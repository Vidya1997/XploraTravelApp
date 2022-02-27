using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xplora.Model;

namespace Xplora.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class frmAddPackage : ContentPage
    {
        public frmAddPackage()
        {
            InitializeComponent();
            Task.Run(AnimateBackground);
            pro_InitialData();
        }
        private async void AnimateBackground()
        {
            Action<double> forward = input => bdGradient.AnchorY = input;
            Action<double> backward = input => bdGradient.AnchorY = input;

            while (true)
            {
                bdGradient.Animate(name: "forward", callback: forward, start: 0, end: 1, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
                bdGradient.Animate(name: "backward", callback: backward, start: 1, end: 0, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
            }
        }
        private async void pro_InitialData()
        {
            List<tblStates> tblStatesList = new List<tblStates>();
            tblStatesList = await App.ent_Database.pro_getStates();
            piStates.ItemsSource = tblStatesList;
        }
        private async void OnpiStateSelectedIndexChanged(object sender, EventArgs e)
        {
            int l_placeid = ((tblStates)piStates.SelectedItem).fldID;
            if (l_placeid > 0)
            {
                List<tblDistricts> tblDistricts = await App.ent_Database.pro_getDistricts();
                piDistricts.ItemsSource = tblDistricts.FindAll(x => x.fldStateID == l_placeid);
            }
        }

        private async void OnpiDistrictsIndexChanged(object sender, EventArgs e)
        {
            int l_placeid = ((tblDistricts)piDistricts.SelectedItem).fldID;
            piPlaces.ItemsSource = null;
            List<tblPlaces> tblPlaces = new List<tblPlaces>();
            tblPlaces = await App.ent_Database.pro_getPlaces();
            tblPlaces = tblPlaces.FindAll(x => x.fldDistrictID == l_placeid);
            piPlaces.ItemsSource = tblPlaces;
        }

        private void OnpiPlacesIndexChanged(object sender, EventArgs e)
        {

        }

        private async void OnbtnSubmitClicked(object sender, EventArgs e)
        {
            
            List<tblPackage> tblPackages = new List<tblPackage>();
            tblPackages = await App.ent_Database.pro_getPackage();
            int id = 0;
            if(tblPackages.Exists(x=> x.fldPlaceId == ((tblPlaces)piPlaces.SelectedItem).fldID))
            {
                id = tblPackages.Find(x => x.fldPlaceId == ((tblPlaces)piPlaces.SelectedItem).fldID).fldId;
                tblPackage tblPackage = new tblPackage()
                {
                    fldId = id,
                    fldDiscount = Convert.ToDouble(txtdiscount.Text?.Trim()),
                    fldPackageAmount = Convert.ToDouble(txtPackageAmt.Text?.Trim()),
                    fldPlaceId = ((tblPlaces)piPlaces.SelectedItem).fldID,
                    fldServiceCharge = Convert.ToDouble(txtServiceCharge.Text?.Trim()),
                    fldTotalTaxes = Convert.ToDouble(txtServiceCharge.Text?.Trim())
                };
                await App.ent_Database.pro_UpdatePackage(tblPackage);
            }
            else
            {
                tblPackage tblPackage = new tblPackage()
                {
                    
                    fldDiscount = Convert.ToDouble(txtdiscount.Text?.Trim()),
                    fldPackageAmount = Convert.ToDouble(txtPackageAmt.Text?.Trim()),
                    fldPlaceId = ((tblPlaces)piPlaces.SelectedItem).fldID,
                    fldServiceCharge = Convert.ToDouble(txtServiceCharge.Text?.Trim()),
                    fldTotalTaxes = Convert.ToDouble(txtServiceCharge.Text?.Trim())
                };
                await App.ent_Database.pro_savePackage(tblPackage);
            }
            await DisplayAlert("Success!", "Saved Successfully", "OK");
            await Navigation.PopAsync();
        }

        private async void OnbtnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
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
    public partial class frmRestaurants : ContentPage
    {
        public frmRestaurants()
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
            cltvCollectionView.ItemsSource = null;
            List<tblRestaurants> tblRestaurants = new List<tblRestaurants>();
            tblRestaurants = await App.ent_Database.pro_getRestaurants();
            tblRestaurants = tblRestaurants.FindAll(x => x.fldDistrictID == l_placeid);
            cltvCollectionView.ItemsSource = tblRestaurants;
        }
    }
}
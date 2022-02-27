using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xplora.Controller;
using Xplora.Model;

namespace Xplora.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class frmReviews : ContentPage
    {
        public frmReviews()
        {
            InitializeComponent();
            
            pro_InitialData();
        }
        
        private async void pro_InitialData()
        {
            List<tblUserPlaces> tblUserPlaces = new List<tblUserPlaces>();
            tblUserPlaces = await App.ent_Database.pro_getUserPlaces();
            tblUserPlaces = tblUserPlaces.FindAll(x => x.fldCustId == clsStaticClass.p_tblUsers.fldId);
            piPlaces.ItemsSource = tblUserPlaces;
            List<tblStates> tblStatesList = new List<tblStates>();
            tblStatesList = await App.ent_Database.pro_getStates();
            piStates.ItemsSource = tblStatesList;
        }
        private async void OnbtnSubmitClicked(object sender, EventArgs e)
        {
            tblReviews tblReviews = new tblReviews()
            {
                fldCustID = clsStaticClass.p_tblUsers.fldId,
                fldPlaceID = ((tblUserPlaces)piPlaces.SelectedItem).fldPlaceId,
                fldRating = Convert.ToInt32(piRatings.SelectedItem.ToString()),
                fldReview = txtReview.Text?.Trim()
            };
            await App.ent_Database.pro_saveReview(tblReviews);
            await DisplayAlert("Success!", "Review Saved", "OK");
            await Navigation.PopAsync();
        }

        private async void OnbtnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
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
            if (l_placeid > 0)
            {
                List<tblPlaces> tblPlaces = await App.ent_Database.pro_getPlaces();
                piPlaces1.ItemsSource = tblPlaces.FindAll(x => x.fldDistrictID == l_placeid);
            }
        }

        private async void OnpiPlacesIndexChanged(object sender, EventArgs e)
        {
            cltvReviews.ItemsSource = null;
            int l_placeid = ((tblPlaces)piPlaces1.SelectedItem).fldID;
            if (l_placeid > 0)
            {
                List<tblReviews> tblReviews = await App.ent_Database.pro_getReviews();
                cltvReviews.ItemsSource = tblReviews.FindAll(x => x.fldPlaceID == l_placeid);
            }
        }
    }
}
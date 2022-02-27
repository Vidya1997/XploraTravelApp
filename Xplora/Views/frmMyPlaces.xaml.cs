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
    public partial class frmMyPlaces : ContentPage
    {
        public frmMyPlaces()
        {
            InitializeComponent();
            pro_MyPlaces();
        }
        private async void pro_MyPlaces()
        {
            cltvCollectionView.ItemsSource = null;
            List<tblUserPlaces> UsersPlaceList = await App.ent_Database.pro_getUserPlaces();
            cltvCollectionView.ItemsSource = UsersPlaceList.FindAll(x => x.fldCustId == clsStaticClass.p_tblUsers.fldId);
        }

        private async void OnbtnAddClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new frmPlaces(2));
        }

        private async void OncltvCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bool answer = await DisplayAlert("Alert!", "Are you sure you want to delete?", "Yes", "No");
            if(answer==true)
            {
                tblUserPlaces tblUserPlaces_o = (tblUserPlaces)e.CurrentSelection.FirstOrDefault();
                await App.ent_Database.pro_DeletePlaces(tblUserPlaces_o);
                pro_MyPlaces();
            }
            else
            {

            }

        }
    }
}
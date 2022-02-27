using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xplora.Controller;
using Xplora.Model;

namespace Xplora.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class frmDashboard : ContentPage
    {
        public frmDashboard()
        {
            InitializeComponent();
            Task.Run(AnimateBackground);
            new clsInitialValuestoDB();
            pro_InitialView();
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
        private async void pro_InitialView()
        {
            List<tblUserDetails> tblUserDetails = new List<tblUserDetails>();
            tblUserDetails = await App.ent_Database.pro_getUserDetails();
            lblUserName.Text = "Welcome " + tblUserDetails.Find(x => x.fldUserId == clsStaticClass.p_tblUsers.fldId).fldName;
        }
        private async void OnbtnPlacesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new frmPlaces(2));
        }

        private async void OnbtnPlacesNearClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new frmRestaurants());
        }

        private async void OnbtnMyPlacesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new frmMyPlaces());
        }

        private async void OnbtnReviewsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new frmReviews());
        }

        private async void OnbtnLocationClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new frmMyLocation());
        }

        private async void OnbtnOlaClicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://www.olacabs.com/");
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }

        private async void OnbtnUberClicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://m.uber.com/v0/looking#_");
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }

        private async void OnbtnLogoutClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new frmLogin());
        }
    }
}
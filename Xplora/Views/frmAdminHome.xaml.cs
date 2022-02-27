using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xplora.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class frmAdminHome : ContentPage
    {
        public frmAdminHome()
        {
            InitializeComponent();
        }

        private async void OnbtnViewPlacesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new frmPlaces(1));
        }

        private async void OnbtnAddPackages(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new frmAddPackage());
        }
    }
}
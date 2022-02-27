using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Threading;

namespace Xplora.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class frmMap : ContentPage
    {
        CancellationTokenSource cts;
        public frmMap()
        {
            InitializeComponent();
            //pro_DisplayMap();
        }
        private async void pro_DisplayMap()
        {
            var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
            cts = new CancellationTokenSource();
            var location = await Geolocation.GetLocationAsync(request, cts.Token);

            Position position = new Position(location.Latitude, location.Longitude);
            MapSpan mapSpan = new MapSpan(position, 0.01, 0.01);
            Xamarin.Forms.Maps.Map map = new Xamarin.Forms.Maps.Map(mapSpan);
        }
    }
}
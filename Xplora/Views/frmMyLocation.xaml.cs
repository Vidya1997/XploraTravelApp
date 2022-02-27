using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xplora.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class frmMyLocation : ContentPage
    {
        CancellationTokenSource cts;

        public frmMyLocation()
        {
            InitializeComponent();
            pro_GetLocation();
        }
        private async void pro_GetLocation()
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                cts = new CancellationTokenSource();
                var location = await Geolocation.GetLocationAsync(request, cts.Token);

                if (location != null)
                {
                    var placemarks = await Geocoding.GetPlacemarksAsync(location.Latitude, location.Longitude);

                    var placemark = placemarks?.FirstOrDefault();
                    if (placemark != null)
                    {
                        txtAreacode.Text ="Admin Area : "+ placemark.AdminArea;
                        txtCountryCode.Text = "Country Code : " + placemark.CountryCode;
                        txtCountryName.Text = "Country Name : " + placemark.CountryName;
                        txtFeatureName.Text = "Feature Name : " + placemark.FeatureName;
                        txtLatitude.Text = "Latitude : " + location.Latitude.ToString();
                        txtLocality.Text = "Locality : " + placemark.Locality;
                        txtLongitude.Text = "Longitude : " + location.Longitude.ToString();
                        txtPostalcode.Text = "Postal Code : " + placemark.PostalCode;
                        txtSubAdminArea.Text = "Sub Admin Area : " + placemark.SubAdminArea;
                        txtSubLocality.Text= "Sub Locality : " + placemark.SubLocality;
                        txtSubThoroughfare.Text = "Sub Thorough Fare : " + placemark.SubThoroughfare;
                        txtThoroughfare.Text = "Thorough Fare : " + placemark.Thoroughfare;
                        
                    }
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
        }
    }
}
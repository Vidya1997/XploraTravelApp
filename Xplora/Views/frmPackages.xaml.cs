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
    public partial class frmPackages : ContentPage
    {
        public tblPlaces p_tblPlaces;
        tblPackage p_tblPackage = new tblPackage();
        int p_Type;
        public frmPackages(tblPlaces tblPlaces, int a_Type)
        {
            InitializeComponent();
            p_tblPlaces = tblPlaces;
            pro_InitialScreen();
            p_Type = a_Type;
        }
        private async void pro_InitialScreen()
        {
            if (p_Type == 1)
            {

                btnSubmit.IsVisible = false;
                btnCancel.IsVisible = false;
            }
            else
            {
                btnSubmit.IsVisible = true;
                btnCancel.IsVisible = true;
            }
            txtPlaceName.Text = p_tblPlaces.fldName;
            
            List<tblPackage> lstPackages = new List<tblPackage>();
            lstPackages = await App.ent_Database.pro_getPackage();
            p_tblPackage=lstPackages.Find(x=> x.fldPlaceId == p_tblPlaces.fldID);
            if(p_tblPackage!=null)
            {
                txtDiscount.Text = p_tblPackage.fldDiscount.ToString();
                txtPackageAmount.Text= p_tblPackage.fldPackageAmount.ToString();
                txtServiceCharge.Text= p_tblPackage.fldServiceCharge.ToString();
                txtTotalTaxes.Text = p_tblPackage.fldTotalTaxes.ToString();
                pro_Calc();
            }
        }
        private void pro_Calc()
        {
            double packageamt = Convert.ToDouble(txtPackageAmount.Text?.Trim());
            double disc= Convert.ToDouble(txtDiscount.Text?.Trim());
            double serv = Convert.ToDouble(txtServiceCharge.Text?.Trim());
            double tax = Convert.ToDouble(txtTotalTaxes.Text?.Trim());
            int noofper = Convert.ToInt32(txtNoofPersons.Text?.Trim());
            
            double grantotal = packageamt + (packageamt * tax / 100.0);
            grantotal += packageamt * serv / 100.0;
            txtTotalAmount.Text = grantotal.ToString();
            grantotal = grantotal - disc;
            grantotal = grantotal * noofper;
            txtGrandTotal.Text = grantotal.ToString();

        }
        private async void OnbtnSubmitClicked(object sender, EventArgs e)
        {
            
            if (p_Type == 2)
            {
                tblUserPlaces tblUserPlaces = new tblUserPlaces()
                {
                    fldCustId = clsStaticClass.p_tblUsers.fldId,
                    fldGrandTotal = Convert.ToDouble(txtGrandTotal.Text?.Trim()),
                    fldnoofpresons = Convert.ToInt32(txtNoofPersons.Text?.Trim()),
                    fldtblplace = p_tblPlaces.fldName,
                    fldtblPackage = p_tblPackage.fldPackageAmount,
                    fldPckId=p_tblPackage.fldId,
                    fldDate=dtDayofJourney.Date.ToString("d"),
                    fldPlaceId=p_tblPlaces.fldID
                };
                await App.ent_Database.pro_saveUserPlaces(tblUserPlaces);
                await DisplayAlert("Alert!", "Saved Successfully", "OK");
                await Navigation.PushAsync(new frmDashboard());
            }
            if(p_Type == 3)
            {
                await DisplayAlert("Alert!", "Login To Continue", "OK");
                await Navigation.PopToRootAsync();
            }
        }

        private async void OnbtnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void OntxtNoofPersonsTextChanged(object sender, TextChangedEventArgs e)
        {
            txtGrandTotal.Text = (Convert.ToDouble(txtGrandTotal.Text?.Trim()) * Convert.ToInt32(txtNoofPersons.Text?.Trim())).ToString();
        }

        private void OnbtnDecrementClicked(object sender, EventArgs e)
        {
            int l_no = Convert.ToInt32(txtNoofPersons.Text?.Trim());
            if(l_no>1)
            {
                l_no--;
            }
            txtNoofPersons.Text = l_no.ToString();
        }

        private void OnbtnIncrementClicked(object sender, EventArgs e)
        {
            int l_no = Convert.ToInt32(txtNoofPersons.Text?.Trim());
            if (l_no >= 1)
            {
                l_no++;
            }
            txtNoofPersons.Text = l_no.ToString();
        }
    }
}
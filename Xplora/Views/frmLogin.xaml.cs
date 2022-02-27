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
    public partial class frmLogin : ContentPage
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void OnbtnLoginClicked(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Admin" && txtPassword.Text == "Admin")
            {
                await Navigation.PushAsync(new frmAdminHome());
            }
            else
            {
                List<tblUsers> tblUserssList = new List<tblUsers>();
                tblUserssList = await App.ent_Database.pro_getUsers();
                bool l_checkUser = tblUserssList.Exists(x => x.fldUsername == txtUserName.Text?.Trim());
                int i = 0;
                if (l_checkUser == true)
                {
                    i = tblUserssList.Find(x => x.fldUsername == txtUserName.Text?.Trim()).fldId;
                }
                else
                {
                    await DisplayAlert("Alert!", "UserName doesnot exists", "OK");
                }

                if (i != 0)
                {
                    string l_password = tblUserssList.Find(x => x.fldId == i).fldPwd;
                    if (txtPassword.Text?.Trim() == l_password)
                    {
                        await DisplayAlert("Sucess!", "Logged IN", "OK");
                        clsStaticClass.p_tblUsers = tblUserssList.Find(x => x.fldId == i);
                        bool l_First = tblUserssList.Find(x => x.fldId == i).fldFirst;
                        if (l_First == true)
                        {
                            await Navigation.PushAsync(new frmUserDetails());
                        }
                        else
                        {
                            await Navigation.PushAsync(new frmDashboard());
                        }
                    }
                    else
                    {
                        await DisplayAlert("Alert!", "Please enter the correct password", "OK");
                    }
                }
            }
        }

        private async void OnbtnNewUserClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new frmUserCreation());
        }

        private async void OnbtnGuestClicked(object sender, EventArgs e)
        {
            new clsInitialValuestoDB();
            await Navigation.PushAsync(new frmPlaces(3));//3
        }
    }
}
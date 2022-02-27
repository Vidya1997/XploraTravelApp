using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xplora.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xplora.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class frmUserCreation : ContentPage
    {
        public frmUserCreation()
        {
            InitializeComponent(); //buttons,all components
            Task.Run(AnimateBackground); //bgcolour animate function
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
        private bool pro_ValidatePassword(string passWord)
        {
            int l_validConditions = 0;
            foreach (char c in passWord)
            {
                if (c >= 'a' && c <= 'z')
                {
                    l_validConditions++;
                    break;
                }
            }
            foreach (char c in passWord)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    l_validConditions++;
                    break;
                }
            }
            if (l_validConditions == 0) return false;
            foreach (char c in passWord)
            {
                if (c >= '0' && c <= '9')
                {
                    l_validConditions++;
                    break;
                }
            }
            if (l_validConditions == 1) return false;
            if (l_validConditions == 2)
            {
                char[] special = { '!', '@', '#', '$', '%', '^', '&', '*' };
                if (passWord.IndexOfAny(special) == -1) return false;
            }
            return true;
        }
        private async void OnbtnSubmitClicked(object sender, EventArgs e)
        {

            if (txtUserName.Text?.Trim() == "" && String.IsNullOrWhiteSpace(txtUserName.Text?.Trim()) && txtPassword.Text?.Trim() == "" && String.IsNullOrWhiteSpace(txtPassword.Text?.Trim()))
            {
                await DisplayAlert("Alert!", "Enter all the fields", "OK");
            }
            else
            {
                if (txtPassword.Text?.Trim() != txtConfirmPassword.Text?.Trim())
                {
                    await DisplayAlert("Alert!", "Password does not match", "OK");
                }
                else
                {
                    bool l_PswrdRight = pro_ValidatePassword(txtConfirmPassword.Text?.Trim());
                    if (l_PswrdRight == true)
                    {
                        tblUsers tblUsers = new tblUsers()
                        {

                            fldUsername = txtUserName.Text?.Trim(),
                            fldPwd = txtConfirmPassword.Text?.Trim(),
                            fldFirst=true
                        };
                        await App.ent_Database.pro_saveUser(tblUsers);
                        await DisplayAlert("Successfully", "saved", "OK");
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        txtConfirmPassword.Text = "";
                        await Navigation.PushAsync(new frmLogin());
                    }
                    else
                    {
                        await DisplayAlert("Alert!", "Password should contain atleast one uppercase letter, one lowercase letter, one digit and one special character(!,@,#,$,%,^,&,*)", "OK");
                    }
                }
            }


        }
    
    }
}
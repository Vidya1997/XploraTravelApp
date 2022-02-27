using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xplora.Controller;
using Xplora.Model;

namespace Xplora.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class frmUserDetails : ContentPage
    {
        string otp = string.Empty;
        string otpt;
        public frmUserDetails()
        {
            InitializeComponent();
        }
        private void GenerateOtp()
        {
            string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string small_alphabets = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "1234567890";
            string characters = numbers;
            characters += alphabets + small_alphabets + numbers;
            int length = 5;
            for (int i = 0; i < length; i++)
            {
                string character = string.Empty;
                do
                {
                    int index = new Random().Next(0, characters.Length);
                    character = characters.ToCharArray()[index].ToString();
                } while (otp.IndexOf(character) != -1);
                otp += character;
            }

            otpt = otp;
        }

        private async void OnbtnSubmitClicked(object sender, EventArgs e)
        {
            if (otpt != txtOtp.Text?.Trim())
            {
                await DisplayAlert("Alert!", "OTP doesnot match", "OK");
            }
            else {
                if (txtName.Text?.Trim() == "" && String.IsNullOrWhiteSpace(txtName.Text?.Trim()) && piGender.SelectedIndex <= -1 && String.IsNullOrWhiteSpace(txtPhoneNo.Text?.Trim()) && String.IsNullOrWhiteSpace(txtEmail.Text?.Trim()))
                {
                    await DisplayAlert("Alert!", "Enter all the fields", "OK");
                }
                else
                {

                    tblUserDetails tblUserDetails = new tblUserDetails()
                    {
                        fldDob = dtDob.Date.ToString("d"),
                        fldName = txtName.Text?.Trim(),
                        fldEmail = txtEmail.Text?.Trim(),
                        fldGender = piGender.SelectedIndex,
                        fldGenderName = piGender.SelectedItem.ToString(),
                        fldPhone = txtPhoneNo.Text?.Trim(),
                        fldUserId = clsStaticClass.p_tblUsers.fldId
                    };
                    await App.ent_Database.pro_saveUserDetails(tblUserDetails);
                    int id = clsStaticClass.p_tblUsers.fldId;
                    tblUsers tblUsers = new tblUsers()
                    {
                        fldId = clsStaticClass.p_tblUsers.fldId,
                        fldFirst = false,
                        fldPwd = clsStaticClass.p_tblUsers.fldPwd,
                        fldUsername = clsStaticClass.p_tblUsers.fldUsername
                    };
                    List<tblUsers> tblUserssList = new List<tblUsers>();
                    tblUserssList = await App.ent_Database.pro_getUsers();
                    clsStaticClass.p_tblUsers = tblUserssList.Find(x => x.fldId == id);
                    await App.ent_Database.pro_UpdateUser(tblUsers);
                    await Navigation.PushAsync(new frmDashboard());
                }

            }
        }

        private async void OnbtnGetOTPClicked(object sender, EventArgs e)
        {
            btnGetOTP.IsEnabled = false;
            if (!string.IsNullOrEmpty(txtEmail.Text?.Trim()))
            {
                GenerateOtp();
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("vvidyavd.mca19@rvce.edu.in");
                msg.To.Add(txtEmail.Text?.Trim());
                msg.Subject = "One Time Password";
                msg.Body = ("Your One Time Password is : " + otpt + "<br/><br/>");
                msg.IsBodyHtml = true;
                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntwd = new NetworkCredential();
                ntwd.UserName = "vvidyavd.mca19@rvce.edu.in"; //Your Email ID
                ntwd.Password = "Welcome123*"; // Your Password
                smt.UseDefaultCredentials = false;
                smt.Credentials = ntwd;
                smt.Port = 587;
                smt.EnableSsl = true;
                smt.Send(msg);
                btnSubmit.IsEnabled = true;
            }
            else
            {
                await DisplayAlert("Alert!", "Enter Email Id", "OK");
            }
        }
    }
}
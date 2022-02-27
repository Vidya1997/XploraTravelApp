using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xplora.Controller;
using Xplora.Views;

namespace Xplora
{
    public partial class App : Application
    {
        static clsDatabaseLayer db_Database;
        public static clsDatabaseLayer ent_Database
        {
            get
            {
                if (db_Database == null)
                {
                    db_Database = new clsDatabaseLayer(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "xplora.db3"));
                }
                return db_Database;
            }
        }
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "Shapes_Experimental", "MediaElement_Experimental" });
            MainPage = new NavigationPage(new frmLogin());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

using Ejercicio1_4PMO2.Controllers;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1_4PMO2
{
    public partial class App : Application
    {
        static EmpleadosDB basedatos;

        public static EmpleadosDB BaseDatos
        {
            get
            {
                if (basedatos == null)
                {
                    basedatos = new EmpleadosDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "EmpleadosDB.db3"));
                }
                return basedatos;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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

using Ejercicio1_4PMO2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1_4PMO2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListEmple : ContentPage
    {
        public ListEmple()
        {
            InitializeComponent();
        }

        private async void listapersonas_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var persona = (Empleados)e.Item;
            VerImagen page = new VerImagen();
            page.BindingContext = persona;
            await Navigation.PushAsync(page);
        }

        private async void toolmenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listapersonas.ItemsSource = await App.BaseDatos.obtenerListaEmple();
        }
    }
}
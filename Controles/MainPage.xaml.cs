using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Controles
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dtp.Date = DateTime.Now;
            dtp.MinimumDate = new DateTime(1990,01,01);
            dtp.MaximumDate = new DateTime(2020, 06, 15);
            dtp.DateSelected += Dtp_DateSelected;
        }

        private void Dtp_DateSelected(object sender, DateChangedEventArgs e)
        {
            DisplayAlert("Fecha", e.NewDate.ToString(), "Cerrar");
        }

        private void Button_Clicked(object sender, EventArgs e) {
            DisplayAlert("Aviso", "Sus datos se han registrado correctamente", "Aceptar");
        }

    }
}

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

        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valorSeleccionado = picker.SelectedItem.ToString();
            DisplayAlert("picker", valorSeleccionado, "Cerrar");
        }

        private void btnSimulador_Clicked(object sender, EventArgs e)
        {
            progres.ProgressTo(.1, 250, Easing.Linear);
        }

        private void Buscar_SearchButtonPressed(object sender, EventArgs e)
        {
            DisplayAlert("Buscando", "Buscando resutlados", "Cerrar");
        }
    }
}

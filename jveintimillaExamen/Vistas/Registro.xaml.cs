using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jveintimillaExamen.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string user)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario:" + user;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double costo = 4000;
            var interes = 4000 * 0.05;
            var montoInicial = Convert.ToDouble(txtMinicial.Text);
            if (montoInicial <= 3999)
            {
                txtPmensual.Text = (((costo - montoInicial) / 5) + interes).ToString();
                btnGuardar.IsEnabled = true;
            }
            else
            {
                DisplayAlert("El valor ingresado excede el limite permitido", "Ingrese el valor correctamente", "Salir");
                txtMinicial.Text = string.Empty;
            }

        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                DisplayAlert("Información", "Guardada correctamente", "ok");
                Navigation.PushAsync(new Resumen(lblUsuario.Text, txtNombre.Text, txtMinicial.Text, txtPmensual.Text));
            }
            else
            {
                DisplayAlert("Información", "Ingrese el nombre", "ok");
            }
        }

    }
}
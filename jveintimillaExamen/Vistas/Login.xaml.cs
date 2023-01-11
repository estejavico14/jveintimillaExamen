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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var usuario = txtUsuario.Text;
                var pass = txtContraseña.Text;

                if (usuario == "estudiante2023" && pass == "uisrael2023")
                {

                    DisplayAlert("Usuario", "Usuario Conectado", "OK");
                    Navigation.PushAsync(new Registro(usuario));


                }
                else
                {
                   
                    DisplayAlert("Usuario", "Usuario o contraseña incorrecta", "Salir");


                }



            }
            catch (Exception)
            {

                throw;
            }
        }
        
    }
}
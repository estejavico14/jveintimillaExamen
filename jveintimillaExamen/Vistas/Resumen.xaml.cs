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
    public partial class Resumen : ContentPage
    {
        public Resumen()
        {
            InitializeComponent();
        }

        private void btnAcerca_Clicked(object sender, EventArgs e)
        {

        }
    }
}
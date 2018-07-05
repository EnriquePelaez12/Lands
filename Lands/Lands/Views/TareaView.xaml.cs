using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lands.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TareaView : ContentPage
	{
		public TareaView ()
		{
			InitializeComponent ();
		}

        DateTime ultima;

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            ultima = e.NewDate;
            var fechamostrar = e.NewDate.ToString("D");
            DisplayAlert("Selector de fechas", fechamostrar, "Aceptar");

        }

      
    }
}
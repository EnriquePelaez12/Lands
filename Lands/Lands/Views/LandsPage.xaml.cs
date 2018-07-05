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
	public partial class LandsPage : ContentPage
	{

        public LandsPage ()
		{
			InitializeComponent ();
            btnAgregarNuevo.Clicked += btnAgregarNuevo_Clicked;
        }
        private void btnAgregarNuevo_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ListaTareasView());
        }

    }
}
using Lands.ViewModels;
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
	public partial class ListaTareasView : ContentPage
	{
		public ListaTareasView ()
		{
			InitializeComponent ();
            this.BindingContext = new ListaTareasViewModel();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaTareasViewModel viewModel = this.BindingContext as ListaTareasViewModel;
            if (viewModel != null)
            {
                viewModel.ActualizarComando.Execute(null);
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}

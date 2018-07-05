
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Lands
{
    using Lands.Views;
    using Xamarin.Forms;

    public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            //MainPage = new NavigationPage(new ListaTareasView());
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

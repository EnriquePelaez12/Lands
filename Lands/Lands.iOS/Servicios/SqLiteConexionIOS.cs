using System.IO;
using Lands.iOS.Servicios;
using Lands.Services;
using SQLite;
[assembly: Xamarin.Forms.Dependency(typeof(SqLiteConexionIOS))]
namespace Lands.iOS.Servicios
{
    public class SqLiteConexionIOS : ISqLiteConexion
    {

        public SQLiteConnection ConexionBaseDatos()
        {
            string nombreBaseDatos = "ListaTareas2.db3";
            string rutaFisica = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "..", "Library", nombreBaseDatos);
            return new SQLiteConnection(rutaFisica);
        }
    }
}
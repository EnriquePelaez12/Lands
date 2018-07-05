using System.IO;
using Lands.Droid.Servicios;
using Lands.Services;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(SqLiteConexionAndroid))]
namespace Lands.Droid.Servicios
{
    public class SqLiteConexionAndroid: ISqLiteConexion
    {
        public SQLiteConnection ConexionBaseDatos()
    {
        string nombreBaseDatos = "ListaTareas2.db3";
        string rutaFisica = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), nombreBaseDatos);
        return new SQLiteConnection(rutaFisica);
    }

}
}
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.Services
{
    public  interface ISqLiteConexion
    {
        SQLiteConnection ConexionBaseDatos();
    }
}

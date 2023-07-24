using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CapaDatos
{
    public class Sistema_Conexion
    {
        public static string miconexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MT\workbench\Miproyecto\Inscripcion_MT\Inscripcion2\CapaDatos\CapaDatos.mdf;Integrated Security=True";

        public SqlConnection dbconexion = new SqlConnection(miconexion);
    }
}

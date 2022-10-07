using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//agregar
using System.Data.SqlClient;

namespace Sistema.Datos
{
    class Conexion
    {
        private static Conexion Con = null;

        private Conexion()
        {

        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Data Source=DESKTOP-6A9C73D\\EDWARD; Initial Catalog=dbsistema;Integrated Security=True";
            }
            catch(Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if(Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}

using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjAccesoBD
{
    public class conexion
    {

        public SqlConnection conexionMSQL { get; set; }

       // private string cadenaConexion;


        //public void conexionServidor(string serv, string inst)
        //{
        //    string nombreServidor = serv;//"PERSONALHOGAR";
        //    string nombreInstancia = inst;//"SQL2016";
        //    string nombreBaseDatos = "proyecto";


        //    if (nombreInstancia != null)
        //    {
        //        nombreServidor = nombreServidor + @"\" + nombreInstancia;

        //    }
        //    cadenaConexion = "Data Source=" + nombreServidor
        //                    + "; Initial Catalog=" + nombreBaseDatos
        //                    + "; User Id=" + usuario
        //                    + "; Password=" + contrasena
        //                    + "Integrated Security=True;";

        //    this.conexionMSQL = new SqlConnection(cadenaConexion);
        //    "Data Source=PERSONALHOGAR\\SQL2016;Initial Catalog=Proyecto;Integrated Security=True";


        //}

    }
}

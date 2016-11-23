using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjAccesoBD
{

    public class clsConexion
    {
        public SqlConnection scnConexion;
        public SqlCommand scmComando;
        public SqlDataReader dtrInfodelSelect;
        public SqlDataAdapter sdaInfoSelectMultiple;
        public DataTable dttCargaSelectMutiple = new DataTable();

        public string srtconexion = "";//"Data Source=PERSONALHOGAR\\SQL2016;Initial Catalog=Proyecto;Integrated Security=True";

        public void conexionServidor(string serv, string inst)
        {
            string nombreServidor = serv;//"PERSONALHOGAR";
            string nombreInstancia = inst;//"SQL2016";
            string nombreBaseDatos = "proyecto;";


            if (nombreInstancia != null)
            {
                nombreServidor = nombreServidor + @"\" + nombreInstancia;

            }
            srtconexion = "Data Source=" + nombreServidor
                            + "; Initial Catalog=" + nombreBaseDatos
                            //+ "; User Id=" + usuario
                            //+ "; Password=" + contrasena
                            + "Integrated Security=True;";
        }
         public void ConexionBD(string srtconexion)
        {
            scnConexion = new SqlConnection(srtconexion);
            try
            {
                scnConexion.Open();
                // MsgBox("Conexion Exitosa", 6, "Mensaje")
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        public void CierraConexionBD()
        {
            try
            {
                scnConexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        //con esta funcion BuscarconSelect, ella consulta a la BD a partir del select que le inyecto
        public void BuscarconSelect(string srtSentencia)
        {
            SqlCommand scmComando = default(SqlCommand);
            scmComando = new SqlCommand();
            scmComando.Connection = scnConexion;
            scmComando.CommandType = CommandType.Text;
            scmComando.CommandText = srtSentencia;
            //Esta es la sentencia del Select que estoy haciendo
            dtrInfodelSelect = scmComando.ExecuteReader();
        }


        public void General(string sComando)
        {
            scmComando = new SqlCommand();
            scmComando.Connection = scnConexion;
            scmComando.CommandType = CommandType.Text;
            scmComando.CommandText = sComando;
            scmComando.ExecuteNonQuery();
        }


        //con esta funcion BuscarconSelect, ella consulta a la BD a partir del select que le inyecto
        public void BuscarMultiple(string srtSentencia)
        {

            SqlCommand scmComando = default(SqlCommand);
            scmComando = new SqlCommand();
            scmComando.Connection = scnConexion;
            scmComando.CommandType = CommandType.Text;
            scmComando.CommandText = srtSentencia;
            //Esta es la sentencia del Select que estoy haciendo
            sdaInfoSelectMultiple = new SqlDataAdapter(scmComando);
            dttCargaSelectMutiple = new DataTable();
            sdaInfoSelectMultiple.Fill(dttCargaSelectMutiple);

        }
    }
}
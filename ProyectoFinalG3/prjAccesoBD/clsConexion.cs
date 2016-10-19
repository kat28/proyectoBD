using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace prjAccesoBD
{
    public class clsConexion
    {
        public SqlConnection scnConexion;
        public SqlCommand scmComando;
        public SqlDataReader dtrInfodelSelect;
        public SqlDataAdapter sdaInfoSelectMultiple;
        public DataTable dttCargaSelectMutiple = new DataTable();

        public string srtconexion = "Data Source=PERSONALHOGAR\\SQL2016;Initial Catalog=Proyecto;Integrated Security=True";

        public void ConexionBD(string strConexion)
        {
            scnConexion = new SqlConnection(strConexion);
            try
            {
                scnConexion.Open();
                // MsgBox("Conexion Exitosa", 6, "Mensaje")
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al conectar a la BD : ", ex);

                //MessageBox.show("Error al conectar a la BD : " + ex.ToString, 2, "Mensaje");
                //MsgBox.Show("Error al conectar a la BD :", ex.ToString)
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
                throw new ApplicationException("Error al conectar a la BD : ", ex);
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

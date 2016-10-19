using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace prjBL
{
    public class clsMetodos
    {
        
        prjAccesoBD.clsConexion FuncionConexion = new prjAccesoBD.clsConexion();
        public string strSentencia;

        public void AccionGeneral(string strSentencia)
        {
            try
            {
                FuncionConexion.ConexionBD(FuncionConexion.srtconexion);
                FuncionConexion.General(strSentencia);
                FuncionConexion.CierraConexionBD();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al conectar a la BD : ", ex);
            }
        }

        public void cargaformulario(ComboBox combobox, string strsentencia)
        {
            try
            {
                FuncionConexion.ConexionBD(FuncionConexion.srtconexion);
                FuncionConexion.BuscarconSelect(strsentencia);
                combobox.Items.Clear();
                combobox.Text = "";



                while (FuncionConexion.dtrInfodelSelect.Read())
                {
                    combobox.Items.Add(FuncionConexion.dtrInfodelSelect.ToString());
                }
                FuncionConexion.dtrInfodelSelect.Close();

                FuncionConexion.CierraConexionBD();

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}

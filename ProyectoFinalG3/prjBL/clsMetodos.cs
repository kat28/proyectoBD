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

        public void CargarNombreServidor(string strNombreServidor, string inst)
        {

            FuncionConexion.conexionServidor(strNombreServidor,inst);
            
        }

        public void cargacombobox(ComboBox combobox, string strsentencia)
        {
            try
            {
                FuncionConexion.ConexionBD(FuncionConexion.srtconexion);
                FuncionConexion.BuscarconSelect(strsentencia);
                combobox.Items.Clear();
                combobox.Text = "";



                while (FuncionConexion.dtrInfodelSelect.Read())
                {
                    combobox.Items.Add(FuncionConexion.dtrInfodelSelect.GetValue(0).ToString());
                }
                FuncionConexion.dtrInfodelSelect.Close();

                FuncionConexion.CierraConexionBD();

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public void cargaVistaArbol(TreeView treeview, string strsentencia, string srtBD)
        {
            try
            {
                FuncionConexion.ConexionBases(FuncionConexion.srtconexion,srtBD);
                FuncionConexion.BuscarconSelect(strsentencia);
                treeview.Nodes.Clear();
                treeview.Text = "";

                while (FuncionConexion.dtrInfodelSelect.Read())
                {


                    TreeNode node = new TreeNode(FuncionConexion.dtrInfodelSelect["tabla"].ToString());
                                      
                   
                    
                    node.Nodes.Add(FuncionConexion.dtrInfodelSelect["columna"].ToString());
                      
                         treeview.Nodes.Add(node);

                    


                 }

                FuncionConexion.dtrInfodelSelect.Close();
                FuncionConexion.CierraConexionBD();

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        //listBox
        public void cargarlists(CheckedListBox checkedlistbox, string strsentencia)
        {
            try
            {
                FuncionConexion.ConexionBD(FuncionConexion.srtconexion);
                FuncionConexion.BuscarconSelect(strsentencia);
                checkedlistbox.Items.Clear();

                while (FuncionConexion.dtrInfodelSelect.Read())
                {
                    checkedlistbox.Items.Add(FuncionConexion.dtrInfodelSelect.GetString(0));

                    //treeview.Nodes.Add(FuncionConexion.dtrInfodelSelect.GetValue(0).ToString());
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
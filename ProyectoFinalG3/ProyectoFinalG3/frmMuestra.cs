using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalG3
{
    public partial class frmMuestra : Form
    {

        prjAccesoBD.clsConexion FuncionConexion = new prjAccesoBD.clsConexion();
        prjBL.clsMetodos FuncionLogica = new prjBL.clsMetodos();
        public string strSentencia;


        public frmMuestra()
        {
           
            InitializeComponent();
        }

        //private void bncargar_Click(object sender, EventArgs e)
        //{
        //    ////cargar descripcion
        //    //try
        //    //{
        //    //    strSentencia = " ";
        //    //    FuncionConexion.ConexionBD(FuncionConexion.srtconexion);
        //    //    strSentencia = "SELECT NumeroPlaca, Marca, Estilo, Cilindrada, Transmision, Combustible, Color, Modelo FROM Autos WHERE IdCategoria= " + cmbTipoAuto.SelectedIndex + " AND Estado = 'disponible'";
        //    //    FuncionConexion.BuscarconSelect(strSentencia);
        //    //    cmbDescripcion.Items.Clear();
        //    //    cmbDescripcion.Text = "";

        //    //    var _with1 = FuncionConexion.dtrInfodelSelect;
        //    //    while (_with1.Read)
        //    //    {
        //    //        cmbDescripcion.Items.Add(_with1.Item(0).ToString() + " , " + _with1.Item(1).ToString + " , " + _with1.Item(2).ToString + " , " + _with1.Item(3).ToString + " cc , " + _with1.Item(4).ToString + " , " + _with1.Item(5).ToString + " , " + _with1.Item(6).ToString + " , " + _with1.Item(7).ToString);
        //    //        //& " ll # Placa:" & .Item(7).ToString)
        //    //    }
        //    //    _with1.Close();
        //    //    FuncionConexion.CierraConexionBD();
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    ex.ToString();
        //    //}


        //}

        private void cbTablas_Click(object sender, EventArgs e)
        {
            strSentencia = "select name from sysobjects where type='U'";
            FuncionLogica.cargaformulario(cbTablas, strSentencia);
        }
    }
}

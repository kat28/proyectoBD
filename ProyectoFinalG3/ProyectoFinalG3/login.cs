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
    public partial class login : Form
    {

        prjAccesoBD.clsConexion FuncionConexion = new prjAccesoBD.clsConexion();
        prjBL.clsMetodos FuncionLogica = new prjBL.clsMetodos();
        public string strSentencia;

        public login()
        {
            InitializeComponent();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            home frm = new home();
            frm.Show();
            
            this.Hide();


    
        }
    }
}
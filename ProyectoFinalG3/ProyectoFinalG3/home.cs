using System;
using System.Windows.Forms;


namespace ProyectoFinalG3
{
    public partial class home : Form
    {

        prjAccesoBD.clsConexion FuncionConexion = new prjAccesoBD.clsConexion();
        prjBL.clsMetodos FuncionLogica = new prjBL.clsMetodos();
        public string strSentencia;


        public home()
        {
            InitializeComponent();
            //strSentencia = "SELECT name FROM master.dbo.sysdatabases WHERE name NOT IN ('master','model','msdb','tempdb')";
            
            strSentencia = "SELECT t.name tabla, c.name columna FROM sys.columns c JOIN sys.tables t ON c.object_id = t.object_id";
            FuncionLogica.cargaVistaArbol(treeViewBD, strSentencia);


            strSentencia = "SELECT name FROM master.dbo.sysdatabases db WHERE name NOT IN ('master','model','msdb','tempdb');";
            FuncionLogica.cargarlists(chboxBD, strSentencia);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            strSentencia = "USE master; SELECT name FROM master.dbo.sysdatabases WHERE name NOT IN ('master','model','msdb','tempdb')";
            FuncionLogica.cargaVistaArbol(treeViewBD, strSentencia);

        }

        private void picAnalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clic");
        }

        private void picBorrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clic");
        }

        private void picEjecutar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clic");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtConsulta.Text = "SELECT nombre_columna,nombre_columna FROM nombre_tabla;";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtConsulta.Text = "DELETE FROM nombre_tabla WHERE nombre_columna = valor;";
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtConsulta.Text = "UPDATE nombre_tabla SET nombre_columna = valor WHERE nombre_columna = algun_valor;";
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            txtConsulta.Text = "INSERT INTO nombre_tabla(nombre_columna1,nombre_columna2,...) VALUES (valor1,valor2,...);";

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picCrearBD_Click(object sender, EventArgs e)
        {
            
            if (txtNuevaBD.Text.Equals("")) {

                MessageBox.Show("Debe escribir el nombre de la nueva base de datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else{
                strSentencia = "SELECT name FROM master.dbo.sysdatabases db WHERE name NOT IN ('master','model','msdb','tempdb');";
                FuncionLogica.cargarlists(chboxBD, strSentencia);
            }
        }
    }
}
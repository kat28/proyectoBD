﻿using System;
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
    public partial class frmInt : Form
    {
        
        prjAccesoBD.clsConexion FuncionConexion = new prjAccesoBD.clsConexion();
        prjBL.clsMetodos FuncionLogica = new prjBL.clsMetodos();
        public string strSentencia;

        public frmInt()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //strSentencia = "select name from sysobjects where type='U'";
            //FuncionLogica.cargaVistaArbol(tv, strSentencia);
        }

        //  private void btnConectar_Click(object sender, EventArgs e)
        //{

        //    string strNombreServidor;
        //    strNombreServidor = txtNombreServidor.Text;

        //    FuncionLogica.CargarNombreServidor(strNombreServidor);

        //    cmbBases.Enabled = true;

        //}

        //private void cmbBases_Click(object sender, EventArgs e)
        //{
        //    strSentencia = "SELECT name FROM master.dbo.sysdatabases WHERE name NOT IN ('master','model','msdb','tempdb')";
        //    FuncionLogica.cargaformulario(cmbBases, strSentencia);
        //}

    }
}

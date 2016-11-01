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
    public partial class MDIPri : Form
    {
        
        public MDIPri()
        {
            InitializeComponent();
        }

        private void conexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    frmMuestra frm = new frmMuestra();
        //    frm.MdiParent = this;
        //    frm.Show();
        }

        private void treeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInt frm = new frmInt();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

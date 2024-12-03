using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_Seg_SBD
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            tssMensagem.Text = Application.ProductName
                + "  Versão: " + Application.ProductVersion;
            tssData.Text = DateTime.Today.ToString();
            this.WindowState = FormWindowState.Maximized;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chamar cadastro de Cliente:
            frmCliente form = new frmCliente();
            form.MdiParent = this;
            form.Show();
        }
    }
}

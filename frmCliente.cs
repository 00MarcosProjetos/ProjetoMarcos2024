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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }


        private void tsbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbIncluir_Click(object sender, EventArgs e)
        {
            grbOpcoes.Visible = true;
            Limpar();

        }

        private void Limpar()
        {
            this.txtCodigo.Clear();
            this.txtNome.Clear();
            this.txtTelefone.Clear();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            // Chamar código para inclusão do cliente:
            Cadastro oCad = new Cadastro();
            oCad.PessoaNome = this.txtNome.Text;
            oCad.PessoaTelefone = this.txtTelefone.Text;
            oCad.Gravar();

            grbOpcoes.Visible = false;
            // Carregar os dados do BD:
            // Carregar()
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grbOpcoes.Visible = false;
            // Carregar os dados do BD:
            // Carregar()
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // Carregar os dados do BD:
            // Carregar()
        }


    }
}

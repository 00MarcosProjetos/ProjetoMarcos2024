namespace _2020_Seg_SBD
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.grbFicha = new System.Windows.Forms.GroupBox();
            this.grbOpcoes = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbIncluir = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAlterar = new System.Windows.Forms.ToolStripButton();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.grbFicha.SuspendLayout();
            this.grbOpcoes.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // grbFicha
            // 
            this.grbFicha.Controls.Add(this.grbOpcoes);
            this.grbFicha.Controls.Add(this.txtTelefone);
            this.grbFicha.Controls.Add(this.txtNome);
            this.grbFicha.Controls.Add(this.txtCodigo);
            this.grbFicha.Controls.Add(this.label3);
            this.grbFicha.Controls.Add(this.label2);
            this.grbFicha.Controls.Add(this.label1);
            this.grbFicha.Location = new System.Drawing.Point(12, 41);
            this.grbFicha.Name = "grbFicha";
            this.grbFicha.Size = new System.Drawing.Size(568, 132);
            this.grbFicha.TabIndex = 0;
            this.grbFicha.TabStop = false;
            this.grbFicha.Text = "Ficha:";
            // 
            // grbOpcoes
            // 
            this.grbOpcoes.Controls.Add(this.btnCancelar);
            this.grbOpcoes.Controls.Add(this.btnGravar);
            this.grbOpcoes.Location = new System.Drawing.Point(479, 3);
            this.grbOpcoes.Name = "grbOpcoes";
            this.grbOpcoes.Size = new System.Drawing.Size(89, 123);
            this.grbOpcoes.TabIndex = 6;
            this.grbOpcoes.TabStop = false;
            this.grbOpcoes.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::WindowsFormsApp1.Properties.Resources.cancel;
            this.btnCancelar.Location = new System.Drawing.Point(9, 62);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 55);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.White;
            this.btnGravar.Image = global::WindowsFormsApp1.Properties.Resources.save;
            this.btnGravar.Location = new System.Drawing.Point(9, 8);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 51);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(84, 84);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(186, 20);
            this.txtTelefone.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(84, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(349, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(84, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbIncluir,
            this.tsbExcluir,
            this.toolStripSeparator1,
            this.tsbAlterar,
            this.tsbFechar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(599, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbIncluir
            // 
            this.tsbIncluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbIncluir.Image")));
            this.tsbIncluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIncluir.Name = "tsbIncluir";
            this.tsbIncluir.Size = new System.Drawing.Size(60, 22);
            this.tsbIncluir.Text = "Incluir";
            this.tsbIncluir.Click += new System.EventHandler(this.tsbIncluir_Click);
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
            this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(62, 22);
            this.tsbExcluir.Text = "Excluir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAlterar
            // 
            this.tsbAlterar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlterar.Image")));
            this.tsbAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlterar.Name = "tsbAlterar";
            this.tsbAlterar.Size = new System.Drawing.Size(62, 22);
            this.tsbAlterar.Text = "Alterar";
            // 
            // tsbFechar
            // 
            this.tsbFechar.Image = ((System.Drawing.Image)(resources.GetObject("tsbFechar.Image")));
            this.tsbFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFechar.Name = "tsbFechar";
            this.tsbFechar.Size = new System.Drawing.Size(62, 22);
            this.tsbFechar.Text = "Fechar";
            this.tsbFechar.Click += new System.EventHandler(this.tsbFechar_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 179);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(568, 178);
            this.dgvDados.TabIndex = 2;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 379);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grbFicha);
            this.Name = "frmCliente";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.grbFicha.ResumeLayout(false);
            this.grbFicha.PerformLayout();
            this.grbOpcoes.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFicha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox grbOpcoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbIncluir;
        private System.Windows.Forms.ToolStripButton tsbExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.ToolStripButton tsbAlterar;
    }
}
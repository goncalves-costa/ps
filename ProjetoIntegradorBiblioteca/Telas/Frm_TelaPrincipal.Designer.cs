namespace ProjetoIntegradorBiblioteca
{
    partial class Frm_TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Mn_Strip = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emprestimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fazerEmprestimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarDevoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leitoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoLeitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acervoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tbc_Principal = new System.Windows.Forms.TabControl();
            this.nomeecodigo = new System.Windows.Forms.Label();
            this.Mn_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mn_Strip
            // 
            this.Mn_Strip.BackColor = System.Drawing.SystemColors.Control;
            this.Mn_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.emprestimosToolStripMenuItem,
            this.leitoresToolStripMenuItem,
            this.livrosToolStripMenuItem,
            this.funcionáriosToolStripMenuItem});
            this.Mn_Strip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.Mn_Strip.Location = new System.Drawing.Point(0, 0);
            this.Mn_Strip.Name = "Mn_Strip";
            this.Mn_Strip.Size = new System.Drawing.Size(800, 23);
            this.Mn_Strip.TabIndex = 0;
            this.Mn_Strip.Text = "menuStrip1";
            this.Mn_Strip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mn_Strip_MouseDown);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // emprestimosToolStripMenuItem
            // 
            this.emprestimosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fazerEmprestimoToolStripMenuItem,
            this.realizarDevoluçãoToolStripMenuItem});
            this.emprestimosToolStripMenuItem.Name = "emprestimosToolStripMenuItem";
            this.emprestimosToolStripMenuItem.Size = new System.Drawing.Size(88, 19);
            this.emprestimosToolStripMenuItem.Text = "Empréstimos";
            this.emprestimosToolStripMenuItem.Click += new System.EventHandler(this.emprestimosToolStripMenuItem_Click);
            // 
            // fazerEmprestimoToolStripMenuItem
            // 
            this.fazerEmprestimoToolStripMenuItem.Name = "fazerEmprestimoToolStripMenuItem";
            this.fazerEmprestimoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.fazerEmprestimoToolStripMenuItem.Text = "Realizar Emprestimo";
            this.fazerEmprestimoToolStripMenuItem.Click += new System.EventHandler(this.fazerEmprestimoToolStripMenuItem_Click);
            // 
            // realizarDevoluçãoToolStripMenuItem
            // 
            this.realizarDevoluçãoToolStripMenuItem.Name = "realizarDevoluçãoToolStripMenuItem";
            this.realizarDevoluçãoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.realizarDevoluçãoToolStripMenuItem.Text = "Realizar Devolução";
            this.realizarDevoluçãoToolStripMenuItem.Click += new System.EventHandler(this.realizarDevoluçãoToolStripMenuItem_Click);
            // 
            // leitoresToolStripMenuItem
            // 
            this.leitoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoLeitorToolStripMenuItem});
            this.leitoresToolStripMenuItem.Name = "leitoresToolStripMenuItem";
            this.leitoresToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.leitoresToolStripMenuItem.Text = "Leitores";
            // 
            // cadastrarNovoLeitorToolStripMenuItem
            // 
            this.cadastrarNovoLeitorToolStripMenuItem.Name = "cadastrarNovoLeitorToolStripMenuItem";
            this.cadastrarNovoLeitorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cadastrarNovoLeitorToolStripMenuItem.Text = "Cadastrar Novo Leitor";
            this.cadastrarNovoLeitorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoLeitorToolStripMenuItem_Click);
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoLivroToolStripMenuItem,
            this.acervoToolStripMenuItem});
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.livrosToolStripMenuItem.Text = "Livros";
            // 
            // cadastrarNovoLivroToolStripMenuItem
            // 
            this.cadastrarNovoLivroToolStripMenuItem.Name = "cadastrarNovoLivroToolStripMenuItem";
            this.cadastrarNovoLivroToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cadastrarNovoLivroToolStripMenuItem.Text = "Cadastrar Novo Livro";
            this.cadastrarNovoLivroToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoLivroToolStripMenuItem_Click);
            // 
            // acervoToolStripMenuItem
            // 
            this.acervoToolStripMenuItem.Name = "acervoToolStripMenuItem";
            this.acervoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.acervoToolStripMenuItem.Text = "Acervo";
            this.acervoToolStripMenuItem.Click += new System.EventHandler(this.acervoToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFuncionárioToolStripMenuItem});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(87, 19);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // cadastrarFuncionárioToolStripMenuItem
            // 
            this.cadastrarFuncionárioToolStripMenuItem.Name = "cadastrarFuncionárioToolStripMenuItem";
            this.cadastrarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cadastrarFuncionárioToolStripMenuItem.Text = "Cadastrar Funcionário";
            this.cadastrarFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFuncionárioToolStripMenuItem_Click);
            // 
            // Tbc_Principal
            // 
            this.Tbc_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Principal.Location = new System.Drawing.Point(0, 23);
            this.Tbc_Principal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.Tbc_Principal.Name = "Tbc_Principal";
            this.Tbc_Principal.SelectedIndex = 0;
            this.Tbc_Principal.Size = new System.Drawing.Size(800, 427);
            this.Tbc_Principal.TabIndex = 1;
            this.Tbc_Principal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tbc_Principal_MouseDown);
            // 
            // nomeecodigo
            // 
            this.nomeecodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeecodigo.AutoSize = true;
            this.nomeecodigo.BackColor = System.Drawing.SystemColors.Control;
            this.nomeecodigo.Location = new System.Drawing.Point(644, 5);
            this.nomeecodigo.Name = "nomeecodigo";
            this.nomeecodigo.Size = new System.Drawing.Size(135, 13);
            this.nomeecodigo.TabIndex = 2;
            this.nomeecodigo.Text = "Funcionário Desconectado";
            // 
            // Frm_TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nomeecodigo);
            this.Controls.Add(this.Tbc_Principal);
            this.Controls.Add(this.Mn_Strip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.Mn_Strip;
            this.Name = "Frm_TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Biblioteca";
            this.Mn_Strip.ResumeLayout(false);
            this.Mn_Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mn_Strip;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emprestimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fazerEmprestimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leitoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoLeitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acervoToolStripMenuItem;
        private System.Windows.Forms.TabControl Tbc_Principal;
        private System.Windows.Forms.ToolStripMenuItem realizarDevoluçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.Label nomeecodigo;
    }
}


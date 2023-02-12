
namespace ProjetoIntegradorBiblioteca.Telas
{
    partial class CadastrodeLivros_UC
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrodeLivros_UC));
            this.Lbl_CadastroLivro = new System.Windows.Forms.Label();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Lbl_Codigo = new System.Windows.Forms.Label();
            this.Txt_Titulo = new System.Windows.Forms.TextBox();
            this.Lbl_TituloLivro = new System.Windows.Forms.Label();
            this.Cmb_Autor = new System.Windows.Forms.ComboBox();
            this.Cmb_Editora = new System.Windows.Forms.ComboBox();
            this.Cmb_Genero = new System.Windows.Forms.ComboBox();
            this.Btn_AdicionarGenero = new System.Windows.Forms.Button();
            this.Lbx_Genero = new System.Windows.Forms.ListBox();
            this.Cmb_Idioma = new System.Windows.Forms.ComboBox();
            this.Txt_Paginas = new System.Windows.Forms.TextBox();
            this.Lbl_LancamentoLivro = new System.Windows.Forms.Label();
            this.Btn_CadastrarAutor = new System.Windows.Forms.Button();
            this.Btn_CadastrarEditora = new System.Windows.Forms.Button();
            this.Btn_CadastrarGenero = new System.Windows.Forms.Button();
            this.Btn_CadastrarIdioma = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Acervo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Lbl_NumeroPag = new System.Windows.Forms.Label();
            this.Lbl_Autor = new System.Windows.Forms.Label();
            this.Lbl_Editora = new System.Windows.Forms.Label();
            this.Lbl_Genero = new System.Windows.Forms.Label();
            this.Lbl_IdiomaOriginal = new System.Windows.Forms.Label();
            this.Lbl_AutorLivro = new System.Windows.Forms.Label();
            this.dtp_lancamento = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_CadastroLivro
            // 
            this.Lbl_CadastroLivro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_CadastroLivro.AutoSize = true;
            this.Lbl_CadastroLivro.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CadastroLivro.Location = new System.Drawing.Point(235, 58);
            this.Lbl_CadastroLivro.Name = "Lbl_CadastroLivro";
            this.Lbl_CadastroLivro.Size = new System.Drawing.Size(337, 44);
            this.Lbl_CadastroLivro.TabIndex = 0;
            this.Lbl_CadastroLivro.Text = "Cadastro de Livro";
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Codigo.Location = new System.Drawing.Point(213, 135);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(437, 20);
            this.Txt_Codigo.TabIndex = 1;
            // 
            // Lbl_Codigo
            // 
            this.Lbl_Codigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Codigo.AutoSize = true;
            this.Lbl_Codigo.Location = new System.Drawing.Point(161, 138);
            this.Lbl_Codigo.Name = "Lbl_Codigo";
            this.Lbl_Codigo.Size = new System.Drawing.Size(46, 13);
            this.Lbl_Codigo.TabIndex = 2;
            this.Lbl_Codigo.Text = "Código: ";
            // 
            // Txt_Titulo
            // 
            this.Txt_Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Titulo.Location = new System.Drawing.Point(211, 163);
            this.Txt_Titulo.Name = "Txt_Titulo";
            this.Txt_Titulo.Size = new System.Drawing.Size(439, 20);
            this.Txt_Titulo.TabIndex = 3;
            // 
            // Lbl_TituloLivro
            // 
            this.Lbl_TituloLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_TituloLivro.AutoSize = true;
            this.Lbl_TituloLivro.Location = new System.Drawing.Point(163, 166);
            this.Lbl_TituloLivro.Name = "Lbl_TituloLivro";
            this.Lbl_TituloLivro.Size = new System.Drawing.Size(38, 13);
            this.Lbl_TituloLivro.TabIndex = 4;
            this.Lbl_TituloLivro.Text = "Título:";
            // 
            // Cmb_Autor
            // 
            this.Cmb_Autor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_Autor.FormattingEnabled = true;
            this.Cmb_Autor.Location = new System.Drawing.Point(210, 215);
            this.Cmb_Autor.Name = "Cmb_Autor";
            this.Cmb_Autor.Size = new System.Drawing.Size(313, 21);
            this.Cmb_Autor.TabIndex = 5;
            // 
            // Cmb_Editora
            // 
            this.Cmb_Editora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_Editora.FormattingEnabled = true;
            this.Cmb_Editora.Location = new System.Drawing.Point(210, 251);
            this.Cmb_Editora.Name = "Cmb_Editora";
            this.Cmb_Editora.Size = new System.Drawing.Size(313, 21);
            this.Cmb_Editora.TabIndex = 9;
            // 
            // Cmb_Genero
            // 
            this.Cmb_Genero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_Genero.FormattingEnabled = true;
            this.Cmb_Genero.Location = new System.Drawing.Point(210, 281);
            this.Cmb_Genero.Name = "Cmb_Genero";
            this.Cmb_Genero.Size = new System.Drawing.Size(265, 21);
            this.Cmb_Genero.TabIndex = 10;
            // 
            // Btn_AdicionarGenero
            // 
            this.Btn_AdicionarGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_AdicionarGenero.Location = new System.Drawing.Point(487, 281);
            this.Btn_AdicionarGenero.Name = "Btn_AdicionarGenero";
            this.Btn_AdicionarGenero.Size = new System.Drawing.Size(36, 23);
            this.Btn_AdicionarGenero.TabIndex = 11;
            this.Btn_AdicionarGenero.Text = "+";
            this.Btn_AdicionarGenero.UseVisualStyleBackColor = true;
            this.Btn_AdicionarGenero.Click += new System.EventHandler(this.Btn_AdicionarGenero_Click);
            // 
            // Lbx_Genero
            // 
            this.Lbx_Genero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbx_Genero.FormattingEnabled = true;
            this.Lbx_Genero.Location = new System.Drawing.Point(210, 309);
            this.Lbx_Genero.Name = "Lbx_Genero";
            this.Lbx_Genero.Size = new System.Drawing.Size(440, 69);
            this.Lbx_Genero.TabIndex = 12;
            // 
            // Cmb_Idioma
            // 
            this.Cmb_Idioma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_Idioma.FormattingEnabled = true;
            this.Cmb_Idioma.Location = new System.Drawing.Point(213, 394);
            this.Cmb_Idioma.Name = "Cmb_Idioma";
            this.Cmb_Idioma.Size = new System.Drawing.Size(310, 21);
            this.Cmb_Idioma.TabIndex = 13;
            // 
            // Txt_Paginas
            // 
            this.Txt_Paginas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Paginas.Location = new System.Drawing.Point(481, 189);
            this.Txt_Paginas.Name = "Txt_Paginas";
            this.Txt_Paginas.Size = new System.Drawing.Size(168, 20);
            this.Txt_Paginas.TabIndex = 14;
            // 
            // Lbl_LancamentoLivro
            // 
            this.Lbl_LancamentoLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_LancamentoLivro.AutoSize = true;
            this.Lbl_LancamentoLivro.Location = new System.Drawing.Point(97, 196);
            this.Lbl_LancamentoLivro.Name = "Lbl_LancamentoLivro";
            this.Lbl_LancamentoLivro.Size = new System.Drawing.Size(110, 13);
            this.Lbl_LancamentoLivro.TabIndex = 15;
            this.Lbl_LancamentoLivro.Text = "Data de Lançamento:";
            // 
            // Btn_CadastrarAutor
            // 
            this.Btn_CadastrarAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_CadastrarAutor.Location = new System.Drawing.Point(535, 213);
            this.Btn_CadastrarAutor.Name = "Btn_CadastrarAutor";
            this.Btn_CadastrarAutor.Size = new System.Drawing.Size(115, 23);
            this.Btn_CadastrarAutor.TabIndex = 19;
            this.Btn_CadastrarAutor.Text = "Cadastrar Autor";
            this.Btn_CadastrarAutor.UseVisualStyleBackColor = true;
            this.Btn_CadastrarAutor.Click += new System.EventHandler(this.Btn_CadastrarAutor_Click);
            // 
            // Btn_CadastrarEditora
            // 
            this.Btn_CadastrarEditora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_CadastrarEditora.Location = new System.Drawing.Point(535, 248);
            this.Btn_CadastrarEditora.Name = "Btn_CadastrarEditora";
            this.Btn_CadastrarEditora.Size = new System.Drawing.Size(115, 23);
            this.Btn_CadastrarEditora.TabIndex = 20;
            this.Btn_CadastrarEditora.Text = "Cadastrar Editora";
            this.Btn_CadastrarEditora.UseVisualStyleBackColor = true;
            this.Btn_CadastrarEditora.Click += new System.EventHandler(this.Btn_CadastrarEditora_Click);
            // 
            // Btn_CadastrarGenero
            // 
            this.Btn_CadastrarGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_CadastrarGenero.Location = new System.Drawing.Point(536, 281);
            this.Btn_CadastrarGenero.Name = "Btn_CadastrarGenero";
            this.Btn_CadastrarGenero.Size = new System.Drawing.Size(114, 23);
            this.Btn_CadastrarGenero.TabIndex = 21;
            this.Btn_CadastrarGenero.Text = "Cadastrar Gênero";
            this.Btn_CadastrarGenero.UseVisualStyleBackColor = true;
            this.Btn_CadastrarGenero.Click += new System.EventHandler(this.Btn_CadastrarGenero_Click);
            // 
            // Btn_CadastrarIdioma
            // 
            this.Btn_CadastrarIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_CadastrarIdioma.Location = new System.Drawing.Point(536, 394);
            this.Btn_CadastrarIdioma.Name = "Btn_CadastrarIdioma";
            this.Btn_CadastrarIdioma.Size = new System.Drawing.Size(114, 23);
            this.Btn_CadastrarIdioma.TabIndex = 22;
            this.Btn_CadastrarIdioma.Text = "Cadastrar Idioma";
            this.Btn_CadastrarIdioma.UseVisualStyleBackColor = true;
            this.Btn_CadastrarIdioma.Click += new System.EventHandler(this.Btn_CadastrarIdioma_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripButton,
            this.Acervo,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(794, 25);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton.Text = "Salvar";
            this.salvarToolStripButton.Click += new System.EventHandler(this.salvarToolStripButton_Click);
            // 
            // Acervo
            // 
            this.Acervo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Acervo.Image = ((System.Drawing.Image)(resources.GetObject("Acervo.Image")));
            this.Acervo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Acervo.Name = "Acervo";
            this.Acervo.Size = new System.Drawing.Size(23, 22);
            this.Acervo.Text = "Acervo";
            this.Acervo.Click += new System.EventHandler(this.Acervo_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Limpar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Lbl_NumeroPag
            // 
            this.Lbl_NumeroPag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_NumeroPag.AutoSize = true;
            this.Lbl_NumeroPag.Location = new System.Drawing.Point(416, 196);
            this.Lbl_NumeroPag.Name = "Lbl_NumeroPag";
            this.Lbl_NumeroPag.Size = new System.Drawing.Size(59, 13);
            this.Lbl_NumeroPag.TabIndex = 24;
            this.Lbl_NumeroPag.Text = "Nº de Pag.";
            // 
            // Lbl_Autor
            // 
            this.Lbl_Autor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Autor.AutoSize = true;
            this.Lbl_Autor.Location = new System.Drawing.Point(163, 218);
            this.Lbl_Autor.Name = "Lbl_Autor";
            this.Lbl_Autor.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Autor.TabIndex = 25;
            // 
            // Lbl_Editora
            // 
            this.Lbl_Editora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Editora.AutoSize = true;
            this.Lbl_Editora.Location = new System.Drawing.Point(163, 254);
            this.Lbl_Editora.Name = "Lbl_Editora";
            this.Lbl_Editora.Size = new System.Drawing.Size(43, 13);
            this.Lbl_Editora.TabIndex = 26;
            this.Lbl_Editora.Text = "Editora:";
            // 
            // Lbl_Genero
            // 
            this.Lbl_Genero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Genero.AutoSize = true;
            this.Lbl_Genero.Location = new System.Drawing.Point(157, 284);
            this.Lbl_Genero.Name = "Lbl_Genero";
            this.Lbl_Genero.Size = new System.Drawing.Size(45, 13);
            this.Lbl_Genero.TabIndex = 27;
            this.Lbl_Genero.Text = "Gênero:";
            // 
            // Lbl_IdiomaOriginal
            // 
            this.Lbl_IdiomaOriginal.AutoSize = true;
            this.Lbl_IdiomaOriginal.Location = new System.Drawing.Point(157, 399);
            this.Lbl_IdiomaOriginal.Name = "Lbl_IdiomaOriginal";
            this.Lbl_IdiomaOriginal.Size = new System.Drawing.Size(41, 13);
            this.Lbl_IdiomaOriginal.TabIndex = 28;
            this.Lbl_IdiomaOriginal.Text = "Idioma:";
            // 
            // Lbl_AutorLivro
            // 
            this.Lbl_AutorLivro.AutoSize = true;
            this.Lbl_AutorLivro.Location = new System.Drawing.Point(166, 222);
            this.Lbl_AutorLivro.Name = "Lbl_AutorLivro";
            this.Lbl_AutorLivro.Size = new System.Drawing.Size(35, 13);
            this.Lbl_AutorLivro.TabIndex = 29;
            this.Lbl_AutorLivro.Text = "Autor:";
            // 
            // dtp_lancamento
            // 
            this.dtp_lancamento.Location = new System.Drawing.Point(210, 189);
            this.dtp_lancamento.Name = "dtp_lancamento";
            this.dtp_lancamento.Size = new System.Drawing.Size(196, 20);
            this.dtp_lancamento.TabIndex = 30;
            // 
            // CadastrodeLivros_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtp_lancamento);
            this.Controls.Add(this.Lbl_AutorLivro);
            this.Controls.Add(this.Lbl_IdiomaOriginal);
            this.Controls.Add(this.Lbl_Genero);
            this.Controls.Add(this.Lbl_Editora);
            this.Controls.Add(this.Lbl_Autor);
            this.Controls.Add(this.Lbl_NumeroPag);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Btn_CadastrarIdioma);
            this.Controls.Add(this.Btn_CadastrarGenero);
            this.Controls.Add(this.Btn_CadastrarEditora);
            this.Controls.Add(this.Btn_CadastrarAutor);
            this.Controls.Add(this.Lbl_LancamentoLivro);
            this.Controls.Add(this.Txt_Paginas);
            this.Controls.Add(this.Cmb_Idioma);
            this.Controls.Add(this.Lbx_Genero);
            this.Controls.Add(this.Btn_AdicionarGenero);
            this.Controls.Add(this.Cmb_Genero);
            this.Controls.Add(this.Cmb_Editora);
            this.Controls.Add(this.Cmb_Autor);
            this.Controls.Add(this.Lbl_TituloLivro);
            this.Controls.Add(this.Txt_Titulo);
            this.Controls.Add(this.Lbl_Codigo);
            this.Controls.Add(this.Txt_Codigo);
            this.Controls.Add(this.Lbl_CadastroLivro);
            this.Name = "CadastrodeLivros_UC";
            this.Size = new System.Drawing.Size(794, 565);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_CadastroLivro;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Label Lbl_Codigo;
        private System.Windows.Forms.TextBox Txt_Titulo;
        private System.Windows.Forms.Label Lbl_TituloLivro;
        private System.Windows.Forms.ComboBox Cmb_Autor;
        private System.Windows.Forms.ComboBox Cmb_Editora;
        private System.Windows.Forms.ComboBox Cmb_Genero;
        private System.Windows.Forms.Button Btn_AdicionarGenero;
        private System.Windows.Forms.ListBox Lbx_Genero;
        private System.Windows.Forms.ComboBox Cmb_Idioma;
        private System.Windows.Forms.TextBox Txt_Paginas;
        private System.Windows.Forms.Label Lbl_LancamentoLivro;
        private System.Windows.Forms.Button Btn_CadastrarAutor;
        private System.Windows.Forms.Button Btn_CadastrarEditora;
        private System.Windows.Forms.Button Btn_CadastrarGenero;
        private System.Windows.Forms.Button Btn_CadastrarIdioma;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.Label Lbl_NumeroPag;
        private System.Windows.Forms.Label Lbl_Autor;
        private System.Windows.Forms.Label Lbl_Editora;
        private System.Windows.Forms.Label Lbl_Genero;
        private System.Windows.Forms.Label Lbl_IdiomaOriginal;
        private System.Windows.Forms.Label Lbl_AutorLivro;
        private System.Windows.Forms.DateTimePicker dtp_lancamento;
        private System.Windows.Forms.ToolStripButton Acervo;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

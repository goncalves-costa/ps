
namespace ProjetoIntegradorBiblioteca
{
    partial class EmprestimosLivros
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_CodigoEmpres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BucaLeitor = new System.Windows.Forms.Button();
            this.dtp_dataatual = new System.Windows.Forms.DateTimePicker();
            this.dtp_prazo = new System.Windows.Forms.DateTimePicker();
            this.Txt_NomeLeitor = new System.Windows.Forms.TextBox();
            this.Txt_CodigoLeitor = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_NomeFunc = new System.Windows.Forms.TextBox();
            this.Txt_CodigoFunc = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dtv_pesquisa = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adicionar = new System.Windows.Forms.Button();
            this.Txt_CódigoLivro = new System.Windows.Forms.TextBox();
            this.Emprestar = new System.Windows.Forms.Button();
            this.dtv_Emprestimo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Título = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.Novo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_pesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Emprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empréstimos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_CodigoEmpres
            // 
            this.Txt_CodigoEmpres.Location = new System.Drawing.Point(7, 32);
            this.Txt_CodigoEmpres.Name = "Txt_CodigoEmpres";
            this.Txt_CodigoEmpres.Size = new System.Drawing.Size(200, 20);
            this.Txt_CodigoEmpres.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Leitor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Código Leitor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BucaLeitor);
            this.groupBox1.Controls.Add(this.dtp_dataatual);
            this.groupBox1.Controls.Add(this.dtp_prazo);
            this.groupBox1.Controls.Add(this.Txt_NomeLeitor);
            this.groupBox1.Controls.Add(this.Txt_CodigoLeitor);
            this.groupBox1.Controls.Add(this.Txt_CodigoEmpres);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(37, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 135);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Leitor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Código do Empréstimo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data de Devolução:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data Atual:";
            // 
            // BucaLeitor
            // 
            this.BucaLeitor.Location = new System.Drawing.Point(162, 81);
            this.BucaLeitor.Name = "BucaLeitor";
            this.BucaLeitor.Size = new System.Drawing.Size(89, 23);
            this.BucaLeitor.TabIndex = 10;
            this.BucaLeitor.Text = "Pesquisar";
            this.BucaLeitor.UseVisualStyleBackColor = true;
            this.BucaLeitor.Click += new System.EventHandler(this.BucaLeitor_Click);
            // 
            // dtp_dataatual
            // 
            this.dtp_dataatual.Location = new System.Drawing.Point(236, 32);
            this.dtp_dataatual.Name = "dtp_dataatual";
            this.dtp_dataatual.Size = new System.Drawing.Size(200, 20);
            this.dtp_dataatual.TabIndex = 9;
            // 
            // dtp_prazo
            // 
            this.dtp_prazo.Location = new System.Drawing.Point(470, 32);
            this.dtp_prazo.Name = "dtp_prazo";
            this.dtp_prazo.Size = new System.Drawing.Size(200, 20);
            this.dtp_prazo.TabIndex = 8;
            // 
            // Txt_NomeLeitor
            // 
            this.Txt_NomeLeitor.Location = new System.Drawing.Point(257, 81);
            this.Txt_NomeLeitor.Name = "Txt_NomeLeitor";
            this.Txt_NomeLeitor.Size = new System.Drawing.Size(413, 20);
            this.Txt_NomeLeitor.TabIndex = 5;
            // 
            // Txt_CodigoLeitor
            // 
            this.Txt_CodigoLeitor.Location = new System.Drawing.Point(9, 81);
            this.Txt_CodigoLeitor.Name = "Txt_CodigoLeitor";
            this.Txt_CodigoLeitor.Size = new System.Drawing.Size(148, 20);
            this.Txt_CodigoLeitor.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Txt_NomeFunc);
            this.groupBox2.Controls.Add(this.Txt_CodigoFunc);
            this.groupBox2.Location = new System.Drawing.Point(37, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 68);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Funcionário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nome Funcionário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Código :";
            // 
            // Txt_NomeFunc
            // 
            this.Txt_NomeFunc.Location = new System.Drawing.Point(257, 42);
            this.Txt_NomeFunc.Name = "Txt_NomeFunc";
            this.Txt_NomeFunc.Size = new System.Drawing.Size(425, 20);
            this.Txt_NomeFunc.TabIndex = 1;
            // 
            // Txt_CodigoFunc
            // 
            this.Txt_CodigoFunc.Location = new System.Drawing.Point(7, 42);
            this.Txt_CodigoFunc.Name = "Txt_CodigoFunc";
            this.Txt_CodigoFunc.Size = new System.Drawing.Size(244, 20);
            this.Txt_CodigoFunc.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.dtv_pesquisa);
            this.groupBox3.Controls.Add(this.adicionar);
            this.groupBox3.Controls.Add(this.Txt_CódigoLivro);
            this.groupBox3.Location = new System.Drawing.Point(44, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(675, 193);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Livros";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(466, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Pesquisar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dtv_pesquisa
            // 
            this.dtv_pesquisa.AllowUserToAddRows = false;
            this.dtv_pesquisa.AllowUserToDeleteRows = false;
            this.dtv_pesquisa.AllowUserToOrderColumns = true;
            this.dtv_pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_pesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Titulo,
            this.Autor,
            this.Editora,
            this.Numero,
            this.Status});
            this.dtv_pesquisa.Location = new System.Drawing.Point(6, 59);
            this.dtv_pesquisa.Name = "dtv_pesquisa";
            this.dtv_pesquisa.ReadOnly = true;
            this.dtv_pesquisa.Size = new System.Drawing.Size(641, 115);
            this.dtv_pesquisa.TabIndex = 8;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Editora
            // 
            this.Editora.HeaderText = "Editora";
            this.Editora.Name = "Editora";
            this.Editora.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Nº Páginas";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 97;
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(568, 32);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(79, 23);
            this.adicionar.TabIndex = 7;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // Txt_CódigoLivro
            // 
            this.Txt_CódigoLivro.Location = new System.Drawing.Point(6, 34);
            this.Txt_CódigoLivro.Name = "Txt_CódigoLivro";
            this.Txt_CódigoLivro.Size = new System.Drawing.Size(451, 20);
            this.Txt_CódigoLivro.TabIndex = 6;
            // 
            // Emprestar
            // 
            this.Emprestar.Location = new System.Drawing.Point(768, 440);
            this.Emprestar.Name = "Emprestar";
            this.Emprestar.Size = new System.Drawing.Size(543, 23);
            this.Emprestar.TabIndex = 7;
            this.Emprestar.Text = "Emprestar";
            this.Emprestar.UseVisualStyleBackColor = true;
            this.Emprestar.Click += new System.EventHandler(this.Emprestar_Click);
            // 
            // dtv_Emprestimo
            // 
            this.dtv_Emprestimo.AllowUserToAddRows = false;
            this.dtv_Emprestimo.AllowUserToDeleteRows = false;
            this.dtv_Emprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Emprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Título,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dtv_Emprestimo.Location = new System.Drawing.Point(768, 87);
            this.dtv_Emprestimo.Name = "dtv_Emprestimo";
            this.dtv_Emprestimo.ReadOnly = true;
            this.dtv_Emprestimo.Size = new System.Drawing.Size(543, 335);
            this.dtv_Emprestimo.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Título
            // 
            this.Título.HeaderText = "Titulo";
            this.Título.Name = "Título";
            this.Título.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Editora";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Status";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1107, 57);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Remover";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Novo
            // 
            this.Novo.Location = new System.Drawing.Point(44, 20);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(137, 23);
            this.Novo.TabIndex = 10;
            this.Novo.Text = "Novo";
            this.Novo.UseVisualStyleBackColor = true;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // EmprestimosLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Novo);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dtv_Emprestimo);
            this.Controls.Add(this.Emprestar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "EmprestimosLivros";
            this.Size = new System.Drawing.Size(1402, 509);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_pesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Emprestimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_CodigoEmpres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_CódigoLivro;
        private System.Windows.Forms.TextBox Txt_NomeLeitor;
        private System.Windows.Forms.TextBox Txt_CodigoLeitor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_prazo;
        private System.Windows.Forms.TextBox Txt_NomeFunc;
        private System.Windows.Forms.TextBox Txt_CodigoFunc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp_dataatual;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.Button Emprestar;
        private System.Windows.Forms.DataGridView dtv_pesquisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BucaLeitor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dtv_Emprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Título;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Label label8;
    }
}

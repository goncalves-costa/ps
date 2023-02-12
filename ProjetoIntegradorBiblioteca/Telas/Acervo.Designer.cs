
namespace ProjetoIntegradorBiblioteca
{
    partial class Acervo
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
            this.dgv_ResultadoPesquisa = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Generos = new System.Windows.Forms.DataGridView();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_BarraPesquisa = new System.Windows.Forms.TextBox();
            this.Cmb_EscolhaPesquisa = new System.Windows.Forms.ComboBox();
            this.Btn_Pesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultadoPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Generos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ResultadoPesquisa
            // 
            this.dgv_ResultadoPesquisa.AllowUserToAddRows = false;
            this.dgv_ResultadoPesquisa.AllowUserToDeleteRows = false;
            this.dgv_ResultadoPesquisa.AllowUserToOrderColumns = true;
            this.dgv_ResultadoPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ResultadoPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Titulo,
            this.Autor,
            this.Editora,
            this.Status});
            this.dgv_ResultadoPesquisa.Location = new System.Drawing.Point(32, 147);
            this.dgv_ResultadoPesquisa.Name = "dgv_ResultadoPesquisa";
            this.dgv_ResultadoPesquisa.ReadOnly = true;
            this.dgv_ResultadoPesquisa.Size = new System.Drawing.Size(642, 223);
            this.dgv_ResultadoPesquisa.TabIndex = 0;
            this.dgv_ResultadoPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ResultadoPesquisa_CellDoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 125;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 125;
            // 
            // Editora
            // 
            this.Editora.HeaderText = "Editora";
            this.Editora.Name = "Editora";
            this.Editora.ReadOnly = true;
            this.Editora.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // dgv_Generos
            // 
            this.dgv_Generos.AllowUserToAddRows = false;
            this.dgv_Generos.AllowUserToDeleteRows = false;
            this.dgv_Generos.AllowUserToOrderColumns = true;
            this.dgv_Generos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Generos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Genero});
            this.dgv_Generos.Location = new System.Drawing.Point(710, 147);
            this.dgv_Generos.Name = "dgv_Generos";
            this.dgv_Generos.ReadOnly = true;
            this.dgv_Generos.Size = new System.Drawing.Size(195, 181);
            this.dgv_Generos.TabIndex = 1;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Gêneros";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Width = 150;
            // 
            // Txt_BarraPesquisa
            // 
            this.Txt_BarraPesquisa.Location = new System.Drawing.Point(32, 103);
            this.Txt_BarraPesquisa.Name = "Txt_BarraPesquisa";
            this.Txt_BarraPesquisa.Size = new System.Drawing.Size(490, 20);
            this.Txt_BarraPesquisa.TabIndex = 2;
            this.Txt_BarraPesquisa.Text = "Pesquisar...";
            // 
            // Cmb_EscolhaPesquisa
            // 
            this.Cmb_EscolhaPesquisa.FormattingEnabled = true;
            this.Cmb_EscolhaPesquisa.Location = new System.Drawing.Point(540, 105);
            this.Cmb_EscolhaPesquisa.Name = "Cmb_EscolhaPesquisa";
            this.Cmb_EscolhaPesquisa.Size = new System.Drawing.Size(134, 21);
            this.Cmb_EscolhaPesquisa.TabIndex = 3;
            // 
            // Btn_Pesquisar
            // 
            this.Btn_Pesquisar.Location = new System.Drawing.Point(710, 105);
            this.Btn_Pesquisar.Name = "Btn_Pesquisar";
            this.Btn_Pesquisar.Size = new System.Drawing.Size(185, 23);
            this.Btn_Pesquisar.TabIndex = 4;
            this.Btn_Pesquisar.Text = "Buscar";
            this.Btn_Pesquisar.UseVisualStyleBackColor = true;
            this.Btn_Pesquisar.Click += new System.EventHandler(this.Btn_Pesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Acervo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pesquisar Por:";
            // 
            // Acervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Pesquisar);
            this.Controls.Add(this.Cmb_EscolhaPesquisa);
            this.Controls.Add(this.Txt_BarraPesquisa);
            this.Controls.Add(this.dgv_Generos);
            this.Controls.Add(this.dgv_ResultadoPesquisa);
            this.Name = "Acervo";
            this.Text = "Acervo";
            this.Load += new System.EventHandler(this.Acervo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ResultadoPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Generos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ResultadoPesquisa;
        private System.Windows.Forms.DataGridView dgv_Generos;
        private System.Windows.Forms.TextBox Txt_BarraPesquisa;
        private System.Windows.Forms.ComboBox Cmb_EscolhaPesquisa;
        private System.Windows.Forms.Button Btn_Pesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
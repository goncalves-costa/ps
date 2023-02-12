
namespace ProjetoIntegradorBiblioteca
{
    partial class Devolucao_UC
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
            this.Txt_Pesquisa = new System.Windows.Forms.TextBox();
            this.Btn_PesquisaEmpr = new System.Windows.Forms.Button();
            this.Dtv_PesquisaLeitor = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_emprestimo = new System.Windows.Forms.Label();
            this.Dtv_PesquisaEmpre = new System.Windows.Forms.DataGridView();
            this.Txt_CodioEmpre = new System.Windows.Forms.TextBox();
            this.Txt_FuncioEntr = new System.Windows.Forms.TextBox();
            this.Btn_Devolucao = new System.Windows.Forms.Button();
            this.Lbl_CodEmprestimo = new System.Windows.Forms.Label();
            this.Lbl_FuncioSaida = new System.Windows.Forms.Label();
            this.Lbl_Funcio2 = new System.Windows.Forms.Label();
            this.Lbl_Multa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_selecionaremprestimo = new System.Windows.Forms.Button();
            this.data1 = new System.Windows.Forms.TextBox();
            this.data2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Func_Saida = new System.Windows.Forms.TextBox();
            this.dtv_hoje = new System.Windows.Forms.DataGridView();
            this.CodigoHoje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeLeitorHoje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtv_prazo = new System.Windows.Forms.DataGridView();
            this.CodigoAtraso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeAtraso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Multas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_PesquisaLeitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_PesquisaEmpre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_hoje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_prazo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar Leitor:";
            // 
            // Txt_Pesquisa
            // 
            this.Txt_Pesquisa.Location = new System.Drawing.Point(33, 88);
            this.Txt_Pesquisa.Name = "Txt_Pesquisa";
            this.Txt_Pesquisa.Size = new System.Drawing.Size(534, 20);
            this.Txt_Pesquisa.TabIndex = 1;
            // 
            // Btn_PesquisaEmpr
            // 
            this.Btn_PesquisaEmpr.Location = new System.Drawing.Point(582, 86);
            this.Btn_PesquisaEmpr.Name = "Btn_PesquisaEmpr";
            this.Btn_PesquisaEmpr.Size = new System.Drawing.Size(75, 23);
            this.Btn_PesquisaEmpr.TabIndex = 2;
            this.Btn_PesquisaEmpr.Text = "Pesquisar";
            this.Btn_PesquisaEmpr.UseVisualStyleBackColor = true;
            this.Btn_PesquisaEmpr.Click += new System.EventHandler(this.Btn_PesquisaEmpr_Click);
            // 
            // Dtv_PesquisaLeitor
            // 
            this.Dtv_PesquisaLeitor.AllowUserToAddRows = false;
            this.Dtv_PesquisaLeitor.AllowUserToDeleteRows = false;
            this.Dtv_PesquisaLeitor.AllowUserToOrderColumns = true;
            this.Dtv_PesquisaLeitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtv_PesquisaLeitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome});
            this.Dtv_PesquisaLeitor.Location = new System.Drawing.Point(33, 125);
            this.Dtv_PesquisaLeitor.Name = "Dtv_PesquisaLeitor";
            this.Dtv_PesquisaLeitor.ReadOnly = true;
            this.Dtv_PesquisaLeitor.Size = new System.Drawing.Size(769, 51);
            this.Dtv_PesquisaLeitor.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 400;
            // 
            // Lbl_emprestimo
            // 
            this.Lbl_emprestimo.AutoSize = true;
            this.Lbl_emprestimo.Location = new System.Drawing.Point(30, 187);
            this.Lbl_emprestimo.Name = "Lbl_emprestimo";
            this.Lbl_emprestimo.Size = new System.Drawing.Size(66, 13);
            this.Lbl_emprestimo.TabIndex = 4;
            this.Lbl_emprestimo.Text = "Empréstimos";
            // 
            // Dtv_PesquisaEmpre
            // 
            this.Dtv_PesquisaEmpre.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.Dtv_PesquisaEmpre.AllowUserToAddRows = false;
            this.Dtv_PesquisaEmpre.AllowUserToDeleteRows = false;
            this.Dtv_PesquisaEmpre.AllowUserToOrderColumns = true;
            this.Dtv_PesquisaEmpre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtv_PesquisaEmpre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Qtda,
            this.DataSaida,
            this.DataPrazo,
            this.Multas,
            this.Status});
            this.Dtv_PesquisaEmpre.Location = new System.Drawing.Point(33, 216);
            this.Dtv_PesquisaEmpre.Name = "Dtv_PesquisaEmpre";
            this.Dtv_PesquisaEmpre.ReadOnly = true;
            this.Dtv_PesquisaEmpre.Size = new System.Drawing.Size(769, 92);
            this.Dtv_PesquisaEmpre.TabIndex = 5;
            this.Dtv_PesquisaEmpre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtv_PesquisaEmpre_CellContentClick);
            // 
            // Txt_CodioEmpre
            // 
            this.Txt_CodioEmpre.Location = new System.Drawing.Point(923, 135);
            this.Txt_CodioEmpre.Name = "Txt_CodioEmpre";
            this.Txt_CodioEmpre.Size = new System.Drawing.Size(227, 20);
            this.Txt_CodioEmpre.TabIndex = 6;
            // 
            // Txt_FuncioEntr
            // 
            this.Txt_FuncioEntr.Location = new System.Drawing.Point(923, 170);
            this.Txt_FuncioEntr.Name = "Txt_FuncioEntr";
            this.Txt_FuncioEntr.Size = new System.Drawing.Size(345, 20);
            this.Txt_FuncioEntr.TabIndex = 7;
            // 
            // Btn_Devolucao
            // 
            this.Btn_Devolucao.Location = new System.Drawing.Point(1136, 292);
            this.Btn_Devolucao.Name = "Btn_Devolucao";
            this.Btn_Devolucao.Size = new System.Drawing.Size(116, 39);
            this.Btn_Devolucao.TabIndex = 12;
            this.Btn_Devolucao.Text = "Devolver Livros";
            this.Btn_Devolucao.UseVisualStyleBackColor = true;
            this.Btn_Devolucao.Click += new System.EventHandler(this.Btn_Devolucao_Click);
            // 
            // Lbl_CodEmprestimo
            // 
            this.Lbl_CodEmprestimo.AutoSize = true;
            this.Lbl_CodEmprestimo.Location = new System.Drawing.Point(855, 138);
            this.Lbl_CodEmprestimo.Name = "Lbl_CodEmprestimo";
            this.Lbl_CodEmprestimo.Size = new System.Drawing.Size(43, 13);
            this.Lbl_CodEmprestimo.TabIndex = 16;
            this.Lbl_CodEmprestimo.Text = "Código:";
            this.Lbl_CodEmprestimo.Click += new System.EventHandler(this.Lbl_CodEmprestimo_Click);
            // 
            // Lbl_FuncioSaida
            // 
            this.Lbl_FuncioSaida.AutoSize = true;
            this.Lbl_FuncioSaida.Location = new System.Drawing.Point(828, 173);
            this.Lbl_FuncioSaida.Name = "Lbl_FuncioSaida";
            this.Lbl_FuncioSaida.Size = new System.Drawing.Size(94, 13);
            this.Lbl_FuncioSaida.TabIndex = 17;
            this.Lbl_FuncioSaida.Text = "Func. Empréstimo:";
            // 
            // Lbl_Funcio2
            // 
            this.Lbl_Funcio2.AutoSize = true;
            this.Lbl_Funcio2.Location = new System.Drawing.Point(828, 202);
            this.Lbl_Funcio2.Name = "Lbl_Funcio2";
            this.Lbl_Funcio2.Size = new System.Drawing.Size(92, 13);
            this.Lbl_Funcio2.TabIndex = 18;
            this.Lbl_Funcio2.Text = "Func. Devolução:";
            // 
            // Lbl_Multa
            // 
            this.Lbl_Multa.AutoSize = true;
            this.Lbl_Multa.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Multa.Location = new System.Drawing.Point(950, 292);
            this.Lbl_Multa.Name = "Lbl_Multa";
            this.Lbl_Multa.Size = new System.Drawing.Size(156, 42);
            this.Lbl_Multa.TabIndex = 19;
            this.Lbl_Multa.Text = "R$ 0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(534, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Devolução";
            // 
            // btn_selecionaremprestimo
            // 
            this.btn_selecionaremprestimo.Location = new System.Drawing.Point(716, 187);
            this.btn_selecionaremprestimo.Name = "btn_selecionaremprestimo";
            this.btn_selecionaremprestimo.Size = new System.Drawing.Size(75, 23);
            this.btn_selecionaremprestimo.TabIndex = 21;
            this.btn_selecionaremprestimo.Text = "Selecionar";
            this.btn_selecionaremprestimo.UseVisualStyleBackColor = true;
            this.btn_selecionaremprestimo.Click += new System.EventHandler(this.btn_selecionaremprestimo_Click);
            // 
            // data1
            // 
            this.data1.Location = new System.Drawing.Point(923, 249);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(166, 20);
            this.data1.TabIndex = 22;
            // 
            // data2
            // 
            this.data2.Location = new System.Drawing.Point(1095, 249);
            this.data2.Name = "data2";
            this.data2.Size = new System.Drawing.Size(173, 20);
            this.data2.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(923, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Data do Empréstimo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1092, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Prazo de Entrega:";
            // 
            // Func_Saida
            // 
            this.Func_Saida.Location = new System.Drawing.Point(921, 199);
            this.Func_Saida.Name = "Func_Saida";
            this.Func_Saida.Size = new System.Drawing.Size(346, 20);
            this.Func_Saida.TabIndex = 26;
            // 
            // dtv_hoje
            // 
            this.dtv_hoje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_hoje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoHoje,
            this.NomeLeitorHoje});
            this.dtv_hoje.Location = new System.Drawing.Point(33, 388);
            this.dtv_hoje.Name = "dtv_hoje";
            this.dtv_hoje.Size = new System.Drawing.Size(443, 150);
            this.dtv_hoje.TabIndex = 27;
            // 
            // CodigoHoje
            // 
            this.CodigoHoje.HeaderText = "Código";
            this.CodigoHoje.Name = "CodigoHoje";
            // 
            // NomeLeitorHoje
            // 
            this.NomeLeitorHoje.HeaderText = "Leitor";
            this.NomeLeitorHoje.Name = "NomeLeitorHoje";
            this.NomeLeitorHoje.Width = 300;
            // 
            // dtv_prazo
            // 
            this.dtv_prazo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_prazo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoAtraso,
            this.NomeAtraso});
            this.dtv_prazo.Location = new System.Drawing.Point(510, 388);
            this.dtv_prazo.Name = "dtv_prazo";
            this.dtv_prazo.Size = new System.Drawing.Size(393, 150);
            this.dtv_prazo.TabIndex = 28;
            // 
            // CodigoAtraso
            // 
            this.CodigoAtraso.HeaderText = "Codigo";
            this.CodigoAtraso.Name = "CodigoAtraso";
            // 
            // NomeAtraso
            // 
            this.NomeAtraso.HeaderText = "Leitor";
            this.NomeAtraso.Name = "NomeAtraso";
            this.NomeAtraso.Width = 250;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Devoluções para Hoje:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Devoluções Atrasadas";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // Qtda
            // 
            this.Qtda.HeaderText = "Qtde de Livros";
            this.Qtda.Name = "Qtda";
            this.Qtda.ReadOnly = true;
            this.Qtda.Width = 130;
            // 
            // DataSaida
            // 
            this.DataSaida.HeaderText = "Data Empréstimo";
            this.DataSaida.Name = "DataSaida";
            this.DataSaida.ReadOnly = true;
            this.DataSaida.Width = 130;
            // 
            // DataPrazo
            // 
            this.DataPrazo.HeaderText = "Data Devolução";
            this.DataPrazo.Name = "DataPrazo";
            this.DataPrazo.ReadOnly = true;
            this.DataPrazo.Width = 130;
            // 
            // Multas
            // 
            this.Multas.HeaderText = "Multa";
            this.Multas.Name = "Multas";
            this.Multas.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Devolucao_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtv_prazo);
            this.Controls.Add(this.dtv_hoje);
            this.Controls.Add(this.Func_Saida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.data2);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.btn_selecionaremprestimo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_Multa);
            this.Controls.Add(this.Lbl_Funcio2);
            this.Controls.Add(this.Lbl_FuncioSaida);
            this.Controls.Add(this.Lbl_CodEmprestimo);
            this.Controls.Add(this.Btn_Devolucao);
            this.Controls.Add(this.Txt_FuncioEntr);
            this.Controls.Add(this.Txt_CodioEmpre);
            this.Controls.Add(this.Dtv_PesquisaEmpre);
            this.Controls.Add(this.Lbl_emprestimo);
            this.Controls.Add(this.Dtv_PesquisaLeitor);
            this.Controls.Add(this.Btn_PesquisaEmpr);
            this.Controls.Add(this.Txt_Pesquisa);
            this.Controls.Add(this.label1);
            this.Name = "Devolucao_UC";
            this.Size = new System.Drawing.Size(1300, 688);
            this.Load += new System.EventHandler(this.Devolucao_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_PesquisaLeitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_PesquisaEmpre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_hoje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_prazo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Pesquisa;
        private System.Windows.Forms.Button Btn_PesquisaEmpr;
        private System.Windows.Forms.DataGridView Dtv_PesquisaLeitor;
        private System.Windows.Forms.Label Lbl_emprestimo;
        private System.Windows.Forms.DataGridView Dtv_PesquisaEmpre;
        private System.Windows.Forms.TextBox Txt_CodioEmpre;
        private System.Windows.Forms.TextBox Txt_FuncioEntr;
        private System.Windows.Forms.Button Btn_Devolucao;
        private System.Windows.Forms.Label Lbl_CodEmprestimo;
        private System.Windows.Forms.Label Lbl_FuncioSaida;
        private System.Windows.Forms.Label Lbl_Funcio2;
        private System.Windows.Forms.Label Lbl_Multa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_selecionaremprestimo;
        private System.Windows.Forms.TextBox data1;
        private System.Windows.Forms.TextBox data2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.TextBox Func_Saida;
        private System.Windows.Forms.DataGridView dtv_hoje;
        private System.Windows.Forms.DataGridView dtv_prazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoHoje;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeLeitorHoje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAtraso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAtraso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtda;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Multas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

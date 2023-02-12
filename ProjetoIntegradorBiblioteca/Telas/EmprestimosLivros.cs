using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegrador_BibliotecasdeClasse;

namespace ProjetoIntegradorBiblioteca
{
    public partial class EmprestimosLivros : UserControl
    {
        private string Codfunc { get; set; }
        public EmprestimosLivros(string codigofunc)
        {
            Codfunc = codigofunc;
            InitializeComponent();
            NovoEmpresimo();
            BuscaFunc();
        }

        private void BucaLeitor_Click(object sender, EventArgs e)
        {
            try
            {
                string Leitor = Txt_CodigoLeitor.Text;
                var SQL = $"select * from cadleitor where codleitor = {Leitor}";
                var bd = new MySQLServerClass();
                var dt = bd.SQLQuery(SQL);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("ERRO, NÃO EXISTE ESSE LEITOR");
                }
                else
                {
                    Txt_NomeLeitor.Text = dt.Rows[0]["nomeleitor"].ToString();
                }
            }
            catch(Exception ex)
            {

            }
            
        }

        private void buscaFunc_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_CódigoLivro.Text == "")
                {
                    MessageBox.Show("Digite um código de um livro.");
                }
                var CodigoLivro = Txt_CódigoLivro.Text;
                string SQL;
                SQL = $"select l.titulo, e.nomeeditora, a.nomeautor, l.numeropag, l.statuslivros, l.codlivro from cadlivro l join editora e on l.codeditora = e.codeditora join autor a on l.codautor = a.codautor where l.codlivro = {CodigoLivro};";
                var db = new MySQLServerClass();
                var dt = db.SQLQuery(SQL);
                dtv_pesquisa.Rows.Clear();
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtv_pesquisa);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Livro não encontrado!");
                }
                else
                {
                    row.Cells[0].Value = dt.Rows[0]["codlivro"];
                    row.Cells[1].Value = dt.Rows[0]["titulo"];
                    row.Cells[2].Value = dt.Rows[0]["nomeautor"];
                    row.Cells[3].Value = dt.Rows[0]["nomeeditora"];
                    row.Cells[4].Value = dt.Rows[0]["numeropag"];

                    var status = dt.Rows[0]["statuslivros"].ToString();
                    if (status == null || status == "")
                    {
                        row.Cells[5].Value = "Disponível";
                        row.Cells[5].Style.ForeColor = Color.Green;
                    }
                    else
                    {
                        var teste = Convert.ToInt32(status);
                        if (teste == 0)
                        {
                            row.Cells[5].Value = "Disponível";
                            row.Cells[5].Style.ForeColor = Color.Green;
                        }
                        else if (teste == 1)
                        {
                            row.Cells[5].Value = "Emprestado";
                            row.Cells[5].Style.ForeColor = Color.Red;
                        }
                    }

                    dtv_pesquisa.Rows.Add(row);
                    dtv_pesquisa.Rows[0].Selected = true;



                }

            }
            catch(Exception ex)
            {

            }
            
            

        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtv_Emprestimo.Rows.Count == 10)
                {
                    adicionar.Enabled = true;
                }
                else
                {
                    DataGridViewRow row = dtv_pesquisa.SelectedRows[0];
                    var teste = row.Cells[5].Value.ToString();
                    if (teste == "Emprestado")
                    {
                        MessageBox.Show("Livro Emprestado! Indisponível para emprestimos");
                    }
                    else
                    {
                        DataGridViewRow row2 = new DataGridViewRow();
                        row2.CreateCells(dtv_Emprestimo);

                        row2.Cells[0].Value = row.Cells[0].Value;
                        row2.Cells[1].Value = row.Cells[1].Value;
                        row2.Cells[2].Value = row.Cells[2].Value;
                        row2.Cells[3].Value = row.Cells[3].Value;
                        row2.Cells[4].Value = row.Cells[5].Value;

                        dtv_Emprestimo.Rows.Add(row2);
                    }

                }
            }
            catch(Exception ex)
            {

            }
       

        }

        private void Emprestar_Click(object sender, EventArgs e)
        {

            try
            {
                Emprestimo empres = new Emprestimo();
                empres = LeituraFormulario();
                empres.Validacao();
                empres.Cadastrar();
                SalvarLivros();

                MessageBox.Show("EMPRÊSTIMO REALIZADO COM SUCESSO");

            }catch(Exception ex)
            {
                MessageBox.Show("ERRO NO EMPRÊSTIMO!");
            }




        }


        Emprestimo LeituraFormulario()
        {
            Emprestimo em = new Emprestimo();
            string saida, prazo, dia1, mes1, ano1, dia2, mes2, ano2;

            em.Codigo = Txt_CodigoEmpres.Text;

            dia1 = dtp_dataatual.Value.Day.ToString();
            mes1 = dtp_dataatual.Value.Month.ToString();
            ano1 = dtp_dataatual.Value.Year.ToString();

            saida = $"{ano1}-{mes1}-{dia1}";

            dia2 = dtp_prazo.Value.Day.ToString();
            mes2 = dtp_prazo.Value.Month.ToString();
            ano2 = dtp_prazo.Value.Year.ToString();

            prazo = $"{ano2}-{mes2}-{dia2}";

            em.DataEmprestimo = saida;
            em.PrazoDevolucao = prazo;
            em.Leitor = Txt_CodigoLeitor.Text;
            em.FuncionarioEmprestimo = Txt_CodigoFunc.Text;

            return em;
        }



        private void NovoEmpresimo()
        {

            try
            {
                var SQL = "SELECT * FROM emprestimo WHERE codemprestimo = (SELECT max(codemprestimo) FROM emprestimo)";
                var db = new MySQLServerClass();
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count == 0)
                {
                    Txt_CodigoEmpres.Text = "1";
                }
                else
                {
                    int codigoNovo;
                    ItemCombo x = new ItemCombo();
                    x.codigo = dt.Rows[0]["codemprestimo"].ToString();
                    codigoNovo = Convert.ToInt32(x.codigo);
                    codigoNovo++;
                    Txt_CodigoEmpres.Text = codigoNovo.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO!" + ex.Message);
            }



        }

        private void SalvarLivros()
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                var codigoemprestimo = Txt_CodigoEmpres.Text;
                for (int i = 0; i <= dtv_Emprestimo.Rows.Count - 1; i++)
                {
                    row = dtv_Emprestimo.Rows[i];
                    string codigoLivro = row.Cells[0].Value.ToString();
                    var bd = new MySQLServerClass();
                    var SQL = $"insert into emprestimolivro (codemprestimo, codlivro) values ({codigoemprestimo},{codigoLivro});";
                    SQL += $"update cadlivro set statuslivros = '1' where codlivro = {codigoLivro}";
                    bd.SQLCommand(SQL);
                    bd.Close();
                }
            }
            catch(Exception ex)
            {

            }
            
        }

        class ItemCombo
        {
            public string codigo { get; set; }
            public string nome { get; set; }

            public override string ToString()
            {
                return nome;
            }
        }

        void BuscaFunc()
        {
            try
            {
                var SQL = $"select * from cadfunc where codfunc = {Codfunc}";
                var bd = new MySQLServerClass();
                var dt = bd.SQLQuery(SQL);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("ERRO, NÃO EXISTE ESSE LEITOR");
                }
                else
                {
                    Txt_NomeFunc.Text = dt.Rows[0]["nomefunc"].ToString();
                    Txt_CodigoFunc.Text = dt.Rows[0]["codfunc"].ToString();
                }
            }
            catch(Exception ex)
            {

            }
            
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            LimpaFormulario();
        }

        void LimpaFormulario()
        {
            NovoEmpresimo();
            BuscaFunc();
            dtp_dataatual.Text = "";
            dtp_prazo.Text = "";
            Txt_CodigoLeitor.Text = "";
            Txt_NomeLeitor.Text = "";
            dtv_Emprestimo.Rows.Clear();
            dtv_pesquisa.Rows.Clear();
            Txt_CódigoLivro.Text = "";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dtv_Emprestimo.SelectedRows[0];
                dtv_Emprestimo.Rows.Remove(row);
            }
            catch (Exception ex)
            {

            }
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

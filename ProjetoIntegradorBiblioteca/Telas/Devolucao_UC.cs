using ProjetoIntegrador_BibliotecasdeClasse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorBiblioteca
{
    public partial class Devolucao_UC : UserControl
    {
        private decimal Multa = 0;
        private string CodigoEmprestimo { get; set; }
        private string CodigoFunc { get; set; }

       

        public Devolucao_UC(string id, string nome)
        {
            CodigoFunc = id;
            InitializeComponent();
            Func_Saida.Text = id + " - " + nome;
            EscreveTabelaAtraso();
            EscreveTabelaHoje();
        }

        private void Lbl_CodEmprestimo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_PesquisaEmpr_Click(object sender, EventArgs e)
        {
            try
            {
                string Leitor = Txt_Pesquisa.Text;
                var SQL = $"select * from cadleitor where codleitor = {Leitor}";
                var bd = new MySQLServerClass();
                var dt = bd.SQLQuery(SQL);
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(Dtv_PesquisaLeitor);
                var codigoLeitor = dt.Rows[0]["codleitor"].ToString();
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("ERRO, NÃO EXISTE ESSE LEITOR");
                }
                else
                {
                    row.Cells[0].Value = dt.Rows[0]["codleitor"];
                    row.Cells[1].Value = dt.Rows[0]["nomeleitor"];
                    Dtv_PesquisaLeitor.Rows.Clear();
                    Dtv_PesquisaLeitor.Rows.Add(row);

                    var emprestimos = PesquisaEmpresitmos(codigoLeitor);
                    Dtv_PesquisaEmpre.Rows.Clear();


                    for (int i = 0; i <= emprestimos.Rows.Count - 1; i++)
                    {
                        var codigoemprestimo = emprestimos.Rows[i]["codemprestimo"];
                        var SQL2 = $"select * from emprestimo where codemprestimo = {codigoemprestimo};";
                        var dt2 = bd.SQLQuery(SQL2);
                        var SQL3 = $"select * from emprestimolivro where codemprestimo = {codigoemprestimo};";
                        var dt3 = bd.SQLQuery(SQL3);

                        DataGridViewRow row2 = new DataGridViewRow();

                        row2.CreateCells(Dtv_PesquisaEmpre);
                        row2.Cells[0].Value = dt2.Rows[0]["codemprestimo"];
                        row2.Cells[2].Value = dt2.Rows[0]["data_emprestimo"];
                        row2.Cells[3].Value = dt2.Rows[0]["prazo_devolucao"];
                        row2.Cells[4].Value = dt2.Rows[0]["multa"];
                        row2.Cells[1].Value = dt3.Rows.Count.ToString();

                        var data = row2.Cells[3].Value = dt2.Rows[0]["prazo_devolucao"];

                        var prazo = Convert.ToDateTime(data);
                        var hoje = DateTime.Today;
                        if (prazo < hoje && dt2.Rows[0]["data_devolucao"].ToString() == "")
                        {
                            row2.Cells[5].Value = "Atrasado";
                            row2.Cells[5].Style.ForeColor = Color.Red;
                        }
                        else if (dt2.Rows[0]["data_devolucao"].ToString() == null || dt2.Rows[0]["data_devolucao"].ToString() == "")
                        {
                            row2.Cells[5].Value = "No Prazo";
                            row2.Cells[5].Style.ForeColor = Color.Blue;
                        }
                        else
                        {
                            row2.Cells[5].Value = "Devolvido";
                            row2.Cells[5].Style.ForeColor = Color.Green;
                        }
                        Dtv_PesquisaEmpre.Rows.Add(row2);

                    }

                }

            }
            catch(Exception ex)
            {

            }
         
           
        }


        DataTable PesquisaEmpresitmos(string codigo)
        {
            string SQL = $"select em.codemprestimo from cadleitor lt join emprestimo em on lt.codleitor = em.codleitor where lt.codleitor  = {codigo} order by em.codemprestimo desc";
            var db = new MySQLServerClass();
            var dt = db.SQLQuery(SQL);
            return dt;

        }

        private void btn_selecionaremprestimo_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow row = Dtv_PesquisaEmpre.SelectedRows[0];
                var emprestimo = row.Cells[0].Value.ToString();
                string SQL = $"select * from emprestimo where codemprestimo = {emprestimo}";
                var bd = new MySQLServerClass();
                var dt = bd.SQLQuery(SQL);

                string funcionario = dt.Rows[0]["codfunc_emprestimo"].ToString();
                SQL = $"select * from cadfunc where codfunc = {funcionario}";
                var dt2 = bd.SQLQuery(SQL);




                Txt_FuncioEntr.Text = dt.Rows[0]["codfunc_emprestimo"].ToString() + " - " + dt2.Rows[0]["nomefunc"].ToString();
                Txt_CodioEmpre.Text = dt.Rows[0]["codemprestimo"].ToString();
                CodigoEmprestimo = dt.Rows[0]["codemprestimo"].ToString();
                data1.Text = dt.Rows[0]["data_emprestimo"].ToString();
                data2.Text = dt.Rows[0]["prazo_devolucao"].ToString();

                var prazo = Convert.ToDateTime(dt.Rows[0]["prazo_devolucao"].ToString());
                DateTime hoje = DateTime.Today;

                if (prazo < hoje)
                {

                    var dias = hoje - prazo;
                    var multa = Convert.ToDouble(dias.Days);
                    double i = multa * 0.55;
                    Multa = Convert.ToDecimal(i);
                    Lbl_Multa.Text = "R$ " + i.ToString();

                }
            }
            catch(Exception ex)
            {

            }

                           

        }

        


       

        private void Btn_LimpaMulta_Click(object sender, EventArgs e)
        {
            string SQL = $"update emprestimo set multa = {Multa} where codemprestimo = {CodigoEmprestimo}";
            var bd = new MySQLServerClass();
            bd.SQLCommand(SQL);
            Lbl_Multa.Text = "R$ 0,00";

        }

        private void Btn_Devolucao_Click(object sender, EventArgs e)
        {
            try
            {
                var bd = new MySQLServerClass();

                var multa = Multa.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
                string SQL3 = $"update emprestimo set multa = '{multa}' where codemprestimo = {CodigoEmprestimo}";
                bd.SQLCommand(SQL3);
                bd.Close();
                Lbl_Multa.Text = "R$ 0,00";


                DataGridViewRow row = Dtv_PesquisaEmpre.SelectedRows[0];
                var emprestimo = row.Cells[0].Value.ToString();
                string dia, mes, ano, data;
                dia = DateTime.Today.Day.ToString();
                mes = DateTime.Today.Month.ToString();
                ano = DateTime.Today.Year.ToString();
                data = $"{ano}-{mes}-{dia}";



                var bd2 = new MySQLServerClass();
                var bd3 = new MySQLServerClass();

                string SQL = $"update emprestimo set codfunc_devolucao = '{CodigoFunc}', data_devolucao = '{data}' where codemprestimo = {CodigoEmprestimo}";
                bd2.SQLCommand(SQL);
                bd2.Close();

                var SQL1 = $"select * from emprestimolivro where codemprestimo = {CodigoEmprestimo}";
                var dt1 = bd3.SQLQuery(SQL1);
                bd3.Close();

                for (int i = 0; i <= dt1.Rows.Count - 1; i++)
                {
                    var b4 = new MySQLServerClass();
                    var codigolivro = dt1.Rows[i]["codlivro"];
                    var SQL2 = $"update cadlivro set statuslivros = '0' where codlivro = {codigolivro}";
                    b4.SQLCommand(SQL2);
                    b4.Close();

                }
                MessageBox.Show("Livros Devolvidos com sucesso!");
                EscreveTabelaAtraso();
                EscreveTabelaHoje();

            }
            catch (Exception ex)
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

        private void Dtv_PesquisaEmpre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Devolucao_UC_Load(object sender, EventArgs e)
        {
            
        }

        void EscreveTabelaAtraso()
        {
            try
            {
                string SQL = "select l.nomeleitor, l.codleitor from emprestimo e join cadleitor l on l.codleitor = e.codleitor  where (prazo_devolucao < current_date() and  e.data_devolucao is null);";
                var bd = new MySQLServerClass();
                var dt = bd.SQLQuery(SQL);
                dtv_prazo.Rows.Clear();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dtv_prazo);
                    row.Cells[0].Value = dt.Rows[i]["codleitor"].ToString();
                    row.Cells[1].Value = dt.Rows[i]["nomeleitor"].ToString();
                    dtv_prazo.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {

            }
            
        }
    

        void EscreveTabelaHoje()
        {
            string SQL = "select l.nomeleitor, l.codleitor from emprestimo e join cadleitor l on l.codleitor = e.codleitor  where prazo_devolucao = current_date() and  e.data_devolucao is null;";
            var bd = new MySQLServerClass();
            var dt = bd.SQLQuery(SQL);
            dtv_hoje.Rows.Clear();
            for (int i = 0; i <= dt.Rows.Count -1; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtv_hoje);
                row.Cells[0].Value = dt.Rows[i]["codleitor"].ToString();
                row.Cells[1].Value = dt.Rows[i]["nomeleitor"].ToString();
                dtv_hoje.Rows.Add(row);
            }
        }
    }
}

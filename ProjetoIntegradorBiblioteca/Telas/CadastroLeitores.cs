using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegrador_BibliotecasdeClasse;
using Microsoft.VisualBasic;


namespace ProjetoIntegradorBiblioteca
{
    public partial class Txt_NumeroEnd : UserControl
    {
        public Txt_NumeroEnd()
        {
            InitializeComponent();
            NovoEmpresimo();
            

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Leitores l = new Leitores();
                l = LerFormulario();
                l.Validacao();
                l.ValidaComplemento();
                l.Cadastrar();
                MessageBox.Show("CADASTRO FEITO COM SUCESSO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO NO CADASTRO:" + ex.Message);
            }



        }



        Leitores LerFormulario()
        {
            string dn, dia, mes, ano;
            Leitores l = new Leitores();

            l.Nome = Txt_NomeLeitor.Text;
            l.Cpf = Txt_CpfLeitor.Text;
            dia= dtp_leitor.Value.Date.Day.ToString();
            mes = dtp_leitor.Value.Month.ToString();
            ano = dtp_leitor.Value.Year.ToString();
            dn = $"{ano}-{mes}-{dia}";
            l.DataNasc = dn;
            l.Email = Txt_Email.Text;
            l.Telefone = Txt_Telefone.Text;
            l.Cep = Txt_Cep.Text;
            l.Estado = Txt_Estado.Text;
            l.Cidade = Txt_CidadeLeitor.Text;
            l.Bairro = Txt_Bairro.Text;
            l.Rua = Txt_Rua.Text;
            l.Numero = Txt_Numero.Text;

            return l;

        }

        void EscreveFormulario(Leitores l)
        {
            try
            {
                Txt_CodigoLeitor.Text = l.Codigo;

            }catch(Exception ex)
            {
                MessageBox.Show("ERRO: PRENCHIMENTO FORMÚLARIO" + ex.Message);
            }


            Txt_NomeLeitor.Text = l.Nome;
            Txt_CpfLeitor.Text = l.Cpf;

            dtp_leitor.Text = l.DataNasc;
            
            Txt_Email.Text = l.Email;
            Txt_Telefone.Text = l.Telefone;
            Txt_Cep.Text = l.Cep;
            Txt_Estado.Text = l.Estado;
            Txt_CidadeLeitor.Text = l.Cidade;
            Txt_Bairro.Text = l.Bairro;
            Txt_Rua.Text = l.Rua;
            Txt_Numero.Text = l.Numero;

        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Leitores l = new Leitores();

                var listaBusca = l.ListarTodos();


                BuscaLeitor c = new BuscaLeitor(listaBusca);
                c.ShowDialog();
                if(c.DialogResult == DialogResult.OK)
                {
                    var idSelected = c.idSelected;
                    l = l.Buscar(idSelected);

                    if(l == null)
                    {
                        MessageBox.Show("Leitor não encontrado");

                    }
                    else
                    {
                        EscreveFormulario(l);
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Erro na busca de leitor" + ex.Message);
            }
        }

        private void colarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Leitores l = new Leitores();
                l = LerFormulario();
                l.Validacao();
                l.Atualizar();
                MessageBox.Show("AUTULIZAÇÃO FEITO COM SUCESSO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO NO CADASTRO:" + ex.Message);
            }
        }

        private void recortarToolStripButton_Click(object sender, EventArgs e)
        {
            
            Txt_CodigoLeitor.Text = "";
            Txt_NomeLeitor.Text = "";
            Txt_CpfLeitor.Text = "";
            dtp_leitor.Text = "";
            Txt_Email.Text = "";
            Txt_Telefone.Text = "";
            Txt_Cep.Text ="";
            Txt_Estado.Text = "";
            Txt_CidadeLeitor.Text = "";
            Txt_Bairro.Text = "";
            Txt_Rua.Text = "";
            Txt_Numero.Text = "";
        }


        private void NovoEmpresimo()
        {

            try
            {
                var SQL = "SELECT * FROM cadleitor WHERE codleitor = (SELECT max(codleitor) FROM cadleitor)";
                var db = new MySQLServerClass();
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count == 0)
                {
                    Txt_CodigoLeitor.Text = "1";
                }
                else
                {
                    int codigoNovo;
                    ItemCombo x = new ItemCombo();
                    x.codigo = dt.Rows[0]["codleitor"].ToString();
                    codigoNovo = Convert.ToInt32(x.codigo);
                    codigoNovo++;
                    Txt_CodigoLeitor.Text = codigoNovo.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO!" + ex.Message);
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
    }


}

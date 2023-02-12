using ProjetoIntegrador_BibliotecasdeClasse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorBiblioteca.Telas
{
    public partial class CadastrodeLivros_UC : UserControl
    {
        
        
        public CadastrodeLivros_UC()
        {
            InitializeComponent();

            InserirAutores();
            InserirEditoras();
            InserirIdiomas();
            InserirGeneros();
            Novo();

            
          
        }

        private void AdiconarCódigo_Click(object sender, EventArgs e)
        {

            

        }

        void Novo()
        {
            try
            {
                var SQL = "SELECT * FROM cadlivro WHERE codlivro = (SELECT max(codlivro) FROM cadlivro)";
                var db = new MySQLServerClass();
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count == 0)
                {
                    Txt_Codigo.Text = "1";
                }
                else
                {
                    int codigoNovo;
                    ItemCombo x = new ItemCombo();
                    x.codigo = dt.Rows[0]["codlivro"].ToString();
                    codigoNovo = Convert.ToInt32(x.codigo);
                    codigoNovo++;
                    Txt_Codigo.Text = codigoNovo.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO!" + ex.Message);
            }

        }

        private void Btn_CadastrarAutor_Click(object sender, EventArgs e)
        {
            CadastroAutor frm = new CadastroAutor();
            frm.ShowDialog();
            InserirAutores();
        }

        private void Btn_CadastrarEditora_Click(object sender, EventArgs e)
        {
            CadastroEditora frm = new CadastroEditora();
            frm.ShowDialog();
            InserirEditoras();
        }

        private void Btn_CadastrarGenero_Click(object sender, EventArgs e)
        {
            CadastroGenero frm = new CadastroGenero();
            frm.ShowDialog();
            InserirGeneros();
        }

        private void Btn_CadastrarIdioma_Click(object sender, EventArgs e)
        {
            CadastroIdiomas frm = new CadastroIdiomas();
            frm.ShowDialog();
            InserirIdiomas();
        }


        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                Livros l = new Livros();
                l = LeituraFormulario();
                l.Validacao();
                l.Cadastrar();
                this.SalvarGeneros();
                
                MessageBox.Show("CADASTRO FEITO COM SUCESSO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO NO CADASTRO:" + ex.Message);
            }
        }

        #region "Funções Formulário"

        private void Btn_AdicionarGenero_Click(object sender, EventArgs e)
        {
            try
            {
                ItemCombo generoSelecionado = (ItemCombo)Cmb_Genero.Items[Cmb_Genero.SelectedIndex];
                Lbx_Genero.Items.Add(generoSelecionado);
            }
            catch(Exception ex)
            {

            }
            
        }

        #endregion

        #region "Funções ComboBox"


        public void InserirAutores()
        {
            try
            {
                string SQL = "SELECT * FROM autor";
                var bd = new MySQLServerClass();
                var dt = bd.SQLQuery(SQL);
                Cmb_Autor.Items.Clear();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    ItemCombo x = new ItemCombo();
                    x.codigo = dt.Rows[i]["codautor"].ToString();
                    x.nome = dt.Rows[i]["nomeautor"].ToString();
                    
                    Cmb_Autor.Items.Add(x);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public void InserirEditoras()
        {

            try
            {
                string SQL = "SELECT * FROM editora";
                var bd = new MySQLServerClass();
                var dt = bd.SQLQuery(SQL);
                Cmb_Editora.Items.Clear();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)                   
                {
                    ItemCombo x = new ItemCombo();
                    x.codigo = dt.Rows[i]["codeditora"].ToString();
                    x.nome = dt.Rows[i]["nomeeditora"].ToString();
            
                    Cmb_Editora.Items.Add(x);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void InserirIdiomas()
        {

            try
            {
                string SQL = "SELECT * FROM idiomaoriginal";
                var bd = new MySQLServerClass();
                var dt = bd.SQLQuery(SQL);
                Cmb_Idioma.Items.Clear();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    ItemCombo x = new ItemCombo();
                    x.codigo = dt.Rows[i]["codidioma"].ToString();
                    x.nome = dt.Rows[i]["nomeidioma"].ToString();                  
                    Cmb_Idioma.Items.Add(x);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void InserirGeneros()
        {

            try
            {
                string SQL = "SELECT * FROM genero";
                var bd = new MySQLServerClass();
                var dt = bd.SQLQuery(SQL);
                Cmb_Genero.Items.Clear();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    ItemCombo x = new ItemCombo();
                    x.codigo = dt.Rows[i]["codgenero"].ToString();
                    x.nome = dt.Rows[i]["nomegenero"].ToString();                 
                    Cmb_Genero.Items.Add(x);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        #endregion

        public void SalvarGeneros()
        {
            try
            {
                var livro = Txt_Codigo.Text;

                for (int i = 0; i <= Lbx_Genero.Items.Count - 1; i++)
                {
                    ItemCombo itens = (ItemCombo)Lbx_Genero.Items[i];

                    var bd = new MySQLServerClass();
                    var codigoGenero = itens.codigo;
                    var SQL = $"insert into generolivro (codgenero, codlivro) values ({codigoGenero},{livro})";
                    bd.SQLCommand(SQL);
                    bd.Close();
                }

               
            }catch(Exception ex)
            {
                throw new Exception("Erro em salvar Generos" + ex.Message);
            }
            

        }






        #region "Funções Complementares"
        Livros LeituraFormulario()
        {
            Livros l = new Livros();
            try
            {
                
                string dt, dia, mes, ano;

                l.Codigo = Txt_Codigo.Text;

                l.Titulo = Txt_Titulo.Text;

                dia = dtp_lancamento.Value.Day.ToString();
                mes = dtp_lancamento.Value.Month.ToString();
                ano = dtp_lancamento.Value.Year.ToString();
                dt = $"{ano}-{mes}-{dia}";
                l.Lancamento = dt;
                l.NumeroPag = Txt_Paginas.Text;

                // AUTOR
                
               

                    ItemCombo autorSelecionado = (ItemCombo)Cmb_Autor.Items[Cmb_Autor.SelectedIndex];
                    l.Autor = autorSelecionado.codigo;

                
              

                // EDITORA
                
                    ItemCombo editoraSelecionada = (ItemCombo)Cmb_Editora.Items[Cmb_Editora.SelectedIndex];
                    l.Editora = editoraSelecionada.codigo;

                //IDIOMA
               
                    ItemCombo IdiomaSelecionada = (ItemCombo)Cmb_Idioma.Items[Cmb_Idioma.SelectedIndex];
                    l.Idioma = IdiomaSelecionada.codigo;
               
                l.Status = "0";
                return l;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro NA LEITURA:" + ex.Message);
                return l;
            }
            


        }
        #endregion

        #region "Funções Auxiliares"

        DataTable procurarCodigo(string tabela, string campo, string itemSelecionado)
        {
            var SQL = $"SELECT * FROM {tabela} WHERE {campo} = {itemSelecionado}";
            var bd = new MySQLServerClass();
            var dt = bd.SQLQuery(SQL);
            return dt;
        }

        #endregion

        #region"Itens"
        class ItemCombo
        {
            public string codigo { get; set; }
            public string nome { get; set; }

            public override string ToString()
            {
                return nome;
            }
        }


        #endregion

        private void Acervo_Click(object sender, EventArgs e)
        {
            Acervo c = new Acervo();
            c.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LimpaFormulario();
            Novo();
        }


        void LimpaFormulario()
        {
            Txt_Codigo.Text = "";
            Txt_Titulo.Text = "";
            dtp_lancamento.Text = "";
            Txt_Paginas.Text = "";
            Cmb_Autor.Text = "";
            Cmb_Editora.Text = "";
            Cmb_Genero.Text = "";
            Cmb_Idioma.Text = "";
            Lbx_Genero.Items.Clear();
        }

    }
}

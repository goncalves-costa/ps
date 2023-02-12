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

namespace ProjetoIntegradorBiblioteca
{
    public partial class Acervo : Form
    {
        public Acervo()
        {
            string SQL = "select l.titulo, e.nomeeditora, a.nomeautor, l.numeropag, l.statuslivros, l.codlivro from cadlivro l join editora e on l.codeditora = e.codeditora join autor a on l.codautor = a.codautor";
            InitializeComponent();
            EscreveTabela(SQL);
            EscreveComboBox();
        }

        void EscreveTabela(string SQL)
        {
            var bd = new MySQLServerClass();
            var dt = bd.SQLQuery(SQL);
            dgv_ResultadoPesquisa.Rows.Clear();

            for (int i = 0; i <= dt.Rows.Count -1; i++)
            {
                
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgv_ResultadoPesquisa);
                row.Cells[0].Value = dt.Rows[i]["codlivro"].ToString();
                row.Cells[1].Value = dt.Rows[i]["titulo"].ToString();
                row.Cells[2].Value = dt.Rows[i]["nomeautor"].ToString();
                row.Cells[3].Value = dt.Rows[i]["nomeeditora"].ToString();
                var status = dt.Rows[i]["statuslivros"].ToString();
                if (status == null || status == "")
                {
                    row.Cells[4].Value = "Disponível";
                    row.Cells[4].Style.ForeColor = Color.Green;
                }
                else
                {
                    var teste = Convert.ToInt32(status);
                    if (teste == 0)
                    {
                        row.Cells[4].Value = "Disponível";                      
                        row.Cells[4].Style.ForeColor = Color.Green ;
                    }
                    else if (teste == 1)
                    {
                        row.Cells[4].Value = "Emprestado";
                        row.Cells[4].Style.ForeColor = Color.Red;
                    }
                }

                dgv_ResultadoPesquisa.Rows.Add(row);



            }    

        }

        void EscreveComboBox()
        {
            Cmb_EscolhaPesquisa.Items.Add("Código");
            Cmb_EscolhaPesquisa.Items.Add("Título");
            Cmb_EscolhaPesquisa.Items.Add("Editora");
            Cmb_EscolhaPesquisa.Items.Add("Autor");
        }
        void EscreveGenero()
        {
            try
            {
                DataGridViewRow row = dgv_ResultadoPesquisa.SelectedRows[0];
                string codigoLivro = row.Cells[0].Value.ToString();
                string SQL = $"select g.nomegenero  from generolivro gl join genero g on gl.codgenero = g.codgenero where gl.codlivro = {codigoLivro};";
                var bd = new MySQLServerClass();
                var dt = bd.SQLQuery(SQL);
                dgv_Generos.Rows.Clear();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    DataGridViewRow row2 = new DataGridViewRow();
                    row2.CreateCells(dgv_Generos);
                    row2.Cells[0].Value = dt.Rows[i]["nomegenero"].ToString();
                    dgv_Generos.Rows.Add(row2);
                }
            }
            catch(Exception ex)
            {

            }
            
        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            var op = Cmb_EscolhaPesquisa.SelectedIndex;
            string busca = Txt_BarraPesquisa.Text;
            string SQL;

            while (true)
            {
                switch (op)
                {
                    case 0:
                        SQL = $"select l.titulo, e.nomeeditora, a.nomeautor, l.numeropag, l.statuslivros, l.codlivro from cadlivro l join editora e on l.codeditora = e.codeditora join autor a on l.codautor = a.codautor where l.codlivro = {busca};";
                        EscreveTabela(SQL);
                        return;

                    case 1:
                        SQL = $"select l.titulo, e.nomeeditora, a.nomeautor, l.numeropag, l.statuslivros, l.codlivro from cadlivro l join editora e on l.codeditora = e.codeditora join autor a on l.codautor = a.codautor where l.titulo = '{busca}';";
                        EscreveTabela(SQL);
                        return;
                    case 2:
                        SQL = $"select l.titulo, e.nomeeditora, a.nomeautor, l.numeropag, l.statuslivros, l.codlivro from cadlivro l join editora e on l.codeditora = e.codeditora join autor a on l.codautor = a.codautor where e.nomeeditora = '{busca}';";
                        EscreveTabela(SQL);
                        return;
                    case 3:
                        SQL = $"select l.titulo, e.nomeeditora, a.nomeautor, l.numeropag, l.statuslivros, l.codlivro from cadlivro l join editora e on l.codeditora = e.codeditora join autor a on l.codautor = a.codautor where a.nomeautor = '{busca}';";
                        EscreveTabela(SQL);
                        return;
                    case 4:
                        SQL = $"select l.titulo, e.nomeeditora, a.nomeautor, l.numeropag, l.statuslivros, l.codlivro from cadlivro l join editora e on l.codeditora = e.codeditora join autor a on l.codautor = a.codautor where l.nomeeditora = '{busca}';";
                        EscreveTabela(SQL);
                        return;
                    case 5:

                        return;
                    default:
                        SQL = "select l.titulo, e.nomeeditora, a.nomeautor, l.numeropag, l.statuslivros, l.codlivro from cadlivro l join editora e on l.codeditora = e.codeditora join autor a on l.codautor = a.codautor";
                        EscreveTabela(SQL);
                        return;
                }
                
            }
        }

        private void dgv_ResultadoPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EscreveGenero();
        }

        private void Acervo_Load(object sender, EventArgs e)
        {

        }
    }
}

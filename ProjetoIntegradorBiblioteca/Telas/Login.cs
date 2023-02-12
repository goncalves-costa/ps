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
    public partial class Login : Form
    {

        public string usuario;
        public string senha;
        public string nomeFunc;

        public Login(string nome)
        {
            InitializeComponent();
            label1.Text = nome;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            senha = Txt_Senha.Text;
            usuario = Txt_usuario.Text;
            string senhacerta;

            var bd = new MySQLServerClass();
            string SQL = $"select senha, codfunc, nomefunc from cadfunc where email = '{usuario}'";
            var dt = bd.SQLQuery(SQL);

            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Erro na busca!");
            }
            else
            {
                senhacerta = dt.Rows[0]["senha"].ToString();
                usuario = dt.Rows[0]["codfunc"].ToString();
                nomeFunc = dt.Rows[0]["nomefunc"].ToString();

                if(senha == senhacerta)
                {
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Usuário encontrado!");
                    this.Close();
                }
                else
                {
                    
                    MessageBox.Show("Senha errada!");
                    return;
                }
            }
            

        }
    }
}

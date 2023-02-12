using ProjetoIntegrador_BibliotecasdeClasse;
using ProjetoIntegradorBiblioteca.Telas;
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
    public partial class Frm_TelaPrincipal : Form
    {
        private string codigofunc { get; set; }
        private string NomeFunc { get; set; }
        public Frm_TelaPrincipal()
        {
            InitializeComponent();
            emprestimosToolStripMenuItem.Enabled = false;
            leitoresToolStripMenuItem.Enabled = false;
            livrosToolStripMenuItem.Enabled = false;
            funcionáriosToolStripMenuItem.Enabled = false;
            sairToolStripMenuItem.Enabled = false;
            conectarToolStripMenuItem.Enabled = true;
        }

        private void cadastrarNovoLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrodeLivros_UC c = new CadastrodeLivros_UC();
            TabPage tb = new TabPage();
            tb.Name = "Cadastro de Livros";
            tb.Text = "Cadastro de Livros";
            tb.Controls.Add(c);
            Tbc_Principal.TabPages.Add(tb);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emprestimosToolStripMenuItem.Enabled = false;
            leitoresToolStripMenuItem.Enabled = false;
            livrosToolStripMenuItem.Enabled = false;
            funcionáriosToolStripMenuItem.Enabled = false;
            sairToolStripMenuItem.Enabled = false;
            conectarToolStripMenuItem.Enabled = true;
            nomeecodigo.Text = "";
            codigofunc = "Funcionário Desconectado";
            ApagaEsquerda(Tbc_Principal.SelectedIndex);
            ApagaDireita(Tbc_Principal.SelectedIndex);
            ApagaAba(Tbc_Principal.SelectedTab);
        }

        private void fazerEmprestimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmprestimosLivros c = new EmprestimosLivros(codigofunc);
            TabPage tb = new TabPage();
            tb.Name = "Realizar Empréstimo";
            tb.Text = "Realizar Empréstimo";
            tb.Controls.Add(c);
            Tbc_Principal.TabPages.Add(tb);
        }

        private void cadastrarNovoLeitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Txt_NumeroEnd c = new Txt_NumeroEnd();
            TabPage tb = new TabPage();
            tb.Name = "Cadastro de Leitores";
            tb.Text = "Cadastro de Leitores";
            tb.Controls.Add(c);
            Tbc_Principal.TabPages.Add(tb);

        }



        private void acervoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acervo a = new Acervo();
            a.ShowDialog();
            
        }

        private void realizarDevoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devolucao_UC c = new Devolucao_UC(codigofunc, NomeFunc);
            TabPage tb = new TabPage();
            tb.Name = "Relizar Devolução";
            tb.Text = "Realizar Devolução";
            tb.Controls.Add(c);
            Tbc_Principal.TabPages.Add(tb);

        }

        private void cadastrarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFuncionario_UC c = new CadastroFuncionario_UC(codigofunc);
            TabPage tb = new TabPage();
            tb.Name = "Cadastro Funcionário";
            tb.Text = "Cadastro Funcionário";
            tb.Controls.Add(c);
            Tbc_Principal.TabPages.Add(tb);
        }

        private void Frm_TelaPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
           

        }
        void vToolTip001_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Principal.SelectedTab == null))
            {
                ApagaAba(Tbc_Principal.SelectedTab);
            }
        }
        void vToolTip002_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Principal.SelectedTab == null))
            {
                ApagaEsquerda(Tbc_Principal.SelectedIndex);
            }
        }
        void vToolTip003_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Principal.SelectedTab == null))
            {
                ApagaDireita(Tbc_Principal.SelectedIndex);
            }
        }
        void vToolTip004_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Principal.SelectedTab == null))
            {
                ApagaEsquerda(Tbc_Principal.SelectedIndex);
                ApagaDireita(Tbc_Principal.SelectedIndex);
            }
        }
        ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = text;
            Image MyImage = (Image)global::ProjetoIntegradorBiblioteca.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            vToolTip.Image = MyImage;
            return vToolTip;
        }

        void ApagaDireita(int ItemSelecionado)
        {
            for (int i = Tbc_Principal.TabCount - 1;
                   i > ItemSelecionado; i += -1)
            {
                ApagaAba(Tbc_Principal.TabPages[i]);
            }
        }

        void ApagaEsquerda(int ItemSelecionado)
        {
            for (int i = ItemSelecionado - 1; i >= 0; i += -1)
            {
                ApagaAba(Tbc_Principal.TabPages[i]);
            }
        }

   
        void ApagaAba(TabPage tb)
        {
            Tbc_Principal.TabPages.Remove(tb);
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login("Login");
            l.ShowDialog();
            if(l.DialogResult == DialogResult.OK)
            {
                emprestimosToolStripMenuItem.Enabled = true;
                leitoresToolStripMenuItem.Enabled = true;
                livrosToolStripMenuItem.Enabled = true;
                funcionáriosToolStripMenuItem.Enabled = true;
                sairToolStripMenuItem.Enabled = true;
                conectarToolStripMenuItem.Enabled = false;
            }
            codigofunc = l.usuario;
            nomeecodigo.Text = codigofunc + " - " + l.nomeFunc;
            NomeFunc = l.nomeFunc;
            
        }

        private void Mn_Strip_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Tbc_Principal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var ContextMenu = new ContextMenuStrip();
                var vToolTip001 = DesenhaItemMenu("Apagar a Aba", "DeleteTab");
                var vToolTip002 = DesenhaItemMenu("Apagar Todas as Esquerda", "DeleteLeft");
                var vToolTip003 = DesenhaItemMenu("Apagar Todas as Direita", "DeleteRight");
                var vToolTip004 = DesenhaItemMenu("Apagar Todas menos Esta", "DeleteAll");
                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);
                ContextMenu.Items.Add(vToolTip003);
                ContextMenu.Items.Add(vToolTip004);
                ContextMenu.Show(this, new Point(e.X, e.Y));
                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
                vToolTip003.Click += new System.EventHandler(vToolTip003_Click);
                vToolTip004.Click += new System.EventHandler(vToolTip004_Click);

            }
        }

        private void emprestimosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

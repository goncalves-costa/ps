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
    public partial class BuscaLeitor : Form
    {
        List<List<string>> _listaBusca = new List<List<string>>();
        public string idSelected { get; set; }
        public BuscaLeitor(List<List<string>> listaBusca)
        {
            _listaBusca = listaBusca;
            InitializeComponent();
            this.Text = "Busca de Leitores";
            PreencherLista();
           
        }

        public void PreencherLista()
        {
            Lst_BuscaLeitor.Items.Clear();
            for(int i = 0; i <= _listaBusca.Count -1; i++)
            {
                ItemBox x = new ItemBox();
                x.id = _listaBusca[i][0];
                x.nome = _listaBusca[i][1];

                Lst_BuscaLeitor.Items.Add(x);
            }
        }



        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
           
        }


        class ItemBox
        {
            public string id { get; set; }
            public string nome { get; set; }

            public override string ToString()
            {
                return nome;
            }
        }

        private void Lst_BuscaLeitor_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ItemBox itemSelecionado = (ItemBox)Lst_BuscaLeitor.Items[Lst_BuscaLeitor.SelectedIndex];
            idSelected = itemSelecionado.id;
            this.Close();
        }
    }
}

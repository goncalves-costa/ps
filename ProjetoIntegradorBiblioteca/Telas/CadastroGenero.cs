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
    public partial class CadastroGenero : Form
    {
        public CadastroGenero()
        {
            InitializeComponent();
        }

        private void generoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.generoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);
            }
            catch(Exception ex)
            {

            }
            

        }

        private void CadastroGenero_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.genero'. Você pode movê-la ou removê-la conforme necessário.
            this.generoTableAdapter.Fill(this.bibliotecaDataSet.genero);

        }
    }
}

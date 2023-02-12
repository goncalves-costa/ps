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
    public partial class CadastroIdiomas : Form
    {
        public CadastroIdiomas()
        {
            InitializeComponent();
        }

        private void idiomaoriginalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.idiomaoriginalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void CadastroIdiomas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.idiomaoriginal'. Você pode movê-la ou removê-la conforme necessário.
            this.idiomaoriginalTableAdapter.Fill(this.bibliotecaDataSet.idiomaoriginal);

        }
    }
}


namespace ProjetoIntegradorBiblioteca
{
    partial class CadastroIdiomas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroIdiomas));
            this.bibliotecaDataSet = new ProjetoIntegradorBiblioteca.bibliotecaDataSet();
            this.idiomaoriginalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idiomaoriginalTableAdapter = new ProjetoIntegradorBiblioteca.bibliotecaDataSetTableAdapters.idiomaoriginalTableAdapter();
            this.tableAdapterManager = new ProjetoIntegradorBiblioteca.bibliotecaDataSetTableAdapters.TableAdapterManager();
            this.idiomaoriginalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.idiomaoriginalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idiomaoriginalDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaoriginalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaoriginalBindingNavigator)).BeginInit();
            this.idiomaoriginalBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaoriginalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idiomaoriginalBindingSource
            // 
            this.idiomaoriginalBindingSource.DataMember = "idiomaoriginal";
            this.idiomaoriginalBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // idiomaoriginalTableAdapter
            // 
            this.idiomaoriginalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.autorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cadfuncTableAdapter = null;
            this.tableAdapterManager.cadleitorTableAdapter = null;
            this.tableAdapterManager.cadlivroTableAdapter = null;
            this.tableAdapterManager.editoraTableAdapter = null;
            this.tableAdapterManager.emprestimolivroTableAdapter = null;
            this.tableAdapterManager.emprestimoTableAdapter = null;
            this.tableAdapterManager.generolivroTableAdapter = null;
            this.tableAdapterManager.generoTableAdapter = null;
            this.tableAdapterManager.idiomaoriginalTableAdapter = this.idiomaoriginalTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoIntegradorBiblioteca.bibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idiomaoriginalBindingNavigator
            // 
            this.idiomaoriginalBindingNavigator.AddNewItem = null;
            this.idiomaoriginalBindingNavigator.BindingSource = this.idiomaoriginalBindingSource;
            this.idiomaoriginalBindingNavigator.CountItem = null;
            this.idiomaoriginalBindingNavigator.DeleteItem = null;
            this.idiomaoriginalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idiomaoriginalBindingNavigatorSaveItem});
            this.idiomaoriginalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.idiomaoriginalBindingNavigator.MoveFirstItem = null;
            this.idiomaoriginalBindingNavigator.MoveLastItem = null;
            this.idiomaoriginalBindingNavigator.MoveNextItem = null;
            this.idiomaoriginalBindingNavigator.MovePreviousItem = null;
            this.idiomaoriginalBindingNavigator.Name = "idiomaoriginalBindingNavigator";
            this.idiomaoriginalBindingNavigator.PositionItem = null;
            this.idiomaoriginalBindingNavigator.Size = new System.Drawing.Size(517, 25);
            this.idiomaoriginalBindingNavigator.TabIndex = 0;
            this.idiomaoriginalBindingNavigator.Text = "bindingNavigator1";
            // 
            // idiomaoriginalBindingNavigatorSaveItem
            // 
            this.idiomaoriginalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.idiomaoriginalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("idiomaoriginalBindingNavigatorSaveItem.Image")));
            this.idiomaoriginalBindingNavigatorSaveItem.Name = "idiomaoriginalBindingNavigatorSaveItem";
            this.idiomaoriginalBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.idiomaoriginalBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.idiomaoriginalBindingNavigatorSaveItem.Click += new System.EventHandler(this.idiomaoriginalBindingNavigatorSaveItem_Click);
            // 
            // idiomaoriginalDataGridView
            // 
            this.idiomaoriginalDataGridView.AutoGenerateColumns = false;
            this.idiomaoriginalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idiomaoriginalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.idiomaoriginalDataGridView.DataSource = this.idiomaoriginalBindingSource;
            this.idiomaoriginalDataGridView.Location = new System.Drawing.Point(30, 53);
            this.idiomaoriginalDataGridView.Name = "idiomaoriginalDataGridView";
            this.idiomaoriginalDataGridView.Size = new System.Drawing.Size(475, 220);
            this.idiomaoriginalDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codidioma";
            this.dataGridViewTextBoxColumn1.HeaderText = "codidioma";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeidioma";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomeidioma";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro de Idiomas";
            // 
            // CadastroIdiomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idiomaoriginalDataGridView);
            this.Controls.Add(this.idiomaoriginalBindingNavigator);
            this.Name = "CadastroIdiomas";
            this.Text = "CadastroIdiomas";
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaoriginalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaoriginalBindingNavigator)).EndInit();
            this.idiomaoriginalBindingNavigator.ResumeLayout(false);
            this.idiomaoriginalBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idiomaoriginalDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource idiomaoriginalBindingSource;
        private bibliotecaDataSetTableAdapters.idiomaoriginalTableAdapter idiomaoriginalTableAdapter;
        private bibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator idiomaoriginalBindingNavigator;
        private System.Windows.Forms.ToolStripButton idiomaoriginalBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView idiomaoriginalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
    }
}
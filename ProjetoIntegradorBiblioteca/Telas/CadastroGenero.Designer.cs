
namespace ProjetoIntegradorBiblioteca
{
    partial class CadastroGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroGenero));
            this.label1 = new System.Windows.Forms.Label();
            this.bibliotecaDataSet = new ProjetoIntegradorBiblioteca.bibliotecaDataSet();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generoTableAdapter = new ProjetoIntegradorBiblioteca.bibliotecaDataSetTableAdapters.generoTableAdapter();
            this.tableAdapterManager = new ProjetoIntegradorBiblioteca.bibliotecaDataSetTableAdapters.TableAdapterManager();
            this.generoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.generoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.generoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingNavigator)).BeginInit();
            this.generoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Gênero";
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "genero";
            this.generoBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.generoTableAdapter = this.generoTableAdapter;
            this.tableAdapterManager.idiomaoriginalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoIntegradorBiblioteca.bibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // generoBindingNavigator
            // 
            this.generoBindingNavigator.AddNewItem = null;
            this.generoBindingNavigator.BindingSource = this.generoBindingSource;
            this.generoBindingNavigator.CountItem = null;
            this.generoBindingNavigator.DeleteItem = null;
            this.generoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generoBindingNavigatorSaveItem});
            this.generoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.generoBindingNavigator.MoveFirstItem = null;
            this.generoBindingNavigator.MoveLastItem = null;
            this.generoBindingNavigator.MoveNextItem = null;
            this.generoBindingNavigator.MovePreviousItem = null;
            this.generoBindingNavigator.Name = "generoBindingNavigator";
            this.generoBindingNavigator.PositionItem = null;
            this.generoBindingNavigator.Size = new System.Drawing.Size(462, 25);
            this.generoBindingNavigator.TabIndex = 1;
            this.generoBindingNavigator.Text = "bindingNavigator1";
            // 
            // generoBindingNavigatorSaveItem
            // 
            this.generoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.generoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("generoBindingNavigatorSaveItem.Image")));
            this.generoBindingNavigatorSaveItem.Name = "generoBindingNavigatorSaveItem";
            this.generoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.generoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.generoBindingNavigatorSaveItem.Click += new System.EventHandler(this.generoBindingNavigatorSaveItem_Click);
            // 
            // generoDataGridView
            // 
            this.generoDataGridView.AutoGenerateColumns = false;
            this.generoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.generoDataGridView.DataSource = this.generoBindingSource;
            this.generoDataGridView.Location = new System.Drawing.Point(12, 84);
            this.generoDataGridView.Name = "generoDataGridView";
            this.generoDataGridView.Size = new System.Drawing.Size(450, 132);
            this.generoDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codgenero";
            this.dataGridViewTextBoxColumn1.HeaderText = "codgenero";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomegenero";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomegenero";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // CadastroGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 342);
            this.Controls.Add(this.generoDataGridView);
            this.Controls.Add(this.generoBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "CadastroGenero";
            this.Text = "CadastroGenero";
            this.Load += new System.EventHandler(this.CadastroGenero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingNavigator)).EndInit();
            this.generoBindingNavigator.ResumeLayout(false);
            this.generoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private bibliotecaDataSetTableAdapters.generoTableAdapter generoTableAdapter;
        private bibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator generoBindingNavigator;
        private System.Windows.Forms.ToolStripButton generoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView generoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
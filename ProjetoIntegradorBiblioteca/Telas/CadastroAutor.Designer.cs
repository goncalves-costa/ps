
namespace ProjetoIntegradorBiblioteca
{
    partial class CadastroAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroAutor));
            this.label1 = new System.Windows.Forms.Label();
            this.bibliotecaDataSet = new ProjetoIntegradorBiblioteca.bibliotecaDataSet();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorTableAdapter = new ProjetoIntegradorBiblioteca.bibliotecaDataSetTableAdapters.autorTableAdapter();
            this.tableAdapterManager = new ProjetoIntegradorBiblioteca.bibliotecaDataSetTableAdapters.TableAdapterManager();
            this.autorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.autorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.autorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingNavigator)).BeginInit();
            this.autorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Autor(a)";
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataMember = "autor";
            this.autorBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // autorTableAdapter
            // 
            this.autorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.autorTableAdapter = this.autorTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cadfuncTableAdapter = null;
            this.tableAdapterManager.cadleitorTableAdapter = null;
            this.tableAdapterManager.cadlivroTableAdapter = null;
            this.tableAdapterManager.editoraTableAdapter = null;
            this.tableAdapterManager.emprestimolivroTableAdapter = null;
            this.tableAdapterManager.emprestimoTableAdapter = null;
            this.tableAdapterManager.generolivroTableAdapter = null;
            this.tableAdapterManager.generoTableAdapter = null;
            this.tableAdapterManager.idiomaoriginalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoIntegradorBiblioteca.bibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // autorBindingNavigator
            // 
            this.autorBindingNavigator.AddNewItem = null;
            this.autorBindingNavigator.BindingSource = this.autorBindingSource;
            this.autorBindingNavigator.CountItem = null;
            this.autorBindingNavigator.DeleteItem = null;
            this.autorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorBindingNavigatorSaveItem});
            this.autorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.autorBindingNavigator.MoveFirstItem = null;
            this.autorBindingNavigator.MoveLastItem = null;
            this.autorBindingNavigator.MoveNextItem = null;
            this.autorBindingNavigator.MovePreviousItem = null;
            this.autorBindingNavigator.Name = "autorBindingNavigator";
            this.autorBindingNavigator.PositionItem = null;
            this.autorBindingNavigator.Size = new System.Drawing.Size(463, 25);
            this.autorBindingNavigator.TabIndex = 1;
            this.autorBindingNavigator.Text = "bindingNavigator1";
            // 
            // autorBindingNavigatorSaveItem
            // 
            this.autorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.autorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("autorBindingNavigatorSaveItem.Image")));
            this.autorBindingNavigatorSaveItem.Name = "autorBindingNavigatorSaveItem";
            this.autorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.autorBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.autorBindingNavigatorSaveItem.Click += new System.EventHandler(this.autorBindingNavigatorSaveItem_Click);
            // 
            // autorDataGridView
            // 
            this.autorDataGridView.AutoGenerateColumns = false;
            this.autorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.autorDataGridView.DataSource = this.autorBindingSource;
            this.autorDataGridView.Location = new System.Drawing.Point(24, 61);
            this.autorDataGridView.Name = "autorDataGridView";
            this.autorDataGridView.Size = new System.Drawing.Size(410, 220);
            this.autorDataGridView.TabIndex = 2;
            this.autorDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.autorDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codautor";
            this.dataGridViewTextBoxColumn1.HeaderText = "codautor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeautor";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomeautor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // CadastroAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 307);
            this.Controls.Add(this.autorDataGridView);
            this.Controls.Add(this.autorBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "CadastroAutor";
            this.Text = "CadastroAutor";
            this.Load += new System.EventHandler(this.CadastroAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingNavigator)).EndInit();
            this.autorBindingNavigator.ResumeLayout(false);
            this.autorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private bibliotecaDataSetTableAdapters.autorTableAdapter autorTableAdapter;
        private bibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator autorBindingNavigator;
        private System.Windows.Forms.ToolStripButton autorBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView autorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

namespace ProjetoIntegradorBiblioteca
{
    partial class CadastroEditora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroEditora));
            this.label1 = new System.Windows.Forms.Label();
            this.bibliotecaDataSet = new ProjetoIntegradorBiblioteca.bibliotecaDataSet();
            this.editoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editoraTableAdapter = new ProjetoIntegradorBiblioteca.bibliotecaDataSetTableAdapters.editoraTableAdapter();
            this.tableAdapterManager = new ProjetoIntegradorBiblioteca.bibliotecaDataSetTableAdapters.TableAdapterManager();
            this.editoraBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.editoraBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.editoraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingNavigator)).BeginInit();
            this.editoraBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editoraDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Editora";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editoraBindingSource
            // 
            this.editoraBindingSource.DataMember = "editora";
            this.editoraBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // editoraTableAdapter
            // 
            this.editoraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.autorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cadfuncTableAdapter = null;
            this.tableAdapterManager.cadleitorTableAdapter = null;
            this.tableAdapterManager.cadlivroTableAdapter = null;
            this.tableAdapterManager.editoraTableAdapter = this.editoraTableAdapter;
            this.tableAdapterManager.emprestimolivroTableAdapter = null;
            this.tableAdapterManager.emprestimoTableAdapter = null;
            this.tableAdapterManager.generolivroTableAdapter = null;
            this.tableAdapterManager.generoTableAdapter = null;
            this.tableAdapterManager.idiomaoriginalTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoIntegradorBiblioteca.bibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // editoraBindingNavigator
            // 
            this.editoraBindingNavigator.AddNewItem = null;
            this.editoraBindingNavigator.BindingSource = this.editoraBindingSource;
            this.editoraBindingNavigator.CountItem = null;
            this.editoraBindingNavigator.DeleteItem = null;
            this.editoraBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editoraBindingNavigatorSaveItem});
            this.editoraBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.editoraBindingNavigator.MoveFirstItem = null;
            this.editoraBindingNavigator.MoveLastItem = null;
            this.editoraBindingNavigator.MoveNextItem = null;
            this.editoraBindingNavigator.MovePreviousItem = null;
            this.editoraBindingNavigator.Name = "editoraBindingNavigator";
            this.editoraBindingNavigator.PositionItem = null;
            this.editoraBindingNavigator.Size = new System.Drawing.Size(671, 25);
            this.editoraBindingNavigator.TabIndex = 1;
            this.editoraBindingNavigator.Text = "bindingNavigator1";
            // 
            // editoraBindingNavigatorSaveItem
            // 
            this.editoraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editoraBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("editoraBindingNavigatorSaveItem.Image")));
            this.editoraBindingNavigatorSaveItem.Name = "editoraBindingNavigatorSaveItem";
            this.editoraBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.editoraBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.editoraBindingNavigatorSaveItem.Click += new System.EventHandler(this.editoraBindingNavigatorSaveItem_Click);
            // 
            // editoraDataGridView
            // 
            this.editoraDataGridView.AutoGenerateColumns = false;
            this.editoraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editoraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.editoraDataGridView.DataSource = this.editoraBindingSource;
            this.editoraDataGridView.Location = new System.Drawing.Point(32, 90);
            this.editoraDataGridView.Name = "editoraDataGridView";
            this.editoraDataGridView.Size = new System.Drawing.Size(544, 220);
            this.editoraDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codeditora";
            this.dataGridViewTextBoxColumn1.HeaderText = "codeditora";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeeditora";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomeeditora";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cnpjeditora";
            this.dataGridViewTextBoxColumn3.HeaderText = "cnpjeditora";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cidadeeditora";
            this.dataGridViewTextBoxColumn4.HeaderText = "cidadeeditora";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "estadoeditora";
            this.dataGridViewTextBoxColumn5.HeaderText = "estadoeditora";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // CadastroEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 348);
            this.Controls.Add(this.editoraDataGridView);
            this.Controls.Add(this.editoraBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "CadastroEditora";
            this.Text = "CadastroEditora";
            this.Load += new System.EventHandler(this.CadastroEditora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingNavigator)).EndInit();
            this.editoraBindingNavigator.ResumeLayout(false);
            this.editoraBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editoraDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private bibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource editoraBindingSource;
        private bibliotecaDataSetTableAdapters.editoraTableAdapter editoraTableAdapter;
        private bibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator editoraBindingNavigator;
        private System.Windows.Forms.ToolStripButton editoraBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView editoraDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
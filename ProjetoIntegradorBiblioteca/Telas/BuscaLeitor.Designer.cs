
namespace ProjetoIntegradorBiblioteca
{
    partial class BuscaLeitor
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Lst_BuscaLeitor = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(617, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Lst_BuscaLeitor
            // 
            this.Lst_BuscaLeitor.FormattingEnabled = true;
            this.Lst_BuscaLeitor.Location = new System.Drawing.Point(12, 68);
            this.Lst_BuscaLeitor.Name = "Lst_BuscaLeitor";
            this.Lst_BuscaLeitor.Size = new System.Drawing.Size(593, 173);
            this.Lst_BuscaLeitor.TabIndex = 1;
            this.Lst_BuscaLeitor.DoubleClick += new System.EventHandler(this.Lst_BuscaLeitor_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Leitor";
            // 
            // BuscaLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lst_BuscaLeitor);
            this.Controls.Add(this.toolStrip1);
            this.Name = "BuscaLeitor";
            this.Text = "BuscaLeitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListBox Lst_BuscaLeitor;
        private System.Windows.Forms.Label label1;
    }
}

namespace Library
{
    partial class knjigaClani
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
            this.vrnitevGrid = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avtor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oddelek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrni = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vrnitevGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // vrnitevGrid
            // 
            this.vrnitevGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vrnitevGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.Avtor,
            this.leto,
            this.oddelek,
            this.vrni});
            this.vrnitevGrid.Location = new System.Drawing.Point(12, 12);
            this.vrnitevGrid.Name = "vrnitevGrid";
            this.vrnitevGrid.Size = new System.Drawing.Size(545, 417);
            this.vrnitevGrid.TabIndex = 0;
            // 
            // title
            // 
            this.title.HeaderText = "Naslov";
            this.title.Name = "title";
            // 
            // Avtor
            // 
            this.Avtor.HeaderText = "Avtor";
            this.Avtor.Name = "Avtor";
            // 
            // leto
            // 
            this.leto.HeaderText = "Leto";
            this.leto.Name = "leto";
            // 
            // oddelek
            // 
            this.oddelek.HeaderText = "Oddelek";
            this.oddelek.Name = "oddelek";
            // 
            // vrni
            // 
            this.vrni.HeaderText = "Vrnitev knjig";
            this.vrni.Name = "vrni";
            // 
            // knjigaClani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vrnitevGrid);
            this.Name = "knjigaClani";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vrnitevGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vrnitevGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avtor;
        private System.Windows.Forms.DataGridViewTextBoxColumn leto;
        private System.Windows.Forms.DataGridViewTextBoxColumn oddelek;
        private System.Windows.Forms.DataGridViewButtonColumn vrni;
    }
}
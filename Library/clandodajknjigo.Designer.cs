namespace Library
{
    partial class clandodajknjigo
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
            this.ckgrid = new System.Windows.Forms.DataGridView();
            this.searchbar = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.inv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nasl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avtor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.let = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reserve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nazajbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ckgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ckgrid
            // 
            this.ckgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ckgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ckgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inv,
            this.nasl,
            this.avtor,
            this.let,
            this.sec,
            this.publ,
            this.reserve});
            this.ckgrid.Location = new System.Drawing.Point(-3, 123);
            this.ckgrid.Name = "ckgrid";
            this.ckgrid.Size = new System.Drawing.Size(1148, 485);
            this.ckgrid.TabIndex = 1;
            this.ckgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ckgrid_CellContentClick);
            // 
            // searchbar
            // 
            this.searchbar.Location = new System.Drawing.Point(12, 44);
            this.searchbar.Name = "searchbar";
            this.searchbar.Size = new System.Drawing.Size(342, 20);
            this.searchbar.TabIndex = 2;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(360, 44);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(58, 20);
            this.searchbutton.TabIndex = 3;
            this.searchbutton.Text = "isci";
            this.searchbutton.UseVisualStyleBackColor = true;
            // 
            // inv
            // 
            this.inv.HeaderText = "Inventarna st";
            this.inv.Name = "inv";
            // 
            // nasl
            // 
            this.nasl.HeaderText = "Naslov";
            this.nasl.Name = "nasl";
            // 
            // avtor
            // 
            this.avtor.HeaderText = "Avtor";
            this.avtor.Name = "avtor";
            this.avtor.Width = 250;
            // 
            // let
            // 
            this.let.HeaderText = "Leto";
            this.let.Name = "let";
            // 
            // sec
            // 
            this.sec.HeaderText = "Sections";
            this.sec.Name = "sec";
            this.sec.Width = 200;
            // 
            // publ
            // 
            this.publ.HeaderText = "Publisher";
            this.publ.Name = "publ";
            this.publ.Width = 250;
            // 
            // reserve
            // 
            this.reserve.HeaderText = "Izposodi";
            this.reserve.Name = "reserve";
            // 
            // nazajbutton
            // 
            this.nazajbutton.Location = new System.Drawing.Point(12, 614);
            this.nazajbutton.Name = "nazajbutton";
            this.nazajbutton.Size = new System.Drawing.Size(109, 49);
            this.nazajbutton.TabIndex = 4;
            this.nazajbutton.Text = "Nazaj";
            this.nazajbutton.UseVisualStyleBackColor = true;
            this.nazajbutton.Click += new System.EventHandler(this.nazajbutton_Click);
            // 
            // clandodajknjigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 696);
            this.Controls.Add(this.nazajbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchbar);
            this.Controls.Add(this.ckgrid);
            this.Name = "clandodajknjigo";
            this.Text = "clandodajknjigo";
            ((System.ComponentModel.ISupportInitialize)(this.ckgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ckgrid;
        private System.Windows.Forms.TextBox searchbar;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn inv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nasl;
        private System.Windows.Forms.DataGridViewTextBoxColumn avtor;
        private System.Windows.Forms.DataGridViewTextBoxColumn let;
        private System.Windows.Forms.DataGridViewTextBoxColumn sec;
        private System.Windows.Forms.DataGridViewTextBoxColumn publ;
        private System.Windows.Forms.DataGridViewButtonColumn reserve;
        private System.Windows.Forms.Button nazajbutton;
    }
}
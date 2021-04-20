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
            this.inv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nasl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avtor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.let = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reserve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.searchbar = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.nazajbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ckgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ckgrid
            // 
            this.ckgrid.AllowUserToAddRows = false;
            this.ckgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.ckgrid.Location = new System.Drawing.Point(12, 61);
            this.ckgrid.Name = "ckgrid";
            this.ckgrid.Size = new System.Drawing.Size(1146, 485);
            this.ckgrid.TabIndex = 1;
            this.ckgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ckgrid_CellContentClick);
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
            // 
            // publ
            // 
            this.publ.HeaderText = "Publisher";
            this.publ.Name = "publ";
            // 
            // reserve
            // 
            this.reserve.HeaderText = "Izposodi";
            this.reserve.Name = "reserve";
            // 
            // searchbar
            // 
            this.searchbar.Location = new System.Drawing.Point(12, 35);
            this.searchbar.Name = "searchbar";
            this.searchbar.Size = new System.Drawing.Size(342, 20);
            this.searchbar.TabIndex = 2;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(360, 35);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(81, 21);
            this.searchbutton.TabIndex = 3;
            this.searchbutton.Text = "Išči";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // nazajbutton
            // 
            this.nazajbutton.Location = new System.Drawing.Point(12, 564);
            this.nazajbutton.Name = "nazajbutton";
            this.nazajbutton.Size = new System.Drawing.Size(109, 49);
            this.nazajbutton.TabIndex = 4;
            this.nazajbutton.Text = "Nazaj";
            this.nazajbutton.UseVisualStyleBackColor = true;
            this.nazajbutton.Click += new System.EventHandler(this.nazajbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Iskanje knjig:";
            // 
            // clandodajknjigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazajbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchbar);
            this.Controls.Add(this.ckgrid);
            this.MaximumSize = new System.Drawing.Size(1195, 664);
            this.Name = "clandodajknjigo";
            this.Text = "Dodaj knjigo članu";
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
        private System.Windows.Forms.Label label1;
    }
}
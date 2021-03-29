
namespace Library
{
    partial class main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.knjigegrid = new System.Windows.Forms.DataGridView();
            this.inv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nasl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avtor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.let = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.usersgrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knjigegrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1288, 620);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.knjigegrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1280, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Izpis";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // knjigegrid
            // 
            this.knjigegrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.knjigegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.knjigegrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inv,
            this.nasl,
            this.avtor,
            this.let,
            this.sec,
            this.publ});
            this.knjigegrid.Location = new System.Drawing.Point(-20, 113);
            this.knjigegrid.Name = "knjigegrid";
            this.knjigegrid.Size = new System.Drawing.Size(1100, 485);
            this.knjigegrid.TabIndex = 0;
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1280, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dodajanje";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.usersgrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1280, 594);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Člani";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // usersgrid
            // 
            this.usersgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.surname,
            this.tel,
            this.ad});
            this.usersgrid.Location = new System.Drawing.Point(6, 35);
            this.usersgrid.Name = "usersgrid";
            this.usersgrid.Size = new System.Drawing.Size(1036, 239);
            this.usersgrid.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "Ime";
            this.name.Name = "name";
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.Name = "surname";
            // 
            // tel
            // 
            this.tel.HeaderText = "Telefon";
            this.tel.Name = "tel";
            // 
            // ad
            // 
            this.ad.HeaderText = "Naslov";
            this.ad.Name = "ad";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 634);
            this.Controls.Add(this.tabControl1);
            this.Name = "main";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.knjigegrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView knjigegrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn inv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nasl;
        private System.Windows.Forms.DataGridViewTextBoxColumn avtor;
        private System.Windows.Forms.DataGridViewTextBoxColumn let;
        private System.Windows.Forms.DataGridViewTextBoxColumn sec;
        private System.Windows.Forms.DataGridViewTextBoxColumn publ;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView usersgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
    }
}


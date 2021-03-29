
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nasl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avtor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.let = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.dodajanjeClanovPage = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.imeBox = new System.Windows.Forms.TextBox();
            this.priimekBox = new System.Windows.Forms.TextBox();
            this.telefonBox = new System.Windows.Forms.TextBox();
            this.naslovBox = new System.Windows.Forms.TextBox();
            this.gmailBox = new System.Windows.Forms.TextBox();
            this.opombeBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dodajClanaButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.dodajanjeClanovPage.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1015, 620);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1280, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Izpis";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inv,
            this.nasl,
            this.avtor,
            this.let,
            this.sec,
            this.publ});
            this.dataGridView1.Location = new System.Drawing.Point(-32, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1268, 485);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1007, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dodajanje";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1280, 594);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Člani";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.dodajanjeClanovPage);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(991, 582);
            this.tabControl2.TabIndex = 0;
            // 
            // dodajanjeClanovPage
            // 
            this.dodajanjeClanovPage.Controls.Add(this.dodajClanaButton);
            this.dodajanjeClanovPage.Controls.Add(this.label8);
            this.dodajanjeClanovPage.Controls.Add(this.label7);
            this.dodajanjeClanovPage.Controls.Add(this.label6);
            this.dodajanjeClanovPage.Controls.Add(this.label5);
            this.dodajanjeClanovPage.Controls.Add(this.label4);
            this.dodajanjeClanovPage.Controls.Add(this.label3);
            this.dodajanjeClanovPage.Controls.Add(this.label2);
            this.dodajanjeClanovPage.Controls.Add(this.label1);
            this.dodajanjeClanovPage.Controls.Add(this.opombeBox);
            this.dodajanjeClanovPage.Controls.Add(this.gmailBox);
            this.dodajanjeClanovPage.Controls.Add(this.naslovBox);
            this.dodajanjeClanovPage.Controls.Add(this.telefonBox);
            this.dodajanjeClanovPage.Controls.Add(this.priimekBox);
            this.dodajanjeClanovPage.Controls.Add(this.imeBox);
            this.dodajanjeClanovPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajanjeClanovPage.Location = new System.Drawing.Point(4, 22);
            this.dodajanjeClanovPage.Name = "dodajanjeClanovPage";
            this.dodajanjeClanovPage.Padding = new System.Windows.Forms.Padding(3);
            this.dodajanjeClanovPage.Size = new System.Drawing.Size(983, 556);
            this.dodajanjeClanovPage.TabIndex = 0;
            this.dodajanjeClanovPage.Text = "Dodajanje članov";
            this.dodajanjeClanovPage.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(192, 74);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // imeBox
            // 
            this.imeBox.Location = new System.Drawing.Point(369, 133);
            this.imeBox.Name = "imeBox";
            this.imeBox.Size = new System.Drawing.Size(323, 23);
            this.imeBox.TabIndex = 0;
            // 
            // priimekBox
            // 
            this.priimekBox.Location = new System.Drawing.Point(369, 159);
            this.priimekBox.Name = "priimekBox";
            this.priimekBox.Size = new System.Drawing.Size(323, 23);
            this.priimekBox.TabIndex = 1;
            // 
            // telefonBox
            // 
            this.telefonBox.Location = new System.Drawing.Point(369, 185);
            this.telefonBox.Name = "telefonBox";
            this.telefonBox.Size = new System.Drawing.Size(323, 23);
            this.telefonBox.TabIndex = 2;
            // 
            // naslovBox
            // 
            this.naslovBox.Location = new System.Drawing.Point(369, 212);
            this.naslovBox.Name = "naslovBox";
            this.naslovBox.Size = new System.Drawing.Size(323, 23);
            this.naslovBox.TabIndex = 3;
            // 
            // gmailBox
            // 
            this.gmailBox.Location = new System.Drawing.Point(369, 239);
            this.gmailBox.Name = "gmailBox";
            this.gmailBox.Size = new System.Drawing.Size(323, 23);
            this.gmailBox.TabIndex = 4;
            // 
            // opombeBox
            // 
            this.opombeBox.Location = new System.Drawing.Point(369, 266);
            this.opombeBox.Name = "opombeBox";
            this.opombeBox.Size = new System.Drawing.Size(323, 96);
            this.opombeBox.TabIndex = 5;
            this.opombeBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "*Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "*Priimek:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "*Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Naslov:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(297, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Opombe:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(378, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "DODAJANJE ČLANOV";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(366, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Polja označena z * so obvezna.";
            // 
            // dodajClanaButton
            // 
            this.dodajClanaButton.Location = new System.Drawing.Point(369, 410);
            this.dodajClanaButton.Name = "dodajClanaButton";
            this.dodajClanaButton.Size = new System.Drawing.Size(323, 50);
            this.dodajClanaButton.TabIndex = 14;
            this.dodajClanaButton.Text = "DODAJ";
            this.dodajClanaButton.UseVisualStyleBackColor = true;
            this.dodajClanaButton.Click += new System.EventHandler(this.dodajClanaButton_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 634);
            this.Controls.Add(this.tabControl1);
            this.Name = "main";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.dodajanjeClanovPage.ResumeLayout(false);
            this.dodajanjeClanovPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nasl;
        private System.Windows.Forms.DataGridViewTextBoxColumn avtor;
        private System.Windows.Forms.DataGridViewTextBoxColumn let;
        private System.Windows.Forms.DataGridViewTextBoxColumn sec;
        private System.Windows.Forms.DataGridViewTextBoxColumn publ;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage dodajanjeClanovPage;
        private System.Windows.Forms.Button dodajClanaButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox opombeBox;
        private System.Windows.Forms.TextBox naslovBox;
        private System.Windows.Forms.TextBox telefonBox;
        private System.Windows.Forms.TextBox priimekBox;
        private System.Windows.Forms.TextBox imeBox;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox gmailBox;
    }
}


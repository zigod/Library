
namespace Library
{
    partial class spremeniStatus
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
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priimek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enaslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izposodi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.iskanjeTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usersGridView
            // 
            this.usersGridView.AllowUserToAddRows = false;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Priimek,
            this.Telefon,
            this.enaslov,
            this.izposodi,
            this.id});
            this.usersGridView.Location = new System.Drawing.Point(18, 94);
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.Size = new System.Drawing.Size(597, 502);
            this.usersGridView.TabIndex = 0;
            this.usersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGridView_CellContentClick);
            // 
            // Ime
            // 
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Priimek
            // 
            this.Priimek.HeaderText = "Priimek";
            this.Priimek.Name = "Priimek";
            this.Priimek.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // enaslov
            // 
            this.enaslov.HeaderText = "E-naslov";
            this.enaslov.Name = "enaslov";
            this.enaslov.ReadOnly = true;
            this.enaslov.Width = 150;
            // 
            // izposodi
            // 
            this.izposodi.HeaderText = "Izposodi";
            this.izposodi.Name = "izposodi";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iskanje uporabnikov:";
            // 
            // iskanjeTextBox
            // 
            this.iskanjeTextBox.Location = new System.Drawing.Point(18, 51);
            this.iskanjeTextBox.Name = "iskanjeTextBox";
            this.iskanjeTextBox.Size = new System.Drawing.Size(216, 20);
            this.iskanjeTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(253, 51);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(108, 20);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Išči";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // spremeniStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 608);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.iskanjeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersGridView);
            this.Name = "spremeniStatus";
            this.Text = "spremeniStatus";
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usersGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iskanjeTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priimek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn enaslov;
        private System.Windows.Forms.DataGridViewButtonColumn izposodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}
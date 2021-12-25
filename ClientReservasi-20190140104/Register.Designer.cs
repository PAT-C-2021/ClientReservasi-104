
namespace ClientReservasi_20190140104
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.tBoxUsername = new System.Windows.Forms.TextBox();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.cBoxKategori = new System.Windows.Forms.ComboBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvRegister = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori";
            // 
            // tBoxID
            // 
            this.tBoxID.Location = new System.Drawing.Point(12, 12);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(70, 22);
            this.tBoxID.TabIndex = 3;
            // 
            // tBoxUsername
            // 
            this.tBoxUsername.Location = new System.Drawing.Point(252, 58);
            this.tBoxUsername.Name = "tBoxUsername";
            this.tBoxUsername.Size = new System.Drawing.Size(237, 22);
            this.tBoxUsername.TabIndex = 4;
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Location = new System.Drawing.Point(252, 107);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.PasswordChar = '*';
            this.tBoxPassword.Size = new System.Drawing.Size(237, 22);
            this.tBoxPassword.TabIndex = 5;
            // 
            // cBoxKategori
            // 
            this.cBoxKategori.FormattingEnabled = true;
            this.cBoxKategori.Items.AddRange(new object[] {
            "Admin",
            "Resepsionis"});
            this.cBoxKategori.Location = new System.Drawing.Point(252, 158);
            this.cBoxKategori.Name = "cBoxKategori";
            this.cBoxKategori.Size = new System.Drawing.Size(237, 24);
            this.cBoxKategori.TabIndex = 6;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(538, 55);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(90, 40);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(538, 122);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 40);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(538, 186);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(90, 40);
            this.btnHapus.TabIndex = 9;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(399, 198);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 40);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvRegister
            // 
            this.dgvRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegister.Location = new System.Drawing.Point(12, 269);
            this.dgvRegister.Name = "dgvRegister";
            this.dgvRegister.RowHeadersWidth = 51;
            this.dgvRegister.RowTemplate.Height = 24;
            this.dgvRegister.Size = new System.Drawing.Size(776, 169);
            this.dgvRegister.TabIndex = 11;
            this.dgvRegister.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegister_CellClick);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.dgvRegister);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.cBoxKategori);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.tBoxUsername);
            this.Controls.Add(this.tBoxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxID;
        private System.Windows.Forms.TextBox tBoxUsername;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.ComboBox cBoxKategori;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvRegister;
    }
}
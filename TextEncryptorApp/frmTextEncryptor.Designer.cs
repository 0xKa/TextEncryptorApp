namespace TextEncryptorApp
{
    partial class frmTextEnrcryptor
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtTextAfter = new System.Windows.Forms.TextBox();
            this.txtTextBefore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.mtxtEncryptionKey = new System.Windows.Forms.MaskedTextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEncrypt.FlatAppearance.BorderSize = 2;
            this.btnEncrypt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEncrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEncrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(464, 253);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(167, 44);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtTextAfter
            // 
            this.txtTextAfter.Location = new System.Drawing.Point(213, 185);
            this.txtTextAfter.Multiline = true;
            this.txtTextAfter.Name = "txtTextAfter";
            this.txtTextAfter.ReadOnly = true;
            this.txtTextAfter.Size = new System.Drawing.Size(235, 112);
            this.txtTextAfter.TabIndex = 6;
            // 
            // txtTextBefore
            // 
            this.txtTextBefore.Location = new System.Drawing.Point(213, 61);
            this.txtTextBefore.Multiline = true;
            this.txtTextBefore.Name = "txtTextBefore";
            this.txtTextBefore.Size = new System.Drawing.Size(235, 112);
            this.txtTextBefore.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter a Text:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter an Encryption Key:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Result:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(464, 153);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(167, 44);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // mtxtEncryptionKey
            // 
            this.mtxtEncryptionKey.Location = new System.Drawing.Point(213, 19);
            this.mtxtEncryptionKey.Mask = "00";
            this.mtxtEncryptionKey.Name = "mtxtEncryptionKey";
            this.mtxtEncryptionKey.Size = new System.Drawing.Size(235, 20);
            this.mtxtEncryptionKey.TabIndex = 12;
            this.mtxtEncryptionKey.Text = "05";
            this.mtxtEncryptionKey.ValidatingType = typeof(int);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrypt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDecrypt.FlatAppearance.BorderSize = 2;
            this.btnDecrypt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDecrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDecrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(464, 203);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(167, 44);
            this.btnDecrypt.TabIndex = 13;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // frmTextEnrcryptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(643, 344);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.mtxtEncryptionKey);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtTextAfter);
            this.Controls.Add(this.txtTextBefore);
            this.Name = "frmTextEnrcryptor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Encryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtTextAfter;
        private System.Windows.Forms.TextBox txtTextBefore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MaskedTextBox mtxtEncryptionKey;
        private System.Windows.Forms.Button btnDecrypt;
    }
}


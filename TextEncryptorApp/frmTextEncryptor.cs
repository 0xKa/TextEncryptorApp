using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEncryptorApp
{
    public partial class frmTextEnrcryptor : Form
    {
        public frmTextEnrcryptor()
        {
            InitializeComponent();
        }

        bool isTextBoxEmpty(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                return true;
            }

            return false;
        }
        bool isTextBoxEmpty(MaskedTextBox mtextBox)
        { //overload
            if (mtextBox.Text == "")
            {
                return true;
            }

            return false;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (isTextBoxEmpty(txtTextBefore) || isTextBoxEmpty(mtxtEncryptionKey))
            {
                MessageBox.Show("Please Enter an Encryption Key and a Text to Encrypt", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            int Key = Convert.ToInt32(mtxtEncryptionKey.Text);
            string Text = txtTextBefore.Text;
            string Result = "";

            for (int i = 0; i < Text.Length; i++)
            {
                Result += (char) (Convert.ToInt32(Text[i]) + Key);
            }

            txtTextAfter.Text = Result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mtxtEncryptionKey.Text = "05";
            txtTextBefore.Text = "";
            txtTextAfter.Text = "";
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (isTextBoxEmpty(txtTextBefore) || isTextBoxEmpty(mtxtEncryptionKey))
            {
                MessageBox.Show("Please Enter an Encryption Key and a Text to Encrypt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Key = Convert.ToInt32(mtxtEncryptionKey.Text);
            string Text = txtTextBefore.Text;
            string Result = "";

            for (int i = 0; i < Text.Length; i++)
            {
                Result += (char)(Convert.ToInt32(Text[i]) - Key);
            }

            txtTextAfter.Text = Result;
        }
    }
}

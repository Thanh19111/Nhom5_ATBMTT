using Rijndael256;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rijndael = Rijndael256.Rijndael;

namespace AES_Encryption
{
    public partial class AES_Encryption : Form
    {
        public AES_Encryption()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inputText = txtemess.Text;
            var key = txtekey.Text;
            string EncryptText = Rijndael.Encrypt(inputText, key, KeySize.Aes256);
            txtecipher.Text = EncryptText;
        }
       
        
        private void button2_Click(object sender, EventArgs e)
        {
            var inputText = txtdcipher.Text;
            string key = txtdk.Text;
            string DecryptText = Rijndael.Decrypt(inputText, key, KeySize.Aes256);
            txtdmess.Text = DecryptText;
        }

        

        

        
        

    }
}

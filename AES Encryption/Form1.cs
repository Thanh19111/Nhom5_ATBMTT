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
        String mess;

        private void button1_Click(object sender, EventArgs e)
        {
            var inputText = mess = txtemess.Text.Trim();
            var key = txtekey.Text.Trim();
            if(String.IsNullOrEmpty(key))
            {
                key = GenerateRandomKey(256);
                txtekey.Text = key;
            }
            try
            {
                string EncryptText = Rijndael.Encrypt(inputText, key, KeySize.Aes256);
                txtecipher.Text = EncryptText;
                MessageBox.Show("Mã hóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình mã hóa dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var inputText = txtdcipher.Text.Trim();
                string key = txtdk.Text;
                string DecryptText = Rijndael.Decrypt(inputText, key, KeySize.Aes256);
                if (DecryptText.Length > 0 && !DecryptText.Equals(txtemess.Text.Trim()))
                {
                    MessageBox.Show("Bản mã đã bị sửa đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         
                }else
                {
                    MessageBox.Show("Giải mã thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                txtdmess.Text = DecryptText;
            }
            catch (CryptographicException ex)
            {
                if (ex.Message.Contains("Padding is invalid and cannot be removed"))
                {
                    MessageBox.Show("Khóa đầu vào không hợp lệ hoặc đã bị sửa đổi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Bản mã bị thay đổi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bản mã bị thay đổi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string GenerateRandomKey(int keySizeInBits)
        {
            int keySizeInBytes = keySizeInBits / 8;
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] key = new byte[keySizeInBytes];
                rng.GetBytes(key);
                return Convert.ToBase64String(key);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //test
            MessageBox.Show(GenerateRandomKey(256));
        }
    }
}

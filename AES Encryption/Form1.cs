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
            String mess = txtemess.Text;

            Byte[] Key = GenerateRandomBytes(16);
            Byte[] IV = GenerateRandomBytes(16);

            String res = Encrypt(mess, Key, IV);

            txteiv.Text = Convert.ToBase64String(IV);
            txtekey.Text = Convert.ToBase64String(Key);
            txtecipher.Text = res;
        }
        public static byte[] HexToBytes(string hex)
        {
            if (hex.Length % 2 != 0)
                throw new ArgumentException("Hex string must have an even length.");

            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < hex.Length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            byte[] key = Convert.FromBase64String(txtdk.Text);
            byte[] iv = Convert.FromBase64String(txtdiv.Text);
    
            String res = Decrypt(txtdcipher.Text, key, iv);
            txtdmess.Text = res;
        }

        public static byte[] GenerateRandomBytes(int length)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[length];
                rng.GetBytes(randomBytes);
                return randomBytes;
            }
        }

        public static string Encrypt(string plaintext, byte[] key, byte[] iv)
        {
            if (key.Length != 16 && key.Length != 24 && key.Length != 32)
            {
                throw new CryptographicException("The specified key is not a valid size for this algorithm.");
            }
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                byte[] encrypted = encryptor.TransformFinalBlock(Encoding.UTF8.GetBytes(plaintext), 0, plaintext.Length);

                return Convert.ToBase64String(encrypted);
            }
        }

        public static string Decrypt(string ciphertext, byte[] key, byte[] iv)
        {
            if (key.Length != 16 && key.Length != 24 && key.Length != 32)
            {
                throw new CryptographicException("The specified key is not a valid size for this algorithm.");
            }

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                try
                {
                    byte[] cipherBytes = Convert.FromBase64String(ciphertext);
                    byte[] decrypted = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                    return Encoding.UTF8.GetString(decrypted);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Base64 string");
                    return null;
                }
                catch (CryptographicException e)
                {
                    MessageBox.Show("Error during decryption: " + e.Message);
                    return null;
                }
            }
        }
    }
}

﻿using Rijndael256;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Rijndael = Rijndael256.Rijndael;

namespace AES_Encryption
{
    public partial class AES_Encryption : Form
    {
        public AES_Encryption()
        {
            InitializeComponent();
            items = new string[] { "AES_128", "AES_192", "AES_256" };
        }
        string[] items;
        String mess;

        private void button1_Click(object sender, EventArgs e)
        {

            AES_Encrypt();
        }
        private void AES_Encrypt()
        {
            var inputText = mess = txtemess.Text.Trim();
            mess = inputText;
            var key = txtekey.Text.Trim();

            if (String.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("Bản mã không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbo.SelectedIndex == 0)
            {
                if (String.IsNullOrEmpty(key))
                {
                    key = GenerateRandomKey(128);
                    txtekey.Text = key;
                }
                try
                {
                    string EncryptText = Rijndael.Encrypt(inputText, key, KeySize.Aes128);
                    txtecipher.Text = EncryptText;
                    MessageBox.Show("Mã hóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình mã hóa dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cbo.SelectedIndex == 1)
            {
                if (String.IsNullOrEmpty(key))
                {
                    key = GenerateRandomKey(192);
                    txtekey.Text = key;
                }
                try
                {
                    string EncryptText = Rijndael.Encrypt(inputText, key, KeySize.Aes192);
                    txtecipher.Text = EncryptText;
                    MessageBox.Show("Mã hóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình mã hóa dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cbo.SelectedIndex == 2)
            {
                if (String.IsNullOrEmpty(key))
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
            else
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình chọn không gian khóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            AES_Decrypt();
        }
        private void AES_Decrypt()
        {
            try
            {
                var inputText = txtdcipher.Text.Trim();
      
                string key = txtdk.Text.Trim();

                if (String.IsNullOrWhiteSpace(inputText))
                {
                    MessageBox.Show("Bản mã không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (String.IsNullOrWhiteSpace(key))
                {
                    MessageBox.Show("Khóa không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string DecryptText;
                if (cbo.SelectedIndex == 0)
                {
                     DecryptText = Rijndael.Decrypt(inputText, key, KeySize.Aes128);
                }else if(cbo.SelectedIndex == 1)
                {
                    DecryptText = Rijndael.Decrypt(inputText, key, KeySize.Aes192);
                }
                else if(cbo.SelectedIndex == 2)
                {
                    DecryptText = Rijndael.Decrypt(inputText, key, KeySize.Aes256);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình chọn không gian khóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (DecryptText.Length > 0 && !DecryptText.Equals(mess))
                {
                    txtdmess.Text = DecryptText;
                    MessageBox.Show("Bản mã đã bị sửa đổi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    txtdmess.Text = DecryptText;
                    MessageBox.Show("Giải mã thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (CryptographicException ex)
            {
                if (ex.Message.Contains("Padding is invalid and cannot be removed"))
                {
                    MessageBox.Show("Khóa đầu vào hoặc bản mã nhập vào không hợp lệ hoặc đã bị sửa đổi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button4_Click(object sender, EventArgs e)
        {
            txtemess.Clear();
            txtekey.Clear();
            txtecipher.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void WriteFile(string fileName, string content)
        {
            string filePath = fileName;
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(content);
            }

            MessageBox.Show("Ghi file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ReadFile(string fileName, TextBox name)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                StringBuilder res = new StringBuilder();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    res.Append(line);
                }
                if (String.IsNullOrEmpty(res.ToString()))
                {
                    MessageBox.Show("File " + fileName + " không có dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    name.Text = res.ToString();
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //tab1 Nhap
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Chọn tệp";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fullPath = openFileDialog.FileName;
                ReadFile(fullPath, txtemess);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //tab1 ghi
            string content = txtecipher.Text.Trim();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Lưu tệp";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.AddExtension = true;
            saveFileDialog.OverwritePrompt = false;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                WriteFile(filePath, content);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //tab2 // nhap
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Chọn tệp";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fullPath = openFileDialog.FileName;
                ReadFile(fullPath, txtdcipher);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string content = txtemess.Text.Trim();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Lưu tệp";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.AddExtension = true;

            saveFileDialog.OverwritePrompt = false;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                WriteFile(filePath, content);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtdcipher.Clear();
            txtdk.Clear();
            txtdmess.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtdk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdcipher_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtdmess_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtecipher_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AES_Encryption_Load(object sender, EventArgs e)
        {
            loadCBO();
        }

        public void loadCBO()
        {
            cbo.DataSource = items;
            cbo.SelectedIndex = 0;
        }

        private void txtemess_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Chọn tệp";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fullPath = openFileDialog.FileName;
                ReadFile(fullPath, txtdcipher);
            }
        }
    }
}

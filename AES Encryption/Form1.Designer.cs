﻿namespace AES_Encryption
{
    partial class AES_Encryption
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtekey = new System.Windows.Forms.TextBox();
            this.txtecipher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemess = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtdk = new System.Windows.Forms.TextBox();
            this.txtdmess = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdcipher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtekey);
            this.groupBox1.Controls.Add(this.txtecipher);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtemess);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(580, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encryption";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtekey
            // 
            this.txtekey.Location = new System.Drawing.Point(133, 193);
            this.txtekey.Name = "txtekey";
            this.txtekey.Size = new System.Drawing.Size(350, 30);
            this.txtekey.TabIndex = 7;
            // 
            // txtecipher
            // 
            this.txtecipher.Location = new System.Drawing.Point(133, 255);
            this.txtecipher.Margin = new System.Windows.Forms.Padding(4);
            this.txtecipher.Multiline = true;
            this.txtecipher.Name = "txtecipher";
            this.txtecipher.ReadOnly = true;
            this.txtecipher.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtecipher.Size = new System.Drawing.Size(350, 118);
            this.txtecipher.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cipher";
            // 
            // txtemess
            // 
            this.txtemess.Location = new System.Drawing.Point(133, 31);
            this.txtemess.Margin = new System.Windows.Forms.Padding(4);
            this.txtemess.Multiline = true;
            this.txtemess.Name = "txtemess";
            this.txtemess.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtemess.Size = new System.Drawing.Size(350, 118);
            this.txtemess.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtdk);
            this.groupBox2.Controls.Add(this.txtdmess);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtdcipher);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(579, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(565, 496);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decryption";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtdk
            // 
            this.txtdk.Location = new System.Drawing.Point(133, 193);
            this.txtdk.Name = "txtdk";
            this.txtdk.Size = new System.Drawing.Size(350, 30);
            this.txtdk.TabIndex = 7;
            // 
            // txtdmess
            // 
            this.txtdmess.Location = new System.Drawing.Point(133, 255);
            this.txtdmess.Margin = new System.Windows.Forms.Padding(4);
            this.txtdmess.Multiline = true;
            this.txtdmess.Name = "txtdmess";
            this.txtdmess.ReadOnly = true;
            this.txtdmess.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtdmess.Size = new System.Drawing.Size(350, 118);
            this.txtdmess.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Message";
            // 
            // txtdcipher
            // 
            this.txtdcipher.Location = new System.Drawing.Point(133, 31);
            this.txtdcipher.Margin = new System.Windows.Forms.Padding(4);
            this.txtdcipher.Multiline = true;
            this.txtdcipher.Name = "txtdcipher";
            this.txtdcipher.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtdcipher.Size = new System.Drawing.Size(350, 118);
            this.txtdcipher.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Key";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cipher";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(400, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 40);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AES_Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AES_Encryption";
            this.Text = "AES Encryption";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtemess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtecipher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtekey;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtdk;
        private System.Windows.Forms.TextBox txtdmess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdcipher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


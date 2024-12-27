namespace AES_Encryption
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtekey = new System.Windows.Forms.TextBox();
            this.txtecipher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemess = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdcipher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdmess = new System.Windows.Forms.TextBox();
            this.txtdk = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtekey);
            this.groupBox1.Controls.Add(this.txtecipher);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtemess);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(950, 516);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã Hóa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(624, 459);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 40);
            this.button4.TabIndex = 10;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(269, 459);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 40);
            this.button3.TabIndex = 9;
            this.button3.Text = "Nhập";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(507, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Mã hóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtekey
            // 
            this.txtekey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtekey.Location = new System.Drawing.Point(134, 211);
            this.txtekey.Name = "txtekey";
            this.txtekey.Size = new System.Drawing.Size(748, 30);
            this.txtekey.TabIndex = 7;
            // 
            // txtecipher
            // 
            this.txtecipher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtecipher.Location = new System.Drawing.Point(134, 280);
            this.txtecipher.Margin = new System.Windows.Forms.Padding(4);
            this.txtecipher.Multiline = true;
            this.txtecipher.Name = "txtecipher";
            this.txtecipher.ReadOnly = true;
            this.txtecipher.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtecipher.Size = new System.Drawing.Size(748, 121);
            this.txtecipher.TabIndex = 5;
            this.txtecipher.TextChanged += new System.EventHandler(this.txtecipher_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 323);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bản mã";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtemess
            // 
            this.txtemess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtemess.Location = new System.Drawing.Point(134, 49);
            this.txtemess.Margin = new System.Windows.Forms.Padding(4);
            this.txtemess.Multiline = true;
            this.txtemess.Name = "txtemess";
            this.txtemess.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtemess.Size = new System.Drawing.Size(748, 95);
            this.txtemess.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bản rõ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 557);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(956, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mã hóa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.Location = new System.Drawing.Point(390, 459);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 40);
            this.button7.TabIndex = 11;
            this.button7.Text = "Ghi";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtdk);
            this.groupBox2.Controls.Add(this.txtdmess);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtdcipher);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(973, 516);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giải Mã";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bản mã";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Khóa";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtdcipher
            // 
            this.txtdcipher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdcipher.Location = new System.Drawing.Point(136, 53);
            this.txtdcipher.Margin = new System.Windows.Forms.Padding(4);
            this.txtdcipher.Multiline = true;
            this.txtdcipher.Name = "txtdcipher";
            this.txtdcipher.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtdcipher.Size = new System.Drawing.Size(787, 96);
            this.txtdcipher.TabIndex = 3;
            this.txtdcipher.TextChanged += new System.EventHandler(this.txtdcipher_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bản rõ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtdmess
            // 
            this.txtdmess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdmess.Location = new System.Drawing.Point(136, 284);
            this.txtdmess.Margin = new System.Windows.Forms.Padding(4);
            this.txtdmess.Multiline = true;
            this.txtdmess.Name = "txtdmess";
            this.txtdmess.ReadOnly = true;
            this.txtdmess.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtdmess.Size = new System.Drawing.Size(787, 116);
            this.txtdmess.TabIndex = 5;
            this.txtdmess.TextChanged += new System.EventHandler(this.txtdmess_TextChanged);
            // 
            // txtdk
            // 
            this.txtdk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdk.Location = new System.Drawing.Point(136, 211);
            this.txtdk.Name = "txtdk";
            this.txtdk.Size = new System.Drawing.Size(787, 30);
            this.txtdk.TabIndex = 7;
            this.txtdk.TextChanged += new System.EventHandler(this.txtdk_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(520, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Giải mã";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(282, 460);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 40);
            this.button5.TabIndex = 10;
            this.button5.Text = "Nhập";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Location = new System.Drawing.Point(641, 460);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 40);
            this.button6.TabIndex = 11;
            this.button6.Text = "Xóa";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.Location = new System.Drawing.Point(402, 460);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 40);
            this.button8.TabIndex = 12;
            this.button8.Text = "Ghi";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(979, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Giải mã";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbo
            // 
            this.cbo.FormattingEnabled = true;
            this.cbo.Location = new System.Drawing.Point(5, 20);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(82, 30);
            this.cbo.TabIndex = 12;
            // 
            // AES_Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 557);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AES_Encryption";
            this.Text = "Mã hóa AES";
            this.Load += new System.EventHandler(this.AES_Encryption_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
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
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtdk;
        private System.Windows.Forms.TextBox txtdmess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdcipher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo;
    }
}


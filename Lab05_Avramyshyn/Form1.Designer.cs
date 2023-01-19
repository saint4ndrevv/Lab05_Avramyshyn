namespace Lab05_Avramyshyn
{
    partial class Form1
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
            this.label_time = new System.Windows.Forms.Label();
            this.bClean = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelOutLength = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelInLength = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tOutFilePath = new System.Windows.Forms.TextBox();
            this.tInFilePath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rB_SHA512 = new System.Windows.Forms.RadioButton();
            this.rB_SHA384 = new System.Windows.Forms.RadioButton();
            this.rB_SHA256 = new System.Windows.Forms.RadioButton();
            this.rB_SHA1 = new System.Windows.Forms.RadioButton();
            this.rB_MD5 = new System.Windows.Forms.RadioButton();
            this.rB_RIPEMD160 = new System.Windows.Forms.RadioButton();
            this.rB_HAVAL = new System.Windows.Forms.RadioButton();
            this.rB_CRC32 = new System.Windows.Forms.RadioButton();
            this.bOutFile = new System.Windows.Forms.Button();
            this.bInFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(594, 366);
            this.label_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(44, 16);
            this.label_time.TabIndex = 40;
            this.label_time.Text = "label7";
            // 
            // bClean
            // 
            this.bClean.Location = new System.Drawing.Point(423, 430);
            this.bClean.Margin = new System.Windows.Forms.Padding(2);
            this.bClean.Name = "bClean";
            this.bClean.Size = new System.Drawing.Size(87, 24);
            this.bClean.TabIndex = 39;
            this.bClean.Text = "Очистити";
            this.bClean.UseVisualStyleBackColor = true;
            this.bClean.Click += new System.EventHandler(this.bClean_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(312, 430);
            this.bStart.Margin = new System.Windows.Forms.Padding(2);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(94, 24);
            this.bStart.TabIndex = 38;
            this.bStart.Text = "Виконати";
            this.bStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelOutLength);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(529, 294);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(238, 64);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Оцінка розміру (Байти) : ";
            // 
            // labelOutLength
            // 
            this.labelOutLength.AutoSize = true;
            this.labelOutLength.Location = new System.Drawing.Point(146, 29);
            this.labelOutLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOutLength.Name = "labelOutLength";
            this.labelOutLength.Size = new System.Drawing.Size(44, 16);
            this.labelOutLength.TabIndex = 1;
            this.labelOutLength.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Вихідного файлу :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelInLength);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(529, 221);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(238, 51);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оцінка розміру (Мбайт) :";
            // 
            // labelInLength
            // 
            this.labelInLength.AutoSize = true;
            this.labelInLength.Location = new System.Drawing.Point(143, 26);
            this.labelInLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInLength.Name = "labelInLength";
            this.labelInLength.Size = new System.Drawing.Size(0, 16);
            this.labelInLength.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Вхідного файлу :";
            // 
            // tOutFilePath
            // 
            this.tOutFilePath.Location = new System.Drawing.Point(329, 167);
            this.tOutFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.tOutFilePath.Name = "tOutFilePath";
            this.tOutFilePath.Size = new System.Drawing.Size(351, 22);
            this.tOutFilePath.TabIndex = 35;
            // 
            // tInFilePath
            // 
            this.tInFilePath.Location = new System.Drawing.Point(329, 137);
            this.tInFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.tInFilePath.Name = "tInFilePath";
            this.tInFilePath.Size = new System.Drawing.Size(351, 22);
            this.tInFilePath.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB_SHA512);
            this.groupBox1.Controls.Add(this.rB_SHA384);
            this.groupBox1.Controls.Add(this.rB_SHA256);
            this.groupBox1.Controls.Add(this.rB_SHA1);
            this.groupBox1.Controls.Add(this.rB_MD5);
            this.groupBox1.Controls.Add(this.rB_RIPEMD160);
            this.groupBox1.Controls.Add(this.rB_HAVAL);
            this.groupBox1.Controls.Add(this.rB_CRC32);
            this.groupBox1.Location = new System.Drawing.Point(197, 215);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(301, 189);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Режим роботи : ";
            // 
            // rB_SHA512
            // 
            this.rB_SHA512.AutoSize = true;
            this.rB_SHA512.ForeColor = System.Drawing.Color.Chocolate;
            this.rB_SHA512.Location = new System.Drawing.Point(171, 141);
            this.rB_SHA512.Margin = new System.Windows.Forms.Padding(2);
            this.rB_SHA512.Name = "rB_SHA512";
            this.rB_SHA512.Size = new System.Drawing.Size(81, 20);
            this.rB_SHA512.TabIndex = 7;
            this.rB_SHA512.TabStop = true;
            this.rB_SHA512.Text = "SHA-512";
            this.rB_SHA512.UseVisualStyleBackColor = true;
            // 
            // rB_SHA384
            // 
            this.rB_SHA384.AutoSize = true;
            this.rB_SHA384.ForeColor = System.Drawing.Color.Chocolate;
            this.rB_SHA384.Location = new System.Drawing.Point(171, 106);
            this.rB_SHA384.Margin = new System.Windows.Forms.Padding(2);
            this.rB_SHA384.Name = "rB_SHA384";
            this.rB_SHA384.Size = new System.Drawing.Size(81, 20);
            this.rB_SHA384.TabIndex = 6;
            this.rB_SHA384.TabStop = true;
            this.rB_SHA384.Text = "SHA-384";
            this.rB_SHA384.UseVisualStyleBackColor = true;
            // 
            // rB_SHA256
            // 
            this.rB_SHA256.AutoSize = true;
            this.rB_SHA256.ForeColor = System.Drawing.Color.Chocolate;
            this.rB_SHA256.Location = new System.Drawing.Point(171, 70);
            this.rB_SHA256.Margin = new System.Windows.Forms.Padding(2);
            this.rB_SHA256.Name = "rB_SHA256";
            this.rB_SHA256.Size = new System.Drawing.Size(81, 20);
            this.rB_SHA256.TabIndex = 5;
            this.rB_SHA256.TabStop = true;
            this.rB_SHA256.Text = "SHA-256";
            this.rB_SHA256.UseVisualStyleBackColor = true;
            // 
            // rB_SHA1
            // 
            this.rB_SHA1.AutoSize = true;
            this.rB_SHA1.ForeColor = System.Drawing.Color.Chocolate;
            this.rB_SHA1.Location = new System.Drawing.Point(171, 38);
            this.rB_SHA1.Margin = new System.Windows.Forms.Padding(2);
            this.rB_SHA1.Name = "rB_SHA1";
            this.rB_SHA1.Size = new System.Drawing.Size(67, 20);
            this.rB_SHA1.TabIndex = 4;
            this.rB_SHA1.TabStop = true;
            this.rB_SHA1.Text = "SHA-1";
            this.rB_SHA1.UseVisualStyleBackColor = true;
            // 
            // rB_MD5
            // 
            this.rB_MD5.AutoSize = true;
            this.rB_MD5.ForeColor = System.Drawing.Color.Chocolate;
            this.rB_MD5.Location = new System.Drawing.Point(19, 141);
            this.rB_MD5.Margin = new System.Windows.Forms.Padding(2);
            this.rB_MD5.Name = "rB_MD5";
            this.rB_MD5.Size = new System.Drawing.Size(56, 20);
            this.rB_MD5.TabIndex = 3;
            this.rB_MD5.TabStop = true;
            this.rB_MD5.Text = "MD5";
            this.rB_MD5.UseVisualStyleBackColor = true;
            // 
            // rB_RIPEMD160
            // 
            this.rB_RIPEMD160.AutoSize = true;
            this.rB_RIPEMD160.ForeColor = System.Drawing.Color.Chocolate;
            this.rB_RIPEMD160.Location = new System.Drawing.Point(19, 106);
            this.rB_RIPEMD160.Margin = new System.Windows.Forms.Padding(2);
            this.rB_RIPEMD160.Name = "rB_RIPEMD160";
            this.rB_RIPEMD160.Size = new System.Drawing.Size(101, 20);
            this.rB_RIPEMD160.TabIndex = 2;
            this.rB_RIPEMD160.TabStop = true;
            this.rB_RIPEMD160.Text = "RIPEMD160";
            this.rB_RIPEMD160.UseVisualStyleBackColor = true;
            // 
            // rB_HAVAL
            // 
            this.rB_HAVAL.AutoSize = true;
            this.rB_HAVAL.ForeColor = System.Drawing.Color.DarkOrange;
            this.rB_HAVAL.Location = new System.Drawing.Point(19, 70);
            this.rB_HAVAL.Margin = new System.Windows.Forms.Padding(2);
            this.rB_HAVAL.Name = "rB_HAVAL";
            this.rB_HAVAL.Size = new System.Drawing.Size(116, 20);
            this.rB_HAVAL.TabIndex = 1;
            this.rB_HAVAL.TabStop = true;
            this.rB_HAVAL.Text = "HashAlgorithm";
            this.rB_HAVAL.UseVisualStyleBackColor = true;
            // 
            // rB_CRC32
            // 
            this.rB_CRC32.AutoSize = true;
            this.rB_CRC32.ForeColor = System.Drawing.Color.Chocolate;
            this.rB_CRC32.Location = new System.Drawing.Point(19, 38);
            this.rB_CRC32.Margin = new System.Windows.Forms.Padding(2);
            this.rB_CRC32.Name = "rB_CRC32";
            this.rB_CRC32.Size = new System.Drawing.Size(70, 20);
            this.rB_CRC32.TabIndex = 0;
            this.rB_CRC32.TabStop = true;
            this.rB_CRC32.Text = "CRC32";
            this.rB_CRC32.UseVisualStyleBackColor = true;
            // 
            // bOutFile
            // 
            this.bOutFile.Location = new System.Drawing.Point(705, 167);
            this.bOutFile.Margin = new System.Windows.Forms.Padding(2);
            this.bOutFile.Name = "bOutFile";
            this.bOutFile.Size = new System.Drawing.Size(62, 26);
            this.bOutFile.TabIndex = 32;
            this.bOutFile.Text = "...";
            this.bOutFile.UseVisualStyleBackColor = true;
            this.bOutFile.Click += new System.EventHandler(this.bOutFile_Click);
            // 
            // bInFile
            // 
            this.bInFile.Location = new System.Drawing.Point(705, 132);
            this.bInFile.Margin = new System.Windows.Forms.Padding(2);
            this.bInFile.Name = "bInFile";
            this.bInFile.Size = new System.Drawing.Size(62, 26);
            this.bInFile.TabIndex = 31;
            this.bInFile.Text = "...";
            this.bInFile.UseVisualStyleBackColor = true;
            this.bInFile.Click += new System.EventHandler(this.bInFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Вихідний файл : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Вхідний файл : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 586);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.bClean);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tOutFilePath);
            this.Controls.Add(this.tInFilePath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bOutFile);
            this.Controls.Add(this.bInFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Button bClean;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelOutLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelInLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tOutFilePath;
        private System.Windows.Forms.TextBox tInFilePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rB_SHA512;
        private System.Windows.Forms.RadioButton rB_SHA384;
        private System.Windows.Forms.RadioButton rB_SHA256;
        private System.Windows.Forms.RadioButton rB_SHA1;
        private System.Windows.Forms.RadioButton rB_MD5;
        private System.Windows.Forms.RadioButton rB_RIPEMD160;
        private System.Windows.Forms.RadioButton rB_HAVAL;
        private System.Windows.Forms.RadioButton rB_CRC32;
        private System.Windows.Forms.Button bOutFile;
        private System.Windows.Forms.Button bInFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


namespace numarator.FirstFunctionality
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.txt_s1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_s2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_s3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_s1
            // 
            this.txt_s1.Location = new System.Drawing.Point(93, 23);
            this.txt_s1.Multiline = true;
            this.txt_s1.Name = "txt_s1";
            this.txt_s1.Size = new System.Drawing.Size(217, 47);
            this.txt_s1.TabIndex = 0;
            this.txt_s1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayı 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sayı 2 :";
            // 
            // txt_s2
            // 
            this.txt_s2.Location = new System.Drawing.Point(93, 76);
            this.txt_s2.Multiline = true;
            this.txt_s2.Name = "txt_s2";
            this.txt_s2.Size = new System.Drawing.Size(217, 47);
            this.txt_s2.TabIndex = 2;
            this.txt_s2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sayı 3 :";
            // 
            // txt_s3
            // 
            this.txt_s3.Location = new System.Drawing.Point(93, 129);
            this.txt_s3.Multiline = true;
            this.txt_s3.Name = "txt_s3";
            this.txt_s3.Size = new System.Drawing.Size(217, 47);
            this.txt_s3.TabIndex = 4;
            this.txt_s3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(564, 54);
            this.label4.TabIndex = 6;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 206);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sonucu Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.validate_number);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sonuç :";
            // 
            // txt_sonuc
            // 
            this.txt_sonuc.Location = new System.Drawing.Point(93, 182);
            this.txt_sonuc.Multiline = true;
            this.txt_sonuc.Name = "txt_sonuc";
            this.txt_sonuc.Size = new System.Drawing.Size(217, 47);
            this.txt_sonuc.TabIndex = 8;
            this.txt_sonuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(620, 359);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_sonuc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_s3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_s2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_s1);
            this.Name = "main";
            this.Text = "Birinci İşlevsellik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_s1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_s2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_s3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sonuc;
    }
}
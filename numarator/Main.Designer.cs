namespace numarator
{
    partial class frm_main
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
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_third = new System.Windows.Forms.Button();
            this.btn_fifth = new System.Windows.Forms.Button();
            this.btn_fourth = new System.Windows.Forms.Button();
            this.btn_second = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(12, 25);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(299, 61);
            this.btn_first.TabIndex = 0;
            this.btn_first.Text = "1. İşlevsellik";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_third
            // 
            this.btn_third.Location = new System.Drawing.Point(12, 159);
            this.btn_third.Name = "btn_third";
            this.btn_third.Size = new System.Drawing.Size(299, 61);
            this.btn_third.TabIndex = 1;
            this.btn_third.Text = "3. işlevsellik";
            this.btn_third.UseVisualStyleBackColor = true;
            this.btn_third.Click += new System.EventHandler(this.btn_third_Click);
            // 
            // btn_fifth
            // 
            this.btn_fifth.Location = new System.Drawing.Point(12, 293);
            this.btn_fifth.Name = "btn_fifth";
            this.btn_fifth.Size = new System.Drawing.Size(299, 61);
            this.btn_fifth.TabIndex = 2;
            this.btn_fifth.Text = "5. İşlevsellik";
            this.btn_fifth.UseVisualStyleBackColor = true;
            this.btn_fifth.Click += new System.EventHandler(this.btn_fifth_Click);
            // 
            // btn_fourth
            // 
            this.btn_fourth.Location = new System.Drawing.Point(12, 226);
            this.btn_fourth.Name = "btn_fourth";
            this.btn_fourth.Size = new System.Drawing.Size(299, 61);
            this.btn_fourth.TabIndex = 3;
            this.btn_fourth.Text = "4. İşlevsellik";
            this.btn_fourth.UseVisualStyleBackColor = true;
            this.btn_fourth.Click += new System.EventHandler(this.btn_fourth_Click);
            // 
            // btn_second
            // 
            this.btn_second.Location = new System.Drawing.Point(12, 92);
            this.btn_second.Name = "btn_second";
            this.btn_second.Size = new System.Drawing.Size(299, 61);
            this.btn_second.TabIndex = 4;
            this.btn_second.Text = "2. İşlevsellik";
            this.btn_second.UseVisualStyleBackColor = true;
            this.btn_second.Click += new System.EventHandler(this.btn_second_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(330, 375);
            this.Controls.Add(this.btn_second);
            this.Controls.Add(this.btn_fourth);
            this.Controls.Add(this.btn_fifth);
            this.Controls.Add(this.btn_third);
            this.Controls.Add(this.btn_first);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Ekran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_third;
        private System.Windows.Forms.Button btn_fifth;
        private System.Windows.Forms.Button btn_fourth;
        private System.Windows.Forms.Button btn_second;
    }
}


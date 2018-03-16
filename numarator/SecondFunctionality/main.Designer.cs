namespace numarator.SecondFunctionality
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
            this.btn_start = new System.Windows.Forms.Button();
            this.lst_items = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(254, 71);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Başla";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lst_items
            // 
            this.lst_items.FormattingEnabled = true;
            this.lst_items.ItemHeight = 16;
            this.lst_items.Location = new System.Drawing.Point(12, 108);
            this.lst_items.Name = "lst_items";
            this.lst_items.Size = new System.Drawing.Size(254, 548);
            this.lst_items.TabIndex = 1;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 677);
            this.Controls.Add(this.lst_items);
            this.Controls.Add(this.btn_start);
            this.Name = "main";
            this.Text = "İkinci İşlevsellik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ListBox lst_items;
    }
}
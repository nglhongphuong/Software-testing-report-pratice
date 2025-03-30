namespace _11_Phuong_Webdriver
{
    partial class phuong_11_webdriver
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
            this.browser_11_phuong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browser_11_phuong
            // 
            this.browser_11_phuong.Location = new System.Drawing.Point(312, 148);
            this.browser_11_phuong.Name = "browser_11_phuong";
            this.browser_11_phuong.Size = new System.Drawing.Size(147, 65);
            this.browser_11_phuong.TabIndex = 0;
            this.browser_11_phuong.Text = "Browser";
            this.browser_11_phuong.UseVisualStyleBackColor = true;
            this.browser_11_phuong.Click += new System.EventHandler(this.browser_11_phuong_Click);
            // 
            // phuong_11_webdriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.browser_11_phuong);
            this.Name = "phuong_11_webdriver";
            this.Text = "phuong_11_webdriver";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button browser_11_phuong;
    }
}


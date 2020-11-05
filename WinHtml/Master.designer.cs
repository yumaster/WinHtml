namespace WinHtml
{
    partial class Master
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
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_urlpath = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_checkAndPara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(485, 39);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(44, 23);
            this.btn_refresh.TabIndex = 0;
            this.btn_refresh.Text = "→";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_urlpath
            // 
            this.txt_urlpath.Location = new System.Drawing.Point(12, 41);
            this.txt_urlpath.Name = "txt_urlpath";
            this.txt_urlpath.Size = new System.Drawing.Size(467, 21);
            this.txt_urlpath.TabIndex = 1;
            this.txt_urlpath.Text = "192.168.0.206/master.html";
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(99, 12);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 23);
            this.btn_check.TabIndex = 2;
            this.btn_check.Text = "JS交互";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_checkAndPara
            // 
            this.btn_checkAndPara.Location = new System.Drawing.Point(12, 12);
            this.btn_checkAndPara.Name = "btn_checkAndPara";
            this.btn_checkAndPara.Size = new System.Drawing.Size(75, 23);
            this.btn_checkAndPara.TabIndex = 3;
            this.btn_checkAndPara.Text = "JS交互带参数";
            this.btn_checkAndPara.UseVisualStyleBackColor = true;
            this.btn_checkAndPara.Click += new System.EventHandler(this.btn_checkAndPara_Click);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 367);
            this.Controls.Add(this.btn_checkAndPara);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.txt_urlpath);
            this.Controls.Add(this.btn_refresh);
            this.Name = "Master";
            this.Text = "Master";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txt_urlpath;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_checkAndPara;
    }
}
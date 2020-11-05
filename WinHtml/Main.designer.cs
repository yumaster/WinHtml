namespace WinHtml
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.wbMain = new System.Windows.Forms.WebBrowser();
            this.btn_look = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wbMain
            // 
            this.wbMain.Location = new System.Drawing.Point(13, 13);
            this.wbMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMain.Name = "wbMain";
            this.wbMain.Size = new System.Drawing.Size(660, 412);
            this.wbMain.TabIndex = 0;
            // 
            // btn_look
            // 
            this.btn_look.Location = new System.Drawing.Point(703, 37);
            this.btn_look.Name = "btn_look";
            this.btn_look.Size = new System.Drawing.Size(75, 23);
            this.btn_look.TabIndex = 1;
            this.btn_look.Text = "执行";
            this.btn_look.UseVisualStyleBackColor = true;
            this.btn_look.Click += new System.EventHandler(this.btn_look_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_look);
            this.Controls.Add(this.wbMain);
            this.Name = "Main";
            this.Text = "浏览器";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbMain;
        private System.Windows.Forms.Button btn_look;
    }
}


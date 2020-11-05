namespace MiniBlinkDemo
{
    partial class Main
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
            this.btn_InvokeJsWithRet = new System.Windows.Forms.Button();
            this.btn_InvokeJsNoRet = new System.Windows.Forms.Button();
            this.btn_runJsWithRet = new System.Windows.Forms.Button();
            this.panel_bs = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_InvokeJsWithRet
            // 
            this.btn_InvokeJsWithRet.Location = new System.Drawing.Point(535, 12);
            this.btn_InvokeJsWithRet.Name = "btn_InvokeJsWithRet";
            this.btn_InvokeJsWithRet.Size = new System.Drawing.Size(241, 44);
            this.btn_InvokeJsWithRet.TabIndex = 6;
            this.btn_InvokeJsWithRet.Text = "c#调用页面中的js函数，有参数有返回值";
            this.btn_InvokeJsWithRet.UseVisualStyleBackColor = true;
            this.btn_InvokeJsWithRet.Click += new System.EventHandler(this.btn_InvokeJsWithRet_Click);
            // 
            // btn_InvokeJsNoRet
            // 
            this.btn_InvokeJsNoRet.Location = new System.Drawing.Point(247, 12);
            this.btn_InvokeJsNoRet.Name = "btn_InvokeJsNoRet";
            this.btn_InvokeJsNoRet.Size = new System.Drawing.Size(242, 44);
            this.btn_InvokeJsNoRet.TabIndex = 5;
            this.btn_InvokeJsNoRet.Text = "c#调用页面中的js函数，无参数无返回值";
            this.btn_InvokeJsNoRet.UseVisualStyleBackColor = true;
            this.btn_InvokeJsNoRet.Click += new System.EventHandler(this.btn_InvokeJsNoRet_Click);
            // 
            // btn_runJsWithRet
            // 
            this.btn_runJsWithRet.Location = new System.Drawing.Point(12, 12);
            this.btn_runJsWithRet.Name = "btn_runJsWithRet";
            this.btn_runJsWithRet.Size = new System.Drawing.Size(184, 44);
            this.btn_runJsWithRet.TabIndex = 4;
            this.btn_runJsWithRet.Text = "c#直接运行js代码，有返回值";
            this.btn_runJsWithRet.UseVisualStyleBackColor = true;
            this.btn_runJsWithRet.Click += new System.EventHandler(this.btn_runJsWithRet_Click);
            // 
            // panel_bs
            // 
            this.panel_bs.Location = new System.Drawing.Point(12, 73);
            this.panel_bs.Name = "panel_bs";
            this.panel_bs.Size = new System.Drawing.Size(764, 365);
            this.panel_bs.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 446);
            this.Controls.Add(this.panel_bs);
            this.Controls.Add(this.btn_InvokeJsWithRet);
            this.Controls.Add(this.btn_InvokeJsNoRet);
            this.Controls.Add(this.btn_runJsWithRet);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_InvokeJsWithRet;
        private System.Windows.Forms.Button btn_InvokeJsNoRet;
        private System.Windows.Forms.Button btn_runJsWithRet;
        private System.Windows.Forms.Panel panel_bs;
    }
}
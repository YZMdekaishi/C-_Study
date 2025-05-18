namespace WinFormHelloWorld
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxShowHello = new System.Windows.Forms.TextBox();
            this.buttonsayHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxShowHello
            // 
            this.textBoxShowHello.Location = new System.Drawing.Point(0, 0);
            this.textBoxShowHello.Name = "textBoxShowHello";
            this.textBoxShowHello.Size = new System.Drawing.Size(532, 28);
            this.textBoxShowHello.TabIndex = 0;
            // 
            // buttonsayHello
            // 
            this.buttonsayHello.Location = new System.Drawing.Point(0, 34);
            this.buttonsayHello.Name = "buttonsayHello";
            this.buttonsayHello.Size = new System.Drawing.Size(532, 32);
            this.buttonsayHello.TabIndex = 1;
            this.buttonsayHello.Text = "Click Me";
            this.buttonsayHello.UseVisualStyleBackColor = true;
            this.buttonsayHello.Click += new System.EventHandler(this.buttonsayHello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 280);
            this.Controls.Add(this.buttonsayHello);
            this.Controls.Add(this.textBoxShowHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxShowHello;
        private System.Windows.Forms.Button buttonsayHello;
    }
}


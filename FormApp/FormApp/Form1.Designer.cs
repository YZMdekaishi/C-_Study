namespace FormApp
{
    partial class MyForm
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
            this.myTextBox = new System.Windows.Forms.TextBox();
            this.myButoon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myTextBox
            // 
            this.myTextBox.Location = new System.Drawing.Point(12, 3);
            this.myTextBox.Name = "myTextBox";
            this.myTextBox.Size = new System.Drawing.Size(254, 28);
            this.myTextBox.TabIndex = 0;
            // 
            // myButoon
            // 
            this.myButoon.Location = new System.Drawing.Point(12, 37);
            this.myButoon.Name = "myButoon";
            this.myButoon.Size = new System.Drawing.Size(254, 30);
            this.myButoon.TabIndex = 1;
            this.myButoon.Text = "Say Hello";
            this.myButoon.UseVisualStyleBackColor = true;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.myButoon);
            this.Controls.Add(this.myTextBox);
            this.Name = "MyForm";
            this.RightToLeftLayout = true;
            this.Text = "Hello Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox myTextBox;
        private System.Windows.Forms.Button myButoon;
    }
}


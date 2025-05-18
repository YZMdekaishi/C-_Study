namespace ModbusDemo
{
    partial class FormModbus
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
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_ReadReg = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(133, 93);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(185, 76);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "连接串口";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_ReadReg
            // 
            this.btn_ReadReg.Location = new System.Drawing.Point(650, 93);
            this.btn_ReadReg.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ReadReg.Name = "btn_ReadReg";
            this.btn_ReadReg.Size = new System.Drawing.Size(185, 76);
            this.btn_ReadReg.TabIndex = 1;
            this.btn_ReadReg.Text = "读取寄存器";
            this.btn_ReadReg.UseVisualStyleBackColor = true;
            this.btn_ReadReg.Click += new System.EventHandler(this.btn_ReadReg_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(133, 285);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(702, 268);
            this.listBox1.TabIndex = 2;
            // 
            // FormModbus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 600);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_ReadReg);
            this.Controls.Add(this.btn_Connect);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormModbus";
            this.Text = "Modbus仿真";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_ReadReg;
        private System.Windows.Forms.ListBox listBox1;
    }
}
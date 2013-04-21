namespace RFIDReaderControler
{
    partial class frmStartReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartReader));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbZigbees = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbSendType = new System.Windows.Forms.ComboBox();
            this.txtTargetIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择节点：";
            // 
            // cmbZigbees
            // 
            this.cmbZigbees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZigbees.FormattingEnabled = true;
            this.cmbZigbees.Location = new System.Drawing.Point(82, 23);
            this.cmbZigbees.Name = "cmbZigbees";
            this.cmbZigbees.Size = new System.Drawing.Size(233, 20);
            this.cmbZigbees.TabIndex = 1;
            this.cmbZigbees.SelectedIndexChanged += new System.EventHandler(this.cmbReaders_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(639, 38);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 27);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "启动(&S)";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cmbSendType
            // 
            this.cmbSendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSendType.Enabled = false;
            this.cmbSendType.FormattingEnabled = true;
            this.cmbSendType.Location = new System.Drawing.Point(82, 103);
            this.cmbSendType.Name = "cmbSendType";
            this.cmbSendType.Size = new System.Drawing.Size(234, 20);
            this.cmbSendType.TabIndex = 12;
            // 
            // txtTargetIP
            // 
            this.txtTargetIP.Enabled = false;
            this.txtTargetIP.Location = new System.Drawing.Point(82, 148);
            this.txtTargetIP.Multiline = true;
            this.txtTargetIP.Name = "txtTargetIP";
            this.txtTargetIP.ReadOnly = true;
            this.txtTargetIP.Size = new System.Drawing.Size(509, 124);
            this.txtTargetIP.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "目标IP：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "发送方式：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPortName);
            this.groupBox1.Controls.Add(this.txtTargetIP);
            this.groupBox1.Controls.Add(this.cmbSendType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbZigbees);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 309);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "节点信息";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(695, 94);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 27);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "停止(&E)";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(639, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 10);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(639, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 27);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "退出(&X)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "串口名称：";
            // 
            // cmbPortName
            // 
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.Enabled = false;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(83, 65);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(232, 20);
            this.cmbPortName.TabIndex = 13;
            // 
            // frmStartReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStartReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "启动节点";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbZigbees;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cmbSendType;
        private System.Windows.Forms.TextBox txtTargetIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.Label label2;
    }
}
namespace RFIDReaderControler
{
    partial class frmReaderMngment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReaderMngment));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSendType = new System.Windows.Forms.ComboBox();
            this.txtTargetIP = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(12, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 410);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPortName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbSendType);
            this.groupBox1.Controls.Add(this.txtTargetIP);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(173, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 367);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "主节点属性";
            // 
            // cmbPortName
            // 
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(97, 61);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(233, 20);
            this.cmbPortName.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "例如 127.0.0.1:5000;";
            // 
            // cmbSendType
            // 
            this.cmbSendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSendType.FormattingEnabled = true;
            this.cmbSendType.Location = new System.Drawing.Point(97, 102);
            this.cmbSendType.Name = "cmbSendType";
            this.cmbSendType.Size = new System.Drawing.Size(234, 20);
            this.cmbSendType.TabIndex = 2;
            this.cmbSendType.SelectedIndexChanged += new System.EventHandler(this.cmbSendType_SelectedIndexChanged);
            // 
            // txtTargetIP
            // 
            this.txtTargetIP.Location = new System.Drawing.Point(98, 140);
            this.txtTargetIP.Multiline = true;
            this.txtTargetIP.Name = "txtTargetIP";
            this.txtTargetIP.Size = new System.Drawing.Size(509, 176);
            this.txtTargetIP.TabIndex = 1;
            this.txtTargetIP.Text = "127.0.0.1:5000";
            this.txtTargetIP.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 21);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "目标IP：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "发送方式：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口名称：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "退出(&X)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(204, 406);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加节点(&A)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(173, 448);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 10);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(366, 406);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除节点(&D)";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(528, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存更改(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "主节点列表：";
            // 
            // frmReaderMngment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 518);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReaderMngment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zigbee管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTargetIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSendType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbPortName;
    }
}
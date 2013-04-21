using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace RFIDReaderControler
{
    public partial class frmStartReader : Form
    {
        public frmStartReader()
        {
            InitializeComponent();
            this.cmbSendType.Items.Clear();
            this.cmbSendType.Items.Add(ZigbeeInfo.sendTypeUDP);
            this.cmbSendType.Items.Add(ZigbeeInfo.sendTypeREST);

            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            cmbPortName.Items.AddRange(ports);

            this.Shown += new EventHandler(frmStartReader_Shown);
        }

        void frmStartReader_Shown(object sender, EventArgs e)
        {
            this.cmbZigbees.Items.Clear();
            Dictionary<string, ZigbeeInfo>.KeyCollection keys = staticClass.readerDic.Keys;
            foreach (string s in keys)
            {
                this.cmbZigbees.Items.Add(s);
            }
            if (this.cmbZigbees.Items.Count > 0)
            {
                this.cmbZigbees.SelectedIndex = 0;
            }
        }
        public void refreshButtonStart(string _reader_name)
        {
            if (this.cmbZigbees.Text == _reader_name)
            {
                ZigbeeInfo ri = staticClass.readerDic[_reader_name];
                if (ri.bRunning == true)
                {
                    this.btnStart.Enabled = false;
                }
                else
                {
                    this.btnStart.Enabled = true;
                }
            }
        }
        private void cmbReaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZigbeeInfo ri = staticClass.readerDic[this.cmbZigbees.Text];
            if (ri != null)
            {
                this.cmbPortName.Text = ri.comport;
                this.cmbSendType.Text = ri.sendType;
                this.txtTargetIP.Text = ri.ips;

                if (ri.bRunning == true)
                {
                    this.btnStart.Enabled = false;
                    //this.btnStop.Enabled = true;
                }
                else
                {
                    this.btnStart.Enabled = true;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this.cmbPortName.Text != string.Empty)
            {
                frmReaderRunning frm = new frmReaderRunning(this.cmbZigbees.Text, this);

                this.btnStart.Enabled = false;

                frm.Show();
            }
            else
            {
                MessageBox.Show("串口已经不存在！", "信息提示");
            }
        }
    }
}

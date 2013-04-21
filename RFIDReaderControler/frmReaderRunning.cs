using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using httpHelper;
using Server;
using invokePhpRestDemo;
using RestAPI;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using System.IO.Ports;

namespace RFIDReaderControler
{
    public partial class frmReaderRunning : Form
    {
        #region 成员
        string __zigbee_name;
        //存储接收到命令信息
        List<string> flagList = new List<string>();
        //HttpWebConnect __httpHelperAddTags = new HttpWebConnect();
        //要上传的标签的缓存池
        //DataTable __dtTagTemp = new DataTable();
        bool bStopListening = false;

        ZigbeeInfo __zigbee_info = null;
        frmStartReader __frmReader = null;
        public Socket clientSocket = null; //The main client socket
        //public EndPoint epServer;   //The EndPoint of the server
        List<EndPoint> endpoint_list = new List<EndPoint>();
        #endregion
        public frmReaderRunning(string _reader_name, frmStartReader frmReader)
        {
            InitializeComponent();
            this.__zigbee_name = _reader_name;
            this.__frmReader = frmReader;
            this.Text = "节点" + this.__zigbee_name;
            this.Shown += new EventHandler(frmReaderRunning_Shown);
            this.FormClosing += new FormClosingEventHandler(frmReaderRunning_FormClosing);

            comport.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

        }
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (bStopListening == true)
            {
                return;
            }
            try
            {
                int n = comport.BytesToRead;//n为返回的字节数
                byte[] buf = new byte[n];//初始化buf 长度为n
                comport.Read(buf, 0, n);//读取返回数据并赋值到数组
                //_RFIDHelper.Parse(buf,true);
                //helper.Parse(buf);
                foreach (EndPoint ep in this.endpoint_list)
                {
                    clientSocket.BeginSendTo(buf, 0,
                                                buf.Length, SocketFlags.None,
                                                ep, new AsyncCallback(OnSend), null);
                }
                string str = Encoding.UTF8.GetString(buf);
                string log = "接收到数据: " + str;
                this.appendLog(log);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OnSend(IAsyncResult ar)
        {
            try
            {
                clientSocket.EndSend(ar);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(
                    string.Format("frmReaderRunning.OnSend  ->  = {0}"
                    , ex.Message));
            }
        }

        void helper_RequestCompleted(object o)
        {
            deleControlInvoke dele = delegate(object otag)
            {
                try
                {
                    tagID tag = (tagID)fastJSON.JSON.Instance.ToObject((string)otag, typeof(tagID));
                    string log = "发送标签 " + tag.tag + " 成功" + "  " + tag.startTime;

                    this.appendLog(log);

                }
                catch (System.Exception ex)
                {
                }
            };
            this.Invoke(dele, o);
        }
        void appendLog(string oLog)
        {
            deleControlInvoke dele = delegate(object o)
            {
                string log = (string)oLog;
                if (this.txtLog.Text != null && this.txtLog.Text.Length > 4096)
                {
                    this.txtLog.Text = string.Empty;
                }
                this.txtLog.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "  " + log + "\r\n" + this.txtLog.Text;
            };
            this.Invoke(dele, oLog);
        }
        void frmReaderRunning_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.bStopListening = true;
            this.comport.Close();

            ZigbeeInfo ri = staticClass.readerDic[this.__zigbee_name];
            if (ri != null)
            {
                ri.bRunning = false;
            }
            if (this.__frmReader != null)
            {
                this.__frmReader.refreshButtonStart(this.__zigbee_name);
            }

        }

        SerialPort comport = new SerialPort();
        void frmReaderRunning_Shown(object sender, EventArgs e)
        {
            this.matrixCircularProgressControl1.Start();
            ZigbeeInfo ri = staticClass.readerDic[this.__zigbee_name];


            if (ri != null)
            {
                try
                {
                    this.comport.PortName = ri.comport;
                    this.comport.StopBits = StopBits.One;
                    this.comport.Parity = Parity.None;
                    this.comport.DataBits = 8;
                    //this.comport.BaudRate = 9600;
                    this.comport.BaudRate = 19200;

                    this.comport.Open();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "异常提示");
                    return;
                }

                if (ri.sendType == ZigbeeInfo.sendTypeUDP)
                {
                    try
                    {
                        clientSocket = new Socket(AddressFamily.InterNetwork,
                                    SocketType.Dgram, ProtocolType.Udp);
                        List<IP_info> infos = ri.ipList;
                        foreach (IP_info ii in infos)
                        {
                            //IP address of the server machine
                            IPEndPoint ipEndPoint = new IPEndPoint(ii.ipaddress, ii.port);
                            EndPoint epServer = (EndPoint)ipEndPoint;
                            this.endpoint_list.Add(epServer);
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "信息提示", MessageBoxButtons.OK);
                        return;
                    }
                }
                ri.bRunning = true;
                this.__zigbee_info = ri;
                this.bStopListening = false;
            }
        }
    }
}

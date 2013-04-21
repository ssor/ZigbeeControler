using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Diagnostics;
using System.Net.Sockets;

namespace RFIDReaderControler
{
    public class IP_info
    {
        public IPAddress ipaddress;
        public int port;
        public IP_info(IPAddress _ip, int _port)
        {
            this.ipaddress = _ip;
            this.port = _port;
        }
    }
    public class ZigbeeInfo
    {
        public static string sendTypeUDP = "UDP";
        public static string sendTypeREST = "REST服务";
        public string name;
        public bool bRunning = false;
        public string comport;
        public string sendType;
        public string ips;
        public List<IP_info> ipList = new List<IP_info>();
        public Socket socket_server;//接收指定读写器信息的udp服务端，不用的时候要关闭

        public ZigbeeInfo(string _name, string _comport, string _sendtype, string _ips)
        {
            this.name = _name;
            try
            {
                this.name = _name;
                this.comport = _comport;
                this.sendType = _sendtype;

                this.ips = _ips;
                string[] ips = _ips.Split(';');
                for (int i = 0; i < ips.Length; i++)
                {
                    if (ips[i].Length > 0)
                    {
                        string[] ip_and_port_s = ips[i].Split(':');
                        if (ip_and_port_s.Length < 2)
                        {
                            continue;
                        }
                        IPAddress ip = IPAddress.Parse(ip_and_port_s[0]);
                        int port = int.Parse(ip_and_port_s[1]);
                        IP_info ipinfo = new IP_info(ip, port);
                        //IPAddress ip = IPAddress.Parse(ips[i]);
                        this.ipList.Add(ipinfo);
                    }
                }
            }
            catch (System.Exception ex)
            {
                Debug.WriteLine(
                    string.Format("ReaderInfo.ReaderInfo  ->  = {0}"
                    , ex.Message));
            }
        }
    }
}

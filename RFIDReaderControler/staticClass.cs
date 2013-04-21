using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace RFIDReaderControler
{
    public static class staticClass
    {
        public static DateTime timeBase = DateTime.Now;
        public static string configFilePath = "app.yap";
        public static string PicturePath = @"商品图片\";
        public static string currentDBConnectString = string.Empty;
        //public static IObjectContainer db = Db4oFactory.OpenFile(configFilePath);
        public static string strServerIP = "192.168.1.100";
        public static int iServePort = 5000;

        public static string restServerIP = "192.168.1.100";
        public static string restServerPort = "9002";
        public static int interval = 15000;

        public static string zigbeeTableName = "tbZigbee";

        public static Dictionary<string, ZigbeeInfo> readerDic = new Dictionary<string, ZigbeeInfo>();

        public static void refresh_reader_dic()
        {
            try
            {
                readerDic.Clear();
                DataTable dt = nsConfigDB.ConfigDB.getTable(staticClass.zigbeeTableName);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ZigbeeInfo ri = new ZigbeeInfo(
                                                   dr["key"].ToString(),
                                                   dr["comport"].ToString(),
                                                   dr["sendType"].ToString(),
                                                   dr["targetIP"].ToString()
                                                   );
                    staticClass.readerDic.Add(dr["key"].ToString(), ri);
                }
            }
            catch
            {

            }
        }
    }

}

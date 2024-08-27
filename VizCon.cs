using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ELE_APP_FF_2024
{
    internal class VizCon
    {
        private int byteRead;
        public string getVizdata(string host, string command)
        {
            TcpClient tc = new TcpClient(host, 6100);
            NetworkStream ns = tc.GetStream();
            byte[] byteData = Encoding.UTF8.GetBytes(command + "\0");
            ns.Write(byteData, 0, byteData.Length);
            byte[] rec_buffer = new byte[2048];
            byteRead = ns.Read(rec_buffer, 0, rec_buffer.Length);
            StringBuilder myVizData = new StringBuilder();
            _ = myVizData.AppendFormat("{0}", Encoding.ASCII.GetString(rec_buffer, 0, byteRead));
            ns.Close();
            tc.Close();
            return myVizData.ToString();
        }
    }
}

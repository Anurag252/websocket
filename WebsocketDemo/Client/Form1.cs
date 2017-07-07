using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcpClient sock = new TcpClient("127.0.0.1", 1112);
            
            Stream s = sock.GetStream();
            StreamWriter sw = new StreamWriter(s);

            sw.Write("Hello");
            s.Close();
            sock.Close();

        }
    }
}

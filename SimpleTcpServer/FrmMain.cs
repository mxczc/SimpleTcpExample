using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTcpServer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private SimpleTcp.SimpleTcpServer server;
        private void btn_link_Click(object sender, EventArgs e)
        {
            if (btn_link.Text == "启动")
            {
                server = new SimpleTcp.SimpleTcpServer($"{txt_ip.Text.Replace(" ", "")}", int.Parse(txt_port.Text));
                server.Events.ClientConnected += OnConnected;
                server.Events.DataReceived += OnDataReceived;
                server.Events.ClientDisconnected += OnDisconnected;
                btn_link.Text = "停止";
                server.Start();
            }
            else
            {
                btn_link.Text = "启动";
                server.Stop();
                server.Dispose();
            }
        }
        private void OnConnected(object sender, SimpleTcp.ClientConnectedEventArgs e)
        {
            this.BeginInvoke((Action)delegate
            {
                cbo_client.Items.Add(e.IpPort);
            });
            ShowLog("客户端连接成功");
        }
        private void OnDataReceived(object sender, SimpleTcp.DataReceivedEventArgs e)
        {
            ShowLog(Encoding.UTF8.GetString(e.Data));
        }
        private void OnDisconnected(object sender, SimpleTcp.ClientDisconnectedEventArgs e)
        {
            ShowLog($"断开连接，原因：{e.Reason}");
        }
        private void ShowLog(string msg)
        {
            this.BeginInvoke((Action)delegate
            {
                ri_log.Text = ri_log.Text.Insert(0, $"{DateTime.Now.ToString("yyyyy-MM-dd HH:mm:ss")} {msg}\r\n");
            });
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            if (cbo_client.Text != "")
            {
                server.Send(cbo_client.Text, txt_msg.Text);
                txt_msg.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("请先选中客户端");
            }
        }

    }
}

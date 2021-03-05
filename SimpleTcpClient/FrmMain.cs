using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTcpClient
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private SimpleTcp.SimpleTcpClient client;
        private void btn_link_Click(object sender, EventArgs e)
        {
            if (btn_link.Text == "连接")
            {
                client = new SimpleTcp.SimpleTcpClient($"{txt_ip.Text.Replace(" ", "")}", int.Parse(txt_port.Text));
                client.Events.Connected += OnConnected;
                client.Events.DataReceived += OnDataReceived;
                client.Events.Disconnected += OnDisconnected; ;
                client.Connect();
                //设置断线重连间隔
                client.ConnectWithRetries();
                btn_link.Text = "断开";
            }
            else
            {
                btn_link.Text = "连接";
                client.Disconnect();
            }
        }
        private void OnConnected(object sender, SimpleTcp.ClientConnectedEventArgs e)
        {
            ShowLog("连接成功");
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
            client.Send(txt_msg.Text);
            txt_msg.Text = string.Empty;
        }
    }
}

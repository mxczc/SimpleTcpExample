
namespace SimpleTcpServer
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ri_log = new System.Windows.Forms.RichTextBox();
            this.gp1 = new System.Windows.Forms.GroupBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.btn_link = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gp2 = new System.Windows.Forms.GroupBox();
            this.cbo_client = new System.Windows.Forms.ComboBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gp1.SuspendLayout();
            this.gp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ri_log
            // 
            this.ri_log.Dock = System.Windows.Forms.DockStyle.Top;
            this.ri_log.Location = new System.Drawing.Point(4, 22);
            this.ri_log.Margin = new System.Windows.Forms.Padding(4);
            this.ri_log.Name = "ri_log";
            this.ri_log.Size = new System.Drawing.Size(899, 382);
            this.ri_log.TabIndex = 0;
            this.ri_log.Text = "";
            // 
            // gp1
            // 
            this.gp1.Controls.Add(this.txt_port);
            this.gp1.Controls.Add(this.txt_ip);
            this.gp1.Controls.Add(this.btn_link);
            this.gp1.Controls.Add(this.label2);
            this.gp1.Controls.Add(this.label1);
            this.gp1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gp1.Location = new System.Drawing.Point(0, 0);
            this.gp1.Margin = new System.Windows.Forms.Padding(4);
            this.gp1.Name = "gp1";
            this.gp1.Padding = new System.Windows.Forms.Padding(4);
            this.gp1.Size = new System.Drawing.Size(907, 84);
            this.gp1.TabIndex = 6;
            this.gp1.TabStop = false;
            this.gp1.Text = "参数";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(664, 35);
            this.txt_port.Margin = new System.Windows.Forms.Padding(4);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(85, 25);
            this.txt_port.TabIndex = 4;
            this.txt_port.Text = "7353";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(60, 35);
            this.txt_ip.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(548, 25);
            this.txt_ip.TabIndex = 3;
            this.txt_ip.Text = "0.0.0.0";
            // 
            // btn_link
            // 
            this.btn_link.Location = new System.Drawing.Point(771, 32);
            this.btn_link.Margin = new System.Windows.Forms.Padding(4);
            this.btn_link.Name = "btn_link";
            this.btn_link.Size = new System.Drawing.Size(100, 29);
            this.btn_link.TabIndex = 2;
            this.btn_link.Text = "启动";
            this.btn_link.UseVisualStyleBackColor = true;
            this.btn_link.Click += new System.EventHandler(this.btn_link_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "地址：";
            // 
            // gp2
            // 
            this.gp2.Controls.Add(this.cbo_client);
            this.gp2.Controls.Add(this.ri_log);
            this.gp2.Controls.Add(this.btn_send);
            this.gp2.Controls.Add(this.txt_msg);
            this.gp2.Controls.Add(this.label3);
            this.gp2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gp2.Location = new System.Drawing.Point(0, 86);
            this.gp2.Margin = new System.Windows.Forms.Padding(4);
            this.gp2.Name = "gp2";
            this.gp2.Padding = new System.Windows.Forms.Padding(4);
            this.gp2.Size = new System.Drawing.Size(907, 476);
            this.gp2.TabIndex = 7;
            this.gp2.TabStop = false;
            this.gp2.Text = "交互";
            // 
            // cbo_client
            // 
            this.cbo_client.FormattingEnabled = true;
            this.cbo_client.Location = new System.Drawing.Point(463, 425);
            this.cbo_client.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_client.Name = "cbo_client";
            this.cbo_client.Size = new System.Drawing.Size(300, 23);
            this.cbo_client.TabIndex = 8;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(771, 422);
            this.btn_send.Margin = new System.Windows.Forms.Padding(4);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(100, 29);
            this.btn_send.TabIndex = 6;
            this.btn_send.Text = "发送文本";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(60, 425);
            this.txt_msg.Margin = new System.Windows.Forms.Padding(4);
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(389, 25);
            this.txt_msg.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 430);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "消息：";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 562);
            this.Controls.Add(this.gp1);
            this.Controls.Add(this.gp2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleTcp服务端";
            this.gp1.ResumeLayout(false);
            this.gp1.PerformLayout();
            this.gp2.ResumeLayout(false);
            this.gp2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ri_log;
        private System.Windows.Forms.GroupBox gp1;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Button btn_link;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gp2;
        private System.Windows.Forms.ComboBox cbo_client;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.Label label3;
    }
}


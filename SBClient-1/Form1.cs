using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBClient_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "Endpoint=sb://azure-ipass-solution-servicebus.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=51FKyKqSE5mWH79NcozZHumg5utfHGYR/iG+Ju8UdGU=";
            var queueName = "logicappstestqueue";

            var client = QueueClient.CreateFromConnectionString(connectionString, queueName);
            var message = new BrokeredMessage(this.textBox1.Text);

            client.Send(message);
        }
    }
}

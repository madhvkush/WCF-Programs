using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsClientApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            HelloServiceInWinApp.HelloServiceClient client = new HelloServiceInWinApp.HelloServiceClient("NetTcpBinding_IHelloService");// use TCP binding
            MessageBox.Show(client.GetMessage(textBox1.Text));
        }
    }
}

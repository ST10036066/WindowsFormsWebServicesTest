using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsWebServicesTest.ServiceReferenceWebServiceTest;

namespace WindowsFormsWebServicesTest
{
    public partial class Form1 : Form
    {

        private ServiceReferenceWebServiceTest.WebService1March7SoapClient MyClient = new WebService1March7SoapClient();
        private ServiceReferenceWebServiceTest.WebService1March7SoapClient client = new WebService1March7SoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private string MyConnectionString = WindowsFormsWebServicesTest.Properties.Settings.Default.MyConnectionString;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAction1_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.MyClient.AddTwoInts(7, 8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ActionBtn2.Text = this.client.HelloWorld();
        }
    }
}

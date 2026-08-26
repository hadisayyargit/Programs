using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long[] m = new long[10];
            
           // ServiceReference1.Service1Client Object1 = new ServiceReference1.Service1Client();
            
           //string s = Object1.sendSMS("989122105628", "dsdfsdfsdfsdfsdf");
           //string s1 = Object1.sendSMS("+989122105628", "dsdfsdfsdfsdfsdf");

           //MessageBox.Show(s);
           com.magfa.sms.SoapSmsQueuableImplementationService objMagfa = new com.magfa.sms.SoapSmsQueuableImplementationService();

           objMagfa.Credentials = new System.Net.NetworkCredential("safa_97500054", "1@2345678","magfa");

            
            /*
           WebProxy proxy;
           proxy = new WebProxy(proxyAddress);
           proxy.Credentials = new NetworkCredential(proxyUsername, proxyPassword);
           sq.Proxy = proxy;

             */


           int[] encodings = new int[1];
           string[] UDH = new string[1];
           int[] mclass = new int[1];
           int[] priorities = new int[1];
           long[] checkingIds = new long[1];

           encodings[0] = -1;
           UDH[0] = "";
           mclass[0] = -1;
           priorities[0] = -1;
           checkingIds[0] = 200;

           m = objMagfa.enqueue("magfa", new string[] { "hi" }, new string[] { "989122105628", "09127381532" }, new string[] { "300097500054" }, encodings, UDH, mclass, priorities, checkingIds);
           string s2 = m[0].ToString();

            MessageBox.Show(s2);
        }
    }
}

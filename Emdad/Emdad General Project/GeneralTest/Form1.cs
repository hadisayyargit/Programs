using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using CommonUnits;
using GlobalUnits;
using System.Configuration;
using System.ServiceModel;

namespace GeneralTest
{
    public partial class Form1 : Form
    {
        SqlConnection m_myConnection = new SqlConnection();
        

        public Form1()
        {
            InitializeComponent();
        }        

        private void btnEcommerce_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            txtXmlOutput.Text = "";

            EcommerceService.EcommerceServiceClient objEcmService1 = new EcommerceService.EcommerceServiceClient();


            txtXmlOutput.Text = objEcmService1.SubmitInvoice("", "", txtXmlInput.Text);           




            Cursor = Cursors.Default;
        }

        private void btnGetFinalPrice_Click(object sender, EventArgs e)
        {
            /*
            EcommerceService2.EcommerceService objEcmService1 = new EcommerceService2.EcommerceService();
            DataSet ds = objEcmService1.GetFinalPrice("518000", "518000");

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                txtXmlOutput.Text="FinalPrice: " + ds.Tables[0].Rows[0]["FinalPrice"].ToString();
            }
            else
            {
                txtXmlOutput.Text = "خروجی قیمتها وجود ندارد";
            }

            */
        }

        private void btnGetServices_Click(object sender, EventArgs e)
        {              
            //http://46.32.24.36:7003/EmdadMainServices.BankPasargadService.svc
            //http://46.32.24.36:7003/EmdadMainServices.GuaranteeService.svc
            //http://46.32.24.36:7003/EmdadMainServices.EcommerceService.svc
   

            /*
            EcommerceService2.EcommerceService objEcmService1 = new EmdadEcommerceServices_EcmService.EcommerceService();
            DataSet ds = objEcmService1.GetServices("518000", "518000");


            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)            
                txtXmlOutput.Text = "ServiceDesc: " + ds.Tables[0].Rows[0]["ServiceDesc"].ToString() + ds.Tables[0].Rows[0]["FinalPrice"].ToString();            
            else            
                txtXmlOutput.Text = "خروجی سرویس وجود ندارد";

            MessageBox.Show(objEcmService1.GetHint("518000", "518000"));
             */


            //LookupExample();

            //content=9655|mobileNumber=989122105628|lang=1|traceCode=|state=1|timestamp=20140224061249

            string strInput = "";

            //http://localhost:15201/EmdadMainServices.BankPasargadService.svc
            
            
            bankpasargad2.BankPasargadService objPasargad = new bankpasargad2.BankPasargadService();
            strInput = "content=" + txtUserInput.Text + "|mobilenumber=" + txtMobileno.Text + "|lang=1|traceCode=|state=1|timestamp=20140224061249";

            txtXmlOutput.Text = objPasargad.progressSession(strInput);

        }

        private void btnSelectXml_Click(object sender, EventArgs e)
        {
            Stream myStream = null;

            openFileDialog1.Filter = "xml files (*.xml)|*.xml";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            XmlDocument myxml = new XmlDocument();
                            myxml.Load(myStream);
                            txtXmlInput.Text = myxml.InnerXml;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnGurantee_Click(object sender, EventArgs e)
        {
            GuaranteeService.GuaranteeService objGuaranteeWebService = new GuaranteeService.GuaranteeService();

            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = ConfigurationManager.ConnectionStrings["EmdadSaipa3_Report"].ConnectionString;

            string strRes = objGuaranteeWebService.PostGuaranteeBadaneh("h_sayyar", "91457", txtRequisition_Activity.Text, txtRequisition_SparePart.Text,txtDamageFinalRep.Text);
            
          
            textBox4.Text = strRes;


        }

        private void btnPublicTest_Click(object sender, EventArgs e)
        {
            polygon myshape1 = new polygon();
            circle myCircle = new circle();
            triangle myTriangle = new triangle();
            

            myshape1.draw();
            myCircle.draw();
            myTriangle.draw();

            myTriangle.firstangle = 90;

            //txtTest.Text = myCircle.getshapename();
            txtTest.Text = "myshape is " + myshape1.GetShape() + "\r\n" + "triangle is:" + myTriangle.GetShape() + "\r\n" + "circle is:" + myCircle.GetShape()
                + "\r\n" + myshape1.vertex.ToString() + myTriangle.vertex.ToString() + myCircle.vertex.ToString()
                + "\r\n" + myTriangle.firstangle.ToString();


        }

        public static void LookupExample()
        {
            // Create a list of Packages to put into a Lookup data structure.
            List<Package> packages = new List<Package> { new Package { Company = "Coho Vineyard", Weight = 25.2, TrackingNumber = 89453312L },
                                                 new Package { Company = "Lucerne Publishing", Weight = 18.7, TrackingNumber = 89112755L },
                                                 new Package { Company = "Wingtip Toys", Weight = 6.0, TrackingNumber = 299456122L },
                                                 new Package { Company = "Contoso Pharmaceuticals", Weight = 9.3, TrackingNumber = 670053128L },
                                                 new Package { Company = "Wide World Importers", Weight = 33.8, TrackingNumber = 4665518773L } };

            // Create a Lookup to organize the packages. Use the first character of Company as the key value. 
            // Select Company appended to TrackingNumber for each element value in the Lookup.
            ILookup<char, string> lookup = (Lookup<char, string>)packages.ToLookup(p => Convert.ToChar(p.Company.Substring(0, 1)),
                                                            p => p.Company + " " + p.TrackingNumber);

            // Iterate through each IGrouping in the Lookup and output the contents. 
            foreach (IGrouping<char, string> packageGroup in lookup)
            {

                // Print the key value of the IGrouping.
                Console.WriteLine(packageGroup.Key);
                // Iterate through each value in the IGrouping and print its value. 
                foreach (string str in packageGroup)
                    Console.WriteLine("    {0}", str);
            }

            // This code produces the following output: 
            // 
            // C 
            //     Coho Vineyard 89453312 
            //     Contoso Pharmaceuticals 670053128 
            // L 
            //     Lucerne Publishing 89112755 
            // W 
            //     Wingtip Toys 299456122 
            //     Wide World Importers 4665518773 

            // Get the number of key-collection pairs in the Lookup. 
            int count = lookup.Count;

            // Select a collection of Packages by indexing directly into the Lookup.
            IEnumerable<string> cgroup = lookup['C'];

            // Output the results.
            Console.WriteLine("\nPackages that have a key of 'C':");
            foreach (string str in cgroup)
                Console.WriteLine(str);

            // This code produces the following output: 
            // 
            // Packages that have a key of 'C' 
            // Coho Vineyard 89453312 
            // Contoso Pharmaceuticals 670053128 

            // Determine if there is a key with the value 'G' in the Lookup. 
            bool hasG = lookup.Contains('G');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //http://sp.saipayadak.org/sy_webservice/mainservice.asmx
        }

        private void btnSms_Click(object sender, EventArgs e)
        {
            txtXmlOutput.Clear();
            int retval=SendEmdadSms(txtMobileno.Text, txtUserInput.Text, "0057695849", 0, 1);
            
            txtXmlOutput.Text = retval.ToString();
        }

        public static int SendEmdadSms(string strMobileNo, string strMessage, string strNationalNo, long nMsgId, int MsgType)
        {

            RahyabService.Send mySms = new RahyabService.Send();

            long[] rec = null;
            byte[] status = null;
            int retval = -1;

            retval = mySms.SendSms("websale", "websale!@#$", new string[] { strMobileNo }, "100096550", strMessage, false, "", ref rec, ref status);

            return retval;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlCommand objComm = new SqlCommand();

            SqlConnection objConnection = new SqlConnection("Data Source=H-SAYYAR\\MSSQLSERVER2012;Initial Catalog=myTest;Integrated Security=True");

            try
            {
                objConnection.Open();
            }
            catch
            {
            }
            try
            {

                objComm.Connection = objConnection;
                objComm.CommandType = CommandType.Text;

                objComm.CommandText = "select * from Table_1 where SerialId=1";
                SqlDataReader dr = objComm.ExecuteReader();
                dr.Read();
                byte[] arrPicture = ((byte[])(dr["PersonImage"]));

                /*
                objComm.CommandText = " select tasvier from hrPersonel where tasvier is not null";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(objComm);
                da.Fill(dt);
                byte[] arrPicture = ((byte[])(dt.Rows[0]["tasvier"]));
                */

                MemoryStream ms = new MemoryStream(arrPicture);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// ذخیره تصویر در بانک اطلاعات
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] bb = new byte[1000];
            MemoryStream s1 = new MemoryStream();
            pictureBox1.Image.Save(s1, System.Drawing.Imaging.ImageFormat.Jpeg);

            //Image img1=new Bitmap(s1);
            bb = s1.ToArray();

            SqlConnection objConnection = new SqlConnection("Data Source=H-SAYYAR\\MSSQLSERVER2012;Initial Catalog=myTest;Integrated Security=True");

            try
            {
                objConnection.Open();
            }
            catch
            {
            }
            try
            {
                SqlCommand objComm = new SqlCommand();
                objComm.Connection = objConnection;
                objComm.CommandType = CommandType.StoredProcedure;
                objComm.CommandText = "sp_Update_Table_1";
                SqlParameter objParameter = new SqlParameter("@pk", 1);
                objComm.Parameters.Add(objParameter);
                objParameter = new SqlParameter("@PersonImage", bb);
                objComm.Parameters.Add(objParameter);
                objComm.ExecuteNonQuery();

                MessageBox.Show("ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}

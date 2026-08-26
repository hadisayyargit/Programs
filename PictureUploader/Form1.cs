using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PictureUploader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int SelectedRowIndex { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowTemplate.MinimumHeight = 100;
            
            RefreshForm();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();


            if(picShow.Image==null)
            {
                MessageBox.Show("select an image");
                return;
            }




            picShow.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] arrayPic = ms.GetBuffer();



            //SqlConnection con = new SqlConnection(@"Data Source=.\MSSQL2019; initial catalog=auto1; Integrated Security=true;TrustServerCertificate=True");

            SqlConnection con = new SqlConnection(@"server=31.25.91.7; database=khordadn_auto1;TrustServerCertificate=True; user id=khordadn_auto1; password=Una6_388b");

            /*
             "Auto1ConnectionString": "server=31.25.91.7; database=khordadn_auto1;TrustServerCertificate=True; user id=khordadn_auto1; password=Una6_388b"
             */

            SqlCommand cmd = new SqlCommand();


            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {                
                cmd.Connection = con;
                cmd.CommandText = " UPDATE car SET [thumbnailphoto]=@binaryval where carid =" + dataGridView1[1,this.SelectedRowIndex].Value.ToString();
                SqlParameter p1 = new SqlParameter("@binaryval", SqlDbType.VarBinary);
                
                p1.Value = arrayPic;
                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshPicture_Click(object sender, EventArgs e)
        {
            RefreshForm();

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        picShow.Image.Save(saveFileDialog.FileName);
                    }
                }
                MessageBox.Show("Success");
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                // MessageBox.Show(dataGridView1[ 1,e.RowIndex].Value.ToString());
                openFileDialog1.ShowDialog();
                picShow.ImageLocation = openFileDialog1.FileName;
                SelectedRowIndex = e.RowIndex;

            }
        }

        private void RefreshForm()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection(@"server=31.25.91.7; database=khordadn_auto1;TrustServerCertificate=True; user id=khordadn_auto1; password=Una6_388b");
            DataTable dtResult = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmd.Connection = con;
            cmd.CommandText = "SELECT CarId, Pname,thumbnailphoto FROM car";
            da.SelectCommand = cmd;

            da.Fill(dtResult);


            dataGridView1.DataSource = dtResult;


            /*
            SqlDataReader da = cmd.ExecuteReader();
         
            while (da.Read())
            {
               // arrayPic = (byte[])da["thumbnailphoto"];
               // ms = new MemoryStream(arrayPic);
               // picShow.Image = Image.FromStream(ms);

            }

            */
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExeCRUD
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-DMUVDQOK\\WIRATAMA;Initial Catalog=ExeCRUD;User ID=sa;Password=Yama190220");

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exeCRUDDataSet2.SiswaC' table. You can move, or remove it, as needed.
            this.siswaCTableAdapter.Fill(this.exeCRUDDataSet2.SiswaC);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.SP_SiswaC_Add '" + (tb1.Text) + "','" + tb2.Text + "','" + DateTime.Parse(dateTimePicker1.Text) + "','" + tb4.Text + "','" + tb5.Text + "'", con);
            
            con.Close();
            MessageBox.Show("Successfully Saved");
            Read();
        }
        void Read()
        {
            SqlCommand com = new SqlCommand("exec dbo.SP_SiswaC_Read");
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.SP_SiswaC_Update '" + (tb1.Text) + "','" + tb2.Text + "','" + DateTime.Parse(dateTimePicker1.Text) + "','" + tb4.Text + "','" + tb5.Text + "'", con);
            
            con.Close();
            MessageBox.Show("Successfully Update");
            Read();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            if (MessageBox.Show("Anda Yakin Untuk Menghapus?", "Enter", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand com = new SqlCommand("exec dbo.SP_SiswaC_Delete '" + (tb1.Text) + "','" + tb2.Text + "','" + DateTime.Parse(dateTimePicker1.Text) + "','" + tb4.Text + "','" + tb5.Text + "'", con);
                
                con.Close();
                MessageBox.Show("Successfully Deleted");
                Read();
            }
        }
    }
}

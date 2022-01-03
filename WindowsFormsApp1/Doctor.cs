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

namespace WindowsFormsApp1
{
    public partial class Doctor : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shan\Documents\ChannelCenterdb.mdf;Integrated Security=True;Connect Timeout=30");
        public Doctor()
        {
            InitializeComponent();
        }
    void populate()
        {
            sqlcon.Open();
            string query = "select * from DoctorTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
            sqlcon.Close();

        }
        void SearchDoc()
        {
            sqlcon.Open();
            string query = "select * from DoctorTbl where DoctorId=" + DocID.Text + "";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
            sqlcon.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home H = new Home();
            H.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string query = "update DoctorTbl set DoctorName='" + DocName.Text + "',ChannelingDate='"+ChanelDate.Text+"',ChannelingFee='"+ChanelFee.Text+"',Specialization='"+Specialization.Text+"' where DoctorId="+DocID.Text+"";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Docter Details Successfully Updated");
            sqlcon.Close();
            populate();
        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DocID.Text == "" || DocName.Text == "" || ChanelDate.Text == "" || ChanelFee.Text == "" || Specialization.Text == "")
                MessageBox.Show("No Empty Fill Accepted");
            else
            {
                sqlcon.Open();
                string query = "insert into DoctorTbl values('" + DocID.Text + "','" + DocName.Text + "','" + ChanelDate.Text + "','" + ChanelFee.Text + "','" + Specialization.Text + "')";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Added Successfully");
                sqlcon.Close();
                populate();
            }
        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DocID.Text == "")
                MessageBox.Show("Enter The Doctor Id");
            else
            {
                sqlcon.Open();
                string query = "delete from DoctorTbl where DoctorId="+DocID.Text+"";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Docter Successfully Deleted");
                sqlcon.Close();
                populate();
            }
        }

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocID.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
            DocName.Text = DoctorGV.SelectedRows[0].Cells[1].Value.ToString();
            ChanelDate.Text = DoctorGV.SelectedRows[0].Cells[2].Value.ToString();
            ChanelFee.Text = DoctorGV.SelectedRows[0].Cells[3].Value.ToString();
            Specialization.Text = DoctorGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
            if (DocID.Text == "")
            {
                sqlcon.Open();
                string query = "select * from DoctorTbl ";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                populate();
            }
              
            else
            {
                sqlcon.Open();
                string query = "select * from DoctorTbl where DoctorId=" + DocID.Text + "";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                SearchDoc();
            }
        }
    }
}

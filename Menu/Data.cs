using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Library_Management_Syatem
{
    public partial class Data : Form
    {
        MySqlCommand cmd;
        MySqlDataAdapter ad;
        MySqlConnection con = new MySqlConnection(@"server=127.0.0.1;uid=root;pwd=;database=library_management_system");
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        Thread th;
        public Data()
        {
            InitializeComponent();
        }
        private void Students()
        {
            dt1.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student_Table";
            ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con.Close();
        }

        private void books()
        {
            dt.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Book_Table";
            ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void vendor()
        {
            dt2.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Vendor_Table";
            ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt2);
            dataGridView1.DataSource = dt2;
            con.Close();
        }

        private void inventory()
        {
            dt3.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Inventory_Table";
            ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt3);
            dataGridView1.DataSource = dt3;
            con.Close();
        }

        private void Books_Students_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Students();
        }

        private void opendataform()
        {
            Application.Run(new Data());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            books();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vendor();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inventory();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openhomeform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openhomeform()
        {
            Application.Run(new Home());
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}

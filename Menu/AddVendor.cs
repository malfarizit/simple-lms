using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_Management_Syatem
{
    public partial class AddVendor : Form
    {
        MySqlDataAdapter ad;
        DataTable dt = new DataTable();
        MySqlCommand cmd;
        MySqlConnection con = new MySqlConnection(@"server=127.0.0.1;uid=root;pwd=;database=library_management_system");
        Thread th;
        public AddVendor()
        {
            InitializeComponent();
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

        private void openvendorform()
        {
            Application.Run(new AddVendor());
        }

        private void insertintoactivitylog()
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into ActivityLog_Table values(Default,'Vendor(" + textBoxname.Text + ") is Added.')";
            //cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnaddvendor_Click(object sender, EventArgs e)
        {
            if (textBoxid.Text == "")
            {
                MessageBox.Show("Please Enter Vendor ID");
            }
            else if (textBoxname.Text == "")
            {
                MessageBox.Show("Please Enter Vendor Name");
            }
            else if (textBoxphone.Text == "")
            {
                MessageBox.Show("Please Enter Phone Number");
            }
            else
            {
                check();
                if (dt.Rows.Count == 0)
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Vendor_Table values(" + int.Parse(textBoxid.Text) + ",'" + textBoxname.Text + "','" + textBoxaddress.Text + "','" + textBoxphone.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    insertintoactivitylog();
                    MessageBox.Show("Vendor Added Successfully");
                    textBoxid.Text = "";
                    textBoxname.Text = "";
                    textBoxaddress.Text = "";
                    textBoxphone.Text = "";
                }
                else
                {
                    MessageBox.Show("ID already exists");
                    this.Close();
                    th = new Thread(openvendorform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }
        }

        private void check()
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * From Vendor_Table where Vendor_ID=" + int.Parse(textBoxid.Text) + "";
            //cmd.ExecuteNonQuery();
            ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt);
            con.Close();
        }

        private void AddVendor_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Home : Form
    {
        Thread th;
        MySqlCommand cmd;
        MySqlConnection con = new MySqlConnection(@"server=127.0.0.1;uid=root;pwd=;database=library_management_system");
        public Home()
        {
            InitializeComponent();
        }

        private void btnaddbook_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openaddbookform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void openaddbookform()
        {
            Application.Run(new AddBook());
        }

        private void btnaddstudent_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openaddstudentform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void openaddstudentform()
        {
            Application.Run(new AddStudent());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opensearchstudentbookform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void opensearchstudentbookform()
        {
            Application.Run(new SearchStudentorBook());
        }

        private void btnissuebook_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openissuebookform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openissuebookform()
        {
            Application.Run(new IssueBook());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openaddvendorform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openaddvendorform()
        {
            Application.Run(new AddVendor());
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openaddvendorform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }


        private void Home_Load(object sender, EventArgs e)
        {
            labelontime.Text = DateTime.Now.ToLongTimeString();
            labelondate.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelontime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openloginform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into activitylog_table values(Default,'" + Login.Admin_ID + " is Logged out.')";
            //cmd.ExecuteNonQuery();
            con.Close();
        }

        private void openloginform()
        {
            Application.Run(new Login());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opendataform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opendataform()
        {
            Application.Run(new Data());
        }

        
        private void openupdateform()
        {
            Application.Run(new UpdateStudent());
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openupdateform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opendelform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opendelform()
        {
            Application.Run(new Delete());
        }
    }
}

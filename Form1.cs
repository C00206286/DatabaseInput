using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DatabaseInput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            findCompanies();

        }

        private void CompanyBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void findCompanies()
        {
            // Add all companies in database to combo box

            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=niteldb;password=Crab123");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from company", con);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                // if (row["name"].ToString() == xlRange.Cells[i, y].Value2.ToString())
                //{

                // owner = row[0].ToString();
                CompanyBox.Items.Add(row["name"].ToString());
                //  }
            }
            cmd.Dispose();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add Company

            CompanyBox.Items.Add("A");
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=niteldb;password=Crab123");
            con.Open();
            string companyName = CompanyTextBox.Text.ToString();
            string accountCode = AccountTextBox.Text.ToString();
            MySqlCommand cmd2 = new MySqlCommand("INSERT into company (name,account) values (\""+companyName+"\","+accountCode+")", con);
            MySqlDataAdapter adp2 = new MySqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            adp2.Fill(dt2);
            cmd2.Dispose();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            findCompanies();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Add Number

            string owner = "";
            string number = NumberTextBox.Text.ToString();
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=niteldb;password=Crab123");
            con.Open();
            MySqlCommand cmd3 = new MySqlCommand("select * from company", con);
            MySqlDataAdapter adp3 = new MySqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            adp3.Fill(dt3);

            foreach (DataRow row in dt3.Rows)
            {
                if (row["name"].ToString() == CompanyBox.SelectedItem.ToString())
                {

                    owner = row[0].ToString();
                }
            }
            cmd3.Dispose();

            MySqlCommand cmd4 = new MySqlCommand("INSERT into numbers (number,owner) values (\""+number+"\",\""+owner+"\")", con);
            MySqlDataAdapter adp4 = new MySqlDataAdapter(cmd4);
            DataTable dt4 = new DataTable();
            adp4.Fill(dt4);

            cmd4.Dispose();
            con.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }

        private void CompanyTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DUET_Transport_management_system
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
                    }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            String Query = "insert into user_table(name,username,userpass,contact_number) values ('" + this.NameTextBox.Text + "','" + this.UserNameTextBox.Text + "', '" + this.PassWordTextBox.Text + "','" + this.ContactNumberTextBox.Text + "');";
            SqlCommand cmd = new SqlCommand(Query, cnn);
            SqlDataReader MyReader;
            try
            {
                cnn.Open();
                MyReader = cmd.ExecuteReader();
                //MessageBox.Show("Saved", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                MessageBox.Show("saved");
                while (MyReader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

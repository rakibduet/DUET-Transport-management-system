using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;



namespace DUET_Transport_management_system
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }

        private void SubmitButton_Click_1(object sender, EventArgs e)
        {
            
            SqlConnection cnn;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            String Query = "insert into user_table (username,password) values ('" + this.UserNameTextBox.Text + "','" + this.PassWordTextBox.Text + "');";
            
            cnn.Open();
           string  username = UserNameTextBox.Text;

          String password = PassWordTextBox.Text;

           
                String query = "select username,userpass from user_table;";
                SqlCommand com = new SqlCommand(query, cnn);

                SqlDataReader reader = com.ExecuteReader();
                int flag = 0;
                while (reader.Read())
                {
                    string name = reader[0].ToString();
                    string pass = reader[1].ToString();
                    if (name == username && pass == password)
                    {
                        flag = 1;
                        break;
                    }

                }
                if (flag == 1)  //if user credential is matched then Usercount value is 1 otherwise it is 0
                {
                    this.Hide(); //hiding form 1
                    welcomeForm obj = new welcomeForm(); //Main M1 = new Main(username);//ing user Name to Second form so we can user Logged user Name
                    obj.Show();
                    Visible = false;
                    //MessageBox.Show("welcome");
                }
                else
                {


                    loginmsg.ForeColor = Color.Red; //if user Name is not available in database

                }

            }

            /*ShowUser obj = new ShowUser();
            obj.Show();
            Visible = false;
             */
        

        private void PassWordTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UserNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(UserNameTextBox, true, true, true, true);

        }

        private void PassWordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(PassWordTextBox, true, true, true, true);

        }

       

        private void Login_Load(object sender, EventArgs e)
        {
            label3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0066CC");
            label4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0066CC");
            this.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3E5B");
            //user.ForeColor = System.Drawing.ColorTranslator.FromHtml("#778899");
            //pass.ForeColor = System.Drawing.ColorTranslator.FromHtml("#778899");
            loginmsg.ForeColor = Color.CadetBlue;

           /* label1.BackColor = Color.Pink;
            label2.BackColor = Color.Pink;
            label3.BackColor = Color.PaleGreen;
            label4.BackColor = Color.PaleGreen;
            label5.BackColor = Color.Red;
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Red;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            SubmitButton.ForeColor = Color.SeaGreen;*/
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
           // this.BackColor = Color.CadetBlue;
          
           
        }

        private void UserNameTextBox_Enter(object sender, EventArgs e)
        {
            //if (UserNameTextBox.Text == "username")
             //   UserNameTextBox.Text = "";
        }

        private void UserNameTextBox_Leave(object sender, EventArgs e)
        {

           // if (UserNameTextBox.Text == "")
           // {
              //  UserNameTextBox.Text = "username";
               // UserNameTextBox.ForeColor = Color.LightGray;

           // }
         
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UserNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            
               // MessageBox.Show("Please Enter a Username:");
        }

        private void PassWordTextBox_Validating(object sender, CancelEventArgs e)
        {
            //if (PassWordTextBox.Text == string.Empty)
               // MessageBox.Show("Please Enter a Password");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Location = new Point(
         this.ClientSize.Width / 2 - panel1.Size.Width / 2,
           this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
            this.BackColor = Color.CadetBlue;
            this.panel1.BackColor = Color.CadetBlue;
            //menuStrip1.BackColor = Color.CadetBlue;
            this.label3.BackColor = Color.CadetBlue;
            this.loginmsg.BackColor = Color.CadetBlue;
           // this.loginmsg.ForeColor = Color.CadetBlue;

        }

        private void UserNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 0)
                loginmsg.ForeColor = Color.CadetBlue;
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButton_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void PassWordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 0)
                loginmsg.ForeColor = Color.CadetBlue;

        }

       

     

        
        }

       
    }



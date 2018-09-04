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
    public partial class Requisition_Form : Form
    {
        public Requisition_Form()
        {
            InitializeComponent();
            Fillcombo();          
        }

        
        void Fillcombo()
        {
           // dateTimePicker2.CustomFormat = "hh:mm";
            dateTimePicker.Value = DateTime.Today;
           dateTimePicker2.Value = DateTime.Now;
           timepicker3.Value = DateTime.Now;
            SqlConnection cnn;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
          
            SqlCommand  cmd = new SqlCommand("select teacher_id from teacher ORDER BY teacher_id;", cnn);
               cnn.Open();

               SqlDataReader reader = cmd.ExecuteReader();
               while (reader.Read())
               {
                   string name = reader[0].ToString();
                   TeacherIdComboBox.Items.Add(name);

               }
               reader.Close();
              cmd = new SqlCommand("select employee_name from transport_employee where employee_designation='Driver';", cnn);

              reader = cmd.ExecuteReader();
               while (reader.Read())
               {
                    string name = reader[0].ToString();
                   
                   DriverComboBox.Items.Add(name);

               }
            
        }

        private void Requisition_Form_Load(object sender, EventArgs e)
        {
            //TeacherIdComboBox.Focus();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#778899");
             
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name= TeacherIdComboBox.Text;
            SqlConnection cnn;
            
            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select teacher_name,teacher_designation from teacher where teacher_id='" + this.TeacherIdComboBox.Text + "';", cnn);
            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
               reader.Read();
                string result = reader[0].ToString();
                string result1 = reader[1].ToString();
                TeacherNameTextBox.Text = result;
                TeacherDesignationomboBox.Text = result1;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
           
            string id = TeacherIdComboBox.Text;
           
            DateTime starttime = dateTimePicker2.Value;

      
            DateTime endtime = timepicker3.Value;
               TimeSpan spacetime = endtime - starttime;
               int x = spacetime.Hours;
                     //        MessageBox.Show(x.ToString());
                  DateTime startdate = dateTimePicker.Value;
                      TimeSpan span=DateTime.Today-startdate;
                      int y = span.Days;
            //MessageBox.Show(y.ToString());
               
          
            if (id.Length == 0)
                MessageBox.Show("Plz Select a Teacher ID");


            else
            {
                String Query = "insert into requisition (teacher_id,teacher_name,teacher_designation,transport_category,transport_number,driver_name,date,start_time,return_time,purpose) values ( '" + this.TeacherIdComboBox.Text + "' ,'" + this.TeacherNameTextBox.Text + "', '" + this.TeacherDesignationomboBox.Text + "','" + this.CategorycomboBox.Text + "','" + this.TransportNumberComboBox.Text + "','" + this.DriverComboBox.Text + "','" + this.dateTimePicker.Value + "','" + starttime + "','" + endtime + "','" + this.PurposeComboBox.Text + "');";
                SqlCommand cmd = new SqlCommand(Query, cnn);
                //SqlDataReader MyReader;



                cnn.Open();
                cmd.ExecuteReader();
                this.TeacherIdComboBox.Text = string.Empty;
                //MessageBox.Show("Saved", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                MessageBox.Show("saved");
               
            }

            Requisition_Form obj = new Requisition_Form();
            obj.Show();
            Visible = false;

        }

       

        private void CategorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select transport_number from transport where transport_catagory='"+this.CategorycomboBox.Text+ "';", cnn);
            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            this.TransportNumberComboBox.Items.Clear();
            while (reader.Read())
            {
                string name = reader[0].ToString();
                //MessageBox.Show(name);
                TransportNumberComboBox.Items.Add(name);

            }
          
            reader.Close();
        }

        private void teacherToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Teacher_Form obj = new Teacher_Form();
            obj.Show();
            Visible = false;
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TransportEmployee obj = new TransportEmployee();
            obj.Show();
            Visible = false;
        }

        private void transportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Transport_Form obj = new Transport_Form();
            obj.Show();
            Visible = false;
        }

        private void requisitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Requisition_Form obj = new Requisition_Form();
            obj.Show();
            Visible = false;
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm o = new UserForm();
            o.Show();
            Visible = false;
        }

        private void personalCarUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal_Car_Use_Form obj = new Personal_Car_Use_Form();
            obj.Show();
            Visible = false;
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usage_Equipment o = new Usage_Equipment();
            o.Show();
            Visible = false;
        }

        private void storedEquipmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Purchase_equipment o = new Purchase_equipment();
            o.Show();
            Visible = false;

        }

        private void transportScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transportListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTransport obj = new ViewTransport();
            obj.Show();
            Visible = false;
        }

        private void personalCarUseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewpersonalcaruse obj = new viewpersonalcaruse();
            obj.Show();
            Visible = false;
        }

        private void requisitionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewrequisition obj = new viewrequisition();
            obj.Show();
            Visible = false;
        }

        private void usageEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUsageEquipment obj = new ViewUsageEquipment();
            obj.Show();
            Visible = false;
        }

        private void storedEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStorageEquipmentForm obj = new ViewStorageEquipmentForm();
            obj.Show();
            Visible = false;
        }

        private void teacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewTeacher obj = new ViewTeacher();
            obj.Show();
            Visible = false;
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowUser obj = new ShowUser();
            obj.Show();
            Visible = false;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Location = new Point(
           this.ClientSize.Width / 2 - panel1.Size.Width / 2,
             this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
            //this.BackColor = System.Drawing.ColorTranslator.FromHtml("#778899");
            this.BackColor = Color.CadetBlue;
            menuStrip1.BackColor = Color.CadetBlue;
            this.label13.BackColor = Color.CadetBlue;
            this.label2.BackColor = Color.CadetBlue;
            this.label3.BackColor = Color.CadetBlue;
            this.label5.BackColor = Color.CadetBlue;
            this.label6.BackColor = Color.CadetBlue;
            this.label7.BackColor = Color.CadetBlue;
            this.label8.BackColor = Color.CadetBlue;
            this.label9.BackColor = Color.CadetBlue;
            this.label10.BackColor = Color.CadetBlue;
            this.label12.BackColor = Color.CadetBlue;
            this.label14.BackColor = Color.CadetBlue;
        }

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewemployeeForm o = new ViewemployeeForm();
            o.Show();
            Visible = false;
        }

        private void purchaseEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPurchasesEquipmentForm o = new ViewPurchasesEquipmentForm();
            o.Show();
            Visible = false;
        }

        private void teacherInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTeacherForm o = new EditTeacherForm();
            o.Show();
            Visible = false;
        }

        private void employeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditEmployeeForm o = new EditEmployeeForm();
            o.Show();
            Visible = false;
        }

        private void transportInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTransportForm o = new EditTransportForm();
            o.Show();
            Visible = false;
        }

        private void requisitionInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRequisitionForm o = new EditRequisitionForm();
            o.Show();
            Visible = false;
        }

        private void carUseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPersonalCarUseForm o = new EditPersonalCarUseForm();
            o.Show();
            Visible = false;
        }

        private void equipmentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPurchaseEquipmentForm o = new EditPurchaseEquipmentForm();
            o.Show();
            Visible = false;
        }

        private void storedEquipmentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditUsagesEquipmentForm o = new EditUsagesEquipmentForm();
            o.Show();
            Visible = false;
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUserForm o = new EditUserForm();
            o.Show();
            Visible = false;
        }



      

      

        }

     
    }


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
    public partial class EditRequisitionForm : Form
    {
        public EditRequisitionForm()
        {
            InitializeComponent();
            Fillcombo();
        }
        void Fillcombo()
        {
         

            SqlConnection cnn;
            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select requisition_number from requisition ORDER BY requisition_number;", cnn);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader[0].ToString();
                RequisitionIdcomboBox.Items.Add(name);

            }
            reader.Close();
            //cnn.Close();
     


        
            
         
        }

        private void RequisitionIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           // String name = TechIdcomboBox.Text;
            SqlConnection cnn1;

            cnn1 = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");

            SqlCommand cmd1 = new SqlCommand("select teacher_id from teacher ORDER BY teacher_id;", cnn1);
            cnn1.Open();

            SqlDataReader reader1 = cmd1.ExecuteReader();
            this.TeacherIdcomboBox.Items.Clear();
            while (reader1.Read())
            {
                string name = reader1[0].ToString();
                TeacherIdcomboBox.Items.Add(name);
                //MessageBox.Show(TeacherIdcomboBox.Text);

            }
            reader1.Close();

            SqlConnection cnn2;

            cnn2 = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd3 = new SqlCommand("select transport_number from transport;", cnn2);
            cnn2.Open();

            SqlDataReader reader3 = cmd3.ExecuteReader();
            this.TransportNumberComboBox.Items.Clear();
            while (reader3.Read())
            {
                string name = reader3[0].ToString();
                //MessageBox.Show(name);
                TransportNumberComboBox.Items.Add(name);

            }

            reader3.Close();

            SqlConnection cnn4;

            cnn4 = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd4 = new SqlCommand("select employee_name from transport_employee where employee_designation='Driver' ;", cnn4);
            cnn4.Open();
            SqlDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
            {
                string name = reader4[0].ToString();

                DriverComboBox.Items.Add(name);

            }
            reader4.Close();

            SqlConnection cnn;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select teacher_id,teacher_name,teacher_designation,transport_category,transport_number,driver_name,date,start_time,return_time,purpose from requisition where requisition_number='" + this.RequisitionIdcomboBox.Text + "';", cnn);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
           reader.Read();
          
                string result1 = reader[0].ToString();
                string result2 = reader[1].ToString();
                string result3 = reader[2].ToString();
                string result4 = reader[3].ToString();
                string result5 = reader[4].ToString();
                string result6 = reader[5].ToString();
                string result7 = reader[6].ToString();
                string result8 = reader[7].ToString();
                string result9 = reader[8].ToString();
                string result10 = reader[9].ToString();

                TeacherIdcomboBox.Text = result1;
                TeacherNameTextBox.Text = result2;
                TeacherDesignationomboBox.Text = result3;
                CategorycomboBox.Text = result4;
                TransportNumberComboBox.Text = result5;
                DriverComboBox.Text = result6;
                dateTimePicker.Text = result7;
                dateTimePicker2.Text = result8;
                timepicker3.Text = result9;
                PurposeComboBox.Text = result10;
                //MessageBox.Show(dateTimePicker.Text);
                //MessageBox.Show(dateTimePicker2.Text);
                //MessageBox.Show(timepicker3.Text);

            
            reader.Close();

            
        }

        private void EditRequisitionForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;




            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");

            string query = "update requisition set teacher_id='" + TeacherIdcomboBox.Text + "',teacher_name='" + TeacherNameTextBox.Text + "',teacher_designation='" + TeacherDesignationomboBox.Text + "',transport_category='" + CategorycomboBox.Text + "',transport_number='" + TransportNumberComboBox.Text + "',driver_name='" + DriverComboBox.Text + "', date='" + dateTimePicker.Value + "', start_time='" + dateTimePicker2.Value + "', return_time='" + timepicker3.Value + "', purpose='" + PurposeComboBox.Text + "' where requisition_number='" + this.RequisitionIdcomboBox.Text + "';";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            MessageBox.Show("updated");
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

            this.label1.BackColor = Color.CadetBlue;
            this.label2.BackColor = Color.CadetBlue;
            this.label3.BackColor = Color.CadetBlue;
            this.label7.BackColor = Color.CadetBlue;
            this.label5.BackColor = Color.CadetBlue;
            this.label6.BackColor = Color.CadetBlue;
            this.label8.BackColor = Color.CadetBlue;

            this.label4.BackColor = Color.CadetBlue;
            this.label9.BackColor = Color.CadetBlue;
            this.label10.BackColor = Color.CadetBlue;
            this.label12.BackColor = Color.CadetBlue;
            //this.label6.BackColor = Color.CadetBlue;
            //this.label8.BackColor = Color.CadetBlue;
        }

        private void teacherToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Teacher_Form o = new Teacher_Form();
            o.Show();
            this.Hide();
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TransportEmployee obj = new TransportEmployee();
            obj.Show();
            Visible = false;
        }

        private void transportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Transport_Form o = new Transport_Form();
            o.Show();
            this.Hide();
        }

        private void requisitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Requisition_Form o = new Requisition_Form();
            o.Show();
            this.Hide();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm o = new UserForm();
            o.Show();
            this.Hide();
        }

        private void personalCarUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal_Car_Use_Form o = new Personal_Car_Use_Form();
            o.Show();
            this.Hide();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usage_Equipment o = new Usage_Equipment();
            o.Show();
            this.Hide();
        }

        private void transportScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void purchaseEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_equipment o = new Purchase_equipment();
            o.Show();
            this.Hide();
        }

        private void transportListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTransport o = new ViewTransport();
            o.Show();
            this.Hide();
        }

        private void teacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewTeacher o = new ViewTeacher();
            o.Show();
            this.Hide();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewemployeeForm o = new ViewemployeeForm();
            o.Show();
            this.Hide();
        }

        private void requisitionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewrequisition o = new viewrequisition();
            o.Show();
            this.Hide();
        }

        private void personalCarUseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewpersonalcaruse o = new viewpersonalcaruse();
            o.Show();
            this.Hide();
        }

        private void usageEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUsageEquipment o = new ViewUsageEquipment();
            o.Show();
            this.Hide();
        }

        private void storedEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStorageEquipmentForm o = new ViewStorageEquipmentForm();
            o.Show();
            this.Hide();
        }

        private void purchaseEquipmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewPurchasesEquipmentForm obj = new ViewPurchasesEquipmentForm();
            obj.Show();
            Visible = false;
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowUser o = new ShowUser();
            o.Show();
            this.Hide();
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

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUserForm o = new EditUserForm();
            o.Show();
            Visible = false;
        }

        private void equipmentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUsagesEquipmentForm o = new EditUsagesEquipmentForm();
            o.Show();
            Visible = false;
        }

        private void storedEquipmentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditPurchaseEquipmentForm o = new EditPurchaseEquipmentForm();
            o.Show();
            Visible = false;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login o = new Login();
            o.Show();
            Visible = false;
        }

        private void storedEquipmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Purchase_equipment o = new Purchase_equipment();
            o.Show();
            Visible = false;
        }

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewemployeeForm o = new ViewemployeeForm();
            o.Show();
            Visible = false;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            //String name2 = TransportNumbercomboBox.Text;
            // MessageBox.Show(name1);
            //MessageBox.Show(name);

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");

            string query = "delete from  requisition  where requisition_number='" + this.RequisitionIdcomboBox.Text + "';";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            MessageBox.Show("Data has been Deleted.");
        }

        
    }
}

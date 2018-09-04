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
    public partial class EditPersonalCarUseForm : Form
    {
        public EditPersonalCarUseForm()
        {
            InitializeComponent();
            Fillcombo();
        }
        void Fillcombo()
        {


            SqlConnection cnn;
            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select use_number from per_car_use ORDER BY use_number;", cnn);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader[0].ToString();
                UseNumbercomboBox.Items.Add(name);

            }
            reader.Close();
            //cnn.Close();
        }

        private void UseNumbercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn1;

            cnn1 = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");

            SqlCommand cmd1 = new SqlCommand("select teacher_id from teacher;", cnn1);
            cnn1.Open();

            SqlDataReader reader1 = cmd1.ExecuteReader();
            this.TeacherIdComboBox.Items.Clear();
            while (reader1.Read())
            {
                string name = reader1[0].ToString();
                TeacherIdComboBox.Items.Add(name);
                //MessageBox.Show(TeacherIdcomboBox.Text);

            }
            reader1.Close();

            SqlConnection cnn2;

            cnn2 = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd7 = new SqlCommand("select teacher_id,return_date,return_time,total_km from per_car_use where use_number='" + this.UseNumbercomboBox.Text + "';", cnn2);
            cnn2.Open();
            SqlDataReader reader = cmd7.ExecuteReader();
            //this.TeacherIdComboBox.Items.Clear();
            reader.Read();
            
                string name1 = reader[0].ToString();
                string name2 = reader[1].ToString();
                string name3 = reader[2].ToString();
                string name5 = reader[3].ToString();
                TeacherIdComboBox.Text = name1;
                ReturnDatePicker.Text = name2;
                RetrunTimePicker.Text = name3;
                TotalKmTextBox.Text = name5;

              
            reader.Close();

            SqlConnection cnn3;

            cnn3 = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");

            SqlCommand cmd3 = new SqlCommand("select requisition_number from requisition where teacher_id= '" + this.TeacherIdComboBox.Text + "';", cnn3);
            cnn3.Open();

            SqlDataReader reader2 = cmd3.ExecuteReader();
            this.RequisitionNumberTextBox.Clear();
            while (reader2.Read())
            {
                string name4 = reader2[0].ToString();
                RequisitionNumberTextBox.Text = name4;
               // MessageBox.Show(name4);


            }
            reader2.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Location = new Point(
          this.ClientSize.Width / 2 - panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
           //this.BackColor = System.Drawing.ColorTranslator.FromHtml("#778899");
            this.panel1.BackColor = Color.CadetBlue;
            menuStrip1.BackColor = Color.CadetBlue;
            this.label13.BackColor = Color.CadetBlue;
            this.label2.BackColor = Color.CadetBlue;
            this.label3.BackColor = Color.CadetBlue;
            this.label7.BackColor = Color.CadetBlue;
            this.label5.BackColor = Color.CadetBlue;
            this.label6.BackColor = Color.CadetBlue;
            this.label8.BackColor = Color.CadetBlue;
           // this.label3.BackColor = Color.CadetBlue;
           // this.label4.BackColor = Color.CadetBlue;
            //this.label5.BackColor = Color.CadetBlue;
            //this.label6.BackColor = Color.CadetBlue;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DateTime return_date = ReturnDatePicker.Value;
            DateTime return_time = RetrunTimePicker.Value;
            string req_num = RequisitionNumberTextBox.Text;
            string tid = TeacherIdComboBox.Text;
            int km =Int32.Parse( TotalKmTextBox.Text);
            SqlConnection cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select teacher_name,teacher_designation,transport_category,transport_number,date,start_time from requisition where requisition_number='" + req_num + "' ;", cnn);
            cnn.Open();
           SqlDataReader  reader1=cmd.ExecuteReader();
            reader1.Read();
            string tn = reader1[0].ToString();
            string td = reader1[1].ToString();
            string tc = reader1[2].ToString();
            string transport_number=reader1[3].ToString();
            string date=reader1[4].ToString();
            DateTime d=DateTime.Parse(date);
            DateTime stime=DateTime.Parse(reader1[5].ToString());
            reader1.Close();
            MessageBox.Show(date);
            TimeSpan d1 = return_date - d;
            TimeSpan t1 = return_time - stime;
            int day = d1.Days;
            int hours = day * 24 + t1.Hours;
            if (t1.Minutes > 30)
                hours = hours + 1;
            MessageBox.Show(hours.ToString());
            int totalcost=0;
          
            

            //SqlConnection cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
             cmd = new SqlCommand("select transport_rent_per_hour,transport_holdage_per_hour from transport where transport_number='" + transport_number + "' ;", cnn);
           // cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int trph = Int32.Parse(reader[0].ToString());
            int thph = Int32.Parse(reader[1].ToString());

            reader.Close();
            totalcost = trph * km + thph*hours;
            
            



            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");

            string query = "update per_car_use set return_date='" + return_date + "',return_time='" + return_time + "',total_hours='" + hours + "',total_km='" + km + "',total_taka='" + totalcost + "' where use_number='" + this.UseNumbercomboBox.Text + "';";
            cnn.Open();
            cmd = new SqlCommand(query, cnn);
            SqlDataReader reader2 = cmd.ExecuteReader();
            reader2.Close();
            MessageBox.Show("updated");
           /* String Query = "insert into per_car_use (teacher_id,teacher_name,teacher_designation,transport_category,start_date,return_date,start_time,return_time,total_hours,total_km,total_taka) values ( '" + this.TeacherIdComboBox.Text + "' ,'" + tn + "', '" + td + "','" + tc + "','" + d + "','" + return_date + "','" + stime + "','" + return_time + "','" + hours + "','"+ km +"','"+totalcost+"');";
             cmd = new SqlCommand(Query, cnn);
            //SqlDataReader MyReader;



            
            cmd.ExecuteReader();
            this.TeacherIdComboBox.Text = string.Empty;
            //MessageBox.Show("Saved", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            MessageBox.Show("saved");

            Teacher_Form obj = new Teacher_Form();
            obj.Show();
            Visible = false;*/

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
            ViewPurchasesEquipmentForm o = new ViewPurchasesEquipmentForm();
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login o = new Login();
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

            string query = "delete from  purchase_equipments  where purchase_number='" + this.UseNumbercomboBox.Text + "';";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            MessageBox.Show("Data has been Deleted.");
        }


      

        }

    }


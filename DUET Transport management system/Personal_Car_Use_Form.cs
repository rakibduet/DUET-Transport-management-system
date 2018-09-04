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
    public partial class Personal_Car_Use_Form : Form
    {
        String s,tn,td,tc,transport_number;//
        DateTime return_time,return_date,d,stime;
        public Personal_Car_Use_Form()
        {
            InitializeComponent();
            fillcombo();
        }
        void fillcombo()
        {
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


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

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
            //this.label7.BackColor = Color.CadetBlue;
            this.label8.BackColor = Color.CadetBlue;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void ReturnDataTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TeacherIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                 DateTime d = DateTime.Today;
            d = d.AddMonths(-1);
            
             s=TeacherIdComboBox.Text;
            //MessageBox.Show(d.ToString());
            SqlConnection cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select requisition_number from requisition where teacher_id='"+s+"' ;", cnn);
            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            this.RequisitionNumberComboBox.Items.Clear();
            while (reader.Read())
            {
                string name = reader[0].ToString();
                RequisitionNumberComboBox.Items.Add(name);
                RequisitionNumberComboBox.Text = name;

            }
            reader.Close();
          
              
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            return_date = ReturnDatePicker.Value;
            return_time = RetrunTimePicker.Value;
            string req_num = RequisitionNumberComboBox.Text;
            string tid = TeacherIdComboBox.Text;
            int km =Int32.Parse( TotalKmTextBox.Text);
            TimeSpan d1 = return_date - d;
            TimeSpan t1 = return_time - stime;
            int day = d1.Days;
            int hours = day * 24 + t1.Hours;
            if (t1.Minutes > 30)
                hours = hours + 1;
            int totalcost=0;
          
            

            SqlConnection cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select transport_rent_per_hour,transport_holdage_per_hour from transport where transport_number='" + transport_number + "' ;", cnn);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int trph = Int32.Parse(reader[0].ToString());
            int thph = Int32.Parse(reader[1].ToString());

            reader.Close();
            totalcost = trph * km + thph*hours;
            String Query = "insert into per_car_use (teacher_id,teacher_name,teacher_designation,transport_category,start_date,return_date,start_time,return_time,total_hours,total_km,total_taka) values ( '" + this.TeacherIdComboBox.Text + "' ,'" + tn + "', '" + td + "','" + tc + "','" + d + "','" + return_date + "','" + stime + "','" + return_time + "','" + hours + "','"+ km +"','"+totalcost+"');";
             cmd = new SqlCommand(Query, cnn);
            //SqlDataReader MyReader;



            
            cmd.ExecuteReader();
            this.TeacherIdComboBox.Text = string.Empty;
            //MessageBox.Show("Saved", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            MessageBox.Show("saved");

            Personal_Car_Use_Form obj = new Personal_Car_Use_Form();
            obj.Show();
            Visible = false;

        }

        private void RequisitionNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           string req_number = RequisitionNumberComboBox.Text;
            SqlConnection cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select teacher_name,teacher_designation,transport_category,date,start_time,transport_number  from requisition where teacher_id='" + s + "' ;", cnn);
            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
             tn = reader[0].ToString();
             td = reader[1].ToString();
             tc = reader[2].ToString();
            string date1= reader[3].ToString();
            String stime1 = reader[4].ToString();
            transport_number = reader[5].ToString();
            d = Convert.ToDateTime(date1);
            stime=Convert.ToDateTime(stime1);
           
        
             
            reader.Close();
        }

        

        private void teacherToolStripMenuItem2_Click_1(object sender, EventArgs e)
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
            ViewUsageEquipment o = new ViewUsageEquipment();
            o.Show();
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            welcomeForm obj = new welcomeForm();
            obj.Show();
            Visible = false;
        }

        private void TeacherIdComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(RequisitionNumberComboBox, true, true, true, true);
        }

        private void RequisitionNumberComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(ReturnDatePicker, true, true, true, true);
        }

        private void ReturnDatePicker_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(RetrunTimePicker, true, true, true, true);
        }

        private void RetrunTimePicker_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(TotalKmTextBox, true, true, true, true);
    
        }

        private void TotalKmTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TotalKmTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(TotalKmTextBox, true, true, true, true);
        }

        private void TotalKmTextBox_TextChanged(object sender, EventArgs e)
        {

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

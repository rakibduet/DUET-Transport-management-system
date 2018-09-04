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
    public partial class Transport_Form : Form
    {
        public Transport_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            String Query = "insert into transport (transport_number,transport_capacity,transport_catagory,transport_condition,transport_rent_per_hour,transport_holdage_per_hour) values ('" + this.TransportNumberTextBox.Text + "', '" + this.CapacityTextBox.Text + "','" + this.TypeComboBox.Text + "','" + this.ConditionComboBox.Text + "','" + this.RentTextBox.Text + "','" + this.HoldageTextBox.Text + "');";
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

        private void TransportNumberTextBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Transport_Form_Load(object sender, EventArgs e)
        {
            this.BackColor=System.Drawing.ColorTranslator.FromHtml("#778899");
        }

        private void viewTransportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTransport obj = new ViewTransport();
            obj.Show();
            Visible = false; 
        }

        private void addTransportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transport_Form obj = new Transport_Form();
            obj.Show();
            Visible = false;
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher_Form obj = new Teacher_Form();
            obj.Show();
            Visible = false;
        }

        private void vewTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTeacher obj = new ViewTeacher();
            obj.Show();
            Visible = false;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            Visible = false;
        }

        private void viewEmployeeLIstToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ViewemployeeForm obj = new ViewemployeeForm();
            obj.Show();
            Visible = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransportEmployee obj = new TransportEmployee();
            obj.Show();
            Visible = false;
        }

        private void HoldageTextBox_TextChanged(object sender, EventArgs e)
        {

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
            ViewUsageEquipment o = new ViewUsageEquipment();
            o.Show();
            Visible = false;
        }

        private void storedEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStorageEquipmentForm o = new ViewStorageEquipmentForm();
            o.Show();
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

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
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

            this.label3.BackColor = Color.CadetBlue;
            this.label6.BackColor = Color.CadetBlue;

            this.label2.BackColor = Color.CadetBlue;
            this.label5.BackColor = Color.CadetBlue;
            this.label7.BackColor = Color.CadetBlue;
            this.label8.BackColor = Color.CadetBlue;
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

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewemployeeForm o = new ViewemployeeForm();
            o.Show();
            Visible = false;
        }

        }
    }


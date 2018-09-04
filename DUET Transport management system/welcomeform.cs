using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DUET_Transport_management_system
{
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();
        }

        

        private void welcomeForm_Load(object sender, EventArgs e)
        {
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            
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
            this.label1.BackColor = Color.CadetBlue;
            this.label2.BackColor = Color.CadetBlue;
            this.label1.ForeColor = Color.DarkGreen;
            this.label2.ForeColor = Color.Black;
            
        }

        private void teacherToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            Teacher_Form o = new Teacher_Form();
            o.Show();
            this.Hide();
        }

        private void employeeToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            TransportEmployee obj = new TransportEmployee();
            obj.Show();
            Visible = false;
        }

        private void transportToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Transport_Form o = new Transport_Form();
            o.Show();
            this.Hide();
        }

        private void requisitionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Requisition_Form o = new Requisition_Form();
            o.Show();
            this.Hide();
        }

        private void userToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UserForm o = new UserForm();
            o.Show();
            this.Hide();
        }

        private void personalCarUseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Personal_Car_Use_Form o = new Personal_Car_Use_Form();
            o.Show();
            this.Hide();
        }

        private void equipmentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Usage_Equipment o = new Usage_Equipment();
            o.Show();
            this.Hide();
        }

        private void transportScheduleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void purchaseEquipmentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Purchase_equipment o = new Purchase_equipment();
            o.Show();
            this.Hide();
        }

        private void transportListToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ViewTransport o = new ViewTransport();
            o.Show();
            this.Hide();
        }

        private void teacherToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ViewTeacher o = new ViewTeacher();
            o.Show();
            this.Hide();
        }

        private void employeeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ViewemployeeForm o = new ViewemployeeForm();
            o.Show();
            this.Hide();
        }

        private void requisitionListToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            viewrequisition o = new viewrequisition();
            o.Show();
            this.Hide();
        }

        private void personalCarUseListToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            viewpersonalcaruse o = new viewpersonalcaruse();
            o.Show();
            this.Hide();
        }

        private void usageEquipmentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ViewUsageEquipment o = new ViewUsageEquipment();
            o.Show();
            this.Hide();
        }

        private void storedEquipmentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ViewStorageEquipmentForm o = new ViewStorageEquipmentForm();
            o.Show();
            this.Hide();
        }

        private void purchaseEquipmentToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ViewPurchasesEquipmentForm obj = new ViewPurchasesEquipmentForm();
            obj.Show();
            Visible = false;
        }

        private void userToolStripMenuItem1_Click_1(object sender, EventArgs e)
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login o = new Login();
            o.Show();
            Visible = false;
        }

       

        

       

       

       

      


      

              
    }
}

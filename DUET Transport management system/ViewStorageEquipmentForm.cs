﻿using System;
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
    public partial class ViewStorageEquipmentForm : Form
    {
        public ViewStorageEquipmentForm()
        {
            InitializeComponent();
        }

        private void ViewStorageEquipmentForm_Load(object sender, EventArgs e)
        {
            SqlConnection cnn;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select * from stored_equipment;", cnn);
            //cnn.Open();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                ViewStorageEquipmentGrid.DataSource = bsource;
                sda.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void personalCarUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal_Car_Use_Form o = new Personal_Car_Use_Form();
            o.Show();
            this.Hide();
        }

        private void purchaseEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_equipment o = new Purchase_equipment();
            o.Show();
            this.Hide();
        }

        private void usageEquipmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Usage_Equipment o = new Usage_Equipment();
            o.Show();
            this.Hide();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm o = new UserForm();
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

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void purchaseEquipmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewPurchasesEquipmentForm obj = new ViewPurchasesEquipmentForm();
            obj.Show();
            Visible = false;
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login o = new Login();
            o.Show();
            Visible = false;
        }

    }
}

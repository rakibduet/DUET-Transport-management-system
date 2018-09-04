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
    public partial class EditPurchaseEquipmentForm : Form
    {
        int qtity = 0;
        public EditPurchaseEquipmentForm()
        {
            InitializeComponent();
            Fillcombo();

        }

        void Fillcombo()
        {
            // dateTimePicker2.CustomFormat = "hh:mm";

            SqlConnection cnn;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");

            SqlCommand cmd = new SqlCommand("select purchase_number from purchase_equipments;", cnn);
            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader[0].ToString();
                // MessageBox.Show(name);
                comboBox1.Items.Add(name);

            }
            reader.Close();


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void submit_Click(object sender, EventArgs e)
        {
            /* SqlConnection cnn;




             cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");

             string query = "update teacher set equipment_id='" + IdComboBox.Text + "',equipment_name='" + NameTextBox.Text + "',quantity='" + QuantityTextBox.Text + "',price_per_pcs='" +PriceTextBox.Text + "',contact_number='" + ContactTextBox.Text + "' where teacher_id='" + this.TeacherIdComboBox.Text + "';";
             cnn.Open();
             SqlCommand cmd = new SqlCommand(query, cnn);
             SqlDataReader reader = cmd.ExecuteReader();
             reader.Close();
             MessageBox.Show("updated");*/
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            welcomeForm obj = new welcomeForm();
            obj.Show();
            Visible = false;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            Visible = false;
        }




        

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem32_Click(object sender, EventArgs e)
        {
            welcomeForm obj = new welcomeForm();
            obj.Show();
            Visible = false;
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            EditPurchaseEquipmentForm obj = new EditPurchaseEquipmentForm();
            obj.Show();
            Visible = false;
        }

        private void toolStripMenuItem29_Click(object sender, EventArgs e)
        {
            EditUsagesEquipmentForm obj = new EditUsagesEquipmentForm();
            obj.Show();
            Visible = false;
        }

       

        private void UPDATE_Click(object sender, EventArgs e)
        {
            string ename = textBox2.Text;
            string quantity = textBox1.Text;
            string price = textBox3.Text;
            string date = dateTimePicker1.Text;
            string eid = IdTextBox.Text;
            int total_taka = Int32.Parse(price) * Int32.Parse(quantity);
            SqlConnection cnn;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select quantity from purchase_equipments where equipment_id='" + this.IdTextBox.Text + "'order by purchase_number;", cnn);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                qtity = Int32.Parse(reader[0].ToString());
            }
            MessageBox.Show(qtity.ToString());
            reader.Close();



            cmd = new SqlCommand("select equipment_name,stored_quantity from stored_equipment where equipment_id='" + this.IdTextBox.Text + "';", cnn);

            SqlDataReader reader1 = cmd.ExecuteReader();
            reader1.Read();

            string sename = reader1[0].ToString();
            int squantity = Int32.Parse(reader1[1].ToString());
            squantity = squantity - qtity + Int32.Parse(quantity);
            //MessageBox.Show(qtity.ToString());
            reader1.Close();



            string query = "update stored_equipment set equipment_name='" + ename + "',stored_quantity='" + squantity + "';";

            cmd = new SqlCommand(query, cnn);
            SqlDataReader reader2 = cmd.ExecuteReader();
            reader2.Close();
            query = "update purchase_equipments set equipment_id='" + eid + "',equipment_name='" + ename + "',quantity='" + quantity + "',price_per_pcs='" + price + "',total_taka='" + total_taka + "',date='" + date + "'where purchase_number='" + comboBox1.Text + "';";

            cmd = new SqlCommand(query, cnn);
            SqlDataReader reader3 = cmd.ExecuteReader();
            reader3.Close();
            MessageBox.Show("updated");

        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String name = IdTextBox.Text;
            SqlConnection cnn;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select equipment_name,quantity,price_per_pcs,date,equipment_id from purchase_equipments where purchase_number='" + this.comboBox1.Text + "';", cnn);
            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string result = reader[0].ToString();
            string result1 = reader[1].ToString();
            string result2 = reader[2].ToString();
            string result3 = reader[3].ToString();
            string result4 = reader[4].ToString();
            textBox2.Text = result;
            textBox1.Text = result1;
            textBox3.Text = result2;
            dateTimePicker1.Text = result3;
            IdTextBox.Text = result4;
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            panel2.Location = new Point(
           this.ClientSize.Width / 2 - panel2.Size.Width / 2,
             this.ClientSize.Height / 2 - panel2.Size.Height / 2);
            panel2.Anchor = AnchorStyles.None;
            //this.BackColor = System.Drawing.ColorTranslator.FromHtml("#778899");
            this.BackColor = Color.CadetBlue;
            menuStrip1.BackColor = Color.CadetBlue;
            this.label11.BackColor = Color.CadetBlue;

            this.label2.BackColor = Color.CadetBlue;
            this.label3.BackColor = Color.CadetBlue;
            this.label7.BackColor = Color.CadetBlue;
            this.label5.BackColor = Color.CadetBlue;
            this.label6.BackColor = Color.CadetBlue;
            this.label4.BackColor = Color.CadetBlue;
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

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Login o = new Login();
            o.Show();
            Visible = false;

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            string ename = textBox2.Text;
            string quantity = textBox1.Text;
            string price = textBox3.Text;
            string date = dateTimePicker1.Text;
            string eid = IdTextBox.Text;
            int total_taka = Int32.Parse(price) * Int32.Parse(quantity);
            SqlConnection cnn;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
           


           SqlCommand cmd = new SqlCommand("select equipment_name,stored_quantity from stored_equipment where equipment_id='" + this.IdTextBox.Text + "';", cnn);
           cnn.Open();
            SqlDataReader reader1 = cmd.ExecuteReader();
            reader1.Read();

            string sename = reader1[0].ToString();
            int squantity = Int32.Parse(reader1[1].ToString());
            squantity = squantity - Int32.Parse(quantity);
            //MessageBox.Show(qtity.ToString());
            reader1.Close();



            string query = "update stored_equipment set equipment_name='" + ename + "',stored_quantity='" + squantity + "';";

            cmd = new SqlCommand(query, cnn);
            SqlDataReader reader2 = cmd.ExecuteReader();
            reader2.Close();
            query = "delete from purchase_equipments where purchase_number='" + this.comboBox1.Text + "'";
            cmd = new SqlCommand(query, cnn);
            SqlDataReader reader3 = cmd.ExecuteReader();
            reader3.Close();
            MessageBox.Show("Deleted");
        }












    }   
    }


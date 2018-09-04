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
    public partial class Usage_Equipment : Form
    {
        public Usage_Equipment()
        {
            InitializeComponent();
            Fillcombo();
        }

        void Fillcombo()
        {
          
         
            SqlConnection cnn;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");

            SqlCommand cmd = new SqlCommand("select equipment_id from stored_equipment ORDER BY equipment_id;", cnn);
            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader[0].ToString();
                IdComboBox.Items.Add(name);

            }
            reader.Close();
            

        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
              String name= IdComboBox.Text;
            SqlConnection cnn;
            
            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select equipment_name from stored_equipment where equipment_id='" + this.IdComboBox.Text + "';", cnn);
            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
               reader.Read();
                string result = reader[0].ToString();
               
                NameTextBox.Text = result;
                
           

        }

        



        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select transport_number from transport where transport_catagory='" + this.CategoryComboBox.Text + "';", cnn);
            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            this.NumberComboBox.Items.Clear();
            while (reader.Read())
            {
                string name = reader[0].ToString();
                //MessageBox.Show(name);
                NumberComboBox.Items.Add(name);

            }

            reader.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Location = new Point(
         this.ClientSize.Width / 2 - panel1.Size.Width / 2,
           this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
            //this.BackColor = System.Drawing.ColorTranslator.FromHtml("#778899");
            this.BackColor = Color.CadetBlue;
            this.label13.BackColor = Color.CadetBlue;
            menuStrip1.BackColor = Color.CadetBlue;
            this.label2.BackColor = Color.CadetBlue;
            this.label3.BackColor = Color.CadetBlue;
            this.label6.BackColor = Color.CadetBlue;
            this.label8.BackColor = Color.CadetBlue;
            this.label7.BackColor = Color.CadetBlue;
            this.label5.BackColor = Color.CadetBlue;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            
            
            int quantity = Int32.Parse(QuantityTextBox.Text);
            
            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd1 = new SqlCommand("select stored_quantity from stored_equipment where equipment_id='" + this.IdComboBox.Text + "';", cnn);
            cnn.Open();

            SqlDataReader reader = cmd1.ExecuteReader();
            reader.Read();
                int qtity = Int32.Parse(reader[0].ToString());
                quantity =qtity-quantity;
                 reader.Close();

                string query = "update stored_equipment set stored_quantity='" + quantity+"' where equipment_id='"+this.IdComboBox.Text+"';";
                cmd1 = new SqlCommand(query, cnn);
                SqlDataReader reader2 = cmd1.ExecuteReader();
                reader2.Close();
                //MessageBox.Show("updated");
            
         

            String Query = "insert into usage_equipment (equipment_id,equipment_name,equipment_quantity,transport_category,transport_number,date) values ('" + this.IdComboBox.Text + "','" + this.NameTextBox.Text + "', '" + this.QuantityTextBox.Text + "','" + this.CategoryComboBox.Text + "','" + this.NumberComboBox.Text+ "','" + this.DateTimePicker.Text + "');";
            SqlCommand cmd = new SqlCommand(Query, cnn);
             SqlDataReader reader1 = cmd.ExecuteReader();
             MessageBox.Show("saved");
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

        private void storedEquipmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Purchase_equipment o = new Purchase_equipment();
            o.Show();
            this.Hide();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void purchaseEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
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

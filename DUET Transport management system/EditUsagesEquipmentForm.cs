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
    public partial class EditUsagesEquipmentForm : Form
    {
        int qtity = 0;
        public EditUsagesEquipmentForm()
        {
            InitializeComponent();
            Fillcombo();
        }
        void Fillcombo()
        {
            // dateTimePicker2.CustomFormat = "hh:mm";

            SqlConnection cnn;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");

            SqlCommand cmd = new SqlCommand("select usage_number from usage_equipment ;", cnn);
            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader[0].ToString();
                //MessageBox.Show(name);
                UseNumberComboBox.Items.Add(name);

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
            menuStrip1.BackColor = Color.CadetBlue;
            this.label13.BackColor = Color.CadetBlue;

            this.label2.BackColor = Color.CadetBlue;
            this.label3.BackColor = Color.CadetBlue;
            this.label7.BackColor = Color.CadetBlue;
            this.label5.BackColor = Color.CadetBlue;
            this.label6.BackColor = Color.CadetBlue;

            this.label8.BackColor = Color.CadetBlue;
            this.label9.BackColor = Color.CadetBlue;
           // this.label7.BackColor = Color.CadetBlue;
            //this.label5.BackColor = Color.CadetBlue;
            //this.label6.BackColor = Color.CadetBlue;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            Visible = false;
        }

        private void IdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UseNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlConnection cnn;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");

            SqlCommand cmd = new SqlCommand("select transport_number,transport_catagory from transport;", cnn);
            cnn.Open();

            SqlDataReader reader1 = cmd.ExecuteReader();
            while (reader1.Read())
            {
                string name = reader1[0].ToString();
                string name1 = reader1[1].ToString();
                NumberComboBox.Items.Add(name);
                CategoryComboBox.Items.Add(name1);

            }
            reader1.Close();

            SqlCommand cmd2 = new SqlCommand("select equipment_id from usage_equipment ;", cnn);

            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                string name = reader2[0].ToString();
                IdComboBox.Items.Add(name);

            }
            reader2.Close();

            SqlCommand cmd1 = new SqlCommand("select equipment_id,equipment_name,equipment_quantity,transport_category,transport_number,date from usage_equipment where usage_number='" + this.UseNumberComboBox.Text + "';", cnn);
            

            SqlDataReader reader = cmd1.ExecuteReader();
            reader.Read();
            string result = reader[0].ToString();
            string result1 = reader[1].ToString();
            string result2 = reader[2].ToString();
            string result3 = reader[3].ToString();
            string result4 = reader[4].ToString();
            string result5 = reader[5].ToString();
            IdComboBox.Text = result;
            NameTextBox.Text = result1;
            QuantityTextBox.Text = result2;
            CategoryComboBox.Text = result3;
            NumberComboBox.Text = result4;
            DateTimePicker.Text = result5;

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        { 
            string ename = NameTextBox.Text;
            string quantity = QuantityTextBox.Text;
            string Tcategory = CategoryComboBox.Text;
            string tnumber = NumberComboBox.Text;
            string eid = IdComboBox.Text;
            string date = DateTimePicker.Text;
           
            SqlConnection cnn;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select equipment_quantity from usage_equipment where equipment_id='" + this.IdComboBox.Text + "'order by usage_number ;", cnn);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                qtity = Int32.Parse(reader[0].ToString());
            }
            MessageBox.Show(qtity.ToString());
            reader.Close();



            cmd = new SqlCommand("select equipment_name,stored_quantity from stored_equipment where equipment_id='" + this.IdComboBox.Text + "';", cnn);

            SqlDataReader reader1 = cmd.ExecuteReader();
            reader1.Read();

            string sename = reader1[0].ToString();
            int squantity = Int32.Parse(reader1[1].ToString());
            squantity = squantity +qtity - Int32.Parse(quantity);
            //MessageBox.Show(qtity.ToString());
            reader1.Close();



            string query = "update stored_equipment set equipment_name='" + ename + "',stored_quantity='" + squantity + "';";

            cmd = new SqlCommand(query, cnn);
            SqlDataReader reader2 = cmd.ExecuteReader();
            reader2.Close();
            query = "update usage_equipment set equipment_id='" + eid + "',equipment_name='" + ename + "',equipment_quantity='" + quantity + "',transport_category='" + Tcategory + "',transport_number='" + tnumber + "',date='" + date + "'where usage_number='" + UseNumberComboBox.Text + "';";

            cmd = new SqlCommand(query, cnn);
            SqlDataReader reader3 = cmd.ExecuteReader();
            reader3.Close();
            MessageBox.Show("updated");

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

        private void personalCarUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal_Car_Use_Form obj = new Personal_Car_Use_Form();
            obj.Show();
            Visible = false;
        }

        private void storedEquipmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Purchase_equipment o = new Purchase_equipment();
            o.Show();
            Visible = false;
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usage_Equipment o = new Usage_Equipment();
            o.Show();
            Visible = false;
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm o = new UserForm();
            o.Show();
            Visible = false;
        }

        private void transportListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTransport obj = new ViewTransport();
            obj.Show();
            Visible = false;
        }

        private void teacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewTeacher obj = new ViewTeacher();
            obj.Show();
            Visible = false;
        }

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewemployeeForm o = new ViewemployeeForm();
            o.Show();
            Visible = false;
        }

        private void requisitionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewrequisition obj = new viewrequisition();
            obj.Show();
            Visible = false;
        }

        private void personalCarUseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewpersonalcaruse o = new viewpersonalcaruse();
            o.Show();
            Visible = false;
        }

        private void purchaseEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPurchasesEquipmentForm o = new ViewPurchasesEquipmentForm();
            o.Show();
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
            ViewStorageEquipmentForm o = new ViewStorageEquipmentForm();
            o.Show();
            Visible = false;
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowUser obj = new ShowUser();
            obj.Show();
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

        private void storedEquipmentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditPurchaseEquipmentForm o = new EditPurchaseEquipmentForm();
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

        private void Deletebutton_Click(object sender, EventArgs e)
        {
           /* SqlConnection cnn;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");



            SqlCommand cmd = new SqlCommand("select equipment_name,stored_quantity from stored_equipment where equipment_id='" + this.IdComboBox.Text + "';", cnn);
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
            MessageBox.Show("Deleted");*/
        }

      
    }
}

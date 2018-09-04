using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace DUET_Transport_management_system
{
    public partial class viewpersonalcaruse : Form
    {string tid;
    int value = 0;
        public viewpersonalcaruse()
        {
            InitializeComponent();
            Fillcombo();
        }
        void Fillcombo()
        {
            // dateTimePicker2.CustomFormat = "hh:mm";
            //dateTimePicker.Value = DateTime.Today;
            //dateTimePicker2.Value = DateTime.Now;
            //timepicker3.Value = DateTime.Now;
            SqlConnection cnn;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");

            SqlCommand cmd = new SqlCommand("select teacher_id from teacher ORDER BY teacher_id;", cnn);
            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader[0].ToString();
                TeacherIdComboBox.Items.Add(name);

            }
           
        }
        private void viewpersonalcaruse_Load(object sender, EventArgs e)
        {
            SqlConnection cnn;
            DateTime d2 = DateTime.Today;
            DateTime d1 = d2.AddMonths(-1);


            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select * from per_car_use where return_date>='" + d1 + "'and return_date<='" + d2 + "';", cnn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                CarUseGridView.DataSource = bsource;
                sda.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

           
            
        }

        private void CreatePdf_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(CarUseGridView.ColumnCount);
            PdfPCell cell = new PdfPCell(new Phrase(" Personal Car Use List", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 25f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE)));
            cell.BackgroundColor = new BaseColor(0, 150, 0);
            cell.Colspan = CarUseGridView.ColumnCount;
            cell.HorizontalAlignment = 1;
            pdfTable.AddCell(cell);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;


            for (int j = 0; j < CarUseGridView.Columns.Count; j++)
            {
                pdfTable.AddCell(new Phrase(CarUseGridView.Columns[j].HeaderText));
            }
            pdfTable.HeaderRows = 2;

            for (int i = 0; i < CarUseGridView.Rows.Count; i++)
            {
                for (int k = 0; k < CarUseGridView.Columns.Count; k++)
                {
                    if (CarUseGridView[k, i].Value != null)
                        pdfTable.AddCell(new Phrase(CarUseGridView[k, i].Value.ToString()));
                }
            }
             pdfTable = new PdfPTable(CarUseGridView.ColumnCount);
             cell = new PdfPCell(new Phrase(" Personal Car Use List", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 25f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE)));
             cell.BackgroundColor = new BaseColor(0, 150, 0);
             cell.Colspan = CarUseGridView.ColumnCount;
             cell.HorizontalAlignment = 1;
             pdfTable.AddCell(cell);
             pdfTable.DefaultCell.Padding = 3;
             pdfTable.WidthPercentage = 100;
             pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
             pdfTable.DefaultCell.BorderWidth = 1;

            string folderPath = "C:\\DTMS\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Personal Car Use.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }


            MessageBox.Show("PDF Created!");
        }

        private void ViewRequisitionGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            UserForm obj = new UserForm();
            obj.Show();
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
            Usage_Equipment obj = new Usage_Equipment();
            obj.Show();
            Visible = false;
        }

        private void storedEquipmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Purchase_equipment obj = new Purchase_equipment();
            obj.Show();
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

        private void purchaseEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPurchasesEquipmentForm obj = new ViewPurchasesEquipmentForm();
            obj.Show();
            Visible = false;
        }

        private void teacherInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTeacherForm obj = new EditTeacherForm();
            obj.Show();
            Visible = false;
        }

        private void employeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditEmployeeForm obj = new EditEmployeeForm();
            obj.Show();
            Visible = false;
        }

        private void transportInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTransportForm obj = new EditTransportForm();
            obj.Show();
            Visible = false;
        }

        private void requisitionInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRequisitionForm obj = new EditRequisitionForm();
            obj.Show();
            Visible = false;
        }

        private void carUseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPersonalCarUseForm obj = new EditPersonalCarUseForm();
            obj.Show();
            Visible = false;
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUserForm obj = new EditUserForm();
            obj.Show();
            Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TeacherIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            
            PdfPTable pdfTable = new PdfPTable(CarUseGridView.ColumnCount);
            PdfPCell cell = new PdfPCell(new Phrase(" Personal Car Use List OF Teacher ID '"+tid+"'", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 25f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE)));
            cell.BackgroundColor = new BaseColor(0, 150, 0);
            cell.Colspan = CarUseGridView.ColumnCount;
            cell.HorizontalAlignment = 1;
            pdfTable.AddCell(cell);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;

            
            for (int j = 0; j < CarUseGridView.Columns.Count; j++)
            {
                pdfTable.AddCell(new Phrase(CarUseGridView.Columns[j].HeaderText));
            }
            pdfTable.HeaderRows = 2;

            for (int i = 0; i < CarUseGridView.Rows.Count; i++)
            {
                for (int k = 0; k < CarUseGridView.Columns.Count; k++)
                {
                    if (CarUseGridView[k, i].Value != null)
                        pdfTable.AddCell(new Phrase(CarUseGridView[k, i].Value.ToString()));
                }

            }

            PdfPTable pdfTable1 = new PdfPTable(1);
            PdfPCell cell1 = new PdfPCell(new Phrase(" Total Taka=  '" + value + "' BDT", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 25f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
            cell1.BackgroundColor = new BaseColor(Color.White);
          
            cell1.Colspan = 1;
            cell1.HorizontalAlignment = 1;
            pdfTable1.AddCell(cell1);
            pdfTable1.DefaultCell.Padding = 3;
            pdfTable1.WidthPercentage = 100;
            pdfTable1.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable1.DefaultCell.BorderWidth = 1;
            string folderPath = "C:\\DTMS\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Personal Car Use'"+tid+"'.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Add(pdfTable1);
                pdfDoc.Close();
                stream.Close();
            }


            MessageBox.Show("PDF Created!");
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
            this.label6.BackColor = Color.CadetBlue;
            this.label1.BackColor = Color.CadetBlue;
            this.label2.BackColor = Color.CadetBlue;
            this.label7.BackColor = Color.CadetBlue;
            this.label5.BackColor = Color.CadetBlue;
            
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

        private void personalCarUseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Personal_Car_Use_Form o = new Personal_Car_Use_Form();
            o.Show();
            this.Hide();
        }

        private void storedEquipmentToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Purchase_equipment o = new Purchase_equipment();
            o.Show();
            this.Hide();
        }

        private void equipmentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Usage_Equipment o = new Usage_Equipment();
            o.Show();
            this.Hide();
        }

        private void userToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UserForm o = new UserForm();
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

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void purchaseEquipmentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ViewPurchasesEquipmentForm obj = new ViewPurchasesEquipmentForm();
            obj.Show();
            Visible = false;
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

        private void userToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ShowUser o = new ShowUser();
            o.Show();
            this.Hide();
        }

        private void teacherInfoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditTeacherForm o = new EditTeacherForm();
            o.Show();
            Visible = false;
        }

        private void employeeInfoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditEmployeeForm o = new EditEmployeeForm();
            o.Show();
            Visible = false;
        }

        private void transportInfoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditTransportForm o = new EditTransportForm();
            o.Show();
            Visible = false;
        }

        private void requisitionInfoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditRequisitionForm o = new EditRequisitionForm();
            o.Show();
            Visible = false;
        }

        private void carUseInfoToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void userInfoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditUserForm o = new EditUserForm();
            o.Show();
            Visible = false;
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Login o = new Login();
            o.Show();
            Visible = false;
        }

        private void CarUseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            DateTime d1 = dateTimePicker4.Value;
            DateTime d2 = dateTimePicker3.Value;
            tid = TeacherIdComboBox.Text;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select * from per_car_use where teacher_id='" + tid + "'and return_date>='" + d1 + "'and return_date<='" + d2 + "';", cnn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                CarUseGridView.DataSource = bsource;
                sda.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //SqlConnection cnn;

            //cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            cmd = new SqlCommand("select total_taka from per_car_use where teacher_id='" + tid + "'and return_date>='" + d1 + "'and return_date<='" + d2 + "';", cnn);
            cnn.Open();
            value = 0;
            SqlDataReader reader1 = cmd.ExecuteReader();
            while (reader1.Read())
            {
                value = value + Int32.Parse(reader1[0].ToString());
            }
            reader1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            DateTime d1 = dateTimePicker1.Value;
            DateTime d2 = dateTimePicker2.Value;

            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select * from per_car_use where return_date>='" + d1 + "'and return_date<='" + d2 + "';", cnn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                CarUseGridView.DataSource = bsource;
                sda.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        }
        }

        
      
    


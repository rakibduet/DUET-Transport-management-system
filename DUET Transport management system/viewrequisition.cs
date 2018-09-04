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
    public partial class viewrequisition : Form
    {
        public viewrequisition()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewrequisition_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.Value = DateTime.Today; dateTimePicker2.Value = DateTime.Today;
            DateTime d1 = DateTime.Today;
            d1 = d1.AddMonths(-1);
            dateTimePicker1.Value = d1;
           
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

        private void teacherToolStripMenuItem2_Click_1(object sender, EventArgs e)
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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d1 = dateTimePicker1.Value;
            DateTime d2 = dateTimePicker2.Value;



            SqlConnection cnn;
            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select * from requisition where date>='" + d1 + "'and date<='" + d2 + "' ;", cnn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                ViewRequisitionGridView.DataSource = bsource;
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
            PdfPTable pdfTable = new PdfPTable(ViewRequisitionGridView.ColumnCount);
            PdfPCell cell = new PdfPCell(new Phrase(" Requisition list", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 25f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE)));
            cell.BackgroundColor = new BaseColor(0, 150, 0);
            cell.Colspan = ViewRequisitionGridView.ColumnCount;
            cell.HorizontalAlignment = 1;
            pdfTable.AddCell(cell);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;


            for (int j = 0; j < ViewRequisitionGridView.Columns.Count; j++)
            {
                pdfTable.AddCell(new Phrase(ViewRequisitionGridView.Columns[j].HeaderText));
            }
            pdfTable.HeaderRows = 2;

            for (int i = 0; i < ViewRequisitionGridView.Rows.Count; i++)
            {
                for (int k = 0; k < ViewRequisitionGridView.Columns.Count; k++)
                {
                    if (ViewRequisitionGridView[k, i].Value != null)
                        pdfTable.AddCell(new Phrase(ViewRequisitionGridView[k, i].Value.ToString()));
                }
            }

            string folderPath = "C:\\DTMS\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Requisition list.pdf", FileMode.Create))
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

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;

using System.Reflection;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace DUET_Transport_management_system
{
    public partial class ViewTeacher : Form
    {
        public ViewTeacher()
        {
            InitializeComponent();
        }

        private void ViewTeacher_Load(object sender, EventArgs e)
        {
            SqlConnection cnn;
            cnn = new SqlConnection("Server=.\\SQLEXPRESS;Database=DTMS; Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select * from teacher;", cnn);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                ViewTeacherGrid1.DataSource = bsource;
                sda.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(ViewTeacherGrid1.ColumnCount);
            PdfPCell cell = new PdfPCell(new Phrase(" TEACHER LIST", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 25f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE)));
            cell.BackgroundColor = new BaseColor(0, 150, 0);
            cell.Colspan = 5;
            cell.HorizontalAlignment = 1;//0 left 1 center 2 right;
            pdfTable.AddCell(cell);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 75;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
           /* foreach (DataGridViewColumn column in ViewTeacherGrid1.Columns)
            {
               PdfPCell cell1 = new PdfPCell(new Phrase(column.HeaderText));
                cell1.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell1);
            */
            for (int j = 0; j < ViewTeacherGrid1.Columns.Count; j++)
            {
                pdfTable.AddCell(new Phrase(ViewTeacherGrid1.Columns[j].HeaderText));
            }
            pdfTable.HeaderRows = 2;
            //Adding DataRow
            /*
             * foreach (DataGridViewRow row in ViewTeacherGrid1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }*/

            for (int i = 0; i < ViewTeacherGrid1.Rows.Count; i++)
            {
                for (int k = 0; k < ViewTeacherGrid1.Columns.Count; k++)
                {
                    if (ViewTeacherGrid1[k, i].Value != null)
                        pdfTable.AddCell(new Phrase(ViewTeacherGrid1[k, i].Value.ToString()));
                }
            }
            //Exporting to PDF
            string folderPath = "C:\\DTMS\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Teacher_list.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
           
           /*Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Text.pdf", FileMode.Create));
            doc.Open();
            /(*iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("mahbub.jpg");
           // PNG.ScalePercent(10f);
            PNG.ScaleToFit(250f, 250f);
            PNG.Border = iTextSharp.text.Rectangle.BOX;
            PNG.BorderColor = iTextSharp.text.BaseColor.YELLOW;
            PNG.BorderWidth = 25f;
           // PNG.SetAbsolutePosition(doc.PageSize.Width -45f-25f,doc.PageSize.Height-15f-25f);
            doc.Add(PNG);
             *(/
            
               Paragraph paragraghp=new Paragraph(" Dhaka University Of Engineering & Technology,Gazipur\n\n",new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL,15f,iTextSharp.text.Font.NORMAL,iTextSharp.text.BaseColor.RED));
               doc.Add(paragraghp);
              /* List list = new List(List.UNORDERED);
               list.IndentationLeft = 50f;
               list.Add(" one");
               list.Add(" two");
               list.Add("three\n\n");

               doc.Add(list);*(/
            PdfPTable table =new PdfPTable(ViewTeacherGrid1.Columns.Count);
            PdfPCell cell = new PdfPCell(new Phrase(" TEACHER LIST",new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL,25f,iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE)));
            cell.BackgroundColor = new BaseColor(0, 150, 0);
            cell.Colspan = 5;
            cell.HorizontalAlignment = 1;//0 left 1 center 2 right;
            table.AddCell(cell);
            for(int j=0;j<ViewTeacherGrid1.Columns.Count;j++)
            {
                table.AddCell(new Phrase(ViewTeacherGrid1.Columns[j].HeaderText));
            }
            table.HeaderRows=1;
            for(int i=0;i<ViewTeacherGrid1.Rows.Count;i++)
            {
                for(int k=0;k<ViewTeacherGrid1.Columns.Count;k++)
                {
                    if(ViewTeacherGrid1[k,i].Value!=null)
                        table.AddCell(new Phrase(ViewTeacherGrid1[k,i].Value.ToString()));
                }
            }
            doc.Add(table);
            doc.Close();
            */
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

        private void userInfoToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void logoutToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Login o = new Login();
            o.Show();
            Visible = false;
        }
    }
}

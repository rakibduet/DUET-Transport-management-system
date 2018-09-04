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
    public partial class Transport_Employee_Form : Form
    {
        public Transport_Employee_Form()
        {
            InitializeComponent();
        }

        private void removeEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Requisition_Form ad = new Requisition_Form();
            ad.Show();
            Visible = false;
          
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}

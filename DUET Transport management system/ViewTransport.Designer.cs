﻿namespace DUET_Transport_management_system
{
    partial class ViewTransport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.ViewTransportGrid1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.requisitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalCarUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usageEquipmentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requisitionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalCarUseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseEquipmentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usageEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storedEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requisitionInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carUseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storedEquipmentToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.userInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtmsDataSet1 = new DUET_Transport_management_system.DTMSDataSet();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtmsDataSet2 = new DUET_Transport_management_system.DTMSDataSet();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewTransportGrid1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmsDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.ViewTransportGrid1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 497);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(6, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(812, 56);
            this.label13.TabIndex = 64;
            this.label13.Text = "VIEW TRANSPORT INFORMATION";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewTransportGrid1
            // 
            this.ViewTransportGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewTransportGrid1.Location = new System.Drawing.Point(3, 83);
            this.ViewTransportGrid1.Name = "ViewTransportGrid1";
            this.ViewTransportGrid1.Size = new System.Drawing.Size(815, 411);
            this.ViewTransportGrid1.TabIndex = 32;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addInformationToolStripMenuItem,
            this.viewInformationToolStripMenuItem,
            this.editInformationToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 28);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addInformationToolStripMenuItem
            // 
            this.addInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherToolStripMenuItem2,
            this.employeeToolStripMenuItem1,
            this.transportToolStripMenuItem1,
            this.requisitionToolStripMenuItem,
            this.userToolStripMenuItem,
            this.personalCarUseToolStripMenuItem,
            this.purchaseEquipmentToolStripMenuItem,
            this.usageEquipmentToolStripMenuItem1});
            this.addInformationToolStripMenuItem.Name = "addInformationToolStripMenuItem";
            this.addInformationToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.addInformationToolStripMenuItem.Text = "Add Information";
            // 
            // teacherToolStripMenuItem2
            // 
            this.teacherToolStripMenuItem2.Name = "teacherToolStripMenuItem2";
            this.teacherToolStripMenuItem2.Size = new System.Drawing.Size(212, 24);
            this.teacherToolStripMenuItem2.Text = "Teacher";
            this.teacherToolStripMenuItem2.Click += new System.EventHandler(this.teacherToolStripMenuItem2_Click_1);
            // 
            // employeeToolStripMenuItem1
            // 
            this.employeeToolStripMenuItem1.Name = "employeeToolStripMenuItem1";
            this.employeeToolStripMenuItem1.Size = new System.Drawing.Size(212, 24);
            this.employeeToolStripMenuItem1.Text = "Employee";
            this.employeeToolStripMenuItem1.Click += new System.EventHandler(this.employeeToolStripMenuItem1_Click_1);
            // 
            // transportToolStripMenuItem1
            // 
            this.transportToolStripMenuItem1.Name = "transportToolStripMenuItem1";
            this.transportToolStripMenuItem1.Size = new System.Drawing.Size(212, 24);
            this.transportToolStripMenuItem1.Text = "Transport";
            this.transportToolStripMenuItem1.Click += new System.EventHandler(this.transportToolStripMenuItem1_Click_1);
            // 
            // requisitionToolStripMenuItem
            // 
            this.requisitionToolStripMenuItem.Name = "requisitionToolStripMenuItem";
            this.requisitionToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.requisitionToolStripMenuItem.Text = "Requisition";
            this.requisitionToolStripMenuItem.Click += new System.EventHandler(this.requisitionToolStripMenuItem_Click_1);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click_1);
            // 
            // personalCarUseToolStripMenuItem
            // 
            this.personalCarUseToolStripMenuItem.Name = "personalCarUseToolStripMenuItem";
            this.personalCarUseToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.personalCarUseToolStripMenuItem.Text = "Personal Car Use";
            this.personalCarUseToolStripMenuItem.Click += new System.EventHandler(this.personalCarUseToolStripMenuItem_Click_1);
            // 
            // purchaseEquipmentToolStripMenuItem
            // 
            this.purchaseEquipmentToolStripMenuItem.Name = "purchaseEquipmentToolStripMenuItem";
            this.purchaseEquipmentToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.purchaseEquipmentToolStripMenuItem.Text = "Purchase Equipment";
            this.purchaseEquipmentToolStripMenuItem.Click += new System.EventHandler(this.purchaseEquipmentToolStripMenuItem_Click_1);
            // 
            // usageEquipmentToolStripMenuItem1
            // 
            this.usageEquipmentToolStripMenuItem1.Name = "usageEquipmentToolStripMenuItem1";
            this.usageEquipmentToolStripMenuItem1.Size = new System.Drawing.Size(212, 24);
            this.usageEquipmentToolStripMenuItem1.Text = "Usage Equipment";
            this.usageEquipmentToolStripMenuItem1.Click += new System.EventHandler(this.usageEquipmentToolStripMenuItem1_Click_1);
            // 
            // viewInformationToolStripMenuItem
            // 
            this.viewInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transportListToolStripMenuItem,
            this.teacherToolStripMenuItem1,
            this.employeeListToolStripMenuItem,
            this.requisitionListToolStripMenuItem,
            this.personalCarUseListToolStripMenuItem,
            this.purchaseEquipmentToolStripMenuItem1,
            this.usageEquipmentToolStripMenuItem,
            this.storedEquipmentToolStripMenuItem,
            this.userToolStripMenuItem1});
            this.viewInformationToolStripMenuItem.Name = "viewInformationToolStripMenuItem";
            this.viewInformationToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.viewInformationToolStripMenuItem.Text = "View Information";
            // 
            // transportListToolStripMenuItem
            // 
            this.transportListToolStripMenuItem.Name = "transportListToolStripMenuItem";
            this.transportListToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.transportListToolStripMenuItem.Text = "Transport List";
            this.transportListToolStripMenuItem.Click += new System.EventHandler(this.transportListToolStripMenuItem_Click_1);
            // 
            // teacherToolStripMenuItem1
            // 
            this.teacherToolStripMenuItem1.Name = "teacherToolStripMenuItem1";
            this.teacherToolStripMenuItem1.Size = new System.Drawing.Size(213, 24);
            this.teacherToolStripMenuItem1.Text = "Teacher List";
            this.teacherToolStripMenuItem1.Click += new System.EventHandler(this.teacherToolStripMenuItem1_Click_1);
            // 
            // employeeListToolStripMenuItem
            // 
            this.employeeListToolStripMenuItem.Name = "employeeListToolStripMenuItem";
            this.employeeListToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.employeeListToolStripMenuItem.Text = "Employee List";
            this.employeeListToolStripMenuItem.Click += new System.EventHandler(this.employeeListToolStripMenuItem_Click);
            // 
            // requisitionListToolStripMenuItem
            // 
            this.requisitionListToolStripMenuItem.Name = "requisitionListToolStripMenuItem";
            this.requisitionListToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.requisitionListToolStripMenuItem.Text = "Requisition List";
            this.requisitionListToolStripMenuItem.Click += new System.EventHandler(this.requisitionListToolStripMenuItem_Click_1);
            // 
            // personalCarUseListToolStripMenuItem
            // 
            this.personalCarUseListToolStripMenuItem.Name = "personalCarUseListToolStripMenuItem";
            this.personalCarUseListToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.personalCarUseListToolStripMenuItem.Text = "Personal Car Use List";
            this.personalCarUseListToolStripMenuItem.Click += new System.EventHandler(this.personalCarUseListToolStripMenuItem_Click_1);
            // 
            // purchaseEquipmentToolStripMenuItem1
            // 
            this.purchaseEquipmentToolStripMenuItem1.Name = "purchaseEquipmentToolStripMenuItem1";
            this.purchaseEquipmentToolStripMenuItem1.Size = new System.Drawing.Size(213, 24);
            this.purchaseEquipmentToolStripMenuItem1.Text = "Purchase Equipment";
            this.purchaseEquipmentToolStripMenuItem1.Click += new System.EventHandler(this.purchaseEquipmentToolStripMenuItem1_Click_1);
            // 
            // usageEquipmentToolStripMenuItem
            // 
            this.usageEquipmentToolStripMenuItem.Name = "usageEquipmentToolStripMenuItem";
            this.usageEquipmentToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.usageEquipmentToolStripMenuItem.Text = "Usage Equipment";
            this.usageEquipmentToolStripMenuItem.Click += new System.EventHandler(this.usageEquipmentToolStripMenuItem_Click_1);
            // 
            // storedEquipmentToolStripMenuItem
            // 
            this.storedEquipmentToolStripMenuItem.Name = "storedEquipmentToolStripMenuItem";
            this.storedEquipmentToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.storedEquipmentToolStripMenuItem.Text = "Stored Equipment";
            this.storedEquipmentToolStripMenuItem.Click += new System.EventHandler(this.storedEquipmentToolStripMenuItem_Click_1);
            // 
            // userToolStripMenuItem1
            // 
            this.userToolStripMenuItem1.Name = "userToolStripMenuItem1";
            this.userToolStripMenuItem1.Size = new System.Drawing.Size(213, 24);
            this.userToolStripMenuItem1.Text = "User";
            this.userToolStripMenuItem1.Click += new System.EventHandler(this.userToolStripMenuItem1_Click_1);
            // 
            // editInformationToolStripMenuItem
            // 
            this.editInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherInfoToolStripMenuItem,
            this.employeeInfoToolStripMenuItem,
            this.transportInfoToolStripMenuItem,
            this.requisitionInfoToolStripMenuItem,
            this.carUseInfoToolStripMenuItem,
            this.equipmentInfoToolStripMenuItem,
            this.storedEquipmentToolStripMenuItem2,
            this.userInfoToolStripMenuItem});
            this.editInformationToolStripMenuItem.Name = "editInformationToolStripMenuItem";
            this.editInformationToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.editInformationToolStripMenuItem.Text = "Edit Information";
            // 
            // teacherInfoToolStripMenuItem
            // 
            this.teacherInfoToolStripMenuItem.Name = "teacherInfoToolStripMenuItem";
            this.teacherInfoToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.teacherInfoToolStripMenuItem.Text = "Teacher Info";
            this.teacherInfoToolStripMenuItem.Click += new System.EventHandler(this.teacherInfoToolStripMenuItem_Click_1);
            // 
            // employeeInfoToolStripMenuItem
            // 
            this.employeeInfoToolStripMenuItem.Name = "employeeInfoToolStripMenuItem";
            this.employeeInfoToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.employeeInfoToolStripMenuItem.Text = "Employee Info";
            this.employeeInfoToolStripMenuItem.Click += new System.EventHandler(this.employeeInfoToolStripMenuItem_Click_1);
            // 
            // transportInfoToolStripMenuItem
            // 
            this.transportInfoToolStripMenuItem.Name = "transportInfoToolStripMenuItem";
            this.transportInfoToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.transportInfoToolStripMenuItem.Text = "Transport Info";
            this.transportInfoToolStripMenuItem.Click += new System.EventHandler(this.transportInfoToolStripMenuItem_Click_1);
            // 
            // requisitionInfoToolStripMenuItem
            // 
            this.requisitionInfoToolStripMenuItem.Name = "requisitionInfoToolStripMenuItem";
            this.requisitionInfoToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.requisitionInfoToolStripMenuItem.Text = "Requisition Info";
            this.requisitionInfoToolStripMenuItem.Click += new System.EventHandler(this.requisitionInfoToolStripMenuItem_Click_1);
            // 
            // carUseInfoToolStripMenuItem
            // 
            this.carUseInfoToolStripMenuItem.Name = "carUseInfoToolStripMenuItem";
            this.carUseInfoToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.carUseInfoToolStripMenuItem.Text = "Car Use Info";
            this.carUseInfoToolStripMenuItem.Click += new System.EventHandler(this.carUseInfoToolStripMenuItem_Click_1);
            // 
            // equipmentInfoToolStripMenuItem
            // 
            this.equipmentInfoToolStripMenuItem.Name = "equipmentInfoToolStripMenuItem";
            this.equipmentInfoToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.equipmentInfoToolStripMenuItem.Text = "Purchase Equipment Info";
            this.equipmentInfoToolStripMenuItem.Click += new System.EventHandler(this.equipmentInfoToolStripMenuItem_Click_1);
            // 
            // storedEquipmentToolStripMenuItem2
            // 
            this.storedEquipmentToolStripMenuItem2.Name = "storedEquipmentToolStripMenuItem2";
            this.storedEquipmentToolStripMenuItem2.Size = new System.Drawing.Size(242, 24);
            this.storedEquipmentToolStripMenuItem2.Text = "Usages Equipment Info";
            this.storedEquipmentToolStripMenuItem2.Click += new System.EventHandler(this.storedEquipmentToolStripMenuItem2_Click_1);
            // 
            // userInfoToolStripMenuItem
            // 
            this.userInfoToolStripMenuItem.Name = "userInfoToolStripMenuItem";
            this.userInfoToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.userInfoToolStripMenuItem.Text = "User Info";
            this.userInfoToolStripMenuItem.Click += new System.EventHandler(this.userInfoToolStripMenuItem_Click_1);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click_1);
            // 
            // dtmsDataSet1
            // 
            this.dtmsDataSet1.DataSetName = "DTMSDataSet";
            this.dtmsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtmsDataSet2
            // 
            this.dtmsDataSet2.DataSetName = "DTMSDataSet";
            this.dtmsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ViewTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 497);
            this.Controls.Add(this.panel1);
            this.Name = "ViewTransport";
            this.Text = "View Transport";
            this.Load += new System.EventHandler(this.ViewTransportGrid_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewTransportGrid1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmsDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem requisitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalCarUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usageEquipmentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalCarUseListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requisitionListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usageEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storedEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem purchaseEquipmentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requisitionInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carUseInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storedEquipmentToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private DTMSDataSet dtmsDataSet1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DTMSDataSet dtmsDataSet2;
        private System.Windows.Forms.DataGridView ViewTransportGrid1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem employeeListToolStripMenuItem;

    }
}
namespace DUET_Transport_management_system
{
    partial class ViewPurchasesEquipmentForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.requisitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalCarUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usageEquipmentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ViewPurchaseGrid = new System.Windows.Forms.DataGridView();
            this.CreatePdf = new System.Windows.Forms.Button();
            this.dtmsDataSet2 = new DUET_Transport_management_system.DTMSDataSet();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPurchaseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmsDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.ViewPurchaseGrid);
            this.panel1.Controls.Add(this.CreatePdf);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 583);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(0, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(822, 64);
            this.label13.TabIndex = 67;
            this.label13.Text = "VIEW PURCHASE EQUIPMENT INFORMATION";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.menuStrip1.Size = new System.Drawing.Size(822, 28);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addInformationToolStripMenuItem
            // 
            this.addInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherToolStripMenuItem2,
            this.employeeToolStripMenuItem1,
            this.transportToolStripMenuItem1,
            this.requisitionToolStripMenuItem,
            this.personalCarUseToolStripMenuItem,
            this.purchaseEquipmentToolStripMenuItem,
            this.usageEquipmentToolStripMenuItem1,
            this.userToolStripMenuItem});
            this.addInformationToolStripMenuItem.Name = "addInformationToolStripMenuItem";
            this.addInformationToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.addInformationToolStripMenuItem.Text = "Add Information";
            // 
            // teacherToolStripMenuItem2
            // 
            this.teacherToolStripMenuItem2.Name = "teacherToolStripMenuItem2";
            this.teacherToolStripMenuItem2.Size = new System.Drawing.Size(212, 24);
            this.teacherToolStripMenuItem2.Text = "Teacher";
            this.teacherToolStripMenuItem2.Click += new System.EventHandler(this.teacherToolStripMenuItem2_Click);
            // 
            // employeeToolStripMenuItem1
            // 
            this.employeeToolStripMenuItem1.Name = "employeeToolStripMenuItem1";
            this.employeeToolStripMenuItem1.Size = new System.Drawing.Size(212, 24);
            this.employeeToolStripMenuItem1.Text = "Employee";
            this.employeeToolStripMenuItem1.Click += new System.EventHandler(this.employeeToolStripMenuItem1_Click);
            // 
            // transportToolStripMenuItem1
            // 
            this.transportToolStripMenuItem1.Name = "transportToolStripMenuItem1";
            this.transportToolStripMenuItem1.Size = new System.Drawing.Size(212, 24);
            this.transportToolStripMenuItem1.Text = "Transport";
            this.transportToolStripMenuItem1.Click += new System.EventHandler(this.transportToolStripMenuItem1_Click);
            // 
            // requisitionToolStripMenuItem
            // 
            this.requisitionToolStripMenuItem.Name = "requisitionToolStripMenuItem";
            this.requisitionToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.requisitionToolStripMenuItem.Text = "Requisition";
            this.requisitionToolStripMenuItem.Click += new System.EventHandler(this.requisitionToolStripMenuItem_Click);
            // 
            // personalCarUseToolStripMenuItem
            // 
            this.personalCarUseToolStripMenuItem.Name = "personalCarUseToolStripMenuItem";
            this.personalCarUseToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.personalCarUseToolStripMenuItem.Text = "Personal Car Use";
            this.personalCarUseToolStripMenuItem.Click += new System.EventHandler(this.personalCarUseToolStripMenuItem_Click);
            // 
            // purchaseEquipmentToolStripMenuItem
            // 
            this.purchaseEquipmentToolStripMenuItem.Name = "purchaseEquipmentToolStripMenuItem";
            this.purchaseEquipmentToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.purchaseEquipmentToolStripMenuItem.Text = "Purchase Equipment";
            this.purchaseEquipmentToolStripMenuItem.Click += new System.EventHandler(this.purchaseEquipmentToolStripMenuItem_Click);
            // 
            // usageEquipmentToolStripMenuItem1
            // 
            this.usageEquipmentToolStripMenuItem1.Name = "usageEquipmentToolStripMenuItem1";
            this.usageEquipmentToolStripMenuItem1.Size = new System.Drawing.Size(212, 24);
            this.usageEquipmentToolStripMenuItem1.Text = "Usage Equipment";
            this.usageEquipmentToolStripMenuItem1.Click += new System.EventHandler(this.usageEquipmentToolStripMenuItem1_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
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
            this.transportListToolStripMenuItem.Click += new System.EventHandler(this.transportListToolStripMenuItem_Click);
            // 
            // teacherToolStripMenuItem1
            // 
            this.teacherToolStripMenuItem1.Name = "teacherToolStripMenuItem1";
            this.teacherToolStripMenuItem1.Size = new System.Drawing.Size(213, 24);
            this.teacherToolStripMenuItem1.Text = "Teacher List";
            this.teacherToolStripMenuItem1.Click += new System.EventHandler(this.teacherToolStripMenuItem1_Click);
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
            this.requisitionListToolStripMenuItem.Click += new System.EventHandler(this.requisitionListToolStripMenuItem_Click);
            // 
            // personalCarUseListToolStripMenuItem
            // 
            this.personalCarUseListToolStripMenuItem.Name = "personalCarUseListToolStripMenuItem";
            this.personalCarUseListToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.personalCarUseListToolStripMenuItem.Text = "Personal Car Use List";
            this.personalCarUseListToolStripMenuItem.Click += new System.EventHandler(this.personalCarUseListToolStripMenuItem_Click);
            // 
            // purchaseEquipmentToolStripMenuItem1
            // 
            this.purchaseEquipmentToolStripMenuItem1.Name = "purchaseEquipmentToolStripMenuItem1";
            this.purchaseEquipmentToolStripMenuItem1.Size = new System.Drawing.Size(213, 24);
            this.purchaseEquipmentToolStripMenuItem1.Text = "Purchase Equipment";
            this.purchaseEquipmentToolStripMenuItem1.Click += new System.EventHandler(this.purchaseEquipmentToolStripMenuItem1_Click);
            // 
            // usageEquipmentToolStripMenuItem
            // 
            this.usageEquipmentToolStripMenuItem.Name = "usageEquipmentToolStripMenuItem";
            this.usageEquipmentToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.usageEquipmentToolStripMenuItem.Text = "Usage Equipment";
            this.usageEquipmentToolStripMenuItem.Click += new System.EventHandler(this.usageEquipmentToolStripMenuItem_Click);
            // 
            // storedEquipmentToolStripMenuItem
            // 
            this.storedEquipmentToolStripMenuItem.Name = "storedEquipmentToolStripMenuItem";
            this.storedEquipmentToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.storedEquipmentToolStripMenuItem.Text = "Stored Equipment";
            this.storedEquipmentToolStripMenuItem.Click += new System.EventHandler(this.storedEquipmentToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem1
            // 
            this.userToolStripMenuItem1.Name = "userToolStripMenuItem1";
            this.userToolStripMenuItem1.Size = new System.Drawing.Size(213, 24);
            this.userToolStripMenuItem1.Text = "User";
            this.userToolStripMenuItem1.Click += new System.EventHandler(this.userToolStripMenuItem1_Click);
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
            this.teacherInfoToolStripMenuItem.Click += new System.EventHandler(this.teacherInfoToolStripMenuItem_Click);
            // 
            // employeeInfoToolStripMenuItem
            // 
            this.employeeInfoToolStripMenuItem.Name = "employeeInfoToolStripMenuItem";
            this.employeeInfoToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.employeeInfoToolStripMenuItem.Text = "Employee Info";
            this.employeeInfoToolStripMenuItem.Click += new System.EventHandler(this.employeeInfoToolStripMenuItem_Click);
            // 
            // transportInfoToolStripMenuItem
            // 
            this.transportInfoToolStripMenuItem.Name = "transportInfoToolStripMenuItem";
            this.transportInfoToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.transportInfoToolStripMenuItem.Text = "Transport Info";
            this.transportInfoToolStripMenuItem.Click += new System.EventHandler(this.transportInfoToolStripMenuItem_Click);
            // 
            // requisitionInfoToolStripMenuItem
            // 
            this.requisitionInfoToolStripMenuItem.Name = "requisitionInfoToolStripMenuItem";
            this.requisitionInfoToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.requisitionInfoToolStripMenuItem.Text = "Requisition Info";
            this.requisitionInfoToolStripMenuItem.Click += new System.EventHandler(this.requisitionInfoToolStripMenuItem_Click);
            // 
            // carUseInfoToolStripMenuItem
            // 
            this.carUseInfoToolStripMenuItem.Name = "carUseInfoToolStripMenuItem";
            this.carUseInfoToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.carUseInfoToolStripMenuItem.Text = "Car Use Info";
            this.carUseInfoToolStripMenuItem.Click += new System.EventHandler(this.carUseInfoToolStripMenuItem_Click);
            // 
            // equipmentInfoToolStripMenuItem
            // 
            this.equipmentInfoToolStripMenuItem.Name = "equipmentInfoToolStripMenuItem";
            this.equipmentInfoToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.equipmentInfoToolStripMenuItem.Text = "Purchase Equipment Info";
            this.equipmentInfoToolStripMenuItem.Click += new System.EventHandler(this.equipmentInfoToolStripMenuItem_Click);
            // 
            // storedEquipmentToolStripMenuItem2
            // 
            this.storedEquipmentToolStripMenuItem2.Name = "storedEquipmentToolStripMenuItem2";
            this.storedEquipmentToolStripMenuItem2.Size = new System.Drawing.Size(242, 24);
            this.storedEquipmentToolStripMenuItem2.Text = "Usages Equipment Info";
            this.storedEquipmentToolStripMenuItem2.Click += new System.EventHandler(this.storedEquipmentToolStripMenuItem2_Click);
            // 
            // userInfoToolStripMenuItem
            // 
            this.userInfoToolStripMenuItem.Name = "userInfoToolStripMenuItem";
            this.userInfoToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.userInfoToolStripMenuItem.Text = "User Info";
            this.userInfoToolStripMenuItem.Click += new System.EventHandler(this.userInfoToolStripMenuItem_Click);
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
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 27);
            this.button1.TabIndex = 54;
            this.button1.Text = "Show Result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(173, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 33);
            this.label3.TabIndex = 53;
            this.label3.Text = "VIEW PURCHASE EQUIPMENT BY DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "End Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Start Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(331, 497);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 50;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(331, 454);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // ViewPurchaseGrid
            // 
            this.ViewPurchaseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewPurchaseGrid.Location = new System.Drawing.Point(0, 91);
            this.ViewPurchaseGrid.Name = "ViewPurchaseGrid";
            this.ViewPurchaseGrid.Size = new System.Drawing.Size(819, 288);
            this.ViewPurchaseGrid.TabIndex = 47;
            // 
            // CreatePdf
            // 
            this.CreatePdf.Location = new System.Drawing.Point(438, 529);
            this.CreatePdf.Name = "CreatePdf";
            this.CreatePdf.Size = new System.Drawing.Size(93, 27);
            this.CreatePdf.TabIndex = 55;
            this.CreatePdf.Text = "Create Pdf";
            this.CreatePdf.UseVisualStyleBackColor = true;
            this.CreatePdf.Click += new System.EventHandler(this.CreatePdf_Click_1);
            // 
            // dtmsDataSet2
            // 
            this.dtmsDataSet2.DataSetName = "DTMSDataSet";
            this.dtmsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ViewPurchasesEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 584);
            this.Controls.Add(this.panel1);
            this.Name = "ViewPurchasesEquipmentForm";
            this.Text = "View Purchase Equipment Form";
            this.Load += new System.EventHandler(this.ViewPurchasesEquipmentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPurchaseGrid)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView ViewPurchaseGrid;
        private System.Windows.Forms.Button CreatePdf;
        private DTMSDataSet dtmsDataSet2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem purchaseEquipmentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeeListToolStripMenuItem;

    }
}
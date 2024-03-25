using SomerenService;
using System.Drawing;

namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            vATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            pnlVat = new System.Windows.Forms.Panel();
            lblRecordProducts = new System.Windows.Forms.Label();
            lblProducts = new System.Windows.Forms.Label();
            lblRecordOrders = new System.Windows.Forms.Label();
            lblOrders = new System.Windows.Forms.Label();
            lblTotalToPayValue = new System.Windows.Forms.Label();
            lblTotalToPay = new System.Windows.Forms.Label();
            lblRecordTotal = new System.Windows.Forms.Label();
            lblRecordPercentage = new System.Windows.Forms.Label();
            lblRecordTypeVat = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            lblPercentage = new System.Windows.Forms.Label();
            blbVatType = new System.Windows.Forms.Label();
            gbQuarter = new System.Windows.Forms.GroupBox();
            btnQ1 = new System.Windows.Forms.Button();
            btnQ4 = new System.Windows.Forms.Button();
            btnQ2 = new System.Windows.Forms.Button();
            btnQ3 = new System.Windows.Forms.Button();
            lblYear = new System.Windows.Forms.Label();
            txtYear = new System.Windows.Forms.TextBox();
            lblDates = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            flowLayoutPanelStudents = new System.Windows.Forms.FlowLayoutPanel();
            pnlTeachers = new System.Windows.Forms.Panel();
            flowLayoutPanelTeachers = new System.Windows.Forms.FlowLayoutPanel();
            pnlActivities = new System.Windows.Forms.Panel();
            flowLayoutPanelActivities = new System.Windows.Forms.FlowLayoutPanel();
            pnlRooms = new System.Windows.Forms.Panel();
            flowLayoutPanelRooms = new System.Windows.Forms.FlowLayoutPanel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            headerLabel = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlVat.SuspendLayout();
            gbQuarter.SuspendLayout();
            pnlStudents.SuspendLayout();
            pnlTeachers.SuspendLayout();
            pnlActivities.SuspendLayout();
            pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, teachersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, vATToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1498, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(94, 21);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new Size(160, 26);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(160, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(82, 21);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // teachersToolStripMenuItem
            // 
            teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            teachersToolStripMenuItem.Size = new Size(83, 21);
            teachersToolStripMenuItem.Text = "Teachers";
            teachersToolStripMenuItem.Click += teachersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new Size(82, 21);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new Size(66, 21);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // vATToolStripMenuItem
            // 
            vATToolStripMenuItem.Name = "vATToolStripMenuItem";
            vATToolStripMenuItem.Size = new Size(47, 21);
            vATToolStripMenuItem.Text = "VAT";
            vATToolStripMenuItem.Click += vATToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new Point(14, 36);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(1072, 621);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new Point(15, 18);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(258, 17);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlVat
            // 
            pnlVat.Controls.Add(lblRecordProducts);
            pnlVat.Controls.Add(lblProducts);
            pnlVat.Controls.Add(lblRecordOrders);
            pnlVat.Controls.Add(lblOrders);
            pnlVat.Controls.Add(lblTotalToPayValue);
            pnlVat.Controls.Add(lblTotalToPay);
            pnlVat.Controls.Add(lblRecordTotal);
            pnlVat.Controls.Add(lblRecordPercentage);
            pnlVat.Controls.Add(lblRecordTypeVat);
            pnlVat.Controls.Add(lblTotal);
            pnlVat.Controls.Add(lblPercentage);
            pnlVat.Controls.Add(blbVatType);
            pnlVat.Controls.Add(gbQuarter);
            pnlVat.Controls.Add(lblYear);
            pnlVat.Controls.Add(txtYear);
            pnlVat.Controls.Add(lblDates);
            pnlVat.Location = new Point(30, 80);
            pnlVat.Name = "pnlVat";
            pnlVat.Size = new Size(886, 347);
            pnlVat.TabIndex = 1;
            // 
            // lblRecordProducts
            // 
            lblRecordProducts.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordProducts.Location = new Point(307, 125);
            lblRecordProducts.Name = "lblRecordProducts";
            lblRecordProducts.Size = new Size(80, 23);
            lblRecordProducts.TabIndex = 20;
            lblRecordProducts.Tag = "PlaceholderRecordsLabel";
            lblRecordProducts.Text = "0";
            lblRecordProducts.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblProducts.Location = new Point(278, 81);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(89, 23);
            lblProducts.TabIndex = 19;
            lblProducts.Text = "Producten:";
            // 
            // lblRecordOrders
            // 
            lblRecordOrders.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordOrders.Location = new Point(229, 125);
            lblRecordOrders.Name = "lblRecordOrders";
            lblRecordOrders.Size = new Size(80, 23);
            lblRecordOrders.TabIndex = 18;
            lblRecordOrders.Tag = "PlaceholderRecordsLabel";
            lblRecordOrders.Text = "0";
            lblRecordOrders.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOrders
            // 
            lblOrders.AutoSize = true;
            lblOrders.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrders.Location = new Point(212, 81);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(65, 23);
            lblOrders.TabIndex = 17;
            lblOrders.Text = "Orders:";
            // 
            // lblTotalToPayValue
            // 
            lblTotalToPayValue.AutoSize = true;
            lblTotalToPayValue.BackColor = SystemColors.Control;
            lblTotalToPayValue.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalToPayValue.ForeColor = SystemColors.ControlText;
            lblTotalToPayValue.Location = new Point(373, 303);
            lblTotalToPayValue.Name = "lblTotalToPayValue";
            lblTotalToPayValue.Size = new Size(55, 23);
            lblTotalToPayValue.TabIndex = 16;
            lblTotalToPayValue.Text = "€0.00";
            // 
            // lblTotalToPay
            // 
            lblTotalToPay.AutoSize = true;
            lblTotalToPay.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalToPay.Location = new Point(207, 303);
            lblTotalToPay.Name = "lblTotalToPay";
            lblTotalToPay.Size = new Size(160, 23);
            lblTotalToPay.TabIndex = 15;
            lblTotalToPay.Text = "Totaal af te rekenen:";
            // 
            // lblRecordTotal
            // 
            lblRecordTotal.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordTotal.Location = new Point(373, 125);
            lblRecordTotal.Name = "lblRecordTotal";
            lblRecordTotal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            lblRecordTotal.Size = new Size(80, 23);
            lblRecordTotal.TabIndex = 14;
            lblRecordTotal.Tag = "PlaceholderRecordsLabel";
            lblRecordTotal.Text = "€0.00";
            lblRecordTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRecordPercentage
            // 
            lblRecordPercentage.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordPercentage.Location = new Point(142, 125);
            lblRecordPercentage.Name = "lblRecordPercentage";
            lblRecordPercentage.Size = new Size(80, 23);
            lblRecordPercentage.TabIndex = 13;
            lblRecordPercentage.Tag = "PlaceholderRecordsLabel";
            lblRecordPercentage.Text = "0%";
            lblRecordPercentage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRecordTypeVat
            // 
            lblRecordTypeVat.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordTypeVat.Location = new Point(33, 125);
            lblRecordTypeVat.Name = "lblRecordTypeVat";
            lblRecordTypeVat.Size = new Size(80, 23);
            lblRecordTypeVat.TabIndex = 12;
            lblRecordTypeVat.Tag = "PlaceholderRecordsLabel";
            lblRecordTypeVat.Text = "Overig";
            lblRecordTypeVat.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(373, 81);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 23);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Totaal:";
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPercentage.Location = new Point(114, 81);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(96, 23);
            lblPercentage.TabIndex = 10;
            lblPercentage.Text = "Percentage:";
            // 
            // blbVatType
            // 
            blbVatType.AutoSize = true;
            blbVatType.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            blbVatType.Location = new Point(21, 81);
            blbVatType.Name = "blbVatType";
            blbVatType.Size = new Size(87, 23);
            blbVatType.TabIndex = 9;
            blbVatType.Text = "Type BTW:";
            // 
            // gbQuarter
            // 
            gbQuarter.Controls.Add(btnQ1);
            gbQuarter.Controls.Add(btnQ4);
            gbQuarter.Controls.Add(btnQ2);
            gbQuarter.Controls.Add(btnQ3);
            gbQuarter.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            gbQuarter.Location = new Point(701, 148);
            gbQuarter.Name = "gbQuarter";
            gbQuarter.Size = new Size(165, 178);
            gbQuarter.TabIndex = 8;
            gbQuarter.TabStop = false;
            gbQuarter.Text = "Kwartaal:";
            // 
            // btnQ1
            // 
            btnQ1.BackColor = Color.IndianRed;
            btnQ1.Font = new Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ1.ForeColor = SystemColors.ControlText;
            btnQ1.Location = new Point(6, 46);
            btnQ1.Name = "btnQ1";
            btnQ1.Size = new Size(68, 59);
            btnQ1.TabIndex = 4;
            btnQ1.Tag = "Q1";
            btnQ1.Text = "Q1";
            btnQ1.UseVisualStyleBackColor = false;
            btnQ1.Click += btnQ1_Click;
            // 
            // btnQ4
            // 
            btnQ4.BackColor = Color.SlateBlue;
            btnQ4.Font = new Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ4.ForeColor = SystemColors.ControlText;
            btnQ4.Location = new Point(80, 111);
            btnQ4.Name = "btnQ4";
            btnQ4.Size = new Size(68, 59);
            btnQ4.TabIndex = 7;
            btnQ4.Tag = "Q4";
            btnQ4.Text = "Q4";
            btnQ4.UseVisualStyleBackColor = false;
            btnQ4.Click += btnQ4_Click;
            // 
            // btnQ2
            // 
            btnQ2.BackColor = Color.Orange;
            btnQ2.Font = new Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ2.ForeColor = SystemColors.ControlText;
            btnQ2.Location = new Point(80, 46);
            btnQ2.Name = "btnQ2";
            btnQ2.Size = new Size(68, 59);
            btnQ2.TabIndex = 5;
            btnQ2.Tag = "Q2";
            btnQ2.Text = "Q2";
            btnQ2.UseVisualStyleBackColor = false;
            btnQ2.Click += btnQ2_Click;
            // 
            // btnQ3
            // 
            btnQ3.BackColor = Color.Green;
            btnQ3.Font = new Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ3.ForeColor = SystemColors.ControlText;
            btnQ3.Location = new Point(6, 111);
            btnQ3.Name = "btnQ3";
            btnQ3.Size = new Size(68, 59);
            btnQ3.TabIndex = 6;
            btnQ3.Tag = "Q3";
            btnQ3.Text = "Q3";
            btnQ3.UseVisualStyleBackColor = false;
            btnQ3.Click += btnQ3_Click;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblYear.Location = new Point(701, 74);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(84, 31);
            lblYear.TabIndex = 1;
            lblYear.Text = "Jaartal:";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(701, 108);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 2;
            txtYear.TextChanged += txtYear_TextChanged;
            // 
            // lblDates
            // 
            lblDates.AutoSize = true;
            lblDates.Font = new Font("Segoe UI Semilight", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblDates.Location = new Point(12, 11);
            lblDates.Name = "lblDates";
            lblDates.Size = new Size(383, 54);
            lblDates.TabIndex = 0;
            lblDates.Text = "Selecteer een tijdstip";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(flowLayoutPanelStudents);
            pnlStudents.Location = new Point(14, 31);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new Size(1072, 528);
            pnlStudents.TabIndex = 2;
            // 
            // flowLayoutPanelStudents
            // 
            flowLayoutPanelStudents.Location = new Point(18, 48);
            flowLayoutPanelStudents.Name = "flowLayoutPanelStudents";
            flowLayoutPanelStudents.Size = new Size(875, 347);
            flowLayoutPanelStudents.TabIndex = 1;
            // 
            // pnlTeachers
            // 
            pnlTeachers.Controls.Add(flowLayoutPanelTeachers);
            pnlTeachers.Location = new Point(14, 31);
            pnlTeachers.Name = "pnlTeachers";
            pnlTeachers.Size = new Size(1072, 528);
            pnlTeachers.TabIndex = 2;
            // 
            // flowLayoutPanelTeachers
            // 
            flowLayoutPanelTeachers.Location = new Point(18, 48);
            flowLayoutPanelTeachers.Name = "flowLayoutPanelTeachers";
            flowLayoutPanelTeachers.Size = new Size(875, 347);
            flowLayoutPanelTeachers.TabIndex = 1;
            // 
            // pnlActivities
            // 
            pnlActivities.Controls.Add(flowLayoutPanelActivities);
            pnlActivities.Location = new Point(14, 31);
            pnlActivities.Name = "pnlActivities";
            pnlActivities.Size = new Size(1072, 528);
            pnlActivities.TabIndex = 2;
            // 
            // flowLayoutPanelActivities
            // 
            flowLayoutPanelActivities.Location = new Point(18, 48);
            flowLayoutPanelActivities.Name = "flowLayoutPanelActivities";
            flowLayoutPanelActivities.Size = new Size(875, 347);
            flowLayoutPanelActivities.TabIndex = 1;
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(flowLayoutPanelRooms);
            pnlRooms.Location = new Point(14, 31);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new Size(1072, 528);
            pnlRooms.TabIndex = 2;
            // 
            // flowLayoutPanelRooms
            // 
            flowLayoutPanelRooms.Location = new Point(18, 48);
            flowLayoutPanelRooms.Name = "flowLayoutPanelRooms";
            flowLayoutPanelRooms.Size = new Size(875, 347);
            flowLayoutPanelRooms.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1200, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 164);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(15, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(134, 41);
            headerLabel.TabIndex = 0;
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(1498, 853);
            Controls.Add(pnlVat);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlStudents);
            Controls.Add(pnlTeachers);
            Controls.Add(pnlActivities);
            Controls.Add(pnlRooms);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "SomerenUI";
            Text = "SomerenApp";
            Load += SomerenUI_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlVat.ResumeLayout(false);
            pnlVat.PerformLayout();
            gbQuarter.ResumeLayout(false);
            pnlStudents.ResumeLayout(false);
            pnlTeachers.ResumeLayout(false);
            pnlActivities.ResumeLayout(false);
            pnlRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.Panel pnlActivities;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.Panel pnlVat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelStudents;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTeachers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelActivities;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRooms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label blbVatType;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblRecordTotal;
        private System.Windows.Forms.Label lblRecordPercentage;
        private System.Windows.Forms.Label lblRecordTypeVat;
        private System.Windows.Forms.Label lblTotalToPay;
        private System.Windows.Forms.ToolStripMenuItem vATToolStripMenuItem;
        private System.Windows.Forms.Label lblTotalToPayValue;
        private System.Windows.Forms.GroupBox gbQuarter;
        private System.Windows.Forms.Button btnQ1;
        private System.Windows.Forms.Button btnQ4;
        private System.Windows.Forms.Button btnQ2;
        private System.Windows.Forms.Button btnQ3;
        private System.Windows.Forms.Label lblRecordProducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblRecordOrders;
        private System.Windows.Forms.Label lblOrders;
    }
}
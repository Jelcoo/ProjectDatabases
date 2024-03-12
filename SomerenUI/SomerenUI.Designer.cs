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
            pnlStudents = new System.Windows.Forms.Panel();
            flowLayoutPanelStudents = new System.Windows.Forms.FlowLayoutPanel();
            pnlTeachers = new System.Windows.Forms.Panel();
            flowLayoutPanelTeachers = new System.Windows.Forms.FlowLayoutPanel();
            pnlActivities = new System.Windows.Forms.Panel();
            flowLayoutPanelActivities = new System.Windows.Forms.FlowLayoutPanel();
            pnlRooms = new System.Windows.Forms.Panel();
            flowLayoutPanelRooms = new System.Windows.Forms.FlowLayoutPanel();
            pnlVat = new System.Windows.Forms.Panel();
            flowLayoutPanelVat = new System.Windows.Forms.FlowLayoutPanel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            headerLabel = new System.Windows.Forms.Label();
            lblDates = new System.Windows.Forms.Label();
            lblJaartal = new System.Windows.Forms.Label();
            txtJaartal = new System.Windows.Forms.TextBox();
            btnQ1 = new System.Windows.Forms.Button();
            btnQ2 = new System.Windows.Forms.Button();
            btnQ3 = new System.Windows.Forms.Button();
            btnQ4 = new System.Windows.Forms.Button();
            gbKwartaal = new System.Windows.Forms.GroupBox();
            blbVatType = new System.Windows.Forms.Label();
            lblPercentage = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            lblRecordTotal = new System.Windows.Forms.Label();
            lblRecordPercentage = new System.Windows.Forms.Label();
            lblRecordTypeVat = new System.Windows.Forms.Label();
            lblTotalToPay = new System.Windows.Forms.Label();
            lblTotalToPayValue = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            pnlTeachers.SuspendLayout();
            pnlActivities.SuspendLayout();
            pnlRooms.SuspendLayout();
            pnlVat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, teachersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, vATToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1099, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(94, 21);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(160, 26);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // teachersToolStripMenuItem
            // 
            teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            teachersToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            teachersToolStripMenuItem.Text = "Teachers";
            teachersToolStripMenuItem.Click += teachersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // vATToolStripMenuItem
            // 
            vATToolStripMenuItem.Name = "vATToolStripMenuItem";
            vATToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            vATToolStripMenuItem.Text = "VAT";
            vATToolStripMenuItem.Click += vATToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(14, 36);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1072, 621);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(15, 18);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(258, 17);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(flowLayoutPanelStudents);
            pnlStudents.Location = new System.Drawing.Point(14, 31);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1072, 528);
            pnlStudents.TabIndex = 2;
            // 
            // flowLayoutPanelStudents
            // 
            flowLayoutPanelStudents.Location = new System.Drawing.Point(18, 48);
            flowLayoutPanelStudents.Name = "flowLayoutPanelStudents";
            flowLayoutPanelStudents.Size = new System.Drawing.Size(875, 347);
            flowLayoutPanelStudents.TabIndex = 1;
            // 
            // pnlTeachers
            // 
            pnlTeachers.Controls.Add(flowLayoutPanelTeachers);
            pnlTeachers.Location = new System.Drawing.Point(14, 31);
            pnlTeachers.Name = "pnlTeachers";
            pnlTeachers.Size = new System.Drawing.Size(1072, 528);
            pnlTeachers.TabIndex = 2;
            // 
            // flowLayoutPanelTeachers
            // 
            flowLayoutPanelTeachers.Location = new System.Drawing.Point(18, 48);
            flowLayoutPanelTeachers.Name = "flowLayoutPanelTeachers";
            flowLayoutPanelTeachers.Size = new System.Drawing.Size(875, 347);
            flowLayoutPanelTeachers.TabIndex = 1;
            // 
            // pnlActivities
            // 
            pnlActivities.Controls.Add(flowLayoutPanelActivities);
            pnlActivities.Location = new System.Drawing.Point(14, 31);
            pnlActivities.Name = "pnlActivities";
            pnlActivities.Size = new System.Drawing.Size(1072, 528);
            pnlActivities.TabIndex = 2;
            // 
            // flowLayoutPanelActivities
            // 
            flowLayoutPanelActivities.Location = new System.Drawing.Point(18, 48);
            flowLayoutPanelActivities.Name = "flowLayoutPanelActivities";
            flowLayoutPanelActivities.Size = new System.Drawing.Size(875, 347);
            flowLayoutPanelActivities.TabIndex = 1;
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(flowLayoutPanelRooms);
            pnlRooms.Location = new System.Drawing.Point(14, 31);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(1072, 528);
            pnlRooms.TabIndex = 2;
            // 
            // flowLayoutPanelRooms
            // 
            flowLayoutPanelRooms.Location = new System.Drawing.Point(18, 48);
            flowLayoutPanelRooms.Name = "flowLayoutPanelRooms";
            flowLayoutPanelRooms.Size = new System.Drawing.Size(875, 347);
            flowLayoutPanelRooms.TabIndex = 1;
            // 
            // pnlVat
            // 
            pnlVat.Controls.Add(flowLayoutPanelVat);
            pnlVat.Location = new System.Drawing.Point(14, 31);
            pnlVat.Name = "pnlVat";
            pnlVat.Size = new System.Drawing.Size(1072, 528);
            pnlVat.TabIndex = 2;
            // 
            // flowLayoutPanelVat
            // 
            flowLayoutPanelVat.Location = new System.Drawing.Point(18, 48);
            flowLayoutPanelVat.Name = "flowLayoutPanelVat";
            flowLayoutPanelVat.Size = new System.Drawing.Size(875, 347);
            flowLayoutPanelVat.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(1200, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(149, 164);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            headerLabel.Location = new System.Drawing.Point(15, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new System.Drawing.Size(134, 41);
            headerLabel.TabIndex = 0;
            // 
            // lblDates
            // 
            lblDates.AutoSize = true;
            lblDates.Font = new Font("Segoe UI Semilight", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblDates.Location = new Point(12, 46);
            lblDates.Name = "lblDates";
            lblDates.Size = new Size(412, 54);
            lblDates.TabIndex = 0;
            lblDates.Text = "Selecteer een kwartaal";
            // 
            // lblJaartal
            // 
            lblJaartal.AutoSize = true;
            lblJaartal.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblJaartal.Location = new Point(579, 64);
            lblJaartal.Name = "lblJaartal";
            lblJaartal.Size = new Size(84, 31);
            lblJaartal.TabIndex = 1;
            lblJaartal.Text = "Jaartal:";
            // 
            // txtJaartal
            // 
            txtJaartal.Location = new Point(582, 98);
            txtJaartal.Name = "txtJaartal";
            txtJaartal.Size = new Size(125, 27);
            txtJaartal.TabIndex = 2;
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
            // 
            // gbKwartaal
            // 
            gbKwartaal.Controls.Add(btnQ1);
            gbKwartaal.Controls.Add(btnQ4);
            gbKwartaal.Controls.Add(btnQ2);
            gbKwartaal.Controls.Add(btnQ3);
            gbKwartaal.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            gbKwartaal.Location = new Point(579, 154);
            gbKwartaal.Name = "gbKwartaal";
            gbKwartaal.Size = new Size(165, 178);
            gbKwartaal.TabIndex = 8;
            gbKwartaal.TabStop = false;
            gbKwartaal.Text = "Kwartaal:";
            // 
            // blbVatType
            // 
            blbVatType.AutoSize = true;
            blbVatType.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            blbVatType.Location = new Point(23, 111);
            blbVatType.Name = "blbVatType";
            blbVatType.Size = new Size(87, 23);
            blbVatType.TabIndex = 9;
            blbVatType.Text = "Type BTW:";
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPercentage.Location = new Point(116, 111);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(96, 23);
            lblPercentage.TabIndex = 10;
            lblPercentage.Text = "Percentage:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(218, 111);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 23);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Totaal:";
            // 
            // lblRecordTotal
            // 
            lblRecordTotal.AutoSize = true;
            lblRecordTotal.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordTotal.Location = new Point(226, 154);
            lblRecordTotal.Name = "lblRecordTotal";
            lblRecordTotal.Size = new Size(50, 23);
            lblRecordTotal.TabIndex = 14;
            lblRecordTotal.Text = "€0.00";
            // 
            // lblRecordPercentage
            // 
            lblRecordPercentage.AutoSize = true;
            lblRecordPercentage.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordPercentage.Location = new Point(116, 154);
            lblRecordPercentage.Name = "lblRecordPercentage";
            lblRecordPercentage.Size = new Size(33, 23);
            lblRecordPercentage.TabIndex = 13;
            lblRecordPercentage.Text = "0%";
            // 
            // lblRecordTypeVat
            // 
            lblRecordTypeVat.AutoSize = true;
            lblRecordTypeVat.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordTypeVat.Location = new Point(23, 154);
            lblRecordTypeVat.Name = "lblRecordTypeVat";
            lblRecordTypeVat.Size = new Size(60, 23);
            lblRecordTypeVat.TabIndex = 12;
            lblRecordTypeVat.Text = "Overig";
            // 
            // lblTotalToPay
            // 
            lblTotalToPay.AutoSize = true;
            lblTotalToPay.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalToPay.Location = new Point(23, 380);
            lblTotalToPay.Name = "lblTotalToPay";
            lblTotalToPay.Size = new Size(160, 23);
            lblTotalToPay.TabIndex = 15;
            lblTotalToPay.Text = "Totaal af te rekenen:";
            // 
            // lblTotalToPayValue
            // 
            lblTotalToPayValue.AutoSize = true;
            lblTotalToPayValue.BackColor = SystemColors.Control;
            lblTotalToPayValue.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalToPayValue.ForeColor = SystemColors.ControlText;
            lblTotalToPayValue.Location = new Point(218, 380);
            lblTotalToPayValue.Name = "lblTotalToPayValue";
            lblTotalToPayValue.Size = new Size(55, 23);
            lblTotalToPayValue.TabIndex = 16;
            lblTotalToPayValue.Text = "€0.00";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1099, 673);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlStudents);
            Controls.Add(pnlTeachers);
            Controls.Add(pnlActivities);
            Controls.Add(pnlRooms);
            Controls.Add(pnlVat);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "SomerenUI";
            Text = "SomerenApp";
            Load += SomerenUI_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlTeachers.ResumeLayout(false);
            pnlActivities.ResumeLayout(false);
            pnlRooms.ResumeLayout(false);
            pnlVat.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelVat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Label lblJaartal;
        private System.Windows.Forms.TextBox txtJaartal;
        private System.Windows.Forms.Button btnQ1;
        private System.Windows.Forms.Button btnQ2;
        private System.Windows.Forms.Button btnQ3;
        private System.Windows.Forms.Button btnQ4;
        private System.Windows.Forms.GroupBox gbKwartaal;
        private System.Windows.Forms.Label blbVatType;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblRecordTotal;
        private System.Windows.Forms.Label lblRecordPercentage;
        private System.Windows.Forms.Label lblRecordTypeVat;
        private System.Windows.Forms.Label lblTotalToPay;
        private System.Windows.Forms.Label lblTotalToPayValue;
        private System.Windows.Forms.ToolStripMenuItem vATToolStripMenuItem;
    }
}
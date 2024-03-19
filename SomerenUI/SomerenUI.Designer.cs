using System.Windows.Forms;
using System;
using SomerenModel;

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
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            teachersToolStripMenuItem = new ToolStripMenuItem();
            activitiesToolStripMenuItem = new ToolStripMenuItem();
            roomsToolStripMenuItem = new ToolStripMenuItem();
            revenueToolStripMenuItem = new ToolStripMenuItem();
            pnlDashboard = new Panel();
            lblDashboard = new Label();
            pnlStudents = new Panel();
            flowLayoutPanelStudents = new FlowLayoutPanel();
            pnlTeachers = new Panel();
            flowLayoutPanelTeachers = new FlowLayoutPanel();
            pnlActivities = new Panel();
            flowLayoutPanelActivities = new FlowLayoutPanel();
            pnlRevenue = new Panel();
            OutputRevenue = new Label();
            EndDatePickerLabel1 = new Label();
            StartDatePickerLabel1 = new Label();
            revenueDateStart = new DateTimePicker();
            revenueDateEnd = new DateTimePicker();
            pnlRooms = new Panel();
            flowLayoutPanelRooms = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            headerLabel = new Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            pnlTeachers.SuspendLayout();
            pnlActivities.SuspendLayout();
            pnlRevenue.SuspendLayout();
            pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, teachersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, revenueToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1099, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // teachersToolStripMenuItem
            // 
            teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            teachersToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            teachersToolStripMenuItem.Text = "Teachers";
            teachersToolStripMenuItem.Click += teachersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // revenueToolStripMenuItem
            // 
            revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            revenueToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            revenueToolStripMenuItem.Text = "Revenue";
            revenueToolStripMenuItem.Click += revenueToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(14, 36);
            pnlDashboard.Margin = new Padding(3, 4, 3, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1072, 621);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(15, 18);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(262, 20);
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
            // pnlRevenue
            // 
            pnlRevenue.Controls.Add(OutputRevenue);
            pnlRevenue.Controls.Add(EndDatePickerLabel1);
            pnlRevenue.Controls.Add(StartDatePickerLabel1);
            pnlRevenue.Controls.Add(revenueDateStart);
            pnlRevenue.Controls.Add(revenueDateEnd);
            pnlRevenue.Location = new System.Drawing.Point(14, 31);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new System.Drawing.Size(1072, 528);
            pnlRevenue.TabIndex = 2;
            // 
            // OutputRevenue
            // 
            OutputRevenue.AutoSize = true;
            OutputRevenue.Location = new System.Drawing.Point(73, 184);
            OutputRevenue.Name = "OutputRevenue";
            OutputRevenue.Size = new System.Drawing.Size(0, 20);
            OutputRevenue.TabIndex = 3;
            
            // 
            // EndDatePickerLabel1
            // 
            EndDatePickerLabel1.AutoSize = true;
            EndDatePickerLabel1.Location = new System.Drawing.Point(398, 68);
            EndDatePickerLabel1.Name = "EndDatePickerLabel1";
            EndDatePickerLabel1.Size = new System.Drawing.Size(69, 20);
            EndDatePickerLabel1.TabIndex = 2;
            EndDatePickerLabel1.Text = "EndDate:";
            // 
            // StartDatePickerLabel1
            // 
            StartDatePickerLabel1.AutoSize = true;
            StartDatePickerLabel1.Location = new System.Drawing.Point(15, 68);
            StartDatePickerLabel1.Name = "StartDatePickerLabel1";
            StartDatePickerLabel1.Size = new System.Drawing.Size(75, 20);
            StartDatePickerLabel1.TabIndex = 1;
            StartDatePickerLabel1.Text = "StartDate:";
            // 
            // revenueDateStart
            // 
            revenueDateStart.Location = new System.Drawing.Point(15, 91);
            revenueDateStart.MaxDate = DateTime.Now;
            revenueDateStart.Name = "revenueDateStart";
            revenueDateStart.Size = new System.Drawing.Size(200, 27);
            revenueDateStart.TabIndex = 0;
            revenueDateStart.ValueChanged += updateRevenueSelector;
            revenueDateStart.Format = DateTimePickerFormat.Custom;
            revenueDateStart.CustomFormat = "dd MMM yyyy";
            // 
            // revenueDateEnd
            // 
            revenueDateEnd.Location = new System.Drawing.Point(398, 91);
            revenueDateEnd.MaxDate = DateTime.Now;
            revenueDateEnd.Name = "revenueDateEnd";
            revenueDateEnd.Size = new System.Drawing.Size(200, 27);
            revenueDateEnd.TabIndex = 0;
            revenueDateEnd.ValueChanged += updateRevenueSelector;
            revenueDateEnd.Format = DateTimePickerFormat.Custom;
            revenueDateEnd.CustomFormat = "dd MMM yyyy";
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
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(1200, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
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
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1099, 673);
            Controls.Add(pnlRevenue);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlStudents);
            Controls.Add(pnlTeachers);
            Controls.Add(pnlActivities);
            Controls.Add(pnlRooms);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem revenueToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.Panel pnlActivities;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelStudents;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTeachers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelActivities;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRooms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.DateTimePicker revenueDateStart;
        private System.Windows.Forms.DateTimePicker revenueDateEnd;
        private Label StartDatePickerLabel1;
        private Label EndDatePickerLabel1;
        private Label OutputRevenue;
    }
}
using System.Windows.Forms;
using System;
using SomerenModel;
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
            ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            revenueToolStripMenuItem = new ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            listViewGeneral = new System.Windows.Forms.ListView();
            pnlTeachers = new System.Windows.Forms.Panel();
            pnlActivities = new System.Windows.Forms.Panel();
            pnlRooms = new System.Windows.Forms.Panel();
            pnlOrders = new System.Windows.Forms.Panel();
            pnlRevenue = new Panel();
            OutputRevenue = new Label();
            ordersComboBoxLabel = new System.Windows.Forms.Label();
            ordersComboBox = new System.Windows.Forms.ComboBox();
            orderDetailsLabel = new System.Windows.Forms.Label();
            orderProcessButton = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            headerLabel = new System.Windows.Forms.Label();
            OutputRevenue = new Label();
            EndDatePickerLabel1 = new Label();
            StartDatePickerLabel1 = new Label();
            revenueDateStart = new DateTimePicker();
            revenueDateEnd = new DateTimePicker();
            flowLayoutPanelOrderProducts = new System.Windows.Forms.FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlRooms.SuspendLayout();
            pnlOrders.SuspendLayout();
            pnlRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, teachersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, ordersToolStripMenuItem, revenueToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1099, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(118, 29);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new Size(202, 34);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(202, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(97, 29);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // teachersToolStripMenuItem
            // 
            teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            teachersToolStripMenuItem.Size = new Size(94, 29);
            teachersToolStripMenuItem.Text = "Teachers";
            teachersToolStripMenuItem.Click += teachersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new Size(83, 24);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new Size(84, 29);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // ordersToolStripMenuItem
            // 
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new Size(82, 29);
            ordersToolStripMenuItem.Text = "Orders";
            ordersToolStripMenuItem.Click += ordersToolStripMenuItem_Click;
            // 
            // revenueToolStripMenuItem
            // 
            revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            ordersToolStripMenuItem.Size = new Size(82, 29);
            revenueToolStripMenuItem.Text = "Revenue";
            revenueToolStripMenuItem.Click += revenueToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new Point(18, 45);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(1340, 776);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new Point(19, 22);
            lblDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(313, 25);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Location = new Point(14, 31);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new Size(1340, 660);
            pnlStudents.TabIndex = 2;
            // 
            // listViewGeneral
            // 
            listViewGeneral.GridLines = true;
            listViewGeneral.Location = new Point(15, 70);
            listViewGeneral.Name = "listViewGeneral";
            listViewGeneral.Size = new Size(875, 347);
            listViewGeneral.TabIndex = 1;
            listViewGeneral.UseCompatibleStateImageBehavior = false;
            listViewGeneral.View = System.Windows.Forms.View.Details;
            // 
            // pnlTeachers
            // 
            pnlTeachers.Location = new Point(14, 31);
            pnlTeachers.Name = "pnlTeachers";
            pnlTeachers.Size = new Size(1340, 660);
            pnlTeachers.TabIndex = 2;
            // 
            // pnlActivities
            // 
            pnlActivities.Location = new Point(14, 31);
            pnlActivities.Name = "pnlActivities";
            pnlActivities.Size = new Size(1340, 660);
            pnlActivities.TabIndex = 2;
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(listViewGeneral);
            pnlRooms.Location = new Point(14, 31);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new Size(1340, 660);
            pnlRooms.TabIndex = 2;
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
            OutputRevenue.Location = new System.Drawing.Point(15, 184);
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
            EndDatePickerLabel1.Text = "End date:";
            // 
            // StartDatePickerLabel1
            // 
            StartDatePickerLabel1.AutoSize = true;
            StartDatePickerLabel1.Location = new System.Drawing.Point(15, 68);
            StartDatePickerLabel1.Name = "StartDatePickerLabel1";
            StartDatePickerLabel1.Size = new System.Drawing.Size(75, 20);
            StartDatePickerLabel1.TabIndex = 1;
            StartDatePickerLabel1.Text = "Start date:";
            // 
            // revenueDateStart
            // 
            revenueDateStart.Location = new System.Drawing.Point(17, 100);
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
            revenueDateEnd.Location = new System.Drawing.Point(400, 100);
            revenueDateEnd.MaxDate = DateTime.Now;
            revenueDateEnd.Name = "revenueDateEnd";
            revenueDateEnd.Size = new System.Drawing.Size(200, 27);
            revenueDateEnd.TabIndex = 0;
            revenueDateEnd.ValueChanged += updateRevenueSelector;
            revenueDateEnd.Format = DateTimePickerFormat.Custom;
            revenueDateEnd.CustomFormat = "dd MMM yyyy";
            // 
            // pnlOrders
            // 
            pnlOrders.Controls.Add(ordersComboBoxLabel);
            pnlOrders.Controls.Add(ordersComboBox);
            pnlOrders.Controls.Add(orderDetailsLabel);
            pnlOrders.Controls.Add(orderProcessButton);
            pnlOrders.Location = new Point(18, 39);
            pnlOrders.Margin = new System.Windows.Forms.Padding(4);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(1340, 660);
            pnlOrders.TabIndex = 2;
            // 
            // ordersComboBoxLabel
            // 
            ordersComboBoxLabel.AutoSize = true;
            ordersComboBoxLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ordersComboBoxLabel.Location = new Point(22, 80);
            ordersComboBoxLabel.Name = "ordersComboBoxLabel";
            ordersComboBoxLabel.Size = new Size(161, 28);
            ordersComboBoxLabel.TabIndex = 0;
            ordersComboBoxLabel.Text = "Selecteer leerling";
            // 
            // ordersComboBox
            // 
            ordersComboBox.Location = new Point(190, 80);
            ordersComboBox.Margin = new System.Windows.Forms.Padding(4);
            ordersComboBox.Name = "ordersComboBox";
            ordersComboBox.Size = new Size(400, 33);
            ordersComboBox.TabIndex = 1;
            ordersComboBox.SelectedIndexChanged += ordersComboBox_SelectedIndexChanged;
            // 
            // orderDetailsLabel
            // 
            orderDetailsLabel.AutoSize = true;
            orderDetailsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            orderDetailsLabel.Location = new Point(650, 80);
            orderDetailsLabel.Name = "orderDetailsLabel";
            orderDetailsLabel.Size = new Size(0, 28);
            orderDetailsLabel.TabIndex = 0;
            // 
            // orderProcessButton
            // 
            orderProcessButton.Location = new Point(650, 400);
            orderProcessButton.Name = "orderProcessButton";
            orderProcessButton.Size = new Size(200, 40);
            orderProcessButton.TabIndex = 2;
            orderProcessButton.Text = "Process Order";
            orderProcessButton.Visible = false;
            orderProcessButton.MouseClick += orderProcessButton_Click;
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
            // flowLayoutPanelOrderProducts
            // 
            flowLayoutPanelOrderProducts.Location = new Point(15, 140);
            flowLayoutPanelOrderProducts.Margin = new System.Windows.Forms.Padding(4);
            flowLayoutPanelOrderProducts.Name = "flowLayoutPanelOrderProducts";
            flowLayoutPanelOrderProducts.Size = new Size(600, 434);
            flowLayoutPanelOrderProducts.TabIndex = 1;
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(1374, 841);
            Controls.Add(pnlRevenue);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlStudents);
            Controls.Add(pnlTeachers);
            Controls.Add(pnlActivities);
            Controls.Add(pnlRooms);
            Controls.Add(pnlOrders);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "SomerenUI";
            Text = "SomerenApp";
            Load += SomerenUI_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlRooms.ResumeLayout(false);
            pnlOrders.ResumeLayout(false);
            pnlOrders.PerformLayout();
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.Panel pnlActivities;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.ListView listViewGeneral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label ordersComboBoxLabel;
        private System.Windows.Forms.ComboBox ordersComboBox;
        private System.Windows.Forms.Label orderDetailsLabel;
        private System.Windows.Forms.Button orderProcessButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrderProducts;
        private System.Windows.Forms.DateTimePicker revenueDateStart;
        private System.Windows.Forms.DateTimePicker revenueDateEnd;
        private Label StartDatePickerLabel1;
        private Label EndDatePickerLabel1;
        private Label OutputRevenue;
    }
}

using System.Windows.Forms;
using System;
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
            activitiesToolStripMenuItem = new ToolStripMenuItem();
            activitiesToolStripMenuItem1 = new ToolStripMenuItem();
            activityParticipantsToolStripMenuItem = new ToolStripMenuItem();
            activitySupervisorsToolStripMenuItem = new ToolStripMenuItem();
            lblVatType = new Label();
            btnQ1 = new Button();
            btnQ2 = new Button();
            btnQ3 = new Button();
            btnQ4 = new Button();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            endDatePickerLabel1 = new Label();
            flowLayoutPanelOrderProducts = new FlowLayoutPanel();
            gbQuarter = new GroupBox();
            headerLabel = new Label();
            lblDashboard = new Label();
            lblDates = new Label();
            lblOrders = new Label();
            lblPercentage = new Label();
            lblProducts = new Label();
            lblRecordOrders = new Label();
            lblRecordPercentage = new Label();
            lblRecordProducts = new Label();
            lblRecordTotal = new Label();
            lblRecordTypeVat = new Label();
            lblTotal = new Label();
            lblTotalToPay = new Label();
            lblTotalToPayValue = new Label();
            lblYear = new Label();
            listViewGeneral = new ListView();
            listViewPanelProducts = new ListView();
            menuStrip1 = new MenuStrip();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            teachersToolStripMenuItem = new ToolStripMenuItem();
            roomsToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            ordersToolStripMenuItem = new ToolStripMenuItem();
            revenueToolStripMenuItem = new ToolStripMenuItem();
            vatToolStripMenuItem = new ToolStripMenuItem();
            orderDetailsLabel = new Label();
            orderProcessButton = new Button();
            ordersComboBox = new ComboBox();
            ordersComboBoxLabel = new Label();
            outputRevenue = new Label();
            pictureBox1 = new PictureBox();
            pnlActivities = new Panel();
            pnlActivityParticipants = new Panel();
            assignedStudentsLabel = new Label();
            activityParticipantUnassignButton = new Button();
            activityParticipantAssignButton = new Button();
            activityParticipantsAssigned = new ListView();
            activityParticipantsUnassigned = new ListView();
            activityParticipantsList = new ListView();
            pnlActivitySupervisors = new Panel();
            pnlDashboard = new Panel();
            pnlOrders = new Panel();
            pnlProducts = new Panel();
            productEditButton = new Button();
            productEditPriceInput = new NumericUpDown();
            productEditPriceLabel = new Label();
            productEditAlcoholInput = new CheckBox();
            productEditStockInput = new NumericUpDown();
            productEditStockLabel = new Label();
            productEditNameInput = new TextBox();
            productEditNameLabel = new Label();
            productDeleteButton = new Button();
            pnlRevenue = new Panel();
            startDatePickerLabel1 = new Label();
            revenueDateStart = new DateTimePicker();
            revenueDateEnd = new DateTimePicker();
            pnlRooms = new Panel();
            pnlStudents = new Panel();
            pnlTeachers = new Panel();
            pnlVat = new Panel();
            txtYear = new NumericUpDown();
            unassignedStudentsLabel = new Label();
            gbQuarter.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlActivityParticipants.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlOrders.SuspendLayout();
            pnlProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productEditPriceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productEditStockInput).BeginInit();
            pnlRevenue.SuspendLayout();
            pnlRooms.SuspendLayout();
            pnlVat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtYear).BeginInit();
            SuspendLayout();
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { activitiesToolStripMenuItem1, activityParticipantsToolStripMenuItem, activitySupervisorsToolStripMenuItem });
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new Size(98, 29);
            activitiesToolStripMenuItem.Text = "Activities";
            // 
            // activitiesToolStripMenuItem1
            // 
            activitiesToolStripMenuItem1.Name = "activitiesToolStripMenuItem1";
            activitiesToolStripMenuItem1.Size = new Size(206, 34);
            activitiesToolStripMenuItem1.Text = "Activities";
            activitiesToolStripMenuItem1.Click += activitiesToolStripMenuItem1_Click;
            // 
            // activityParticipantsToolStripMenuItem
            // 
            activityParticipantsToolStripMenuItem.Name = "activityParticipantsToolStripMenuItem";
            activityParticipantsToolStripMenuItem.Size = new Size(206, 34);
            activityParticipantsToolStripMenuItem.Text = "Participants";
            activityParticipantsToolStripMenuItem.Click += activityParticipantsToolStripMenuItem_Click;
            // 
            // activitySupervisorsToolStripMenuItem
            // 
            activitySupervisorsToolStripMenuItem.Name = "activitySupervisorsToolStripMenuItem";
            activitySupervisorsToolStripMenuItem.Size = new Size(206, 34);
            activitySupervisorsToolStripMenuItem.Text = "Supervisors";
            activitySupervisorsToolStripMenuItem.Click += activitySupervisorsToolStripMenuItem_Click;
            // 
            // lblVatType
            // 
            lblVatType.AutoSize = true;
            lblVatType.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblVatType.Location = new Point(21, 81);
            lblVatType.Name = "lblVatType";
            lblVatType.Size = new Size(98, 28);
            lblVatType.TabIndex = 9;
            lblVatType.Text = "Type BTW:";
            // 
            // btnQ1
            // 
            btnQ1.BackColor = Color.IndianRed;
            btnQ1.Font = new Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ1.ForeColor = SystemColors.ControlText;
            btnQ1.Location = new Point(6, 46);
            btnQ1.Name = "btnQ1";
            btnQ1.Size = new Size(78, 59);
            btnQ1.TabIndex = 4;
            btnQ1.Tag = "Q1";
            btnQ1.Text = "Q1";
            btnQ1.UseVisualStyleBackColor = false;
            btnQ1.Click += DisplayVat;
            // 
            // btnQ2
            // 
            btnQ2.BackColor = Color.Orange;
            btnQ2.Font = new Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ2.ForeColor = SystemColors.ControlText;
            btnQ2.Location = new Point(80, 46);
            btnQ2.Name = "btnQ2";
            btnQ2.Size = new Size(79, 59);
            btnQ2.TabIndex = 5;
            btnQ2.Tag = "Q2";
            btnQ2.Text = "Q2";
            btnQ2.UseVisualStyleBackColor = false;
            btnQ2.Click += DisplayVat;
            // 
            // btnQ3
            // 
            btnQ3.BackColor = Color.Green;
            btnQ3.Font = new Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ3.ForeColor = SystemColors.ControlText;
            btnQ3.Location = new Point(6, 111);
            btnQ3.Name = "btnQ3";
            btnQ3.Size = new Size(78, 59);
            btnQ3.TabIndex = 6;
            btnQ3.Tag = "Q3";
            btnQ3.Text = "Q3";
            btnQ3.UseVisualStyleBackColor = false;
            btnQ3.Click += DisplayVat;
            // 
            // btnQ4
            // 
            btnQ4.BackColor = Color.SlateBlue;
            btnQ4.Font = new Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ4.ForeColor = SystemColors.ControlText;
            btnQ4.Location = new Point(80, 111);
            btnQ4.Name = "btnQ4";
            btnQ4.Size = new Size(79, 59);
            btnQ4.TabIndex = 7;
            btnQ4.Tag = "Q4";
            btnQ4.Text = "Q4";
            btnQ4.UseVisualStyleBackColor = false;
            btnQ4.Click += DisplayVat;
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
            // endDatePickerLabel1
            // 
            endDatePickerLabel1.AutoSize = true;
            endDatePickerLabel1.Location = new Point(398, 68);
            endDatePickerLabel1.Name = "endDatePickerLabel1";
            endDatePickerLabel1.Size = new Size(86, 25);
            endDatePickerLabel1.TabIndex = 2;
            endDatePickerLabel1.Text = "End date:";
            // 
            // flowLayoutPanelOrderProducts
            // 
            flowLayoutPanelOrderProducts.Location = new Point(15, 140);
            flowLayoutPanelOrderProducts.Margin = new Padding(4);
            flowLayoutPanelOrderProducts.Name = "flowLayoutPanelOrderProducts";
            flowLayoutPanelOrderProducts.Size = new Size(600, 434);
            flowLayoutPanelOrderProducts.TabIndex = 1;
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
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(15, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(134, 41);
            headerLabel.TabIndex = 0;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new Point(15, 22);
            lblDashboard.Margin = new Padding(4, 0, 4, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(313, 25);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // lblDates
            // 
            lblDates.Font = new Font("Segoe UI Semilight", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblDates.Location = new Point(12, 11);
            lblDates.Name = "lblDates";
            lblDates.Size = new Size(1242, 65);
            lblDates.TabIndex = 0;
            lblDates.Text = "Selecteer een tijdstip";
            // 
            // lblOrders
            // 
            lblOrders.AutoSize = true;
            lblOrders.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrders.Location = new Point(212, 81);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(74, 28);
            lblOrders.TabIndex = 17;
            lblOrders.Text = "Orders:";
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPercentage.Location = new Point(114, 81);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(110, 28);
            lblPercentage.TabIndex = 10;
            lblPercentage.Text = "Percentage:";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblProducts.Location = new Point(278, 81);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(103, 28);
            lblProducts.TabIndex = 19;
            lblProducts.Text = "Producten:";
            // 
            // lblRecordOrders
            // 
            lblRecordOrders.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordOrders.Location = new Point(229, 125);
            lblRecordOrders.Name = "lblRecordOrders";
            lblRecordOrders.Size = new Size(80, 35);
            lblRecordOrders.TabIndex = 18;
            lblRecordOrders.Tag = "PlaceholderRecordsLabel";
            lblRecordOrders.Text = "0";
            lblRecordOrders.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRecordPercentage
            // 
            lblRecordPercentage.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordPercentage.Location = new Point(142, 125);
            lblRecordPercentage.Name = "lblRecordPercentage";
            lblRecordPercentage.Size = new Size(80, 35);
            lblRecordPercentage.TabIndex = 13;
            lblRecordPercentage.Tag = "PlaceholderRecordsLabel";
            lblRecordPercentage.Text = "0%";
            lblRecordPercentage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRecordProducts
            // 
            lblRecordProducts.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordProducts.Location = new Point(307, 125);
            lblRecordProducts.Name = "lblRecordProducts";
            lblRecordProducts.Size = new Size(80, 35);
            lblRecordProducts.TabIndex = 20;
            lblRecordProducts.Tag = "PlaceholderRecordsLabel";
            lblRecordProducts.Text = "0";
            lblRecordProducts.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRecordTotal
            // 
            lblRecordTotal.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordTotal.Location = new Point(373, 125);
            lblRecordTotal.Name = "lblRecordTotal";
            lblRecordTotal.Padding = new Padding(10, 0, 0, 0);
            lblRecordTotal.Size = new Size(80, 35);
            lblRecordTotal.TabIndex = 14;
            lblRecordTotal.Tag = "PlaceholderRecordsLabel";
            lblRecordTotal.Text = "€0.00";
            lblRecordTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRecordTypeVat
            // 
            lblRecordTypeVat.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordTypeVat.Location = new Point(33, 125);
            lblRecordTypeVat.Name = "lblRecordTypeVat";
            lblRecordTypeVat.Size = new Size(80, 35);
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
            lblTotal.Size = new Size(65, 28);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Totaal:";
            // 
            // lblTotalToPay
            // 
            lblTotalToPay.AutoSize = true;
            lblTotalToPay.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalToPay.Location = new Point(178, 303);
            lblTotalToPay.Name = "lblTotalToPay";
            lblTotalToPay.Size = new Size(180, 28);
            lblTotalToPay.TabIndex = 15;
            lblTotalToPay.Text = "Totaal af te rekenen:";
            // 
            // lblTotalToPayValue
            // 
            lblTotalToPayValue.AutoSize = true;
            lblTotalToPayValue.BackColor = SystemColors.Control;
            lblTotalToPayValue.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalToPayValue.ForeColor = SystemColors.ControlText;
            lblTotalToPayValue.Location = new Point(373, 303);
            lblTotalToPayValue.Name = "lblTotalToPayValue";
            lblTotalToPayValue.Size = new Size(72, 30);
            lblTotalToPayValue.TabIndex = 16;
            lblTotalToPayValue.Text = "€0.00";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblYear.Location = new Point(701, 74);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(100, 38);
            lblYear.TabIndex = 1;
            lblYear.Text = "Jaartal:";
            // 
            // listViewGeneral
            // 
            listViewGeneral.FullRowSelect = true;
            listViewGeneral.GridLines = true;
            listViewGeneral.Location = new Point(15, 70);
            listViewGeneral.Name = "listViewGeneral";
            listViewGeneral.Size = new Size(875, 347);
            listViewGeneral.TabIndex = 1;
            listViewGeneral.UseCompatibleStateImageBehavior = false;
            listViewGeneral.View = View.Details;
            // 
            // listViewPanelProducts
            // 
            listViewPanelProducts.FullRowSelect = true;
            listViewPanelProducts.Location = new Point(15, 60);
            listViewPanelProducts.Name = "listViewPanelProducts";
            listViewPanelProducts.Size = new Size(700, 400);
            listViewPanelProducts.TabIndex = 0;
            listViewPanelProducts.UseCompatibleStateImageBehavior = false;
            listViewPanelProducts.View = View.Details;
            listViewPanelProducts.SelectedIndexChanged += listViewPanelProducts_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, teachersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, productsToolStripMenuItem, ordersToolStripMenuItem, revenueToolStripMenuItem, vatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1374, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
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
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new Size(84, 29);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(98, 29);
            productsToolStripMenuItem.Text = "Products";
            productsToolStripMenuItem.Click += productsToolStripMenuItem_Click;
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
            revenueToolStripMenuItem.Size = new Size(94, 29);
            revenueToolStripMenuItem.Text = "Revenue";
            revenueToolStripMenuItem.Click += revenueToolStripMenuItem_Click;
            // 
            // vatToolStripMenuItem
            // 
            vatToolStripMenuItem.Name = "vatToolStripMenuItem";
            vatToolStripMenuItem.Size = new Size(58, 29);
            vatToolStripMenuItem.Text = "VAT";
            vatToolStripMenuItem.Click += vatToolStripMenuItem_Click;
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
            // ordersComboBox
            // 
            ordersComboBox.Location = new Point(190, 80);
            ordersComboBox.Margin = new Padding(4);
            ordersComboBox.Name = "ordersComboBox";
            ordersComboBox.Size = new Size(400, 33);
            ordersComboBox.TabIndex = 1;
            ordersComboBox.SelectedIndexChanged += ordersComboBox_SelectedIndexChanged;
            // 
            // ordersComboBoxLabel
            // 
            ordersComboBoxLabel.AutoSize = true;
            ordersComboBoxLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ordersComboBoxLabel.Location = new Point(15, 80);
            ordersComboBoxLabel.Name = "ordersComboBoxLabel";
            ordersComboBoxLabel.Size = new Size(161, 28);
            ordersComboBoxLabel.TabIndex = 0;
            ordersComboBoxLabel.Text = "Selecteer leerling";
            // 
            // outputRevenue
            // 
            outputRevenue.AutoSize = true;
            outputRevenue.Location = new Point(15, 184);
            outputRevenue.Name = "outputRevenue";
            outputRevenue.Size = new Size(0, 25);
            outputRevenue.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1200, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 164);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pnlActivities
            // 
            pnlActivities.Location = new Point(15, 31);
            pnlActivities.Name = "pnlActivities";
            pnlActivities.Size = new Size(1340, 660);
            pnlActivities.TabIndex = 2;
            // 
            // pnlActivityParticipants
            // 
            pnlActivityParticipants.Controls.Add(unassignedStudentsLabel);
            pnlActivityParticipants.Controls.Add(assignedStudentsLabel);
            pnlActivityParticipants.Controls.Add(activityParticipantUnassignButton);
            pnlActivityParticipants.Controls.Add(activityParticipantAssignButton);
            pnlActivityParticipants.Controls.Add(activityParticipantsAssigned);
            pnlActivityParticipants.Controls.Add(activityParticipantsUnassigned);
            pnlActivityParticipants.Controls.Add(activityParticipantsList);
            pnlActivityParticipants.Location = new Point(15, 31);
            pnlActivityParticipants.Name = "pnlActivityParticipants";
            pnlActivityParticipants.Size = new Size(1340, 660);
            pnlActivityParticipants.TabIndex = 2;
            // 
            // assignedStudentsLabel
            // 
            assignedStudentsLabel.AutoSize = true;
            assignedStudentsLabel.Location = new Point(11, 243);
            assignedStudentsLabel.Name = "assignedStudentsLabel";
            assignedStudentsLabel.Size = new Size(146, 25);
            assignedStudentsLabel.TabIndex = 5;
            assignedStudentsLabel.Text = "Not participating";
            // 
            // activityParticipantUnassignButton
            // 
            activityParticipantUnassignButton.Enabled = false;
            activityParticipantUnassignButton.Location = new Point(456, 426);
            activityParticipantUnassignButton.Name = "activityParticipantUnassignButton";
            activityParticipantUnassignButton.Size = new Size(60, 34);
            activityParticipantUnassignButton.TabIndex = 4;
            activityParticipantUnassignButton.Text = "<";
            activityParticipantUnassignButton.UseVisualStyleBackColor = true;
            activityParticipantUnassignButton.Click += activityParticipantUnassignButton_Click;
            // 
            // activityParticipantAssignButton
            // 
            activityParticipantAssignButton.Enabled = false;
            activityParticipantAssignButton.Location = new Point(456, 383);
            activityParticipantAssignButton.Name = "activityParticipantAssignButton";
            activityParticipantAssignButton.Size = new Size(60, 34);
            activityParticipantAssignButton.TabIndex = 3;
            activityParticipantAssignButton.Text = ">";
            activityParticipantAssignButton.UseVisualStyleBackColor = true;
            activityParticipantAssignButton.Click += activityParticipantAssignButton_Click;
            // 
            // activityParticipantsAssigned
            // 
            activityParticipantsAssigned.FullRowSelect = true;
            activityParticipantsAssigned.Location = new Point(548, 271);
            activityParticipantsAssigned.Name = "activityParticipantsAssigned";
            activityParticipantsAssigned.Size = new Size(405, 320);
            activityParticipantsAssigned.TabIndex = 2;
            activityParticipantsAssigned.UseCompatibleStateImageBehavior = false;
            activityParticipantsAssigned.View = View.Details;
            activityParticipantsAssigned.SelectedIndexChanged += activityParticipantsAssigned_SelectedIndexChanged;
            // 
            // activityParticipantsUnassigned
            // 
            activityParticipantsUnassigned.FullRowSelect = true;
            activityParticipantsUnassigned.Location = new Point(15, 271);
            activityParticipantsUnassigned.Name = "activityParticipantsUnassigned";
            activityParticipantsUnassigned.Size = new Size(405, 320);
            activityParticipantsUnassigned.TabIndex = 1;
            activityParticipantsUnassigned.UseCompatibleStateImageBehavior = false;
            activityParticipantsUnassigned.View = View.Details;
            activityParticipantsUnassigned.SelectedIndexChanged += activityParticipantsUnassigned_SelectedIndexChanged;
            // 
            // activityParticipantsList
            // 
            activityParticipantsList.FullRowSelect = true;
            activityParticipantsList.GridLines = true;
            activityParticipantsList.Location = new Point(15, 70);
            activityParticipantsList.Name = "activityParticipantsList";
            activityParticipantsList.Size = new Size(938, 143);
            activityParticipantsList.TabIndex = 1;
            activityParticipantsList.UseCompatibleStateImageBehavior = false;
            activityParticipantsList.View = View.Details;
            activityParticipantsList.SelectedIndexChanged += activityParticipantsList_SelectedIndexChanged;
            // 
            // pnlActivitySupervisors
            // 
            pnlActivitySupervisors.Location = new Point(15, 31);
            pnlActivitySupervisors.Name = "pnlActivitySupervisors";
            pnlActivitySupervisors.Size = new Size(1340, 660);
            pnlActivitySupervisors.TabIndex = 2;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new Point(15, 45);
            pnlDashboard.Margin = new Padding(4, 5, 4, 5);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(1340, 776);
            pnlDashboard.TabIndex = 1;
            // 
            // pnlOrders
            // 
            pnlOrders.Controls.Add(ordersComboBoxLabel);
            pnlOrders.Controls.Add(ordersComboBox);
            pnlOrders.Controls.Add(orderDetailsLabel);
            pnlOrders.Controls.Add(orderProcessButton);
            pnlOrders.Location = new Point(18, 39);
            pnlOrders.Margin = new Padding(4);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(1340, 660);
            pnlOrders.TabIndex = 2;
            // 
            // pnlProducts
            // 
            pnlProducts.Controls.Add(productEditButton);
            pnlProducts.Controls.Add(productEditPriceInput);
            pnlProducts.Controls.Add(productEditPriceLabel);
            pnlProducts.Controls.Add(productEditAlcoholInput);
            pnlProducts.Controls.Add(productEditStockInput);
            pnlProducts.Controls.Add(productEditStockLabel);
            pnlProducts.Controls.Add(productEditNameInput);
            pnlProducts.Controls.Add(productEditNameLabel);
            pnlProducts.Controls.Add(listViewPanelProducts);
            pnlProducts.Controls.Add(productDeleteButton);
            pnlProducts.Location = new Point(15, 31);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new Size(1072, 528);
            pnlProducts.TabIndex = 2;
            // 
            // productEditButton
            // 
            productEditButton.Location = new Point(745, 249);
            productEditButton.Name = "productEditButton";
            productEditButton.Size = new Size(94, 35);
            productEditButton.TabIndex = 10;
            productEditButton.Text = "Create";
            productEditButton.UseVisualStyleBackColor = true;
            productEditButton.Click += productEditButton_Click;
            // 
            // productEditPriceInput
            // 
            productEditPriceInput.DecimalPlaces = 2;
            productEditPriceInput.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            productEditPriceInput.Location = new Point(800, 193);
            productEditPriceInput.Name = "productEditPriceInput";
            productEditPriceInput.Size = new Size(125, 31);
            productEditPriceInput.TabIndex = 9;
            // 
            // productEditPriceLabel
            // 
            productEditPriceLabel.AutoSize = true;
            productEditPriceLabel.Location = new Point(745, 195);
            productEditPriceLabel.Name = "productEditPriceLabel";
            productEditPriceLabel.Size = new Size(49, 25);
            productEditPriceLabel.TabIndex = 8;
            productEditPriceLabel.Text = "Price";
            // 
            // productEditAlcoholInput
            // 
            productEditAlcoholInput.AutoSize = true;
            productEditAlcoholInput.CheckAlign = ContentAlignment.MiddleRight;
            productEditAlcoholInput.Location = new Point(745, 157);
            productEditAlcoholInput.Name = "productEditAlcoholInput";
            productEditAlcoholInput.Size = new Size(110, 29);
            productEditAlcoholInput.TabIndex = 7;
            productEditAlcoholInput.Text = "Alcoholic";
            productEditAlcoholInput.UseVisualStyleBackColor = true;
            // 
            // productEditStockInput
            // 
            productEditStockInput.Location = new Point(800, 107);
            productEditStockInput.Name = "productEditStockInput";
            productEditStockInput.Size = new Size(125, 31);
            productEditStockInput.TabIndex = 5;
            // 
            // productEditStockLabel
            // 
            productEditStockLabel.AutoSize = true;
            productEditStockLabel.Location = new Point(745, 109);
            productEditStockLabel.Name = "productEditStockLabel";
            productEditStockLabel.Size = new Size(55, 25);
            productEditStockLabel.TabIndex = 4;
            productEditStockLabel.Text = "Stock";
            // 
            // productEditNameInput
            // 
            productEditNameInput.Location = new Point(800, 57);
            productEditNameInput.Name = "productEditNameInput";
            productEditNameInput.Size = new Size(125, 31);
            productEditNameInput.TabIndex = 3;
            // 
            // productEditNameLabel
            // 
            productEditNameLabel.AutoSize = true;
            productEditNameLabel.Location = new Point(745, 60);
            productEditNameLabel.Name = "productEditNameLabel";
            productEditNameLabel.Size = new Size(59, 25);
            productEditNameLabel.TabIndex = 2;
            productEditNameLabel.Text = "Name";
            // 
            // productDeleteButton
            // 
            productDeleteButton.Location = new Point(859, 249);
            productDeleteButton.Name = "productDeleteButton";
            productDeleteButton.Size = new Size(94, 35);
            productDeleteButton.TabIndex = 1;
            productDeleteButton.Text = "Delete";
            productDeleteButton.Visible = false;
            productDeleteButton.Click += DeleteProductButton_Click;
            // 
            // pnlRevenue
            // 
            pnlRevenue.Controls.Add(outputRevenue);
            pnlRevenue.Controls.Add(endDatePickerLabel1);
            pnlRevenue.Controls.Add(startDatePickerLabel1);
            pnlRevenue.Controls.Add(revenueDateStart);
            pnlRevenue.Controls.Add(revenueDateEnd);
            pnlRevenue.Location = new Point(15, 31);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new Size(1072, 528);
            pnlRevenue.TabIndex = 2;
            // 
            // startDatePickerLabel1
            // 
            startDatePickerLabel1.AutoSize = true;
            startDatePickerLabel1.Location = new Point(15, 68);
            startDatePickerLabel1.Name = "startDatePickerLabel1";
            startDatePickerLabel1.Size = new Size(92, 25);
            startDatePickerLabel1.TabIndex = 1;
            startDatePickerLabel1.Text = "Start date:";
            // 
            // revenueDateStart
            // 
            revenueDateStart.CustomFormat = "dd MMM yyyy";
            revenueDateStart.Format = DateTimePickerFormat.Custom;
            revenueDateStart.Location = new Point(15, 100);
            revenueDateStart.MaxDate = new DateTime(2024, 3, 26, 0, 0, 0, 0);
            revenueDateStart.Name = "revenueDateStart";
            revenueDateStart.Size = new Size(200, 31);
            revenueDateStart.TabIndex = 0;
            revenueDateStart.Value = new DateTime(2024, 3, 26, 0, 0, 0, 0);
            revenueDateStart.ValueChanged += UpdateRevenueSelector;
            // 
            // revenueDateEnd
            // 
            revenueDateEnd.CustomFormat = "dd MMM yyyy";
            revenueDateEnd.Format = DateTimePickerFormat.Custom;
            revenueDateEnd.Location = new Point(400, 100);
            revenueDateEnd.MaxDate = new DateTime(2024, 3, 26, 0, 0, 0, 0);
            revenueDateEnd.Name = "revenueDateEnd";
            revenueDateEnd.Size = new Size(200, 31);
            revenueDateEnd.TabIndex = 0;
            revenueDateEnd.Value = new DateTime(2024, 3, 26, 0, 0, 0, 0);
            revenueDateEnd.ValueChanged += UpdateRevenueSelector;
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(listViewGeneral);
            pnlRooms.Location = new Point(15, 31);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new Size(1340, 660);
            pnlRooms.TabIndex = 2;
            // 
            // pnlStudents
            // 
            pnlStudents.Location = new Point(15, 31);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new Size(1340, 660);
            pnlStudents.TabIndex = 2;
            // 
            // pnlTeachers
            // 
            pnlTeachers.Location = new Point(15, 31);
            pnlTeachers.Name = "pnlTeachers";
            pnlTeachers.Size = new Size(1340, 660);
            pnlTeachers.TabIndex = 2;
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
            pnlVat.Controls.Add(lblVatType);
            pnlVat.Controls.Add(gbQuarter);
            pnlVat.Controls.Add(lblYear);
            pnlVat.Controls.Add(txtYear);
            pnlVat.Controls.Add(lblDates);
            pnlVat.Location = new Point(30, 80);
            pnlVat.Name = "pnlVat";
            pnlVat.Size = new Size(886, 347);
            pnlVat.TabIndex = 1;
            // 
            // txtYear
            // 
            txtYear.AllowDrop = true;
            txtYear.Location = new Point(701, 108);
            txtYear.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 31);
            txtYear.TabIndex = 2;
            txtYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            txtYear.ValueChanged += DisplayVat;
            // 
            // unassignedStudentsLabel
            // 
            unassignedStudentsLabel.AutoSize = true;
            unassignedStudentsLabel.Location = new Point(548, 243);
            unassignedStudentsLabel.Name = "unassignedStudentsLabel";
            unassignedStudentsLabel.Size = new Size(59, 25);
            unassignedStudentsLabel.TabIndex = 6;
            unassignedStudentsLabel.Text = "Participating";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 841);
            Controls.Add(pnlActivityParticipants);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlStudents);
            Controls.Add(pnlTeachers);
            Controls.Add(pnlActivities);
            Controls.Add(pnlActivitySupervisors);
            Controls.Add(pnlRooms);
            Controls.Add(pnlProducts);
            Controls.Add(pnlOrders);
            Controls.Add(pnlRevenue);
            Controls.Add(pnlVat);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "SomerenUI";
            Text = "SomerenApp";
            Load += SomerenUI_Load;
            gbQuarter.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlActivityParticipants.ResumeLayout(false);
            pnlActivityParticipants.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlOrders.ResumeLayout(false);
            pnlOrders.PerformLayout();
            pnlProducts.ResumeLayout(false);
            pnlProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productEditPriceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)productEditStockInput).EndInit();
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            pnlRooms.ResumeLayout(false);
            pnlVat.ResumeLayout(false);
            pnlVat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQ1;
        private Button btnQ2;
        private Button btnQ3;
        private Button btnQ4;
        private Button orderProcessButton;
        private Button productDeleteButton;
        private Button productEditButton;
        private CheckBox productEditAlcoholInput;
        private ComboBox ordersComboBox;
        private DateTimePicker revenueDateEnd;
        private DateTimePicker revenueDateStart;
        private FlowLayoutPanel flowLayoutPanelOrderProducts;
        private GroupBox gbQuarter;
        private Label lblVatType;
        private Label endDatePickerLabel1;
        private Label headerLabel;
        private Label lblDashboard;
        private Label lblDates;
        private Label lblOrders;
        private Label lblPercentage;
        private Label lblProducts;
        private Label lblRecordOrders;
        private Label lblRecordPercentage;
        private Label lblRecordProducts;
        private Label lblRecordTotal;
        private Label lblRecordTypeVat;
        private Label lblTotal;
        private Label lblTotalToPay;
        private Label lblTotalToPayValue;
        private Label lblYear;
        private Label orderDetailsLabel;
        private Label ordersComboBoxLabel;
        private Label outputRevenue;
        private Label productEditNameLabel;
        private Label productEditPriceLabel;
        private Label productEditStockLabel;
        private Label startDatePickerLabel1;
        private ListView listViewGeneral;
        private ListView listViewPanelProducts;
        private MenuStrip menuStrip1;
        private NumericUpDown productEditPriceInput;
        private NumericUpDown productEditStockInput;
        private Panel pnlActivities;
        private Panel pnlActivityParticipants;
        private Panel pnlActivitySupervisors;
        private Panel pnlDashboard;
        private Panel pnlOrders;
        private Panel pnlProducts;
        private Panel pnlRevenue;
        private Panel pnlRooms;
        private Panel pnlStudents;
        private Panel pnlTeachers;
        private Panel pnlVat;
        private PictureBox pictureBox1;
        private TextBox productEditNameInput;
        private NumericUpDown txtYear;
        private ToolStripMenuItem activitiesToolStripMenuItem;
        private ToolStripMenuItem activitiesToolStripMenuItem1;
        private ToolStripMenuItem activityParticipantsToolStripMenuItem;
        private ToolStripMenuItem activitySupervisorsToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem ordersToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem revenueToolStripMenuItem;
        private ToolStripMenuItem roomsToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem teachersToolStripMenuItem;
        private ToolStripMenuItem vatToolStripMenuItem;
        private Button activityParticipantAssignButton;
        private ListView activityParticipantsAssigned;
        private ListView activityParticipantsUnassigned;
        private ListView activityParticipantsList;
        private Button activityParticipantUnassignButton;
        private Label assignedStudentsLabel;
        private Label unassignedStudentsLabel;
    }
}

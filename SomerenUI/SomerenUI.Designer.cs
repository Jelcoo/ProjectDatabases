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
            listViewPanelStudents = new ListView();
            listViewPanelteachers = new ListView();
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
            unassignedStudentsLabel = new Label();
            assignedStudentsLabel = new Label();
            unassignedStudentsLabel = new Label();
            activityParticipantUnassignButton = new Button();
            activityParticipantAssignButton = new Button();
            activityParticipantsAssigned = new ListView();
            activityParticipantsUnassigned = new ListView();
            activityParticipantsList = new ListView();
            pnlActivitySupervisors = new Panel();
            lblAssignedSupervisor = new Label();
            lblUnassignedSupervisor = new Label();
            activitySupervisorUnassignButton = new Button();
            activitySupervisorAssignButton = new Button();
            activitySupervisorsAssigned = new ListView();
            activitySupervisorsUnassigned = new ListView();
            activitySupervisorsList = new ListView();
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
            teacherEditButton = new Button();
            teacherEditFirstNameInput = new TextBox();
            teacherEditRoomSelect = new ComboBox();
            teacherEditPhoneNumberInput = new NumericUpDown();
            teacherEditDateOfBirthInput = new DateTimePicker();
            teacherEditLastNameInput = new TextBox();
            teacherEditFirstNameLabel = new Label();
            teachersDeleteButton = new Button();
            pnlRevenue = new Panel();
            startDatePickerLabel1 = new Label();
            revenueDateStart = new DateTimePicker();
            revenueDateEnd = new DateTimePicker();
            pnlRooms = new Panel();
            pnlStudents = new Panel();
            studentEditRoomSelect = new ComboBox();
            studentEditRoomLabel = new Label();
            studentEditVouchersNumerric = new NumericUpDown();
            studentEditVouchersLabel = new Label();
            studentEditClassInput = new TextBox();
            studentEditClassLabel = new Label();
            studentEditPhoneNumberInput = new NumericUpDown();
            studentEditPhoneNumberLabel = new Label();
            studentEditLastNameInput = new TextBox();
            label1studentEditLastNameLabel = new Label();
            studentEditButton = new Button();
            studentEditFirstNameLabel = new Label();
            studentDeleteButton = new Button();
            pnlTeachers = new Panel();
            pnlVat = new Panel();
            txtYear = new NumericUpDown();
            teacherEditLastNameLabel = new Label();
            teacherEditPhoneNumberLabel = new Label();
            teacherEditDateOfBirthLabel = new Label();
            teacherEditRoomIdLabel = new Label();
            studentEditFirstNameInput = new TextBox();
            gbQuarter.SuspendLayout();
            menuStrip1.SuspendLayout();
            pnlActivityParticipants.SuspendLayout();
            pnlActivitySupervisors.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlOrders.SuspendLayout();
            pnlProducts.SuspendLayout();
            pnlRevenue.SuspendLayout();
            pnlRooms.SuspendLayout();
            pnlStudents.SuspendLayout();
            pnlTeachers.SuspendLayout();
            pnlVat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productEditPriceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productEditStockInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtYear).BeginInit();
            SuspendLayout();
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { activitiesToolStripMenuItem1, activityParticipantsToolStripMenuItem, activitySupervisorsToolStripMenuItem });
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new Size(83, 24);
            activitiesToolStripMenuItem.Text = "Activities";
            // 
            // activitiesToolStripMenuItem1
            // 
            activitiesToolStripMenuItem1.Name = "activitiesToolStripMenuItem1";
            activitiesToolStripMenuItem1.Size = new Size(169, 26);
            activitiesToolStripMenuItem1.Text = "Activities";
            activitiesToolStripMenuItem1.Click += activitiesToolStripMenuItem1_Click;
            // 
            // activityParticipantsToolStripMenuItem
            // 
            activityParticipantsToolStripMenuItem.Name = "activityParticipantsToolStripMenuItem";
            activityParticipantsToolStripMenuItem.Size = new Size(169, 26);
            activityParticipantsToolStripMenuItem.Text = "Participants";
            activityParticipantsToolStripMenuItem.Click += activityParticipantsToolStripMenuItem_Click;
            // 
            // activitySupervisorsToolStripMenuItem
            // 
            activitySupervisorsToolStripMenuItem.Name = "activitySupervisorsToolStripMenuItem";
            activitySupervisorsToolStripMenuItem.Size = new Size(169, 26);
            activitySupervisorsToolStripMenuItem.Text = "Supervisors";
            activitySupervisorsToolStripMenuItem.Click += activitySupervisorsToolStripMenuItem_Click;
            // 
            // lblVatType
            // 
            lblVatType.AutoSize = true;
            lblVatType.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblVatType.Location = new Point(17, 55);
            lblVatType.Margin = new Padding(2, 0, 2, 0);
            lblVatType.Name = "lblVatType";
            lblVatType.Size = new Size(87, 23);
            lblVatType.TabIndex = 9;
            lblVatType.Text = "Type BTW:";
            // 
            // btnQ1
            // 
            btnQ1.BackColor = Color.IndianRed;
            btnQ1.Font = new Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ1.ForeColor = SystemColors.ControlText;
            btnQ1.Location = new Point(5, 37);
            btnQ1.Margin = new Padding(2);
            btnQ1.Name = "btnQ1";
            btnQ1.Size = new Size(62, 47);
            btnQ1.TabIndex = 4;
            btnQ1.Tag = "Q1";
            btnQ1.Text = "Q1";
            btnQ1.UseVisualStyleBackColor = false;
            btnQ1.Click += btnQ1_Click;
            // 
            // btnQ2
            // 
            btnQ2.BackColor = Color.Orange;
            btnQ2.Font = new Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ2.ForeColor = SystemColors.ControlText;
            btnQ2.Location = new Point(64, 37);
            btnQ2.Margin = new Padding(2);
            btnQ2.Name = "btnQ2";
            btnQ2.Size = new Size(63, 47);
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
            btnQ3.Location = new Point(5, 89);
            btnQ3.Margin = new Padding(2);
            btnQ3.Name = "btnQ3";
            btnQ3.Size = new Size(62, 47);
            btnQ3.TabIndex = 6;
            btnQ3.Tag = "Q3";
            btnQ3.Text = "Q3";
            btnQ3.UseVisualStyleBackColor = false;
            btnQ3.Click += btnQ3_Click;
            // 
            // btnQ4
            // 
            btnQ4.BackColor = Color.SlateBlue;
            btnQ4.Font = new Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnQ4.ForeColor = SystemColors.ControlText;
            btnQ4.Location = new Point(64, 89);
            btnQ4.Margin = new Padding(2);
            btnQ4.Name = "btnQ4";
            btnQ4.Size = new Size(63, 47);
            btnQ4.TabIndex = 7;
            btnQ4.Tag = "Q4";
            btnQ4.Text = "Q4";
            btnQ4.UseVisualStyleBackColor = false;
            btnQ4.Click += btnQ4_Click;
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(100, 24);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new Size(165, 26);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(165, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // endDatePickerLabel1
            // 
            endDatePickerLabel1.AutoSize = true;
            endDatePickerLabel1.Location = new Point(318, 46);
            endDatePickerLabel1.Margin = new Padding(2, 0, 2, 0);
            endDatePickerLabel1.Name = "endDatePickerLabel1";
            endDatePickerLabel1.Size = new Size(72, 17);
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
            gbQuarter.Location = new Point(561, 118);
            gbQuarter.Margin = new Padding(2);
            gbQuarter.Name = "gbQuarter";
            gbQuarter.Padding = new Padding(2);
            gbQuarter.Size = new Size(132, 142);
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
            lblDashboard.Location = new Point(12, 18);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(262, 20);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // lblDates
            // 
            lblDates.Font = new Font("Segoe UI Semilight", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblDates.Location = new Point(10, 9);
            lblDates.Margin = new Padding(2, 0, 2, 0);
            lblDates.Name = "lblDates";
            lblDates.Size = new Size(994, 52);
            lblDates.TabIndex = 0;
            lblDates.Text = "Selecteer een tijdstip";
            // 
            // lblOrders
            // 
            lblOrders.AutoSize = true;
            lblOrders.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrders.Location = new Point(170, 65);
            lblOrders.Margin = new Padding(2, 0, 2, 0);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(65, 23);
            lblOrders.TabIndex = 17;
            lblOrders.Text = "Orders:";
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPercentage.Location = new Point(91, 65);
            lblPercentage.Margin = new Padding(2, 0, 2, 0);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(96, 23);
            lblPercentage.TabIndex = 10;
            lblPercentage.Text = "Percentage:";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblProducts.Location = new Point(222, 65);
            lblProducts.Margin = new Padding(2, 0, 2, 0);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(89, 23);
            lblProducts.TabIndex = 19;
            lblProducts.Text = "Producten:";
            // 
            // lblRecordOrders
            // 
            lblRecordOrders.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordOrders.Location = new Point(183, 100);
            lblRecordOrders.Margin = new Padding(2, 0, 2, 0);
            lblRecordOrders.Name = "lblRecordOrders";
            lblRecordOrders.Size = new Size(64, 28);
            lblRecordOrders.TabIndex = 18;
            lblRecordOrders.Tag = "PlaceholderRecordsLabel";
            lblRecordOrders.Text = "0";
            lblRecordOrders.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRecordPercentage
            // 
            lblRecordPercentage.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordPercentage.Location = new Point(114, 100);
            lblRecordPercentage.Margin = new Padding(2, 0, 2, 0);
            lblRecordPercentage.Name = "lblRecordPercentage";
            lblRecordPercentage.Size = new Size(64, 28);
            lblRecordPercentage.TabIndex = 13;
            lblRecordPercentage.Tag = "PlaceholderRecordsLabel";
            lblRecordPercentage.Text = "0%";
            lblRecordPercentage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRecordProducts
            // 
            lblRecordProducts.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordProducts.Location = new Point(246, 100);
            lblRecordProducts.Margin = new Padding(2, 0, 2, 0);
            lblRecordProducts.Name = "lblRecordProducts";
            lblRecordProducts.Size = new Size(64, 28);
            lblRecordProducts.TabIndex = 20;
            lblRecordProducts.Tag = "PlaceholderRecordsLabel";
            lblRecordProducts.Text = "0";
            lblRecordProducts.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRecordTotal
            // 
            lblRecordTotal.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordTotal.Location = new Point(298, 100);
            lblRecordTotal.Margin = new Padding(2, 0, 2, 0);
            lblRecordTotal.Name = "lblRecordTotal";
            lblRecordTotal.Padding = new Padding(8, 0, 0, 0);
            lblRecordTotal.Size = new Size(64, 28);
            lblRecordTotal.TabIndex = 14;
            lblRecordTotal.Tag = "PlaceholderRecordsLabel";
            lblRecordTotal.Text = "€0.00";
            lblRecordTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRecordTypeVat
            // 
            lblRecordTypeVat.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordTypeVat.Location = new Point(26, 100);
            lblRecordTypeVat.Margin = new Padding(2, 0, 2, 0);
            lblRecordTypeVat.Name = "lblRecordTypeVat";
            lblRecordTypeVat.Size = new Size(64, 28);
            lblRecordTypeVat.TabIndex = 12;
            lblRecordTypeVat.Tag = "PlaceholderRecordsLabel";
            lblRecordTypeVat.Text = "Overig";
            lblRecordTypeVat.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(298, 65);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 23);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Totaal:";
            // 
            // lblTotalToPay
            // 
            lblTotalToPay.AutoSize = true;
            lblTotalToPay.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalToPay.Location = new Point(142, 242);
            lblTotalToPay.Margin = new Padding(2, 0, 2, 0);
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
            lblTotalToPayValue.Location = new Point(298, 242);
            lblTotalToPayValue.Margin = new Padding(2, 0, 2, 0);
            lblTotalToPayValue.Name = "lblTotalToPayValue";
            lblTotalToPayValue.Size = new Size(55, 23);
            lblTotalToPayValue.TabIndex = 16;
            lblTotalToPayValue.Text = "€0.00";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblYear.Location = new Point(561, 59);
            lblYear.Margin = new Padding(2, 0, 2, 0);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(84, 31);
            lblYear.TabIndex = 1;
            lblYear.Text = "Jaartal:";
            // 
            // listViewGeneral
            // 
            listViewGeneral.FullRowSelect = true;
            listViewGeneral.GridLines = true;
            listViewGeneral.Location = new Point(12, 56);
            listViewGeneral.Margin = new Padding(2);
            listViewGeneral.Name = "listViewGeneral";
            listViewGeneral.Size = new Size(701, 278);
            listViewGeneral.TabIndex = 1;
            listViewGeneral.UseCompatibleStateImageBehavior = false;
            listViewGeneral.View = View.Details;
            // 
            // listViewPanelProducts
            // 
            listViewPanelProducts.FullRowSelect = true;
            listViewPanelProducts.Location = new Point(12, 41);
            listViewPanelProducts.Margin = new Padding(2);
            listViewPanelProducts.Name = "listViewPanelProducts";
            listViewPanelProducts.Size = new Size(561, 321);
            listViewPanelProducts.TabIndex = 0;
            listViewPanelProducts.UseCompatibleStateImageBehavior = false;
            listViewPanelProducts.View = View.Details;
            listViewPanelProducts.SelectedIndexChanged += listViewPanelProducts_SelectedIndexChanged;
            //
            // listViewPanelStudents
            //
            listViewPanelStudents.FullRowSelect = true;
            listViewPanelStudents.Location = new Point(12, 48);
            listViewPanelStudents.Margin = new Padding(2);
            listViewPanelStudents.Name = "listViewPanelStudents";
            listViewPanelStudents.Size = new Size(561, 321);
            listViewPanelStudents.TabIndex = 0;
            listViewPanelStudents.UseCompatibleStateImageBehavior = false;
            listViewPanelStudents.View = View.Details;
            listViewPanelStudents.SelectedIndexChanged += listViewPanelStudents_SelectedIndexChanged;
            //
            // listViewPanelteachers
            // 
            listViewPanelteachers.FullRowSelect = true;
            listViewPanelteachers.Location = new Point(12, 48);
            listViewPanelteachers.Margin = new Padding(2);
            listViewPanelteachers.Name = "listViewPanelteachers";
            listViewPanelteachers.Size = new Size(561, 321);
            listViewPanelteachers.TabIndex = 0;
            listViewPanelteachers.UseCompatibleStateImageBehavior = false;
            listViewPanelteachers.View = View.Details;
            listViewPanelteachers.SelectedIndexChanged += listViewPanelTeachers_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, teachersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, productsToolStripMenuItem, ordersToolStripMenuItem, revenueToolStripMenuItem, vatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1099, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(80, 24);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // teachersToolStripMenuItem
            // 
            teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            teachersToolStripMenuItem.Size = new Size(80, 24);
            teachersToolStripMenuItem.Text = "Teachers";
            teachersToolStripMenuItem.Click += teachersToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new Size(69, 24);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(80, 24);
            productsToolStripMenuItem.Text = "Products";
            productsToolStripMenuItem.Click += productsToolStripMenuItem_Click;
            // 
            // ordersToolStripMenuItem
            // 
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new Size(67, 24);
            ordersToolStripMenuItem.Text = "Orders";
            ordersToolStripMenuItem.Click += ordersToolStripMenuItem_Click;
            // 
            // revenueToolStripMenuItem
            // 
            revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            revenueToolStripMenuItem.Size = new Size(79, 24);
            revenueToolStripMenuItem.Text = "Revenue";
            revenueToolStripMenuItem.Click += revenueToolStripMenuItem_Click;
            // 
            // vatToolStripMenuItem
            // 
            vatToolStripMenuItem.Name = "vatToolStripMenuItem";
            vatToolStripMenuItem.Size = new Size(48, 24);
            vatToolStripMenuItem.Text = "VAT";
            vatToolStripMenuItem.Click += vatToolStripMenuItem_Click;
            // 
            // orderDetailsLabel
            // 
            orderDetailsLabel.AutoSize = true;
            orderDetailsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            orderDetailsLabel.Location = new Point(520, 64);
            orderDetailsLabel.Margin = new Padding(2, 0, 2, 0);
            orderDetailsLabel.Name = "orderDetailsLabel";
            orderDetailsLabel.Size = new Size(0, 23);
            orderDetailsLabel.TabIndex = 0;
            // 
            // orderProcessButton
            // 
            orderProcessButton.Location = new Point(520, 320);
            orderProcessButton.Margin = new Padding(2);
            orderProcessButton.Name = "orderProcessButton";
            orderProcessButton.Size = new Size(160, 32);
            orderProcessButton.TabIndex = 2;
            orderProcessButton.Text = "Process Order";
            orderProcessButton.Visible = false;
            orderProcessButton.MouseClick += orderProcessButton_Click;
            // 
            // ordersComboBox
            // 
            ordersComboBox.Location = new Point(152, 64);
            ordersComboBox.Name = "ordersComboBox";
            ordersComboBox.Size = new Size(321, 28);
            ordersComboBox.TabIndex = 1;
            ordersComboBox.SelectedIndexChanged += ordersComboBox_SelectedIndexChanged;
            // 
            // ordersComboBoxLabel
            // 
            ordersComboBoxLabel.AutoSize = true;
            ordersComboBoxLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ordersComboBoxLabel.Location = new Point(12, 64);
            ordersComboBoxLabel.Margin = new Padding(2, 0, 2, 0);
            ordersComboBoxLabel.Name = "ordersComboBoxLabel";
            ordersComboBoxLabel.Size = new Size(140, 23);
            ordersComboBoxLabel.TabIndex = 0;
            ordersComboBoxLabel.Text = "Selecteer leerling";
            // 
            // outputRevenue
            // 
            outputRevenue.AutoSize = true;
            outputRevenue.Location = new Point(12, 147);
            outputRevenue.Margin = new Padding(2, 0, 2, 0);
            outputRevenue.Name = "outputRevenue";
            outputRevenue.Size = new Size(0, 20);
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
            pnlActivities.Location = new Point(12, 25);
            pnlActivities.Margin = new Padding(2);
            pnlActivities.Name = "pnlActivities";
            pnlActivities.Size = new Size(1072, 528);
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
            pnlActivityParticipants.Location = new Point(12, 21);
            pnlActivityParticipants.Margin = new Padding(2);
            pnlActivityParticipants.Name = "pnlActivityParticipants";
            pnlActivityParticipants.Size = new Size(1072, 449);
            pnlActivityParticipants.TabIndex = 2;
            // 
            // unassignedStudentsLabel
            // 
            unassignedStudentsLabel.AutoSize = true;
            unassignedStudentsLabel.Location = new Point(438, 165);
            unassignedStudentsLabel.Margin = new Padding(2, 0, 2, 0);
            unassignedStudentsLabel.Name = "unassignedStudentsLabel";
            unassignedStudentsLabel.Size = new Size(91, 17);
            unassignedStudentsLabel.TabIndex = 6;
            unassignedStudentsLabel.Text = "Participating";
            // 
            // assignedStudentsLabel
            // 
            assignedStudentsLabel.AutoSize = true;
            assignedStudentsLabel.Location = new Point(9, 165);
            assignedStudentsLabel.Margin = new Padding(2, 0, 2, 0);
            assignedStudentsLabel.Name = "assignedStudentsLabel";
            assignedStudentsLabel.Size = new Size(119, 17);
            assignedStudentsLabel.TabIndex = 5;
            assignedStudentsLabel.Text = "Not participating";
            // 
            // activityParticipantUnassignButton
            // 
            activityParticipantUnassignButton.Enabled = false;
            activityParticipantUnassignButton.Location = new Point(365, 290);
            activityParticipantUnassignButton.Margin = new Padding(2);
            activityParticipantUnassignButton.Name = "activityParticipantUnassignButton";
            activityParticipantUnassignButton.Size = new Size(48, 23);
            activityParticipantUnassignButton.TabIndex = 4;
            activityParticipantUnassignButton.Text = "<";
            activityParticipantUnassignButton.UseVisualStyleBackColor = true;
            activityParticipantUnassignButton.Click += activityParticipantUnassignButton_Click;
            // 
            // activityParticipantAssignButton
            // 
            activityParticipantAssignButton.Enabled = false;
            activityParticipantAssignButton.Location = new Point(365, 260);
            activityParticipantAssignButton.Margin = new Padding(2);
            activityParticipantAssignButton.Name = "activityParticipantAssignButton";
            activityParticipantAssignButton.Size = new Size(48, 23);
            activityParticipantAssignButton.TabIndex = 3;
            activityParticipantAssignButton.Text = ">";
            activityParticipantAssignButton.UseVisualStyleBackColor = true;
            activityParticipantAssignButton.Click += activityParticipantAssignButton_Click;
            // 
            // activityParticipantsAssigned
            // 
            activityParticipantsAssigned.FullRowSelect = true;
            activityParticipantsAssigned.Location = new Point(438, 184);
            activityParticipantsAssigned.Margin = new Padding(2);
            activityParticipantsAssigned.Name = "activityParticipantsAssigned";
            activityParticipantsAssigned.Size = new Size(325, 219);
            activityParticipantsAssigned.TabIndex = 2;
            activityParticipantsAssigned.UseCompatibleStateImageBehavior = false;
            activityParticipantsAssigned.View = View.Details;
            activityParticipantsAssigned.SelectedIndexChanged += activityParticipantsAssigned_SelectedIndexChanged;
            // 
            // activityParticipantsUnassigned
            // 
            activityParticipantsUnassigned.FullRowSelect = true;
            activityParticipantsUnassigned.Location = new Point(12, 184);
            activityParticipantsUnassigned.Margin = new Padding(2);
            activityParticipantsUnassigned.Name = "activityParticipantsUnassigned";
            activityParticipantsUnassigned.Size = new Size(325, 219);
            activityParticipantsUnassigned.TabIndex = 1;
            activityParticipantsUnassigned.UseCompatibleStateImageBehavior = false;
            activityParticipantsUnassigned.View = View.Details;
            activityParticipantsUnassigned.SelectedIndexChanged += activityParticipantsUnassigned_SelectedIndexChanged;
            // 
            // activityParticipantsList
            // 
            activityParticipantsList.FullRowSelect = true;
            activityParticipantsList.GridLines = true;
            activityParticipantsList.Location = new Point(12, 48);
            activityParticipantsList.Margin = new Padding(2);
            activityParticipantsList.Name = "activityParticipantsList";
            activityParticipantsList.Size = new Size(751, 99);
            activityParticipantsList.TabIndex = 1;
            activityParticipantsList.UseCompatibleStateImageBehavior = false;
            activityParticipantsList.View = View.Details;
            activityParticipantsList.SelectedIndexChanged += activityParticipantsList_SelectedIndexChanged;
            // 
            // pnlActivitySupervisors
            // 
            pnlActivitySupervisors.Controls.Add(lblAssignedSupervisor);
            pnlActivitySupervisors.Controls.Add(lblUnassignedSupervisor);
            pnlActivitySupervisors.Controls.Add(activitySupervisorUnassignButton);
            pnlActivitySupervisors.Controls.Add(activitySupervisorAssignButton);
            pnlActivitySupervisors.Controls.Add(activitySupervisorsAssigned);
            pnlActivitySupervisors.Controls.Add(activitySupervisorsUnassigned);
            pnlActivitySupervisors.Controls.Add(activitySupervisorsList);
            pnlActivitySupervisors.Location = new Point(12, 21);
            pnlActivitySupervisors.Margin = new Padding(2);
            pnlActivitySupervisors.Name = "pnlActivitySupervisors";
            pnlActivitySupervisors.Size = new Size(1072, 449);
            pnlActivitySupervisors.TabIndex = 2;
            // 
            // lblAssignedSupervisor
            // 
            lblAssignedSupervisor.AutoSize = true;
            lblAssignedSupervisor.Location = new Point(440, 134);
            lblAssignedSupervisor.Margin = new Padding(2, 0, 2, 0);
            lblAssignedSupervisor.Name = "lblAssignedSupervisor";
            lblAssignedSupervisor.Size = new Size(91, 17);
            lblAssignedSupervisor.TabIndex = 13;
            lblAssignedSupervisor.Text = "Participating";
            // 
            // lblUnassignedSupervisor
            // 
            lblUnassignedSupervisor.AutoSize = true;
            lblUnassignedSupervisor.Location = new Point(11, 134);
            lblUnassignedSupervisor.Margin = new Padding(2, 0, 2, 0);
            lblUnassignedSupervisor.Name = "lblUnassignedSupervisor";
            lblUnassignedSupervisor.Size = new Size(119, 17);
            lblUnassignedSupervisor.TabIndex = 12;
            lblUnassignedSupervisor.Text = "Not participating";
            // 
            // activitySupervisorUnassignButton
            // 
            activitySupervisorUnassignButton.Enabled = false;
            activitySupervisorUnassignButton.Location = new Point(367, 259);
            activitySupervisorUnassignButton.Margin = new Padding(2);
            activitySupervisorUnassignButton.Name = "activitySupervisorUnassignButton";
            activitySupervisorUnassignButton.Size = new Size(48, 23);
            activitySupervisorUnassignButton.TabIndex = 11;
            activitySupervisorUnassignButton.Text = "<";
            activitySupervisorUnassignButton.UseVisualStyleBackColor = true;
            activitySupervisorUnassignButton.Click += activitySupervisorUnassignButton_Click;
            // 
            // activitySupervisorAssignButton
            // 
            activitySupervisorAssignButton.Enabled = false;
            activitySupervisorAssignButton.Location = new Point(367, 229);
            activitySupervisorAssignButton.Margin = new Padding(2);
            activitySupervisorAssignButton.Name = "activitySupervisorAssignButton";
            activitySupervisorAssignButton.Size = new Size(48, 23);
            activitySupervisorAssignButton.TabIndex = 10;
            activitySupervisorAssignButton.Text = ">";
            activitySupervisorAssignButton.UseVisualStyleBackColor = true;
            activitySupervisorAssignButton.Click += activitySupervisorAssignButton_Click;
            // 
            // activitySupervisorsAssigned
            // 
            activitySupervisorsAssigned.FullRowSelect = true;
            activitySupervisorsAssigned.Location = new Point(440, 153);
            activitySupervisorsAssigned.Margin = new Padding(2);
            activitySupervisorsAssigned.Name = "activitySupervisorsAssigned";
            activitySupervisorsAssigned.Size = new Size(325, 219);
            activitySupervisorsAssigned.TabIndex = 9;
            activitySupervisorsAssigned.UseCompatibleStateImageBehavior = false;
            activitySupervisorsAssigned.View = View.Details;
            activitySupervisorsAssigned.SelectedIndexChanged += activitySupervisorsAssigned_SelectedIndexChanged;
            // 
            // activitySupervisorsUnassigned
            // 
            activitySupervisorsUnassigned.FullRowSelect = true;
            activitySupervisorsUnassigned.Location = new Point(14, 153);
            activitySupervisorsUnassigned.Margin = new Padding(2);
            activitySupervisorsUnassigned.Name = "activitySupervisorsUnassigned";
            activitySupervisorsUnassigned.Size = new Size(325, 219);
            activitySupervisorsUnassigned.TabIndex = 7;
            activitySupervisorsUnassigned.UseCompatibleStateImageBehavior = false;
            activitySupervisorsUnassigned.View = View.Details;
            activitySupervisorsUnassigned.SelectedIndexChanged += activitySupervisorsUnassigned_SelectedIndexChanged;
            // 
            // activitySupervisorsList
            // 
            activitySupervisorsList.FullRowSelect = true;
            activitySupervisorsList.GridLines = true;
            activitySupervisorsList.Location = new Point(14, 17);
            activitySupervisorsList.Margin = new Padding(2);
            activitySupervisorsList.Name = "activitySupervisorsList";
            activitySupervisorsList.Size = new Size(751, 99);
            activitySupervisorsList.TabIndex = 8;
            activitySupervisorsList.UseCompatibleStateImageBehavior = false;
            activitySupervisorsList.View = View.Details;
            activitySupervisorsList.SelectedIndexChanged += activitySupervisorsList_SelectedIndexChanged;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new Point(12, 36);
            pnlDashboard.Margin = new Padding(3, 4, 3, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(1072, 621);
            pnlDashboard.TabIndex = 1;
            // 
            // pnlOrders
            // 
            pnlOrders.Controls.Add(ordersComboBoxLabel);
            pnlOrders.Controls.Add(ordersComboBox);
            pnlOrders.Controls.Add(orderDetailsLabel);
            pnlOrders.Controls.Add(orderProcessButton);
            pnlOrders.Location = new Point(14, 31);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(1072, 528);
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
            pnlProducts.Location = new Point(12, 25);
            pnlProducts.Margin = new Padding(2);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new Size(858, 422);
            pnlProducts.TabIndex = 2;
            // 
            // productEditButton
            // 
            productEditButton.Location = new Point(596, 199);
            productEditButton.Margin = new Padding(2);
            productEditButton.Name = "productEditButton";
            productEditButton.Size = new Size(75, 28);
            productEditButton.TabIndex = 10;
            productEditButton.Text = "Create";
            productEditButton.UseVisualStyleBackColor = true;
            productEditButton.Click += productEditButton_Click;
            // 
            // productEditPriceInput
            // 
            productEditPriceInput.DecimalPlaces = 2;
            productEditPriceInput.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            productEditPriceInput.Location = new Point(640, 154);
            productEditPriceInput.Margin = new Padding(2);
            productEditPriceInput.Name = "productEditPriceInput";
            productEditPriceInput.Size = new Size(100, 27);
            productEditPriceInput.TabIndex = 9;
            // 
            // productEditPriceLabel
            // 
            productEditPriceLabel.AutoSize = true;
            productEditPriceLabel.Location = new Point(596, 156);
            productEditPriceLabel.Margin = new Padding(2, 0, 2, 0);
            productEditPriceLabel.Name = "productEditPriceLabel";
            productEditPriceLabel.Size = new Size(41, 20);
            productEditPriceLabel.TabIndex = 8;
            productEditPriceLabel.Text = "Price";
            // 
            // productEditAlcoholInput
            // 
            productEditAlcoholInput.AutoSize = true;
            productEditAlcoholInput.CheckAlign = ContentAlignment.MiddleRight;
            productEditAlcoholInput.Location = new Point(596, 126);
            productEditAlcoholInput.Margin = new Padding(2);
            productEditAlcoholInput.Name = "productEditAlcoholInput";
            productEditAlcoholInput.Size = new Size(93, 24);
            productEditAlcoholInput.TabIndex = 7;
            productEditAlcoholInput.Text = "Alcoholic";
            productEditAlcoholInput.UseVisualStyleBackColor = true;
            // 
            // productEditStockInput
            // 
            productEditStockInput.Location = new Point(640, 86);
            productEditStockInput.Margin = new Padding(2);
            productEditStockInput.Name = "productEditStockInput";
            productEditStockInput.Size = new Size(100, 27);
            productEditStockInput.TabIndex = 5;
            // 
            // productEditStockLabel
            // 
            productEditStockLabel.AutoSize = true;
            productEditStockLabel.Location = new Point(596, 87);
            productEditStockLabel.Margin = new Padding(2, 0, 2, 0);
            productEditStockLabel.Name = "productEditStockLabel";
            productEditStockLabel.Size = new Size(45, 20);
            productEditStockLabel.TabIndex = 4;
            productEditStockLabel.Text = "Stock";
            // 
            // productEditNameInput
            // 
            productEditNameInput.Location = new Point(640, 46);
            productEditNameInput.Margin = new Padding(2);
            productEditNameInput.Name = "productEditNameInput";
            productEditNameInput.Size = new Size(101, 27);
            productEditNameInput.TabIndex = 3;
            // 
            // productEditNameLabel
            // 
            productEditNameLabel.AutoSize = true;
            productEditNameLabel.Location = new Point(596, 48);
            productEditNameLabel.Margin = new Padding(2, 0, 2, 0);
            productEditNameLabel.Name = "productEditNameLabel";
            productEditNameLabel.Size = new Size(49, 20);
            productEditNameLabel.TabIndex = 2;
            productEditNameLabel.Text = "Name";
            // 
            // productDeleteButton
            // 
            productDeleteButton.Location = new Point(687, 199);
            productDeleteButton.Margin = new Padding(2);
            productDeleteButton.Name = "productDeleteButton";
            productDeleteButton.Size = new Size(75, 28);
            productDeleteButton.TabIndex = 1;
            productDeleteButton.Text = "Delete";
            productDeleteButton.Visible = false;
            productDeleteButton.Click += DeleteProductButton_Click;
            // 
            // teacherEditButton
            // 
            teacherEditButton.Location = new Point(596, 250);
            teacherEditButton.Margin = new Padding(2);
            teacherEditButton.Name = "teacherEditButton";
            teacherEditButton.Size = new Size(75, 28);
            teacherEditButton.TabIndex = 10;
            teacherEditButton.Text = "Create";
            teacherEditButton.UseVisualStyleBackColor = true;
            teacherEditButton.Click += teacherEditButton_Click;
            // 
            // teacherEditFirstNameInput
            // 
            teacherEditFirstNameInput.Location = new Point(702, 75);
            teacherEditFirstNameInput.Margin = new Padding(2);
            teacherEditFirstNameInput.Name = "teacherEditFirstNameInput";
            teacherEditFirstNameInput.Size = new Size(120, 27);
            teacherEditFirstNameInput.TabIndex = 3;
            // 
            // teacherEditRoomSelect
            // 
            teacherEditRoomSelect.Location = new Point(702, 199);
            teacherEditRoomSelect.Name = "teacherEditRoomSelect";
            teacherEditRoomSelect.Size = new Size(120, 27);
            teacherEditRoomSelect.TabIndex = 3;
            // 
            // teacherEditPhoneNumberInput
            // 
            teacherEditPhoneNumberInput.Location = new Point(702, 136);
            teacherEditPhoneNumberInput.Margin = new Padding(2);
            teacherEditPhoneNumberInput.Name = "teacherEditPhoneNumberInput";
            teacherEditPhoneNumberInput.Size = new Size(120, 27);
            teacherEditPhoneNumberInput.TabIndex = 3;
            teacherEditPhoneNumberInput.Minimum = 0;
            teacherEditPhoneNumberInput.Maximum = UInt64.MaxValue;
            // 
            // teacherEditDateOfBirthInput
            // 
            teacherEditDateOfBirthInput.CustomFormat = "dd MMM yyyy";
            teacherEditDateOfBirthInput.Format = DateTimePickerFormat.Custom;
            teacherEditDateOfBirthInput.Location = new Point(702, 167);
            teacherEditDateOfBirthInput.Margin = new Padding(2);
            teacherEditDateOfBirthInput.Name = "teacherEditDateOfBirthInput";
            teacherEditDateOfBirthInput.Size = new Size(120, 27);
            teacherEditDateOfBirthInput.TabIndex = 3;
            // 
            // teacherEditLastNameInput
            // 
            teacherEditLastNameInput.Location = new Point(702, 106);
            teacherEditLastNameInput.Margin = new Padding(2);
            teacherEditLastNameInput.Name = "teacherEditLastNameInput";
            teacherEditLastNameInput.Size = new Size(120, 27);
            teacherEditLastNameInput.TabIndex = 3;
            // 
            // teacherEditFirstNameLabel
            // 
            teacherEditFirstNameLabel.AutoSize = true;
            teacherEditFirstNameLabel.Location = new Point(587, 79);
            teacherEditFirstNameLabel.Margin = new Padding(2, 0, 2, 0);
            teacherEditFirstNameLabel.Name = "teacherEditFirstNameLabel";
            teacherEditFirstNameLabel.Size = new Size(76, 20);
            teacherEditFirstNameLabel.TabIndex = 2;
            teacherEditFirstNameLabel.Text = "Firstname:";
            // 
            // teachersDeleteButton
            // 
            teachersDeleteButton.Location = new Point(687, 250);
            teachersDeleteButton.Margin = new Padding(2);
            teachersDeleteButton.Name = "teachersDeleteButton";
            teachersDeleteButton.Size = new Size(75, 28);
            teachersDeleteButton.TabIndex = 1;
            teachersDeleteButton.Text = "Delete";
            teachersDeleteButton.Visible = false;
            teachersDeleteButton.Click += DeleteTeacherButton_Click;
            // 
            // pnlRevenue
            // 
            pnlRevenue.Controls.Add(outputRevenue);
            pnlRevenue.Controls.Add(endDatePickerLabel1);
            pnlRevenue.Controls.Add(startDatePickerLabel1);
            pnlRevenue.Controls.Add(revenueDateStart);
            pnlRevenue.Controls.Add(revenueDateEnd);
            pnlRevenue.Location = new Point(12, 25);
            pnlRevenue.Margin = new Padding(2);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new Size(858, 422);
            pnlRevenue.TabIndex = 2;
            // 
            // startDatePickerLabel1
            // 
            startDatePickerLabel1.AutoSize = true;
            startDatePickerLabel1.Location = new Point(12, 54);
            startDatePickerLabel1.Margin = new Padding(2, 0, 2, 0);
            startDatePickerLabel1.Name = "startDatePickerLabel1";
            startDatePickerLabel1.Size = new Size(77, 20);
            startDatePickerLabel1.TabIndex = 1;
            startDatePickerLabel1.Text = "Start date:";
            // 
            // revenueDateStart
            // 
            revenueDateStart.CustomFormat = "dd MMM yyyy";
            revenueDateStart.Format = DateTimePickerFormat.Custom;
            revenueDateStart.Location = new Point(12, 80);
            revenueDateStart.Margin = new Padding(2);
            revenueDateStart.MaxDate = new DateTime(2024, 3, 26, 0, 0, 0, 0);
            revenueDateStart.Name = "revenueDateStart";
            revenueDateStart.Size = new Size(161, 27);
            revenueDateStart.TabIndex = 0;
            revenueDateStart.Value = new DateTime(2024, 3, 26, 0, 0, 0, 0);
            revenueDateStart.ValueChanged += UpdateRevenueSelector;
            // 
            // revenueDateEnd
            // 
            revenueDateEnd.CustomFormat = "dd MMM yyyy";
            revenueDateEnd.Format = DateTimePickerFormat.Custom;
            revenueDateEnd.Location = new Point(320, 80);
            revenueDateEnd.Margin = new Padding(2);
            revenueDateEnd.MaxDate = new DateTime(2024, 3, 26, 0, 0, 0, 0);
            revenueDateEnd.Name = "revenueDateEnd";
            revenueDateEnd.Size = new Size(161, 27);
            revenueDateEnd.TabIndex = 0;
            revenueDateEnd.Value = new DateTime(2024, 3, 26, 0, 0, 0, 0);
            revenueDateEnd.ValueChanged += UpdateRevenueSelector;
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(listViewGeneral);
            pnlRooms.Location = new Point(12, 25);
            pnlRooms.Margin = new Padding(2);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new Size(1072, 528);
            pnlRooms.TabIndex = 2;
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(studentEditFirstNameInput);
            pnlStudents.Controls.Add(studentEditRoomSelect);
            pnlStudents.Controls.Add(studentEditRoomLabel);
            pnlStudents.Controls.Add(studentEditVouchersNumerric);
            pnlStudents.Controls.Add(studentEditVouchersLabel);
            pnlStudents.Controls.Add(studentEditClassInput);
            pnlStudents.Controls.Add(studentEditClassLabel);
            pnlStudents.Controls.Add(studentEditPhoneNumberInput);
            pnlStudents.Controls.Add(studentEditPhoneNumberLabel);
            pnlStudents.Controls.Add(studentEditLastNameInput);
            pnlStudents.Controls.Add(label1studentEditLastNameLabel);
            pnlStudents.Controls.Add(studentEditButton);
            pnlStudents.Controls.Add(studentEditFirstNameLabel);
            pnlStudents.Controls.Add(listViewPanelStudents);
            pnlStudents.Controls.Add(studentDeleteButton);
            pnlStudents.Location = new Point(12, 25);
            pnlStudents.Margin = new Padding(2);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new Size(858, 422);
            pnlStudents.TabIndex = 2;
            // 
            // studentEditRoomSelect
            // 
            studentEditRoomSelect.Location = new Point(594, 323);
            studentEditRoomSelect.Name = "studentEditRoomSelect";
            studentEditRoomSelect.Size = new Size(170, 27);
            studentEditRoomSelect.TabIndex = 21;
            // 
            // studentEditRoomLabel
            // 
            studentEditRoomLabel.AutoSize = true;
            studentEditRoomLabel.Location = new Point(596, 301);
            studentEditRoomLabel.Margin = new Padding(2, 0, 2, 0);
            studentEditRoomLabel.Name = "studentEditRoomLabel";
            studentEditRoomLabel.Size = new Size(49, 20);
            studentEditRoomLabel.TabIndex = 20;
            studentEditRoomLabel.Text = "Room";
            // 
            // studentEditVouchersNumerric
            // 
            studentEditVouchersNumerric.Location = new Point(596, 266);
            studentEditVouchersNumerric.Name = "studentEditVouchersNumerric";
            studentEditVouchersNumerric.Size = new Size(150, 27);
            studentEditVouchersNumerric.TabIndex = 19;
            // 
            // studentEditVouchersLabel
            // 
            studentEditVouchersLabel.AutoSize = true;
            studentEditVouchersLabel.Location = new Point(594, 243);
            studentEditVouchersLabel.Margin = new Padding(2, 0, 2, 0);
            studentEditVouchersLabel.Name = "studentEditVouchersLabel";
            studentEditVouchersLabel.Size = new Size(68, 20);
            studentEditVouchersLabel.TabIndex = 17;
            studentEditVouchersLabel.Text = "Vouchers";
            // 
            // studentEditClassInput
            // 
            studentEditClassInput.Location = new Point(596, 200);
            studentEditClassInput.Margin = new Padding(2);
            studentEditClassInput.Name = "studentEditClassInput";
            studentEditClassInput.Size = new Size(170, 27);
            studentEditClassInput.TabIndex = 16;
            // 
            // studentEditClassLabel
            // 
            studentEditClassLabel.AutoSize = true;
            studentEditClassLabel.Location = new Point(598, 177);
            studentEditClassLabel.Margin = new Padding(2, 0, 2, 0);
            studentEditClassLabel.Name = "studentEditClassLabel";
            studentEditClassLabel.Size = new Size(42, 20);
            studentEditClassLabel.TabIndex = 15;
            studentEditClassLabel.Text = "Class";
            // 
            // studentEditPhoneNumberInput
            // 
            studentEditPhoneNumberInput.Location = new Point(596, 147);
            studentEditPhoneNumberInput.Margin = new Padding(2);
            studentEditPhoneNumberInput.Name = "studentEditPhoneNumberInput";
            studentEditPhoneNumberInput.Size = new Size(170, 27);
            studentEditPhoneNumberInput.TabIndex = 14;
            studentEditPhoneNumberInput.Minimum = 0;
            studentEditPhoneNumberInput.Maximum = UInt64.MaxValue;
            // 
            // studentEditPhoneNumberLabel
            // 
            studentEditPhoneNumberLabel.AutoSize = true;
            studentEditPhoneNumberLabel.Location = new Point(596, 126);
            studentEditPhoneNumberLabel.Margin = new Padding(2, 0, 2, 0);
            studentEditPhoneNumberLabel.Name = "studentEditPhoneNumberLabel";
            studentEditPhoneNumberLabel.Size = new Size(105, 20);
            studentEditPhoneNumberLabel.TabIndex = 13;
            studentEditPhoneNumberLabel.Text = "Phone number";
            // 
            // studentEditLastNameInput
            // 
            studentEditLastNameInput.Location = new Point(595, 92);
            studentEditLastNameInput.Margin = new Padding(2);
            studentEditLastNameInput.Name = "studentEditLastNameInput";
            studentEditLastNameInput.Size = new Size(170, 27);
            studentEditLastNameInput.TabIndex = 12;
            // 
            // label1studentEditLastNameLabel
            // 
            label1studentEditLastNameLabel.AutoSize = true;
            label1studentEditLastNameLabel.Location = new Point(594, 70);
            label1studentEditLastNameLabel.Margin = new Padding(2, 0, 2, 0);
            label1studentEditLastNameLabel.Name = "label1studentEditLastNameLabel";
            label1studentEditLastNameLabel.Size = new Size(76, 20);
            label1studentEditLastNameLabel.TabIndex = 11;
            label1studentEditLastNameLabel.Text = "Last name";
            // 
            // studentEditButton
            // 
            studentEditButton.Location = new Point(594, 373);
            studentEditButton.Margin = new Padding(2);
            studentEditButton.Name = "studentEditButton";
            studentEditButton.Size = new Size(75, 28);
            studentEditButton.TabIndex = 10;
            studentEditButton.Text = "Create";
            studentEditButton.UseVisualStyleBackColor = true;
            studentEditButton.Click += studentEditButton_Click;
            // 
            // studentEditFirstNameLabel
            // 
            studentEditFirstNameLabel.AutoSize = true;
            studentEditFirstNameLabel.Location = new Point(595, 17);
            studentEditFirstNameLabel.Margin = new Padding(2, 0, 2, 0);
            studentEditFirstNameLabel.Name = "studentEditFirstNameLabel";
            studentEditFirstNameLabel.Size = new Size(77, 20);
            studentEditFirstNameLabel.TabIndex = 2;
            studentEditFirstNameLabel.Text = "First name";
            // 
            // studentDeleteButton
            // 
            studentDeleteButton.Location = new Point(691, 373);
            studentDeleteButton.Margin = new Padding(2);
            studentDeleteButton.Name = "studentDeleteButton";
            studentDeleteButton.Size = new Size(75, 28);
            studentDeleteButton.TabIndex = 1;
            studentDeleteButton.Text = "Delete";
            studentDeleteButton.Visible = false;
            studentDeleteButton.Click += DeleteStudentButton_Click;
            // 
            // pnlTeachers
            // 
            pnlTeachers.Controls.Add(teacherEditRoomIdLabel);
            pnlTeachers.Controls.Add(teacherEditDateOfBirthLabel);
            pnlTeachers.Controls.Add(teacherEditPhoneNumberLabel);
            pnlTeachers.Controls.Add(teacherEditLastNameLabel);
            pnlTeachers.Controls.Add(teacherEditButton);
            pnlTeachers.Controls.Add(teacherEditFirstNameInput);
            pnlTeachers.Controls.Add(teacherEditRoomSelect);
            pnlTeachers.Controls.Add(teacherEditDateOfBirthInput);
            pnlTeachers.Controls.Add(teacherEditLastNameInput);
            pnlTeachers.Controls.Add(teacherEditPhoneNumberInput);
            pnlTeachers.Controls.Add(teacherEditFirstNameLabel);
            pnlTeachers.Controls.Add(listViewPanelteachers);
            pnlTeachers.Controls.Add(teachersDeleteButton);
            pnlTeachers.Location = new Point(12, 25);
            pnlTeachers.Margin = new Padding(2);
            pnlTeachers.Name = "pnlTeachers";
            pnlTeachers.Size = new Size(1072, 528);
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
            pnlVat.Location = new Point(24, 64);
            pnlVat.Margin = new Padding(2);
            pnlVat.Name = "pnlVat";
            pnlVat.Size = new Size(709, 278);
            pnlVat.TabIndex = 1;
            // 
            // txtYear
            // 
            txtYear.AllowDrop = true;
            txtYear.Location = new Point(561, 86);
            txtYear.Margin = new Padding(2);
            txtYear.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 27);
            txtYear.TabIndex = 2;
            txtYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            txtYear.ValueChanged += txtYear_ValueChanged;
            // 
            // studentEditFirstNameInput
            // 
            studentEditFirstNameInput.Location = new Point(598, 39);
            studentEditFirstNameInput.Margin = new Padding(2);
            studentEditFirstNameInput.Name = "studentEditFirstNameInput";
            studentEditFirstNameInput.Size = new Size(170, 27);
            studentEditFirstNameInput.TabIndex = 22;
            //
            // teacherEditLastNameLabel
            // 
            teacherEditLastNameLabel.AutoSize = true;
            teacherEditLastNameLabel.Location = new Point(587, 107);
            teacherEditLastNameLabel.Margin = new Padding(2, 0, 2, 0);
            teacherEditLastNameLabel.Name = "teacherEditLastNameLabel";
            teacherEditLastNameLabel.Size = new Size(75, 20);
            teacherEditLastNameLabel.TabIndex = 11;
            teacherEditLastNameLabel.Text = "Lastname:";
            // 
            // teacherEditPhoneNumberLabel
            // 
            teacherEditPhoneNumberLabel.AutoSize = true;
            teacherEditPhoneNumberLabel.Location = new Point(587, 139);
            teacherEditPhoneNumberLabel.Margin = new Padding(2, 0, 2, 0);
            teacherEditPhoneNumberLabel.Name = "teacherEditPhoneNumberLabel";
            teacherEditPhoneNumberLabel.Size = new Size(111, 20);
            teacherEditPhoneNumberLabel.TabIndex = 12;
            teacherEditPhoneNumberLabel.Text = "Phone Number:";
            // 
            // teacherEditDateOfBirthLabel
            // 
            teacherEditDateOfBirthLabel.AutoSize = true;
            teacherEditDateOfBirthLabel.Location = new Point(587, 172);
            teacherEditDateOfBirthLabel.Margin = new Padding(2, 0, 2, 0);
            teacherEditDateOfBirthLabel.Name = "teacherEditDateOfBirthLabel";
            teacherEditDateOfBirthLabel.Size = new Size(99, 20);
            teacherEditDateOfBirthLabel.TabIndex = 13;
            teacherEditDateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // teacherEditRoomIdLabel
            // 
            teacherEditRoomIdLabel.AutoSize = true;
            teacherEditRoomIdLabel.Location = new Point(588, 202);
            teacherEditRoomIdLabel.Margin = new Padding(2, 0, 2, 0);
            teacherEditRoomIdLabel.Name = "teacherEditRoomIdLabel";
            teacherEditRoomIdLabel.Size = new Size(110, 20);
            teacherEditRoomIdLabel.TabIndex = 14;
            teacherEditRoomIdLabel.Text = "Room Number:";
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 841);
            Controls.Add(pnlTeachers);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlStudents);
            Controls.Add(pnlActivities);
            Controls.Add(pnlActivityParticipants);
            Controls.Add(pnlActivitySupervisors);
            Controls.Add(pnlRooms);
            Controls.Add(pnlRevenue);
            Controls.Add(pnlProducts);
            Controls.Add(pnlOrders);
            Controls.Add(pnlVat);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SomerenUI";
            Text = "SomerenApp";
            Load += SomerenUI_Load;
            gbQuarter.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlActivityParticipants.ResumeLayout(false);
            pnlActivityParticipants.PerformLayout();
            pnlActivitySupervisors.ResumeLayout(false);
            pnlActivitySupervisors.PerformLayout();
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
        private Button teachersDeleteButton;
        private Button productEditButton;
        private Button studentDeleteButton;
        private Button studentEditButton;
        private Button teacherEditButton;
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
        private Label teacherEditFirstNameLabel;
        private Label productEditPriceLabel;
        private Label productEditStockLabel;
        private Label studentEditFirstNameLabel;
        private Label startDatePickerLabel1;
        private ListView listViewGeneral;
        private ListView listViewPanelProducts;
        private ListView listViewPanelStudents;
        private ListView listViewPanelteachers;
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
        private TextBox studentEditFirstNameInput;
        private TextBox studentEditLastNameInput;
        private NumericUpDown studentEditPhoneNumberInput;
        private TextBox studentEditClassInput;
        private ComboBox studentEditRoomSelect;
        private NumericUpDown studentEditVouchersNumerric;
        private TextBox teacherEditFirstNameInput;
        private ComboBox teacherEditRoomSelect;
        private DateTimePicker teacherEditDateOfBirthInput;
        private TextBox teacherEditLastNameInput;
        private NumericUpDown teacherEditPhoneNumberInput;
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
        private Label label1studentEditLastNameLabel;
        private Label studentEditPhoneNumberLabel;
        private Label studentEditClassLabel;
        private Label studentEditVouchersLabel;
        private Label studentEditRoomLabel;
        private Label teacherEditLastNameLabel;
        private Label teacherEditRoomIdLabel;
        private Label teacherEditDateOfBirthLabel;
        private Label teacherEditPhoneNumberLabel;
        private Button activityParticipantAssignButton;
        private ListView activityParticipantsAssigned;
        private ListView activityParticipantsUnassigned;
        private ListView activityParticipantsList;
        private Button activityParticipantUnassignButton;
        private Label assignedStudentsLabel;
        private Label unassignedStudentsLabel;
        private Label lblAssignedSupervisor;
        private Label lblUnassignedSupervisor;
        private Button activitySupervisorUnassignButton;
        private Button activitySupervisorAssignButton;
        private ListView activitySupervisorsAssigned;
        private ListView activitySupervisorsUnassigned;
        private ListView activitySupervisorsList;
    }
}

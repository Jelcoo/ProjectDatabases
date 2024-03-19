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
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            teachersToolStripMenuItem = new ToolStripMenuItem();
            activitiesToolStripMenuItem = new ToolStripMenuItem();
            roomsToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            ordersToolStripMenuItem = new ToolStripMenuItem();
            revenueToolStripMenuItem = new ToolStripMenuItem();
            pnlProducts = new Panel();
            productEditButton = new Button();
            productEditPriceInput = new NumericUpDown();
            productEditPriceLabel = new Label();
            productEditAlcoholInput = new CheckBox();
            productEditStockInput = new NumericUpDown();
            productEditStockLabel = new Label();
            productEditNameInput = new TextBox();
            productEditNameLabel = new Label();
            listViewPanelProducts = new ListView();
            productDeleteButton = new Button();
            pnlDashboard = new Panel();
            lblDashboard = new Label();
            pnlStudents = new Panel();
            listViewGeneral = new ListView();
            pnlTeachers = new Panel();
            pnlActivities = new Panel();
            pnlRooms = new Panel();
            pnlOrders = new Panel();
            ordersComboBoxLabel = new Label();
            ordersComboBox = new ComboBox();
            orderDetailsLabel = new Label();
            orderProcessButton = new Button();
            pnlRevenue = new Panel();
            OutputRevenue = new Label();
            EndDatePickerLabel1 = new Label();
            StartDatePickerLabel1 = new Label();
            revenueDateStart = new DateTimePicker();
            revenueDateEnd = new DateTimePicker();
            pictureBox1 = new PictureBox();
            headerLabel = new Label();
            flowLayoutPanelOrderProducts = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            pnlProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productEditPriceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productEditStockInput).BeginInit();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, teachersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, productsToolStripMenuItem, ordersToolStripMenuItem, revenueToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1374, 33);
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
            activitiesToolStripMenuItem.Size = new Size(98, 29);
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
            // listViewPanelProducts
            // 
            listViewPanelProducts.Location = new Point(15, 60);
            listViewPanelProducts.Name = "listViewPanelProducts";
            listViewPanelProducts.Size = new Size(700, 400);
            listViewPanelProducts.TabIndex = 0;
            listViewPanelProducts.UseCompatibleStateImageBehavior = false;
            listViewPanelProducts.View = View.Details;
            listViewPanelProducts.SelectedIndexChanged += listViewPanelProducts_SelectedIndexChanged;
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
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new Point(15, 45);
            pnlDashboard.Margin = new Padding(4, 5, 4, 5);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(1340, 776);
            pnlDashboard.TabIndex = 1;
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
            // pnlStudents
            // 
            pnlStudents.Location = new Point(15, 31);
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
            listViewGeneral.View = View.Details;
            // 
            // pnlTeachers
            // 
            pnlTeachers.Location = new Point(15, 31);
            pnlTeachers.Name = "pnlTeachers";
            pnlTeachers.Size = new Size(1340, 660);
            pnlTeachers.TabIndex = 2;
            // 
            // pnlActivities
            // 
            pnlActivities.Location = new Point(15, 31);
            pnlActivities.Name = "pnlActivities";
            pnlActivities.Size = new Size(1340, 660);
            pnlActivities.TabIndex = 2;
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(listViewGeneral);
            pnlRooms.Location = new Point(15, 31);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new Size(1340, 660);
            pnlRooms.TabIndex = 2;
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
            // ordersComboBox
            // 
            ordersComboBox.Location = new Point(190, 80);
            ordersComboBox.Margin = new Padding(4);
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
            // pnlRevenue
            // 
            pnlRevenue.Controls.Add(OutputRevenue);
            pnlRevenue.Controls.Add(EndDatePickerLabel1);
            pnlRevenue.Controls.Add(StartDatePickerLabel1);
            pnlRevenue.Controls.Add(revenueDateStart);
            pnlRevenue.Controls.Add(revenueDateEnd);
            pnlRevenue.Location = new Point(15, 31);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new Size(1072, 528);
            pnlRevenue.TabIndex = 2;
            // 
            // OutputRevenue
            // 
            OutputRevenue.AutoSize = true;
            OutputRevenue.Location = new Point(15, 184);
            OutputRevenue.Name = "OutputRevenue";
            OutputRevenue.Size = new Size(0, 25);
            OutputRevenue.TabIndex = 3;
            // 
            // EndDatePickerLabel1
            // 
            EndDatePickerLabel1.AutoSize = true;
            EndDatePickerLabel1.Location = new Point(398, 68);
            EndDatePickerLabel1.Name = "EndDatePickerLabel1";
            EndDatePickerLabel1.Size = new Size(86, 25);
            EndDatePickerLabel1.TabIndex = 2;
            EndDatePickerLabel1.Text = "End date:";
            // 
            // StartDatePickerLabel1
            // 
            StartDatePickerLabel1.AutoSize = true;
            StartDatePickerLabel1.Location = new Point(15, 68);
            StartDatePickerLabel1.Name = "StartDatePickerLabel1";
            StartDatePickerLabel1.Size = new Size(92, 25);
            StartDatePickerLabel1.TabIndex = 1;
            StartDatePickerLabel1.Text = "Start date:";
            // 
            // revenueDateStart
            // 
            revenueDateStart.CustomFormat = "dd MMM yyyy";
            revenueDateStart.Format = DateTimePickerFormat.Custom;
            revenueDateStart.Location = new Point(15, 100);
            revenueDateStart.MaxDate = new DateTime(2024, 3, 19, 15, 17, 16, 450);
            revenueDateStart.Name = "revenueDateStart";
            revenueDateStart.Size = new Size(200, 31);
            revenueDateStart.TabIndex = 0;
            revenueDateStart.Value = new DateTime(2024, 3, 19, 15, 17, 16, 450);
            revenueDateStart.ValueChanged += updateRevenueSelector;
            // 
            // revenueDateEnd
            // 
            revenueDateEnd.CustomFormat = "dd MMM yyyy";
            revenueDateEnd.Format = DateTimePickerFormat.Custom;
            revenueDateEnd.Location = new Point(400, 100);
            revenueDateEnd.MaxDate = new DateTime(2024, 3, 19, 15, 17, 16, 454);
            revenueDateEnd.Name = "revenueDateEnd";
            revenueDateEnd.Size = new Size(200, 31);
            revenueDateEnd.TabIndex = 0;
            revenueDateEnd.Value = new DateTime(2024, 3, 19, 15, 17, 16, 454);
            revenueDateEnd.ValueChanged += updateRevenueSelector;
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
            flowLayoutPanelOrderProducts.Margin = new Padding(4);
            flowLayoutPanelOrderProducts.Name = "flowLayoutPanelOrderProducts";
            flowLayoutPanelOrderProducts.Size = new Size(600, 434);
            flowLayoutPanelOrderProducts.TabIndex = 1;
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 841);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlStudents);
            Controls.Add(pnlTeachers);
            Controls.Add(pnlActivities);
            Controls.Add(pnlRooms);
            Controls.Add(pnlProducts);
            Controls.Add(pnlOrders);
            Controls.Add(pnlRevenue);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "SomerenUI";
            Text = "SomerenApp";
            Load += SomerenUI_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlProducts.ResumeLayout(false);
            pnlProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productEditPriceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)productEditStockInput).EndInit();
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

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem teachersToolStripMenuItem;
        private ToolStripMenuItem activitiesToolStripMenuItem;
        private ToolStripMenuItem roomsToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem ordersToolStripMenuItem;
        private ToolStripMenuItem revenueToolStripMenuItem;
        private Panel pnlDashboard;
        private Label lblDashboard;
        private Panel pnlStudents;
        private Panel pnlTeachers;
        private Panel pnlActivities;
        private Panel pnlRooms;
        private Panel pnlProducts;
        private ListView listViewPanelProducts;
        private PictureBox pictureBox1;
        private Label headerLabel;
        private Button productDeleteButton;
        private Label productEditNameLabel;
        private TextBox productEditNameInput;
        private Label productEditStockLabel;
        private NumericUpDown productEditStockInput;
        private NumericUpDown productEditPriceInput;
        private Label productEditPriceLabel;
        private CheckBox productEditAlcoholInput;
        private Button productEditButton;
        private Panel pnlOrders;
        private Panel pnlRevenue;
        private ListView listViewGeneral;
        private Label ordersComboBoxLabel;
        private ComboBox ordersComboBox;
        private Label orderDetailsLabel;
        private Button orderProcessButton;
        private FlowLayoutPanel flowLayoutPanelOrderProducts;
        private DateTimePicker revenueDateStart;
        private DateTimePicker revenueDateEnd;
        private Label StartDatePickerLabel1;
        private Label EndDatePickerLabel1;
        private Label OutputRevenue;
    }
}

using System.Windows.Forms;

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
            productsToolStripMenuItem = new ToolStripMenuItem();
            roomsToolStripMenuItem = new ToolStripMenuItem();
            pnlDashboard = new Panel();
            lblDashboard = new Label();
            pnlStudents = new Panel();
            flowLayoutPanelStudents = new FlowLayoutPanel();
            pnlTeachers = new Panel();
            flowLayoutPanelTeachers = new FlowLayoutPanel();
            pnlActivities = new Panel();
            flowLayoutPanelActivities = new FlowLayoutPanel();
            pnlRooms = new Panel();
            flowLayoutPanelRooms = new FlowLayoutPanel();
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
            pictureBox1 = new PictureBox();
            headerLabel = new Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            pnlTeachers.SuspendLayout();
            pnlActivities.SuspendLayout();
            pnlRooms.SuspendLayout();
            pnlProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productEditPriceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productEditStockInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, teachersToolStripMenuItem, activitiesToolStripMenuItem, productsToolStripMenuItem, roomsToolStripMenuItem });
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
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            productsToolStripMenuItem.Text = "Products";
            productsToolStripMenuItem.Click += productsToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(3, 4);
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
            pnlProducts.Location = new System.Drawing.Point(14, 31);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new System.Drawing.Size(1072, 528);
            pnlProducts.TabIndex = 2;
            // 
            // productEditButton
            // 
            productEditButton.Location = new System.Drawing.Point(745, 249);
            productEditButton.Name = "productEditButton";
            productEditButton.Size = new System.Drawing.Size(94, 29);
            productEditButton.TabIndex = 10;
            productEditButton.Text = "Create";
            productEditButton.UseVisualStyleBackColor = true;
            productEditButton.Click += productEditButton_Click;
            // 
            // productEditPriceInput
            // 
            productEditPriceInput.DecimalPlaces = 2;
            productEditPriceInput.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            productEditPriceInput.Location = new System.Drawing.Point(800, 193);
            productEditPriceInput.Name = "productEditPriceInput";
            productEditPriceInput.Size = new System.Drawing.Size(125, 27);
            productEditPriceInput.TabIndex = 9;
            // 
            // productEditPriceLabel
            // 
            productEditPriceLabel.AutoSize = true;
            productEditPriceLabel.Location = new System.Drawing.Point(745, 195);
            productEditPriceLabel.Name = "productEditPriceLabel";
            productEditPriceLabel.Size = new System.Drawing.Size(41, 20);
            productEditPriceLabel.TabIndex = 8;
            productEditPriceLabel.Text = "Price";
            // 
            // productEditAlcoholInput
            // 
            productEditAlcoholInput.AutoSize = true;
            productEditAlcoholInput.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            productEditAlcoholInput.Location = new System.Drawing.Point(745, 157);
            productEditAlcoholInput.Name = "productEditAlcoholInput";
            productEditAlcoholInput.Size = new System.Drawing.Size(93, 24);
            productEditAlcoholInput.TabIndex = 7;
            productEditAlcoholInput.Text = "Alcoholic";
            productEditAlcoholInput.UseVisualStyleBackColor = true;
            // 
            // productEditStockInput
            // 
            productEditStockInput.Location = new System.Drawing.Point(800, 107);
            productEditStockInput.Name = "productEditStockInput";
            productEditStockInput.Size = new System.Drawing.Size(125, 27);
            productEditStockInput.TabIndex = 5;
            // 
            // productEditStockLabel
            // 
            productEditStockLabel.AutoSize = true;
            productEditStockLabel.Location = new System.Drawing.Point(745, 109);
            productEditStockLabel.Name = "productEditStockLabel";
            productEditStockLabel.Size = new System.Drawing.Size(45, 20);
            productEditStockLabel.TabIndex = 4;
            productEditStockLabel.Text = "Stock";
            // 
            // productEditNameInput
            // 
            productEditNameInput.Location = new System.Drawing.Point(800, 57);
            productEditNameInput.Name = "productEditNameInput";
            productEditNameInput.Size = new System.Drawing.Size(125, 27);
            productEditNameInput.TabIndex = 3;
            // 
            // productEditNameLabel
            // 
            productEditNameLabel.AutoSize = true;
            productEditNameLabel.Location = new System.Drawing.Point(745, 60);
            productEditNameLabel.Name = "productEditNameLabel";
            productEditNameLabel.Size = new System.Drawing.Size(49, 20);
            productEditNameLabel.TabIndex = 2;
            productEditNameLabel.Text = "Name";
            // 
            // listViewPanelProducts
            // 
            listViewPanelProducts.Location = new System.Drawing.Point(14, 60);
            listViewPanelProducts.Name = "listViewPanelProducts";
            listViewPanelProducts.Size = new System.Drawing.Size(700, 400);
            listViewPanelProducts.TabIndex = 0;
            listViewPanelProducts.UseCompatibleStateImageBehavior = false;
            listViewPanelProducts.View = View.Details;
            listViewPanelProducts.SelectedIndexChanged += listViewPanelProducts_SelectedIndexChanged;
            // 
            // productDeleteButton
            // 
            productDeleteButton.Location = new System.Drawing.Point(859, 249);
            productDeleteButton.Name = "productDeleteButton";
            productDeleteButton.Size = new System.Drawing.Size(94, 29);
            productDeleteButton.TabIndex = 1;
            productDeleteButton.Text = "Delete";
            productDeleteButton.Click += DeleteProductButton_Click;
            productDeleteButton.Visible = false;
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
            Controls.Add(pnlProducts);
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
            pnlRooms.ResumeLayout(false);
            pnlProducts.ResumeLayout(false);
            pnlProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productEditPriceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)productEditStockInput).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.Panel pnlActivities;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelStudents;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTeachers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelActivities;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRooms;
        private System.Windows.Forms.ListView listViewPanelProducts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button productDeleteButton;
        private Label productEditNameLabel;
        private TextBox productEditNameInput;
        private Label productEditStockLabel;
        private NumericUpDown productEditStockInput;
        private NumericUpDown productEditPriceInput;
        private Label productEditPriceLabel;
        private CheckBox productEditAlcoholInput;
        private Button productEditButton;
    }
}
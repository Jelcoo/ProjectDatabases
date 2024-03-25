using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Drawing;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        private List<Panel> panelList = new List<Panel>();
        private Student selectedOrderStudent = null;
        private Order unprocessedOrder = null;
        private Product selectedProduct;

        public SomerenUI()
        {
            InitializeComponent();

            panelList.Add(pnlDashboard);
            panelList.Add(pnlStudents);
            panelList.Add(pnlTeachers);
            panelList.Add(pnlActivities);
            panelList.Add(pnlRooms);
            panelList.Add(pnlProducts);
            panelList.Add(pnlOrders);
            panelList.Add(pnlRevenue);
            panelList.Add(pnlVat);
        }

        private void ShowPanel(Panel panel)
        {
            foreach (Panel item in this.panelList)
            {
                item.Hide();
            }
            panel.Show();
            panel.Controls.Add(pictureBox1);
            panel.Controls.Add(headerLabel);
        }

        private void SetHeader(string header, bool visible = true)
        {
            headerLabel.Text = header;
            headerLabel.Visible = visible;
        }

        private void ShowListView(Panel pnl, ListView list)
        {
            pnl.Controls.Add(list);
            list.Items.Clear();
            list.Columns.Clear();
        }

        private void ShowStudentsPanel()
        {
            ShowPanel(pnlStudents);

            try
            {
                List<Student> students = GetStudents("lastName DESC");
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private void ShowTeachersPanel()
        {
            ShowPanel(pnlTeachers);

            try
            {
                List<Teacher> teachers = GetTeachers("lastName DESC");
                DisplayTeachers(teachers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the teachers: " + e.Message);
            }
        }

        private void ShowRoomsPanel()
        {
            ShowPanel(pnlRooms);

            try
            {
                List<Room> rooms = GetRooms("building, floor, roomId ASC");
                DisplayRooms(rooms);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }

        private void ShowRevenuePanel()
        {
            ShowPanel(pnlRevenue);
            SetHeader("Revenue");
        }

        private void ShowActivitiesPanel()
        {
            ShowPanel(pnlActivities);

            try
            {
                List<Activity> activities = GetActivities();
                DisplayActivities(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }

        private void ShowProductsPanel()
        {
            ShowPanel(pnlProducts);

            try
            {
                List<Product> products = GetProducts();
                DisplayProducts(products);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the products: " + e.Message);
            }
        }

        private void ShowOrderStudentsPanel()
        {
            ShowPanel(pnlOrders);

            try
            {
                List<Student> students = GetStudents("lastName DESC");
                DisplayOrderStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the orders: " + e.Message);
            }
        }

        private void ShowOrderProductsList()
        {
            pnlOrders.Controls.Add(flowLayoutPanelOrderProducts);

            try
            {
                List<Product> products = GetProducts("name ASC");
                DisplayOrderProducts(products);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the order for student: " + e.Message);
            }
        }

        private void ShowVatPanel()
        {
            ShowPanel(pnlVat);

            try
            {
                SetHeader("VAT");
                DisplayVat();
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the VAT: " + e.Message);
            }
        }

        private List<Student> GetStudents(string sortBy)
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents(sortBy);
            return students;
        }

        private List<Teacher> GetTeachers(string sortBy)
        {
            TeacherService teacherService = new TeacherService();
            List<Teacher> teachers = teacherService.GetTeachers(sortBy);
            return teachers;
        }

        private List<Activity> GetActivities()
        {
            ActivityService activityService = new ActivityService();
            List<Activity> activities = activityService.GetActivities();
            return activities;
        }

        private List<Room> GetRooms(string sortBy)
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms(sortBy);
            return rooms;
        }
        private List<Product> GetProducts()
        {
            ProductService productService = new ProductService();
            List<Product> products = productService.GetProducts();
            return products;
        }

        private Revenue GetRevenue(DateTime startDate, DateTime endDate)
        {
            RevenueService revenueService = new RevenueService();
            Revenue revenue = revenueService.GetRevenue(startDate, endDate);
            return revenue;
        }

        private List<Product> GetProducts(string sortBy)
        {
            ProductService productService = new ProductService();
            List<Product> products = productService.GetProducts(sortBy);
            return products;
        }

        private void DisplayStudents(List<Student> students)
        {
            ShowListView(pnlStudents, listViewGeneral);

            listViewGeneral.Columns.Add("ID");
            listViewGeneral.Columns.Add("Name", 200);

            foreach (Student student in students)
            {
                ListViewItem listViewItem = new ListViewItem(student.StudentId.ToString());
                listViewItem.Tag = student;
                listViewItem.SubItems.Add(student.Name);
                listViewGeneral.Items.Add(listViewItem);
            }

            SetHeader("Students");
        }

        private void DisplayTeachers(List<Teacher> teachers)
        {
            ShowListView(pnlTeachers, listViewGeneral);

            listViewGeneral.Columns.Add("ID");
            listViewGeneral.Columns.Add("Name", 200);

            foreach (Teacher teacher in teachers)
            {
                ListViewItem listViewItem = new ListViewItem(teacher.TeacherId.ToString());
                listViewItem.Tag = teacher;
                listViewItem.SubItems.Add(teacher.Name);
                listViewGeneral.Items.Add(listViewItem);
            }

            SetHeader("Teachers");
        }

        private void DisplayActivities(List<Activity> activities)
        {
            ShowListView(pnlActivities, listViewGeneral);

            listViewGeneral.Columns.Add("ID");
            listViewGeneral.Columns.Add("Name", 200);

            foreach (Activity activity in activities)
            {
                ListViewItem listViewItem = new ListViewItem(activity.ActivityId.ToString());
                listViewItem.Tag = activities;
                listViewItem.SubItems.Add(activity.Name);
                listViewGeneral.Items.Add(listViewItem);
            }

            SetHeader("Activities");
        }

        private void DisplayRooms(List<Room> rooms)
        {
            ShowListView(pnlRooms, listViewGeneral);

            listViewGeneral.Columns.Add("ID");
            listViewGeneral.Columns.Add("Name", 200);

            foreach (Room room in rooms)
            {
                ListViewItem listViewItem = new ListViewItem(room.RoomId.ToString());
                listViewItem.Tag = room;
                listViewItem.SubItems.Add(room.Name);
                listViewGeneral.Items.Add(listViewItem);
            }

            SetHeader("Rooms");
        }

        private ListViewItem AddProductListView(Product product)
        {
            ListViewItem item = new ListViewItem(product.ProductId.ToString());
            item.Tag = product;
            item.SubItems.Add(product.Name);
            item.SubItems.Add(product.Stock.ToString());
            item.SubItems.Add($"{product.VATRate * 100}%");
            item.SubItems.Add($"€{product.Price:0.00}");
            item.SubItems.Add(Helpers.StockToMessage(product.Stock));

            return item;
        }

        private void DisplayProducts(List<Product> products)
        {
            listViewPanelProducts.Clear();

            listViewPanelProducts.Columns.Add("ID", 50);
            listViewPanelProducts.Columns.Add("Name", 150);
            listViewPanelProducts.Columns.Add("Stock", 100);
            listViewPanelProducts.Columns.Add("VATRate", 100);
            listViewPanelProducts.Columns.Add("Price", 100);
            listViewPanelProducts.Columns.Add("Status", 150);

            foreach (Product product in products)
            {
                ListViewItem item = AddProductListView(product);
                listViewPanelProducts.Items.Add(item);
            }

            SetHeader("Products");

        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            if (this.selectedProduct != null)
            {
                ProductService productService = new ProductService();
                productService.DeleteProduct(this.selectedProduct);

                MessageBox.Show("Product deleted successfully!");
                ShowProductsPanel();
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }

            ProductFormSetEmpty();
        }

        private void DisplayRevenue(DateTime start, DateTime end)
        {
            try
            {
                Revenue revenue = GetRevenue(start, end);

                outputRevenue.Text = $"Turnover: €{revenue.Turnover:0.00}\nUnique Customers: {revenue.UniqueCustomers}\nTotal Drinks Sold: {revenue.TotalDrinksSold}";
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the revenue: " + e.Message);
            }
        }

        private void DisplayOrderStudents(List<Student> students)
        {
            ordersComboBox.Items.Clear();

            foreach (Student student in students)
            {
                ordersComboBox.Items.Add(student);
            }

            SetHeader("Order");
        }

        private void DisplayOrderProducts(List<Product> products)
        {
            flowLayoutPanelOrderProducts.Controls.Clear();
            foreach (Product product in products)
            {
                Button btn = new Button();
                btn.Size = new Size(150, 75);
                btn.Text = product.Name;
                btn.Tag = product;
                btn.MouseClick += orderProduct_Click;
                flowLayoutPanelOrderProducts.Controls.Add(btn);
            }

            ResetUnprocessedOrder();
        }

        private void ResetUnprocessedOrder()
        {
            this.unprocessedOrder = new Order();
            this.unprocessedOrder.Student = this.selectedOrderStudent;
            this.unprocessedOrder.OrderLines = new List<OrderLine>();
        }

        private void CreateVatLabels(Dictionary<string,object> summary, int counter)
        {
            Helpers.CopyAndCloneLabel(lblRecordTypeVat, Helpers.GetVatType((double)summary["VATRate"]).ToString(), counter);
            Helpers.CopyAndCloneLabel(lblRecordPercentage, ((double)summary["VATRate"] * 100).ToString() + "%", counter);
            Helpers.CopyAndCloneLabel(lblRecordOrders, summary["NumberOfOrders"].ToString(), counter);
            Helpers.CopyAndCloneLabel(lblRecordProducts, summary["TotalProductsSold"].ToString(), counter);
            Helpers.CopyAndCloneLabel(lblRecordTotal, $"€{summary["VATAmount"]:0.00}", counter);
        }

        private void DisplayVat(string quarter = null)
        {
            ResetVatLabels(quarter);
            VATService vatService = new VATService();
            List<Dictionary<string, object>> vatSummary = vatService.GetVatSummary(Helpers.GetQuarterDates(GetYear(), quarter));
            for (int i = 0; i < vatSummary.Count; i++)
            {
                CreateVatLabels(vatSummary[i], i);
            }

            double totalTaxNeeded = vatService.GetTotalTaxNeeded(Helpers.GetQuarterDates(GetYear(), quarter));
            lblTotalToPayValue.Text = $"€{Math.Round(totalTaxNeeded, 2)}";
        }

        private void ResetVatLabels(string quarter)
        {
            lblDates.Text = Helpers.GetQuarterDates(GetYear(), quarter)[0].ToString("dddd dd/MM/yyyy") + " - " + Helpers.GetQuarterDates(GetYear(), quarter)[1].ToString("dddd dd/MM/yyyy");
            Helpers.RemoveControlsWithTag("clonedLabel", this);
            lblRecordTypeVat.Text = "Overig";
            lblRecordPercentage.Text = "0%";
            lblRecordOrders.Text = "0";
            lblRecordProducts.Text = "0";
            lblRecordTotal.Text = "€0.00";
        }

        private int GetYear()
        {
            if (txtYear.Text.Length == 4 && int.TryParse(txtYear.Text, out int year)) return year;
            else
            {
                if (txtYear.Text.Length != 0) MessageBox.Show("Invalid year");

                return DateTime.Now.Year;
            }
        }

        private void orderProduct_Click(object sender, EventArgs e)
        {
            Product product = (Product)((Button)sender).Tag;

            bool alreadyInOrder = false;
            foreach (OrderLine orderLine in this.unprocessedOrder.OrderLines)
            {
                if (orderLine.Product.ProductId == product.ProductId)
                {
                    alreadyInOrder = true;
                    orderLine.Quantity++;
                }
            }

            if (!alreadyInOrder) CreateOrderLine(product);
            if (!orderProcessButton.Visible) orderProcessButton.Visible = true;
            UpdateOrderDetailsLabel();
        }

        private void CreateOrderLine(Product product)
        {
            OrderLine orderLine = new OrderLine();
            orderLine.Order = this.unprocessedOrder;
            orderLine.Product = product;
            orderLine.Quantity = 1;

            this.unprocessedOrder.OrderLines.Add(orderLine);
        }

        private void orderProcessButton_Click(object sender, EventArgs e)
        {
            OrderService orderService = new OrderService();
            orderService.StoreOrder(this.unprocessedOrder);
            this.unprocessedOrder = new Order();
            this.unprocessedOrder.Student = this.selectedOrderStudent;
            this.unprocessedOrder.OrderLines = new List<OrderLine>();
            orderDetailsLabel.Text = "";
            orderProcessButton.Visible = false;
        }

        private void UpdateOrderDetailsLabel()
        {
            string orderDetails = "";
            orderDetails += this.unprocessedOrder.ToString();
            orderDetails += "\n";
            orderDetails += $"Total price: €{this.unprocessedOrder.TotalPrice:0.00}";

            orderDetailsLabel.Text = orderDetails;
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetHeader("Dashboard", false);
            ShowPanel(pnlDashboard);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTeachersPanel();
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProductsPanel();
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRevenuePanel();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOrderStudentsPanel();
        }

        private void ordersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedOrderStudent = (Student)ordersComboBox.SelectedItem;
            this.unprocessedOrder = new Order();
            this.unprocessedOrder.Student = this.selectedOrderStudent;
            this.unprocessedOrder.OrderLines = new List<OrderLine>();
            orderDetailsLabel.Text = "";
            orderProcessButton.Visible = false;
            ShowOrderProductsList();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            ShowPanel(pnlDashboard);
        }

        private void ProductFormSetProduct(Product product)
        {
            if (product == null) {
                ProductFormSetEmpty();
                return;
            }

            productEditButton.Text = "Edit";
            productEditNameInput.Text = product.Name;
            productEditStockInput.Value = Math.Max(product.Stock, 0);
            productEditAlcoholInput.Checked = product.IsAlcoholic;
            productEditPriceInput.Value = (decimal)product.Price;
        }

        private void ProductFormSetEmpty()
        {
            productEditButton.Text = "Create";
            productEditNameInput.Text = "";
            productEditStockInput.Value = 0;
            productEditAlcoholInput.Checked = false;
            productEditPriceInput.Value = 0.00M;
        }

        private void listViewPanelProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listViewPanelProducts.SelectedItems.Count == 0 ? null : listViewPanelProducts.SelectedItems[0];
            this.selectedProduct = (Product)selectedItem?.Tag;
            ProductFormSetProduct(this.selectedProduct);
            productDeleteButton.Visible = this.selectedProduct == null ? false : true;
        }

        private void productEditButton_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            Product newProduct = new Product()
            {
                Name = productEditNameInput.Text,
                Stock = (int)productEditStockInput.Value,
                VATRate = productEditAlcoholInput.Checked ? Product.ALCOHOL_VAT_RATE : Product.NORMAL_VAT_RATE,
                Price = decimal.ToDouble(productEditPriceInput.Value)
            };

            if (selectedProduct == null) productService.CreateProduct(newProduct);
            else
            {
                newProduct.ProductId = selectedProduct.ProductId;
                productService.UpdateProduct(newProduct);
            }

            MessageBox.Show(selectedProduct == null ? "Product added successfully!" : "Product created successfully!");

            ProductFormSetEmpty();
            ShowProductsPanel();
        }

        private string FormatDate(DateTime date)
        {
            return date.ToString("dd-MM-yyyy");
        }

        private void UpdateRevenueSelector(object sender, EventArgs e)
        {
            DateTime startDate = revenueDateStart.Value;
            DateTime endDate = revenueDateEnd.Value;

            if (FormatDate(startDate) != FormatDate(endDate))
            {
                revenueDateStart.MaxDate = endDate;
                revenueDateEnd.MinDate = startDate;
            }

            DisplayRevenue(startDate, endDate);
        }

        private void vatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowVatPanel();
        }

        private void btnQ1_Click(object sender, EventArgs e)
        {
            DisplayVat("Q1");
        }

        private void btnQ2_Click(object sender, EventArgs e)
        {
            DisplayVat("Q2");
        }

        private void btnQ3_Click(object sender, EventArgs e)
        {
            DisplayVat("Q3");
        }

        private void btnQ4_Click(object sender, EventArgs e)
        {
            DisplayVat("Q4");
        }
    }
}

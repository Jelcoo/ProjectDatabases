using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        List<Panel> panelList = new List<Panel>();
        Student selectedOrderStudent = null;
        Order unprocessedOrder = null;

        public SomerenUI()
        {
            InitializeComponent();

            panelList.Add(pnlDashboard);
            panelList.Add(pnlStudents);
            panelList.Add(pnlTeachers);
            panelList.Add(pnlActivities);
            panelList.Add(pnlRooms);
            panelList.Add(pnlRevenue);
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

        private Button NewButton()
        {
            Button btn = new Button();
            btn.Size = new Size(200, 75);

            return btn;
        }

        private void ShowStudentsPanel()
        {
            ShowPanel(pnlStudents);

            try
            {
                // get and display all students
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
                // get and display all students
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
                // get and display all rooms
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
                // get and display all activities
                List<Activity> activities = GetActivities("name DESC");
                DisplayActivities(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }

        private void ShowOrderStudentsPanel()
        {
            ShowPanel(pnlOrders);

            try
            {
                // get and add all students
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
                // get and display all products
                List<Product> products = GetProducts("name ASC");
                DisplayOrderProducts(products);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the order for student: " + e.Message);
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

        private List<Activity> GetActivities(string sortBy)
        {
            ActivityService activityService = new ActivityService();
            List<Activity> activities = activityService.GetActivities(sortBy);
            return activities;
        }

        private List<Room> GetRooms(string sortBy)
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms(sortBy);
            return rooms;
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

        private void DisplayRevenue(DateTime start, DateTime end)
        {
            try
            {
                // get and display revenue
                Revenue revenue = GetRevenue(start, end);

                OutputRevenue.Text = $"Turnover: {revenue.Turnover}\nUnique Customers: {revenue.UniqueCustomers}\nTotal Drinks Sold: {revenue.TotalDrinksSold}";
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

            this.unprocessedOrder = new Order();
            this.unprocessedOrder.Student = this.selectedOrderStudent;
            this.unprocessedOrder.OrderLines = new List<OrderLine>();
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

            if (!alreadyInOrder)
            {
                OrderLine orderLine = new OrderLine();
                orderLine.Order = this.unprocessedOrder;
                orderLine.Product = product;
                orderLine.Quantity = 1;

                this.unprocessedOrder.OrderLines.Add(orderLine);
            }

            UpdateOrderDetailsLabel();

            if (!orderProcessButton.Visible)
            {
                orderProcessButton.Visible = true;
            }
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

        private void updateRevenueSelector(object sender, EventArgs e)
        {
            DateTime startDate = revenueDateStart.Value;
            DateTime endDate = revenueDateEnd.Value;

            revenueDateStart.MaxDate = endDate;
            revenueDateEnd.MinDate = startDate;

            DisplayRevenue(startDate, endDate);
        }
    }
}

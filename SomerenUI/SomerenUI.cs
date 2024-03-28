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
        private Student selectedStudent;
        private Teacher selectedTeacher;
        private string selectedQuarter = null;
        private Activity participantSelectedActivity;
        private Activity supervisorSelectedActivity;


        public SomerenUI()
        {
            InitializeComponent();

            panelList.Add(pnlDashboard);
            panelList.Add(pnlStudents);
            panelList.Add(pnlTeachers);
            panelList.Add(pnlActivities);
            panelList.Add(pnlActivityParticipants);
            panelList.Add(pnlActivitySupervisors);
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
                List<Student> students = GetStudents();
                DisplayStudents(students);
                DisplayRoomsDropdown(studentEditRoomSelect);
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
                List<Teacher> teachers = GetTeachers();
                DisplayTeachers(teachers);
                DisplayRoomsDropdown(teacherEditRoomSelect);
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
                List<Room> rooms = GetRooms();
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

        private void ShowActivityParticipantsPanel()
        {
            ShowPanel(pnlActivityParticipants);

            try
            {
                List<Activity> activities = GetActivities();
                DisplayParticipantsActivityList(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activity list: " + e.Message);
            }
        }

        private void ShowActivitySupervisorsPanel()
        {
            ShowPanel(pnlActivitySupervisors);

            try
            {
                List<Activity> activities = GetActivities();
                DisplaySupervisorsActivityList(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activity list: " + e.Message);
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
                List<Student> students = GetStudents();
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
                List<Product> products = GetProducts();
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

        private void DisplayRoomsDropdown(ComboBox comboBox)
        {
            List<Room> rooms = GetRooms();
            comboBox.Items.Clear();
            foreach (Room room in rooms)
            {
                comboBox.Items.Add(room);
            }
            comboBox.SelectedIndex = 0;
        }

        private void DisplayParticipantsActivityList(List<Activity> activities)
        {
            activityParticipantsList.Items.Clear();
            activityParticipantsList.Columns.Clear();

            activityParticipantsList.Columns.Add("ID");
            activityParticipantsList.Columns.Add("Name", 200);

            foreach (Activity activity in activities)
            {
                ListViewItem listViewItem = new ListViewItem(activity.ActivityId.ToString());
                listViewItem.Tag = activity;
                listViewItem.SubItems.Add(activity.Name);
                activityParticipantsList.Items.Add(listViewItem);
            }

            SetHeader("Activity Participants");
        }

        private void ShowParticipants()
        {
            try
            {
                List<Student> assignedStudents = GetActivityAssignedStudents();
                List<Student> unassignedStudents = GetActivityUnassignedStudents();
                ShowParticipantsList(assignedStudents, activityParticipantsAssigned);
                ShowParticipantsList(unassignedStudents, activityParticipantsUnassigned);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activity participants: " + e.Message);
            }
        }

        private void ShowSupervisors()
        {
            try
            {
                List<Teacher> assignedSupervisors = GetActivityAssignedSupervisors();
                List<Teacher> unassignedSupervisors = GetActivityUnassignedSupervisors();
                ShowSupervisorsList(assignedSupervisors, activitySupervisorsAssigned);
                ShowSupervisorsList(unassignedSupervisors, activitySupervisorsUnassigned);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activity Supervisors: " + e.Message);
            }
        }


        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private List<Teacher> GetTeachers()
        {
            TeacherService teacherService = new TeacherService();
            List<Teacher> teachers = teacherService.GetTeachers();
            return teachers;
        }

        private List<Activity> GetActivities()
        {
            ActivityService activityService = new ActivityService();
            List<Activity> activities = activityService.GetActivities();
            return activities;
        }

        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
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

        private List<Student> GetActivityAssignedStudents()
        {
            ActivityService activityService = new ActivityService();
            List<Student> students = activityService.GetActivityAssignedStudents(this.participantSelectedActivity);
            return students;
        }

        private List<Student> GetActivityUnassignedStudents()
        {
            ActivityService activityService = new ActivityService();
            List<Student> students = activityService.GetActivityUnassignedStudents(this.participantSelectedActivity);
            return students;
        }

        private List<Teacher> GetActivityAssignedSupervisors()
        {
            ActivityService activityService = new ActivityService();
            List<Teacher> teachers = activityService.GetActivityAssignedTeachers(this.supervisorSelectedActivity);
            return teachers;
        }

        private List<Teacher> GetActivityUnassignedSupervisors()
        {
            ActivityService activityService = new ActivityService();
            List<Teacher> teachers = activityService.GetActivityUnassignedTeachers(this.supervisorSelectedActivity);
            return teachers;
        }

        private void DisplaySupervisorsActivityList(List<Activity> activities)
        {
            activitySupervisorsList.Items.Clear();
            activitySupervisorsList.Columns.Clear();

            activitySupervisorsList.Columns.Add("ID");
            activitySupervisorsList.Columns.Add("Name", 200);

            foreach (Activity activity in activities)
            {
                ListViewItem listViewItem = new ListViewItem(activity.ActivityId.ToString());
                listViewItem.Tag = activity;
                listViewItem.SubItems.Add(activity.Name);
                activitySupervisorsList.Items.Add(listViewItem);
            }

            SetHeader("Activity Supervisors");
        }

        private void ShowParticipantsList(List<Student> students, ListView list)
        {
            list.Items.Clear();
            list.Columns.Clear();

            list.Columns.Add("ID");
            list.Columns.Add("Name", 200);
            list.Columns.Add("Phone number", 200);
            list.Columns.Add("Class", 100);

            foreach (Student student in students)
            {
                ListViewItem listViewItem = new ListViewItem(student.StudentId.ToString());
                listViewItem.Tag = student;
                listViewItem.SubItems.Add(student.Name);
                listViewItem.SubItems.Add(student.PhoneNumber.ToString());
                listViewItem.SubItems.Add(student.Class);
                list.Items.Add(listViewItem);
            }
        }

        private void ShowSupervisorsList(List<Teacher> teachers, ListView list)
        {
            list.Items.Clear();
            list.Columns.Clear();

            list.Columns.Add("ID");
            list.Columns.Add("Name", 200);

            foreach (Teacher teacher in teachers)
            {
                ListViewItem listViewItem = new ListViewItem(teacher.TeacherId.ToString());
                listViewItem.Tag = teacher;
                listViewItem.SubItems.Add(teacher.Name);
                list.Items.Add(listViewItem);
            }
        }

        private void DisplayStudents(List<Student> students)
        {
            listViewPanelStudents.Clear();

            listViewPanelStudents.Columns.Add("Studentnr", 100);
            listViewPanelStudents.Columns.Add("Name", 200);
            listViewPanelStudents.Columns.Add("Phone number", 200);
            listViewPanelStudents.Columns.Add("Class", 100);
            listViewPanelStudents.Columns.Add("Vouchers", 100);
            listViewPanelStudents.Columns.Add("Room", 70);

            foreach (Student student in students)
            {
                ListViewItem listViewItem = new ListViewItem(student.StudentId.ToString());
                listViewItem.Tag = student;
                listViewItem.SubItems.Add(student.Name);
                listViewItem.SubItems.Add(student.PhoneNumber.ToString());
                listViewItem.SubItems.Add(student.Class);
                listViewItem.SubItems.Add(student.Vouchers.ToString());
                listViewItem.SubItems.Add(student.Room.Name);

                listViewPanelStudents.Items.Add(listViewItem);
            }

            SetHeader("Students");
        }

        private void DisplayTeachers(List<Teacher> teachers)
        {
            listViewPanelteachers.Clear();

            listViewPanelteachers.Columns.Add("Teachernr", 100);
            listViewPanelteachers.Columns.Add("Name", 200);
            listViewPanelteachers.Columns.Add("Phone number", 200);
            listViewPanelteachers.Columns.Add("Date of birth", 200);
            listViewPanelteachers.Columns.Add("Room", 70);

            foreach (Teacher teacher in teachers)
            {
                ListViewItem listViewItem = new ListViewItem(teacher.TeacherId.ToString());
                listViewItem.Tag = teacher;
                listViewItem.SubItems.Add(teacher.Name);
                listViewItem.SubItems.Add(teacher.PhoneNumber.ToString());
                listViewItem.SubItems.Add(teacher.DateOfBirth.ToString("dd/MM/yyyy"));
                listViewItem.SubItems.Add(teacher.Room.Name);
                listViewPanelteachers.Items.Add(listViewItem);
            }

            SetHeader("Teachers");
        }

        private void DisplayActivities(List<Activity> activities)
        {
            ShowListView(pnlActivities, listViewGeneral);

            listViewGeneral.Columns.Add("Name", 200);
            listViewGeneral.Columns.Add("Location", 200);
            listViewGeneral.Columns.Add("Start", 200);
            listViewGeneral.Columns.Add("End", 200);

            foreach (Activity activity in activities)
            {
                ListViewItem listViewItem = new ListViewItem(activity.Name);
                listViewItem.Tag = activities;
                listViewItem.SubItems.Add(activity.Location);
                listViewItem.SubItems.Add(activity.StartOfActivity.ToString("dd/MM/yyyy HH:mm"));
                listViewItem.SubItems.Add(activity.EndOfActivity.ToString("dd/MM/yyyy HH:mm"));
                listViewGeneral.Items.Add(listViewItem);
            }

            SetHeader("Activities");
        }

        private void DisplayRooms(List<Room> rooms)
        {
            ShowListView(pnlRooms, listViewGeneral);

            listViewGeneral.Columns.Add("Name", 200);
            listViewGeneral.Columns.Add("Building", 100);
            listViewGeneral.Columns.Add("Floor", 100);
            listViewGeneral.Columns.Add("Capacity", 100);

            foreach (Room room in rooms)
            {
                ListViewItem listViewItem = new ListViewItem(room.Name);
                listViewItem.Tag = room;
                listViewItem.SubItems.Add(room.Building);
                listViewItem.SubItems.Add(room.Floor.ToString());
                listViewItem.SubItems.Add(room.AmountOfBeds.ToString());
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
                DialogResult result = MessageBox.Show("Are you sure you want to unassign the selected teacher?", "Confirm Unassign", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;

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

        private void DeleteTeacherButton_Click(object sender, EventArgs e)
        {
            if (this.selectedTeacher != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to unassign the selected teacher?", "Confirm Unassign", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;

                TeacherService teacherService = new TeacherService();
                teacherService.DeleteTeacher(this.selectedTeacher);

                MessageBox.Show("Teacher deleted successfully!");
                ShowTeachersPanel();
            }
            else
            {
                MessageBox.Show("Please select a teacher to delete.");
            }

            TeacherFormSetEmpty();
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            if (this.selectedStudent != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to unassign the selected student?", "Confirm Unassign", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;

                StudentService studentService = new StudentService();
                studentService.DeleteStudent(this.selectedStudent);

                MessageBox.Show("Student deleted successfully!");
                ShowStudentsPanel();
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }

            StudentFormSetEmpty();
        }

        private void DisplayRevenue(DateTime start, DateTime end)
        {
            try
            {
                Revenue revenue = GetRevenue(start, end);

                outputRevenue.Text = @$"
Turnover: €{revenue.Turnover:0.00}
Unique Customers: {revenue.UniqueCustomers}
Total Drinks Sold: {revenue.TotalDrinksSold}";
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
            this.unprocessedOrder = new Order(this.selectedOrderStudent);
        }

        private void CreateVatLabels(Dictionary<string, object> summary, int counter)
        {
            Helpers.CopyAndCloneLabel(lblRecordTypeVat, Helpers.GetVatType((double)summary["VATRate"]).ToString(), counter);
            Helpers.CopyAndCloneLabel(lblRecordPercentage, ((double)summary["VATRate"] * 100).ToString() + "%", counter);
            Helpers.CopyAndCloneLabel(lblRecordOrders, summary["NumberOfOrders"].ToString(), counter);
            Helpers.CopyAndCloneLabel(lblRecordProducts, summary["TotalProductsSold"].ToString(), counter);
            Helpers.CopyAndCloneLabel(lblRecordTotal, $"€{summary["VATAmount"]:0.00}", counter);
        }

        private void DisplayVat()
        {
            ResetVatLabels(selectedQuarter);
            VATService vatService = new VATService();
            List<Dictionary<string, object>> vatSummary = vatService.GetVatSummary(Helpers.GetQuarterDates((int)txtYear.Value, selectedQuarter));
            for (int i = 0; i < vatSummary.Count; i++)
            {
                CreateVatLabels(vatSummary[i], i);
            }

            double totalTaxNeeded = vatService.GetTotalTaxNeeded(Helpers.GetQuarterDates((int)txtYear.Value, selectedQuarter));
            lblTotalToPayValue.Text = $"€{Math.Round(totalTaxNeeded, 2)}";
        }

        private void ResetVatLabels(string quarter)
        {
            lblDates.Text = Helpers.GetQuarterDates((int)txtYear.Value, quarter)[0].ToString("dddd dd/MM/yyyy") + " - " + Helpers.GetQuarterDates((int)txtYear.Value, quarter)[1].ToString("dddd dd/MM/yyyy");
            Helpers.RemoveControlsWithTag("clonedLabel", this);
            lblRecordTypeVat.Text = "Overig";
            lblRecordPercentage.Text = "0%";
            lblRecordOrders.Text = "0";
            lblRecordProducts.Text = "0";
            lblRecordTotal.Text = "€0.00";
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
                    orderLine.IncreaseQuantity(1);
                }
            }

            if (!alreadyInOrder) CreateOrderLine(product);
            if (!orderProcessButton.Visible) orderProcessButton.Visible = true;
            UpdateOrderDetailsLabel();
        }

        private void CreateOrderLine(Product product)
        {
            OrderLine orderLine = new OrderLine(this.unprocessedOrder, product, 1);
            this.unprocessedOrder.AddOrderLine(orderLine);
        }

        private void orderProcessButton_Click(object sender, EventArgs e)
        {
            OrderService orderService = new OrderService();
            orderService.StoreOrder(this.unprocessedOrder);
            this.unprocessedOrder = new Order(this.selectedOrderStudent);
            orderDetailsLabel.Text = "";
            orderProcessButton.Visible = false;
        }

        private void UpdateOrderDetailsLabel()
        {
            string orderDetails = "";
            orderDetails += this.unprocessedOrder.ToString();
            orderDetails += "\n";
            orderDetails += $"Total price: €{this.unprocessedOrder.TotalPrice():0.00}";

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

        private void activitiesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
        }

        private void activityParticipantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivityParticipantsPanel();
        }

        private void activitySupervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivitySupervisorsPanel();
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
            this.unprocessedOrder = new Order(this.selectedOrderStudent);
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
            if (product == null)
            {
                ProductFormSetEmpty();
                return;
            }

            productEditButton.Text = "Edit";
            productEditNameInput.Text = product.Name;
            productEditStockInput.Value = Math.Max(product.Stock, 0);
            productEditAlcoholInput.Checked = product.DrinkType == DrinkType.Alcoholic;
            productEditPriceInput.Value = (decimal)product.Price;
        }

        private void TeacherFormSetTeacher(Teacher teacher)
        {
            if (teacher == null)
            {
                TeacherFormSetEmpty();
                return;
            }

            teacherEditButton.Text = "Edit";
            teacherEditFirstNameInput.Text = teacher.FirstName;
            teacherEditLastNameInput.Text = teacher.LastName;
            teacherEditPhoneNumberInput.Value = teacher.PhoneNumber;
            teacherEditDateOfBirthInput.Text = teacher.DateOfBirth.ToString();
            teacherEditRoomSelect.SelectedItem = teacher.Room;
        }

        private void ProductFormSetEmpty()
        {
            productEditButton.Text = "Create";
            productEditNameInput.Text = "";
            productEditStockInput.Value = 0;
            productEditAlcoholInput.Checked = false;
            productEditPriceInput.Value = 0.00M;
        }

        private void TeacherFormSetEmpty()
        {
            teacherEditButton.Text = "Create";
            teacherEditFirstNameInput.Text = "";
            teacherEditLastNameInput.Text = "";
            teacherEditPhoneNumberInput.Text = "";
            teacherEditDateOfBirthInput.Text = DateTime.Now.ToString();
            teacherEditRoomSelect.SelectedIndex = 0;
        }

        private void listViewPanelProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listViewPanelProducts.SelectedItems.Count == 0 ? null : listViewPanelProducts.SelectedItems[0];
            this.selectedProduct = (Product)selectedItem?.Tag;
            ProductFormSetProduct(this.selectedProduct);
            productDeleteButton.Visible = this.selectedProduct == null ? false : true;
        }

        private void listViewPanelTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listViewPanelteachers.SelectedItems.Count == 0 ? null : listViewPanelteachers.SelectedItems[0];
            this.selectedTeacher = (Teacher)selectedItem?.Tag;
            TeacherFormSetTeacher(this.selectedTeacher);
            teachersDeleteButton.Visible = this.selectedTeacher == null ? false : true;
        }

        private void productEditButton_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();

            string productName = productEditNameInput.Text;
            int productStock = (int)productEditStockInput.Value;
            double productVatRate = productEditAlcoholInput.Checked ? Product.ALCOHOL_VAT_RATE : Product.NORMAL_VAT_RATE;
            double productPrice = decimal.ToDouble(productEditPriceInput.Value);

            if (selectedProduct == null) {
                productService.CreateProduct(new Product(productName, productStock, productVatRate, productPrice));
            } else
            {
                productService.UpdateProduct(new Product(selectedProduct.ProductId, productName, productStock, productVatRate, productPrice));
            }

            MessageBox.Show(selectedProduct == null ? "Product created successfully!" : "Product edited successfully!");

            ProductFormSetEmpty();
            ShowProductsPanel();
        }

        private void StudentFormSetStudent(Student student)
        {
            if (student == null)
            {
                StudentFormSetEmpty();
                return;
            }

            studentEditButton.Text = "Edit";
            studentEditFirstNameInput.Text = student.FirstName;
            studentEditLastNameInput.Text = student.LastName;
            studentEditPhoneNumberInput.Value = student.PhoneNumber;
            studentEditClassInput.Text = student.Class;
            studentEditVouchersNumerric.Value = student.Vouchers;
            studentEditRoomSelect.SelectedItem = student.Room;
        }

        private void StudentFormSetEmpty()
        {
            studentEditButton.Text = "Create";
            studentEditFirstNameInput.Text = "";
            studentEditLastNameInput.Text = "";
            studentEditPhoneNumberInput.Text = "";
            studentEditClassInput.Text = "";
            studentEditVouchersNumerric.Value = 0;
            studentEditRoomSelect.SelectedIndex = 0;
        }

        private void listViewPanelStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listViewPanelStudents.SelectedItems.Count == 0 ? null : listViewPanelStudents.SelectedItems[0];
            this.selectedStudent = (Student)selectedItem?.Tag;
            StudentFormSetStudent(this.selectedStudent);
            studentDeleteButton.Visible = this.selectedStudent == null ? false : true;
        }

        private void studentEditButton_Click(object sender, EventArgs e)
        {
            StudentService studentService = new StudentService();

            string firstName = studentEditFirstNameInput.Text;
            string lastName = studentEditLastNameInput.Text;
            long phoneNumber = (long)studentEditPhoneNumberInput.Value;
            string @class = studentEditClassInput.Text;
            int vouchers = (int)studentEditVouchersNumerric.Value;
            Room room = (Room)studentEditRoomSelect.SelectedItem;

            if (CheckInputFields(firstName, lastName, phoneNumber, @class, vouchers, room)) {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (selectedStudent == null) studentService.CreateStudent(new Student(firstName, lastName, phoneNumber, @class, vouchers).SetRoom(room));
            else
            {
                studentService.UpdateStudent(new Student(selectedStudent.StudentId, firstName, lastName, phoneNumber, @class, vouchers).SetRoom(room));
            }

            MessageBox.Show(selectedStudent == null ? "student created successfully!" : "student edited successfully!");

            StudentFormSetEmpty();
            ShowStudentsPanel();
        }

        private void teacherEditButton_Click(object sender, EventArgs e)
        {
            TeacherService teacherService = new TeacherService();

            string firstName = teacherEditFirstNameInput.Text;
            string lastName = teacherEditLastNameInput.Text;
            long phoneNumber = (long)teacherEditPhoneNumberInput.Value;
            DateTime dateOfBirth = teacherEditDateOfBirthInput.Value;
            Room room = (Room)teacherEditRoomSelect.SelectedItem;

            if (CheckInputFields(firstName, lastName, phoneNumber, dateOfBirth, room)) {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (selectedTeacher == null) teacherService.CreateTeacher(new Teacher(firstName, lastName, phoneNumber, dateOfBirth).SetRoom(room));
            else
            {
                teacherService.UpdateTeacher(new Teacher(selectedTeacher.TeacherId, firstName, lastName, phoneNumber, dateOfBirth).SetRoom(room));
            }

            MessageBox.Show(selectedTeacher == null ? "Teacher created successfully!" : "Teacher updated successfully!");

            TeacherFormSetEmpty();
            ShowTeachersPanel();
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
            this.selectedQuarter = "Q1";
            DisplayVat();
        }

        private void btnQ2_Click(object sender, EventArgs e)
        {
            this.selectedQuarter = "Q2";
            DisplayVat();
        }

        private void btnQ3_Click(object sender, EventArgs e)
        {
            this.selectedQuarter = "Q3";
            DisplayVat();
        }

        private void btnQ4_Click(object sender, EventArgs e)
        {
            this.selectedQuarter = "Q4";
            DisplayVat();
        }

        private void txtYear_ValueChanged(object sender, EventArgs e)
        {
            DisplayVat();
        }

        private void activityParticipantsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem = activityParticipantsList.SelectedItems.Count == 0 ? null : activityParticipantsList.SelectedItems[0];
            this.participantSelectedActivity = (Activity)selectedItem?.Tag;
            if (this.participantSelectedActivity != null)
            {
                ShowParticipants();
            }
            activityParticipantAssignButton.Enabled = false;
            activityParticipantUnassignButton.Enabled = false;
        }

        private void activityParticipantsUnassigned_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem = activityParticipantsUnassigned.SelectedItems.Count == 0 ? null : activityParticipantsUnassigned.SelectedItems[0];
            if (selectedItem == null)
            {
                activityParticipantAssignButton.Enabled = false;
                activityParticipantUnassignButton.Enabled = false;
            }
            else
            {
                activityParticipantAssignButton.Enabled = true;
                activityParticipantUnassignButton.Enabled = false;
            }
        }

        private void activityParticipantsAssigned_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem = activityParticipantsAssigned.SelectedItems.Count == 0 ? null : activityParticipantsAssigned.SelectedItems[0];
            if (selectedItem == null)
            {
                activityParticipantAssignButton.Enabled = false;
                activityParticipantUnassignButton.Enabled = false;
            }
            else
            {
                activityParticipantAssignButton.Enabled = false;
                activityParticipantUnassignButton.Enabled = true;
            }
        }

        private void activitySupervisorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem = activitySupervisorsList.SelectedItems.Count == 0 ? null : activitySupervisorsList.SelectedItems[0];
            this.supervisorSelectedActivity = (Activity)selectedItem?.Tag;
            if (this.supervisorSelectedActivity != null)
            {
                ShowSupervisors();
            }
            activitySupervisorAssignButton.Enabled = false;
            activitySupervisorUnassignButton.Enabled = false;
        }

        private void activitySupervisorsUnassigned_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem = activitySupervisorsUnassigned.SelectedItems.Count == 0 ? null : activitySupervisorsUnassigned.SelectedItems[0];
            if (selectedItem == null)
            {
                activitySupervisorAssignButton.Enabled = false;
                activitySupervisorUnassignButton.Enabled = false;
            }
            else
            {
                activitySupervisorAssignButton.Enabled = true;
                activitySupervisorUnassignButton.Enabled = false;
            }
        }

        private void activitySupervisorsAssigned_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem = activitySupervisorsAssigned.SelectedItems.Count == 0 ? null : activitySupervisorsAssigned.SelectedItems[0];
            if (selectedItem == null)
            {
                activitySupervisorAssignButton.Enabled = false;
                activitySupervisorUnassignButton.Enabled = false;
            }
            else
            {
                activitySupervisorAssignButton.Enabled = false;
                activitySupervisorUnassignButton.Enabled = true;
            }
        }

        private void activityParticipantAssignButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem unassignedParticipant in activityParticipantsUnassigned.SelectedItems)
            {
                Student participant = (Student)unassignedParticipant.Tag;
                AssignStudent(participant, this.participantSelectedActivity);
            }
            ShowParticipants();
        }

        private void AssignStudent(Student student, Activity activity)
        {
            ActivityService activityService = new ActivityService();
            activityService.AssignStudent(student, activity);
        }

        private void activityParticipantUnassignButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to unassign the selected participant(s)?", "Confirm Unassign", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            foreach (ListViewItem assignedParticipant in activityParticipantsAssigned.SelectedItems)
            {
                Student participant = (Student)assignedParticipant.Tag;
                UnassignStudent(participant, this.participantSelectedActivity);
            }
            ShowParticipants();
        }

        private void UnassignStudent(Student student, Activity activity)
        {
            ActivityService activityService = new ActivityService();
            activityService.UnassignStudent(student, activity);
        }

        private void activitySupervisorAssignButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem unassignedSupervisor in activitySupervisorsUnassigned.SelectedItems)
            {
                Teacher teacher = (Teacher)unassignedSupervisor.Tag;
                AssignSupervisor(teacher, this.supervisorSelectedActivity);
            }
            ShowSupervisors();
        }

        private void AssignSupervisor(Teacher teacher, Activity activity)
        {
            ActivityService activityService = new ActivityService();
            activityService.AssignTeacher(teacher, activity);
        }

        private void activitySupervisorUnassignButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to unassign the selected supervisor(s)?", "Confirm Unassign", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            foreach (ListViewItem assignedSupervisor in activitySupervisorsAssigned.SelectedItems)
            {
                Teacher teacher = (Teacher)assignedSupervisor.Tag;
                UnassignSupervisor(teacher, this.supervisorSelectedActivity);
            }
            ShowSupervisors();
        }

        private void UnassignSupervisor(Teacher teacher, Activity activity)
        {
            ActivityService activityService = new ActivityService();
            activityService.UnassignTeacher(teacher, activity);
        }

        private bool CheckInputFields(params object[] fields)
        {
            foreach (var field in fields)
            {
                if (field == null || field.ToString() == "")
                {
                    return true;
                }
            }
            return false;
        }
    }
}

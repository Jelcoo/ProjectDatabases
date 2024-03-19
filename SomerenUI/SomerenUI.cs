using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Globalization;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        List<Panel> panelList = new List<Panel>();

        public SomerenUI()
        {
            InitializeComponent();


            panelList.Add(pnlDashboard);
            panelList.Add(pnlStudents);
            panelList.Add(pnlTeachers);
            panelList.Add(pnlActivities);
            panelList.Add(pnlRooms);
            panelList.Add(pnlProducts);

        }

        private void ShowPanel(Panel panel)
        {
            foreach (Panel item in panelList)
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

        private void ShowActivitiesPanel()
        {
            ShowPanel(pnlActivities);

            try
            {
                // get and display all activities
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
                // get and display all activities
                List<Product> products = GetProducts();
                DisplayProducts(products);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the products: " + e.Message);
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

        private void DisplayStudents(List<Student> students)
        {
            flowLayoutPanelStudents.Controls.Clear();

            foreach (Student student in students)
            {
                Button btn = NewButton();
                btn.Text = student.Name;
                btn.Tag = student;
                btn.BackColor = UIHelpers.StringToColor(student.Name);
                flowLayoutPanelStudents.Controls.Add(btn);
            }

            SetHeader("Students");
        }

        private void DisplayTeachers(List<Teacher> teachers)
        {
            flowLayoutPanelTeachers.Controls.Clear();

            foreach (Teacher teacher in teachers)
            {
                Button btn = NewButton();
                btn.Text = teacher.Name;
                btn.Tag = teacher;
                btn.BackColor = UIHelpers.StringToColor(teacher.Name);
                flowLayoutPanelTeachers.Controls.Add(btn);
            }

            SetHeader("Teachers");
        }

        private void DisplayActivities(List<Activity> activities)
        {
            flowLayoutPanelActivities.Controls.Clear();

            foreach (Activity activity in activities)
            {
                Button btn = NewButton();
                btn.Text = activity.Name;
                btn.Tag = activity;
                btn.BackColor = UIHelpers.StringToColor(activity.Name);
                flowLayoutPanelActivities.Controls.Add(btn);
            }

            SetHeader("Activities");
        }

        private void DisplayRooms(List<Room> rooms)
        {
            flowLayoutPanelRooms.Controls.Clear();

            foreach (Room room in rooms)
            {
                Button btn = NewButton();
                btn.Text = room.Name;
                btn.Tag = room;
                btn.BackColor = UIHelpers.StringToColor(room.Name);
                flowLayoutPanelRooms.Controls.Add(btn);
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
            item.SubItems.Add($"{product.Price:0.00}");
            if (product.Stock <= 0)
            {
                item.SubItems.Add("stock empty");
            }
            else if (product.Stock <= 10)
            {
                item.SubItems.Add("nearly depleted");
            }
            else
            {
                item.SubItems.Add("stock sufficient");
            }

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
            // Logic to delete a product
            // Assuming you have a way to select one for deletion
            // For example, if you have a list view, you can get the selected product from there

            if (this.selectedProduct != null)
            {
                ProductService productService = new ProductService();
                productService.DeleteProduct(this.selectedProduct);

                //    MessageBox.Show("Product deleted successfully!");
                ShowProductsPanel(); // Refresh products panel
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            SetHeader("Dashboard", false);
            ShowPanel(pnlDashboard);
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
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

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            ShowPanel(pnlDashboard);
        }

        private Product selectedProduct; // Declare a private field to store the selected product

        private void ProductFormSetProduct(Product product)
        {
            productEditButton.Text = "Edit";
            productEditNameInput.Text = product.Name;
            productEditStockInput.Value = product.Stock;
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
            // Check if any item is selected in the listViewPanelProducts
            if (listViewPanelProducts.SelectedItems.Count > 0)
            {
                // Retrieve the selected item from the listView
                ListViewItem selectedItem = listViewPanelProducts.SelectedItems[0];

                // Update the selectedProduct field with the selected product details
                this.selectedProduct = (Product)selectedItem.Tag;

                ProductFormSetProduct(this.selectedProduct);
                productDeleteButton.Visible = true;
            }
            else
            {
                // If no item is selected, set selectedProduct to null
                selectedProduct = null;
                ProductFormSetEmpty();
                productDeleteButton.Visible = false;
            }
        }

        private void productEditButton_Click(object sender, EventArgs e)
        {
            string name = productEditNameInput.Text;
            int stock = (int)productEditStockInput.Value;
            bool isAlcoholic = productEditAlcoholInput.Checked;
            double price = decimal.ToDouble(productEditPriceInput.Value);

            ProductService productService = new ProductService();

            if (selectedProduct == null)
            {
                Product newProduct = new Product()
                {
                    Name = name,
                    Stock = stock,
                    VATRate = isAlcoholic ? 0.21 : 0.09,
                    Price = price
                };

                Product createdProduct = productService.CreateProduct(newProduct);

                MessageBox.Show("Product added successfully!");
            }
            else
            {
                Product newProduct = new Product()
                {
                    ProductId = selectedProduct.ProductId,
                    Name = name,
                    Stock = stock,
                    VATRate = isAlcoholic ? 0.21 : 0.09,
                    Price = price
                };

                productService.UpdateProduct(newProduct);

                MessageBox.Show("Product updated successfully!");
            }

            ProductFormSetEmpty();
            ShowProductsPanel();
        }
    }
}
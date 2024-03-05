using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();

            // show students
            pnlStudents.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private void DisplayStudents(List<Student> students)
        {
            // Clear the ListView before filling it
            listViewStudents.Clear();
            listViewStudents.Items.Clear(); // Ensure all items are removed

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.Name); // Assuming Name is a concatenation of FirstName and LastName
                li.Tag = student; // Link student object to ListViewItem
                listViewStudents.Items.Add(li);
            }

            // Subscribe to the ItemActivate event to show a message box with student attributes
            listViewStudents.ItemActivate += ListViewStudents_ItemActivate;
        }

        private void ListViewStudents_ItemActivate(object sender, EventArgs e)
        {
            if (listViewStudents.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewStudents.SelectedItems[0];
                Student selectedStudent = selectedItem.Tag as Student; // Retrieve the Student object from the Tag

                if (selectedStudent != null)
                {
                    // Construct a string to display all student attributes
                    string studentDetails = $"Student ID: {selectedStudent.StudentId}\n"  +
                                            $"Name: {selectedStudent.Name}\n" +
                                            $"First Name: {selectedStudent.FirstName}\n" +
                                            $"Last Name: {selectedStudent.LastName}\n" +
                                            $"Phone Number: {selectedStudent.PhoneNumber}\n" +
                                            $"Class: {selectedStudent.Class}\n" +
                                            $"Vouchers: {selectedStudent.Vouchers}\n" +
                                            $"Room ID: {selectedStudent.RoomId}";

                    // Show a message box with the student details
                    MessageBox.Show(studentDetails, "Student Details");
                }
            }
        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }
    }
}
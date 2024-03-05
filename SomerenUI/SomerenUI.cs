using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

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
        }

        private void ShowPanel(Panel panel)
        {
            foreach (Panel item in panelList)
            {
                item.Hide();
            }
            panel.Show();
        }

        private void ShowStudentsPanel()
        {
            ShowPanel(pnlStudents);

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
        private void ShowTeachersPanel()
        {
            ShowPanel(pnlTeachers);

            try
            {
                // get and display all students
                List<Teacher> teachers = GetTeacher();
                DisplayTeachers(teachers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the Teachers: " + e.Message);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private List<Teacher> GetTeacher()
        {
            TeacherService teacherService = new TeacherService();
            List<Teacher> teachers = teacherService.GetTeachers();
            return teachers;
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

        private void DisplayTeachers(List<Teacher> teachers)
        {
            // Clear the ListView before filling it
            listViewTeachers.Clear();
            listViewTeachers.Items.Clear(); // Ensure all items are removed

            foreach (Teacher teacher in teachers)
            {
                ListViewItem li = new ListViewItem(teacher.Name); // Assuming Name is a concatenation of FirstName and LastName
                li.Tag = teacher; // Link student object to ListViewItem
                listViewTeachers.Items.Add(li);
            }

            // Subscribe to the ItemActivate event to show a message box with student attributes
            listViewTeachers.ItemActivate += ListViewTeachers_ItemActivate;
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
                    string studentDetails = $"Student ID: {selectedStudent.StudentId}\n" +
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

        private void ListViewTeachers_ItemActivate(object sender, EventArgs e)
        {
            if (listViewTeachers.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewTeachers.SelectedItems[0];
                Teacher selectedTeacher = selectedItem.Tag as Teacher; // Retrieve the Student object from the Tag

                if (selectedTeacher != null)
                {
                    // Construct a string to display all student attributes
                    string teacherDetails = $"Student ID: {selectedTeacher.TeacherId}\n" +
                                            $"Name: {selectedTeacher.Name}\n" +
                                            $"First Name: {selectedTeacher.FirstName}\n" +
                                            $"Last Name: {selectedTeacher.LastName}\n" +
                                            $"Phone Number: {selectedTeacher.PhoneNumber}\n" +
                                            $"Date Of Birth: {selectedTeacher.DateOfBirth:dd/MM/yyyy}\n" +
                                            $"Room ID: {selectedTeacher.RoomId}";

                    // Show a message box with the student details
                    MessageBox.Show(teacherDetails, "Teacher Details");
                }
            }
        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
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

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            ShowPanel(pnlDashboard);
        }
    }
}
using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Reflection.Emit;

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

        private void ShowActivitiesPanel()
        {
            ShowPanel(pnlActivities);

            try
            {
                // get and display all students
                List<Activity> activities = GetActivities();
                DisplayActivities(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private List<Activity> GetActivities()
        {
            ActivityService activityService = new ActivityService();
            List<Activity> activities = activityService.GetActivities();
            return activities;
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

            label1.Text = "Students";

            // Subscribe to the ItemActivate event to show a message box with student attributes
            listViewStudents.ItemActivate += ListViewStudents_ItemActivate;
        }

        private void DisplayActivities(List<Activity> activities)
        {
            // Clear the ListView before filling it
            listViewActivities.Clear();
            listViewActivities.Items.Clear(); // Ensure all items are removed

            foreach (Activity activity in activities)
            {
                ListViewItem li = new ListViewItem(activity.Name);
                li.Tag = activity; // Link student object to ListViewItem
                listViewActivities.Items.Add(li);
            }

            label1.Text = "Activities";

            // Subscribe to the ItemActivate event to show a message box with student attributes
            listViewActivities.ItemActivate += ListViewActivity_ItemActivate;
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

        private void ListViewActivity_ItemActivate(object sender, EventArgs e)
        {
            if (listViewActivities.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewActivities.SelectedItems[0];
                Activity selectedActivity = selectedItem.Tag as Activity; // Retrieve the Student object from the Tag

                if (selectedActivity != null)
                {
                    // Construct a string to display all student attributes
                    string activityDetails = $"Activity ID: {selectedActivity.ActivityId}\n" +
                                            $"Name: {selectedActivity.Name}\n" +
                                            $"Location: {selectedActivity.Location}\n" +
                                            $"Start of activity: {selectedActivity.StartOfActivity:dd/MM/yyyy HH:mm}\n" +
                                            $"End of activity: {selectedActivity.EndOfActivity:dd/MM/yyyy HH:mm}";

                    // Show a message box with the student details
                    MessageBox.Show(activityDetails, "Activity Details");
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

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            ShowPanel(pnlDashboard);
        }
    }
}
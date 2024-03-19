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

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            ShowPanel(pnlDashboard);
        }
    }
}
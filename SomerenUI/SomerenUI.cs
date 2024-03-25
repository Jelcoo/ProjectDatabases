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
            panelList.Add(pnlVat);
        }

        private void ShowPanel(Panel panel)
        {
            foreach (Panel item in panelList)
            {
                try
                {
                    item.Hide();
                }
                catch { }
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
                List<Activity> activities = GetActivities("name DESC");
                DisplayActivities(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }

        private void ShowVatPanel()
        {
            ShowPanel(pnlVat);

            try
            {
                // get and display all VAT

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

        private void DisplayVat(string? quarter = null)
        {
            SetHeader("VAT");
            VATService vatService = new VATService();

            List<Dictionary<string, object>> vatSummary = vatService.GetVatSummary(Helpers.GetQuarterDates(getYear(), quarter));
            lblDates.Text = Helpers.GetQuarterDates(getYear(), quarter)[0].ToString("dddd dd/MM/yyyy") + " - " + Helpers.GetQuarterDates(getYear(), quarter)[1].ToString("dddd dd/MM/yyyy");
            //if there is an element Label with tag clonedLabel then remove all of them
            Helpers.RemoveControlsWithTag("clonedLabel", this);
            lblRecordTypeVat.Text = "Overig";
            lblRecordPercentage.Text = "0%";
            lblRecordOrders.Text = "0";
            lblRecordProducts.Text = "0";
            lblRecordTotal.Text = "€ 0.00";

            int counter = 0;
            foreach (var summary in vatSummary)
            {
                string vatAmount = String.Format("{0:N2}", summary["VATAmount"]);
                Label vatType = Helpers.CopyAndCloneLabel(lblRecordTypeVat, Helpers.GetVatType((double)summary["VATRate"]).ToString(), counter);

                Label vatPercentage = Helpers.CopyAndCloneLabel(lblRecordPercentage, ((double)summary["VATRate"] * 100).ToString() + "%", counter);

                Label orders = Helpers.CopyAndCloneLabel(lblRecordOrders, summary["NumberOfOrders"].ToString(), counter);

                Label products = Helpers.CopyAndCloneLabel(lblRecordProducts, summary["TotalProductsSold"].ToString(), counter);

                Label total = Helpers.CopyAndCloneLabel(lblRecordTotal, "€" + vatAmount, counter);

                counter++;
            }
            counter = 0;

            // Display total tax needed
            double totalTaxNeeded = vatService.GetTotalTaxNeeded(Helpers.GetQuarterDates(getYear(), quarter));
            lblTotalToPayValue.Text = $"€{Math.Round(totalTaxNeeded, 2)}";
        }

        private int getYear()
        {
            if (txtYear.Text.Length == 4 && int.TryParse(txtYear.Text, out int year))
            {
                return year;
            }
            else
            {
                if (txtYear.Text.Length != 0)
                {
                    MessageBox.Show("Invalid year");
                }

                return DateTime.Now.Year;
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

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            ShowPanel(pnlDashboard);
        }

        private void vATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowVatPanel();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

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
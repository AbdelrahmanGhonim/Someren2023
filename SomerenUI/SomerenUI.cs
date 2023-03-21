using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
            ShowDashboardPanel();
        }

        private void ShowDashboardPanel()  // show Dashboard 
        {
            // hide all other panels
            pnlStudents.Hide();

            pnlLecturers.Hide();

            pnlCashRegister.Hide();

            pnlDrinks.Hide();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();

            pnlLecturers.Hide();

            pnlCashRegister.Hide();

            pnlDrinks.Hide();

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
            // clear the listview before filling it
            listViewStudents.Clear();

            listViewStudents.Columns.Add("ID", 50);
            listViewStudents.Columns.Add("name", 100);
            listViewStudents.Columns.Add("Number", 100);
            listViewStudents.Columns.Add("DateOfBirth", 150);


            // displaying students in list 

            foreach (Student student in students)
            {

                ListViewItem li = new ListViewItem(student.Id.ToString());
                li.SubItems.Add(student.Name.ToString());
                li.SubItems.Add(student.Number.ToString());
                li.SubItems.Add(student.BirthDate.ToShortDateString());

                li.Tag = student;   // link student object to listview item
                listViewStudents.Items.Add(li);

            }
            listViewStudents.Columns[0].Width = 50;
            listViewStudents.Columns[1].Width = 200;
            listViewStudents.Columns[2].Width = 200;
            listViewStudents.Columns[3].Width = 200;
            listViewStudents.View = View.Details;


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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLecturersPanel();
        }

        private void ShowLecturersPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();

            pnlStudents.Hide();

            pnlCashRegister.Hide();

            pnlDrinks.Hide();

            // show Lecurer panel 
            pnlLecturers.Show();

            try
            {
                List<Teacher> teachers = GetLecturers();
                DisplayLecturers(teachers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private List<Teacher> GetLecturers()
        {
            TeacherService teacherService = new TeacherService();
            List<Teacher> teachers = teacherService.GetLecturers();
            return teachers;
        }

        private void DisplayLecturers(List<Teacher> teachers)
        {
            // clear the listview before filling it
            listViewLecturers.Clear();

            listViewLecturers.Columns.Add("ID", 50);
            listViewLecturers.Columns.Add("Name", 100);
            listViewLecturers.Columns.Add("Number", 100);
            listViewLecturers.Columns.Add("DateOfBirth", 200);

            // displaying Lecturers in List 

            foreach (Teacher teacher in teachers)
            {
                ListViewItem li = new ListViewItem(teacher.Id.ToString());
                li.SubItems.Add(teacher.Name.ToString());
                li.SubItems.Add(teacher.Number.ToString());
                li.SubItems.Add(teacher.DateOfBirth.ToShortDateString());

                li.Tag = teacher;
                listViewLecturers.Items.Add(li);
            }

            listViewLecturers.Columns[0].Width = 50;
            listViewLecturers.Columns[1].Width = 200;
            listViewLecturers.Columns[2].Width = 100;
            listViewLecturers.Columns[3].Width = 200;

            listViewLecturers.View = View.Details;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // unused
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // usused
        }

        private void drinksSuppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDrinkPanel();
        }

        public void showDrinkPanel()
        {
            // hide unused panels
            pnlDashboard.Hide();

            pnlLecturers.Hide();

            pnlStudents.Hide();

            pnlCashRegister.Hide();

            // show students
            pnlDrinks.Show();

            try
            {
                List<Drink> drinks = GetDrinks();
                DisplayDrinks(drinks);
            }
            catch (Exception drinks)
            {
                MessageBox.Show("Something went wrong while loading the drinks: " + drinks.Message);
            }
        }
        private List<Drink> GetDrinks()
        {
            DrinkService drinkService = new DrinkService();
            List<Drink> drinks = drinkService.GetDrinks();
            return drinks;
        }

        private void DisplayDrinks(List<Drink> drinks)
        {
            // clear the listview before filling it
            listViewDrinks.Clear();

            listViewDrinks.Columns.Add("Name", 150);
            listViewDrinks.Columns.Add("Price", 100);
            listViewDrinks.Columns.Add("AmountInStock", 100);
            listViewDrinks.Columns.Add("IsAlcoholic", 150);

            // displaying Lecturers in List 

            foreach (Drink drink in drinks)
            {
                ListViewItem li = new ListViewItem(drink.Name);
                li.SubItems.Add(drink.Price.ToString());
                li.SubItems.Add(drink.Amount.ToString());
                li.SubItems.Add(drink.IsAlcoholic);

                li.Tag = drink;
                listViewDrinks.Items.Add(li);
            }

            listViewDrinks.Columns[0].Width = 150;
            listViewDrinks.Columns[1].Width = 100;
            listViewDrinks.Columns[2].Width = 100;
            listViewDrinks.Columns[3].Width = 150;

            listViewDrinks.View = View.Details;
        }

        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // hide unused panels
            pnlDashboard.Hide();

            pnlLecturers.Hide();

            pnlStudents.Hide();

            pnlDrinks.Hide();

            // show students
            pnlCashRegister.Show();
        }

        private void btAddDrinks_Click(object sender, EventArgs e)
        {

        }

        private void btDeleteDrinks_Click(object sender, EventArgs e)
        {

        }

        private void btUpdateDrinks_Click(object sender, EventArgs e)
        {

        }

        private void btCheckout_Click(object sender, EventArgs e)
        {

        }
    }
}
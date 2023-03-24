using SomerenDAL;
using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;

using System.ComponentModel.Design;

using System.Runtime.CompilerServices;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
            ShowDashboardPanel();
        }

        public void HidingPanels()
        {
            pnlStudents.Hide();

            pnlLecturers.Hide();

            pnlCashRegister.Hide();

            pnlDrinks.Hide();

            pnlActivities.Hide();

            pnlDashboard.Hide();

            pnlLecturers.Hide();

            pnlSupervisors.Hide();
        }

        private void ShowDashboardPanel()  // show Dashboard 
        {
            // hide all other panels
            HidingPanels();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            HidingPanels();

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
            HidingPanels();

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
            HidingPanels();

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
            listViewDrinks.Columns.Add("Stock", 200);

            // displaying Lecturers in List 

            DrinkService drinkService = new DrinkService();

            foreach (Drink drink in drinks)
            {
                ListViewItem li = new ListViewItem(drink.Name);
                li.SubItems.Add(drink.Price.ToString() + "€");
                li.SubItems.Add(drink.Amount.ToString());
                li.SubItems.Add(drink.IsAlcoholic);

                if (drink.Amount >= 10)
                    li.SubItems.Add("Stock sufficient");
                else
                    li.SubItems.Add("Stock nearly depleted");


                li.Tag = drink;
                listViewDrinks.Items.Add(li);
            }

            listViewDrinks.Columns[0].Width = 150;
            listViewDrinks.Columns[1].Width = 100;
            listViewDrinks.Columns[2].Width = 100;
            listViewDrinks.Columns[3].Width = 150;
            listViewDrinks.Columns[4].Width = 200;

            listViewDrinks.View = View.Details;
        }

        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // hide unused panels
            HidingPanels();

            // show students
            pnlCashRegister.Show();


            List<Student> students = GetStudents();
            DisplayStudentsChashRiegester(students);
            List<Drink> drinks = GetDrinks();
            DisplayDrinksChashRegister(drinks);
        }

        private void DisplayStudentsChashRiegester(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudentsCashRegister.Clear();

            listViewStudentsCashRegister.Columns.Add("ID", 100);
            listViewStudentsCashRegister.Columns.Add("name", 150);
            listViewStudentsCashRegister.Columns.Add("Number", 150);
            listViewStudentsCashRegister.Columns.Add("DateOfBirth", 150);


            // displaying students in list 

            foreach (Student student in students)
            {

                ListViewItem ls = new ListViewItem(student.Id.ToString());
                ls.SubItems.Add(student.Name);
                ls.SubItems.Add(student.Number.ToString());
                ls.SubItems.Add(student.BirthDate.ToShortDateString());

                ls.Tag = student;   // link student object to listview item
                listViewStudentsCashRegister.Items.Add(ls);

            }
            listViewStudentsCashRegister.Columns[1].Width = 200;
            listViewStudentsCashRegister.Columns[2].Width = 200;
            listViewStudentsCashRegister.Columns[3].Width = 200;
            listViewStudentsCashRegister.View = View.Details;


        }
        private void DisplayDrinksChashRegister(List<Drink> drinks)
        {
            // clear the listview before filling it
            listViewDrinksCashRegister.Clear();

            listViewDrinksCashRegister.Columns.Add("Name", 150);
            listViewDrinksCashRegister.Columns.Add("Price", 100);
            listViewDrinksCashRegister.Columns.Add("AmountInStock", 200);
            listViewDrinksCashRegister.Columns.Add("IsAlcoholic", 200);

            // displaying Lecturers in List 

            foreach (Drink drink in drinks)
            {
                ListViewItem li = new ListViewItem(drink.Name);
                li.SubItems.Add(drink.Price.ToString() + "€");
                li.SubItems.Add(drink.Amount.ToString());
                li.SubItems.Add(drink.IsAlcoholic);

                li.Tag = drink;
                listViewDrinksCashRegister.Items.Add(li);
            }

            listViewDrinksCashRegister.Columns[0].Width = 150;
            listViewDrinksCashRegister.Columns[1].Width = 100;
            listViewDrinksCashRegister.Columns[2].Width = 100;
            listViewDrinksCashRegister.Columns[3].Width = 200;

            listViewDrinksCashRegister.View = View.Details;
        }



        private void btAddDrinks_Click(object sender, EventArgs e)
        {
            try
            {
                Drink drink = GettingDataOfDrink();
                DrinkService drinkService = new DrinkService();
                drinkService.AddDrink(drink);
            }
            catch (Exception drinkexp)
            {
                MessageBox.Show("Something went wrong while adding drink! " + drinkexp.Message, "Error");
            }

            UpdateDrinks();

        }

        private void btDeleteDrinks_Click(object sender, EventArgs e)
        {
            try
            {
                Drink drink = GettingDataOfDrink();
                if (drink.Amount == 0)
                    throw new Exception("There is no more left!");

                DrinkService drinkService = new DrinkService();
                drinkService.DeleteDrink(drink);
            }
            catch (Exception drinkexp)
            {
                MessageBox.Show("Something went wrong while removing drink! " + drinkexp.Message, "Error");
            }

            UpdateDrinks();
        }

        private void btUpdateDrinks_Click(object sender, EventArgs e)
        {
            try
            {
                Drink drink = GettingDataOfDrink();
                DrinkService drinkService = new DrinkService();
                drinkService.UpdateDrink(drink);
            }
            catch (Exception drinkexp)
            {
                MessageBox.Show("Something went wrong! " + drinkexp.Message, "Error");  
            }

            UpdateDrinks();
        }

        private void btCheckout_Click(object sender, EventArgs e)
        {
            if (listViewStudentsCashRegister.SelectedItems.Count > 0 && listViewDrinksCashRegister.SelectedItems.Count > 0)
            {
                // Get the selected items from the list views
                ListViewItem selectedStudent = listViewStudentsCashRegister.SelectedItems[0];
                ListViewItem selectedDrink = listViewDrinksCashRegister.SelectedItems[0];

                // Get the text values of the selected items
                Student student = (Student)selectedStudent.Tag;
                Drink drink = (Drink)selectedDrink.Tag;
               
                //Drink drink1 = new Drink();
                //drink1.Price= decimal.Parse(selectedDrink.SubItems[1].Text);
                lbAmountToPay.Text = $"{drink.Price}";

                // Do something with the selected items
                MessageBox.Show("Selected student: " + student.Name + "\nSelected drink: " + drink.Name + "\n Total Price: " + drink.Price);
                // when smth sold it should decrease one
                //drink1.Amount = int.Parse(selectedDrink.SubItems[2].Text);
                //selectedDrink.SubItems[2].Text = (drink1.Amount - 1).ToString();// not working :(

                // !!todo: decrease amount/stck from selected drink
                drink.Amount--;
                DrinkService drinkService = new DrinkService();
                drinkService.UpdateAmountInStock(drink);
                
                // Refresh
                List<Drink> drinks = GetDrinks();
                DisplayDrinksChashRegister(drinks);

                SalesDrinks sales = new SalesDrinks();
                sales.StudentId = student.Id;
                sales.DrinksName = drink.Name;
                drinkService.DrinksSold(sales);
            }
            else
            {
                // Show an error message if a student or a drink is not selected
                MessageBox.Show("Please select a student and a drink.");
            }
        }

        private void listViewStudentsCashRegister_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateDrinks()
        {
            List<Drink> drinks = GetDrinks();
            DisplayDrinks(drinks);
        }

        private void listViewDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewDrinks.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = listViewDrinks.SelectedItems[0];
                Drink selectedDrink = (Drink)listViewItem.Tag;

                txtAmountDrinks.Text = selectedDrink.Amount.ToString();
                txtNameDrinks.Text = selectedDrink.Name.ToString();
                txtPriceDrinks.Text = selectedDrink.Price.ToString();
                if (selectedDrink.IsAlcoholic == "Alcoholic")
                    rbAlkoholicDrinks.Checked = true;
                else
                    rbNonAlkoholicDrinks.Checked = true;
            }
        }

        private Drink GettingDataOfDrink()
        {
            Drink drink = new Drink();
            drink.Name = txtNameDrinks.Text;
            drink.Price = decimal.Parse(txtPriceDrinks.Text);
            drink.Amount = int.Parse(txtAmountDrinks.Text);
            if (rbAlkoholicDrinks.Checked || rbNonAlkoholicDrinks.Checked)
            {
                if (rbAlkoholicDrinks.Checked)
                    drink.IsAlcoholic = "Alcoholic";
                else
                    drink.IsAlcoholic = "non Alcoholic";
            }
            else
                throw new Exception("You need to choose if drink is Alcoholic or not");

            return drink;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listViewActivites_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btActivitiesAdd_Click(object sender, EventArgs e)
        {

        }

        private void btActivitiesRemove_Click(object sender, EventArgs e)
        {

        }

        private void btActivitiesUpdate_Click(object sender, EventArgs e)
        {

        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // hiding all panels
            HidingPanels();

            // showing activities panel
            pnlActivities.Show();
        }

        private void activitySupervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // hiding all panels
            HidingPanels();

            // showing activities panel
            pnlSupervisors.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void listViewSupervisorsActivities_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewSupervisorsLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btSupervisorsAdd_Click(object sender, EventArgs e)
        {

        }

        private void btSupervisorsRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
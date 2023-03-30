using SomerenDAL;
using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
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
            listViewStudents.FullRowSelect = true;

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
            listViewLecturers.FullRowSelect = true;

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
                List<Drink> drinks = GetDrinks();
                foreach (Drink drinkDrink in drinks)
                {
                    if(drinkDrink.Name == drink.Name)
                        throw new Exception("That drink already exists!");
                }

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
                DialogResult result = MessageBox.Show("Are you sure you want to remove this drink?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
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


                lbAmountToPay.Text = $"{drink.Price}";

                MessageBox.Show("Selected student: " + student.Name + "\nSelected drink: " + drink.Name + "\n Total Price: " + drink.Price);


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
            clearingTxtBoxes();
        }

        private void listViewDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDrinks.SelectedItems.Count > 0)
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
            if(listViewActivites.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = listViewActivites.SelectedItems[0];
                Activities selectedActivity = (Activities)listViewItem.Tag;
                txtActivitiesId.Text = selectedActivity.ID.ToString();
                txtActivitiesDescription.Text = selectedActivity.Description;
                dateActivitiesEnd.Value = selectedActivity.EndDateTime;
                dateActivitiesStart.Value = selectedActivity.StartDateTime;
            }
        }
        public List<Activities> GetActivities()
        { 
            ActivityService activity=new ActivityService();
            List<Activities> activities=activity.GetActivities();
            return activities;
        }

        public void DisplayActivities(List<Activities> activity)
        {
            listViewActivites.Clear();

            listViewActivites.Columns.Add("ID", 150);
            listViewActivites.Columns.Add("Description", 200);
            listViewActivites.Columns.Add("StartDateTime", 300);
            listViewActivites.Columns.Add("EndDateTime", 300);

            // displaying activities in List 

            foreach (Activities activities in activity )
            {
                ListViewItem li = new ListViewItem(activities.ID.ToString());
                li.SubItems.Add(activities.Description);
                li.SubItems.Add(activities.StartDateTime.ToString());
                li.SubItems.Add(activities.EndDateTime.ToString());

                li.Tag = activities;
                listViewActivites.Items.Add(li);
            }

            listViewActivites.Columns[0].Width = 200;
            listViewActivites.Columns[1].Width = 200;
            listViewActivites.Columns[2].Width = 300;
            listViewActivites.Columns[3].Width = 300;

            listViewActivites.View = View.Details;
        }
    

        private void btActivitiesAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Activities activities = GettingDataOfActivity();
                ActivityService activityService = new ActivityService();
                activityService.AddActivity(activities);

                // refresh
                List<Activities> activity = GetActivities();
                DisplayActivities(activity);
                clearActivities();
            }
            catch (Exception activityexp)
            {
                MessageBox.Show("Something went wrong while adding activity! " + activityexp.Message, "Error");
            }


        }

        private Activities GettingDataOfActivity()
        {
            Activities activities = new Activities();
            activities.ID = int.Parse(txtActivitiesId.Text);
            activities.Description = txtActivitiesDescription.Text;
            activities.StartDateTime = DateTime.Parse(dateActivitiesStart.Text);
            activities.EndDateTime = DateTime.Parse(dateActivitiesEnd.Text);
            return activities;
        }

        private int NumberOfActivities()
        {
            List<Activities> activities = GetActivities();
            return activities.Count;
        }

        private void btActivitiesRemove_Click(object sender, EventArgs e)
        {
            if (listViewActivites.SelectedItems.Count == 0)
                return;

            DialogResult result = MessageBox.Show("Are you sure you want to remove this activity?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            Activities selectedActivity = (Activities)listViewActivites.SelectedItems[0].Tag;

            ActivityService activityService = new ActivityService();

            activityService.RemoveActivity(selectedActivity);
            List<Activities> activity = GetActivities();
            DisplayActivities(activity);
            clearActivities();

        }

        private void btActivitiesUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Activities activities = GettingDataOfActivity();
                ActivityService activityService = new ActivityService();
                activityService.UpdateActivity(activities);
            }
            catch (Exception drinkexp)
            {
                MessageBox.Show("Something went wrong! " + drinkexp.Message, "Error");
            }

            List<Activities> activity = GetActivities();
            DisplayActivities(activity);
            clearActivities();

        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // hiding all panels
            HidingPanels();

            // showing activities panel
            pnlActivities.Show();
            ShowActivities();
            txtActivitiesId.Enabled = true;
        }

        private void ShowActivities()
        {
            try
            {
                List<Activities> activities = GetActivities();
                DisplayActivities(activities);
            }
            catch (Exception x)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + x.Message);
            }
        }
            

        private void activitySupervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // hiding all panels
            HidingPanels();

            // showing activities panel
            pnlSupervisors.Show();
            rbSupervisorsSupervisors.Checked = true;
            ShowSupervisors();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void listViewSupervisorsActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckingActivity();
        }

        private void listViewSupervisorsLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btSupervisorsAdd_Click(object sender, EventArgs e)
        {
            ListViewItem selectedActivity = listViewSupervisorsActivities.SelectedItems[0];
            ListViewItem selectedSupervisor = listViewSupervisorsLecturers.SelectedItems[0];

            Activities activity = (Activities)selectedActivity.Tag;
            Supervisor supervisor = (Supervisor)selectedSupervisor.Tag;

            try
            {
                if(supervisor.ActivityId == activity.ID)
                    MessageBox.Show("This Lecturer is already supervising this activity!", "Error");
                else
                {
                    supervisor.ActivityId = activity.ID;

                    TeacherService teacherService = new TeacherService();

                    teacherService.AddSupervisor(supervisor);
                }
            }
            catch (Exception activityexp)
            {
                MessageBox.Show("Something went wrong! " + activityexp.Message, "Error");
            }

            ShowSupervisors();
        }

        private void btSupervisorsRemove_Click(object sender, EventArgs e)
        {
            ListViewItem selectedActivity = listViewSupervisorsActivities.SelectedItems[0];
            ListViewItem selectedSupervisor = listViewSupervisorsLecturers.SelectedItems[0];

            Activities activity = (Activities)selectedActivity.Tag;
            Supervisor supervisor = (Supervisor)selectedSupervisor.Tag;

            try
            {

                supervisor.ActivityName = "null";

                TeacherService teacherService = new TeacherService();

                DialogResult result = MessageBox.Show(string.Format($"Are you sure you wish to remove {supervisor.Name} as a Supervisor?", selectedSupervisor, selectedActivity), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    teacherService.RemoveSupervisor(supervisor);
                }
                else
                {
                    return;
                }

            }
            catch (Exception activityexp)
            {
                MessageBox.Show("Something went wrong! " + activityexp.Message, "Error");
            }

            ShowSupervisors();
        }


        private void clearingTxtBoxes()
        {
            txtNameDrinks.Text = "";
            txtPriceDrinks.Text = "";
            txtAmountDrinks.Text = "";
            rbAlkoholicDrinks.Checked = false;
            rbNonAlkoholicDrinks.Checked = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listViewDrinksCashRegister_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {


        }

        private void ShowSupervisors()
        {
            List<Activities> activities = GetActivities();
            DisplayActivitiesInSupervisors(activities);
            List<Supervisor> supervisors = GetSupervisors();
            DisplayAllSupervisorsInSupervisors(supervisors);
        }

        private List<Supervisor> GetSupervisors()
        {
            TeacherService teacherService = new TeacherService();
            List<Supervisor> supervisors = teacherService.GetSupervisors();

            return supervisors;
        }

        private void DisplaySupervisorsForActivity(int activityID) 
        {
            TeacherService teacherService = new TeacherService();
            List<Supervisor> supervisors1 = teacherService.GetSupervisors();
            List<Supervisor> supervisors = new List<Supervisor>();

           foreach (Supervisor supervisor in supervisors1)
           {
                if (supervisor.ActivityId == activityID)
                    supervisors.Add(supervisor);
           }

            DisplayAllSupervisorsInSupervisors(supervisors);
        }

        private void DisplaySupervisorsForNonActivity(int activityID)
        {
            TeacherService teacherService = new TeacherService();
            List<Supervisor> supervisors1 = teacherService.GetSupervisors();
            List<Supervisor> supervisors = new List<Supervisor>();

            foreach (Supervisor supervisor in supervisors1)
            {
                if (supervisor.ActivityId != activityID)
                    supervisors.Add(supervisor);
            }

            DisplayAllSupervisorsInSupervisors(supervisors);
        }

        private void DisplayAllSupervisorsInSupervisors(List<Supervisor> supervisors)
        {
            listViewSupervisorsLecturers.Clear();

            listViewSupervisorsLecturers.Columns.Add("Name", 150);
            listViewSupervisorsLecturers.Columns.Add("Number", 200);
            listViewSupervisorsLecturers.Columns.Add("DateOfBirth", 200);
            listViewSupervisorsLecturers.Columns.Add("ActivityName", 200);

            // displaying activities in List 

            foreach (Supervisor supervisor in supervisors)
            {
                ListViewItem li = new ListViewItem(supervisor.Name.ToString());
                li.SubItems.Add(supervisor.Number.ToString());
                li.SubItems.Add(supervisor.DateOfBirth.ToString());
                li.SubItems.Add(supervisor.ActivityName);

                li.Tag = supervisor;
                listViewSupervisorsLecturers.Items.Add(li);
            }

            listViewSupervisorsLecturers.Columns[0].Width = 200;
            listViewSupervisorsLecturers.Columns[1].Width = 200;
            listViewSupervisorsLecturers.Columns[2].Width = 200;
            listViewSupervisorsLecturers.Columns[3].Width = 200;

            listViewSupervisorsLecturers.View = View.Details;
        }

        private void DisplayActivitiesInSupervisors(List<Activities> activity)
        {
            listViewSupervisorsActivities.Clear();

            listViewSupervisorsActivities.Columns.Add("ID", 150);
            listViewSupervisorsActivities.Columns.Add("Description", 200);
            listViewSupervisorsActivities.Columns.Add("StartDateTime", 200);
            listViewSupervisorsActivities.Columns.Add("EndDateTime", 200);

            // displaying activities in List 

            foreach (Activities activities in activity)
            {
                ListViewItem li = new ListViewItem(activities.ID.ToString());
                li.SubItems.Add(activities.Description);
                li.SubItems.Add(activities.StartDateTime.ToShortDateString());
                li.SubItems.Add(activities.EndDateTime.ToShortDateString());

                li.Tag = activities;
                listViewSupervisorsActivities.Items.Add(li);
            }

            listViewSupervisorsActivities.Columns[0].Width = 200;
            listViewSupervisorsActivities.Columns[1].Width = 200;
            listViewSupervisorsActivities.Columns[2].Width = 200;
            listViewSupervisorsActivities.Columns[3].Width = 200;

            listViewSupervisorsActivities.View = View.Details;
        }

        private void rbSupervisorsNotSupervisors_CheckedChanged(object sender, EventArgs e)
        {
            CheckingActivity();
        }

        private void rbSupervisorsSupervisors_CheckedChanged(object sender, EventArgs e)
        {
            CheckingActivity();
        }

        private void CheckingActivity()
        {
            if (listViewSupervisorsActivities.SelectedItems.Count > 0)
            {
                ListViewItem selectedActivity = listViewSupervisorsActivities.SelectedItems[0];

                Activities activity = (Activities)selectedActivity.Tag;

                if (rbSupervisorsSupervisors.Checked)
                    DisplaySupervisorsForActivity(activity.ID);
                else
                    DisplaySupervisorsForNonActivity(activity.ID);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearActivities();
        }

        private void clearActivities()
        {
            txtActivitiesId.Text = string.Empty;
            txtActivitiesDescription.Text = string.Empty;
        }
    }
}
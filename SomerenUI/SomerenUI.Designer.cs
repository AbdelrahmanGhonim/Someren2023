namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinksSuppliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLecturers = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listViewLecturers = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDrinks = new System.Windows.Forms.Panel();
            this.btUpdateDrinks = new System.Windows.Forms.Button();
            this.btDeleteDrinks = new System.Windows.Forms.Button();
            this.btAddDrinks = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rbNonAlkoholicDrinks = new System.Windows.Forms.RadioButton();
            this.rbAlkoholicDrinks = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmountDrinks = new System.Windows.Forms.TextBox();
            this.txtPriceDrinks = new System.Windows.Forms.TextBox();
            this.txtNameDrinks = new System.Windows.Forms.TextBox();
            this.listViewDrinks = new System.Windows.Forms.ListView();
            this.pnlCashRegister = new System.Windows.Forms.Panel();
            this.lbAmountToPay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btCheckout = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewDrinksCashRegister = new System.Windows.Forms.ListView();
            this.listViewStudentsCashRegister = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLecturers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlDrinks.SuspendLayout();
            this.pnlCashRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.drinksSuppliesToolStripMenuItem,
            this.cashRegisterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1786, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(154, 36);
            this.dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(262, 44);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(262, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(130, 36);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.lecturersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(129, 36);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.roomsToolStripMenuItem.Text = "Rooms";
            // 
            // drinksSuppliesToolStripMenuItem
            // 
            this.drinksSuppliesToolStripMenuItem.Name = "drinksSuppliesToolStripMenuItem";
            this.drinksSuppliesToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
            this.drinksSuppliesToolStripMenuItem.Text = "Drinks Supplies";
            this.drinksSuppliesToolStripMenuItem.Click += new System.EventHandler(this.drinksSuppliesToolStripMenuItem_Click);
            // 
            // cashRegisterToolStripMenuItem
            // 
            this.cashRegisterToolStripMenuItem.Name = "cashRegisterToolStripMenuItem";
            this.cashRegisterToolStripMenuItem.Size = new System.Drawing.Size(172, 36);
            this.cashRegisterToolStripMenuItem.Text = "Cash register";
            this.cashRegisterToolStripMenuItem.Click += new System.EventHandler(this.cashRegisterToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lblDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(23, 58);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1742, 994);
            this.pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Location = new System.Drawing.Point(24, 27);
            this.lblDashboard.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(421, 32);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            this.pnlStudents.Controls.Add(this.pictureBox1);
            this.pnlStudents.Controls.Add(this.listViewStudents);
            this.pnlStudents.Controls.Add(this.label1);
            this.pnlStudents.Location = new System.Drawing.Point(23, 58);
            this.pnlStudents.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(1742, 994);
            this.pnlStudents.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1495, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 262);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Location = new System.Drawing.Point(29, 90);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(1419, 650);
            this.listViewStudents.TabIndex = 1;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students";
            // 
            // pnlLecturers
            // 
            this.pnlLecturers.Controls.Add(this.pictureBox2);
            this.pnlLecturers.Controls.Add(this.listViewLecturers);
            this.pnlLecturers.Controls.Add(this.label2);
            this.pnlLecturers.Location = new System.Drawing.Point(23, 58);
            this.pnlLecturers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnlLecturers.Name = "pnlLecturers";
            this.pnlLecturers.Size = new System.Drawing.Size(1742, 994);
            this.pnlLecturers.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1495, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 262);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // listViewLecturers
            // 
            this.listViewLecturers.Location = new System.Drawing.Point(29, 90);
            this.listViewLecturers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listViewLecturers.Name = "listViewLecturers";
            this.listViewLecturers.Size = new System.Drawing.Size(1419, 650);
            this.listViewLecturers.TabIndex = 1;
            this.listViewLecturers.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 65);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lecturers";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnlDrinks
            // 
            this.pnlDrinks.Controls.Add(this.btUpdateDrinks);
            this.pnlDrinks.Controls.Add(this.btDeleteDrinks);
            this.pnlDrinks.Controls.Add(this.btAddDrinks);
            this.pnlDrinks.Controls.Add(this.label6);
            this.pnlDrinks.Controls.Add(this.rbNonAlkoholicDrinks);
            this.pnlDrinks.Controls.Add(this.rbAlkoholicDrinks);
            this.pnlDrinks.Controls.Add(this.label5);
            this.pnlDrinks.Controls.Add(this.label4);
            this.pnlDrinks.Controls.Add(this.label3);
            this.pnlDrinks.Controls.Add(this.txtAmountDrinks);
            this.pnlDrinks.Controls.Add(this.txtPriceDrinks);
            this.pnlDrinks.Controls.Add(this.txtNameDrinks);
            this.pnlDrinks.Controls.Add(this.listViewDrinks);
            this.pnlDrinks.Location = new System.Drawing.Point(28, 54);
            this.pnlDrinks.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnlDrinks.Name = "pnlDrinks";
            this.pnlDrinks.Size = new System.Drawing.Size(1742, 994);
            this.pnlDrinks.TabIndex = 4;
            // 
            // btUpdateDrinks
            // 
            this.btUpdateDrinks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btUpdateDrinks.Location = new System.Drawing.Point(1198, 792);
            this.btUpdateDrinks.Margin = new System.Windows.Forms.Padding(5);
            this.btUpdateDrinks.Name = "btUpdateDrinks";
            this.btUpdateDrinks.Size = new System.Drawing.Size(366, 69);
            this.btUpdateDrinks.TabIndex = 14;
            this.btUpdateDrinks.Text = "Update";
            this.btUpdateDrinks.UseVisualStyleBackColor = true;
            this.btUpdateDrinks.Click += new System.EventHandler(this.btUpdateDrinks_Click);
            // 
            // btDeleteDrinks
            // 
            this.btDeleteDrinks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDeleteDrinks.Location = new System.Drawing.Point(1198, 598);
            this.btDeleteDrinks.Margin = new System.Windows.Forms.Padding(5);
            this.btDeleteDrinks.Name = "btDeleteDrinks";
            this.btDeleteDrinks.Size = new System.Drawing.Size(366, 69);
            this.btDeleteDrinks.TabIndex = 13;
            this.btDeleteDrinks.Text = "Delete";
            this.btDeleteDrinks.UseVisualStyleBackColor = true;
            this.btDeleteDrinks.Click += new System.EventHandler(this.btDeleteDrinks_Click);
            // 
            // btAddDrinks
            // 
            this.btAddDrinks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAddDrinks.Location = new System.Drawing.Point(1198, 470);
            this.btAddDrinks.Margin = new System.Windows.Forms.Padding(5);
            this.btAddDrinks.Name = "btAddDrinks";
            this.btAddDrinks.Size = new System.Drawing.Size(366, 69);
            this.btAddDrinks.TabIndex = 12;
            this.btAddDrinks.Text = "Add";
            this.btAddDrinks.UseVisualStyleBackColor = true;
            this.btAddDrinks.Click += new System.EventHandler(this.btAddDrinks_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(141, 816);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 45);
            this.label6.TabIndex = 11;
            this.label6.Text = "Amount:";
            // 
            // rbNonAlkoholicDrinks
            // 
            this.rbNonAlkoholicDrinks.AutoSize = true;
            this.rbNonAlkoholicDrinks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNonAlkoholicDrinks.Location = new System.Drawing.Point(418, 730);
            this.rbNonAlkoholicDrinks.Margin = new System.Windows.Forms.Padding(5);
            this.rbNonAlkoholicDrinks.Name = "rbNonAlkoholicDrinks";
            this.rbNonAlkoholicDrinks.Size = new System.Drawing.Size(253, 49);
            this.rbNonAlkoholicDrinks.TabIndex = 10;
            this.rbNonAlkoholicDrinks.TabStop = true;
            this.rbNonAlkoholicDrinks.Text = "Non Alkoholic";
            this.rbNonAlkoholicDrinks.UseVisualStyleBackColor = true;
            this.rbNonAlkoholicDrinks.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbAlkoholicDrinks
            // 
            this.rbAlkoholicDrinks.AutoSize = true;
            this.rbAlkoholicDrinks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbAlkoholicDrinks.Location = new System.Drawing.Point(418, 669);
            this.rbAlkoholicDrinks.Margin = new System.Windows.Forms.Padding(5);
            this.rbAlkoholicDrinks.Name = "rbAlkoholicDrinks";
            this.rbAlkoholicDrinks.Size = new System.Drawing.Size(182, 49);
            this.rbAlkoholicDrinks.TabIndex = 9;
            this.rbAlkoholicDrinks.TabStop = true;
            this.rbAlkoholicDrinks.Text = "Alcoholic";
            this.rbAlkoholicDrinks.UseVisualStyleBackColor = true;
            this.rbAlkoholicDrinks.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(141, 706);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 45);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(141, 598);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 45);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(141, 501);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name:";
            // 
            // txtAmountDrinks
            // 
            this.txtAmountDrinks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAmountDrinks.Location = new System.Drawing.Point(418, 811);
            this.txtAmountDrinks.Margin = new System.Windows.Forms.Padding(5);
            this.txtAmountDrinks.Name = "txtAmountDrinks";
            this.txtAmountDrinks.Size = new System.Drawing.Size(225, 50);
            this.txtAmountDrinks.TabIndex = 5;
            // 
            // txtPriceDrinks
            // 
            this.txtPriceDrinks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPriceDrinks.Location = new System.Drawing.Point(418, 589);
            this.txtPriceDrinks.Margin = new System.Windows.Forms.Padding(5);
            this.txtPriceDrinks.Name = "txtPriceDrinks";
            this.txtPriceDrinks.Size = new System.Drawing.Size(225, 50);
            this.txtPriceDrinks.TabIndex = 3;
            // 
            // txtNameDrinks
            // 
            this.txtNameDrinks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameDrinks.Location = new System.Drawing.Point(418, 485);
            this.txtNameDrinks.Margin = new System.Windows.Forms.Padding(5);
            this.txtNameDrinks.Name = "txtNameDrinks";
            this.txtNameDrinks.Size = new System.Drawing.Size(225, 50);
            this.txtNameDrinks.TabIndex = 2;
            // 
            // listViewDrinks
            // 
            this.listViewDrinks.FullRowSelect = true;
 
            this.listViewDrinks.Location = new System.Drawing.Point(141, 14);
            this.listViewDrinks.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listViewDrinks.MultiSelect = false;

            this.listViewDrinks.Name = "listViewDrinks";
            this.listViewDrinks.Size = new System.Drawing.Size(1419, 391);
            this.listViewDrinks.TabIndex = 1;
            this.listViewDrinks.UseCompatibleStateImageBehavior = false;
            this.listViewDrinks.SelectedIndexChanged += new System.EventHandler(this.listViewDrinks_SelectedIndexChanged);
            // 
            // pnlCashRegister
            // 
            this.pnlCashRegister.Controls.Add(this.lbAmountToPay);
            this.pnlCashRegister.Controls.Add(this.label9);
            this.pnlCashRegister.Controls.Add(this.btCheckout);
            this.pnlCashRegister.Controls.Add(this.label8);
            this.pnlCashRegister.Controls.Add(this.label7);
            this.pnlCashRegister.Controls.Add(this.listViewDrinksCashRegister);
            this.pnlCashRegister.Controls.Add(this.listViewStudentsCashRegister);
<
            this.pnlCashRegister.Location = new System.Drawing.Point(23, 61);
            this.pnlCashRegister.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
=
>
            this.pnlCashRegister.Name = "pnlCashRegister";
            this.pnlCashRegister.Size = new System.Drawing.Size(1742, 994);
            this.pnlCashRegister.TabIndex = 16;
            // 
            // lbAmountToPay
            // 
            this.lbAmountToPay.AutoSize = true;
            this.lbAmountToPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAmountToPay.Location = new System.Drawing.Point(993, 774);
            this.lbAmountToPay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbAmountToPay.Name = "lbAmountToPay";
            this.lbAmountToPay.Size = new System.Drawing.Size(78, 45);
            this.lbAmountToPay.TabIndex = 7;
            this.lbAmountToPay.Text = "0.00";
            this.lbAmountToPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(681, 774);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 45);
            this.label9.TabIndex = 6;
            this.label9.Text = "Amount:";
            // 
            // btCheckout
            // 
            this.btCheckout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCheckout.Location = new System.Drawing.Point(681, 845);
            this.btCheckout.Margin = new System.Windows.Forms.Padding(5);
            this.btCheckout.Name = "btCheckout";
            this.btCheckout.Size = new System.Drawing.Size(392, 104);
            this.btCheckout.TabIndex = 5;
            this.btCheckout.Text = "Checkout";
            this.btCheckout.UseVisualStyleBackColor = true;
            this.btCheckout.Click += new System.EventHandler(this.btCheckout_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(964, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 45);
            this.label8.TabIndex = 4;
            this.label8.Text = "Drinks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(28, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 45);
            this.label7.TabIndex = 3;
            this.label7.Text = "Students";
            // 
            // listViewDrinksCashRegister
            // 
            this.listViewDrinksCashRegister.FullRowSelect = true;
            this.listViewDrinksCashRegister.Location = new System.Drawing.Point(964, 66);
            this.listViewDrinksCashRegister.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listViewDrinksCashRegister.Name = "listViewDrinksCashRegister";
            this.listViewDrinksCashRegister.Size = new System.Drawing.Size(752, 535);
            this.listViewDrinksCashRegister.TabIndex = 2;
            this.listViewDrinksCashRegister.UseCompatibleStateImageBehavior = false;
            // 
            // listViewStudentsCashRegister
            // 
            this.listViewStudentsCashRegister.FullRowSelect = true;
            this.listViewStudentsCashRegister.Location = new System.Drawing.Point(28, 66);
            this.listViewStudentsCashRegister.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listViewStudentsCashRegister.Name = "listViewStudentsCashRegister";
            this.listViewStudentsCashRegister.Size = new System.Drawing.Size(795, 535);
            this.listViewStudentsCashRegister.TabIndex = 1;
            this.listViewStudentsCashRegister.UseCompatibleStateImageBehavior = false;
            this.listViewStudentsCashRegister.SelectedIndexChanged += new System.EventHandler(this.listViewStudentsCashRegister_SelectedIndexChanged);
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1786, 1077);
            this.Controls.Add(this.pnlCashRegister);
            this.Controls.Add(this.pnlDrinks);
            this.Controls.Add(this.pnlLecturers);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.pnlDashboard);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SomerenUI";
            this.Text = "SomerenApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLecturers.ResumeLayout(false);
            this.pnlLecturers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlDrinks.ResumeLayout(false);
            this.pnlDrinks.PerformLayout();
            this.pnlCashRegister.ResumeLayout(false);
            this.pnlCashRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLecturers;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listViewLecturers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem drinksSuppliesToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDrinks;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.RadioButton rbNonAlkoholicDrinks;
        private System.Windows.Forms.RadioButton rbAlkoholicDrinks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmountDrinks;
        private System.Windows.Forms.TextBox txtPriceDrinks;
        private System.Windows.Forms.TextBox txtNameDrinks;
        private System.Windows.Forms.Button btUpdateDrinks;
        private System.Windows.Forms.Button btDeleteDrinks;
        private System.Windows.Forms.Button btAddDrinks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem cashRegisterToolStripMenuItem;
        private System.Windows.Forms.Panel pnlCashRegister;
        private System.Windows.Forms.Label lbAmountToPay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btCheckout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewDrinksCashRegister;
        private System.Windows.Forms.ListView listViewStudentsCashRegister;
    }
}
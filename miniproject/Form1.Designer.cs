namespace miniproject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            btnlogin = new Button();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            lblpassword = new Label();
            lblusername = new Label();
            menuStrip1 = new MenuStrip();
            admissionToolStripMenuItem = new ToolStripMenuItem();
            newAdmissionToolStripMenuItem = new ToolStripMenuItem();
            upgradeSemesterToolStripMenuItem = new ToolStripMenuItem();
            feesToolStripMenuItem = new ToolStripMenuItem();
            studentDetailsToolStripMenuItem = new ToolStripMenuItem();
            searchStudeToolStripMenuItem = new ToolStripMenuItem();
            individualDetailsToolStripMenuItem = new ToolStripMenuItem();
            teachersToolStripMenuItem = new ToolStripMenuItem();
            addTeacherInformationToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            removeStudentToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            exitSystemToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(507, 495);
            label1.Name = "label1";
            label1.Size = new Size(261, 55);
            label1.TabIndex = 0;
            label1.Text = "COLLEGE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1030, 635);
            label2.Name = "label2";
            label2.Size = new Size(222, 55);
            label2.TabIndex = 1;
            label2.Text = "SYSTEM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(703, 566);
            label3.Name = "label3";
            label3.Size = new Size(387, 55);
            label3.TabIndex = 2;
            label3.Text = "MANAGEMENT";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(txtpassword);
            panel1.Controls.Add(txtusername);
            panel1.Controls.Add(lblpassword);
            panel1.Controls.Add(lblusername);
            panel1.Location = new Point(472, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 220);
            panel1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Castellar", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Desktop;
            label6.Location = new Point(180, 12);
            label6.Name = "label6";
            label6.Size = new Size(105, 29);
            label6.TabIndex = 5;
            label6.Text = "Login";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.GhostWhite;
            btnlogin.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogin.Location = new Point(198, 176);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(87, 27);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtpassword.Location = new Point(169, 132);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(139, 25);
            txtpassword.TabIndex = 3;
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtusername.Location = new Point(169, 70);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(139, 25);
            txtusername.TabIndex = 2;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblpassword.Location = new Point(53, 140);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(76, 17);
            lblpassword.TabIndex = 1;
            lblpassword.Text = "Password";
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblusername.Location = new Point(50, 78);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(78, 17);
            lblusername.TabIndex = 0;
            lblusername.Text = "Username";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { admissionToolStripMenuItem, feesToolStripMenuItem, studentDetailsToolStripMenuItem, teachersToolStripMenuItem, removeStudentToolStripMenuItem, aboutUsToolStripMenuItem, exitSystemToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1281, 25);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // admissionToolStripMenuItem
            // 
            admissionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newAdmissionToolStripMenuItem, upgradeSemesterToolStripMenuItem });
            admissionToolStripMenuItem.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            admissionToolStripMenuItem.Image = (Image)resources.GetObject("admissionToolStripMenuItem.Image");
            admissionToolStripMenuItem.Name = "admissionToolStripMenuItem";
            admissionToolStripMenuItem.Size = new Size(110, 21);
            admissionToolStripMenuItem.Text = "Admission";
            // 
            // newAdmissionToolStripMenuItem
            // 
            newAdmissionToolStripMenuItem.Name = "newAdmissionToolStripMenuItem";
            newAdmissionToolStripMenuItem.Size = new Size(205, 22);
            newAdmissionToolStripMenuItem.Text = "New Admission";
            newAdmissionToolStripMenuItem.Click += newAdmissionToolStripMenuItem_Click;
            // 
            // upgradeSemesterToolStripMenuItem
            // 
            upgradeSemesterToolStripMenuItem.Name = "upgradeSemesterToolStripMenuItem";
            upgradeSemesterToolStripMenuItem.Size = new Size(205, 22);
            upgradeSemesterToolStripMenuItem.Text = "Upgrade Semester";
            upgradeSemesterToolStripMenuItem.Click += upgradeSemesterToolStripMenuItem_Click;
            // 
            // feesToolStripMenuItem
            // 
            feesToolStripMenuItem.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            feesToolStripMenuItem.Image = (Image)resources.GetObject("feesToolStripMenuItem.Image");
            feesToolStripMenuItem.Name = "feesToolStripMenuItem";
            feesToolStripMenuItem.Size = new Size(66, 21);
            feesToolStripMenuItem.Text = "Fees";
            feesToolStripMenuItem.Click += feesToolStripMenuItem_Click;
            // 
            // studentDetailsToolStripMenuItem
            // 
            studentDetailsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchStudeToolStripMenuItem, individualDetailsToolStripMenuItem });
            studentDetailsToolStripMenuItem.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            studentDetailsToolStripMenuItem.Image = (Image)resources.GetObject("studentDetailsToolStripMenuItem.Image");
            studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            studentDetailsToolStripMenuItem.Size = new Size(138, 21);
            studentDetailsToolStripMenuItem.Text = "StudentDetails";
            // 
            // searchStudeToolStripMenuItem
            // 
            searchStudeToolStripMenuItem.Name = "searchStudeToolStripMenuItem";
            searchStudeToolStripMenuItem.Size = new Size(203, 22);
            searchStudeToolStripMenuItem.Text = "Search Student";
            searchStudeToolStripMenuItem.Click += searchStudeToolStripMenuItem_Click;
            // 
            // individualDetailsToolStripMenuItem
            // 
            individualDetailsToolStripMenuItem.Name = "individualDetailsToolStripMenuItem";
            individualDetailsToolStripMenuItem.Size = new Size(203, 22);
            individualDetailsToolStripMenuItem.Text = "Individual Details";
            individualDetailsToolStripMenuItem.Click += individualDetailsToolStripMenuItem_Click;
            // 
            // teachersToolStripMenuItem
            // 
            teachersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addTeacherInformationToolStripMenuItem, searchToolStripMenuItem });
            teachersToolStripMenuItem.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            teachersToolStripMenuItem.Image = (Image)resources.GetObject("teachersToolStripMenuItem.Image");
            teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            teachersToolStripMenuItem.Size = new Size(99, 21);
            teachersToolStripMenuItem.Text = "Teachers";
            // 
            // addTeacherInformationToolStripMenuItem
            // 
            addTeacherInformationToolStripMenuItem.Name = "addTeacherInformationToolStripMenuItem";
            addTeacherInformationToolStripMenuItem.Size = new Size(253, 22);
            addTeacherInformationToolStripMenuItem.Text = "Add Teacher Information";
            addTeacherInformationToolStripMenuItem.Click += addTeacherInformationToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(253, 22);
            searchToolStripMenuItem.Text = "search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // removeStudentToolStripMenuItem
            // 
            removeStudentToolStripMenuItem.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            removeStudentToolStripMenuItem.Image = (Image)resources.GetObject("removeStudentToolStripMenuItem.Image");
            removeStudentToolStripMenuItem.Name = "removeStudentToolStripMenuItem";
            removeStudentToolStripMenuItem.Size = new Size(148, 21);
            removeStudentToolStripMenuItem.Text = "Remove Student";
            removeStudentToolStripMenuItem.Click += removeStudentToolStripMenuItem_Click;
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            aboutUsToolStripMenuItem.Image = (Image)resources.GetObject("aboutUsToolStripMenuItem.Image");
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(98, 21);
            aboutUsToolStripMenuItem.Text = "About Us";
            aboutUsToolStripMenuItem.Click += aboutUsToolStripMenuItem_Click;
            // 
            // exitSystemToolStripMenuItem
            // 
            exitSystemToolStripMenuItem.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            exitSystemToolStripMenuItem.Image = (Image)resources.GetObject("exitSystemToolStripMenuItem.Image");
            exitSystemToolStripMenuItem.Name = "exitSystemToolStripMenuItem";
            exitSystemToolStripMenuItem.Size = new Size(115, 21);
            exitSystemToolStripMenuItem.Text = "Exit System";
            exitSystemToolStripMenuItem.Click += exitSystemToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1281, 749);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Button btnlogin;
        private TextBox txtpassword;
        private TextBox txtusername;
        private Label lblpassword;
        private Label lblusername;
        private Label label6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem admissionToolStripMenuItem;
        private ToolStripMenuItem newAdmissionToolStripMenuItem;
        private ToolStripMenuItem upgradeSemesterToolStripMenuItem;
        private ToolStripMenuItem feesToolStripMenuItem;
        private ToolStripMenuItem studentDetailsToolStripMenuItem;
        private ToolStripMenuItem searchStudeToolStripMenuItem;
        private ToolStripMenuItem individualDetailsToolStripMenuItem;
        private ToolStripMenuItem teachersToolStripMenuItem;
        private ToolStripMenuItem addTeacherInformationToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem removeStudentToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private ToolStripMenuItem exitSystemToolStripMenuItem;
    }
}

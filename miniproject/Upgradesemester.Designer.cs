namespace miniproject
{
    partial class Upgradesemester
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upgradesemester));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            comboBoxfrom = new ComboBox();
            comboBoxto = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnupgrade = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(135, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 194);
            label1.Name = "label1";
            label1.Size = new Size(391, 22);
            label1.TabIndex = 1;
            label1.Text = "Select Semester For Old Students Admission";
            // 
            // comboBoxfrom
            // 
            comboBoxfrom.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxfrom.FormattingEnabled = true;
            comboBoxfrom.Items.AddRange(new object[] { "1st Sem", "2nd Sem", "3rd Sem", "4th Sem", "5th Sem", "6thSem", "7thSem", "8thSem" });
            comboBoxfrom.Location = new Point(214, 258);
            comboBoxfrom.Name = "comboBoxfrom";
            comboBoxfrom.Size = new Size(153, 22);
            comboBoxfrom.TabIndex = 2;
            comboBoxfrom.Text = "--Select--";
            // 
            // comboBoxto
            // 
            comboBoxto.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxto.FormattingEnabled = true;
            comboBoxto.Items.AddRange(new object[] { "1st Sem", "2nd Sem", "3rd Sem", "4th Sem", "5th Sem", "6thSem", "7thSem", "8thSem" });
            comboBoxto.Location = new Point(214, 338);
            comboBoxto.Name = "comboBoxto";
            comboBoxto.Size = new Size(153, 22);
            comboBoxto.TabIndex = 3;
            comboBoxto.Text = "--Select--";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(123, 259);
            label2.Name = "label2";
            label2.Size = new Size(66, 22);
            label2.TabIndex = 4;
            label2.Text = "From :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(123, 339);
            label3.Name = "label3";
            label3.Size = new Size(40, 22);
            label3.TabIndex = 5;
            label3.Text = "To :";
            // 
            // btnupgrade
            // 
            btnupgrade.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnupgrade.Location = new Point(241, 403);
            btnupgrade.Name = "btnupgrade";
            btnupgrade.Size = new Size(80, 27);
            btnupgrade.TabIndex = 6;
            btnupgrade.Text = "Upgrade";
            btnupgrade.UseVisualStyleBackColor = true;
            btnupgrade.Click += btnupgrade_Click;
            // 
            // Upgradesemester
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(493, 495);
            Controls.Add(btnupgrade);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxto);
            Controls.Add(comboBoxfrom);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Upgradesemester";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upgradesemester";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox comboBoxfrom;
        private ComboBox comboBoxto;
        private Label label2;
        private Label label3;
        private Button btnupgrade;
    }
}
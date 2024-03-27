namespace miniproject
{
    partial class Fees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fees));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtregnumber = new TextBox();
            txtfees = new TextBox();
            fnamelabel = new Label();
            durationlabel = new Label();
            mnamelabel = new Label();
            btnsubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(85, 432);
            label1.Name = "label1";
            label1.Size = new Size(40, 19);
            label1.TabIndex = 1;
            label1.Text = "Fees";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(85, 382);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 2;
            label2.Text = "Duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(85, 333);
            label3.Name = "label3";
            label3.Size = new Size(109, 19);
            label3.TabIndex = 3;
            label3.Text = "Mother Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(85, 286);
            label4.Name = "label4";
            label4.Size = new Size(84, 19);
            label4.TabIndex = 4;
            label4.Text = "Full Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(85, 240);
            label5.Name = "label5";
            label5.Size = new Size(163, 19);
            label5.TabIndex = 5;
            label5.Text = "Registration Number";
            // 
            // txtregnumber
            // 
            txtregnumber.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtregnumber.Location = new Point(264, 236);
            txtregnumber.Name = "txtregnumber";
            txtregnumber.Size = new Size(163, 23);
            txtregnumber.TabIndex = 6;
            txtregnumber.TextChanged += txtregnumber_TextChanged;
            // 
            // txtfees
            // 
            txtfees.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtfees.Location = new Point(264, 428);
            txtfees.Name = "txtfees";
            txtfees.Size = new Size(163, 23);
            txtfees.TabIndex = 7;
            // 
            // fnamelabel
            // 
            fnamelabel.AutoSize = true;
            fnamelabel.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            fnamelabel.Location = new Point(264, 289);
            fnamelabel.Name = "fnamelabel";
            fnamelabel.Size = new Size(62, 15);
            fnamelabel.TabIndex = 8;
            fnamelabel.Text = "___________";
            // 
            // durationlabel
            // 
            durationlabel.AutoSize = true;
            durationlabel.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            durationlabel.Location = new Point(264, 385);
            durationlabel.Name = "durationlabel";
            durationlabel.Size = new Size(62, 15);
            durationlabel.TabIndex = 9;
            durationlabel.Text = "___________";
            // 
            // mnamelabel
            // 
            mnamelabel.AutoSize = true;
            mnamelabel.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            mnamelabel.Location = new Point(264, 336);
            mnamelabel.Name = "mnamelabel";
            mnamelabel.Size = new Size(62, 15);
            mnamelabel.TabIndex = 10;
            mnamelabel.Text = "___________";
            // 
            // btnsubmit
            // 
            btnsubmit.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnsubmit.Location = new Point(209, 501);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(87, 29);
            btnsubmit.TabIndex = 11;
            btnsubmit.Text = "Submit";
            btnsubmit.UseVisualStyleBackColor = true;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // Fees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(534, 553);
            Controls.Add(btnsubmit);
            Controls.Add(mnamelabel);
            Controls.Add(durationlabel);
            Controls.Add(fnamelabel);
            Controls.Add(txtfees);
            Controls.Add(txtregnumber);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Fees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fees";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtregnumber;
        private TextBox txtfees;
        private Label fnamelabel;
        private Label durationlabel;
        private Label mnamelabel;
        private Button btnsubmit;
    }
}
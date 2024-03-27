namespace miniproject
{
    partial class RemoveStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveStudent));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtregid = new TextBox();
            btndelete = new Button();
            dataGridViewdelete = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewdelete).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(315, 36);
            label1.Name = "label1";
            label1.Size = new Size(241, 25);
            label1.TabIndex = 1;
            label1.Text = "Delete Students Record";
            // 
            // txtregid
            // 
            txtregid.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtregid.Location = new Point(345, 110);
            txtregid.Name = "txtregid";
            txtregid.Size = new Size(234, 30);
            txtregid.TabIndex = 2;
            // 
            // btndelete
            // 
            btndelete.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btndelete.ForeColor = Color.Red;
            btndelete.Location = new Point(425, 165);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(91, 31);
            btndelete.TabIndex = 3;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // dataGridViewdelete
            // 
            dataGridViewdelete.BackgroundColor = Color.Cornsilk;
            dataGridViewdelete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewdelete.Location = new Point(12, 244);
            dataGridViewdelete.Name = "dataGridViewdelete";
            dataGridViewdelete.RowTemplate.Height = 25;
            dataGridViewdelete.Size = new Size(802, 260);
            dataGridViewdelete.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(191, 111);
            label2.Name = "label2";
            label2.Size = new Size(148, 22);
            label2.TabIndex = 5;
            label2.Text = "Registration ID:";
            // 
            // RemoveStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(826, 516);
            Controls.Add(label2);
            Controls.Add(dataGridViewdelete);
            Controls.Add(btndelete);
            Controls.Add(txtregid);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "RemoveStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RemoveStudent";
            Load += RemoveStudent_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewdelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtregid;
        private Button btndelete;
        private DataGridView dataGridViewdelete;
        private Label label2;
    }
}
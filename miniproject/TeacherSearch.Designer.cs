namespace miniproject
{
    partial class TeacherSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherSearch));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            btnsearch = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 152);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(351, 36);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 1;
            label1.Text = "Search Teacher";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(201, 107);
            label2.Name = "label2";
            label2.Size = new Size(148, 22);
            label2.TabIndex = 2;
            label2.Text = "Registration ID:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(355, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 26);
            textBox1.TabIndex = 3;
            // 
            // btnsearch
            // 
            btnsearch.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsearch.Location = new Point(409, 162);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(82, 26);
            btnsearch.TabIndex = 4;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Cornsilk;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 239);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(802, 265);
            dataGridView1.TabIndex = 5;
            // 
            // TeacherSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(826, 516);
            Controls.Add(dataGridView1);
            Controls.Add(btnsearch);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "TeacherSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherSearch";
            Load += TeacherSearch_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button btnsearch;
        private DataGridView dataGridView1;
    }
}
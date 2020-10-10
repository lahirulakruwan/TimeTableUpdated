namespace TimeTableManagement.Forms
{
    partial class lecture
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.E_Details = new System.Windows.Forms.DataGridView();
            this.LectureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ranks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Level = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Rank = new System.Windows.Forms.Label();
            this.Building = new System.Windows.Forms.Label();
            this.Center = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.EmployeeID = new System.Windows.Forms.Label();
            this.Faculty = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.E_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.E_Details);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.Level);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.Rank);
            this.panel1.Controls.Add(this.Building);
            this.panel1.Controls.Add(this.Center);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.EmployeeID);
            this.panel1.Controls.Add(this.Faculty);
            this.panel1.Controls.Add(this.Department);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Name);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 441);
            this.panel1.TabIndex = 0;
            // 
            // E_Details
            // 
            this.E_Details.AllowUserToAddRows = false;
            this.E_Details.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.E_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.E_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LectureName,
            this.id,
            this.fac,
            this.Dept,
            this.Cent,
            this.Buld,
            this.Lev,
            this.ranks});
            this.E_Details.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.E_Details.Location = new System.Drawing.Point(0, 242);
            this.E_Details.Name = "E_Details";
            this.E_Details.Size = new System.Drawing.Size(746, 196);
            this.E_Details.TabIndex = 19;
            this.E_Details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LectureName
            // 
            this.LectureName.HeaderText = "Name";
            this.LectureName.Name = "LectureName";
            // 
            // id
            // 
            this.id.HeaderText = "E_ID";
            this.id.Name = "id";
            // 
            // fac
            // 
            this.fac.HeaderText = "Fac";
            this.fac.Name = "fac";
            // 
            // Dept
            // 
            this.Dept.HeaderText = "Dept";
            this.Dept.Name = "Dept";
            // 
            // Cent
            // 
            this.Cent.HeaderText = "Center";
            this.Cent.Name = "Cent";
            // 
            // Buld
            // 
            this.Buld.HeaderText = "Building";
            this.Buld.Name = "Buld";
            // 
            // Lev
            // 
            this.Lev.HeaderText = "Level";
            this.Lev.Name = "Lev";
            // 
            // ranks
            // 
            this.ranks.HeaderText = "Rank";
            this.ranks.Name = "ranks";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(569, 116);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(141, 31);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(569, 64);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(141, 31);
            this.Edit.TabIndex = 17;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(569, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(141, 31);
            this.Add.TabIndex = 16;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Level.Location = new System.Drawing.Point(14, 174);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(46, 20);
            this.Level.TabIndex = 14;
            this.Level.Text = "Level";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(322, 176);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(151, 20);
            this.textBox7.TabIndex = 13;
            // 
            // Rank
            // 
            this.Rank.AutoSize = true;
            this.Rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Rank.Location = new System.Drawing.Point(265, 174);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(47, 20);
            this.Rank.TabIndex = 12;
            this.Rank.Text = "Rank";
            this.Rank.Click += new System.EventHandler(this.label1_Click);
            // 
            // Building
            // 
            this.Building.AutoSize = true;
            this.Building.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Building.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Building.Location = new System.Drawing.Point(14, 142);
            this.Building.Name = "Building";
            this.Building.Size = new System.Drawing.Size(65, 20);
            this.Building.TabIndex = 10;
            this.Building.Text = "Building";
            // 
            // Center
            // 
            this.Center.AutoSize = true;
            this.Center.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Center.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Center.Location = new System.Drawing.Point(14, 116);
            this.Center.Name = "Center";
            this.Center.Size = new System.Drawing.Size(57, 20);
            this.Center.TabIndex = 8;
            this.Center.Text = "Center";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(139, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(334, 20);
            this.textBox4.TabIndex = 7;
            // 
            // EmployeeID
            // 
            this.EmployeeID.AutoSize = true;
            this.EmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EmployeeID.Location = new System.Drawing.Point(14, 36);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(100, 20);
            this.EmployeeID.TabIndex = 6;
            this.EmployeeID.Text = "Employee ID";
            // 
            // Faculty
            // 
            this.Faculty.AutoSize = true;
            this.Faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Faculty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Faculty.Location = new System.Drawing.Point(14, 62);
            this.Faculty.Name = "Faculty";
            this.Faculty.Size = new System.Drawing.Size(60, 20);
            this.Faculty.TabIndex = 4;
            this.Faculty.Text = "Faculty";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Department.Location = new System.Drawing.Point(14, 90);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(94, 20);
            this.Department.TabIndex = 2;
            this.Department.Text = "Department";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Name.Location = new System.Drawing.Point(14, 12);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(51, 20);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            this.Name.Click += new System.EventHandler(this.Name_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business Management"});
            this.comboBox1.Location = new System.Drawing.Point(139, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(334, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Software Engineering",
            "Information Technology",
            "Cyber Security",
            "Network Engineering"});
            this.comboBox2.Location = new System.Drawing.Point(139, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(334, 21);
            this.comboBox2.TabIndex = 21;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Malabe",
            "Metro",
            "Mathara",
            "Kandy"});
            this.comboBox3.Location = new System.Drawing.Point(139, 119);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(334, 21);
            this.comboBox3.TabIndex = 22;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox4.Location = new System.Drawing.Point(139, 176);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 23;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Main Building",
            "Engineering",
            "Business",
            "Auditoriam"});
            this.comboBox5.Location = new System.Drawing.Point(139, 146);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(334, 21);
            this.comboBox5.TabIndex = 24;
            // 
            // lecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 465);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lecture";
            this.Text = "subjects";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.E_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label Rank;
        private System.Windows.Forms.Label Building;
        private System.Windows.Forms.Label Center;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label EmployeeID;
        private System.Windows.Forms.Label Faculty;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView E_Details;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn LectureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buld;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lev;
        private System.Windows.Forms.DataGridViewTextBoxColumn ranks;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
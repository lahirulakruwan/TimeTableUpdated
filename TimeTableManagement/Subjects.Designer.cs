namespace TimeTableManagement.Forms
{
    partial class Subjects
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
            this.offYear = new System.Windows.Forms.Label();
            this.offSem = new System.Windows.Forms.Label();
            this.subName = new System.Windows.Forms.Label();
            this.subCode = new System.Windows.Forms.Label();
            this.lechrs = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.evalhrs = new System.Windows.Forms.Label();
            this.labhrs = new System.Windows.Forms.Label();
            this.tutehrs = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lechours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuteHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvalHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.tutehrs);
            this.panel1.Controls.Add(this.labhrs);
            this.panel1.Controls.Add(this.evalhrs);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lechrs);
            this.panel1.Controls.Add(this.subCode);
            this.panel1.Controls.Add(this.subName);
            this.panel1.Controls.Add(this.offSem);
            this.panel1.Controls.Add(this.offYear);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 441);
            this.panel1.TabIndex = 0;
            // 
            // offYear
            // 
            this.offYear.AutoSize = true;
            this.offYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.offYear.Location = new System.Drawing.Point(3, 13);
            this.offYear.Name = "offYear";
            this.offYear.Size = new System.Drawing.Size(101, 20);
            this.offYear.TabIndex = 0;
            this.offYear.Text = "Offered Year";
            // 
            // offSem
            // 
            this.offSem.AutoSize = true;
            this.offSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offSem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.offSem.Location = new System.Drawing.Point(3, 54);
            this.offSem.Name = "offSem";
            this.offSem.Size = new System.Drawing.Size(136, 20);
            this.offSem.TabIndex = 1;
            this.offSem.Text = "Offered Semester";
            // 
            // subName
            // 
            this.subName.AutoSize = true;
            this.subName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.subName.Location = new System.Drawing.Point(3, 91);
            this.subName.Name = "subName";
            this.subName.Size = new System.Drawing.Size(109, 20);
            this.subName.TabIndex = 2;
            this.subName.Text = "Subject Name";
            this.subName.Click += new System.EventHandler(this.subName_Click);
            // 
            // subCode
            // 
            this.subCode.AutoSize = true;
            this.subCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.subCode.Location = new System.Drawing.Point(3, 130);
            this.subCode.Name = "subCode";
            this.subCode.Size = new System.Drawing.Size(105, 20);
            this.subCode.TabIndex = 3;
            this.subCode.Text = "Subject Code";
            this.subCode.Click += new System.EventHandler(this.subCode_Click);
            // 
            // lechrs
            // 
            this.lechrs.AutoSize = true;
            this.lechrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lechrs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lechrs.Location = new System.Drawing.Point(3, 169);
            this.lechrs.Name = "lechrs";
            this.lechrs.Size = new System.Drawing.Size(89, 20);
            this.lechrs.TabIndex = 4;
            this.lechrs.Text = "# Of lec hrs";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(386, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(168, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(386, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(386, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(386, 20);
            this.textBox2.TabIndex = 8;
            // 
            // evalhrs
            // 
            this.evalhrs.AutoSize = true;
            this.evalhrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evalhrs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.evalhrs.Location = new System.Drawing.Point(309, 210);
            this.evalhrs.Name = "evalhrs";
            this.evalhrs.Size = new System.Drawing.Size(114, 20);
            this.evalhrs.TabIndex = 9;
            this.evalhrs.Text = "# Of evalus hrs";
            // 
            // labhrs
            // 
            this.labhrs.AutoSize = true;
            this.labhrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labhrs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labhrs.Location = new System.Drawing.Point(3, 210);
            this.labhrs.Name = "labhrs";
            this.labhrs.Size = new System.Drawing.Size(90, 20);
            this.labhrs.TabIndex = 10;
            this.labhrs.Text = "# Of lab hrs";
            this.labhrs.Click += new System.EventHandler(this.label2_Click);
            // 
            // tutehrs
            // 
            this.tutehrs.AutoSize = true;
            this.tutehrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutehrs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tutehrs.Location = new System.Drawing.Point(309, 169);
            this.tutehrs.Name = "tutehrs";
            this.tutehrs.Size = new System.Drawing.Size(97, 20);
            this.tutehrs.TabIndex = 11;
            this.tutehrs.Text = "# Of ture hrs";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(168, 171);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(120, 21);
            this.comboBox3.TabIndex = 12;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(434, 171);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(120, 21);
            this.comboBox4.TabIndex = 13;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(168, 212);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(120, 21);
            this.comboBox5.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(434, 213);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(0, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 183);
            this.panel2.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.year,
            this.sem,
            this.SubjName,
            this.SubjCode,
            this.Lechours,
            this.TuteHours,
            this.LabHours,
            this.EvalHours});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // year
            // 
            this.year.HeaderText = "Off Year";
            this.year.Name = "year";
            // 
            // sem
            // 
            this.sem.HeaderText = "Off Sem";
            this.sem.Name = "sem";
            // 
            // SubjName
            // 
            this.SubjName.HeaderText = "SubName";
            this.SubjName.Name = "SubjName";
            // 
            // SubjCode
            // 
            this.SubjCode.HeaderText = "SubjCode";
            this.SubjCode.Name = "SubjCode";
            // 
            // Lechours
            // 
            this.Lechours.HeaderText = "LecHrs";
            this.Lechours.Name = "Lechours";
            // 
            // TuteHours
            // 
            this.TuteHours.HeaderText = "TuteHrs";
            this.TuteHours.Name = "TuteHours";
            // 
            // LabHours
            // 
            this.LabHours.HeaderText = "LabHrs";
            this.LabHours.Name = "LabHours";
            // 
            // EvalHours
            // 
            this.EvalHours.HeaderText = "EvalHrs";
            this.EvalHours.Name = "EvalHours";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(584, 117);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(141, 31);
            this.Delete.TabIndex = 21;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(584, 65);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(141, 31);
            this.Edit.TabIndex = 20;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(584, 13);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(141, 31);
            this.Add.TabIndex = 19;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 465);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lechrs;
        private System.Windows.Forms.Label subCode;
        private System.Windows.Forms.Label subName;
        private System.Windows.Forms.Label offSem;
        private System.Windows.Forms.Label offYear;
        private System.Windows.Forms.Label tutehrs;
        private System.Windows.Forms.Label labhrs;
        private System.Windows.Forms.Label evalhrs;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn sem;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lechours;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuteHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvalHours;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
    }
}
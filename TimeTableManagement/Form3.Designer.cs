namespace TimeTableManagement.Forms
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.academicyearsem = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Programme_comboBox = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Groupnumber_comboBox = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupId_comboBox = new System.Windows.Forms.ComboBox();
            this.button10 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Sub_group_number_comboBox = new System.Windows.Forms.ComboBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Sub_group_comboBox = new System.Windows.Forms.ComboBox();
            this.button14 = new System.Windows.Forms.Button();
            this.studSubmitbtn = new System.Windows.Forms.Button();
            this.Student_Data_Grid_View = new System.Windows.Forms.DataGridView();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Data_Grid_View)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Academic Year and  Semester";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // academicyearsem
            // 
            this.academicyearsem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.academicyearsem.FormattingEnabled = true;
            this.academicyearsem.Location = new System.Drawing.Point(234, 39);
            this.academicyearsem.Name = "academicyearsem";
            this.academicyearsem.Size = new System.Drawing.Size(136, 21);
            this.academicyearsem.TabIndex = 2;
            this.academicyearsem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(577, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Programme";
            // 
            // Programme_comboBox
            // 
            this.Programme_comboBox.FormattingEnabled = true;
            this.Programme_comboBox.Location = new System.Drawing.Point(234, 98);
            this.Programme_comboBox.Name = "Programme_comboBox";
            this.Programme_comboBox.Size = new System.Drawing.Size(136, 21);
            this.Programme_comboBox.TabIndex = 7;
            this.Programme_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(389, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(482, 96);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(577, 96);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Group number";
            // 
            // Groupnumber_comboBox
            // 
            this.Groupnumber_comboBox.FormattingEnabled = true;
            this.Groupnumber_comboBox.Location = new System.Drawing.Point(234, 150);
            this.Groupnumber_comboBox.Name = "Groupnumber_comboBox";
            this.Groupnumber_comboBox.Size = new System.Drawing.Size(136, 21);
            this.Groupnumber_comboBox.TabIndex = 12;
            this.Groupnumber_comboBox.SelectedIndexChanged += new System.EventHandler(this.Groupnumber_comboBox_SelectedIndexChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(389, 148);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Add";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(482, 148);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 14;
            this.button8.Text = "Edit";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(577, 148);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 15;
            this.button9.Text = "Delete";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Group Id";
            // 
            // GroupId_comboBox
            // 
            this.GroupId_comboBox.FormattingEnabled = true;
            this.GroupId_comboBox.Location = new System.Drawing.Point(234, 205);
            this.GroupId_comboBox.Name = "GroupId_comboBox";
            this.GroupId_comboBox.Size = new System.Drawing.Size(136, 21);
            this.GroupId_comboBox.TabIndex = 18;
            this.GroupId_comboBox.SelectedIndexChanged += new System.EventHandler(this.GroupId_comboBox_SelectedIndexChanged);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(532, 208);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 19;
            this.button10.Text = "Delete";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sub -Group-number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Sub_group_number_comboBox
            // 
            this.Sub_group_number_comboBox.FormattingEnabled = true;
            this.Sub_group_number_comboBox.Location = new System.Drawing.Point(234, 287);
            this.Sub_group_number_comboBox.Name = "Sub_group_number_comboBox";
            this.Sub_group_number_comboBox.Size = new System.Drawing.Size(136, 21);
            this.Sub_group_number_comboBox.TabIndex = 21;
            this.Sub_group_number_comboBox.SelectedIndexChanged += new System.EventHandler(this.Sub_group_number_comboBox_SelectedIndexChanged);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(389, 285);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 22;
            this.button11.Text = "Add";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(482, 285);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 23;
            this.button12.Text = "Edit";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(577, 287);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 24;
            this.button13.Text = "Delete";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Sub -Group-Id";
            // 
            // Sub_group_comboBox
            // 
            this.Sub_group_comboBox.FormattingEnabled = true;
            this.Sub_group_comboBox.Location = new System.Drawing.Point(234, 342);
            this.Sub_group_comboBox.Name = "Sub_group_comboBox";
            this.Sub_group_comboBox.Size = new System.Drawing.Size(136, 21);
            this.Sub_group_comboBox.TabIndex = 27;
            this.Sub_group_comboBox.SelectedIndexChanged += new System.EventHandler(this.Sub_group_comboBox_SelectedIndexChanged);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(532, 340);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 28;
            this.button14.Text = "Delete";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // studSubmitbtn
            // 
            this.studSubmitbtn.Location = new System.Drawing.Point(264, 431);
            this.studSubmitbtn.Name = "studSubmitbtn";
            this.studSubmitbtn.Size = new System.Drawing.Size(119, 35);
            this.studSubmitbtn.TabIndex = 29;
            this.studSubmitbtn.Text = "Submit";
            this.studSubmitbtn.UseVisualStyleBackColor = true;
            this.studSubmitbtn.Click += new System.EventHandler(this.studSubmitbtn_Click);
            // 
            // Student_Data_Grid_View
            // 
            this.Student_Data_Grid_View.AllowUserToAddRows = false;
            this.Student_Data_Grid_View.AllowUserToDeleteRows = false;
            this.Student_Data_Grid_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_Data_Grid_View.Location = new System.Drawing.Point(132, 493);
            this.Student_Data_Grid_View.Name = "Student_Data_Grid_View";
            this.Student_Data_Grid_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Student_Data_Grid_View.Size = new System.Drawing.Size(332, 150);
            this.Student_Data_Grid_View.TabIndex = 30;
            this.Student_Data_Grid_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Student_Data_Grid_View_CellContentClick);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(389, 209);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(117, 21);
            this.button15.TabIndex = 31;
            this.button15.Text = "Submit Group Id";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(389, 342);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(117, 21);
            this.button16.TabIndex = 32;
            this.button16.Text = "Submit Sub Group Id";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(751, 417);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.Student_Data_Grid_View);
            this.Controls.Add(this.studSubmitbtn);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.Sub_group_comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.Sub_group_number_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.GroupId_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Groupnumber_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Programme_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.academicyearsem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "students";
            this.Load += new System.EventHandler(this.students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Student_Data_Grid_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox academicyearsem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Programme_comboBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Groupnumber_comboBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox GroupId_comboBox;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Sub_group_number_comboBox;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Sub_group_comboBox;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button studSubmitbtn;
        private System.Windows.Forms.DataGridView Student_Data_Grid_View;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}
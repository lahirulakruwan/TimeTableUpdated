namespace TimeTableManagement.Forms
{
    partial class TimeTableGenerate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTableGenerate));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LecTimeTable = new System.Windows.Forms.DataGridView();
            this.btnGenLec = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioWeekendLec = new System.Windows.Forms.RadioButton();
            this.radioWeekdayLec = new System.Windows.Forms.RadioButton();
            this.selectLecture = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.selectGroupYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.printPreviewDialogLecturer = new System.Windows.Forms.PrintPreviewDialog();
            this.printTimetableLecturer = new System.Drawing.Printing.PrintDocument();
            this.groupSem = new System.Windows.Forms.ComboBox();
            this.groupId = new System.Windows.Forms.ComboBox();
            this.printPreviewDialogGroup = new System.Windows.Forms.PrintPreviewDialog();
            this.printTimeTableGroup = new System.Drawing.Printing.PrintDocument();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LecTimeTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 701);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LecTimeTable);
            this.tabPage1.Controls.Add(this.btnGenLec);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.selectLecture);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1056, 675);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lecturer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LecTimeTable
            // 
            this.LecTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LecTimeTable.Location = new System.Drawing.Point(43, 241);
            this.LecTimeTable.Name = "LecTimeTable";
            this.LecTimeTable.Size = new System.Drawing.Size(948, 405);
            this.LecTimeTable.TabIndex = 4;
            // 
            // btnGenLec
            // 
            this.btnGenLec.Location = new System.Drawing.Point(43, 196);
            this.btnGenLec.Name = "btnGenLec";
            this.btnGenLec.Size = new System.Drawing.Size(75, 23);
            this.btnGenLec.TabIndex = 3;
            this.btnGenLec.Text = "Generate";
            this.btnGenLec.UseVisualStyleBackColor = true;
            this.btnGenLec.Click += new System.EventHandler(this.btnGenLec_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioWeekendLec);
            this.groupBox1.Controls.Add(this.radioWeekdayLec);
            this.groupBox1.Location = new System.Drawing.Point(43, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 51);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // radioWeekendLec
            // 
            this.radioWeekendLec.AutoSize = true;
            this.radioWeekendLec.Location = new System.Drawing.Point(324, 19);
            this.radioWeekendLec.Name = "radioWeekendLec";
            this.radioWeekendLec.Size = new System.Drawing.Size(72, 17);
            this.radioWeekendLec.TabIndex = 1;
            this.radioWeekendLec.TabStop = true;
            this.radioWeekendLec.Text = "Weekend";
            this.radioWeekendLec.UseVisualStyleBackColor = true;
            // 
            // radioWeekdayLec
            // 
            this.radioWeekdayLec.AutoSize = true;
            this.radioWeekdayLec.Location = new System.Drawing.Point(109, 19);
            this.radioWeekdayLec.Name = "radioWeekdayLec";
            this.radioWeekdayLec.Size = new System.Drawing.Size(71, 17);
            this.radioWeekdayLec.TabIndex = 0;
            this.radioWeekdayLec.TabStop = true;
            this.radioWeekdayLec.Text = "Weekday";
            this.radioWeekdayLec.UseVisualStyleBackColor = true;
            // 
            // selectLecture
            // 
            this.selectLecture.FormattingEnabled = true;
            this.selectLecture.Location = new System.Drawing.Point(140, 60);
            this.selectLecture.Name = "selectLecture";
            this.selectLecture.Size = new System.Drawing.Size(329, 21);
            this.selectLecture.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecturer name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupId);
            this.tabPage2.Controls.Add(this.groupSem);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.selectGroupYear);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1056, 675);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Student Group";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(35, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 51);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(316, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Weekend";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(97, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(71, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Weekday";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // selectGroupYear
            // 
            this.selectGroupYear.FormattingEnabled = true;
            this.selectGroupYear.Items.AddRange(new object[] {
            "Y1",
            "Y2",
            "Y3",
            "Y4"});
            this.selectGroupYear.Location = new System.Drawing.Point(132, 48);
            this.selectGroupYear.Name = "selectGroupYear";
            this.selectGroupYear.Size = new System.Drawing.Size(93, 21);
            this.selectGroupYear.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student Group";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.comboBox3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1056, 675);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Room";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Generate";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Location = new System.Drawing.Point(24, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 51);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(327, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(72, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Weekend";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(97, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(71, 17);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Weekday";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(121, 42);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(329, 21);
            this.comboBox3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Room Name";
            // 
            // printPreviewDialogLecturer
            // 
            this.printPreviewDialogLecturer.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogLecturer.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogLecturer.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogLecturer.Enabled = true;
            this.printPreviewDialogLecturer.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogLecturer.Icon")));
            this.printPreviewDialogLecturer.Name = "printPreviewDialogLecturer";
            this.printPreviewDialogLecturer.Visible = false;
            // 
            // printTimetableLecturer
            // 
            this.printTimetableLecturer.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printTimetableLecturer_PrintPage);
            // 
            // groupSem
            // 
            this.groupSem.FormattingEnabled = true;
            this.groupSem.Items.AddRange(new object[] {
            "S1",
            "S2"});
            this.groupSem.Location = new System.Drawing.Point(254, 48);
            this.groupSem.Name = "groupSem";
            this.groupSem.Size = new System.Drawing.Size(93, 21);
            this.groupSem.TabIndex = 8;
            // 
            // groupId
            // 
            this.groupId.FormattingEnabled = true;
            this.groupId.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.groupId.Location = new System.Drawing.Point(372, 48);
            this.groupId.Name = "groupId";
            this.groupId.Size = new System.Drawing.Size(93, 21);
            this.groupId.TabIndex = 9;
            // 
            // printPreviewDialogGroup
            // 
            this.printPreviewDialogGroup.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogGroup.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogGroup.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogGroup.Enabled = true;
            this.printPreviewDialogGroup.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogGroup.Icon")));
            this.printPreviewDialogGroup.Name = "printPreviewDialogGroup";
            this.printPreviewDialogGroup.Visible = false;
            this.printPreviewDialogGroup.Load += new System.EventHandler(this.printPreviewDialogGroup_Load);
            // 
            // printTimeTableGroup
            // 
            this.printTimeTableGroup.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printTimeTableGroup_PrintPage);
            // 
            // TimeTableGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 714);
            this.Controls.Add(this.tabControl1);
            this.Name = "TimeTableGenerate";
            this.Text = "TimeTableGenerate";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LecTimeTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView LecTimeTable;
        private System.Windows.Forms.Button btnGenLec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioWeekendLec;
        private System.Windows.Forms.RadioButton radioWeekdayLec;
        private System.Windows.Forms.ComboBox selectLecture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ComboBox selectGroupYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogLecturer;
        private System.Drawing.Printing.PrintDocument printTimetableLecturer;
        private System.Windows.Forms.ComboBox groupSem;
        private System.Windows.Forms.ComboBox groupId;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogGroup;
        private System.Drawing.Printing.PrintDocument printTimeTableGroup;
    }
}
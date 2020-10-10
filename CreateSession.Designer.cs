namespace TimeTableManagement.Forms
{
    partial class CreateSession
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lecList = new System.Windows.Forms.ListView();
            this.Createsessions = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datapnl = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sessionList = new System.Windows.Forms.DataGridView();
            this.Addlecture = new System.Windows.Forms.Button();
            this.Scount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.subBox = new System.Windows.Forms.ComboBox();
            this.Gid = new System.Windows.Forms.ComboBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.subcodeList = new System.Windows.Forms.ComboBox();
            this.subNamelist = new System.Windows.Forms.ComboBox();
            this.lecturerlist = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sublbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchSession = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.findSessionList = new System.Windows.Forms.DataGridView();
            this.subjectBox = new System.Windows.Forms.ComboBox();
            this.GroupBox = new System.Windows.Forms.ComboBox();
            this.lecturerbox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.datapnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionList)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findSessionList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 714);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1062, 708);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lecList);
            this.tabPage1.Controls.Add(this.Createsessions);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.Addlecture);
            this.tabPage1.Controls.Add(this.Scount);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.subBox);
            this.tabPage1.Controls.Add(this.Gid);
            this.tabPage1.Controls.Add(this.type);
            this.tabPage1.Controls.Add(this.subcodeList);
            this.tabPage1.Controls.Add(this.subNamelist);
            this.tabPage1.Controls.Add(this.lecturerlist);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.sublbl);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1054, 682);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Sessions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lecList
            // 
            this.lecList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecList.HideSelection = false;
            this.lecList.Location = new System.Drawing.Point(637, 74);
            this.lecList.Name = "lecList";
            this.lecList.Size = new System.Drawing.Size(405, 179);
            this.lecList.TabIndex = 26;
            this.lecList.UseCompatibleStateImageBehavior = false;
            this.lecList.View = System.Windows.Forms.View.List;
            this.lecList.DoubleClick += new System.EventHandler(this.lecList_DoubleClick);
            // 
            // Createsessions
            // 
            this.Createsessions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Createsessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createsessions.Location = new System.Drawing.Point(637, 263);
            this.Createsessions.Name = "Createsessions";
            this.Createsessions.Size = new System.Drawing.Size(282, 40);
            this.Createsessions.TabIndex = 25;
            this.Createsessions.Text = "Create Session";
            this.Createsessions.UseVisualStyleBackColor = false;
            this.Createsessions.Click += new System.EventHandler(this.Createsessions_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datapnl);
            this.panel2.Controls.Add(this.sessionList);
            this.panel2.Location = new System.Drawing.Point(6, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 320);
            this.panel2.TabIndex = 24;
            // 
            // datapnl
            // 
            this.datapnl.Controls.Add(this.flowLayoutPanel1);
            this.datapnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datapnl.Location = new System.Drawing.Point(0, 0);
            this.datapnl.Name = "datapnl";
            this.datapnl.Size = new System.Drawing.Size(1043, 320);
            this.datapnl.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1043, 320);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // sessionList
            // 
            this.sessionList.AllowUserToAddRows = false;
            this.sessionList.AllowUserToDeleteRows = false;
            this.sessionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sessionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionList.Location = new System.Drawing.Point(3, 3);
            this.sessionList.Name = "sessionList";
            this.sessionList.ReadOnly = true;
            this.sessionList.Size = new System.Drawing.Size(1033, 314);
            this.sessionList.TabIndex = 0;
            // 
            // Addlecture
            // 
            this.Addlecture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Addlecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addlecture.ForeColor = System.Drawing.Color.Black;
            this.Addlecture.Location = new System.Drawing.Point(546, 35);
            this.Addlecture.Name = "Addlecture";
            this.Addlecture.Size = new System.Drawing.Size(76, 28);
            this.Addlecture.TabIndex = 23;
            this.Addlecture.Text = "Add";
            this.Addlecture.UseVisualStyleBackColor = false;
            this.Addlecture.Click += new System.EventHandler(this.Addlecture_Click);
            // 
            // Scount
            // 
            this.Scount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scount.Location = new System.Drawing.Point(153, 230);
            this.Scount.Name = "Scount";
            this.Scount.Size = new System.Drawing.Size(129, 26);
            this.Scount.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(633, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Added Lecturers";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(42, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Student Count";
            // 
            // subBox
            // 
            this.subBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBox.FormattingEnabled = true;
            this.subBox.Items.AddRange(new object[] {
            "s1",
            "s2"});
            this.subBox.Location = new System.Drawing.Point(411, 192);
            this.subBox.Name = "subBox";
            this.subBox.Size = new System.Drawing.Size(129, 28);
            this.subBox.TabIndex = 14;
            // 
            // Gid
            // 
            this.Gid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gid.FormattingEnabled = true;
            this.Gid.Items.AddRange(new object[] {
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
            this.Gid.Location = new System.Drawing.Point(153, 192);
            this.Gid.Name = "Gid";
            this.Gid.Size = new System.Drawing.Size(129, 28);
            this.Gid.TabIndex = 13;
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Lecture",
            "Tutorial",
            "Practical"});
            this.type.Location = new System.Drawing.Point(153, 152);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(387, 28);
            this.type.TabIndex = 12;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // subcodeList
            // 
            this.subcodeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subcodeList.FormattingEnabled = true;
            this.subcodeList.Location = new System.Drawing.Point(153, 113);
            this.subcodeList.Name = "subcodeList";
            this.subcodeList.Size = new System.Drawing.Size(387, 28);
            this.subcodeList.TabIndex = 11;
            // 
            // subNamelist
            // 
            this.subNamelist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subNamelist.FormattingEnabled = true;
            this.subNamelist.Location = new System.Drawing.Point(153, 74);
            this.subNamelist.Name = "subNamelist";
            this.subNamelist.Size = new System.Drawing.Size(387, 28);
            this.subNamelist.TabIndex = 10;
            this.subNamelist.SelectedIndexChanged += new System.EventHandler(this.subNamelist_SelectedIndexChanged);
            // 
            // lecturerlist
            // 
            this.lecturerlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturerlist.FormattingEnabled = true;
            this.lecturerlist.Location = new System.Drawing.Point(153, 36);
            this.lecturerlist.Name = "lecturerlist";
            this.lecturerlist.Size = new System.Drawing.Size(387, 28);
            this.lecturerlist.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(42, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Subject";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(42, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Subject Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(42, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Group ID";
            // 
            // sublbl
            // 
            this.sublbl.AutoSize = true;
            this.sublbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sublbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sublbl.Location = new System.Drawing.Point(300, 200);
            this.sublbl.Name = "sublbl";
            this.sublbl.Size = new System.Drawing.Size(104, 20);
            this.sublbl.TabIndex = 2;
            this.sublbl.Text = "Sub group ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(42, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lecturer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(42, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1054, 682);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Find Sessions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.searchSession);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.subjectBox);
            this.panel3.Controls.Add(this.GroupBox);
            this.panel3.Controls.Add(this.lecturerbox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1048, 676);
            this.panel3.TabIndex = 0;
            // 
            // searchSession
            // 
            this.searchSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.searchSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSession.Location = new System.Drawing.Point(612, 97);
            this.searchSession.Name = "searchSession";
            this.searchSession.Size = new System.Drawing.Size(209, 32);
            this.searchSession.TabIndex = 7;
            this.searchSession.Text = "Search";
            this.searchSession.UseVisualStyleBackColor = false;
            this.searchSession.Click += new System.EventHandler(this.searchSession_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.findSessionList);
            this.panel4.Location = new System.Drawing.Point(3, 300);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1043, 376);
            this.panel4.TabIndex = 6;
            // 
            // findSessionList
            // 
            this.findSessionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.findSessionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.findSessionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findSessionList.Location = new System.Drawing.Point(0, 0);
            this.findSessionList.Name = "findSessionList";
            this.findSessionList.Size = new System.Drawing.Size(1043, 376);
            this.findSessionList.TabIndex = 0;
            // 
            // subjectBox
            // 
            this.subjectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectBox.FormattingEnabled = true;
            this.subjectBox.Location = new System.Drawing.Point(612, 45);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(209, 28);
            this.subjectBox.TabIndex = 5;
            this.subjectBox.Text = "All";
            // 
            // GroupBox
            // 
            this.GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.FormattingEnabled = true;
            this.GroupBox.Location = new System.Drawing.Point(198, 95);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(209, 28);
            this.GroupBox.TabIndex = 4;
            this.GroupBox.Text = "All";
            // 
            // lecturerbox
            // 
            this.lecturerbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturerbox.FormattingEnabled = true;
            this.lecturerbox.Location = new System.Drawing.Point(198, 45);
            this.lecturerbox.Name = "lecturerbox";
            this.lecturerbox.Size = new System.Drawing.Size(209, 28);
            this.lecturerbox.TabIndex = 3;
            this.lecturerbox.SelectedIndexChanged += new System.EventHandler(this.lecturerbox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(543, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(108, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Group ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(108, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lecturer";
            // 
            // CreateSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 714);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateSession";
            this.Text = "CreateSession";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.datapnl.ResumeLayout(false);
            this.datapnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.findSessionList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox subNamelist;
        private System.Windows.Forms.ComboBox lecturerlist;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sublbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Addlecture;
        private System.Windows.Forms.TextBox Scount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox subBox;
        private System.Windows.Forms.ComboBox Gid;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.ComboBox subcodeList;
        private System.Windows.Forms.Button Createsessions;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lecList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button searchSession;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView findSessionList;
        private System.Windows.Forms.ComboBox subjectBox;
        private System.Windows.Forms.ComboBox GroupBox;
        private System.Windows.Forms.ComboBox lecturerbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView sessionList;
        private System.Windows.Forms.Panel datapnl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
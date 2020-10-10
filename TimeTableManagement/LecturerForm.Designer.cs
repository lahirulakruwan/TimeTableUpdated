namespace TimeTableManagement.Forms
{
    partial class LecturerForm
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
            this.clear = new System.Windows.Forms.Button();
            this.delLec = new System.Windows.Forms.Button();
            this.editLec = new System.Windows.Forms.Button();
            this.addLec = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lecturerTble = new System.Windows.Forms.DataGridView();
            this.leveltxt = new System.Windows.Forms.ComboBox();
            this.buildingtxt = new System.Windows.Forms.ComboBox();
            this.centertxt = new System.Windows.Forms.ComboBox();
            this.depttxt = new System.Windows.Forms.ComboBox();
            this.factxt = new System.Windows.Forms.ComboBox();
            this.eidtxt = new System.Windows.Forms.TextBox();
            this.ranktxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EId = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerTble)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.delLec);
            this.panel1.Controls.Add(this.editLec);
            this.panel1.Controls.Add(this.addLec);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.leveltxt);
            this.panel1.Controls.Add(this.buildingtxt);
            this.panel1.Controls.Add(this.centertxt);
            this.panel1.Controls.Add(this.depttxt);
            this.panel1.Controls.Add(this.factxt);
            this.panel1.Controls.Add(this.eidtxt);
            this.panel1.Controls.Add(this.ranktxt);
            this.panel1.Controls.Add(this.nametxt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EId);
            this.panel1.Controls.Add(this.lName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 705);
            this.panel1.TabIndex = 0;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(799, 340);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(169, 35);
            this.clear.TabIndex = 20;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // delLec
            // 
            this.delLec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.delLec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delLec.Location = new System.Drawing.Point(568, 340);
            this.delLec.Name = "delLec";
            this.delLec.Size = new System.Drawing.Size(169, 35);
            this.delLec.TabIndex = 19;
            this.delLec.Text = "Delete";
            this.delLec.UseVisualStyleBackColor = false;
            this.delLec.Click += new System.EventHandler(this.delLec_Click);
            // 
            // editLec
            // 
            this.editLec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.editLec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLec.Location = new System.Drawing.Point(309, 340);
            this.editLec.Name = "editLec";
            this.editLec.Size = new System.Drawing.Size(169, 35);
            this.editLec.TabIndex = 18;
            this.editLec.Text = "Edit";
            this.editLec.UseVisualStyleBackColor = false;
            this.editLec.Click += new System.EventHandler(this.editLec_Click);
            // 
            // addLec
            // 
            this.addLec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addLec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLec.Location = new System.Drawing.Point(51, 340);
            this.addLec.Name = "addLec";
            this.addLec.Size = new System.Drawing.Size(169, 35);
            this.addLec.TabIndex = 17;
            this.addLec.Text = "Add";
            this.addLec.UseVisualStyleBackColor = false;
            this.addLec.Click += new System.EventHandler(this.addLec_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lecturerTble);
            this.panel2.Location = new System.Drawing.Point(7, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 298);
            this.panel2.TabIndex = 16;
            // 
            // lecturerTble
            // 
            this.lecturerTble.AllowUserToAddRows = false;
            this.lecturerTble.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lecturerTble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lecturerTble.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lecturerTble.Location = new System.Drawing.Point(0, 0);
            this.lecturerTble.Name = "lecturerTble";
            this.lecturerTble.Size = new System.Drawing.Size(1026, 298);
            this.lecturerTble.TabIndex = 0;
            this.lecturerTble.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lecturerTble_CellContentDoubleClick);
            // 
            // leveltxt
            // 
            this.leveltxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leveltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leveltxt.FormattingEnabled = true;
            this.leveltxt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.leveltxt.Location = new System.Drawing.Point(364, 282);
            this.leveltxt.Name = "leveltxt";
            this.leveltxt.Size = new System.Drawing.Size(166, 28);
            this.leveltxt.TabIndex = 15;
            this.leveltxt.SelectedIndexChanged += new System.EventHandler(this.leveltxt_SelectedIndexChanged);
            // 
            // buildingtxt
            // 
            this.buildingtxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildingtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingtxt.FormattingEnabled = true;
            this.buildingtxt.Items.AddRange(new object[] {
            "Main Building",
            "New building",
            "Engineering",
            "Business"});
            this.buildingtxt.Location = new System.Drawing.Point(364, 236);
            this.buildingtxt.Name = "buildingtxt";
            this.buildingtxt.Size = new System.Drawing.Size(392, 28);
            this.buildingtxt.TabIndex = 14;
            // 
            // centertxt
            // 
            this.centertxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.centertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centertxt.FormattingEnabled = true;
            this.centertxt.Items.AddRange(new object[] {
            "Malabe",
            "Metro",
            "Mathara",
            "Kandy"});
            this.centertxt.Location = new System.Drawing.Point(364, 190);
            this.centertxt.Name = "centertxt";
            this.centertxt.Size = new System.Drawing.Size(392, 28);
            this.centertxt.TabIndex = 13;
            // 
            // depttxt
            // 
            this.depttxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.depttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depttxt.FormattingEnabled = true;
            this.depttxt.Location = new System.Drawing.Point(364, 145);
            this.depttxt.Name = "depttxt";
            this.depttxt.Size = new System.Drawing.Size(392, 28);
            this.depttxt.TabIndex = 12;
            this.depttxt.SelectedIndexChanged += new System.EventHandler(this.depttxt_SelectedIndexChanged);
            // 
            // factxt
            // 
            this.factxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.factxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factxt.FormattingEnabled = true;
            this.factxt.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Humanities & Sciences",
            "Graduate Studies and Research",
            "School of Architecture"});
            this.factxt.Location = new System.Drawing.Point(364, 98);
            this.factxt.Name = "factxt";
            this.factxt.Size = new System.Drawing.Size(392, 28);
            this.factxt.TabIndex = 11;
            this.factxt.SelectedIndexChanged += new System.EventHandler(this.factxt_SelectedIndexChanged);
            // 
            // eidtxt
            // 
            this.eidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eidtxt.Location = new System.Drawing.Point(364, 55);
            this.eidtxt.MaxLength = 6;
            this.eidtxt.Name = "eidtxt";
            this.eidtxt.Size = new System.Drawing.Size(392, 26);
            this.eidtxt.TabIndex = 10;
            // 
            // ranktxt
            // 
            this.ranktxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ranktxt.Location = new System.Drawing.Point(590, 284);
            this.ranktxt.Name = "ranktxt";
            this.ranktxt.ReadOnly = true;
            this.ranktxt.Size = new System.Drawing.Size(166, 29);
            this.ranktxt.TabIndex = 9;
            this.ranktxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(364, 18);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(392, 26);
            this.nametxt.TabIndex = 8;
            this.nametxt.TextChanged += new System.EventHandler(this.nametxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(257, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Faculty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(257, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(257, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Center";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(257, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Building";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(257, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Level";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(537, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rank";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EId
            // 
            this.EId.AutoSize = true;
            this.EId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EId.Location = new System.Drawing.Point(257, 61);
            this.EId.Name = "EId";
            this.EId.Size = new System.Drawing.Size(100, 20);
            this.EId.TabIndex = 1;
            this.EId.Text = "Employee ID";
            this.EId.Click += new System.EventHandler(this.EId_Click);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lName.Location = new System.Drawing.Point(257, 29);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(51, 20);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name";
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 729);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LecturerForm";
            this.Text = "LecturerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lecturerTble)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EId;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.ComboBox leveltxt;
        private System.Windows.Forms.ComboBox buildingtxt;
        private System.Windows.Forms.ComboBox centertxt;
        private System.Windows.Forms.ComboBox depttxt;
        private System.Windows.Forms.ComboBox factxt;
        private System.Windows.Forms.TextBox eidtxt;
        private System.Windows.Forms.TextBox ranktxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView lecturerTble;
        private System.Windows.Forms.Button delLec;
        private System.Windows.Forms.Button editLec;
        private System.Windows.Forms.Button addLec;
        private System.Windows.Forms.Button clear;
    }
}
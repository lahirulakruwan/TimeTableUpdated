namespace TimeTableManagement.Forms
{
    partial class StaticsRelated
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.roomTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet2 = new TimeTableManagement.myDBDataSet2();
            this.roomTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet1 = new TimeTableManagement.myDBDataSet1();
            this.myDBDataSet = new TimeTableManagement.myDBDataSet();
            this.myDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableTableAdapter = new TimeTableManagement.myDBDataSet1TableAdapters.RoomTableTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.subjectTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet3 = new TimeTableManagement.myDBDataSet3();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lecturerTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet4 = new TimeTableManagement.myDBDataSet4();
            this.roomTableTableAdapter1 = new TimeTableManagement.myDBDataSet2TableAdapters.RoomTableTableAdapter();
            this.subjectTableTableAdapter = new TimeTableManagement.myDBDataSet3TableAdapters.SubjectTableTableAdapter();
            this.lecturerTblTableAdapter = new TimeTableManagement.myDBDataSet4TableAdapters.LecturerTblTableAdapter();
            this.myDBDataSet5 = new TimeTableManagement.myDBDataSet5();
            this.roomTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableTableAdapter2 = new TimeTableManagement.myDBDataSet5TableAdapters.RoomTableTableAdapter();
            this.myDBDataSet6 = new TimeTableManagement.myDBDataSet6();
            this.lecturerTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lecturerTblTableAdapter1 = new TimeTableManagement.myDBDataSet6TableAdapters.LecturerTblTableAdapter();
            this.myDBDataSet7 = new TimeTableManagement.myDBDataSet7();
            this.subjectTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectTableTableAdapter1 = new TimeTableManagement.myDBDataSet7TableAdapters.SubjectTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.roomTableBindingSource2;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(42, 67);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "roomName";
            series1.YValueMembers = "roomCapacity";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(490, 278);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // roomTableBindingSource1
            // 
            this.roomTableBindingSource1.DataMember = "RoomTable";
            this.roomTableBindingSource1.DataSource = this.myDBDataSet2;
            // 
            // myDBDataSet2
            // 
            this.myDBDataSet2.DataSetName = "myDBDataSet2";
            this.myDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTableBindingSource
            // 
            this.roomTableBindingSource.DataMember = "RoomTable";
            this.roomTableBindingSource.DataSource = this.myDBDataSet1;
            // 
            // myDBDataSet1
            // 
            this.myDBDataSet1.DataSetName = "myDBDataSet1";
            this.myDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "myDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myDBDataSetBindingSource
            // 
            this.myDBDataSetBindingSource.DataSource = this.myDBDataSet;
            this.myDBDataSetBindingSource.Position = 0;
            // 
            // roomTableTableAdapter
            // 
            this.roomTableTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(42, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(490, 39);
            this.label4.TabIndex = 53;
            this.label4.Text = "Releated Statics comparing to rooms with capacity";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(545, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 35);
            this.label1.TabIndex = 54;
            this.label1.Text = "Releated Statics comparing to Lecturers with levels";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(342, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 57);
            this.label2.TabIndex = 55;
            this.label2.Text = "Releated Statics comparing to Subjects with years";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.DataSource = this.subjectTableBindingSource1;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(42, 424);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "SubName";
            series2.YValueMembers = "year";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(997, 278);
            this.chart2.TabIndex = 56;
            this.chart2.Text = "chart2";
            // 
            // subjectTableBindingSource
            // 
            this.subjectTableBindingSource.DataMember = "SubjectTable";
            this.subjectTableBindingSource.DataSource = this.myDBDataSet3;
            // 
            // myDBDataSet3
            // 
            this.myDBDataSet3.DataSetName = "myDBDataSet3";
            this.myDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.DataSource = this.lecturerTblBindingSource1;
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(549, 67);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.XValueMember = "name";
            series3.YValueMembers = "level";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(490, 278);
            this.chart3.TabIndex = 57;
            this.chart3.Text = "chart3";
            // 
            // lecturerTblBindingSource
            // 
            this.lecturerTblBindingSource.DataMember = "LecturerTbl";
            this.lecturerTblBindingSource.DataSource = this.myDBDataSet4;
            // 
            // myDBDataSet4
            // 
            this.myDBDataSet4.DataSetName = "myDBDataSet4";
            this.myDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTableTableAdapter1
            // 
            this.roomTableTableAdapter1.ClearBeforeFill = true;
            // 
            // subjectTableTableAdapter
            // 
            this.subjectTableTableAdapter.ClearBeforeFill = true;
            // 
            // lecturerTblTableAdapter
            // 
            this.lecturerTblTableAdapter.ClearBeforeFill = true;
            // 
            // myDBDataSet5
            // 
            this.myDBDataSet5.DataSetName = "myDBDataSet5";
            this.myDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTableBindingSource2
            // 
            this.roomTableBindingSource2.DataMember = "RoomTable";
            this.roomTableBindingSource2.DataSource = this.myDBDataSet5;
            // 
            // roomTableTableAdapter2
            // 
            this.roomTableTableAdapter2.ClearBeforeFill = true;
            // 
            // myDBDataSet6
            // 
            this.myDBDataSet6.DataSetName = "myDBDataSet6";
            this.myDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturerTblBindingSource1
            // 
            this.lecturerTblBindingSource1.DataMember = "LecturerTbl";
            this.lecturerTblBindingSource1.DataSource = this.myDBDataSet6;
            // 
            // lecturerTblTableAdapter1
            // 
            this.lecturerTblTableAdapter1.ClearBeforeFill = true;
            // 
            // myDBDataSet7
            // 
            this.myDBDataSet7.DataSetName = "myDBDataSet7";
            this.myDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectTableBindingSource1
            // 
            this.subjectTableBindingSource1.DataMember = "SubjectTable";
            this.subjectTableBindingSource1.DataSource = this.myDBDataSet7;
            // 
            // subjectTableTableAdapter1
            // 
            this.subjectTableTableAdapter1.ClearBeforeFill = true;
            // 
            // StaticsRelated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 714);
            this.ControlBox = false;
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Name = "StaticsRelated";
            this.Text = "StaticsRelated";
            this.Load += new System.EventHandler(this.StaticsRelated_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectTableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource myDBDataSetBindingSource;
        private myDBDataSet myDBDataSet;
        private myDBDataSet1 myDBDataSet1;
        private System.Windows.Forms.BindingSource roomTableBindingSource;
        private myDBDataSet1TableAdapters.RoomTableTableAdapter roomTableTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private myDBDataSet2 myDBDataSet2;
        private System.Windows.Forms.BindingSource roomTableBindingSource1;
        private myDBDataSet2TableAdapters.RoomTableTableAdapter roomTableTableAdapter1;
        private myDBDataSet3 myDBDataSet3;
        private System.Windows.Forms.BindingSource subjectTableBindingSource;
        private myDBDataSet3TableAdapters.SubjectTableTableAdapter subjectTableTableAdapter;
        private myDBDataSet4 myDBDataSet4;
        private System.Windows.Forms.BindingSource lecturerTblBindingSource;
        private myDBDataSet4TableAdapters.LecturerTblTableAdapter lecturerTblTableAdapter;
        private myDBDataSet5 myDBDataSet5;
        private System.Windows.Forms.BindingSource roomTableBindingSource2;
        private myDBDataSet5TableAdapters.RoomTableTableAdapter roomTableTableAdapter2;
        private myDBDataSet6 myDBDataSet6;
        private System.Windows.Forms.BindingSource lecturerTblBindingSource1;
        private myDBDataSet6TableAdapters.LecturerTblTableAdapter lecturerTblTableAdapter1;
        private myDBDataSet7 myDBDataSet7;
        private System.Windows.Forms.BindingSource subjectTableBindingSource1;
        private myDBDataSet7TableAdapters.SubjectTableTableAdapter subjectTableTableAdapter1;
    }
}
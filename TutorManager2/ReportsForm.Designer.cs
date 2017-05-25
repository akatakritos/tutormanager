namespace TutorManager2
{
    partial class ReportsForm
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tutorDataSet = new TutorManager2.TutorDataSet();
            this.hoursByClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoursByClientTableAdapter = new TutorManager2.TutorDataSetTableAdapters.HoursByClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursByClientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.hoursByClientBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "Name";
            series1.YValueMembers = "TotalHours";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(522, 409);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tutorDataSet
            // 
            this.tutorDataSet.DataSetName = "TutorDataSet";
            this.tutorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoursByClientBindingSource
            // 
            this.hoursByClientBindingSource.DataMember = "HoursByClient";
            this.hoursByClientBindingSource.DataSource = this.tutorDataSet;
            // 
            // hoursByClientTableAdapter
            // 
            this.hoursByClientTableAdapter.ClearBeforeFill = true;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 433);
            this.Controls.Add(this.chart1);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursByClientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TutorDataSet tutorDataSet;
        private System.Windows.Forms.BindingSource hoursByClientBindingSource;
        private TutorDataSetTableAdapters.HoursByClientTableAdapter hoursByClientTableAdapter;
    }
}
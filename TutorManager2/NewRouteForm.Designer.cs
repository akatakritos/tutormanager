namespace TutorManager2
{
    partial class NewRouteForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.tutorDataSet = new TutorManager2.TutorDataSet();
            this.cboTo = new System.Windows.Forms.ComboBox();
            this.placesTableAdapter = new TutorManager2.TutorDataSetTableAdapters.PlacesTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tutorDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "To:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 20);
            this.txtName.TabIndex = 5;
            // 
            // cboFrom
            // 
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.Location = new System.Drawing.Point(67, 39);
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(157, 21);
            this.cboFrom.TabIndex = 6;
            this.cboFrom.SelectedIndexChanged += new System.EventHandler(this.placesBindingSource_CurrentChanged);
            // 
            // tutorDataSet
            // 
            this.tutorDataSet.DataSetName = "TutorDataSet";
            this.tutorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboTo
            // 
            this.cboTo.FormattingEnabled = true;
            this.cboTo.Location = new System.Drawing.Point(67, 66);
            this.cboTo.Name = "cboTo";
            this.cboTo.Size = new System.Drawing.Size(157, 21);
            this.cboTo.TabIndex = 7;
            this.cboTo.SelectedIndexChanged += new System.EventHandler(this.placesBindingSource_CurrentChanged);
            // 
            // placesTableAdapter
            // 
            this.placesTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Miles:";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(66, 93);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(157, 20);
            this.txtMiles.TabIndex = 9;
            // 
            // NewRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 172);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboTo);
            this.Controls.Add(this.cboFrom);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "NewRouteForm";
            this.Text = "New Route";
            this.Load += new System.EventHandler(this.NewRouteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tutorDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboFrom;
        private System.Windows.Forms.ComboBox cboTo;
        private TutorDataSet tutorDataSet;
        private TutorDataSetTableAdapters.PlacesTableAdapter placesTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMiles;
    }
}
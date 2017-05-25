namespace TutorManager2
{
    partial class EditRoutesForm
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
            this.tutorDataSet = new TutorManager2.TutorDataSet();
            this.routesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routesTableAdapter = new TutorManager2.TutorDataSetTableAdapters.RoutesTableAdapter();
            this.tableAdapterManager = new TutorManager2.TutorDataSetTableAdapters.TableAdapterManager();
            this.placesTableAdapter1 = new TutorManager2.TutorDataSetTableAdapters.PlacesTableAdapter();
            this.routesDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromPlaceColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toPlaceColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tutorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tutorDataSet
            // 
            this.tutorDataSet.DataSetName = "TutorDataSet";
            this.tutorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routesBindingSource
            // 
            this.routesBindingSource.DataMember = "Routes";
            this.routesBindingSource.DataSource = this.tutorDataSet;
            // 
            // routesTableAdapter
            // 
            this.routesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.PaychecksTableAdapter = null;
            this.tableAdapterManager.PlacesTableAdapter = this.placesTableAdapter1;
            this.tableAdapterManager.RoutesTableAdapter = this.routesTableAdapter;
            this.tableAdapterManager.SessionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TutorManager2.TutorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // placesTableAdapter1
            // 
            this.placesTableAdapter1.ClearBeforeFill = true;
            // 
            // routesDataGridView
            // 
            this.routesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.routesDataGridView.AutoGenerateColumns = false;
            this.routesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.fromPlaceColumn,
            this.toPlaceColumn,
            this.dataGridViewTextBoxColumn5});
            this.routesDataGridView.DataSource = this.routesBindingSource;
            this.routesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.routesDataGridView.Name = "routesDataGridView";
            this.routesDataGridView.Size = new System.Drawing.Size(562, 285);
            this.routesDataGridView.TabIndex = 1;
            this.routesDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.routesDataGridView_CellValueChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Places";
            this.bindingSource1.DataSource = this.tutorDataSet;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(256, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // fromPlaceColumn
            // 
            this.fromPlaceColumn.DataPropertyName = "FromPlace";
            this.fromPlaceColumn.DataSource = this.bindingSource1;
            this.fromPlaceColumn.DisplayMember = "Name";
            this.fromPlaceColumn.HeaderText = "From";
            this.fromPlaceColumn.Name = "fromPlaceColumn";
            this.fromPlaceColumn.ValueMember = "PlaceID";
            // 
            // toPlaceColumn
            // 
            this.toPlaceColumn.DataPropertyName = "ToPlace";
            this.toPlaceColumn.DataSource = this.bindingSource1;
            this.toPlaceColumn.DisplayMember = "Name";
            this.toPlaceColumn.HeaderText = "To";
            this.toPlaceColumn.Name = "toPlaceColumn";
            this.toPlaceColumn.ValueMember = "PlaceID";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Miles";
            this.dataGridViewTextBoxColumn5.HeaderText = "Miles";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // EditRoutesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.routesDataGridView);
            this.Name = "EditRoutesForm";
            this.Text = "Edit Routes";
            this.Load += new System.EventHandler(this.EditRoutesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tutorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TutorDataSet tutorDataSet;
        private System.Windows.Forms.BindingSource routesBindingSource;
        private TutorDataSetTableAdapters.RoutesTableAdapter routesTableAdapter;
        private TutorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TutorDataSetTableAdapters.PlacesTableAdapter placesTableAdapter1;
        private System.Windows.Forms.DataGridView routesDataGridView;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn fromPlaceColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn toPlaceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
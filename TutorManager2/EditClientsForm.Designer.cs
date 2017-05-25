namespace TutorManager2
{
    partial class EditClientsForm
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
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new TutorManager2.TutorDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new TutorManager2.TutorDataSetTableAdapters.TableAdapterManager();
            this.placesTableAdapter1 = new TutorManager2.TutorDataSetTableAdapters.PlacesTableAdapter();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tutorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tutorDataSet
            // 
            this.tutorDataSet.DataSetName = "TutorDataSet";
            this.tutorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.tutorDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.PaychecksTableAdapter = null;
            this.tableAdapterManager.PlacesTableAdapter = this.placesTableAdapter1;
            this.tableAdapterManager.RoutesTableAdapter = null;
            this.tableAdapterManager.SessionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TutorManager2.TutorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // placesTableAdapter1
            // 
            this.placesTableAdapter1.ClearBeforeFill = true;
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientsDataGridView.AutoGenerateColumns = false;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.PlaceID});
            this.clientsDataGridView.DataSource = this.clientsBindingSource;
            this.clientsDataGridView.Location = new System.Drawing.Point(12, 11);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.Size = new System.Drawing.Size(729, 307);
            this.clientsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ClientID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ClientID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 69;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ParentName";
            this.dataGridViewTextBoxColumn3.HeaderText = "ParentName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Subjects";
            this.dataGridViewTextBoxColumn6.HeaderText = "Subjects";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // PlaceID
            // 
            this.PlaceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlaceID.DataPropertyName = "PlaceID";
            this.PlaceID.DataSource = this.bindingSource1;
            this.PlaceID.DisplayMember = "Name";
            this.PlaceID.HeaderText = "Place";
            this.PlaceID.Name = "PlaceID";
            this.PlaceID.ValueMember = "PlaceID";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Places";
            this.bindingSource1.DataSource = this.tutorDataSet;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(339, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clientsDataGridView);
            this.MinimumSize = new System.Drawing.Size(769, 174);
            this.Name = "EditClientsForm";
            this.Text = "Edit Clients";
            this.Load += new System.EventHandler(this.EditClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tutorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private TutorDataSet tutorDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private TutorDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private TutorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TutorDataSetTableAdapters.PlacesTableAdapter placesTableAdapter1;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn PlaceID;
    }
}
namespace TutorManager2
{
    partial class EnterPayCheckForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label6;
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.paychecksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tutorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tutorDataSet = new TutorManager2.TutorDataSet();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtImport = new System.Windows.Forms.TextBox();
            this.sessionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionsTableAdapter = new TutorManager2.TutorDataSetTableAdapters.SessionsTableAdapter();
            this.tableAdapterManager = new TutorManager2.TutorDataSetTableAdapters.TableAdapterManager();
            this.sessionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Route = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.routesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.txtFederalTax = new System.Windows.Forms.TextBox();
            this.paychecksTableAdapter = new TutorManager2.TutorDataSetTableAdapters.PaychecksTableAdapter();
            this.sessionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new TutorManager2.TutorDataSetTableAdapters.ClientsTableAdapter();
            this.routesTableAdapter = new TutorManager2.TutorDataSetTableAdapters.RoutesTableAdapter();
            this.txtStateTax = new System.Windows.Forms.TextBox();
            this.lblNet = new System.Windows.Forms.Label();
            this.dtpPeriodEnd = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paychecksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(135, 13);
            label1.TabIndex = 1;
            label1.Text = "Select Previous Paycheck:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(217, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 13);
            label2.TabIndex = 6;
            label2.Text = "Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(589, 56);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(27, 13);
            label4.TabIndex = 9;
            label4.Text = "Net:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(351, 54);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 13);
            label5.TabIndex = 10;
            label5.Text = "Federal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(475, 54);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(35, 13);
            label3.TabIndex = 15;
            label3.Text = "State:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.paychecksBindingSource;
            this.comboBox1.DisplayMember = "Date";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "PaycheckID";
            // 
            // paychecksBindingSource
            // 
            this.paychecksBindingSource.DataMember = "Paychecks";
            this.paychecksBindingSource.DataSource = this.tutorDataSetBindingSource;
            // 
            // tutorDataSetBindingSource
            // 
            this.tutorDataSetBindingSource.DataSource = this.tutorDataSet;
            this.tutorDataSetBindingSource.Position = 0;
            // 
            // tutorDataSet
            // 
            this.tutorDataSet.DataSetName = "TutorDataSet";
            this.tutorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(296, 13);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(196, 20);
            this.dtpDate.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(269, 53);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(69, 20);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtImport
            // 
            this.txtImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImport.Location = new System.Drawing.Point(15, 90);
            this.txtImport.Multiline = true;
            this.txtImport.Name = "txtImport";
            this.txtImport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtImport.Size = new System.Drawing.Size(664, 74);
            this.txtImport.TabIndex = 4;
            this.txtImport.Text = "Paste Here";
            this.txtImport.Click += new System.EventHandler(this.txtImport_Click);
            // 
            // sessionsBindingSource
            // 
            this.sessionsBindingSource.DataMember = "Sessions";
            this.sessionsBindingSource.DataSource = this.tutorDataSet;
            // 
            // sessionsTableAdapter
            // 
            this.sessionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.PaychecksTableAdapter = null;
            this.tableAdapterManager.PlacesTableAdapter = null;
            this.tableAdapterManager.RoutesTableAdapter = null;
            this.tableAdapterManager.SessionsTableAdapter = this.sessionsTableAdapter;
            this.tableAdapterManager.UpdateOrder = TutorManager2.TutorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sessionsDataGridView
            // 
            this.sessionsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sessionsDataGridView.AutoGenerateColumns = false;
            this.sessionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.Client,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.Route});
            this.sessionsDataGridView.DataSource = this.sessionsBindingSource;
            this.sessionsDataGridView.Location = new System.Drawing.Point(12, 199);
            this.sessionsDataGridView.Name = "sessionsDataGridView";
            this.sessionsDataGridView.Size = new System.Drawing.Size(692, 183);
            this.sessionsDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SessionID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SessionID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn4.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 72;
            // 
            // Client
            // 
            this.Client.DataPropertyName = "Client";
            this.Client.DataSource = this.clientsBindingSource;
            this.Client.DisplayMember = "Name";
            this.Client.HeaderText = "Client";
            this.Client.Name = "Client";
            this.Client.ValueMember = "ClientID";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.tutorDataSet;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PayRate";
            this.dataGridViewTextBoxColumn5.HeaderText = "PayRate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 73;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AmountEarned";
            this.dataGridViewTextBoxColumn8.HeaderText = "AmountEarned";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 102;
            // 
            // Route
            // 
            this.Route.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Route.DataPropertyName = "Route";
            this.Route.DataSource = this.routesBindingSource;
            this.Route.DisplayMember = "Name";
            this.Route.HeaderText = "Route";
            this.Route.Name = "Route";
            this.Route.ValueMember = "RouteID";
            // 
            // routesBindingSource
            // 
            this.routesBindingSource.DataMember = "Routes";
            this.routesBindingSource.DataSource = this.tutorDataSet;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(321, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPost
            // 
            this.btnPost.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPost.Location = new System.Drawing.Point(321, 388);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 12;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtFederalTax
            // 
            this.txtFederalTax.Location = new System.Drawing.Point(404, 53);
            this.txtFederalTax.Name = "txtFederalTax";
            this.txtFederalTax.Size = new System.Drawing.Size(57, 20);
            this.txtFederalTax.TabIndex = 14;
            // 
            // paychecksTableAdapter
            // 
            this.paychecksTableAdapter.ClearBeforeFill = true;
            // 
            // sessionsBindingSource1
            // 
            this.sessionsBindingSource1.DataMember = "Sessions";
            this.sessionsBindingSource1.DataSource = this.tutorDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // routesTableAdapter
            // 
            this.routesTableAdapter.ClearBeforeFill = true;
            // 
            // txtStateTax
            // 
            this.txtStateTax.Location = new System.Drawing.Point(512, 53);
            this.txtStateTax.Name = "txtStateTax";
            this.txtStateTax.Size = new System.Drawing.Size(57, 20);
            this.txtStateTax.TabIndex = 16;
            // 
            // lblNet
            // 
            this.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNet.Location = new System.Drawing.Point(622, 53);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(57, 20);
            this.lblNet.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 54);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(62, 13);
            label6.TabIndex = 18;
            label6.Text = "Period End:";
            // 
            // dtpPeriodEnd
            // 
            this.dtpPeriodEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPeriodEnd.Location = new System.Drawing.Point(85, 53);
            this.dtpPeriodEnd.Name = "dtpPeriodEnd";
            this.dtpPeriodEnd.Size = new System.Drawing.Size(126, 20);
            this.dtpPeriodEnd.TabIndex = 19;
            // 
            // EnterPayCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 418);
            this.Controls.Add(this.dtpPeriodEnd);
            this.Controls.Add(label6);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.txtStateTax);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtFederalTax);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.button1);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label2);
            this.Controls.Add(this.sessionsDataGridView);
            this.Controls.Add(this.txtImport);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBox1);
            this.MinimumSize = new System.Drawing.Size(732, 328);
            this.Name = "EnterPayCheckForm";
            this.Text = "Paycheck Entry";
            this.Load += new System.EventHandler(this.EnterPayCheckForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paychecksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtImport;
        private TutorDataSet tutorDataSet;
        private System.Windows.Forms.BindingSource sessionsBindingSource;
        private TutorDataSetTableAdapters.SessionsTableAdapter sessionsTableAdapter;
        private TutorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sessionsDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.BindingSource tutorDataSetBindingSource;
        private System.Windows.Forms.TextBox txtFederalTax;
        private System.Windows.Forms.BindingSource paychecksBindingSource;
        private TutorDataSetTableAdapters.PaychecksTableAdapter paychecksTableAdapter;
        private System.Windows.Forms.BindingSource sessionsBindingSource1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private TutorDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource routesBindingSource;
        private TutorDataSetTableAdapters.RoutesTableAdapter routesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn Route;
        private System.Windows.Forms.TextBox txtStateTax;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.DateTimePicker dtpPeriodEnd;
    }
}
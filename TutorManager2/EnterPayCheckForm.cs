using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlServerCe;
using TutorManager2.Properties;

namespace TutorManager2
{
    public partial class EnterPayCheckForm : Form
    {
        public EnterPayCheckForm()
        {
            InitializeComponent();
        }

        TutorDataSet.PaychecksRow paycheckRow;
        TutorDataSet.PaychecksRow newPaycheckRow;
        TutorDataSet.RoutesRow newRouteRow;

        private void EnterPayCheckForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tutorDataSet.Routes' table. You can move, or remove it, as needed.
            this.routesTableAdapter.Fill(this.tutorDataSet.Routes);
            // TODO: This line of code loads data into the 'tutorDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.tutorDataSet.Clients);
            // TODO: This line of code loads data into the 'tutorDataSet.Paychecks' table. You can move, or remove it, as needed.
            this.paychecksTableAdapter.Fill(this.tutorDataSet.Paychecks);

            newPaycheckRow = tutorDataSet.Paychecks.AddPaychecksRow(DateTime.Today, 0.0, 0.0, 0.0, 0.0, DateTime.Today);
            paychecksBindingSource.CurrentChanged += new EventHandler(paychecksBindingSource_SelectedValueChanged);
            paychecksBindingSource.MoveLast();
            paycheckRow = newPaycheckRow;


            newRouteRow = tutorDataSet.Routes.AddRoutesRow("<< Create New >>",1, 1, 0.0);
            routesBindingSource.CurrentChanged += new EventHandler(routesBindingSource_CurrentChanged);
        }

        

       
        bool editing = false;
        void routesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var r = ((DataRowView)routesBindingSource.Current).Row as TutorDataSet.RoutesRow;

            if (editing)
                return;

            if (r == null)
                return;

            if (r != newRouteRow)
                return;

            NewRouteForm f = new NewRouteForm(r);
            if (f.ShowDialog() == DialogResult.OK)
            {
                editing = true;

                try
                {
                    routesTableAdapter.Update(tutorDataSet.Routes);
                }
                catch (Exception ex) { }
                tutorDataSet.Routes.AcceptChanges();
                newRouteRow = tutorDataSet.Routes.AddRoutesRow("<< Create New >>", 1,1, 0.0);
                editing = false;
            }
            else
            {
                routesBindingSource.MoveFirst();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tutorDataSet.Sessions.Clear();
                foreach (string s in txtImport.Lines)
                {
                    string[] tokens = s.Split(' ');
                    string date = tokens[0];
                    string name = tokens[1] + " " + tokens[2];
                    string hours = tokens[3];
                    string rate = tokens[5];
                    string total = tokens[7];

                    var row = tutorDataSet.Sessions.NewSessionsRow();
                    row.Date = DateTime.ParseExact(date, "MM/dd/yy", CultureInfo.InvariantCulture);
                    row.Client = findClientId(name);
                    row.Duration = float.Parse(hours);
                    row.PayRate = float.Parse(rate);
                    row.AmountEarned = float.Parse(total);
                    row.Paycheck = paycheckRow.PaycheckID;

                    if (row.Client == -1)
                        throw new Exception();

                    tutorDataSet.Sessions.AddSessionsRow(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not parse pasted text: " + ex.Message, "Enter Paychecks",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tutorDataSet.Sessions.Clear();
            }

            
        }

        private int findClientId(string name)
        {

            foreach (var r in tutorDataSet.Clients)
            {
                if (r.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return r.ClientID;
                }
            }

            return -1;
        }

        /// <summary>
        /// Updates the tax calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double amount = double.Parse(txtAmount.Text);
                double federal = amount * Settings.Default.FederalTaxPercent / 100.0;
                double state = amount * Settings.Default.StateTaxPercent / 100.0;

                txtFederalTax.Text = federal.ToString();
                txtStateTax.Text = state.ToString();
                lblNet.Text = (amount - federal - state).ToString();

            }
            catch (Exception ex) { }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            var r = paycheckRow;

            r.Date = dtpDate.Value.Date; //strip time?
            r.PeriodEnd = dtpPeriodEnd.Value.Date;
            r.Amount = double.Parse(txtAmount.Text);
            r.FederalTax = double.Parse(txtFederalTax.Text);
            r.StateTax = double.Parse(txtStateTax.Text);
            r.Net = r.Amount - r.FederalTax - r.StateTax;

            foreach (var sr in tutorDataSet.Sessions)
                sr.Paycheck = r.PaycheckID;

            bool addingnewrow = (r == newPaycheckRow); //if we are adding a new paycheck row, we must create a new one after

            paychecksTableAdapter.Update(r); //update just the row, not the whole table!

            sessionsTableAdapter.Update(tutorDataSet.Sessions);
            tutorDataSet.Paychecks.AcceptChanges();

            if (addingnewrow)
            {
                newPaycheckRow = tutorDataSet.Paychecks.AddPaychecksRow(DateTime.Today, 0.0, 0.0, 0.0, 0.0, DateTime.Today);
                paychecksBindingSource.MoveLast();
            }
        }

        private void paychecksBindingSource_SelectedValueChanged(object sender, EventArgs e)
        {
            paycheckRow = ((DataRowView)paychecksBindingSource.Current).Row as TutorDataSet.PaychecksRow;

            if (paycheckRow == null)
                return;

            var r = paycheckRow;
            txtAmount.Text     = r.Amount.ToString();
            lblNet.Text        = r.Net.ToString();
            txtFederalTax.Text = r.FederalTax.ToString();
            txtStateTax.Text   = r.StateTax.ToString(); 
            dtpDate.Value      = r.Date;
            dtpPeriodEnd.Value = r.PeriodEnd;

            tutorDataSet.Sessions.Clear();

            if (paycheckRow == newPaycheckRow)
            {
                btnPost.Text = "Add";
            }
            else
            {
                btnPost.Text = "Update";
                //Load sessions

                using (var conn = new SqlCeConnection(Properties.Settings.Default.data35ConnectionString))
                {
                    SqlCeCommand cmd = new SqlCeCommand(string.Format("SELECT * FROM Sessions WHERE Paycheck={0}",
                        paycheckRow.PaycheckID), conn);
                    SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                    da.Fill(tutorDataSet.Sessions);
                }

                sessionsDataGridView.Update();
            }
        }

        private void txtImport_Click(object sender, EventArgs e)
        {
            if (txtImport.Text == "Paste Here")
                txtImport.Clear();
        }
    }
}

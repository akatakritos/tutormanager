using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using TutorManager2.Properties;

namespace TutorManager2
{
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();
        }



        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditClientsForm f = new EditClientsForm();
            f.MdiParent = this;
            f.Show();
        }

        private void routsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRoutesForm f = new EditRoutesForm();
            f.MdiParent = this;
            f.Show();
        }

        private void paychecksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterPayCheckForm f = new EnterPayCheckForm();
            f.MdiParent = this;
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ReportsForm();
            f.MdiParent = this;
            f.Show();
        }

        private void paychecksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DateRangePicker p = new DateRangePicker();
            p.SetYear(DateTime.Now.Year - 1); //last year
            if (p.ShowDialog() == DialogResult.Cancel)
                return;

            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Comma Separated Values (*.csv)|*.csv";
            f.DefaultExt = ".csv";

            if (f.ShowDialog() == DialogResult.OK)
            {
                FileStream fs          = null;
                StreamWriter writer    = null;
                SqlCeDataReader reader = null;
                SqlCeConnection conn   = null;
                SqlCeCommand cmd       = null;

                try
                {
                    fs = new FileStream(f.FileName, FileMode.Create);
                    writer = new StreamWriter(fs);
                    conn = new SqlCeConnection(Properties.Settings.Default.data35ConnectionString);
                    conn.Open();

                    cmd = new SqlCeCommand(
                        "SELECT Date, PeriodEnd, Amount, FederalTax, StateTax, Net FROM Paychecks " + 
                        "WHERE Date >= @StartDate AND Date <= @EndDate " +
                        "ORDER BY Date", conn);
                    cmd.Parameters.Add("@StartDate", p.BeginDate);
                    cmd.Parameters.Add("@EndDate", p.EndDate);

                    reader = cmd.ExecuteReader();
                    writer.WriteLine("Date,Period End,Amount,Federal Tax, State Tax, Net");
                    
                    while (reader.Read())
                    {
                        writer.WriteLine(string.Format("{0},{1},{2},{3},{4},{5}",
                            ((DateTime)reader["Date"]).ToString("MM/dd/yy"),
                            ((DateTime)reader["PeriodEnd"]).ToString("MM/dd/yy"),
                            ((double)reader["Amount"]).ToString("0.00"),
                            ((double)reader["FederalTax"]).ToString("0.00"),
                            ((double)reader["StateTax"]).ToString("0.00"),
                            ((double)reader["Net"]).ToString("0.00")));
                    }

                    cmd.CommandText = "SELECT SUM(Amount) AS TotalAmount, SUM(FederalTax) AS TotalFederal, " +
                        "SUM(StateTax) AS TotalState, SUM(Net) AS TotalNet FROM Paychecks " +
                        "WHERE Date >= @StartDate AND Date <= @EndDate";
                    var results = cmd.ExecuteResultSet(ResultSetOptions.None);
                    if (results.Read())
                    {
                        writer.WriteLine(",Total:,{0},{1},{2},{3}",
                            ((double)results["TotalAmount"]).ToString("0.00"),
                            ((double)results["TotalFederal"]).ToString("0.00"),
                            ((double)results["TotalState"]).ToString("0.00"),
                            ((double)results["TotalNet"]).ToString("0.00"));
                    }
                    


                    MessageBox.Show("Successfully exported paycheck logs.", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Operation failed: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (writer != null)
                        writer.Close();
                    if (reader != null)
                        reader.Close();
                    if (cmd != null)
                        cmd.Dispose();
                    if (conn != null)
                        conn.Close();
                }
            }
        }

        private void drivingLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateRangePicker p = new DateRangePicker();
            p.SetYear(DateTime.Now.Year - 1); //select last year

            if (p.ShowDialog() == DialogResult.Cancel)
                return;

            SaveFileDialog f = new SaveFileDialog();
            f.DefaultExt = ".csv";
            f.Filter = "Comma Separated Values (*.csv)|*.csv";
            if (f.ShowDialog() == DialogResult.OK)
            {
                string filename = f.FileName;

                FileStream fs          = null;
                StreamWriter writer    = null;                
                SqlCeDataReader reader = null;
                SqlCeConnection conn   = null;
                SqlCeCommand cmd       = null;

                try
                {
                    fs = new FileStream(filename, FileMode.Create);
                    writer = new StreamWriter(fs);
                    conn = new SqlCeConnection(Properties.Settings.Default.data35ConnectionString);
                    
                    conn.Open();

                    cmd = new SqlCeCommand(
                        "SELECT s.Date, c.Name, r.Miles FROM Sessions s " +
                        "JOIN Clients c on s.Client=c.ClientId " +
                        "JOIN Routes r ON s.route=r.routeid " +
                        "WHERE s.Date >= @StartDate AND s.Date <= @EndDate " +
                        "ORDER BY s.Date",
                        conn);

                    cmd.Parameters.Add("@StartDate", p.BeginDate);
                    cmd.Parameters.Add("@EndDate", p.EndDate);

                    reader = cmd.ExecuteReader();

                    writer.WriteLine("Date,Name,Miles");
                    while (reader.Read())
                    {
                        writer.WriteLine(string.Format("{0},{1},{2}",
                            ((DateTime)reader["Date"]).ToString("MM/dd/yy"), 
                            reader["Name"], 
                            reader["Miles"]));

                    }

                    cmd.CommandText = "SELECT SUM(r.MILES) FROM Sessions s " +
                        "JOIN Routes r ON s.Route = r.RouteId " +
                        "WHERE s.Date >= @StartDate AND s.Date <= @EndDate";

                    var result = cmd.ExecuteScalar();
                    if (!(result is DBNull))
                    {
                        writer.WriteLine(",Total:,{0}", result);
                    }

                    MessageBox.Show("Driving log exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Operation failed: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    if (writer != null)
                        writer.Close();
                    if (reader != null)
                        reader.Close();
                    if (conn != null)
                        conn.Close();
                    if (cmd != null)
                        cmd.Dispose();
                }               

            }
        }

        private void estimateTaxReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstimatedTaxesReport f = new EstimatedTaxesReport();
            f.MdiParent = this;
            f.Show();
        }

        private void backUpDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string src = Settings.Default.data35ConnectionString.Substring(
                    Settings.Default.data35ConnectionString.IndexOf('=') + 1);
                string dest = Settings.Default.BackupLocation;

                File.Copy(src, dest, true);
                MessageBox.Show("Backed up database to: \n" + Settings.Default.BackupLocation,
                    "Back Up Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error backing up database: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

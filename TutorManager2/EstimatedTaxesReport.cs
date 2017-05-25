using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using TutorManager2.Properties;

namespace TutorManager2
{
    public partial class EstimatedTaxesReport : Form
    {
        DataTable report;
        TaxQuarter[] quarters;
        public EstimatedTaxesReport()
        {
            InitializeComponent();
        }

        private void EstimatedTaxesReport_Load(object sender, EventArgs e)
        {
            try
            {
                int minyear = getMinYear();
                int thisyear = DateTime.Now.Year;

                for (int i = thisyear; i >= minyear; i--)
                {
                    cboYear.Items.Add(i);
                }

                cboYear.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error loading tax years from the database. " + ex.Message);
            }
            
        }

        private int getMinYear()
        {
            using (SqlCeConnection conn = new SqlCeConnection(Settings.Default.data35ConnectionString))
            {

                SqlCeCommand cmd = new SqlCeCommand("SELECT MIN(Date) FROM Paychecks", conn);
                conn.Open();
                DateTime min = (DateTime)cmd.ExecuteScalar();
                return min.Year;
                
            }
        }

        private void initializeTaxQuarters(int year)
        {
           
            quarters = new TaxQuarter[]
            {
                new TaxQuarter(){
                    StartDate=new DateTime(year, 1 , 1),
                    EndDate=new DateTime(year, 3, 31),
                    DueDate= nextWorkDay(new DateTime(year, 4, 15)),
                    Name="Q1"
                },
                new TaxQuarter(){
                    StartDate= new DateTime(year, 4, 1),
                    EndDate=new DateTime(year, 5, 31),
                    DueDate = nextWorkDay(new DateTime(year,6, 15)),
                    Name="Q2"
                },
                new TaxQuarter(){
                    StartDate= new DateTime(year, 6, 1),
                    EndDate = new DateTime(year, 8, 31),
                    DueDate = nextWorkDay(new DateTime(year, 9, 15)),
                    Name="Q3"
                },
                new TaxQuarter(){
                    StartDate=new DateTime(year, 9, 1),
                    EndDate = new DateTime(year, 12, 31),
                    DueDate = nextWorkDay(new DateTime(year+1, 1, 15)),
                    Name="Q4"
                }
            };
        }

        private DateTime nextWorkDay(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday)
                return date.AddDays(2);
            else if (date.DayOfWeek == DayOfWeek.Sunday)
                return date.AddDays(1);
            else
                return date;
        }

        private void loadReport(int year)
        {

            report = new DataTable();
            addColumns();
            addQuarterReports();
            addYtdReport(year);

        }

        private void addQuarterReports()
        {
            foreach (TaxQuarter q in quarters)
            {
                addQuarterReport(q);
            }    
        }

        private void addYtdReport(int year)
        {
            DateTime ytd = DateTime.Today.Year > year ? new DateTime(year, 12, 31) : DateTime.Today;
            DateTime start = new DateTime(year, 1, 1);
            double income, federal, state;
            if (getResults(start, ytd, out income, out federal, out state))
            {
                report.Rows.Add(string.Format("YTD ({0})", ytd.ToShortDateString()),
                    "", income.ToString("C"), federal.ToString("C"), state.ToString("C"));
            }

        }

        private void addQuarterReport(TaxQuarter q)
        {
            double income, federal, state;
            if (getResults(q.StartDate, q.EndDate, out income, out federal, out state))
            {
                report.Rows.Add(q.Name, q.DueDate.ToShortDateString(), 
                    income == 0.0 ? "" : income.ToString("C"),
                    federal == 0.0 ? "" : federal.ToString("C"),
                    state == 0.0 ? "" : state.ToString("C"));
            }
        }

        private bool getResults(DateTime start, DateTime end, out double income, out double federal, out double state)
        {
            income = 0.0;
            federal = 0.0;
            state = 0.0;
            using (SqlCeConnection conn = new SqlCeConnection(Settings.Default.data35ConnectionString))
            {
                try
                {
                    SqlCeCommand cmd = new SqlCeCommand(
                        "SELECT SUM(Amount) AS Income, SUM(FederalTax) AS FederalDue, SUM(StateTax) AS StateDue " +
                        "FROM Paychecks WHERE Date BETWEEN @StartDate AND @EndDate", conn);
                    cmd.Parameters.AddWithValue("@StartDate", start);
                    cmd.Parameters.AddWithValue("@EndDate", end);
                    conn.Open();

                    var reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    if (reader.Read())
                    {
                        income  = reader["Income"] is DBNull ? 0.0 : Convert.ToDouble(reader["Income"]);
                        federal = reader["FederalDue"] is DBNull ? 0.0 : Convert.ToDouble(reader["FederalDue"]);
                        state   = reader["StateDue"] is DBNull ? 0.0 : Convert.ToDouble(reader["StateDue"]);
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    return false;
                }
            }

            return true;
        }

        private void addColumns()
        {
            report.Columns.Add(new DataColumn()
            {
                ColumnName = "Quarter",
                Caption = "Quarter",
                DataType = typeof(string)
            });
            report.Columns.Add(new DataColumn()
            {
                ColumnName = "DateDue",
                Caption = "Due Date",
                DataType = typeof(string)
            });
            report.Columns.Add(new DataColumn()
            {
                ColumnName = "Income",
                Caption = "Income",
                DataType = typeof(string)
            });
            report.Columns.Add(new DataColumn()
            {
                ColumnName = "FederalDue",
                Caption = "Federal Due",
                DataType = typeof(string)
            });
            report.Columns.Add(new DataColumn()
            {
                ColumnName = "StateDue",
                Caption = "State Due",
                DataType = typeof(string)
            });
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = (int)cboYear.SelectedItem;
            try
            {
                initializeTaxQuarters(year);
                loadReport(year);
                dataGridView1.DataSource = report;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load report. " + ex.Message);
            }
        }
    }

    struct TaxQuarter
    {
        public string Name;
        public DateTime StartDate;
        public DateTime EndDate;
        public DateTime DueDate;
    }
}

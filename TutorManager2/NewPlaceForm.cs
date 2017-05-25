using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace TutorManager2
{
    public partial class NewPlaceForm : Form
    {
        public NewPlaceForm(TutorDataSet.PlacesRow placeRow)
        {
            InitializeComponent();
            this.placeRow = placeRow;
        }

        DataTable placeNames;
        TutorDataSet.PlacesRow placeRow;

        private void button1_Click(object sender, EventArgs e)
        {
            bool errors = false;

            if (placeNames == null)
                getPlaceNames();

            if (txtName.Text.Length == 0)
            {
                errorProvider1.SetError(txtName, "You must specify a place name");
                errors = true;
            }
            else
            {
                foreach (DataRow row in placeNames.Rows)
                {
                    if (((string)row["Name"]).Equals(txtName.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        errorProvider1.SetError(txtName, "This place name already exists");
                        errors = true;
                        break;
                    }
                }
            }

            if (txtAddress.Text.Length == 0)
            {
                errors = true;
                errorProvider1.SetError(txtAddress, "You must specify an address");
            }

            if (txtCity.Text.Length == 0)
            {
                errors = true;
                errorProvider1.SetError(txtCity, "You must specify a city.");
            }

            if (txtZipCode.Text.Length == 0)
            {
                errors = true;
                errorProvider1.SetError(txtZipCode, "You must specify a zip code");
            }
            else
            {
                int tmp;
                if (!int.TryParse(txtZipCode.Text, out tmp))
                {
                    errorProvider1.SetError(txtZipCode, "This does not represent a valid zip code.");
                    errors = true;
                }
            }

            

            if (!errors)
            {
                placeRow.Name = txtName.Text;
                placeRow.Address   = txtAddress.Text;
                placeRow.City      = txtCity.Text;
                placeRow.State     = cboState.Text;
                placeRow.Zip       = int.Parse(txtZipCode.Text);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void getPlaceNames()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.data35ConnectionString);
            SqlCeCommand cmd = new SqlCeCommand("SELECT Name from Places", conn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            conn.Open();

            placeNames = new DataTable();
            da.Fill(placeNames);
        }
    }
}

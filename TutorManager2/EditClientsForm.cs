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

namespace TutorManager2
{
    public partial class EditClientsForm : Form
    {
        public EditClientsForm()
        {
            InitializeComponent();
        }

        TutorDataSet.PlacesRow newPlacesRow;

        private void EditClientsForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.data35ConnectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                
            }
        
            // TODO: This line of code loads data into the 'tutorDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.tutorDataSet.Clients);
            

            this.placesTableAdapter1.Fill(this.tutorDataSet.Places);
            newPlacesRow = this.tutorDataSet.Places.AddPlacesRow("<< Create New >>", "", "", "", 0);
            bindingSource1.CurrentChanged += new EventHandler(bindingSource1_CurrentChanged);
        }

        bool editing = false;
        void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (editing)
                return;
            
            if (((System.Data.DataRowView)bindingSource1.Current).Row == newPlacesRow)
            {
                NewPlaceForm f = new NewPlaceForm(newPlacesRow);
                if (f.ShowDialog () == DialogResult.OK)
                {
                    editing = true;
                   
                    try
                    {
                        placesTableAdapter1.Update(tutorDataSet.Places);
                    }
                    catch (Exception ex) { }
                    tutorDataSet.Places.AcceptChanges();
                    newPlacesRow = tutorDataSet.Places.AddPlacesRow("<< Create New >>", "", "", "", 0);
                    editing = false;
                }
                else
                {
                    bindingSource1.MoveFirst();
                }
            }
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tutorDataSet);

        }

        private void clientsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tutorDataSet);

        } 

    }
}

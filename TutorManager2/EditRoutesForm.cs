using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Xml;

namespace TutorManager2
{
    public partial class EditRoutesForm : Form
    {
        public EditRoutesForm()
        {
            InitializeComponent();
        }

        private void routesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.routesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tutorDataSet);

        }

        private void EditRoutesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tutorDataSet.Routes' table. You can move, or remove it, as needed.
            this.routesTableAdapter.Fill(this.tutorDataSet.Routes);
            this.placesTableAdapter1.Fill(this.tutorDataSet.Places);

            //this.bindingSource1.CurrentChanged += new EventHandler(bindingSource1_CurrentChanged);
        }

        void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (routesDataGridView.CurrentRow == null)
                return;

            var r = ((DataRowView)routesDataGridView.CurrentRow.DataBoundItem).Row as TutorDataSet.RoutesRow;
            if (r.RowState != DataRowState.Modified && r.RowState != DataRowState.Added && r.RowState != DataRowState.Detached)
                return;

            if (/*!r.IsMilesNull()||*/r.IsFromPlaceNull()||r.IsToPlaceNull())
                return;

            var sb = new StringBuilder("http://maps.googleapis.com/maps/api/distancematrix/xml?");
            sb.Append("sensor=false&units=imperial&");
            TutorDataSet.PlacesRow place = tutorDataSet.Places.FindByPlaceID(r.FromPlace);
            
            sb.AppendFormat("origins={0}+{1}+{2}&",
                place.Address.Replace(' ', '+'),
                place.City.Replace(' ', '+'),
                place.State,
                place.Zip);
            place = tutorDataSet.Places.FindByPlaceID(r.ToPlace);
            sb.AppendFormat("destinations={0}+{1}+{2}",
                place.Address.Replace(' ', '+'),
                place.City.Replace(' ', '+'),
                place.State,
                place.Zip);

            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object o)
            {
                using (WebClient cl = new WebClient())
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(cl.DownloadString(sb.ToString()));

                    var statusnodes = xml.GetElementsByTagName("status");
                    if (statusnodes.Count > 0)
                    {
                        if (statusnodes[0].InnerText == "OK")
                        {
                            var distancenodes = xml.GetElementsByTagName("distance");
                            string miles = distancenodes[0].LastChild.InnerText.Split(' ')[0];
                            r.Miles = Math.Round(double.Parse(miles), 1);
                            this.Invoke(new MethodInvoker(delegate() { routesDataGridView.Refresh(); }));
                        }
                    }
                }
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.routesTableAdapter.Update(tutorDataSet.Routes);
            tutorDataSet.Routes.AcceptChanges();
            this.Close();
        }

        private void routesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
                bindingSource1_CurrentChanged(null, null);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Xml;

namespace TutorManager2
{
    public partial class NewRouteForm : Form
    {
        TutorDataSet.RoutesRow route;
        public NewRouteForm(TutorDataSet.RoutesRow route)
        {
            InitializeComponent();
            this.route = route;
            txtName.Text = route.Name;
            txtMiles.Text = route.Miles.ToString();
        }

        private void NewRouteForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tutorDataSet.Routes' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'tutorDataSet.Routes' table. You can move, or remove it, as needed.
            this.placesTableAdapter.Fill(this.tutorDataSet.Places);

            foreach (var r in tutorDataSet.Places)
            {
                cboFrom.Items.Add(r.Name);
                cboTo.Items.Add(r.Name);
            }
        }

        void placesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var r = route;
            if (r.RowState != DataRowState.Modified && r.RowState != DataRowState.Added && r.RowState != DataRowState.Detached)
                return;

            if (cboTo.SelectedItem == null || cboFrom.SelectedItem == null)
                return;

            var sb = new StringBuilder("http://maps.googleapis.com/maps/api/distancematrix/xml?");
            sb.Append("sensor=false&units=imperial&");
            TutorDataSet.PlacesRow place = tutorDataSet.Places.FindByPlaceID(findPlaceId(cboFrom.SelectedItem));

            sb.AppendFormat("origins={0}+{1}+{2}&",
                place.Address.Replace(' ', '+'),
                place.City.Replace(' ', '+'),
                place.State,
                place.Zip);
            place = tutorDataSet.Places.FindByPlaceID(findPlaceId(cboTo.SelectedItem));
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

                            this.Invoke(new MethodInvoker(delegate() { txtMiles.Text = miles; }));
                        }
                    }
                }
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            route.Miles = double.Parse(txtMiles.Text);
            route.Name = txtName.Text;
            route.FromPlace = findPlaceId(cboFrom.SelectedItem);
            route.ToPlace = findPlaceId(cboTo.SelectedItem);
            this.DialogResult = DialogResult.OK;
        }

        private int findPlaceId(object p)
        {
            string s = p.ToString();

            foreach (var r in tutorDataSet.Places)
            {
                if (r.Name == s)
                {
                    return r.PlaceID;
                }
            }

            return -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

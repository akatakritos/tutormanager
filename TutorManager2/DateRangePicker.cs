using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TutorManager2
{
    public partial class DateRangePicker : Form
    {
        public DateRangePicker()
        {
            InitializeComponent();
        }

        private void DateRangePicker_Load(object sender, EventArgs e)
        {

        }

        public DateTime BeginDate
        {
            get { return dtpBeginning.Value; }
            set { dtpBeginning.Value = value; }
        }

        public DateTime EndDate
        {
            get { return dtpEnding.Value; }
            set { dtpEnding.Value = value; }
        }

        public void SetYear(int year)
        {
            dtpBeginning.Value = new DateTime(year, 1, 1);
            dtpEnding.Value = new DateTime(year, 12, 31);
        }
    }
}

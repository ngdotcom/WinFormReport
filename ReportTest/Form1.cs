using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkLibrary;

namespace ReportTest
{
    public partial class LiquorForm : Form
    {
        public LiquorForm()
        {
            InitializeComponent();
        }

        private void startTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            startTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            startTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void endTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            endTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            endTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void runRepBtn_Click(object sender, EventArgs e)
        {
            SqlProcessor test = new SqlProcessor();
            string d1 = startTimePicker1.Value.ToString();
            string d2 = endTimePicker1.Value.ToString();

            test.CreateShelfReport(d1,d2);
        }
    }
}

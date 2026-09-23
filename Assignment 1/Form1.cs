using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RecreatingHandle variable
            String dayOf_week, dayOf_month,numericof_days,year, full_data;
            
            //InitializationEventAttribute values to variable
            dayOf_week=txtdaysoftheweek.Text;
            dayOf_month=txtnameofthemonth.Text;
            numericof_days=txtnumericthemonth.Text;
            year = txtyear.Text;

            //ProcessCmdKey concatinating
            full_data = dayOf_week + "" + dayOf_month + "", + numericof_days + "" + year;

            //Display output
            lbloutput.Text = full_data;


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtdaysoftheweek.Clear();
            txtnameofthemonth.Clear();
            txtnumericthemonth.Clear();
            txtyear.Clear();
        }

        private void daysoftheweek_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameofthemonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

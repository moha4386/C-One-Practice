using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowInformationBtn_Click(object sender, EventArgs e)
        {
            String LblName, LblstudentId, LblDepartment, LblSemester, Full_Info;

            LblName = TxtName.Text;
            LblstudentId = TxtStudentId.Text;
            LblDepartment = TxtDepartment.Text;
            LblSemester = TxtSemester.Text;
         
            Full_Info = LblName + "," + LblstudentId + "," + LblDepartment + "," + LblSemester;

            LplOutput.Text = Full_Info;

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TxtName.Clear();
            TxtStudentId.Clear();
            TxtDepartment.Clear();
            TxtSemester.Clear();

            LplOutput.Text = " ";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

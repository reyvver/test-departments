using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dep_library;

namespace test_departments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBoxDepCount.Text);
            int M = Convert.ToInt32(textBoxStampCount.Text);

            StartProg(N, M);
        }

        private void StartProg(int N, int M)
        {
            List<Department> deps = programm.GenerateDepartmentsInline(N, M);
            labelDepsData.Text = programm.GetDepartmentsData(deps);
        }
    }
}

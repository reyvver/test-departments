using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using dep_library;

namespace test_departments
{
    public partial class Form1 : Form
    {
        Programm current_prog = new Programm();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (CheckIfNumbers(textBoxDepCount, true) && CheckIfNumbers(textBoxStampCount, true) && CheckIfNumbers(textBoxStart) && CheckIfNumbers(textBoxEnd, true))
            {
                int N = Convert.ToInt32(textBoxDepCount.Text);
                int M = Convert.ToInt32(textBoxStampCount.Text);

                StartProg(N, M);

                buttonVasya.Enabled = true;
            }
            else
                MessageBox.Show("Некорректные данные (числа должны быть >=1)!", "Ошибка входных данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void StartProg(int N, int M)
        {
            if (checkBoxInline.Checked)
                current_prog.GenerateDepartments(N, M);
            else
                current_prog.GenerateDepartments(N, M, false);

            ShowData(listViewDeps);
        }

        private void ShowData(ListView list)
        {
            list.Items.Clear();

            foreach (Department dep in current_prog.deps)
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(dep.DepartmentId));
                lvi.SubItems.Add(dep.NextDepK.ToString());
                lvi.SubItems.Add(dep.StampIdI.ToString());
                lvi.SubItems.Add(dep.StampIdJ.ToString());

                if (dep.Rool)
                {
                    lvi.SubItems.Add(dep.NextDepP.ToString());
                    lvi.SubItems.Add(dep.StampIdS.ToString());
                    lvi.SubItems.Add(dep.StampIdT.ToString());
                    lvi.SubItems.Add(dep.StampIdR.ToString());
                }
                else
                {
                    lvi.SubItems.Add("-");
                    lvi.SubItems.Add("-");
                    lvi.SubItems.Add("-");
                    lvi.SubItems.Add("-");
                }

                list.Items.Add(lvi);
            }
        }

        private void CheckBoxesStates(bool inline, bool fullRandom)
        {
            if (inline)
            {
                checkBoxRandom.Checked = false;
            }

            if (fullRandom)
            {
                checkBoxInline.Checked = false;
            }

        }

        private void checkBoxInline_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxesStates(checkBoxInline.Checked, false);
        }

        private void checkBoxRandom_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxesStates(false, checkBoxRandom.Checked);
        }

        private bool CheckIfNumbers(TextBox txt, bool checkValue = false)
        {
            var result = 0;

            if (int.TryParse(txt.Text, out result))
            {
                if (result <= 1 && checkValue)
                    return false;
                else
                    return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonVasya_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(textBoxStart.Text);
            int Z = Convert.ToInt32(textBoxEnd.Text);

            labelResult.Text = "";

            Thread newThd = new Thread(()=> { Vasya(A, Z); });
            newThd.Start();

        }

        async void Vasya(int A, int Z)
        {
            labelResult.Invoke(new Action(() =>
            {
                labelResult.Text = current_prog.VasyaIsGoing(A, Z);
            }));

        }
    }
}

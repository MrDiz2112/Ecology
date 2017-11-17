using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecology
{
    public partial class NewComponent : Form
    {
        private MainForm _mainForm;

        public NewComponent(MainForm mainForm)
        {
            InitializeComponent();
            this._mainForm = mainForm;
        }

        private void addDefaultComponent_Click(object sender, EventArgs e)
        {
            String newComponentName = defaulComponentName.Text;
            double newComponentPercent = (double)defaulComponentPercent.Value;
            double newComponentW = 1000000;

            bool isHigher = _mainForm.CheckPercentSum(newComponentPercent);

            if (isHigher)
            {
                MessageBox.Show("Сумма состава больше 100%",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                _mainForm.compositionData.Rows.Add(newComponentName, 
                    newComponentPercent, 
                    newComponentW);

                _mainForm.CheckIsCanDelete();
                defaulComponentName.Text = "";
                defaulComponentPercent.Value = 0;
            }
        }

        private void addUnknownComponentButton_Click(object sender, EventArgs e)
        {
            decimal scoreSum = 0;
            int scoreCount = 0;

            foreach (Control c in pointsGroup.Controls)
            {
                if (c.GetType() == typeof(NumericUpDown))
                {
                    if (Decimal.Parse(c.Text) != 0)
                    {
                        scoreSum += Decimal.Parse(c.Text);
                        scoreCount++;
                    }
                }
            }

            String newComponentName = unknownComponentName.Text;
            double newPercent = (double)unknownComponentPercent.Value;
            bool isHigher = _mainForm.CheckPercentSum(newPercent);

            if (isHigher)
            {
                MessageBox.Show("Сумма состава больше 100%",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                double newX = (double)(scoreSum / scoreCount);
                double newZ = 4 * newX / 3 - 0.33333333333333;
                double newLgW = 0;

                if (newZ > 1 && newZ < 2)
                {
                    newLgW = 4 - (4 / newZ);
                }
                if (newZ > 2 && newZ < 4)
                {
                    newLgW = newZ;
                }
                if (newZ > 4 && newZ < 5)
                {
                    newLgW = 2 + (4 / (6 - newZ));
                }

                double newW = Math.Pow(10, newLgW);

                _mainForm.compositionData.Rows.Add(newComponentName,
                    newPercent,
                    newW);

                _mainForm.CheckIsCanDelete();
                unknownComponentName.Text = "";
                unknownComponentPercent.Value = 0;

                foreach (Control c in pointsGroup.Controls)
                {
                    if (c.GetType() == typeof(NumericUpDown))
                    {
                        c.Text = "0";
                    }
                }
            }
        }
    }
}

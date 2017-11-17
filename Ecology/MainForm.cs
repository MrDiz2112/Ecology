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
    public partial class MainForm : Form
    {
        // Список компонентов, входящих в состав отхода
        public static List<Component> componentsData = new List<Component>();

        // Добавление компонента в список
        private static void AddComponent(String name, double W)
        {
            componentsData.Add(new Component(name, W));
        }

        // Заполнить список значениями
        private static void FillData()
        {
            AddComponent("Альдрин", 138);
            AddComponent("Бенз(а)пирен", 59.97);
            AddComponent("Бензол", 316.2);
            AddComponent("Гексахлорбензол", 354);
            AddComponent("2-4 Динитрофенол", 39.8);
            AddComponent("Ди(п)бутилфталат", 215.44);
            AddComponent("Диоксины", 24.6);
            AddComponent("Дихлорпропен", 398);
            AddComponent("Диметилфтатат", 358.59);
            AddComponent("Дихлорфенол", 39.8);
            AddComponent("Дихлордифенилтрихлорэтан", 213.8);
            AddComponent("Кадмий", 26.9);
            AddComponent("Линдан", 463.4);
            AddComponent("Марганец", 537);
            AddComponent("Медь", 358.9);
            AddComponent("Мышьяк", 55);
            AddComponent("Нафталин", 517.9);
            AddComponent("Никель", 128.8);
            AddComponent("N-нитрозодифениламин", 2511.88);
            AddComponent("Пентахлорбифенилы", 59.98);
            AddComponent("Пентахлорфенол", 75.85);
            AddComponent("Ртуть", 10);
            AddComponent("Стронций", 2951);
            AddComponent("Серебро", 311.1);
            AddComponent("Свинец", 33.1);
            AddComponent("Тетрахлорэтан", 735.6);
            AddComponent("Толуол", 1000);
            AddComponent("Трихлорбензол", 598.4);
            AddComponent("Фенол", 215.44);
            AddComponent("Фураны", 359);
            AddComponent("Хлороформ", 215.4);
            AddComponent("Хром", 100);
            AddComponent("Цинк", 463.4);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        // Заполнить combobox с названиями компонентов
        private static void FillComponentNameComboBox(ComboBox componentName)
        {
            foreach (Component item in componentsData)
            {
                componentName.Items.Add(item.name);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillData();
            FillComponentNameComboBox(componentName);
            componentName.SelectedIndex = 0;
        }

        // проверка больше ли сумма процентов 100%
        public bool CheckPercentSum(double newPercent)
        {
            double percentSum = 0;
            foreach (DataGridViewRow compositionDataRow in compositionData.Rows)
            {
                DataGridViewCell cell = compositionDataRow.Cells[1];
                double compositionPercent = double.Parse(cell.Value.ToString());
                percentSum += compositionPercent;
            }

            percentSum += newPercent;
            if (percentSum > 100)
            {
                return true;
            }

            return false;
        }

        // проверить, если ли что удалять из состава
        public void CheckIsCanDelete()
        {
            int componentsCount = compositionData.RowCount;

            deleteComponentButton.Enabled = componentsCount > 0;
        }

        private void componentAddButton_Click(object sender, EventArgs e)
        {
            double new_Percent = (double)componentNamePercent.Value;
            bool isHigher = CheckPercentSum(new_Percent);

            if (isHigher)
            {
                MessageBox.Show("Сумма состава больше 100%",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                double new_W = 0;

                foreach (Component item in componentsData)
                {
                    if (item.name == componentName.Text)
                    {
                        new_W = item.W;
                        break;
                    }
                }

                compositionData.Rows.Add(componentName.Text, 
                    componentNamePercent.Value, new_W);

                CheckIsCanDelete();
            }
        }

        // вызвать форму для нового компонента
        private void newComponent_Click(object sender, EventArgs e)
        {
            NewComponent newComponentForm = new NewComponent(this);
            newComponentForm.Show();
        }

        // удалить выбранный компонент
        private void deleteComponentButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in compositionData.SelectedRows)
            {
                compositionData.Rows.RemoveAt(item.Index);
            }

            CheckIsCanDelete();
        }

        // рассчитать
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double sumK = 0;
            double mass = (double)massNumeric.Value;

            int hazardClass = 0;

            foreach (DataGridViewRow item in compositionData.Rows)
            {
                double itemPercent = Double.Parse(item.Cells[1].Value.ToString());
                double itemW = (double)item.Cells[2].Value;

                double newC = (itemPercent/10 * 1000000) / mass;
                double newK = newC / itemW;
                sumK += newK;
            }

            if (sumK == 1.0)
            {
                hazardClass = 5;
            }
            if (sumK > 1.0 && sumK <= 100)
            {
                hazardClass = 4;
            }
            if (sumK > 100 && sumK <= 1000)
            {
                hazardClass = 3;
            }
            if (sumK > 1000 && sumK <= 10000)
            {
                hazardClass = 2;
            }
            if (sumK > 10000)
            {
                hazardClass = 1;
            }

            MessageBox.Show("K = " + sumK.ToString() + "\r\nКласс опасности: " + hazardClass.ToString(),
                "Класс опасности",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    public class Component
    {
        public String name;
        public double W;

        public Component(String name, double W)
        {
            this.name = name;
            this.W = W;
        }
    }
}

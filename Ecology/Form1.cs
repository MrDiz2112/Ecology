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

        private void componentAddButton_Click(object sender, EventArgs e)
        {
            double percentSum = 0;
            foreach (DataGridViewRow compositionDataRow in compositionData.Rows)
            {
                DataGridViewCell cell = compositionDataRow.Cells[1];
                double compositionPercent = double.Parse(cell.Value.ToString());
                percentSum += compositionPercent;
            }

            percentSum += (double)componentNamePercent.Value;
            if (percentSum > 100)
            {
                MessageBox.Show("Сумма состава больше 100%",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                compositionData.Rows.Add(componentName.Text, 
                    componentNamePercent.Value);
            }
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

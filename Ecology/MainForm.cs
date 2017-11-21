using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Ecology
{
    public partial class MainForm : Form
    {
        // Список компонентов, входящих в состав отхода
        public static XmlFile xmlFile = new XmlFile();
        public static List<Component> componentsData = new List<Component>();

        // Заполнить список значениями
        private static void FillData()
        {
            xmlFile.AddComponent("Альдрин", 138);
            xmlFile.AddComponent("Бенз(а)пирен", 59.97);
            xmlFile.AddComponent("Бензол", 316.2);
            xmlFile.AddComponent("Гексахлорбензол", 354);
            xmlFile.AddComponent("2-4 Динитрофенол", 39.8);
            xmlFile.AddComponent("Ди(п)бутилфталат", 215.44);
            xmlFile.AddComponent("Диоксины", 24.6);
            xmlFile.AddComponent("Дихлорпропен", 398);
            xmlFile.AddComponent("Диметилфтатат", 358.59);
            xmlFile.AddComponent("Дихлорфенол", 39.8);
            xmlFile.AddComponent("Дихлордифенилтрихлорэтан", 213.8);
            xmlFile.AddComponent("Кадмий", 26.9);
            xmlFile.AddComponent("Линдан", 463.4);
            xmlFile.AddComponent("Марганец", 537);
            xmlFile.AddComponent("Медь", 358.9);
            xmlFile.AddComponent("Мышьяк", 55);
            xmlFile.AddComponent("Нафталин", 517.9);
            xmlFile.AddComponent("Никель", 128.8);
            xmlFile.AddComponent("N-нитрозодифениламин", 2511.88);
            xmlFile.AddComponent("Пентахлорбифенилы", 59.98);
            xmlFile.AddComponent("Пентахлорфенол", 75.85);
            xmlFile.AddComponent("Ртуть", 10);
            xmlFile.AddComponent("Стронций", 2951);
            xmlFile.AddComponent("Серебро", 311.1);
            xmlFile.AddComponent("Свинец", 33.1);
            xmlFile.AddComponent("Тетрахлорэтан", 735.6);
            xmlFile.AddComponent("Толуол", 1000);
            xmlFile.AddComponent("Трихлорбензол", 598.4);
            xmlFile.AddComponent("Фенол", 215.44);
            xmlFile.AddComponent("Фураны", 359);
            xmlFile.AddComponent("Хлороформ", 215.4);
            xmlFile.AddComponent("Хром", 100);
            xmlFile.AddComponent("Цинк", 463.4);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        // Заполнить combobox с названиями компонентов
        public static void FillComponentNameComboBox(ComboBox componentName)
        {
            componentName.Items.Clear();
            componentsData = xmlFile.LoadComponents();

            foreach (Component item in componentsData)
            {
                componentName.Items.Add(item.name);
            }

            componentName.SelectedIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (xmlFile.IsEmpty())
            {
                FillData();
            }
            componentsData = xmlFile.LoadComponents();
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

                componentNamePercent.Value = 0;

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

            string cString = "Концентрации:\r\n";
            string kString = "Показатели степени опасности:\r\n";

            int hazardClass = 0;

            foreach (DataGridViewRow item in compositionData.Rows)
            {
                string itemName = item.Cells[0].Value.ToString();
                double itemPercent = Double.Parse(item.Cells[1].Value.ToString());
                double itemW = (double)item.Cells[2].Value;

                double newC = (mass * (itemPercent/100) * 1000000) / mass;
                double newK = newC / itemW;

                cString += itemName + ": " + newC.ToString() + "\r\n";
                kString += itemName + ": " + newK.ToString() + "\r\n";

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

            cString += "\r\n";

            MessageBox.Show(cString + kString,
                "Результаты вычислений",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);

            MessageBox.Show("K = " + sumK.ToString() + "\r\nКласс опасности: " + hazardClass.ToString(),
                "Класс опасности",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ShowComponentsEditorStripMenuItemClick(object sender, EventArgs e)
        {
            ComponentsEditor editor = new ComponentsEditor(this);
            editor.Show();
        }

        private void ExitStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
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

    public class XmlFile
    {
        private XDocument xdoc = new XDocument();

        public XmlFile(string path = "components.xml")
        {
            LoadDoc(path);
        }

        public void LoadDoc(string path = "components.xml")
        {
            try
            {
                xdoc = XDocument.Load(path);
            }
            catch (FileNotFoundException)
            {
                CreateNewFile();
                LoadDoc(path);
            }
        }

        public void SaveDoc(string name = "components")
        {
            try
            {
                xdoc.Save(name + ".xml");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source + "\r\n" + e.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void CreateNewFile(string name = "components")
        {
            XDocument xdoc = new XDocument();
            CreateRoot(xdoc);
            xdoc.Save(name + ".xml");
        }

        public void CreateRoot(XDocument xdoc)
        {
            XElement components = new XElement("components");
            xdoc.Add(components);
        }

        public void AddComponent(string name, double W)
        {
            XElement newComponent = new XElement("component");
            XElement newComponentName = new XElement("name", name);
            XElement newComponentW = new XElement("W", W.ToString());

            newComponent.Add(newComponentName);
            newComponent.Add(newComponentW);

            try
            {
                XElement root = xdoc.Root;
                root.Add(newComponent);
                SaveDoc();
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show(e.Source + "\r\n" + e.Message,
                    "Ошибка XML файла.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void EditComponent(Component oldComp, Component newComp)
        {
            foreach (XElement item in xdoc.Root.Elements("component"))
            {
                if (item.Element("name").Value == oldComp.name)
                {
                    item.Element("name").Value = newComp.name;
                    item.Element("W").Value = newComp.W.ToString();
                }
            }

            SaveDoc();
        }

        public void RemoveComponent(string name)
        {
            foreach (XElement component in xdoc.Root.Elements("component").ToList())
            {
                if (component.Element("name").Value == name)
                {
                    component.Remove();
                }

                SaveDoc();
            }
        }

        public List<Component> LoadComponents()
        {
            LoadDoc();
            List<Component> componentsData = new List<Component>();

            try
            {
                foreach (XElement component in xdoc.Root.Elements("component"))
                {
                    XElement componentName = component.Element("name");
                    XElement componentW = component.Element("W");
                    string name = componentName.Value;
                    double W = Double.Parse(componentW.Value);

                    Component newComponent = new Component(name, W);

                    componentsData.Add(newComponent);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Source + "\r\n" + e.Message,
                    "Ошибка XML файла.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return componentsData;
        }

        public bool IsEmpty()
        {
            return xdoc.Root.IsEmpty;
        }
    }
}

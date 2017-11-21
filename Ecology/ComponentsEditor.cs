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
    public partial class ComponentsEditor : Form
    {
        private MainForm _mainForm;
        private Component oldData;

        public ComponentsEditor(MainForm mainForm)
        {
            InitializeComponent();
            this._mainForm = mainForm;
        }

        private void ComponentsEditor_Load(object sender, EventArgs e)
        {
            XmlFile xmlFile = new XmlFile();
            List<Component> components = xmlFile.LoadComponents();

            FillComponentsData(components);

            CheckCanDelete();
        }

        private void FillComponentsData(List<Component> components)
        {
            foreach (Component item in components)
            {
                componentsData.Rows.Add(item.name, Double.Parse(item.W.ToString()));
            }
        }

        private void CheckCanDelete()
        {
            deleteComponentButton.Enabled = componentsData.Rows.Count != 0;
        }

        private void deleteComponentButton_Click(object sender, EventArgs e)
        {
            XmlFile xmlFile = new XmlFile();

            foreach (DataGridViewRow item in componentsData.SelectedRows)
            {
                string componentName = item.Cells[0].Value.ToString();
                componentsData.Rows.RemoveAt(item.Index);
                xmlFile.RemoveComponent(componentName);
            }

            componentsData.Rows.Clear();
            List<Component> components = xmlFile.LoadComponents();
            FillComponentsData(components);
            MainForm.FillComponentNameComboBox(_mainForm.componentName);
        }

        private void componentsData_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            string oldName = componentsData.Rows[e.RowIndex].Cells[0].Value.ToString();
            double oldW = Double.Parse(componentsData.Rows[e.RowIndex].Cells[1].Value.ToString());
            oldData = new Component(oldName, oldW);
        }

        private void componentsData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newName = componentsData.Rows[e.RowIndex].Cells[0].Value.ToString();
                double newW = Double.Parse(componentsData.Rows[e.RowIndex].Cells[1].Value.ToString());

                Component newComponent = new Component(newName, newW);

                XmlFile xmlFile = new XmlFile();
                xmlFile.EditComponent(oldData, newComponent);
                MainForm.FillComponentNameComboBox(_mainForm.componentName);
            }
            catch (FormatException)
            {
                componentsData.Rows[e.RowIndex].Cells[0].Value = oldData.name;
                componentsData.Rows[e.RowIndex].Cells[1].Value = oldData.W;

                MessageBox.Show("Ячейка имеет неправильный формат",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

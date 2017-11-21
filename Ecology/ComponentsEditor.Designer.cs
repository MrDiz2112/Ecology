namespace Ecology
{
    partial class ComponentsEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentsEditor));
            this.label1 = new System.Windows.Forms.Label();
            this.componentsData = new System.Windows.Forms.DataGridView();
            this.tableComponentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteComponentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.componentsData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список компонентов";
            // 
            // componentsData
            // 
            this.componentsData.AllowUserToAddRows = false;
            this.componentsData.AllowUserToDeleteRows = false;
            this.componentsData.AllowUserToResizeColumns = false;
            this.componentsData.AllowUserToResizeRows = false;
            this.componentsData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.componentsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.componentsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tableComponentName,
            this.compW});
            this.componentsData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.componentsData.Location = new System.Drawing.Point(12, 34);
            this.componentsData.MultiSelect = false;
            this.componentsData.Name = "componentsData";
            this.componentsData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.componentsData.RowHeadersVisible = false;
            this.componentsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.componentsData.Size = new System.Drawing.Size(366, 216);
            this.componentsData.TabIndex = 2;
            this.componentsData.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.componentsData_CellBeginEdit);
            this.componentsData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.componentsData_CellEndEdit);
            // 
            // tableComponentName
            // 
            this.tableComponentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tableComponentName.HeaderText = "Название";
            this.tableComponentName.Name = "tableComponentName";
            // 
            // compW
            // 
            this.compW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.compW.DefaultCellStyle = dataGridViewCellStyle3;
            this.compW.HeaderText = "W";
            this.compW.Name = "compW";
            this.compW.Width = 43;
            // 
            // deleteComponentButton
            // 
            this.deleteComponentButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteComponentButton.Location = new System.Drawing.Point(12, 257);
            this.deleteComponentButton.Name = "deleteComponentButton";
            this.deleteComponentButton.Size = new System.Drawing.Size(363, 23);
            this.deleteComponentButton.TabIndex = 3;
            this.deleteComponentButton.Text = "Удалить компонент";
            this.deleteComponentButton.UseVisualStyleBackColor = true;
            this.deleteComponentButton.Click += new System.EventHandler(this.deleteComponentButton_Click);
            // 
            // ComponentsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 296);
            this.Controls.Add(this.deleteComponentButton);
            this.Controls.Add(this.componentsData);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComponentsEditor";
            this.Text = "Редактор компонентов";
            this.Load += new System.EventHandler(this.ComponentsEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.componentsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView componentsData;
        private System.Windows.Forms.Button deleteComponentButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableComponentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn compW;
    }
}
namespace Ecology
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleLabel = new System.Windows.Forms.Label();
            this.massGroup = new System.Windows.Forms.GroupBox();
            this.massLabel = new System.Windows.Forms.Label();
            this.massNumeric = new System.Windows.Forms.NumericUpDown();
            this.compositionGroup = new System.Windows.Forms.GroupBox();
            this.deleteComponentButton = new System.Windows.Forms.Button();
            this.newComponent = new System.Windows.Forms.Button();
            this.componentAddButton = new System.Windows.Forms.Button();
            this.componentNamePercentLabel = new System.Windows.Forms.Label();
            this.componentNamePercent = new System.Windows.Forms.NumericUpDown();
            this.componentName = new System.Windows.Forms.ComboBox();
            this.componentNameLabel = new System.Windows.Forms.Label();
            this.compositionData = new System.Windows.Forms.DataGridView();
            this.tableComponentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableComponentPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculateButton = new System.Windows.Forms.Button();
            this.massGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.massNumeric)).BeginInit();
            this.compositionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.componentNamePercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionData)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(36, 9);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleLabel.Size = new System.Drawing.Size(213, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Определение класса опасности отходов";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // massGroup
            // 
            this.massGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.massGroup.Controls.Add(this.massLabel);
            this.massGroup.Controls.Add(this.massNumeric);
            this.massGroup.Location = new System.Drawing.Point(12, 30);
            this.massGroup.Name = "massGroup";
            this.massGroup.Size = new System.Drawing.Size(338, 57);
            this.massGroup.TabIndex = 1;
            this.massGroup.TabStop = false;
            this.massGroup.Text = "Масса отхода";
            // 
            // massLabel
            // 
            this.massLabel.AutoSize = true;
            this.massLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.massLabel.Location = new System.Drawing.Point(132, 19);
            this.massLabel.Name = "massLabel";
            this.massLabel.Size = new System.Drawing.Size(20, 17);
            this.massLabel.TabIndex = 1;
            this.massLabel.Text = "кг";
            // 
            // massNumeric
            // 
            this.massNumeric.DecimalPlaces = 2;
            this.massNumeric.Location = new System.Drawing.Point(6, 19);
            this.massNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.massNumeric.Name = "massNumeric";
            this.massNumeric.Size = new System.Drawing.Size(120, 20);
            this.massNumeric.TabIndex = 0;
            this.massNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // compositionGroup
            // 
            this.compositionGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compositionGroup.Controls.Add(this.deleteComponentButton);
            this.compositionGroup.Controls.Add(this.newComponent);
            this.compositionGroup.Controls.Add(this.componentAddButton);
            this.compositionGroup.Controls.Add(this.componentNamePercentLabel);
            this.compositionGroup.Controls.Add(this.componentNamePercent);
            this.compositionGroup.Controls.Add(this.componentName);
            this.compositionGroup.Controls.Add(this.componentNameLabel);
            this.compositionGroup.Controls.Add(this.compositionData);
            this.compositionGroup.Location = new System.Drawing.Point(12, 93);
            this.compositionGroup.Name = "compositionGroup";
            this.compositionGroup.Size = new System.Drawing.Size(338, 277);
            this.compositionGroup.TabIndex = 2;
            this.compositionGroup.TabStop = false;
            this.compositionGroup.Text = "Состав";
            // 
            // deleteComponentButton
            // 
            this.deleteComponentButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteComponentButton.Enabled = false;
            this.deleteComponentButton.Location = new System.Drawing.Point(7, 173);
            this.deleteComponentButton.Name = "deleteComponentButton";
            this.deleteComponentButton.Size = new System.Drawing.Size(325, 23);
            this.deleteComponentButton.TabIndex = 7;
            this.deleteComponentButton.Text = "Удалить выбранный компонент";
            this.deleteComponentButton.UseVisualStyleBackColor = true;
            this.deleteComponentButton.Click += new System.EventHandler(this.deleteComponentButton_Click);
            // 
            // newComponent
            // 
            this.newComponent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newComponent.Location = new System.Drawing.Point(6, 248);
            this.newComponent.Name = "newComponent";
            this.newComponent.Size = new System.Drawing.Size(326, 23);
            this.newComponent.TabIndex = 6;
            this.newComponent.Text = "Добавить отсутствующий компонент";
            this.newComponent.UseVisualStyleBackColor = true;
            this.newComponent.Click += new System.EventHandler(this.newComponent_Click);
            // 
            // componentAddButton
            // 
            this.componentAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.componentAddButton.Location = new System.Drawing.Point(257, 213);
            this.componentAddButton.Name = "componentAddButton";
            this.componentAddButton.Size = new System.Drawing.Size(75, 23);
            this.componentAddButton.TabIndex = 5;
            this.componentAddButton.Text = "Добавить";
            this.componentAddButton.UseVisualStyleBackColor = true;
            this.componentAddButton.Click += new System.EventHandler(this.componentAddButton_Click);
            // 
            // componentNamePercentLabel
            // 
            this.componentNamePercentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.componentNamePercentLabel.AutoSize = true;
            this.componentNamePercentLabel.Location = new System.Drawing.Point(198, 199);
            this.componentNamePercentLabel.Name = "componentNamePercentLabel";
            this.componentNamePercentLabel.Size = new System.Drawing.Size(15, 13);
            this.componentNamePercentLabel.TabIndex = 4;
            this.componentNamePercentLabel.Text = "%";
            // 
            // componentNamePercent
            // 
            this.componentNamePercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.componentNamePercent.Location = new System.Drawing.Point(201, 215);
            this.componentNamePercent.Name = "componentNamePercent";
            this.componentNamePercent.Size = new System.Drawing.Size(50, 20);
            this.componentNamePercent.TabIndex = 3;
            // 
            // componentName
            // 
            this.componentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.componentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.componentName.FormattingEnabled = true;
            this.componentName.Location = new System.Drawing.Point(6, 213);
            this.componentName.Name = "componentName";
            this.componentName.Size = new System.Drawing.Size(188, 21);
            this.componentName.TabIndex = 2;
            // 
            // componentNameLabel
            // 
            this.componentNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.componentNameLabel.AutoSize = true;
            this.componentNameLabel.Location = new System.Drawing.Point(3, 199);
            this.componentNameLabel.Name = "componentNameLabel";
            this.componentNameLabel.Size = new System.Drawing.Size(63, 13);
            this.componentNameLabel.TabIndex = 1;
            this.componentNameLabel.Text = "Компонент";
            // 
            // compositionData
            // 
            this.compositionData.AllowUserToAddRows = false;
            this.compositionData.AllowUserToDeleteRows = false;
            this.compositionData.AllowUserToResizeColumns = false;
            this.compositionData.AllowUserToResizeRows = false;
            this.compositionData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compositionData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compositionData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tableComponentName,
            this.tableComponentPercent,
            this.compW});
            this.compositionData.Location = new System.Drawing.Point(6, 19);
            this.compositionData.MultiSelect = false;
            this.compositionData.Name = "compositionData";
            this.compositionData.ReadOnly = true;
            this.compositionData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.compositionData.RowHeadersVisible = false;
            this.compositionData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.compositionData.Size = new System.Drawing.Size(326, 148);
            this.compositionData.TabIndex = 0;
            // 
            // tableComponentName
            // 
            this.tableComponentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tableComponentName.HeaderText = "Название";
            this.tableComponentName.Name = "tableComponentName";
            this.tableComponentName.ReadOnly = true;
            this.tableComponentName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tableComponentPercent
            // 
            this.tableComponentPercent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = null;
            this.tableComponentPercent.DefaultCellStyle = dataGridViewCellStyle7;
            this.tableComponentPercent.HeaderText = "Процент";
            this.tableComponentPercent.MaxInputLength = 100;
            this.tableComponentPercent.Name = "tableComponentPercent";
            this.tableComponentPercent.ReadOnly = true;
            this.tableComponentPercent.Width = 75;
            // 
            // compW
            // 
            this.compW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.compW.DefaultCellStyle = dataGridViewCellStyle8;
            this.compW.HeaderText = "W";
            this.compW.Name = "compW";
            this.compW.ReadOnly = true;
            this.compW.Width = 43;
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateButton.Location = new System.Drawing.Point(122, 376);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(121, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 406);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.compositionGroup);
            this.Controls.Add(this.massGroup);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Определение класса опасности отходов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.massGroup.ResumeLayout(false);
            this.massGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.massNumeric)).EndInit();
            this.compositionGroup.ResumeLayout(false);
            this.compositionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.componentNamePercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox massGroup;
        private System.Windows.Forms.NumericUpDown massNumeric;
        private System.Windows.Forms.Label massLabel;
        private System.Windows.Forms.GroupBox compositionGroup;
        public System.Windows.Forms.DataGridView compositionData;
        private System.Windows.Forms.Button componentAddButton;
        private System.Windows.Forms.Label componentNamePercentLabel;
        private System.Windows.Forms.NumericUpDown componentNamePercent;
        private System.Windows.Forms.ComboBox componentName;
        private System.Windows.Forms.Label componentNameLabel;
        private System.Windows.Forms.Button newComponent;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button deleteComponentButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableComponentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableComponentPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn compW;
    }
}


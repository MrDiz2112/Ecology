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
            this.titleLabel = new System.Windows.Forms.Label();
            this.massGroup = new System.Windows.Forms.GroupBox();
            this.massLabel = new System.Windows.Forms.Label();
            this.massNumeric = new System.Windows.Forms.NumericUpDown();
            this.compositionGroup = new System.Windows.Forms.GroupBox();
            this.newComponent = new System.Windows.Forms.Button();
            this.componentAddButton = new System.Windows.Forms.Button();
            this.componentNamePercentLabel = new System.Windows.Forms.Label();
            this.componentNamePercent = new System.Windows.Forms.NumericUpDown();
            this.componentName = new System.Windows.Forms.ComboBox();
            this.componentNameLabel = new System.Windows.Forms.Label();
            this.compositionData = new System.Windows.Forms.DataGridView();
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
            this.massGroup.Size = new System.Drawing.Size(292, 57);
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
            this.massNumeric.Location = new System.Drawing.Point(6, 19);
            this.massNumeric.Name = "massNumeric";
            this.massNumeric.Size = new System.Drawing.Size(120, 20);
            this.massNumeric.TabIndex = 0;
            // 
            // compositionGroup
            // 
            this.compositionGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compositionGroup.Controls.Add(this.newComponent);
            this.compositionGroup.Controls.Add(this.componentAddButton);
            this.compositionGroup.Controls.Add(this.componentNamePercentLabel);
            this.compositionGroup.Controls.Add(this.componentNamePercent);
            this.compositionGroup.Controls.Add(this.componentName);
            this.compositionGroup.Controls.Add(this.componentNameLabel);
            this.compositionGroup.Controls.Add(this.compositionData);
            this.compositionGroup.Location = new System.Drawing.Point(12, 93);
            this.compositionGroup.Name = "compositionGroup";
            this.compositionGroup.Size = new System.Drawing.Size(292, 234);
            this.compositionGroup.TabIndex = 2;
            this.compositionGroup.TabStop = false;
            this.compositionGroup.Text = "Состав";
            // 
            // newComponent
            // 
            this.newComponent.Location = new System.Drawing.Point(6, 205);
            this.newComponent.Name = "newComponent";
            this.newComponent.Size = new System.Drawing.Size(280, 23);
            this.newComponent.TabIndex = 6;
            this.newComponent.Text = "Добавить отсутствующий компонент";
            this.newComponent.UseVisualStyleBackColor = true;
            // 
            // componentAddButton
            // 
            this.componentAddButton.Location = new System.Drawing.Point(211, 170);
            this.componentAddButton.Name = "componentAddButton";
            this.componentAddButton.Size = new System.Drawing.Size(75, 23);
            this.componentAddButton.TabIndex = 5;
            this.componentAddButton.Text = "Добавить";
            this.componentAddButton.UseVisualStyleBackColor = true;
            // 
            // componentNamePercentLabel
            // 
            this.componentNamePercentLabel.AutoSize = true;
            this.componentNamePercentLabel.Location = new System.Drawing.Point(135, 155);
            this.componentNamePercentLabel.Name = "componentNamePercentLabel";
            this.componentNamePercentLabel.Size = new System.Drawing.Size(15, 13);
            this.componentNamePercentLabel.TabIndex = 4;
            this.componentNamePercentLabel.Text = "%";
            // 
            // componentNamePercent
            // 
            this.componentNamePercent.Location = new System.Drawing.Point(135, 172);
            this.componentNamePercent.Name = "componentNamePercent";
            this.componentNamePercent.Size = new System.Drawing.Size(50, 20);
            this.componentNamePercent.TabIndex = 3;
            // 
            // componentName
            // 
            this.componentName.FormattingEnabled = true;
            this.componentName.Location = new System.Drawing.Point(6, 172);
            this.componentName.Name = "componentName";
            this.componentName.Size = new System.Drawing.Size(121, 21);
            this.componentName.TabIndex = 2;
            // 
            // componentNameLabel
            // 
            this.componentNameLabel.AutoSize = true;
            this.componentNameLabel.Location = new System.Drawing.Point(3, 156);
            this.componentNameLabel.Name = "componentNameLabel";
            this.componentNameLabel.Size = new System.Drawing.Size(63, 13);
            this.componentNameLabel.TabIndex = 1;
            this.componentNameLabel.Text = "Компонент";
            // 
            // compositionData
            // 
            this.compositionData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compositionData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compositionData.Location = new System.Drawing.Point(6, 19);
            this.compositionData.Name = "compositionData";
            this.compositionData.Size = new System.Drawing.Size(280, 129);
            this.compositionData.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(122, 333);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 363);
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
        private System.Windows.Forms.DataGridView compositionData;
        private System.Windows.Forms.Button componentAddButton;
        private System.Windows.Forms.Label componentNamePercentLabel;
        private System.Windows.Forms.NumericUpDown componentNamePercent;
        private System.Windows.Forms.ComboBox componentName;
        private System.Windows.Forms.Label componentNameLabel;
        private System.Windows.Forms.Button newComponent;
        private System.Windows.Forms.Button calculateButton;
    }
}


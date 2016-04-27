namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sakilaDataSet = new WindowsFormsApplication2.sakilaDataSet();
            this.datchik1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datchik1TableAdapter = new WindowsFormsApplication2.sakilaDataSetTableAdapters.datchik1TableAdapter();
            this.iddatchik1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlagaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.davlenieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datchik1colDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sakilaDataSet1 = new WindowsFormsApplication2.sakilaDataSet();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakilaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datchik1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakilaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddatchik1DataGridViewTextBoxColumn,
            this.temperaturaDataGridViewTextBoxColumn,
            this.vlagaDataGridViewTextBoxColumn,
            this.davlenieDataGridViewTextBoxColumn,
            this.datchik1colDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.datchik1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // sakilaDataSet
            // 
            this.sakilaDataSet.DataSetName = "sakilaDataSet";
            this.sakilaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datchik1BindingSource
            // 
            this.datchik1BindingSource.DataMember = "datchik1";
            this.datchik1BindingSource.DataSource = this.sakilaDataSet;
            // 
            // datchik1TableAdapter
            // 
            this.datchik1TableAdapter.ClearBeforeFill = true;
            // 
            // iddatchik1DataGridViewTextBoxColumn
            // 
            this.iddatchik1DataGridViewTextBoxColumn.DataPropertyName = "iddatchik1";
            this.iddatchik1DataGridViewTextBoxColumn.HeaderText = "iddatchik1";
            this.iddatchik1DataGridViewTextBoxColumn.Name = "iddatchik1DataGridViewTextBoxColumn";
            // 
            // temperaturaDataGridViewTextBoxColumn
            // 
            this.temperaturaDataGridViewTextBoxColumn.DataPropertyName = "temperatura";
            this.temperaturaDataGridViewTextBoxColumn.HeaderText = "temperatura";
            this.temperaturaDataGridViewTextBoxColumn.Name = "temperaturaDataGridViewTextBoxColumn";
            // 
            // vlagaDataGridViewTextBoxColumn
            // 
            this.vlagaDataGridViewTextBoxColumn.DataPropertyName = "vlaga";
            this.vlagaDataGridViewTextBoxColumn.HeaderText = "vlaga";
            this.vlagaDataGridViewTextBoxColumn.Name = "vlagaDataGridViewTextBoxColumn";
            // 
            // davlenieDataGridViewTextBoxColumn
            // 
            this.davlenieDataGridViewTextBoxColumn.DataPropertyName = "davlenie";
            this.davlenieDataGridViewTextBoxColumn.HeaderText = "davlenie";
            this.davlenieDataGridViewTextBoxColumn.Name = "davlenieDataGridViewTextBoxColumn";
            // 
            // datchik1colDataGridViewTextBoxColumn
            // 
            this.datchik1colDataGridViewTextBoxColumn.DataPropertyName = "datchik1col";
            this.datchik1colDataGridViewTextBoxColumn.HeaderText = "datchik1col";
            this.datchik1colDataGridViewTextBoxColumn.Name = "datchik1colDataGridViewTextBoxColumn";
            // 
            // sakilaDataSet1
            // 
            this.sakilaDataSet1.DataSetName = "sakilaDataSet";
            this.sakilaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(0, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(455, 167);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 23);
            this.btnFill.TabIndex = 2;
            this.btnFill.Text = "Выгрузить\r\n";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.datchik1BindingSource, "iddatchik1", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.chart1.DataSource = this.datchik1BindingSource;
            legend1.Name = "Temperatura";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 225);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Temperatura";
            series1.MarkerBorderColor = System.Drawing.Color.Red;
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series1.Name = "Series1";
            series1.XValueMember = "iddatchik1";
            series1.YValueMembers = "temperatura";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(545, 177);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 403);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakilaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datchik1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakilaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private sakilaDataSet sakilaDataSet;
        private System.Windows.Forms.BindingSource datchik1BindingSource;
        private sakilaDataSetTableAdapters.datchik1TableAdapter datchik1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddatchik1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlagaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn davlenieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datchik1colDataGridViewTextBoxColumn;
        private sakilaDataSet sakilaDataSet1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}


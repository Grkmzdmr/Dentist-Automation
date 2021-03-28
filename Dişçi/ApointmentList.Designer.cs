namespace Dişçi
{
    partial class ApointmentList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApointmentList));
            this.label1 = new System.Windows.Forms.Label();
            this.dentistAutomationDataSet1 = new Dişçi.DentistAutomationDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientOperationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dentistAutomationDataSet4 = new Dişçi.DentistAutomationDataSet4();
            this.patientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dentistAutomationDataSet2 = new Dişçi.DentistAutomationDataSet2();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentistAutomationDataSet11 = new Dişçi.DentistAutomationDataSet1();
            this.patientsTableAdapter = new Dişçi.DentistAutomationDataSet1TableAdapters.PatientsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.patientsTableAdapter1 = new Dişçi.DentistAutomationDataSet2TableAdapters.PatientsTableAdapter();
            this.dentistAutomationDataSet3 = new Dişçi.DentistAutomationDataSet();
            this.patientsTableAdapter2 = new Dişçi.DentistAutomationDataSet4TableAdapters.PatientsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.dentistAutomationDataSet7 = new Dişçi.DentistAutomationDataSet7();
            this.patientsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter3 = new Dişçi.DentistAutomationDataSet7TableAdapters.PatientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dentistAutomationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistAutomationDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistAutomationDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistAutomationDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistAutomationDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistAutomationDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(799, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Randevu Listesi";
            // 
            // dentistAutomationDataSet1
            // 
            this.dentistAutomationDataSet1.DataSetName = "DentistAutomationDataSet";
            this.dentistAutomationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.patientSurnameDataGridViewTextBoxColumn,
            this.patientOperationDataGridViewTextBoxColumn,
            this.operationDateDataGridViewTextBoxColumn,
            this.operationHoursDataGridViewTextBoxColumn,
            this.patientNumber});
            this.dataGridView1.DataSource = this.patientsBindingSource3;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(140, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1644, 484);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "patientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "Sıra";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.patientIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "patientName";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "Hasta İsmi";
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            // 
            // patientSurnameDataGridViewTextBoxColumn
            // 
            this.patientSurnameDataGridViewTextBoxColumn.DataPropertyName = "patientSurname";
            this.patientSurnameDataGridViewTextBoxColumn.HeaderText = "Hasta Soyismi";
            this.patientSurnameDataGridViewTextBoxColumn.Name = "patientSurnameDataGridViewTextBoxColumn";
            // 
            // patientOperationDataGridViewTextBoxColumn
            // 
            this.patientOperationDataGridViewTextBoxColumn.DataPropertyName = "patientOperation";
            this.patientOperationDataGridViewTextBoxColumn.HeaderText = "Tedavi Türü";
            this.patientOperationDataGridViewTextBoxColumn.Name = "patientOperationDataGridViewTextBoxColumn";
            // 
            // operationDateDataGridViewTextBoxColumn
            // 
            this.operationDateDataGridViewTextBoxColumn.DataPropertyName = "OperationDate";
            this.operationDateDataGridViewTextBoxColumn.HeaderText = "Randevu Tarihi";
            this.operationDateDataGridViewTextBoxColumn.Name = "operationDateDataGridViewTextBoxColumn";
            // 
            // operationHoursDataGridViewTextBoxColumn
            // 
            this.operationHoursDataGridViewTextBoxColumn.DataPropertyName = "OperationHours";
            this.operationHoursDataGridViewTextBoxColumn.HeaderText = "Randevu Saati";
            this.operationHoursDataGridViewTextBoxColumn.Name = "operationHoursDataGridViewTextBoxColumn";
            // 
            // patientNumber
            // 
            this.patientNumber.DataPropertyName = "patientNumber";
            this.patientNumber.HeaderText = "Hasta Numarası";
            this.patientNumber.Name = "patientNumber";
            // 
            // patientsBindingSource2
            // 
            this.patientsBindingSource2.DataMember = "Patients";
            this.patientsBindingSource2.DataSource = this.dentistAutomationDataSet4;
            // 
            // dentistAutomationDataSet4
            // 
            this.dentistAutomationDataSet4.DataSetName = "DentistAutomationDataSet4";
            this.dentistAutomationDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource1
            // 
            this.patientsBindingSource1.DataMember = "Patients";
            this.patientsBindingSource1.DataSource = this.dentistAutomationDataSet2;
            // 
            // dentistAutomationDataSet2
            // 
            this.dentistAutomationDataSet2.DataSetName = "DentistAutomationDataSet2";
            this.dentistAutomationDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.dentistAutomationDataSet11;
            // 
            // dentistAutomationDataSet11
            // 
            this.dentistAutomationDataSet11.DataSetName = "DentistAutomationDataSet1";
            this.dentistAutomationDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(621, 695);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "Randevu İptal\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(994, 695);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 68);
            this.button2.TabIndex = 3;
            this.button2.Text = "Yeni Randevu Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 65);
            this.button3.TabIndex = 4;
            this.button3.Text = "Geri\r\n";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // patientsTableAdapter1
            // 
            this.patientsTableAdapter1.ClearBeforeFill = true;
            // 
            // dentistAutomationDataSet3
            // 
            this.dentistAutomationDataSet3.DataSetName = "DentistAutomationDataSet";
            this.dentistAutomationDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsTableAdapter2
            // 
            this.patientsTableAdapter2.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(140, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "*Randevu İptal Etmek İçin Randevu Seçiniz Ve Randevu İptal Butonuna Basınız.";
            // 
            // dentistAutomationDataSet7
            // 
            this.dentistAutomationDataSet7.DataSetName = "DentistAutomationDataSet7";
            this.dentistAutomationDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource3
            // 
            this.patientsBindingSource3.DataMember = "Patients";
            this.patientsBindingSource3.DataSource = this.dentistAutomationDataSet7;
            // 
            // patientsTableAdapter3
            // 
            this.patientsTableAdapter3.ClearBeforeFill = true;
            // 
            // ApointmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApointmentList";
            this.Text = "Randevu Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ApointmentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dentistAutomationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistAutomationDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistAutomationDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistAutomationDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistAutomationDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistAutomationDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DentistAutomationDataSet dentistAutomationDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DentistAutomationDataSet1 dentistAutomationDataSet11;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private DentistAutomationDataSet1TableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private DentistAutomationDataSet2 dentistAutomationDataSet2;
        private System.Windows.Forms.BindingSource patientsBindingSource1;
        private DentistAutomationDataSet2TableAdapters.PatientsTableAdapter patientsTableAdapter1;
        private DentistAutomationDataSet dentistAutomationDataSet3;
        private DentistAutomationDataSet4 dentistAutomationDataSet4;
        private System.Windows.Forms.BindingSource patientsBindingSource2;
        private DentistAutomationDataSet4TableAdapters.PatientsTableAdapter patientsTableAdapter2;
        private System.Windows.Forms.DataGridViewButtonColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientOperationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNumber;
        private System.Windows.Forms.Label label2;
        private DentistAutomationDataSet7 dentistAutomationDataSet7;
        private System.Windows.Forms.BindingSource patientsBindingSource3;
        private DentistAutomationDataSet7TableAdapters.PatientsTableAdapter patientsTableAdapter3;
    }
}
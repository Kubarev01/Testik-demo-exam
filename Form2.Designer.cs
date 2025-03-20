namespace Testik
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.тесатикDataSet = new Testik.тесатикDataSet();
            this.заявкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявкиTableAdapter = new Testik.тесатикDataSetTableAdapters.ЗаявкиTableAdapter();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemDescryptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairPartsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тесатикDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.carIDDataGridViewTextBoxColumn,
            this.problemDescryptionDataGridViewTextBoxColumn,
            this.requestStatusDataGridViewTextBoxColumn,
            this.completionDateDataGridViewTextBoxColumn,
            this.repairPartsDataGridViewTextBoxColumn,
            this.masterIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заявкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(96, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // тесатикDataSet
            // 
            this.тесатикDataSet.DataSetName = "тесатикDataSet";
            this.тесатикDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заявкиBindingSource
            // 
            this.заявкиBindingSource.DataMember = "Заявки";
            this.заявкиBindingSource.DataSource = this.тесатикDataSet;
            // 
            // заявкиTableAdapter
            // 
            this.заявкиTableAdapter.ClearBeforeFill = true;
            // 
            // requestIDDataGridViewTextBoxColumn
            // 
            this.requestIDDataGridViewTextBoxColumn.DataPropertyName = "requestID";
            this.requestIDDataGridViewTextBoxColumn.HeaderText = "requestID";
            this.requestIDDataGridViewTextBoxColumn.Name = "requestIDDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "startDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            this.carIDDataGridViewTextBoxColumn.DataPropertyName = "carID";
            this.carIDDataGridViewTextBoxColumn.HeaderText = "carID";
            this.carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            // 
            // problemDescryptionDataGridViewTextBoxColumn
            // 
            this.problemDescryptionDataGridViewTextBoxColumn.DataPropertyName = "problemDescryption";
            this.problemDescryptionDataGridViewTextBoxColumn.HeaderText = "problemDescryption";
            this.problemDescryptionDataGridViewTextBoxColumn.Name = "problemDescryptionDataGridViewTextBoxColumn";
            // 
            // requestStatusDataGridViewTextBoxColumn
            // 
            this.requestStatusDataGridViewTextBoxColumn.DataPropertyName = "requestStatus";
            this.requestStatusDataGridViewTextBoxColumn.HeaderText = "requestStatus";
            this.requestStatusDataGridViewTextBoxColumn.Name = "requestStatusDataGridViewTextBoxColumn";
            // 
            // completionDateDataGridViewTextBoxColumn
            // 
            this.completionDateDataGridViewTextBoxColumn.DataPropertyName = "completionDate";
            this.completionDateDataGridViewTextBoxColumn.HeaderText = "completionDate";
            this.completionDateDataGridViewTextBoxColumn.Name = "completionDateDataGridViewTextBoxColumn";
            // 
            // repairPartsDataGridViewTextBoxColumn
            // 
            this.repairPartsDataGridViewTextBoxColumn.DataPropertyName = "repairParts";
            this.repairPartsDataGridViewTextBoxColumn.HeaderText = "repairParts";
            this.repairPartsDataGridViewTextBoxColumn.Name = "repairPartsDataGridViewTextBoxColumn";
            // 
            // masterIDDataGridViewTextBoxColumn
            // 
            this.masterIDDataGridViewTextBoxColumn.DataPropertyName = "masterID";
            this.masterIDDataGridViewTextBoxColumn.HeaderText = "masterID";
            this.masterIDDataGridViewTextBoxColumn.Name = "masterIDDataGridViewTextBoxColumn";
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "clientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "clientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тесатикDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private тесатикDataSet тесатикDataSet;
        private System.Windows.Forms.BindingSource заявкиBindingSource;
        private тесатикDataSetTableAdapters.ЗаявкиTableAdapter заявкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemDescryptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn completionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairPartsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}
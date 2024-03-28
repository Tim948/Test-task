namespace Test_task
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
            this.test_zadachaDataSet = new Test_task.Test_zadachaDataSet();
            this.objectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.objectsTableAdapter = new Test_task.Test_zadachaDataSetTableAdapters.ObjectsTableAdapter();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Test_task.Test_zadachaDataSetTableAdapters.TableAdapterManager();
            this.objectsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.test_zadachaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // test_zadachaDataSet
            // 
            this.test_zadachaDataSet.DataSetName = "Test_zadachaDataSet";
            this.test_zadachaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // objectsBindingSource
            // 
            this.objectsBindingSource.DataMember = "Objects";
            this.objectsBindingSource.DataSource = this.test_zadachaDataSet;
            // 
            // objectsTableAdapter
            // 
            this.objectsTableAdapter.ClearBeforeFill = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(250, 249);
            this.treeView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Считать данные с базы данных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttributesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LinksTableAdapter = null;
            this.tableAdapterManager.ObjectsTableAdapter = this.objectsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Test_task.Test_zadachaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // objectsDataGridView
            // 
            this.objectsDataGridView.AllowUserToAddRows = false;
            this.objectsDataGridView.AutoGenerateColumns = false;
            this.objectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.objectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.objectsDataGridView.DataSource = this.objectsBindingSource;
            this.objectsDataGridView.Location = new System.Drawing.Point(302, 12);
            this.objectsDataGridView.Name = "objectsDataGridView";
            this.objectsDataGridView.Size = new System.Drawing.Size(486, 413);
            this.objectsDataGridView.TabIndex = 21;
            this.objectsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.objectsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер по базе данных";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 170;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип(ы) данных";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "product";
            this.dataGridViewTextBoxColumn3.HeaderText = "Продукт";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Редактирование данных";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Обновление данных";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(249, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Выгрузить данные в файл";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.objectsDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Обьекты проекта";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.test_zadachaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Test_zadachaDataSet test_zadachaDataSet;
        private System.Windows.Forms.BindingSource objectsBindingSource;
        private Test_zadachaDataSetTableAdapters.ObjectsTableAdapter objectsTableAdapter;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private Test_zadachaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView objectsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
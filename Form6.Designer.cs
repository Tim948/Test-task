namespace Test_task
{
    partial class Form6
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.test_zadachaDataSet = new Test_task.Test_zadachaDataSet();
            this.attributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attributesTableAdapter = new Test_task.Test_zadachaDataSetTableAdapters.AttributesTableAdapter();
            this.linksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linksTableAdapter = new Test_task.Test_zadachaDataSetTableAdapters.LinksTableAdapter();
            this.parentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_zadachaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(249, 246);
            this.treeView1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parentIdDataGridViewTextBoxColumn,
            this.childIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.linksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(282, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(307, 333);
            this.dataGridView1.TabIndex = 1;
            // 
            // test_zadachaDataSet
            // 
            this.test_zadachaDataSet.DataSetName = "Test_zadachaDataSet";
            this.test_zadachaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attributesBindingSource
            // 
            this.attributesBindingSource.DataMember = "Attributes";
            this.attributesBindingSource.DataSource = this.test_zadachaDataSet;
            // 
            // attributesTableAdapter
            // 
            this.attributesTableAdapter.ClearBeforeFill = true;
            // 
            // linksBindingSource
            // 
            this.linksBindingSource.DataMember = "Links";
            this.linksBindingSource.DataSource = this.test_zadachaDataSet;
            // 
            // linksTableAdapter
            // 
            this.linksTableAdapter.ClearBeforeFill = true;
            // 
            // parentIdDataGridViewTextBoxColumn
            // 
            this.parentIdDataGridViewTextBoxColumn.DataPropertyName = "parentId";
            this.parentIdDataGridViewTextBoxColumn.HeaderText = "Родительский номер по базе";
            this.parentIdDataGridViewTextBoxColumn.Name = "parentIdDataGridViewTextBoxColumn";
            this.parentIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // childIdDataGridViewTextBoxColumn
            // 
            this.childIdDataGridViewTextBoxColumn.DataPropertyName = "childId";
            this.childIdDataGridViewTextBoxColumn.HeaderText = "Дочерний номер по базе";
            this.childIdDataGridViewTextBoxColumn.Name = "childIdDataGridViewTextBoxColumn";
            this.childIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Обновление данных";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Редактирование данных";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Считать данные с базы данных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 351);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(249, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "Выгрузить данные в файл";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 384);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.Text = "Связующие компоненты проекта";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_zadachaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Test_zadachaDataSet test_zadachaDataSet;
        private System.Windows.Forms.BindingSource attributesBindingSource;
        private Test_zadachaDataSetTableAdapters.AttributesTableAdapter attributesTableAdapter;
        private System.Windows.Forms.BindingSource linksBindingSource;
        private Test_zadachaDataSetTableAdapters.LinksTableAdapter linksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}
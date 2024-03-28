namespace Test_task
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            System.Windows.Forms.Label parentIdLabel;
            System.Windows.Forms.Label childIdLabel;
            this.test_zadachaDataSet = new Test_task.Test_zadachaDataSet();
            this.linksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linksTableAdapter = new Test_task.Test_zadachaDataSetTableAdapters.LinksTableAdapter();
            this.tableAdapterManager = new Test_task.Test_zadachaDataSetTableAdapters.TableAdapterManager();
            this.linksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.linksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.parentIdTextBox = new System.Windows.Forms.TextBox();
            this.childIdTextBox = new System.Windows.Forms.TextBox();
            parentIdLabel = new System.Windows.Forms.Label();
            childIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.test_zadachaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksBindingNavigator)).BeginInit();
            this.linksBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // test_zadachaDataSet
            // 
            this.test_zadachaDataSet.DataSetName = "Test_zadachaDataSet";
            this.test_zadachaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttributesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LinksTableAdapter = this.linksTableAdapter;
            this.tableAdapterManager.ObjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Test_task.Test_zadachaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // linksBindingNavigator
            // 
            this.linksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.linksBindingNavigator.BindingSource = this.linksBindingSource;
            this.linksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.linksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.linksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.linksBindingNavigatorSaveItem});
            this.linksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.linksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.linksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.linksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.linksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.linksBindingNavigator.Name = "linksBindingNavigator";
            this.linksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.linksBindingNavigator.Size = new System.Drawing.Size(347, 25);
            this.linksBindingNavigator.TabIndex = 0;
            this.linksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // linksBindingNavigatorSaveItem
            // 
            this.linksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.linksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("linksBindingNavigatorSaveItem.Image")));
            this.linksBindingNavigatorSaveItem.Name = "linksBindingNavigatorSaveItem";
            this.linksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.linksBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.linksBindingNavigatorSaveItem.Click += new System.EventHandler(this.linksBindingNavigatorSaveItem_Click);
            // 
            // parentIdLabel
            // 
            parentIdLabel.AutoSize = true;
            parentIdLabel.Location = new System.Drawing.Point(12, 44);
            parentIdLabel.Name = "parentIdLabel";
            parentIdLabel.Size = new System.Drawing.Size(159, 13);
            parentIdLabel.TabIndex = 1;
            parentIdLabel.Text = "Родительский номер по базе:";
            // 
            // parentIdTextBox
            // 
            this.parentIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.linksBindingSource, "parentId", true));
            this.parentIdTextBox.Location = new System.Drawing.Point(177, 41);
            this.parentIdTextBox.Name = "parentIdTextBox";
            this.parentIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.parentIdTextBox.TabIndex = 2;
            // 
            // childIdLabel
            // 
            childIdLabel.AutoSize = true;
            childIdLabel.Location = new System.Drawing.Point(34, 68);
            childIdLabel.Name = "childIdLabel";
            childIdLabel.Size = new System.Drawing.Size(137, 13);
            childIdLabel.TabIndex = 3;
            childIdLabel.Text = "Дочерний номер по базе:";
            // 
            // childIdTextBox
            // 
            this.childIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.linksBindingSource, "childId", true));
            this.childIdTextBox.Location = new System.Drawing.Point(177, 68);
            this.childIdTextBox.Name = "childIdTextBox";
            this.childIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.childIdTextBox.TabIndex = 4;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 137);
            this.Controls.Add(childIdLabel);
            this.Controls.Add(this.childIdTextBox);
            this.Controls.Add(parentIdLabel);
            this.Controls.Add(this.parentIdTextBox);
            this.Controls.Add(this.linksBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form7";
            this.Text = "Редактирование данных";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.test_zadachaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksBindingNavigator)).EndInit();
            this.linksBindingNavigator.ResumeLayout(false);
            this.linksBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Test_zadachaDataSet test_zadachaDataSet;
        private System.Windows.Forms.BindingSource linksBindingSource;
        private Test_zadachaDataSetTableAdapters.LinksTableAdapter linksTableAdapter;
        private Test_zadachaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator linksBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton linksBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox parentIdTextBox;
        private System.Windows.Forms.TextBox childIdTextBox;
    }
}
namespace Test_task
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label objectIdLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label valueLabel;
            this.test_zadachaDataSet = new Test_task.Test_zadachaDataSet();
            this.attributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attributesTableAdapter = new Test_task.Test_zadachaDataSetTableAdapters.AttributesTableAdapter();
            this.tableAdapterManager = new Test_task.Test_zadachaDataSetTableAdapters.TableAdapterManager();
            this.attributesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.attributesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.objectIdComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.objectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.objectsTableAdapter = new Test_task.Test_zadachaDataSetTableAdapters.ObjectsTableAdapter();
            objectIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.test_zadachaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingNavigator)).BeginInit();
            this.attributesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttributesTableAdapter = this.attributesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LinksTableAdapter = null;
            this.tableAdapterManager.ObjectsTableAdapter = this.objectsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Test_task.Test_zadachaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // attributesBindingNavigator
            // 
            this.attributesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.attributesBindingNavigator.BindingSource = this.attributesBindingSource;
            this.attributesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.attributesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.attributesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.attributesBindingNavigatorSaveItem});
            this.attributesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.attributesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.attributesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.attributesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.attributesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.attributesBindingNavigator.Name = "attributesBindingNavigator";
            this.attributesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.attributesBindingNavigator.Size = new System.Drawing.Size(369, 25);
            this.attributesBindingNavigator.TabIndex = 0;
            this.attributesBindingNavigator.Text = "bindingNavigator1";
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
            // attributesBindingNavigatorSaveItem
            // 
            this.attributesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.attributesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("attributesBindingNavigatorSaveItem.Image")));
            this.attributesBindingNavigatorSaveItem.Name = "attributesBindingNavigatorSaveItem";
            this.attributesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.attributesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.attributesBindingNavigatorSaveItem.Click += new System.EventHandler(this.attributesBindingNavigatorSaveItem_Click);
            // 
            // objectIdLabel
            // 
            objectIdLabel.AutoSize = true;
            objectIdLabel.Location = new System.Drawing.Point(11, 44);
            objectIdLabel.Name = "objectIdLabel";
            objectIdLabel.Size = new System.Drawing.Size(131, 13);
            objectIdLabel.TabIndex = 1;
            objectIdLabel.Text = "Номер объекта по базе:";
            // 
            // objectIdComboBox
            // 
            this.objectIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attributesBindingSource, "objectId", true));
            this.objectIdComboBox.DataSource = this.objectsBindingSource;
            this.objectIdComboBox.DisplayMember = "id";
            this.objectIdComboBox.FormattingEnabled = true;
            this.objectIdComboBox.Location = new System.Drawing.Point(148, 41);
            this.objectIdComboBox.Name = "objectIdComboBox";
            this.objectIdComboBox.Size = new System.Drawing.Size(203, 21);
            this.objectIdComboBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(82, 68);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(60, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Название:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attributesBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(148, 68);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(203, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new System.Drawing.Point(84, 94);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(58, 13);
            valueLabel.TabIndex = 5;
            valueLabel.Text = "Значение:";
            // 
            // valueTextBox
            // 
            this.valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attributesBindingSource, "value", true));
            this.valueTextBox.Location = new System.Drawing.Point(148, 94);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(203, 20);
            this.valueTextBox.TabIndex = 6;
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
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 149);
            this.Controls.Add(valueLabel);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(objectIdLabel);
            this.Controls.Add(this.objectIdComboBox);
            this.Controls.Add(this.attributesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.Text = "Редактирование данных";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.test_zadachaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingNavigator)).EndInit();
            this.attributesBindingNavigator.ResumeLayout(false);
            this.attributesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Test_zadachaDataSet test_zadachaDataSet;
        private System.Windows.Forms.BindingSource attributesBindingSource;
        private Test_zadachaDataSetTableAdapters.AttributesTableAdapter attributesTableAdapter;
        private Test_zadachaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator attributesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton attributesBindingNavigatorSaveItem;
        private Test_zadachaDataSetTableAdapters.ObjectsTableAdapter objectsTableAdapter;
        private System.Windows.Forms.ComboBox objectIdComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.BindingSource objectsBindingSource;
    }
}
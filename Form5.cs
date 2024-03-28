using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_task
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void attributesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.attributesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.test_zadachaDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "test_zadachaDataSet.Objects". При необходимости она может быть перемещена или удалена.
            this.objectsTableAdapter.Fill(this.test_zadachaDataSet.Objects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "test_zadachaDataSet.Attributes". При необходимости она может быть перемещена или удалена.
            this.attributesTableAdapter.Fill(this.test_zadachaDataSet.Attributes);

        }
    }
}

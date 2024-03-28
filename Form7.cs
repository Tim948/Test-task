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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void linksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.linksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.test_zadachaDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "test_zadachaDataSet.Links". При необходимости она может быть перемещена или удалена.
            this.linksTableAdapter.Fill(this.test_zadachaDataSet.Links);

        }
    }
}

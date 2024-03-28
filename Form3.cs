using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Test_task
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void attributesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.attributesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.test_zadachaDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "test_zadachaDataSet.Attributes". При необходимости она может быть перемещена или удалена.
            this.attributesTableAdapter.Fill(this.test_zadachaDataSet.Attributes);

        }

        private void button1_Click(object sender, EventArgs e) // Кнопка для того, чтобы с DataGridView, которая привязана к базе, считать данные на TreeView.
        {
           
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int rowIndex = i + 1;
                TreeNode node = new TreeNode("Объект №" + rowIndex);
                
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    node.Nodes.Add(dataGridView1.Rows[i].Cells[j].Value.ToString());

                }
                treeView1.Nodes.Add(node);
               

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private Form5 attributes; // Кнопка для открытия второстепенной формы приложения.
        private void button2_Click(object sender, EventArgs e)
        {
            
            attributes = new Form5();
            attributes.Visible = true;
        }
        private Form3 attributes2;
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("После внесения изменений необходимо считать новые данные с базы");
            this.Close();
            attributes2 = new Form3();
            attributes2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Здесь укажите строку подключения к вашей базе данных 
            string connectionString = @"server=DESKTOP-OVC86RC\DESKTOP; Initial Catalog = Test_zadacha; Integrated Security = True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT objectId, name, value FROM Attributes", connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    string json = JsonConvert.SerializeObject(dt, Formatting.Indented);
                    File.WriteAllText("C:\\Test_task_Attributes.json", json);
                    MessageBox.Show("Данные успешно сохранены по пути: С:\\Test_task_Attributes.json ");

                }
            }
        }
    }
}

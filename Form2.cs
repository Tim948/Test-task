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
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace Test_task
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "test_zadachaDataSet.Objects". При необходимости она может быть перемещена или удалена.
            this.objectsTableAdapter.Fill(this.test_zadachaDataSet.Objects);

        }

        private void button1_Click(object sender, EventArgs e) // Кнопка для того, чтобы с DataGridView, которая привязана к базе, считать данные на TreeView.
        {
            for (int i = 0; i < objectsDataGridView.Rows.Count; i++)
            {
                int rowIndex = i + 1;
                TreeNode node = new TreeNode("Объект №" + rowIndex);
                for (int j = 0; j < objectsDataGridView.Columns.Count; j++)
                {
                    node.Nodes.Add(objectsDataGridView.Rows[i].Cells[j].Value.ToString());

                }
                treeView1.Nodes.Add(node);
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private Form4 objects; // Кнопка для открытия второстепенной формы приложения.
        private void button2_Click_1(object sender, EventArgs e)
        {
            
            objects = new Form4();
            objects.Visible = true;
        }
        private Form2 objectss;
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("После внесения изменений необходимо считать новые данные с базы");
            this.Close();
            objectss = new Form2();
            objectss.Visible = true;
        }

        private void objectsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Здесь укажите строку подключения к вашей базе данных 
            string connectionString = @"server=DESKTOP-OVC86RC\DESKTOP; Initial Catalog = Test_zadacha; Integrated Security = True;"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT id, type, product FROM Objects", connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    string json = JsonConvert.SerializeObject(dt, Formatting.Indented);
                    File.WriteAllText("C:\\Test_task_Objects.json", json);
                    MessageBox.Show("Данные успешно сохранены по пути: С:\\Test_task_Objects.json ");

                }
            }
        }
    }
}

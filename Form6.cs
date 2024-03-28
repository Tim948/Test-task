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

namespace Test_task
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "test_zadachaDataSet.Links". При необходимости она может быть перемещена или удалена.
            this.linksTableAdapter.Fill(this.test_zadachaDataSet.Links);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "test_zadachaDataSet.Attributes". При необходимости она может быть перемещена или удалена.
            this.attributesTableAdapter.Fill(this.test_zadachaDataSet.Attributes);

        }

        private void button1_Click(object sender, EventArgs e)
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
        private Form7 links; // Кнопка для открытия второстепенной формы приложения.
        private void button2_Click(object sender, EventArgs e)
        {
            
            links = new Form7();
            links.Visible = true;
        }
        private Form6 links2;
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("После внесения изменений необходимо считать новые данные с базы");
            this.Close();
            links2 = new Form6();
            links2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Здесь укажите строку подключения к вашей базе данных 
            string connectionString = @"server=DESKTOP-OVC86RC\DESKTOP; Initial Catalog = Test_zadacha; Integrated Security = True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT parentId, childId FROM Links", connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    string json = JsonConvert.SerializeObject(dt, Formatting.Indented);
                    File.WriteAllText("C:\\Test_task_Links.json", json);
                    MessageBox.Show("Данные успешно сохранены по пути: С:\\Test_task_Links.json ");

                }
            }
        }
    }
}

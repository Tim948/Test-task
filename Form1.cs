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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form2 objects; // Кнопка для открытия второстепенной формы приложения.
        private void button1_Click(object sender, EventArgs e)
        {
            objects = new Form2();
            objects.Visible = true;
        }
        private Form3 Attributes;// Кнопка для открытия второстепенной формы приложения.
        private void button2_Click(object sender, EventArgs e)
        {
            Attributes = new Form3();
            Attributes.Visible = true;
        }
        private Form6 Links; // Кнопка для открытия второстепенной формы приложения.
        private void button3_Click(object sender, EventArgs e)
        {
            Links = new Form6();
            Links.Visible = true;
        }
    }
}

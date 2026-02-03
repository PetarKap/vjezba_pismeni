using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vjezba_pismeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form Form3 = new Form3();
           Form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Form4 = new Form4();
            Form4.Show();
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string zapis = textBox1.Text + "," + comboBox1.Text + "," + dateTimePicker1.Text + "," + numericUpDown1.Value.ToString() + "," 
                + checkBox1.Checked.ToString();
            Admin.SaveBook(zapis);
            MessageBox.Show("Knjiga je uspješno dodana!");
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if 
        }
    }
}

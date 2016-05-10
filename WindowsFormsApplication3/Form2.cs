using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            obj.id = textBox1.Text;
            obj.fname = textBox2.Text;
            obj.lname = textBox3.Text;
            obj.city = textBox4.Text;

            MessageBox.Show(obj.Register3());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using consHuman; 
namespace WFhumans
{
    public partial class Form2add : Form
    {
        Human humanAdd = new Human();

        internal Human HumanAdd
        {
            get { return humanAdd; }
            set { humanAdd = value; }
        }
        public Form2add()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btaddHuman_Click(object sender, EventArgs e)
        {
            humanAdd.Fam = textBox2.Text;
            humanAdd.Name = textBox1.Text;
            humanAdd.BirthDay = dateTimePicker1.Value;
            int age = (DateTime.Now.Year - humanAdd.BirthDay.Year);
            textBox3.Text = age.ToString();
            humanAdd.Age = Convert.ToInt32(textBox3.Text);
        }
    }
}

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
    public partial class Form1 : Form
    {
        Form2add fAdd;
        Humans listH = new Humans(); 
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Form2add fAdd)
        {
            this.fAdd = fAdd;
            InitializeComponent();
        }

        public void addHumInGW()
        {

            GW1.RowCount = 2;
            GW1.ColumnCount = 5;
            string[] row = new string[5];
            foreach (var x in listH.ListHuman) 
            {
                row[0] = x.Name;
                row[1] = x.Fam;
                row[2] = x.Age.ToString();
                row[3] = x.BirthDay.ToShortDateString(); 
                GW1.Rows.Add(row);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2add f = new Form2add();
            f.ShowDialog();
          
               
            Human h = new Human("11111","322222",22,new DateTime(1995,12,12));
            //label1.Text = h.getFullInfo();
            //listBox1.Items.Add(h.getFullInfo());
            //GW1.RowCount = 1;
            listH.addListHuman(f.HumanAdd);

             
         
           
            
           // listH.addListHuman(st1);
           // listH.addListHuman(prof1);
           // listH.safeObjects();
          //  listH2.loadObjects();
            addHumInGW();

        }

        private void GW1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GW1.RowCount = 2;
            GW1.ColumnCount = 5;
            GW1.Rows[0].Cells[0].Value = "Имя";
            GW1.Rows[0].Cells[1].Value = "Фамилия";
            GW1.Rows[0].Cells[2].Value = "Возраст";
            GW1.Rows[0].Cells[3].Value = "Дата рождения";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Humans.safeObjects(listH);
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            listH = (Humans)Humans.loadObjects();
            addHumInGW();
        }


        private void btSearch_Click(object sender, EventArgs e)
        {
            if (cbName.Checked)
            {
                Human h = new Human();
                h = listH.searchHumanName(tbSearch.Text);
                for (int i=0; i<GW1.RowCount; i++)
                {
                    for (int j = 0; j < GW1.ColumnCount; j++)
                    {
                        if (GW1.Rows[i].Cells[j].Value == h.Name)
                        {
                            GW1.Rows[i].Selected = true;
                        }
                    }
                }
                
            }
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            if (cbName.Checked)
            {
                listH.sortHumanName();
                addHumInGW();
            }


        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

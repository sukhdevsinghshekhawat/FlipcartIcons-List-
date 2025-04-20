using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlipcartIcons_List_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Collectionmobile> list = new List<Collectionmobile>();
        
        private void button1_Click(object sender, EventArgs e)
        {
            Collectionmobile mob = new Collectionmobile();
            mob.Brand = textBox1.Text;
            mob.Model = textBox3.Text;
            mob.Ram= textBox4.Text;
            mob.Color= textBox6.Text;
            mob.Price =Convert.ToInt32(textBox7.Text);
            mob.Storage = textBox5.Text;
            list.Add(mob);
            //list.Count();
            MessageBox.Show(list.Count().ToString());
            Textboxclear();
            textBox1.Focus();
            DataList();
        }
        void DataList()
        {
            listBox1.Items.Clear();
              
            foreach (Collectionmobile str in list)
            {
             
               
                //listBox1.Items.Add();
              listBox1.Items.Add(Environment.NewLine+"\nbrand:" + str.Brand+ Environment.NewLine+"\nModel:" + str.Model+ "\nRam:" + str.Ram+ "\nStorage:" + str.Storage+ "\nColor:" + str.Color+ "\nPrice:" + str.Price);
            }
        }
        void Textboxclear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Collectionmobile p= list.Find(s=>s.Brand==textBox1.Text);
            list.Remove(p);
            DataList();
        }
        int i = 0;
        private void button3_Click(object sender, EventArgs e)
        {
           Collectionmobile p=list.FirstOrDefault();
            if (p != null)
            {
                textBox1.Text = p.Brand;
                textBox3.Text = p.Model;
                textBox4.Text = p.Ram;
                textBox5.Text = p.Storage;
                textBox6.Text = p.Color;
                textBox7.Text = p.Price.ToString();
            }
            else
            {
                MessageBox.Show("No data found");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Collectionmobile p=list.LastOrDefault();
            if (p != null)
            {
                textBox1.Text = p.Brand;
                textBox3.Text = p.Model;
                textBox4.Text = p.Ram;
                textBox5.Text = p.Storage;
                textBox6.Text = p.Color;
                textBox7.Text = p.Price.ToString();
            }
            else
            {
                MessageBox.Show("No data found");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Collectionmobile co = list.Find(s => s.Brand.StartsWith(textBox2.Text));
            textBox1.Text = co.Brand;
            textBox3.Text = co.Model;
             textBox4.Text = co.Ram;
            textBox5.Text = co.Storage;
            textBox6.Text = co.Color;
            textBox7.Text = co.Price.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Collectionmobile>lisall =list.FindAll(s=>s.Brand.StartsWith(textBox2.Text));
            listBox1.Items.Clear();
        
            foreach(Collectionmobile str in lisall)
            {
                listBox1.Items.Add("brand:"+str.Brand+"model:"+str.Model+"Ram:"+str.Ram+"storage:"+str.Storage+"price:"+str.Price+"color:"+str.Color);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            list.Clear();
            DataList();

        }

        private void button8_Click(object sender, EventArgs e)
        {
              MessageBox.Show("max price" + list.Max(s=>s.Price).ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("min price" + list.Min(s => s.Price).ToString());

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("total price all model" + list.Sum(s => s.Price).ToString());

        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("avg price" + list.Average(s => s.Price).ToString());

        }
    }
}

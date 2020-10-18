using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCollectionApplication
{
    public partial class Form1 : Form
    {
        private ArrayList calendarList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calendarList = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String calendarValue = textBox1.Text;
            calendarList.Add(calendarValue);

            listBox1.Items.Clear();
            foreach (String item in calendarList)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String calendarValue = listBox1.SelectedItem.ToString();

            calendarList.Remove(calendarValue);

            listBox1.Items.Remove(calendarValue);


        }
    }
}

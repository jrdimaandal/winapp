using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Tony";

            label1.Text= firstCat.SayMiau();

            Cat secondCat = new Cat("Pepy", "red");

            label2.Text = secondCat.SayMiau();

            label3.Text = string.Format("Cat {0} is {1}.", secondCat.Name, secondCat.Color);

            //Console.WriteLine("Cat {0} is {1}.", secondCat.Name, secondCat.Color);

        }
    }
}

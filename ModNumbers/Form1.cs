using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int starter = 1;
            int last = 100;
            double sum = 0;
            double alls = 0;
            double cb = 0;

            for (int i = starter; i <= last; i ++)
            {
                sum += i;
                alls += Math.Pow(i, 2);
            }
            if(Convert.ToInt64(Math.Pow(Math.Pow(sum, 2)-alls, (1.0/3.0))) % 2 == 0)
            {
                
                lblResults.Text = "Even";
                MessageBox.Show("Sum: " + sum + " All Sums: " + alls + " Cubed Number " );
            }
            else
            {
                lblResults.Text = "Odd";
                MessageBox.Show("Sum: " + sum + " All Sums: " + alls + " Cubed Number ");
            }
       
            
        }
    }
}

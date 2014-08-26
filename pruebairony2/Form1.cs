using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaIrony2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                Analizador a = new Analizador();
                Object str = a.parse(textBox1.Text);
                if ( str != null)
                {                    
                    MessageBox.Show(str.ToString());
                }
                else 
                    MessageBox.Show("error");
            }
        }


    }
}

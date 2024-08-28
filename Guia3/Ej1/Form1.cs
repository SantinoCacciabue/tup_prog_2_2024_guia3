using Ej1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Producto p;
        private void button1_Click(object sender, EventArgs e)
        {
            p = new Mesa("Comedor", 10.1, 1, 1);
            textBox1.Text +=p.VerDetalle();
            p = new Silla("Escritorio", 12.2, 2);
            textBox1.Text += p.VerDetalle();

        }
    }
}

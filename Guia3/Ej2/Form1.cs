using Ej1;
using Ej1.models;
using Ej2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bAgregar.Enabled = false;
            bVer.Enabled = false;
        }
        Presupuesto pres;

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if(cliente.ShowDialog() == DialogResult.OK)
            {
                string nombre = cliente.tBnombre.Text;
                string direc = cliente.tBdirec.Text;
                pres = new Presupuesto(nombre, direc);
                labelNombre.Text = nombre;
                labelDirec.Text = direc;
                bAgregar.Enabled = true;
                bVer.Enabled = true;
            }
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            Mueble mueble = new Mueble();
            
            if(mueble.ShowDialog() == DialogResult.OK)
            {
                Producto p = null;
                string desc = mueble.tBdesc.Text;
                int material = mueble.cBmaterial.SelectedIndex;
                double precio = Convert.ToDouble(mueble.tBprecio.Text);
                if (mueble.cBtipo.SelectedIndex == 0)
                {
                    double largo = Convert.ToDouble(mueble.tBlargo.Text);
                    p = new Mesa(desc, precio,material,largo);
                }
                else if(mueble.cBtipo.SelectedIndex == 1)
                {
                    p = new Silla(desc, precio, material);
                }
                pres.AgregarProducto(p);              
            }
        }

        private void bVer_Click(object sender, EventArgs e)
        {
            Ver ver = new Ver();
            for(int i = 0; i < pres.CantidadProductos; i++)
            {
                Producto p = pres.VerProducto(i);
                ver.tBver.Text+=p.VerDetalle();
            }
            ver.tBver.Text += $"{Environment.NewLine}Total:{pres.CostoTotal}";
            ver.ShowDialog();
        }
    }
}

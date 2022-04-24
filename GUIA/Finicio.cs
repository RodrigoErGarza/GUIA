using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIA.Clases
{
    public partial class Finicio : Form
    {
        Carro carrito1;
        public Finicio()
        {
            InitializeComponent();
        }

        private void CrearCarrito()
        {
            string marca = textboxmarca.Text;
            int modelo= Convert.ToInt32(textBoxmodelo);
            string color= textBoxcolor.Text;
            carrito1= new Carro(marca,modelo,color);
        }

        private void Finicio_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrearCarro_Click(object sender, EventArgs e)
        {
            CrearCarrito(); 
        }
    }
}

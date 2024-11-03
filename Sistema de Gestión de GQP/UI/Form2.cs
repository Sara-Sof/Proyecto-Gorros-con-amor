using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestión_de_GQP
{
    public partial class Form2 : Form
    {
        private string rol;
        private string nombre;
        private string direccion;
        private string usuario;
        private string contrasena;
        private string cedula;
        private string celular;
        private Vendedor vendedor;
        private Produccion produccion;
        private Administrador administrador2;

        public Form2()
        {
            InitializeComponent();
            nombre = textBox1.Text;
            cedula = textBox2.Text;
            celular = textBox3.Text;
            direccion = textBox4.Text;
            usuario = textBox5.Text;
            contrasena = textBox6.Text;
            //rol = textBox7.Text;

            administrador2 = new Administrador(rol, usuario, contrasena);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelNuevoUsuario.Visible = true;


        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (rol.Equals("produccion"))
            {
                produccion = new Produccion(1, nombre, cedula, usuario, contrasena, direccion, celular);


            }
           else if (rol.Equals("vendedor"))
            {
                vendedor = new Vendedor(1, nombre, cedula, usuario, contrasena, direccion, celular);
                administrador2.agregarVendedor(vendedor);


            }
            else
            {
                MessageBox.Show("Por favor ingrese un valor correcto (vendedor/produccion)");
            }

        }
    }
}

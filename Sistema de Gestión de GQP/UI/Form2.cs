using MySqlX.XDevAPI.Common;
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

            comboBox1.Items.Add("Vendedor");
            comboBox1.Items.Add("Producción");
            comboBox1.SelectedIndex = 0;

            nombre = textBox1.Text;
            cedula = textBox2.Text;
            celular = textBox3.Text;
            direccion = textBox4.Text;
            usuario = textBox5.Text;
            contrasena = textBox6.Text;

           



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelNuevoUsuario.Visible = true;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            panelNuevoUsuario.Visible = false; 
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            rol = comboBox1.SelectedItem.ToString();
            nombre = textBox1.Text;
            cedula = textBox2.Text;
            celular = textBox3.Text;
            direccion = textBox4.Text;
            usuario = textBox5.Text;
            contrasena = textBox6.Text;

            if (rol.Equals("Producción"))
            {
                produccion = new Produccion(1, nombre, cedula, usuario, contrasena, direccion, celular);

            }
            else if (rol.Equals("Vendedor"))
            {
                vendedor = new Vendedor(1, nombre, cedula, usuario, contrasena, direccion, celular);

                MessageBox.Show("a" + rol + nombre + cedula + usuario + contrasena + direccion + celular);

                int result = Administrador.agregarVendedor(vendedor);



                if (result > 0)
                {
                    MessageBox.Show("siiiiii"+ rol +  nombre + cedula + usuario + contrasena + direccion + celular);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un valor correcto (vendedor/produccion)");
            }
        }
    }
}

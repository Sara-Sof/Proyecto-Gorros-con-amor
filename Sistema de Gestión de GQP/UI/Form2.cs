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
            
            string rolSeleccionado = comboBox1.SelectedItem.ToString();
            int contador = 0;
            
            nombre = textBox1.Text;
            cedula = textBox2.Text;
            celular = textBox3.Text;
            direccion = textBox4.Text;
            usuario = textBox5.Text;
            contrasena = textBox6.Text;

           
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(cedula) ||
                string.IsNullOrWhiteSpace(celular) || string.IsNullOrWhiteSpace(direccion) ||
                string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (rolSeleccionado.Equals("Producción"))
            {
                produccion = new Produccion(3, nombre, cedula, usuario, contrasena, direccion, celular);
                Console.WriteLine(produccion);
                int result = Administrador.agregarProduccion(produccion);
                contador = 1;
               
            }
            else if (rolSeleccionado.Equals("Vendedor"))
            {
                vendedor = new Vendedor(2, nombre, cedula, usuario, contrasena, direccion, celular);
                int result = Administrador.agregarVendedor(vendedor);
                contador = 1;

            }

            //if (contador == 1)
            //{
            //    this.Close();
            //    Form1 form1 = new Form1(administrador2);
            //    form1.Show();

            //}

        }


        private void buttonCerrarS_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(administrador2); 
            form1.Show();
            this.Hide(); 
        }
    }
}

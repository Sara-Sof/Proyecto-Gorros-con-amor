using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_de_Gestión_de_GQP
{
    public partial class Form1 : Form
    {
        private Administrador superUsuario;
        private Form2 form2;
        private string usuario;
        private string contrasena;
        

        public Form1(Administrador admin)
        {
            InitializeComponent();

            this.superUsuario = admin;
            PANEL_BIENVENIDO.Visible = false;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //usuario
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //contraseña
        {

        }

        private void button1_Click(object sender, EventArgs e) //ingresar
        {
             usuario = textBox1.Text;
             contrasena = textBox2.Text;

            // Validar las credenciales
            if (superUsuario.autentificacion(usuario, contrasena) == 1 || superUsuario.autentificacion(usuario, contrasena) == 2 ||
                superUsuario.autentificacion(usuario, contrasena) == 3)
            {
                PANEL_BIENVENIDO.Visible = true;
                labelBienvenida.Text = $"¡Bienvenido, {usuario}!";
            }
            else
            {
                MessageBox.Show("Acceso denegado. Usuario o contraseña incorrectos.");
            }
            

        }

        private void button2_Click(object sender, EventArgs e) //salir
        {
            this.Close(); 
        }
        private void buttonCerrarS_Click(object sender, EventArgs e) // regresar a Form2
        {
            if (form2 == null || form2.IsDisposed)
            {
                form2 = new Form2();
            }
            form2.Show();
            this.Hide(); // Opcional: Ocultar Form1 si deseas
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox2.PasswordChar == '❤') 
            {
                // Muestra el texto real
                textBox2.PasswordChar = '\0';
                button4.Text = "Ocultar";
            }
            else
            {
                // Vuelve a ocultar el texto
                textBox2.PasswordChar = '❤';
                button4.Text = "Mostrar";
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Detiene el hilo al cerrar la aplicación
            superUsuario.DetenerHilo();
        }

        private void boton_Gracias_Click(object sender, EventArgs e)
        {

            PANEL_BIENVENIDO.Visible = false;
            if(superUsuario.autentificacion(usuario, contrasena) == 1)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }else if (superUsuario.autentificacion(usuario, contrasena) == 2)
            {
                Form3 form3 = new Form3();
                this.Hide();

                form3.Show();
            }else
            {
                Form4 form4 = new Form4();
                this.Hide();

                form4.Show();
            }
            
        }
    }
}

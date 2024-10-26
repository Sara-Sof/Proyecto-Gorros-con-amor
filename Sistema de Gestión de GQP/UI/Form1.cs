﻿using System;
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
        private Conexion mConexion;
        public Form1()
        {
            InitializeComponent();

            superUsuario = Administrador.CrearSuperUsuario();
            mConexion = new Conexion();

            // Bitmap img = new Bitmap(Application.StartupPath+@"\img\logo.png");
            //this.BackgroundImage = img;
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
            string usuario = textBox1.Text;
            string contrasena = textBox2.Text;

            // Validar las credenciales
            if (superUsuario.autentificacion(usuario, contrasena))
            {
                MessageBox.Show("Acceso concedido. Bienvenida, Maryu.");

                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Acceso denegado. Usuario o contraseña incorrectos.");
            }
            Conexion objetoconexion = new Conexion();
            objetoconexion.establecer_conexion();
        }

        private void button2_Click(object sender, EventArgs e) //salir
        {
            this.Close(); 
        }
    }
}

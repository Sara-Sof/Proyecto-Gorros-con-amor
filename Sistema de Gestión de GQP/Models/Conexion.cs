using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_de_Gestión_de_GQP
{
    internal class Conexion
    {
        MySqlConnection cnx =  new MySqlConnection();

        static  string servidor="localhost";
        static string bd = "gorros_con_amor";
        static string usuario = "root";
        static string password = "enzomilu";
        static string puerto = "3306";

        private string cadena_conexion = "server = " + servidor + ";"  + "user id = " + usuario + ";" + "password = " +
            password + ";" + "port = " + puerto + ";" + "database = " + bd + ";" ;

        public MySqlConnection establecer_conexion() {
            try
            {
                cnx.ConnectionString = cadena_conexion;
                cnx.Open();
                MessageBox.Show("Conexión establecida!");

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al establecer la conexión. Error: " + e.ToString());
            }
            return cnx;
        }
    }
}

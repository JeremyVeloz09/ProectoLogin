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

namespace Proyecto_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SqlConnection conexion = new SqlConnection(@"server= DESKTOP-H1J1BQ1; database= Empresa1; integrated security=True");
            conexion.Open();


        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        int mov75 = 0;
        int sip = 0;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            {
                if (e.Button != MouseButtons.Left)
                {

                    mov75 = e.X;
                    sip = e.Y;

                }
                else
                {
                    Left = Left + (e.X - mov75);
                    Top = Top + (e.Y - sip);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /////conexion de mi buton de entrar a el base de datos y mi servidor sql////
            ///
            SqlConnection conexion = new SqlConnection(@"server= DESKTOP-H1J1BQ1; database= Empresa1; integrated security=True");
            conexion.Open();
            string query = "select Usuarios, Clave from Usuarios where Usuarios='" + textuser.Text + "'and Clave='" + textpass.Text + "'";
            SqlCommand tmd = new SqlCommand(query, conexion);
            SqlDataReader dr = tmd.ExecuteReader();
            if (dr.Read())
            {
                welcome llamo = new welcome();
                llamo.Show();
                this.Hide();
            }
            else
            ////////////////////Mensaje para la iniciacion de inicio de mis usuarios//////////////////////////
            {
                MessageBox.Show(" Los Datos que ha Puesto Son Errores. Vuelva a insertar su Usuario y Contraseña por favor!! . ");


            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

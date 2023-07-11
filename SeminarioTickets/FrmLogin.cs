using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarioTickets
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {

            InitializeComponent();
        }

 


        //Conexión con Base
        Conexion con = new Conexion();
        SqlConnection sqlCon = new SqlConnection("Data Source=localhost;Initial Catalog=SeminarioTickets;Integrated Security=True");

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                String comand = ("SELECT [EmlUsu],[ConUsu],[IdNvl] FROM [dbo].[Usuarios] WHERE [EmlUsu] ='" + textBox1.Text + "' AND [ConUsu]='" + textBox2.Text + "' ");
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = new SqlCommand(comand, sqlCon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    //this.Hide();
                    if (Convert.ToInt32(dt.Rows[0][2].ToString()) == 1)
                    {
                        //Abrir Menú
                        FrmMenu frmMenu = new FrmMenu();
                        frmMenu.Show();
                        this.Hide();
                        //Mensaje de Bienvenida
                        MessageBox.Show("Bienvenido Administrador");
                        //Limpiar Campos
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox1.Focus();

                    }
                }
                if (Convert.ToInt32(dt.Rows[0][2].ToString()) == 2)
                {
                    //Abrir Menú
                    FrmMenuUsu frmMenu = new FrmMenuUsu();
                    frmMenu.Show();
                    this.Hide();
                    //Mensaje de Bienvenida
                    MessageBox.Show("Bienvenido Usuario");
                    //Limpiar Campos
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();


                }
                else
                {
                    //MessageBox.Show("Usuario o Contraseña Incorrecto");
                }

            }
            catch (Exception ex)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                MessageBox.Show("Usuario o Contraseña Incorrecto");

            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

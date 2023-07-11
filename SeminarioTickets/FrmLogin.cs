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

        private FrmMenu formulario1;
        public FrmLogin()
        {

            InitializeComponent();
        }

        public FrmLogin(FrmMenu formulario1)
        {
            this.formulario1 = formulario1;
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

                    }
                }
                if (Convert.ToInt32(dt.Rows[0][2].ToString()) == 2)
                {
                    //Abrir Menú
                    FrmMenu frmMenu = new FrmMenu();
                    frmMenu.Show();
                    this.Hide();
                    //Mensaje de Bienvenida
                    MessageBox.Show("Bienvenido Usuario");


                }
                else
                {
                    //MessageBox.Show("Usuario o Contraseña Incorrecto");
                }

            }
            catch (Exception ex)
            {

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

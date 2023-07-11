using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarioTickets
{
    public partial class Usuarios : Form
    {

        Conexion conexion = new Conexion();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Colaboradores' Puede moverla o quitarla según sea necesario.
            this.colaboradoresTableAdapter.Fill(this.seminarioTicketsDataSet.Colaboradores);

            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Niveles' Puede moverla o quitarla según sea necesario.
            this.nivelesTableAdapter.Fill(this.seminarioTicketsDataSet.Niveles);

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT EmlUsu AS Email, ConUsu AS Contraseña, CodEnvUsu AS CodigoRecuperacion, IdNvl AS Nivel, CASE WHEN EstUsu = 1 THEN 'Permitido' ELSE 'Denegado' END AS Estado FROM Usuarios", dgvUsuario);
        }


        // Propiedad pública para acceder al botón INSERTAR desde otro formulario
        public System.Windows.Forms.Button Insertar
        {
            get
            {
                return btnGuardar;
            }
        }
        // Propiedad pública para acceder al botón ACTUALIZAR desde otro formulario
        public System.Windows.Forms.Button Actualizar
        {
            get
            {
                return btnActualizar;
            }
        }
        // Propiedad pública para acceder al botón ELIMINAR desde otro formulario
        public System.Windows.Forms.Button Eliminar
        {
            get
            {
                return btnEliminar;
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int estado;
            if (cmbEstado.Text == "Activo")
            {
                estado = 1;
            }
            else
            {
                estado = 0;
            }
            conexion.Modificaciones("exec InsercionUsuarios '" + txtEmail.Text + "','" + txtCon.Text + "','" + cmbEmpleado.SelectedValue + "','" + cmbNivel.SelectedValue + "','" + estado + "' ");

            MessageBox.Show("Datos guardados correctamente", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtEmail.Clear();
            txtCon.Clear();
            txtEmail.Focus();


            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT EmlUsu AS Email, ConUsu AS Contraseña, CodEnvUsu AS CodigoEnviado, IdNvl AS Nivel, CASE WHEN EstUsu = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado FROM Usuarios", dgvUsuario);

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int estado;
            if (cmbEstado.Text == "Activo")
            {
                estado = 1;
            }
            else
            {
                estado = 0;
            }
            conexion.Modificaciones("exec ModificarUsuarios '" + txtEmail.Text + "','" + txtCon.Text + "','" + cmbEmpleado.SelectedValue + "','" + cmbNivel.SelectedValue + "','" + estado + "' ");

            MessageBox.Show("Datos ACTUALIZADOS Correctamente", "Seminario de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtEmail.Clear();
            txtCon.Clear();
            txtEmail.Focus();

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT EmlUsu AS Email, ConUsu AS Contraseña, IdNvl AS Nivel, CASE WHEN EstUsu = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado FROM Usuarios", dgvUsuario);
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que la selección no sea la fila de encabezado
            {
                DataGridViewRow row = dgvUsuario.Rows[e.RowIndex];

                // Obtiene el valor de la celda seleccionada y asígnalo al TextBox
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtCon.Text = row.Cells["Contraseña"].Value.ToString();
                //cmbEmpleado.Text = row.Cells["CodigoEnviado"].Value.ToString();
                cmbNivel.Text = row.Cells["Nivel"].Value.ToString();
                cmbEstado.Text = row.Cells["Estado"].Value.ToString();
           
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec EliminarUsuarios '" + txtEmail.Text + "'");

            MessageBox.Show("Datos Eliminados Correctamente", "Seminario de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtEmail.Clear();
            txtCon.Clear();
            txtEmail.Focus();

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT EmlUsu AS Email, ConUsu AS Contraseña, CodEnvUsu AS CodigoEnviado, IdNvl AS Nivel, CASE WHEN EstUsu = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado FROM Usuarios", dgvUsuario);
        }
    }
    }

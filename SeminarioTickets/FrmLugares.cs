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
    public partial class FrmLugares : Form
    {
        public FrmLugares()
        {
            InitializeComponent();
            dgvLugares.CellClick += dgvLugares_CellClick;
        }

        Conexion conexion = new Conexion();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Modificaciones(" exec InsercionLugares '" + txtId.Text + "','" + txtNombre.Text + "','"  + txtCapacidad.Text + "'  ");
            MessageBox.Show("Datos Guardados Correctamente", "UNICAH", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtNombre.Clear();
            txtCapacidad.Clear();
            txtId.Focus();

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT IdLug AS Id, NomLug As Nombre, CapLug As Capacidad FROM Lugares", dgvLugares);
        }

        private void FrmLugares_Load(object sender, EventArgs e)
        {
            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT IdLug AS Id, NomLug As Nombre, CapLug As Capacidad FROM Lugares", dgvLugares);

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

        private void dgvLugares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que la selección no sea la fila de encabezado
            {
                DataGridViewRow row = dgvLugares.Rows[e.RowIndex];

                // Obtiene el valor de la celda seleccionada y asígnalo al TextBox
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtCapacidad.Text = row.Cells["Capacidad"].Value.ToString();
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec ModificarLugares '"+txtId.Text+"', '"+txtNombre.Text+"', '"+txtCapacidad.Text+"' ");

            MessageBox.Show("Datos ACTUALIZADOS Correctamente", "Seminario de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtId.Clear();
            txtNombre.Clear();
            txtCapacidad.Clear();
            txtId.Focus();

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT IdLug AS Id, NomLug As Nombre, CapLug As Capacidad FROM Lugares", dgvLugares);
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec EliminarLugares '"+txtId.Text+"' ");

            MessageBox.Show("Datos Eliminados Correctamente", "Seminario de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtNombre.Clear();
            txtId.Focus();

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT IdLug AS Id, NomLug As Nombre, CapLug As Capacidad FROM Lugares", dgvLugares);
        }

    }
}

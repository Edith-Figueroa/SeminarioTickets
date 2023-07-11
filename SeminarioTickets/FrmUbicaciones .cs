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
    public partial class FrmUbicaciones : Form
    {
        //Conexión
        Conexion conexion = new Conexion();

        public FrmUbicaciones()
        {
            InitializeComponent();
            dgvUbicaciones.CellClick += dgvUbicaciones_CellClick;
        }

        private void FrmUbicaciones_Load(object sender, EventArgs e)
        {
            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT IdUbc AS Id, ZonaUbc as Zona FROM Ubicaciones", dgvUbicaciones);
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


        //Guardar Datos en Bd
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Modificaciones(" exec InsercionUbicaciones '" + txtId.Text + "','" + txtZona.Text + "'  ");
            MessageBox.Show("Datos Guardados Correctamente", "UNICAH", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtZona.Clear();
            txtId.Focus();

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT IdUbc AS Id, ZonaUbc as Zona FROM Ubicaciones", dgvUbicaciones);
        }

        //Actualizar Datos en Bd
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec ModificarUbicaciones '"+txtId.Text+"', '"+txtZona.Text+"' ");

            MessageBox.Show("Datos ACTUALIZADOS Correctamente", "Seminario de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtZona.Clear();
            txtId.Focus();

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT IdUbc AS Id, ZonaUbc as Zona FROM Ubicaciones", dgvUbicaciones);

        }

        //Eliminar Datos en Bd
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec EliminarUbicaciones '"+txtId.Text+"' ");

            MessageBox.Show("Datos Eliminados Correctamente", "Seminario de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtId.Focus();

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT IdUbc AS Id, ZonaUbc as Zona FROM Ubicaciones", dgvUbicaciones);

        }

        private void dgvUbicaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que la selección no sea la fila de encabezado
            {
                DataGridViewRow row = dgvUbicaciones.Rows[e.RowIndex];

                // Obtiene el valor de la celda seleccionada y asígnalo al TextBox
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtZona.Text = row.Cells["Zona"].Value.ToString();

            }
        }

    }
}

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
    public partial class FrmNiveles : Form
    {
        public FrmNiveles()
        {
            InitializeComponent();
            dgvNiveles.CellClick += dgvNiveles_CellClick;
        }

        //Conexión
        Conexion conexion = new Conexion();

        private void FrmNiveles_Load(object sender, EventArgs e)
        {
            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT IdNvl AS ID, NomNvl as Nivel FROM Niveles", dgvNiveles);
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
            conexion.Modificaciones(" exec InsercionNiveles '" + txtId.Text + "','" + txtNombre.Text + "'  ");
            MessageBox.Show("Datos Guardados Correctamente", "UNICAH", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtNombre.Clear();

            txtId.Focus();

            //Visualización de datos de la base al DataGridView  
            conexion.Grids("SELECT IdNvl AS ID, NomNvl as Nivel FROM Niveles", dgvNiveles);
        }

    
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec ModificarNiveles '" + txtId.Text + "', '" + txtNombre.Text + "' ");

            MessageBox.Show("Datos ACTUALIZADOS Correctamente", "Seminario de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtNombre.Clear();
            txtId.Focus();

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT IdNvl AS ID, NomNvl as Nivel FROM Niveles", dgvNiveles);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec EliminarNiveles '"+txtId.Text+"' ");

            MessageBox.Show("Datos Eliminados Correctamente", "Seminario de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtId.Focus();

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT IdNvl AS ID, NomNvl as Nivel FROM Niveles", dgvNiveles);
        }

        private void dgvNiveles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que la selección no sea la fila de encabezado
            {
                DataGridViewRow row = dgvNiveles.Rows[e.RowIndex];

                // Obtiene el valor de la celda seleccionada y asígnalo al TextBox
                txtId.Text = row.Cells["ID"].Value.ToString();
                txtNombre.Text = row.Cells["Nivel"].Value.ToString();

            }
        }

    }
}

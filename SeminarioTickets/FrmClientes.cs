using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SeminarioTickets
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
            dgvClientes.CellClick += dgvClientes_CellClick;
        }

        //Conexión
        Conexion conexion = new Conexion();


        private void FrmClientes_Load(object sender, EventArgs e)
        {
            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT IdCli AS Identidad, NomCli AS Nombre, TelCli AS Telefono, EmlCli AS Email, DirCli AS Direccion, RtnCli AS RTN, CASE WHEN GnrCli = 1 THEN 'Femenino' ELSE 'Masculino' END AS Genero FROM Clientes", dgvClientes);

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
            int genero;

            if (cmbGenero.Text == "Femenino")
            {
                genero = 1;
            }
            else
            {
                genero = 0;
            }

            conexion.Modificaciones("exec InsercionClientes '" + txtId.Text + "', '" + txtNombre.Text + "', '" + txtTelefono.Text + "', '" + txtCorreo.Text + "', '" + txtDireccion.Text + "', '" + txtRTN.Text + "', '" + genero + "' ");

            txtId.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtRTN.Clear();
            txtId.Focus();

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT IdCli AS Identidad, NomCli AS Nombre, TelCli AS Telefono, EmlCli AS Email, DirCli AS Direccion, RtnCli AS RTN, CASE WHEN GnrCli = 1 THEN 'Femenino' ELSE 'Masculino' END AS Genero FROM Clientes", dgvClientes);

        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int genero;

            if (cmbGenero.Text == "Femenino")
            {
                genero = 1;
            }
            else
            {
                genero = 0;
            }
            conexion.Modificaciones("exec ModificarClientes '" + txtId.Text + "', '" + txtNombre.Text + "', '" + txtTelefono.Text + "', '" + txtCorreo.Text + "', '" + txtDireccion.Text + "', '" + txtRTN.Text + "', '" + genero + "'  ");

            MessageBox.Show("Datos ACTUALIZADOS Correctamente", "Seminario de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtRTN.Clear();
            txtId.Focus();

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT IdCli AS Identidad, NomCli AS Nombre, TelCli AS Telefono, EmlCli AS Email, DirCli AS Direccion, RtnCli AS RTN, CASE WHEN GnrCli = 1 THEN 'Femenino' ELSE 'Masculino' END AS Genero FROM Clientes", dgvClientes);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            conexion.Modificaciones("exec EliminarClientes '" + txtId.Text + "' ");

            MessageBox.Show("Datos Eliminados Correctamente", "Seminario de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtRTN.Clear();
            txtId.Focus();

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT IdCli AS Identidad, NomCli AS Nombre, TelCli AS Telefono, EmlCli AS Email, DirCli AS Direccion, RtnCli AS RTN, CASE WHEN GnrCli = 1 THEN 'Femenino' ELSE 'Masculino' END AS Genero FROM Clientes", dgvClientes);

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0) // Asegúrate de que la selección no sea la fila de encabezado
                {
                    DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                // Obtiene el valor de la celda seleccionada y asígnalo al TextBox
                         txtId.Text = row.Cells["Identidad"].Value.ToString();
                         txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                         txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                         txtCorreo.Text = row.Cells["Email"].Value.ToString();
                         txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                         txtRTN.Text = row.Cells["RTN"].Value.ToString();
                         cmbGenero.Text = row.Cells["Genero"].Value.ToString();
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec BusquedaClientes '" + txtBuscar.Text + "' ");

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT * FROM Clientes WHERE   NomCli", dgvClientes);

        }
    }
}

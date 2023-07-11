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
    public partial class FrmColaboradores : Form
    {
        public FrmColaboradores()
        {
            InitializeComponent();
            dgvColaboradores.CellClick += dgvColaboradores_CellClick;
        }

        private void FrmColaboradores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Puestos' Puede moverla o quitarla según sea necesario.
            this.puestosTableAdapter.Fill(this.seminarioTicketsDataSet.Puestos);

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT IdEmp As Id, NomEmp As Nombre, FchNacEmp As FechaNacimiento, EmlEmp As Email, DirEmp As Dirección, TelEmp As Teléfono,CASE WHEN GnrEmp = 1 THEN 'Femenino' ELSE 'Masculino' END AS Genero , IdPst As Puesto FROM Colaboradores ", dgvColaboradores);
        }
        //Cpnexión
        Conexion conexion = new Conexion();

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
                genero= 0;
            }
            

            conexion.Modificaciones("exec InsercionColaboradores '" + txtId.Text + "','" + txtNombre.Text + "','" + dtpFechaContratacion.Value.ToString("yyyy-MM-dd") + "','" + txtEmail.Text + "', '" + txtDireccion.Text + "', '" + txtTelefono.Text + "', '" + genero + "', '" + cmbPuesto.SelectedValue + "'  ");
            MessageBox.Show("Datos fueron guardados correctamente", "UNICAH", MessageBoxButtons.OK,MessageBoxIcon.Information);

            txtId.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtId.Focus();

            conexion.Grids("SELECT IdEmp As Id, NomEmp As Nombre, FchNacEmp As FechaNacimiento, EmlEmp As Email, DirEmp As Dirección, TelEmp As Teléfono,CASE WHEN GnrEmp= 1 THEN 'Femenino' ELSE 'Masculino' END AS Genero , IdPst As Puesto FROM Colaboradores ", dgvColaboradores);

         }

        private void cmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
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
            conexion.Modificaciones("exec ModificarColaboradores  '" + txtId.Text + "','" + txtNombre.Text + "','" + dtpFechaContratacion.Value.ToString("yyyy-MM-dd") + "','" + txtEmail.Text + "', '" + txtDireccion.Text + "', '" + txtTelefono.Text + "', '" + genero + "', '" + cmbPuesto.SelectedValue + "'  ");

            MessageBox.Show("Datos ACTUALIZADOS Correctamente", "Seminario de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtId.Focus();

            conexion.Grids("SELECT IdEmp As Id, NomEmp As Nombre, FchNacEmp As FechaNacimiento, EmlEmp As Email, DirEmp As Dirección, TelEmp As Teléfono,CASE WHEN GnrEmp= 1 THEN 'Femenino' ELSE 'Masculino' END AS Genero , IdPst As Puesto FROM Colaboradores ", dgvColaboradores);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            conexion.Modificaciones("exec EliminarColaboradores  '" + txtId.Text + "' ");

            MessageBox.Show("Datos Eliminados Correctamente", "Seminario de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtId.Focus();

            conexion.Grids("SELECT IdEmp As Id, NomEmp As Nombre, FchNacEmp As FechaNacimiento, EmlEmp As Email, DirEmp As Dirección, TelEmp As Teléfono,CASE WHEN GnrEmp= 1 THEN 'Femenino' ELSE 'Masculino' END AS Genero , IdPst As Puesto FROM Colaboradores ", dgvColaboradores);

        }

        private void dgvColaboradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que la selección no sea la fila de encabezado
            {
                DataGridViewRow row = dgvColaboradores.Rows[e.RowIndex];

                // Obtiene el valor de la celda seleccionada y asígnalo al TextBox
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                dtpFechaContratacion.Text = row.Cells["FechaNacimiento"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtDireccion.Text = row.Cells["Dirección"].Value.ToString();
                txtTelefono.Text = row.Cells["Teléfono"].Value.ToString();
                cmbGenero.Text = row.Cells["Genero"].Value.ToString();
                cmbPuesto.Text = row.Cells["Puesto"].Value.ToString();
            }
        }
    }
}

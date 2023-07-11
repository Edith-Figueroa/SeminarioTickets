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
    public partial class FrmTickets : Form
    {
        //Conexión
        Conexion conexion = new Conexion();

        public FrmTickets()
        {
            InitializeComponent();
        }

        private void FrmTickets_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Ubicaciones' Puede moverla o quitarla según sea necesario.
            this.ubicacionesTableAdapter.Fill(this.seminarioTicketsDataSet.Ubicaciones);

            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.seminarioTicketsDataSet.Usuarios);

            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.seminarioTicketsDataSet.Clientes);

            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Eventos' Puede moverla o quitarla según sea necesario.
            this.eventosTableAdapter.Fill(this.seminarioTicketsDataSet.Eventos);

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT Idtct AS Identidad, FchTct AS Fecha, IdEvt AS IdEvento, IdCli AS IdCliente, IdUbc AS IdUbicacion, NumUbc AS NumeroUbicacion, PrcTct AS Precio FROM Tickets", dgvTicket);
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
            conexion.Modificaciones("exec InsercionTickets '" + txtId.Text + "','" + dtpFchTct.Value.ToString("yyyy-MM-dd") + "','" + cmbEventos.SelectedValue + "','" + cmbCliente.SelectedValue + "','" + cmbUbicacion.SelectedValue + "','" + txtNumero.Text + "','" + txtPrecio.Text + "' ");

            MessageBox.Show("Datos guardados correctamente", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtNumero.Clear();
            txtPrecio.Clear();
            txtId.Focus();

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT Idtct AS Identidad, FchTct AS Fecha, IdEvt AS IdEvento, IdCli AS IdCliente, IdUbc AS IdUbicacion, NumUbc AS NumeroUbicacion, PrcTct AS Precio FROM Tickets", dgvTicket);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
          
            conexion.Modificaciones("exec ModificarTickets '" + txtId.Text + "','" + dtpFchTct.Value.ToString("yyyy-MM-dd") + "','" + cmbEventos.SelectedValue + "','" + cmbCliente.SelectedValue + "','" + cmbUbicacion.SelectedValue + "','" + txtNumero.Text + "','" + txtPrecio.Text + "' ");

            MessageBox.Show("Datos ACTUALIZADOS Correctamente", "Seminario de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtNumero.Clear();
            txtPrecio.Clear();
            txtId.Focus();

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT Idtct AS Identidad, FchTct AS Fecha, IdEvt AS IdEvento, IdCli AS IdCliente, IdUbc AS IdUbicacion, NumUbc AS NumeroUbicacion, PrcTct AS Precio FROM Tickets", dgvTicket);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec EliminarTickets '" + txtId.Text + "'");

            MessageBox.Show("Datos Eliminados Correctamente", "Seminario de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtNumero.Clear();
            txtPrecio.Clear();
            txtId.Focus();

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT Idtct AS Identidad, FchTct AS Fecha, IdEvt AS IdEvento, IdCli AS IdCliente, IdUbc AS IdUbicacion, NumUbc AS NumeroUbicacion, PrcTct AS Precio FROM Tickets", dgvTicket);
        }

        private void dgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que la selección no sea la fila de encabezado
            {
                DataGridViewRow row = dgvTicket.Rows[e.RowIndex];

                // Obtiene el valor de la celda seleccionada y asígnalo al TextBox
                txtId.Text = row.Cells["Identidad"].Value.ToString();
                dtpFchTct.Text = row.Cells["Fecha"].Value.ToString();
                cmbEventos.Text = row.Cells["IdEvento"].Value.ToString();
                cmbCliente.Text = row.Cells["IdCliente"].Value.ToString();
                cmbUbicacion.Text = row.Cells["IdUbicacion"].Value.ToString();
                txtNumero.Text = row.Cells["NumeroUbicacion"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
            }
        }
    }
}

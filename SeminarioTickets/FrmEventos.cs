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
    public partial class FrmEventos : Form
    {
        public FrmEventos()
        {
            InitializeComponent();
            dgvEventos.CellClick += dgvEventos_CellClick;
        }

        //Cpnexión
        Conexion conexion = new Conexion();

        private void FrmEventos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet11.TipoEventos' Puede moverla o quitarla según sea necesario.
            this.tipoEventosTableAdapter2.Fill(this.seminarioTicketsDataSet11.TipoEventos);

            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet11.Lugares' Puede moverla o quitarla según sea necesario.
            this.lugaresTableAdapter2.Fill(this.seminarioTicketsDataSet11.Lugares);

            //Visualización de datos de la base al DataGridView
            conexion.Grids("SELECT IdEvt As Id, NomEvt As Nombre, IdEvn As TipoEvento, FchEvt As FechaEvento,HrEvt As Hora, IdLug As Lugar, CapEvt As Capacidad, ResEvt As Reserva FROM Eventos ", dgvEventos);
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

            conexion.Modificaciones("exec InsercionEventos '"+txtId.Text+"', '"+txtNombre.Text +"', '"+cmbEvento.SelectedValue+"', '"+dtpFecha.Value.ToString("yyyy-MM-dd")+"', '"+dtpHora.Value.ToString("hh:mm:ss")+"', '"+cmbLugar.SelectedValue+"', '"+txtCapacidad.Text+"', '"+txtReserva.Text+"' ");
            MessageBox.Show("Datos fueron guardados correctamente", "UNICAH", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtNombre.Clear();
            txtCapacidad.Clear();
            txtReserva.Clear();
           
            txtId.Focus();

            conexion.Grids("SELECT IdEvt As Id, NomEvt As Nombre, IdEvn As TipoEvento, FchEvt As FechaEvento,HrEvt As Hora, IdLug As Lugar,  CapEvt As Capacidad, ResEvt As Reserva  FROM Eventos ", dgvEventos);

        }

        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que la selección no sea la fila de encabezado
            {
                DataGridViewRow row = dgvEventos.Rows[e.RowIndex];

                // Obtiene el valor de la celda seleccionada y asígnalo al TextBox
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                cmbEvento.Text = row.Cells["TipoEvento"].Value.ToString();
                dtpFecha.Text = row.Cells["FechaEvento"].Value.ToString();
                dtpHora.Text = row.Cells["Hora"].Value.ToString();
                cmbLugar.Text = row.Cells["Lugar"].Value.ToString();
                txtCapacidad.Text = row.Cells["Capacidad"].Value.ToString();
                txtReserva.Text = row.Cells["Reserva"].Value.ToString();

            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec ModificarEventos  '" + txtId.Text + "','" + txtNombre.Text + "','" + cmbEvento.SelectedValue + "','" + dtpFecha.Value.ToString("yyyy-MM-dd") + "','" + dtpHora.Value.ToString("hh:mm:ss") + "','" + cmbLugar.SelectedValue + "', '" + txtCapacidad.Text + "', '" + txtReserva.Text + "'  ");

            MessageBox.Show("Datos ACTUALIZADOS Correctamente", "Seminario de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtId.Clear();
            txtNombre.Clear();
            txtCapacidad.Clear();
            txtReserva.Clear();

            txtId.Focus();

            conexion.Grids("SELECT IdEvt As Id, NomEvt As Nombre, IdEvn As TipoEvento, FchEvt As FechaEvento,HrEvt As Hora, IdLug As Lugar,  CapEvt As Capacidad, ResEvt As Reserva  FROM Eventos", dgvEventos);

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec EliminarEventos ' " + txtId.Text + " ' ");

            MessageBox.Show("Datos Eliminados Correctamente", "Seminario de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtNombre.Clear();
            txtCapacidad.Clear();
            txtReserva.Clear();
            txtId.Focus();

            conexion.Grids("SELECT IdEvt As Id, NomEvt As Nombre, IdEvn As TipoEvento, FchEvt As FechaEvento,HrEvt As Hora, IdLug As Lugar,  CapEvt As Capacidad, ResEvt As Reserva  FROM Eventos", dgvEventos);
        }
    }
}

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
    public partial class FrmMenuUsu : Form
    {
        public FrmMenuUsu()
        {
            InitializeComponent();
        }

        //CONFIGURACIÓN
        //CLIENTES
        //Nuevo Clien
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
                FrmClientes frmClientes = new FrmClientes();
                frmClientes.Show();
                //Ocutar Boton Actualizar y eliminar
                frmClientes.Actualizar.Visible = false;
                frmClientes.Eliminar.Visible = false;
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();
            //Ocutar Botones
            frmClientes.Actualizar.Visible = false;
            frmClientes.Eliminar.Visible = false;

        }

        // PUESTOS
        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPuestos frmPuestos = new FrmPuestos();
            frmPuestos.Show();
            //Ocutar Boton Actualizar y eliminar
            frmPuestos.Actualizar.Visible = false;
            frmPuestos.Eliminar.Visible = false;
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPuestos frmPuestos = new FrmPuestos();
            frmPuestos.Show();
            //Ocutar Botones
            frmPuestos.Actualizar.Visible = false;
            frmPuestos.Eliminar.Visible = false;
        }


        //COLABODORES
        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmColaboradores frmColaboradores = new FrmColaboradores();
            frmColaboradores.Show();
            //Ocutar Boton Actualizar y eliminar
            frmColaboradores.Actualizar.Visible = false;
            frmColaboradores.Eliminar.Visible = false;
        }

        private void buscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmColaboradores frmColaboradores = new FrmColaboradores();
            frmColaboradores.Show();
            //Ocutar Botones
            frmColaboradores.Actualizar.Visible = false;
            frmColaboradores.Eliminar.Visible = false;
        }


        //TICKETS
        //LUGARES
        //Nuevo lugar
        private void nuevoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmLugares frmLugares = new FrmLugares();
            frmLugares.Show();
            //Ocutar Boton Actualizar y eliminar
            frmLugares.Actualizar.Visible = false;
            frmLugares.Eliminar.Visible = false;
        }

        //buscar lugares
        private void buscarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmLugares frmLugares = new FrmLugares();
            frmLugares.Show();
            //Ocutar Botones
            frmLugares.Actualizar.Visible = false;
            frmLugares.Eliminar.Visible = false;
        }

        //UBICACIONES
        //Nuevo ubicaciones
        private void nuevoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmUbicaciones frmUbicaciones = new FrmUbicaciones();
            frmUbicaciones.Show();
            //Ocutar Boton Actualizar y eliminar
            frmUbicaciones.Actualizar.Visible = false;
            frmUbicaciones.Eliminar.Visible = false;
        }
        //Buscar ubicaciones
        private void buscarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmUbicaciones frmUbicaciones = new FrmUbicaciones();
            frmUbicaciones.Show();
            //Ocutar Botones
            frmUbicaciones.Actualizar.Visible = false;
            frmUbicaciones.Eliminar.Visible = false;
        }

        //TIPO EVENTO
        //Nuevo TEento
        private void nuevoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmTipoEventos frmTipoEventos = new FrmTipoEventos();
            frmTipoEventos.Show();
            //Ocutar Boton Actualizar y eliminar
            frmTipoEventos.Actualizar.Visible = false;
            frmTipoEventos.Eliminar.Visible = false;
        }
        //buscar TEvento
        private void buscarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmTipoEventos frmTipoEventos = new FrmTipoEventos();
            frmTipoEventos.Show();
            //Ocutar Botones
            frmTipoEventos.Actualizar.Visible = false;
            frmTipoEventos.Eliminar.Visible = false;

        }

        //EVENTOS
        //Nuevo Evento
        private void nuevoToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmTipoEventos frmTipoEventos = new FrmTipoEventos();
            frmTipoEventos.Show();
            //Ocutar Boton Actualizar y eliminar
            frmTipoEventos.Actualizar.Visible = false;
            frmTipoEventos.Eliminar.Visible = false;
        }
        //Buscar Eventos
        private void buscarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmTipoEventos frmTipoEventos = new FrmTipoEventos();
            frmTipoEventos.Show();
            //Ocutar Boton Actualizar y eliminar
            frmTipoEventos.Actualizar.Visible = false;
            frmTipoEventos.Eliminar.Visible = false;
        }

        //TICKETS
        //Nuevo Tickets
        private void nuevoToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FrmTickets frmTickets = new FrmTickets();
            frmTickets.Show();
            //Ocutar Boton Actualizar y eliminar
            frmTickets.Actualizar.Visible = false;
            frmTickets.Eliminar.Visible = false;
        }
        //Buscar Tickets
        private void buscarToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FrmTickets frmTickets = new FrmTickets();
            frmTickets.Show();
            //Ocutar Boton Actualizar y eliminar
            frmTickets.Actualizar.Visible = false;
            frmTickets.Eliminar.Visible = false;
        }

        //FACTURA
        private void nuevoToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FrmFactura frmFactura = new FrmFactura();
            frmFactura.Show();
        }

        //BITACORA
        private void nuevoToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            FrmBitacora frmBitacora = new FrmBitacora();
            frmBitacora.Show();
        }

        //NIVELES
        //Nuevo nivel
        private void nuevoToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FrmNiveles frmNiveles = new FrmNiveles();
            frmNiveles.Show();
            //Ocutar Boton Actualizar y eliminar
            frmNiveles.Actualizar.Visible = false;
            frmNiveles.Eliminar.Visible = false;
        }
        //Buscar Nivel
        private void buscarToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FrmNiveles frmNiveles = new FrmNiveles();
            frmNiveles.Show();
            //Ocutar Boton Actualizar y eliminar
            frmNiveles.Actualizar.Visible = false;
            frmNiveles.Eliminar.Visible = false;
        }

        //USUARIOS
        //Nuevo Usuario

        private void nuevoToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Usuarios frmUsuarios = new Usuarios();
            frmUsuarios.Show();
            //Ocutar Boton Actualizar y eliminar
            frmUsuarios.Actualizar.Visible = false;
            frmUsuarios.Eliminar.Visible = false;
        }
        //Buscar Usuario
        private void bUscarToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Usuarios frmUsuarios = new Usuarios();
            frmUsuarios.Show();
            //Ocutar Boton Actualizar y eliminar
            frmUsuarios.Actualizar.Visible = false;
            frmUsuarios.Eliminar.Visible = false;
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }
    }
}

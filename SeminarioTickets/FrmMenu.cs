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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        //CONFIGURACIÓN
        //CLIENTES
        //Nuevo Cliente
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();
            //Ocutar Boton Actualizar y eliminar
            frmClientes.Actualizar.Visible = false;
            frmClientes.Eliminar.Visible = false;
        }
        //Actualizar Cliente
        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();
            //Ocutar Boton Insertar y eliminar
            frmClientes.Insertar.Visible = false;
            frmClientes.Eliminar.Visible = false;
        }
        //Eliminar Clientes
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();
            //Ocutar Boton Insertar y eliminar
            frmClientes.Insertar.Visible = false;
            frmClientes.Actualizar.Visible = false;
        }
        //Buscar Clientes
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();
        }

        //PUESTOS
        //Nuevo Puesto
        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPuestos frmPuestos = new FrmPuestos();
            frmPuestos.Show();
            //Ocutar Boton Actualizar y eliminar
            frmPuestos.Actualizar.Visible = false;
            frmPuestos.Eliminar.Visible = false;
        }
        //Actualizar Puesto
        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPuestos frmPuestos = new FrmPuestos();
            frmPuestos.Show();
            //Ocutar Boton Insertar y eliminar
            frmPuestos.Insertar.Visible = false;
            frmPuestos.Eliminar.Visible = false;
        }
        //Eliminar Puesto
        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPuestos frmPuestos = new FrmPuestos();
            frmPuestos.Show();
            //Ocutar Boton Insertar y eliminar
            frmPuestos.Insertar.Visible = false;
            frmPuestos.Actualizar.Visible = false;
        }
        //Buscar Puesto
        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPuestos frmPuestos = new FrmPuestos();
            frmPuestos.Show();
        }

        //COLABORADORES
        //Nuevo Colaborador
        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmColaboradores frmColaboradores = new FrmColaboradores();
            frmColaboradores.Show();
            //Ocutar Boton Actualizar y eliminar
            frmColaboradores.Actualizar.Visible = false;
            frmColaboradores.Eliminar.Visible = false;
        }
        //Actualizar Colaborador
        private void actualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmColaboradores frmColaboradores = new FrmColaboradores();
            frmColaboradores.Show();
            //Ocutar Boton Insertar y eliminar
            frmColaboradores.Insertar.Visible = false;
            frmColaboradores.Eliminar.Visible = false;
        }
        //Eliminar Colaborador
        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmColaboradores frmColaboradores = new FrmColaboradores();
            frmColaboradores.Show();
            //Ocutar Boton Insertar y eliminar
            frmColaboradores.Insertar.Visible = false;
            frmColaboradores.Actualizar.Visible = false;
        }
        //BuscarColaborador
        private void buscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmColaboradores frmColaboradores = new FrmColaboradores();
            frmColaboradores.Show();

        }

        //TICKETS
        //LUGARES
        //Nuevo Lugar
        private void nuevoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmLugares frmLugares = new FrmLugares();
            frmLugares.Show();
            //Ocutar Boton Actualizar y eliminar
            frmLugares.Actualizar.Visible = false;
            frmLugares.Eliminar.Visible = false;
        }
        //Actualizar Lugar
        private void actualizarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmLugares frmLugares = new FrmLugares();
            frmLugares.Show();
            //Ocutar Boton Insertar y eliminar
            frmLugares.Insertar.Visible = false;
            frmLugares.Eliminar.Visible = false;
        }
        //Eliminar Lugar
        private void eliminarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmLugares frmLugares = new FrmLugares();
            frmLugares.Show();
            //Ocutar Boton Insertar y eliminar
            frmLugares.Insertar.Visible = false;
            frmLugares.Actualizar.Visible = false;
        }
        //Buscar Lugar
        private void buscarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmLugares frmLugares = new FrmLugares();
            frmLugares.Show();
        }

        //UBICACIONES
        //Nueva Ubicación
        private void nuevoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmUbicaciones frmUbicaciones = new FrmUbicaciones();
            frmUbicaciones.Show();
            //Ocutar Boton Actualizar y eliminar
            frmUbicaciones.Actualizar.Visible = false;
            frmUbicaciones.Eliminar.Visible = false;
        }
        //Actualizar ubicación
        private void actualizarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmUbicaciones frmUbicaciones = new FrmUbicaciones();
            frmUbicaciones.Show();
            //Ocutar Boton Insertar y eliminar
            frmUbicaciones.Insertar.Visible = false;
            frmUbicaciones.Eliminar.Visible = false;
        }
        //Eliminar ubicación
        private void eliminarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmUbicaciones frmUbicaciones = new FrmUbicaciones();
            frmUbicaciones.Show();
            //Ocutar Boton Insertar y eliminar
            frmUbicaciones.Insertar.Visible = false;
            frmUbicaciones.Actualizar.Visible = false;
        }
        //Buscar ubicación
        private void buscarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmUbicaciones frmUbicaciones = new FrmUbicaciones();
            frmUbicaciones.Show();

        }

        //TIPO EVENTO
        //Nuevo TEvento
        private void nuevoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmTipoEventos frmTipoEventos = new FrmTipoEventos();
            frmTipoEventos.Show();
            //Ocutar Boton Actualizar y eliminar
            frmTipoEventos.Actualizar.Visible = false;
            frmTipoEventos.Eliminar.Visible = false;
        }   
        //Actualizar TEvento
        private void actualizarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmTipoEventos frmTipoEventos = new FrmTipoEventos();
            frmTipoEventos.Show();
            //Ocutar Boton Insertar y eliminar
            frmTipoEventos.Insertar.Visible = false;
            frmTipoEventos.Eliminar.Visible = false;

        }
        //Eliminar TEvento
        private void eliminarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmTipoEventos frmTipoEventos = new FrmTipoEventos();
            frmTipoEventos.Show();
            //Ocutar Boton Insertar y eliminar
            frmTipoEventos.Insertar.Visible = false;
            frmTipoEventos.Actualizar.Visible = false;
        }
        //Buscar TEvento
        private void buscarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmTipoEventos frmTipoEventos = new FrmTipoEventos();
            frmTipoEventos.Show();
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
        //Actualizar Evento
        private void actualizarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmEventos frmEventos = new FrmEventos();
            frmEventos.Show();
            //Ocutar Boton Insertar y eliminar
            frmEventos.Insertar.Visible = false;
            frmEventos.Eliminar.Visible = false;

        }
        //Eliminar Evento
        private void eliminarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmEventos frmEventos = new FrmEventos();
            frmEventos.Show();
            //Ocutar Boton Insertar y eliminar
            frmEventos.Insertar.Visible = false;
            frmEventos.Actualizar.Visible = false;
        }
        //Buscar Evento
        private void buscarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmEventos frmEventos = new FrmEventos();
            frmEventos.Show();
        }

        //TICKETS
        //Nuevo Ticket
        private void nuevoToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FrmTickets frmTickets = new FrmTickets();
            frmTickets.Show();
            //Ocutar Boton Actualizar y eliminar
            frmTickets.Actualizar.Visible = false;
            frmTickets.Eliminar.Visible = false;
        }
        //Actualizar Ticket
        private void actualizarToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FrmTickets frmTickets = new FrmTickets();
            frmTickets.Show();
            //Ocutar Boton Insertar y eliminar
            frmTickets.Insertar.Visible = false;
            frmTickets.Eliminar.Visible = false;

        }
        //Eliminar Ticket
        private void eliminarToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FrmTickets frmTickets = new FrmTickets();
            frmTickets.Show();
            //Ocutar Boton Insertar y eliminar
            frmTickets.Insertar.Visible = false;
            frmTickets.Actualizar.Visible = false;
        }
        //Buscar Ticket
        private void buscarToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FrmTickets frmTickets = new FrmTickets();
            frmTickets.Show();
        }

        //FACTURA
        private void nuevoToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FrmFactura frmFactura = new FrmFactura();
            frmFactura.Show();
        }


        //SEGURIDAD
        //BITACORA
        private void nuevoToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            FrmBitacora frmBitacora = new FrmBitacora();
            frmBitacora.Show();
        }

        //NIVELES
        //Nuevo Nivel
        private void nuevoToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FrmNiveles frmNiveles = new FrmNiveles();
            frmNiveles.Show();
            //Ocutar Boton Actualizar y eliminar
            frmNiveles.Actualizar.Visible = false;
            frmNiveles.Eliminar.Visible = false;
        }
        //Actualizar Nivel
        private void actualizarToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FrmNiveles frmNiveles = new FrmNiveles();
            frmNiveles.Show();
            //Ocutar Boton Insertar y eliminar
            frmNiveles.Insertar.Visible = false;
            frmNiveles.Eliminar.Visible = false;

        }
        //Eliminar Nivel
        private void eliminarToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FrmNiveles frmNiveles = new FrmNiveles();
            frmNiveles.Show();
            //Ocutar Boton Insertar y eliminar
            frmNiveles.Insertar.Visible = false;
            frmNiveles.Actualizar.Visible = false;
        }
        //Buscar Nivel
        private void buscarToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FrmNiveles frmNiveles = new FrmNiveles();
            frmNiveles.Show();
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
        //Actualizar Usuario
        private void actualizarToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Usuarios frmUsuarios = new Usuarios();
            frmUsuarios.Show();
            //Ocutar Boton Insertar y eliminar
            frmUsuarios.Insertar.Visible = false;
            frmUsuarios.Eliminar.Visible = false;

        }
        //Eliminar Usuario
        private void eliminarToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Usuarios frmUsuarios = new Usuarios();
            frmUsuarios.Show();
            //Ocutar Boton Insertar y eliminar
            frmUsuarios.Insertar.Visible = false;
            frmUsuarios.Actualizar.Visible = false;
        }
        //Buscar Usuario
        private void buscarToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Usuarios frmUsuarios = new Usuarios();
            frmUsuarios.Show();
        }



















    }
}

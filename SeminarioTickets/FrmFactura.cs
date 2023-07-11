using System;
            
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarioTickets
{
    public partial class FrmFactura : Form
    {

        //Llamado a Clase conexión
        Conexion conexion = new Conexion();

        public FrmFactura()
        {
            InitializeComponent();
  
        }
        SqlConnection conex = new SqlConnection("Data Source=localhost;Initial Catalog=SeminarioTickets;Integrated Security=True");

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.seminarioTicketsDataSet.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Colaboradores' Puede moverla o quitarla según sea necesario.
            this.colaboradoresTableAdapter.Fill(this.seminarioTicketsDataSet.Colaboradores);
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.seminarioTicketsDataSet.Clientes);
           
             ConsultaN();
        }

        public void ConsultaN ()
        {
            string consulta = "SELECT (SELECT DISTINCT TOP 1 NroFac DES FROM FacturasEncabezado ORDER BY NroFac DESC) + 1";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conex);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblNumero.Text = row[0].ToString();
            }

        }

        //Metodo de SubTotal
        public void SubTotal()
        {
            decimal ST = 0;
            foreach ( DataGridViewRow row in dgvFacturas.Rows)
            {
                ST += Convert.ToDecimal(row.Cells[3].Value);
            }

            txtSubT.Text = ST.ToString();
        }

        //Metodo de ISV
        public void ISV()
        {
            decimal Isv = 0;
            foreach (DataGridViewRow row in dgvFacturas.Rows)
            {
                Isv = Convert.ToDecimal(txtSubT.Text) * Convert.ToDecimal(0.15);
            }

            txtIsv.Text = Isv.ToString();
        }

        //Metodo de Total
        public void TotalF()
        {
            decimal Ttl = 0;
            foreach (DataGridViewRow row in dgvFacturas.Rows)
            {
                Ttl = Convert.ToDecimal(txtSubT.Text) - Convert.ToDecimal(txtIsv.Text);
            }

            txtTotal.Text = Ttl.ToString();
        }

        //Metodo Inserción Encabezado Factura
        public void InsercionEncabezado()
        {
            int numero = Convert.ToInt32(lblNumero.Text);
            conexion.Modificaciones(" exec InsercionFacturaEncabezado'" + numero + "','" + cmbCliente.SelectedValue + "','" + cmbEmpleado.SelectedValue + "','" +  dtpFecha.Value.ToString("yyyy-MM-dd") + "'  ");
        }

        //Metodo Inserción Detalle Factura
        public void InsercionDetalle()
        {
                int numero = Convert.ToInt32(lblNumero.Text);
                conexion.Modificaciones("exec InsercionFacturaDetalle'" + numero + "','" + dgvFacturas.CurrentRow.Cells[0].Value + "','" + dgvFacturas.CurrentRow.Cells[1].Value + "'  ");
        }

        private void dgvFacturas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
             if (e.ColumnIndex >= dgvFacturas.Columns.Count - 1)  // Última columna
            {
                if (e.RowIndex < dgvFacturas.Rows.Count - 1)  // No es la última fila
                {
                    dgvFacturas.CurrentCell = dgvFacturas.Rows[e.RowIndex + 1].Cells[0];
                }
            }
            else
            {
                dgvFacturas.CurrentCell = dgvFacturas.Rows[e.RowIndex].Cells[e.ColumnIndex + 1];
            }
           dgvFacturas.CurrentRow.Cells[3].Value = Convert.ToInt32(dgvFacturas.CurrentRow.Cells[1].Value) * Convert.ToInt32(dgvFacturas.CurrentRow.Cells[2].Value);
            SubTotal();
            ISV();
            TotalF();

        }

        private void dgvFacturas_RowLeave(object sender, DataGridViewCellEventArgs e)
        { 
           InsercionDetalle();
        }

        private void dgvFacturas_Click(object sender, EventArgs e)
        {
            InsercionEncabezado();
        }

        private void dgvFacturas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                InsercionDetalle();
            }
            else
                MessageBox.Show("No se guardaron datos");
        }
    }
}

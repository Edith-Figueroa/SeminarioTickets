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
    public partial class FrmBitacora : Form
    {
        public FrmBitacora()
        {
            InitializeComponent();
        }

        private void lblBitacora_Click(object sender, EventArgs e)
        {

        }

        Conexion conexion = new Conexion();

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            conexion.Grids("SELECT * from Bitacora", dgvBitacora);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioClientes
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {

        }

        private void datosIniciales ()
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgv);
            fila.Cells[0].Value = "";
            fila.Cells[1].Value = "";
            fila.Cells[2].Value = "";
            fila.Cells[3].Value = "";
            fila.Cells[4].Value = "";
            fila.Cells[5].Value = "";
            fila.Cells[6].Value = "";
            fila.Cells[7].Value = "";
            dgv.Rows.Add(fila);
        }
    }
}

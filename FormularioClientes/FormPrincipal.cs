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

        /*
        * Función que nos genera los datos del datagridview de manera secuencial
        */
        private void datosIniciales(int numeroDatos)
        {
            for (int i = 0; i < numeroDatos; i++)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgv);
                fila.Cells[0].Value = "Carlos";
                fila.Cells[1].Value = "Perez Aguado";
                fila.Cells[2].Value = "Hombre";
                fila.Cells[3].Value = "05/11/1989";
                fila.Cells[4].Value = "75693545P";
                fila.Cells[5].Value = "685987456";
                fila.Cells[6].Value = "C/Pez, nº3";
                fila.Cells[7].Value = "carlospa@gmail.com";
                dgv.Rows.Add(fila);
            }

            for (int i = 0; i < numeroDatos; i++)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgv);
                fila.Cells[0].Value = "Maria";
                fila.Cells[1].Value = "Anguis Jimenez";
                fila.Cells[2].Value = "Mujer";
                fila.Cells[3].Value = "15/01/1967";
                fila.Cells[4].Value = "23695445C";
                fila.Cells[5].Value = "645982156";
                fila.Cells[6].Value = "C/Langosta, nº20";
                fila.Cells[7].Value = "mariaaj@gmail.com";
                dgv.Rows.Add(fila);
            }

            for (int i = 0; i < numeroDatos; i++)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgv);
                fila.Cells[0].Value = "Hugo";
                fila.Cells[1].Value = "Valero Sanchez";
                fila.Cells[2].Value = "Hombre";
                fila.Cells[3].Value = "25/05/1995";
                fila.Cells[4].Value = "15563895L";
                fila.Cells[5].Value = "612934456";
                fila.Cells[6].Value = "C/Dorada, nº15";
                fila.Cells[7].Value = "hugovs@gmail.com";
                dgv.Rows.Add(fila);
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //Llamamos a la función para que nos genere los datos del datagridview
            datosIniciales(2);
        }

        /*
         * Este metodo cuando hacemos doble click en una fila lo que hace es que coge los datos de la 
         * fila y nos lo pasa a FormSecundario
         */
        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewCellCollection datosFila = dgv.CurrentRow.Cells;

            //Paso por referencia tanto el dvg como datosFilas
            FormSecundario formSecundario = new FormSecundario(ref datosFila);
            formSecundario.Show();
        }

        /*
        * Borramos la fila seleccionada del dgv
        */
        private void btEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
            {
                return;
            }

            dgv.Rows.Remove(dgv.CurrentRow);
        }

        /*
         * Este método cuando pulsamos el botón nuevo cliente nos lleva directamente al FormSecundario para
         * desde alli crear al nuevo cliente y que se guarde
         */
        private void btNuevoCliente_Click(object sender, EventArgs e)
        {

        }
    }
}

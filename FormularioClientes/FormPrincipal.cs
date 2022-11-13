using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

            //Cambiamos el color de fondo, el color y el tipo de la letra al formulario
            BackColor = Color.FromArgb(184, 240, 237);
            ForeColor = Color.FromArgb(222, 120, 125);
            Font = new Font("Comic Sans MS", 11, FontStyle.Bold);
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
                fila.Cells[0].Value = "Tipo A";
                fila.Cells[1].Value = "Carlos";
                fila.Cells[2].Value = "Perez Aguado";
                fila.Cells[3].Value = "Hombre";
                fila.Cells[4].Value = "05/11/1989";
                fila.Cells[5].Value = "75693545P";
                fila.Cells[6].Value = "685987456";
                fila.Cells[7].Value = "C/Pez, nº3";
                fila.Cells[8].Value = "carlospa@gmail.com";
                dgv.Rows.Add(fila);
            }

            for (int i = 0; i < numeroDatos; i++)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgv);
                fila.Cells[0].Value = "Tipo B";
                fila.Cells[1].Value = "Maria";
                fila.Cells[2].Value = "Anguis Jimenez";
                fila.Cells[3].Value = "Mujer";
                fila.Cells[4].Value = "15/01/1967";
                fila.Cells[5].Value = "23695445C";
                fila.Cells[6].Value = "645982156";
                fila.Cells[7].Value = "C/Langosta, nº20";
                fila.Cells[8].Value = "mariaaj@gmail.com";
                dgv.Rows.Add(fila);
            }

            for (int i = 0; i < numeroDatos; i++)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgv);
                fila.Cells[0].Value = "Tipo C";
                fila.Cells[1].Value = "Hugo";
                fila.Cells[2].Value = "Valero Sanchez";
                fila.Cells[3].Value = "Hombre";
                fila.Cells[4].Value = "25/05/1995";
                fila.Cells[5].Value = "15563895L";
                fila.Cells[6].Value = "612934456";
                fila.Cells[7].Value = "C/Dorada, nº15";
                fila.Cells[8].Value = "hugovs@gmail.com";
                dgv.Rows.Add(fila);
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //Llamamos a la función para que nos genere los datos del datagridview
            datosIniciales(2);

            Estilos estilo = new Estilos(this.dgv);

            //Introducimos los diferetentes estilos
            estilo.definirFilas("#7adcd5", "#b8575e", "#50b4ad", "----------");
            estilo.definirCabecera("#7adcd5", "#50b4ad");
            estilo.definirFilarAlternas("#de787d", "#7adcd5", "**********");

            //Ajustamos el tamño de todas las columnas
            foreach (DataGridViewColumn dgvColumna in this.dgv.Columns)
            {
                dgvColumna.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

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
            FormSecundario formSecundario = new FormSecundario(ref dgv);
            formSecundario.Show();
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv.Columns[e.ColumnIndex].Name == "ColumnTipoCliente")
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString() == "Tipo A")
                    {
                        e.CellStyle.BackColor = Color.White;
                        e.CellStyle.ForeColor = Color.FromArgb(184, 87, 94);
                        e.CellStyle.Font = new Font("Comic Sans MS", 12, FontStyle.Underline);
                    }
                    if (e.Value.ToString() == "Tipo B")
                    {
                        e.CellStyle.BackColor = Color.White;
                        e.CellStyle.ForeColor = Color.FromArgb(80, 180, 173);
                        e.CellStyle.Font = new Font("Comic Sans MS", 12, FontStyle.Underline);
                    }
                    if (e.Value.ToString() == "Tipo C")
                    {
                        e.CellStyle.BackColor = Color.White;
                        e.CellStyle.ForeColor = Color.FromArgb(222, 120, 125);
                        e.CellStyle.Font = new Font("Comic Sans MS", 12, FontStyle.Underline);
                    }
                }
            }
        }
    }
}

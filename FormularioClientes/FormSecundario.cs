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
    public partial class FormSecundario : Form
    {
        //Creamos las variables a utilizar
        public String nombre, apellidos, sexo, fechaNacimiento, tipoDocumento, telefono, direccion, email;

        //Creamos la variable datagridview que vamos a usar
        DataGridView dataGridViewCompleto;

        //Creamos la variable datagridviewcellcollection que vamos a usar
        DataGridViewCellCollection filaExtraida;

        public FormSecundario()
        {
            InitializeComponent();
        }

        /*
         * Añadimos la ref del datagridview del FormPrincipal
         */
        public FormSecundario(ref DataGridView dgv)
        {
            InitializeComponent();

            dataGridViewCompleto = dgv;
        }

        /*
         * Añadimos la ref del datagridview y las filas seleccionadas del FormPrincipal,
         * nos muestra los datos de la fila seleccionada
         */
        public FormSecundario(ref DataGridViewCellCollection fila)
        {
            InitializeComponent();

            this.tbNombre.Text = fila[0].Value.ToString();
            this.tbApellidos.Text = fila[1].Value.ToString();
            if (fila[2].Value.ToString().Equals(rbHombre.Text))
            {
                this.rbHombre.Text = fila[2].Value.ToString();

            } else
            {
                this.rbMujer.Text = fila[2].Value.ToString();
            }
            this.dtpFechaNacimiento.Text = fila[3].Value.ToString();
            this.mtbTipoDocumento.Text = fila[4].Value.ToString();
            this.tbTelefono.Text = fila[5].Value.ToString();
            this.tbDireccion.Text = fila[6].Value.ToString();
            this.tbEmail.Text = fila[7].Value.ToString();

            filaExtraida = fila;
        }

        private void FormSecundario_Load(object sender, EventArgs e)
        {

        }

        /*
         * Este metodo guarda los datos que se han pasado de la fila seleccionada de FormPrincipal
         * y se si cambian los guarda y se actualizada en el FormPrincipal
         */
        private void btGuardar_Click(object sender, EventArgs e)
        {
            filaExtraida[0].Value = this.tbNombre.Text;
            filaExtraida[1].Value = this.tbApellidos.Text;
            if (rbHombre.Checked == true)
            {
                filaExtraida[2].Value = this.rbHombre.Text;

            }
            else
            {
                filaExtraida[2].Value = this.rbMujer.Text;
            }
            filaExtraida[3].Value = this.dtpFechaNacimiento.Text;
            filaExtraida[4].Value = this.mtbTipoDocumento.Text.ToString();
            filaExtraida[5].Value = this.tbTelefono.Text;
            filaExtraida[6].Value = this.tbDireccion.Text;
            filaExtraida[7].Value = this.tbEmail.Text;

            Close();
        }
    }
}

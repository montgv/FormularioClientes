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
        //Creamos la variable datagridview que vamos a usar
        DataGridView dataGridViewCompleto;

        //Creamos la variable datagridviewrow que vamos a usar
        DataGridViewRow filaInsertar;

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

            //Cambiamos el color de fondo, el color y el tipo de la letra al formulario
            BackColor = Color.FromArgb(184, 240, 237);
            ForeColor = Color.FromArgb(222, 120, 125);
            Font = new Font("Comic Sans MS", 10, FontStyle.Bold);
        }

        /*
         * Añadimos la ref del datagridview y las filas seleccionadas del FormPrincipal,
         * nos muestra los datos de la fila seleccionada
         */
        public FormSecundario(ref DataGridViewCellCollection fila)
        {
            InitializeComponent();

            this.cbTipoCliente.Text = fila[0].Value.ToString();
            this.tbNombre.Text = fila[1].Value.ToString();
            this.tbApellidos.Text = fila[1].Value.ToString();
            if (fila[3].Value.ToString().Equals(rbHombre.Text))
            {
                this.rbHombre.Text = fila[3].Value.ToString();

            }
            else
            {
                this.rbMujer.Text = fila[3].Value.ToString();
            }
            this.dtpFechaNacimiento.Text = fila[4].Value.ToString();
            this.mtbDni.Text = fila[5].Value.ToString();
            this.tbTelefono.Text = fila[6].Value.ToString();
            this.tbDireccion.Text = fila[7].Value.ToString();
            this.tbEmail.Text = fila[8].Value.ToString();

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
            if (filaExtraida == null)
            {
                filaInsertar = new DataGridViewRow();
                filaInsertar.CreateCells(dataGridViewCompleto);
                filaInsertar.Cells[0].Value = this.cbTipoCliente.Text;
                filaInsertar.Cells[1].Value = this.tbNombre.Text;
                filaInsertar.Cells[2].Value = this.tbApellidos.Text;
                if (rbHombre.Checked == true)
                {
                    filaInsertar.Cells[3].Value = this.rbHombre.Text;

                }
                else
                {
                    filaInsertar.Cells[3].Value = this.rbMujer.Text;
                }
                filaInsertar.Cells[4].Value = this.dtpFechaNacimiento.Text;
                filaInsertar.Cells[5].Value = this.mtbDni.Text.ToString();
                filaInsertar.Cells[6].Value = this.tbTelefono.Text;
                filaInsertar.Cells[7].Value = this.tbDireccion.Text;
                filaInsertar.Cells[8].Value = this.tbEmail.Text;

                dataGridViewCompleto.Rows.Add(filaInsertar);

                this.tbNombre.Text = "";
                this.tbApellidos.Text = "";
                this.rbHombre.Enabled = false;
                this.rbMujer.Enabled = false;
                this.dtpFechaNacimiento.Text = "";
                this.mtbDni.Text = "";
                this.tbTelefono.Text = "";
                this.tbDireccion.Text = "";
                this.tbEmail.Text = "";

                Close();
            }
            else
            {
                filaExtraida[0].Value = this.cbTipoCliente.Text;
                filaExtraida[1].Value = this.tbNombre.Text;
                filaExtraida[2].Value = this.tbApellidos.Text;
                if (rbHombre.Checked == true)
                {
                    filaExtraida[3].Value = this.rbHombre.Text;

                }
                else
                {
                    filaExtraida[3].Value = this.rbMujer.Text;
                }
                filaExtraida[4].Value = this.dtpFechaNacimiento.Text;
                filaExtraida[5].Value = this.mtbDni.Text.ToString();
                filaExtraida[6].Value = this.tbTelefono.Text;
                filaExtraida[7].Value = this.tbDireccion.Text;
                filaExtraida[8].Value = this.tbEmail.Text;

                Close();
            }
        }

        //Creo la siguiente función donde en cada componenten hay un texto distinto de una cadena vacia
        //en el caso de los radio button si esta seleccionado y es igual a verdadero que contador sume
        //uno y por ultimo se los asignamos al valor del progressbar para que se muestre en el progressbar
        public void completadoCliente()
        {
            int contador = 0;

            if (cbTipoCliente.Text != "")
            {
                contador++;
            }

            if (tbNombre.Text != "")
            {
                contador++;
            }

            if (tbApellidos.Text != "")
            {
                contador++;
            }
             
            if (rbHombre.Checked == true)
            {
                contador++;
            }

            if (rbMujer.Checked == true)
            {
                contador++;
            }

            if (dtpFechaNacimiento.Text != "")
            {
                contador++;
            }

            if (mtbDni.Text != "")
            {
                contador++;
            }

            if (tbTelefono.Text != "")
            {
                contador++;
            }

            if (tbDireccion.Text != "")
            {
                contador++;
            }

            if (tbEmail.Text != "")
            {
                contador++;
            }

            pbCompletado.Value = contador;
        }

        //A partir de aqui lo que estamos es pasandole la funcion a los distintos eventos que hace que se
        //active por asi decirlo el cambio que depende de cada componente

        private void cbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            completadoCliente();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            completadoCliente();
        }

        private void tbApellidos_TextChanged(object sender, EventArgs e)
        {
            completadoCliente();
        }

        private void rbHombre_CheckedChanged(object sender, EventArgs e)
        {
            completadoCliente();
        }

        private void rbMujer_CheckedChanged(object sender, EventArgs e)
        {
            completadoCliente();
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            completadoCliente();
        }

        private void mtbDni_MaskChanged(object sender, EventArgs e)
        {
            completadoCliente();
        }

        /*
         * Comprobamos los datos introducidos en el tBTelefono, si la longitud del texto de telefono es 
         * distinto de 9, se cambian el fondo del textbox al tono elegido por rgb y sino el fondo es blanco
         * Y ademas la funcion para que realice el crecimiento del progressBar
         */
        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {
            String telef = tbTelefono.Text;

            if (telef.Length != 9)
            {
                tbTelefono.BackColor = Color.FromArgb(222, 120, 125);
            }
            else
            {
                tbTelefono.BackColor = Color.White;
            }

            completadoCliente();
        }

        private void tbDireccion_TextChanged(object sender, EventArgs e)
        {
            completadoCliente();
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            completadoCliente();
        }
    }
}

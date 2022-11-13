namespace FormularioClientes
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lbListadoClientes = new System.Windows.Forms.Label();
            this.btNuevoCliente = new System.Windows.Forms.Button();
            this.btEliminarCliente = new System.Windows.Forms.Button();
            this.ColumnTipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTipoCliente,
            this.ColumnNombre,
            this.ColumnApellidos,
            this.ColumnSexo,
            this.ColumnFechaNacimiento,
            this.ColumnDni,
            this.ColumnDireccion,
            this.ColumnTelefono,
            this.ColumnEmail});
            this.dgv.Location = new System.Drawing.Point(13, 129);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.Size = new System.Drawing.Size(1214, 242);
            this.dgv.TabIndex = 0;
            this.dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // lbListadoClientes
            // 
            this.lbListadoClientes.AutoSize = true;
            this.lbListadoClientes.Location = new System.Drawing.Point(532, 20);
            this.lbListadoClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbListadoClientes.Name = "lbListadoClientes";
            this.lbListadoClientes.Size = new System.Drawing.Size(122, 20);
            this.lbListadoClientes.TabIndex = 1;
            this.lbListadoClientes.Text = "Listado Clientes";
            // 
            // btNuevoCliente
            // 
            this.btNuevoCliente.BackColor = System.Drawing.SystemColors.Window;
            this.btNuevoCliente.Location = new System.Drawing.Point(169, 70);
            this.btNuevoCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btNuevoCliente.Name = "btNuevoCliente";
            this.btNuevoCliente.Size = new System.Drawing.Size(212, 35);
            this.btNuevoCliente.TabIndex = 2;
            this.btNuevoCliente.Text = "Nuevo Cliente";
            this.btNuevoCliente.UseVisualStyleBackColor = false;
            this.btNuevoCliente.Click += new System.EventHandler(this.btNuevoCliente_Click);
            // 
            // btEliminarCliente
            // 
            this.btEliminarCliente.BackColor = System.Drawing.SystemColors.Window;
            this.btEliminarCliente.Location = new System.Drawing.Point(826, 70);
            this.btEliminarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btEliminarCliente.Name = "btEliminarCliente";
            this.btEliminarCliente.Size = new System.Drawing.Size(232, 35);
            this.btEliminarCliente.TabIndex = 3;
            this.btEliminarCliente.Text = "Eliminar Cliente";
            this.btEliminarCliente.UseVisualStyleBackColor = false;
            this.btEliminarCliente.Click += new System.EventHandler(this.btEliminarCliente_Click);
            // 
            // ColumnTipoCliente
            // 
            this.ColumnTipoCliente.HeaderText = "Tipo Cliente";
            this.ColumnTipoCliente.MinimumWidth = 8;
            this.ColumnTipoCliente.Name = "ColumnTipoCliente";
            this.ColumnTipoCliente.Width = 150;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.MinimumWidth = 8;
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.Width = 150;
            // 
            // ColumnApellidos
            // 
            this.ColumnApellidos.HeaderText = "Apellidos";
            this.ColumnApellidos.MinimumWidth = 8;
            this.ColumnApellidos.Name = "ColumnApellidos";
            this.ColumnApellidos.Width = 150;
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.HeaderText = "Sexo";
            this.ColumnSexo.MinimumWidth = 8;
            this.ColumnSexo.Name = "ColumnSexo";
            this.ColumnSexo.Width = 150;
            // 
            // ColumnFechaNacimiento
            // 
            this.ColumnFechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.ColumnFechaNacimiento.MinimumWidth = 8;
            this.ColumnFechaNacimiento.Name = "ColumnFechaNacimiento";
            this.ColumnFechaNacimiento.Width = 150;
            // 
            // ColumnDni
            // 
            this.ColumnDni.HeaderText = "Dni";
            this.ColumnDni.MinimumWidth = 8;
            this.ColumnDni.Name = "ColumnDni";
            this.ColumnDni.Width = 150;
            // 
            // ColumnDireccion
            // 
            this.ColumnDireccion.HeaderText = "Dirección";
            this.ColumnDireccion.MinimumWidth = 8;
            this.ColumnDireccion.Name = "ColumnDireccion";
            this.ColumnDireccion.Width = 150;
            // 
            // ColumnTelefono
            // 
            this.ColumnTelefono.HeaderText = "Teléfono";
            this.ColumnTelefono.MinimumWidth = 8;
            this.ColumnTelefono.Name = "ColumnTelefono";
            this.ColumnTelefono.Width = 150;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "E-mail";
            this.ColumnEmail.MinimumWidth = 8;
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.Width = 150;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 473);
            this.Controls.Add(this.btEliminarCliente);
            this.Controls.Add(this.btNuevoCliente);
            this.Controls.Add(this.lbListadoClientes);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lbListadoClientes;
        private System.Windows.Forms.Button btNuevoCliente;
        private System.Windows.Forms.Button btEliminarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
    }
}
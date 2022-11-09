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
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbListadoClientes = new System.Windows.Forms.Label();
            this.btNuevoCliente = new System.Windows.Forms.Button();
            this.btEliminarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombre,
            this.ColumnApellidos,
            this.ColumnSexo,
            this.ColumnFechaNacimiento,
            this.ColumnTipoDocumento,
            this.ColumnDireccion,
            this.ColumnTelefono,
            this.ColumnEmail});
            this.dgv.Location = new System.Drawing.Point(31, 161);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(846, 150);
            this.dgv.TabIndex = 0;
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnApellidos
            // 
            this.ColumnApellidos.HeaderText = "Apellidos";
            this.ColumnApellidos.Name = "ColumnApellidos";
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.HeaderText = "Sexo";
            this.ColumnSexo.Name = "ColumnSexo";
            // 
            // ColumnFechaNacimiento
            // 
            this.ColumnFechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.ColumnFechaNacimiento.Name = "ColumnFechaNacimiento";
            // 
            // ColumnTipoDocumento
            // 
            this.ColumnTipoDocumento.HeaderText = "Tipo de Documento";
            this.ColumnTipoDocumento.Name = "ColumnTipoDocumento";
            // 
            // ColumnDireccion
            // 
            this.ColumnDireccion.HeaderText = "Dirección";
            this.ColumnDireccion.Name = "ColumnDireccion";
            // 
            // ColumnTelefono
            // 
            this.ColumnTelefono.HeaderText = "Teléfono";
            this.ColumnTelefono.Name = "ColumnTelefono";
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "E-mail";
            this.ColumnEmail.Name = "ColumnEmail";
            // 
            // lbListadoClientes
            // 
            this.lbListadoClientes.AutoSize = true;
            this.lbListadoClientes.Location = new System.Drawing.Point(389, 42);
            this.lbListadoClientes.Name = "lbListadoClientes";
            this.lbListadoClientes.Size = new System.Drawing.Size(81, 13);
            this.lbListadoClientes.TabIndex = 1;
            this.lbListadoClientes.Text = "Listado Clientes";
            // 
            // btNuevoCliente
            // 
            this.btNuevoCliente.Location = new System.Drawing.Point(205, 98);
            this.btNuevoCliente.Name = "btNuevoCliente";
            this.btNuevoCliente.Size = new System.Drawing.Size(141, 23);
            this.btNuevoCliente.TabIndex = 2;
            this.btNuevoCliente.Text = "Nuevo Cliente";
            this.btNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // btEliminarCliente
            // 
            this.btEliminarCliente.Location = new System.Drawing.Point(498, 99);
            this.btEliminarCliente.Name = "btEliminarCliente";
            this.btEliminarCliente.Size = new System.Drawing.Size(155, 23);
            this.btEliminarCliente.TabIndex = 3;
            this.btEliminarCliente.Text = "Eliminar Cliente";
            this.btEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.btEliminarCliente);
            this.Controls.Add(this.btNuevoCliente);
            this.Controls.Add(this.lbListadoClientes);
            this.Controls.Add(this.dgv);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.Label lbListadoClientes;
        private System.Windows.Forms.Button btNuevoCliente;
        private System.Windows.Forms.Button btEliminarCliente;
    }
}
namespace Laboratorio6
{
    partial class Form1
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarLibro = new System.Windows.Forms.TextBox();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.grpInicio = new System.Windows.Forms.GroupBox();
            this.btnActualizarCantidad = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.grpInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Salmon;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(797, 632);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 52);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarLibro.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLibro.Location = new System.Drawing.Point(88, 632);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(124, 52);
            this.btnAgregarLibro.TabIndex = 10;
            this.btnAgregarLibro.Text = "Agregar";
            this.btnAgregarLibro.UseVisualStyleBackColor = false;
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(67, 211);
            this.dgvLibros.MultiSelect = false;
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.RowTemplate.Height = 24;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(883, 364);
            this.dgvLibros.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inventario de Libros ";
            // 
            // txtBuscarLibro
            // 
            this.txtBuscarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarLibro.Location = new System.Drawing.Point(526, 61);
            this.txtBuscarLibro.Name = "txtBuscarLibro";
            this.txtBuscarLibro.Size = new System.Drawing.Size(263, 27);
            this.txtBuscarLibro.TabIndex = 4;
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.BackColor = System.Drawing.Color.Silver;
            this.btnBuscarLibro.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLibro.Location = new System.Drawing.Point(809, 54);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(115, 41);
            this.btnBuscarLibro.TabIndex = 5;
            this.btnBuscarLibro.Text = "Buscar";
            this.btnBuscarLibro.UseVisualStyleBackColor = false;
            // 
            // grpInicio
            // 
            this.grpInicio.BackColor = System.Drawing.Color.Black;
            this.grpInicio.Controls.Add(this.btnBuscarLibro);
            this.grpInicio.Controls.Add(this.txtBuscarLibro);
            this.grpInicio.Controls.Add(this.label1);
            this.grpInicio.Location = new System.Drawing.Point(0, 23);
            this.grpInicio.Name = "grpInicio";
            this.grpInicio.Size = new System.Drawing.Size(1022, 126);
            this.grpInicio.TabIndex = 8;
            this.grpInicio.TabStop = false;
            // 
            // btnActualizarCantidad
            // 
            this.btnActualizarCantidad.BackColor = System.Drawing.Color.Silver;
            this.btnActualizarCantidad.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCantidad.Location = new System.Drawing.Point(267, 632);
            this.btnActualizarCantidad.Name = "btnActualizarCantidad";
            this.btnActualizarCantidad.Size = new System.Drawing.Size(240, 52);
            this.btnActualizarCantidad.TabIndex = 11;
            this.btnActualizarCantidad.Text = "Actualizar Cantidad";
            this.btnActualizarCantidad.UseVisualStyleBackColor = false;
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.Silver;
            this.btnRecargar.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargar.Location = new System.Drawing.Point(558, 632);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(199, 52);
            this.btnRecargar.TabIndex = 13;
            this.btnRecargar.Text = "Mostrar Todos";
            this.btnRecargar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 737);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizarCantidad);
            this.Controls.Add(this.btnAgregarLibro);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.grpInicio);
            this.Name = "Form1";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.grpInicio.ResumeLayout(false);
            this.grpInicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarLibro;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.GroupBox grpInicio;
        private System.Windows.Forms.Button btnActualizarCantidad;
        private System.Windows.Forms.Button btnRecargar;
    }
}
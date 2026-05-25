namespace InventarioApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvDatos = new DataGridView();
            txtNombre = new TextBox();
            numPrecio = new NumericUpDown();
            cmbCategorias = new ComboBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(205, 30);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(583, 394);
            dgvDatos.TabIndex = 0;
            dgvDatos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(23, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 27);
            txtNombre.TabIndex = 1;
            // 
            // numPrecio
            // 
            numPrecio.Location = new Point(23, 132);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(165, 27);
            numPrecio.TabIndex = 2;
            // 
            // cmbCategorias
            // 
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(23, 43);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(165, 28);
            cmbCategorias.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(23, 188);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(165, 55);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(23, 350);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(165, 60);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(23, 271);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(165, 57);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbCategorias);
            Controls.Add(numPrecio);
            Controls.Add(txtNombre);
            Controls.Add(dgvDatos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos;
        private TextBox txtNombre;
        private NumericUpDown numPrecio;
        private ComboBox cmbCategorias;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnLimpiar;
    }
}

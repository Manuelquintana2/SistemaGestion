namespace SistemaGestionUI
{
    partial class FrmClientes
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
            dataGridView1 = new DataGridView();
            btnCrear = new Button();
            Id = new DataGridViewTextBoxColumn();
            NombreApellido = new DataGridViewTextBoxColumn();
            Domicilio = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            btnEditar = new DataGridViewButtonColumn();
            btnEliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, NombreApellido, Domicilio, Telefono, btnEditar, btnEliminar });
            dataGridView1.Location = new Point(12, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 353);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(664, 32);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // NombreApellido
            // 
            NombreApellido.DataPropertyName = "NombreApellido";
            NombreApellido.HeaderText = "NombreApellido";
            NombreApellido.MinimumWidth = 6;
            NombreApellido.Name = "NombreApellido";
            NombreApellido.ReadOnly = true;
            NombreApellido.Width = 125;
            // 
            // Domicilio
            // 
            Domicilio.DataPropertyName = "Domicilio";
            Domicilio.HeaderText = "Domicilio";
            Domicilio.MinimumWidth = 6;
            Domicilio.Name = "Domicilio";
            Domicilio.ReadOnly = true;
            Domicilio.Width = 125;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 125;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "Editar";
            btnEditar.MinimumWidth = 6;
            btnEditar.Name = "btnEditar";
            btnEditar.ReadOnly = true;
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.Width = 125;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.MinimumWidth = 6;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ReadOnly = true;
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.Width = 125;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrear);
            Controls.Add(dataGridView1);
            Name = "FrmClientes";
            Text = "FrmClientes";
            FormClosed += FrmClientes_FormClosed;
            Load += FrmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnCrear;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NombreApellido;
        private DataGridViewTextBoxColumn Domicilio;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewButtonColumn btnEditar;
        private DataGridViewButtonColumn btnEliminar;
    }
}
namespace SistemaGestionUI
{
    partial class FrmModificarCliente
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
            label1 = new Label();
            txtNombreApellido = new TextBox();
            label2 = new Label();
            txtDomicilio = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(268, 50);
            label1.Name = "label1";
            label1.Size = new Size(217, 31);
            label1.TabIndex = 1;
            label1.Text = "Nombre y Apellido";
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(226, 84);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(304, 27);
            txtNombreApellido.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(318, 145);
            label2.Name = "label2";
            label2.Size = new Size(119, 31);
            label2.TabIndex = 3;
            label2.Text = "Domicilio";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(226, 179);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(304, 27);
            txtDomicilio.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(318, 232);
            label3.Name = "label3";
            label3.Size = new Size(107, 31);
            label3.TabIndex = 5;
            label3.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(226, 278);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(304, 27);
            txtTelefono.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(318, 345);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(109, 42);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmModificarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtDomicilio);
            Controls.Add(label2);
            Controls.Add(txtNombreApellido);
            Controls.Add(label1);
            Name = "FrmModificarCliente";
            Text = "FrmModificarCliente";
            Load += FrmModificarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreApellido;
        private Label label2;
        private TextBox txtDomicilio;
        private Label label3;
        private TextBox txtTelefono;
        private Button btnGuardar;
    }
}
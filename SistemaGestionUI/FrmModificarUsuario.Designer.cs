﻿namespace SistemaGestion
{
    partial class FrmModificarUsuario
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
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtNombreUsuario = new TextBox();
            label4 = new Label();
            txtContraseña = new TextBox();
            label5 = new Label();
            txtMail = new TextBox();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(291, 9);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 40;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(171, 41);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(356, 34);
            txtNombre.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(289, 79);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 46;
            label1.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(171, 111);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(356, 34);
            txtApellido.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(246, 149);
            label3.Name = "label3";
            label3.Size = new Size(194, 28);
            label3.TabIndex = 48;
            label3.Text = "Nombre de usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreUsuario.Location = new Point(171, 181);
            txtNombreUsuario.Margin = new Padding(3, 4, 3, 4);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(356, 34);
            txtNombreUsuario.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(289, 219);
            label4.Name = "label4";
            label4.Size = new Size(118, 28);
            label4.TabIndex = 50;
            label4.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(171, 251);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(356, 34);
            txtContraseña.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(310, 289);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
            label5.TabIndex = 52;
            label5.Text = "Mail";
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(171, 321);
            txtMail.Margin = new Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(356, 34);
            txtMail.TabIndex = 53;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(289, 374);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(105, 48);
            btnModificar.TabIndex = 54;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // FrmModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificar);
            Controls.Add(txtMail);
            Controls.Add(label5);
            Controls.Add(txtContraseña);
            Controls.Add(label4);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Name = "FrmModificarUsuario";
            Text = "FrmModificarUsuario";
            Load += FrmModificarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtNombreUsuario;
        private Label label4;
        private TextBox txtContraseña;
        private Label label5;
        private TextBox txtMail;
        private Button btnModificar;
    }
}
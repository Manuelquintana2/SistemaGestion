namespace SistemaGestionUI
{
    partial class FrmLogin
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
            txtUsuario = new TextBox();
            label2 = new Label();
            txtContraseña = new TextBox();
            btnEnviar = new Button();
            btnMosrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(297, 72);
            label1.Name = "label1";
            label1.Size = new Size(166, 28);
            label1.TabIndex = 0;
            label1.Text = "Ingrese su Email";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(230, 103);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(298, 27);
            txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(310, 178);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(230, 209);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(298, 27);
            txtContraseña.TabIndex = 3;
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnviar.Location = new Point(322, 295);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 40);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnMosrar
            // 
            btnMosrar.Location = new Point(574, 209);
            btnMosrar.Name = "btnMosrar";
            btnMosrar.Size = new Size(94, 29);
            btnMosrar.TabIndex = 5;
            btnMosrar.Text = "Mostrar";
            btnMosrar.UseVisualStyleBackColor = true;
            btnMosrar.Click += btnMosrar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMosrar);
            Controls.Add(btnEnviar);
            Controls.Add(txtContraseña);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtContraseña;
        private Button btnEnviar;
        private Button btnMosrar;
    }
}
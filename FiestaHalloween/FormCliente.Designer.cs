namespace FiestaHalloween
{
    partial class FormCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxCodigoInvitacion = new System.Windows.Forms.TextBox();
            this.tbxContraseña = new System.Windows.Forms.TextBox();
            this.tbxDisfraz = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código de invitación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Registro cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Disfraz:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cargar foto del disfraz";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(39, 90);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(129, 22);
            this.tbxNombre.TabIndex = 6;
            // 
            // tbxCodigoInvitacion
            // 
            this.tbxCodigoInvitacion.Location = new System.Drawing.Point(39, 161);
            this.tbxCodigoInvitacion.Name = "tbxCodigoInvitacion";
            this.tbxCodigoInvitacion.Size = new System.Drawing.Size(129, 22);
            this.tbxCodigoInvitacion.TabIndex = 7;
            // 
            // tbxContraseña
            // 
            this.tbxContraseña.Location = new System.Drawing.Point(39, 230);
            this.tbxContraseña.Name = "tbxContraseña";
            this.tbxContraseña.Size = new System.Drawing.Size(129, 22);
            this.tbxContraseña.TabIndex = 8;
            // 
            // tbxDisfraz
            // 
            this.tbxDisfraz.Location = new System.Drawing.Point(39, 304);
            this.tbxDisfraz.Name = "tbxDisfraz";
            this.tbxDisfraz.Size = new System.Drawing.Size(129, 22);
            this.tbxDisfraz.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(283, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 179);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(206, 368);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 33);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 429);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxDisfraz);
            this.Controls.Add(this.tbxContraseña);
            this.Controls.Add(this.tbxCodigoInvitacion);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxCodigoInvitacion;
        private System.Windows.Forms.TextBox tbxContraseña;
        private System.Windows.Forms.TextBox tbxDisfraz;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistrar;
    }
}
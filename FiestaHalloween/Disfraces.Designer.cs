namespace FiestaHalloween
{
    partial class Disfraces
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
            this.lbxParticipantes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbDisfraz = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPuntajeDisfraz = new System.Windows.Forms.NumericUpDown();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPuntuaciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDisfraz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuntajeDisfraz)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxParticipantes
            // 
            this.lbxParticipantes.FormattingEnabled = true;
            this.lbxParticipantes.ItemHeight = 16;
            this.lbxParticipantes.Location = new System.Drawing.Point(29, 61);
            this.lbxParticipantes.Name = "lbxParticipantes";
            this.lbxParticipantes.Size = new System.Drawing.Size(140, 212);
            this.lbxParticipantes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Participantes:";
            // 
            // pcbDisfraz
            // 
            this.pcbDisfraz.Location = new System.Drawing.Point(253, 61);
            this.pcbDisfraz.Name = "pcbDisfraz";
            this.pcbDisfraz.Size = new System.Drawing.Size(196, 214);
            this.pcbDisfraz.TabIndex = 2;
            this.pcbDisfraz.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "ver disfraz";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtPuntajeDisfraz
            // 
            this.txtPuntajeDisfraz.Location = new System.Drawing.Point(280, 313);
            this.txtPuntajeDisfraz.Name = "txtPuntajeDisfraz";
            this.txtPuntajeDisfraz.Size = new System.Drawing.Size(145, 22);
            this.txtPuntajeDisfraz.TabIndex = 4;
            this.txtPuntajeDisfraz.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(298, 341);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(112, 27);
            this.btnCalificar.TabIndex = 5;
            this.btnCalificar.Text = "calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Puntaje disfraz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tabla de puntaciones";
            // 
            // lblPuntuaciones
            // 
            this.lblPuntuaciones.AutoSize = true;
            this.lblPuntuaciones.Location = new System.Drawing.Point(552, 91);
            this.lblPuntuaciones.Name = "lblPuntuaciones";
            this.lblPuntuaciones.Size = new System.Drawing.Size(44, 16);
            this.lblPuntuaciones.TabIndex = 8;
            this.lblPuntuaciones.Text = "label4";
            // 
            // Disfraces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.lblPuntuaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalificar);
            this.Controls.Add(this.txtPuntajeDisfraz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pcbDisfraz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxParticipantes);
            this.Name = "Disfraces";
            this.Text = "Disfraces";
            ((System.ComponentModel.ISupportInitialize)(this.pcbDisfraz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuntajeDisfraz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxParticipantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbDisfraz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txtPuntajeDisfraz;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPuntuaciones;
    }
}
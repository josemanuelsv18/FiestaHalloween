namespace FiestaHalloween
{
    partial class FormActividad
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
            this.btnConcursoDisfraces = new System.Windows.Forms.Button();
            this.btnDulceTruco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConcursoDisfraces
            // 
            this.btnConcursoDisfraces.Location = new System.Drawing.Point(109, 143);
            this.btnConcursoDisfraces.Name = "btnConcursoDisfraces";
            this.btnConcursoDisfraces.Size = new System.Drawing.Size(125, 86);
            this.btnConcursoDisfraces.TabIndex = 0;
            this.btnConcursoDisfraces.Text = "Concurso de disfraces";
            this.btnConcursoDisfraces.UseVisualStyleBackColor = true;
            // 
            // btnDulceTruco
            // 
            this.btnDulceTruco.Location = new System.Drawing.Point(338, 143);
            this.btnDulceTruco.Name = "btnDulceTruco";
            this.btnDulceTruco.Size = new System.Drawing.Size(125, 86);
            this.btnDulceTruco.TabIndex = 1;
            this.btnDulceTruco.Text = "Dulce o Truco";
            this.btnDulceTruco.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione en que desea participar:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(249, 274);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FormActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 337);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDulceTruco);
            this.Controls.Add(this.btnConcursoDisfraces);
            this.Name = "FormActividad";
            this.Text = "FormActividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConcursoDisfraces;
        private System.Windows.Forms.Button btnDulceTruco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
    }
}
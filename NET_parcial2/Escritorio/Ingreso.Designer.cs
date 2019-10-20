namespace Escritorio
{
    partial class Ingreso
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
            this.etiqUsuario = new System.Windows.Forms.Label();
            this.etiqContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.etiqArriba = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // etiqUsuario
            // 
            this.etiqUsuario.AutoSize = true;
            this.etiqUsuario.Location = new System.Drawing.Point(20, 81);
            this.etiqUsuario.Name = "etiqUsuario";
            this.etiqUsuario.Size = new System.Drawing.Size(98, 13);
            this.etiqUsuario.TabIndex = 0;
            this.etiqUsuario.Text = "Nombre de Usuario";
            // 
            // etiqContraseña
            // 
            this.etiqContraseña.AutoSize = true;
            this.etiqContraseña.Location = new System.Drawing.Point(57, 107);
            this.etiqContraseña.Name = "etiqContraseña";
            this.etiqContraseña.Size = new System.Drawing.Size(61, 13);
            this.etiqContraseña.TabIndex = 1;
            this.etiqContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(124, 78);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(147, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(124, 104);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(147, 20);
            this.txtContraseña.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(87, 158);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(196, 158);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // etiqArriba
            // 
            this.etiqArriba.AutoSize = true;
            this.etiqArriba.Location = new System.Drawing.Point(64, 34);
            this.etiqArriba.Name = "etiqArriba";
            this.etiqArriba.Size = new System.Drawing.Size(196, 13);
            this.etiqArriba.TabIndex = 6;
            this.etiqArriba.Text = "Ingrese nombre de usuario y contraseña";
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 226);
            this.Controls.Add(this.etiqArriba);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.etiqContraseña);
            this.Controls.Add(this.etiqUsuario);
            this.Name = "Ingreso";
            this.Text = "Ingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiqUsuario;
        private System.Windows.Forms.Label etiqContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label etiqArriba;
    }
}
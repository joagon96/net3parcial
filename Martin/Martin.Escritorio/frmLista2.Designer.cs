namespace Martin.Escritorio
{
    partial class frmLista2
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
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasUltimoIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimo_ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EliminarBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.DiasUltimoIngreso,
            this.clave,
            this.email,
            this.nombre_usuario,
            this.tipo_usuario,
            this.ultimo_ingreso});
            this.dgvUsuario.Location = new System.Drawing.Point(0, 1);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.Size = new System.Drawing.Size(645, 267);
            this.dgvUsuario.TabIndex = 0;
            // 
            // id_usuario
            // 
            this.id_usuario.DataPropertyName = "ID";
            this.id_usuario.HeaderText = "Usuario";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            // 
            // DiasUltimoIngreso
            // 
            this.DiasUltimoIngreso.DataPropertyName = "DiasUltimoIngreso";
            this.DiasUltimoIngreso.HeaderText = "Dias Ultimo Ingreso";
            this.DiasUltimoIngreso.Name = "DiasUltimoIngreso";
            this.DiasUltimoIngreso.ReadOnly = true;
            // 
            // clave
            // 
            this.clave.DataPropertyName = "clave";
            this.clave.HeaderText = "Clave";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.DataPropertyName = "NombreUsuario";
            this.nombre_usuario.HeaderText = "Nombre Usuario";
            this.nombre_usuario.Name = "nombre_usuario";
            this.nombre_usuario.ReadOnly = true;
            // 
            // tipo_usuario
            // 
            this.tipo_usuario.DataPropertyName = "TipoUsuario";
            this.tipo_usuario.HeaderText = "Tipo Usuario";
            this.tipo_usuario.Name = "tipo_usuario";
            this.tipo_usuario.ReadOnly = true;
            // 
            // ultimo_ingreso
            // 
            this.ultimo_ingreso.DataPropertyName = "UltimoIngreso";
            this.ultimo_ingreso.HeaderText = "Ultimo Ingreso";
            this.ultimo_ingreso.Name = "ultimo_ingreso";
            this.ultimo_ingreso.ReadOnly = true;
            // 
            // EliminarBTN
            // 
            this.EliminarBTN.Location = new System.Drawing.Point(558, 265);
            this.EliminarBTN.Name = "EliminarBTN";
            this.EliminarBTN.Size = new System.Drawing.Size(87, 31);
            this.EliminarBTN.TabIndex = 1;
            this.EliminarBTN.Text = "Eliminar";
            this.EliminarBTN.UseVisualStyleBackColor = true;
            this.EliminarBTN.Click += new System.EventHandler(this.EliminarBTN_Click);
            // 
            // frmLista2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 294);
            this.Controls.Add(this.EliminarBTN);
            this.Controls.Add(this.dgvUsuario);
            this.Name = "frmLista2";
            this.Text = "frmLista2";
            this.Load += new System.EventHandler(this.FrmLista2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasUltimoIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimo_ingreso;
        private System.Windows.Forms.Button EliminarBTN;
    }
}
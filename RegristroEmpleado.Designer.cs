namespace Permisos
{
    partial class frmregistroempleado
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
            this.lbldnir = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblfi = new System.Windows.Forms.Label();
            this.lblcargo = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.dtpfi = new System.Windows.Forms.DateTimePicker();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldnir
            // 
            this.lbldnir.AutoSize = true;
            this.lbldnir.Location = new System.Drawing.Point(53, 61);
            this.lbldnir.Name = "lbldnir";
            this.lbldnir.Size = new System.Drawing.Size(26, 13);
            this.lbldnir.TabIndex = 0;
            this.lbldnir.Text = "DNI";
            this.lbldnir.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(53, 113);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            // 
            // lblfi
            // 
            this.lblfi.AutoSize = true;
            this.lblfi.Location = new System.Drawing.Point(51, 173);
            this.lblfi.Name = "lblfi";
            this.lblfi.Size = new System.Drawing.Size(75, 13);
            this.lblfi.TabIndex = 2;
            this.lblfi.Text = "Fecha Ingreso";
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.Location = new System.Drawing.Point(53, 223);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(35, 13);
            this.lblcargo.TabIndex = 3;
            this.lblcargo.Text = "Cargo";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(131, 61);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(100, 20);
            this.txtdni.TabIndex = 4;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(131, 110);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(131, 223);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(100, 20);
            this.txtcargo.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(404, 92);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 34);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(404, 132);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 34);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(404, 173);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(87, 34);
            this.BtnLimpiar.TabIndex = 10;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(404, 213);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(87, 34);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // dtpfi
            // 
            this.dtpfi.Location = new System.Drawing.Point(132, 167);
            this.dtpfi.Name = "dtpfi";
            this.dtpfi.Size = new System.Drawing.Size(199, 20);
            this.dtpfi.TabIndex = 12;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(404, 53);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(89, 35);
            this.btnbuscar.TabIndex = 13;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // frmregistroempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(547, 538);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dtpfi);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.lblcargo);
            this.Controls.Add(this.lblfi);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lbldnir);
            this.Name = "frmregistroempleado";
            this.Text = "RegristroEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldnir;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblfi;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DateTimePicker dtpfi;
        private System.Windows.Forms.Button btnbuscar;
    }
}
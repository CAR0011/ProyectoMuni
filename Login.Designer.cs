namespace Permisos
{
    partial class frmlogin
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
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.lblusario = new System.Windows.Forms.Label();
            this.lblcontra = new System.Windows.Forms.Label();
            this.btningresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(402, 78);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 0;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(402, 164);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(100, 20);
            this.txtcontraseña.TabIndex = 1;
            // 
            // lblusario
            // 
            this.lblusario.AutoSize = true;
            this.lblusario.Location = new System.Drawing.Point(271, 85);
            this.lblusario.Name = "lblusario";
            this.lblusario.Size = new System.Drawing.Size(56, 13);
            this.lblusario.TabIndex = 2;
            this.lblusario.Text = "USUARIO";
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.Location = new System.Drawing.Point(271, 167);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(81, 13);
            this.lblcontra.TabIndex = 3;
            this.lblcontra.Text = "CONTRASEÑA";
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(364, 240);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 4;
            this.btningresar.Text = "INGRESAR";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 366);
            this.panel1.TabIndex = 5;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(462, 240);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(672, 366);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.lblcontra);
            this.Controls.Add(this.lblusario);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmlogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label lblusario;
        private System.Windows.Forms.Label lblcontra;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsalir;
    }
}
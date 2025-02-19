using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Permisos
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Sergio" || txtcontraseña.Text == "1234")
            {
                MessageBox.Show("inicio de sesion correcto");

              frmadmin llamar = new frmadmin();

                this.Hide();
                llamar.ShowDialog();
            }
                if (txtusuario.Text == "Mario" || txtcontraseña.Text == "123")
                {
                    MessageBox.Show("inicio de sesion correcto");

                    frmusuario llamar2 = new frmusuario();
                    llamar2.Show();
                    this.Hide();
                }
            else
            {
                MessageBox.Show("Usuario o contrasena incorrecta");
            }
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Permisos
{
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            InitializeComponent();

        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmlogin llamar = new frmlogin();
            this.Hide();
            llamar.ShowDialog();
        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmregistroempleado llamar = new frmregistroempleado();
            this.Hide();    
            llamar.ShowDialog();
        }

        private void solicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmusuario llamar = new frmusuario();   
            this.Hide();    
            llamar.ShowDialog();    
        }
    }
}

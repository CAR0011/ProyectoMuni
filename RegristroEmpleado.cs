using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Permisos
{
    public partial class frmregistroempleado : Form
    {
        public frmregistroempleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verifica que todos los campos estén llenos
            if (txtdni.Text == "" || txtnombre.Text == "" || txtcargo.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Cadena de conexión a MySQL (ajusta según tu configuración)
                string conexionString = "server=localhost; database=gestion_permisos; uid=root; pwd=;";

                using (MySqlConnection conexion = new MySqlConnection(conexionString))
                {
                    conexion.Open();
                    string query = "INSERT INTO empleados (dni, nombre, fecha_ingreso, cargo) VALUES (@dni, @nombre, @fecha, @cargo)";

                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        // Asigna valores de los TextBox y DateTimePicker
                        comando.Parameters.AddWithValue("@dni", txtdni.Text);
                        comando.Parameters.AddWithValue("@nombre", txtnombre.Text);
                        comando.Parameters.AddWithValue("@fecha", dtpfi.Value.ToString("yyyy-MM-dd"));
                        comando.Parameters.AddWithValue("@cargo", txtcargo.Text);

                        // Ejecuta la consulta
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Empleado guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpia los campos después de guardar
                txtdni.Clear();
                txtnombre.Clear();
                txtcargo.Clear();
                dtpfi.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Verifica que todos los campos estén llenos
            if (txtdni.Text == "" || txtnombre.Text == "" || txtcargo.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Cadena de conexión a MySQL (ajusta según tu configuración)
                string conexionString = "server=localhost; database=gestion_permisos; uid=root; pwd=;";

                using (MySqlConnection conexion = new MySqlConnection(conexionString))
                {
                    conexion.Open();
                    string query = "UPDATE empleados SET nombre = @nombre, fecha_ingreso = @fecha, cargo = @cargo WHERE dni = @dni";

                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        // Asigna valores de los TextBox y DateTimePicker
                        comando.Parameters.AddWithValue("@dni", txtdni.Text);  // Utiliza el DNI para identificar el empleado
                        comando.Parameters.AddWithValue("@nombre", txtnombre.Text);
                        comando.Parameters.AddWithValue("@fecha", dtpfi.Value.ToString("yyyy-MM-dd"));  // Asegúrate de que el formato sea adecuado
                        comando.Parameters.AddWithValue("@cargo", txtcargo.Text);

                        // Ejecuta la consulta
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Empleado actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpia los campos después de actualizar
                txtdni.Clear();
                txtnombre.Clear();
                txtcargo.Clear();
                dtpfi.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            // Verifica que el campo de DNI esté lleno
            if (txtdni.Text == "")
            {
                MessageBox.Show("Por favor, ingrese el DNI para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Cadena de conexión a MySQL (ajusta según tu configuración)
                string conexionString = "server=localhost; database=gestion_permisos; uid=root; pwd=;";

                using (MySqlConnection conexion = new MySqlConnection(conexionString))
                {
                    conexion.Open();
                    string query = "SELECT nombre, fecha_ingreso, cargo FROM empleados WHERE dni = @dni";

                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        // Asigna el valor del DNI para buscar
                        comando.Parameters.AddWithValue("@dni", txtdni.Text);

                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                // Si encuentra el empleado, llena los campos con los datos
                                txtnombre.Text = lector["nombre"].ToString();
                                dtpfi.Value = Convert.ToDateTime(lector["fecha_ingreso"]);
                                txtcargo.Text = lector["cargo"].ToString();
                            }
                            else
                            {
                                // Si no encuentra el empleado, muestra un mensaje
                                MessageBox.Show("Empleado no encontrado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtcargo.Text = " ";
            txtdni.Text = " ";
            txtnombre.Text = " ";
            dtpfi.Value = DateTime.Now;
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

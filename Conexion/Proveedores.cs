using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion
{
    public partial class Proveedores : Form
    {
        private Conectar con;
        int renglon;
        public Proveedores()
        {
            InitializeComponent();
        }

        public Proveedores(Conectar con)
        {
            this.con = con;
            InitializeComponent();
            ListarProveedores();
           
        }

        private void ListarProveedores()
        {
            con.listarResultados(dataGridView1, "BuscarProveedor");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, nombre, direccion, telefono, correo;


            id = dataGridView1.Rows[renglon].Cells["idProveedor"].Value.ToString();
            nombre = dataGridView1.Rows[renglon].Cells["nombre"].Value.ToString();
            direccion = dataGridView1.Rows[renglon].Cells["direccion"].Value.ToString();
            correo = dataGridView1.Rows[renglon].Cells["correo"].Value.ToString();
            telefono = dataGridView1.Rows[renglon].Cells["telefono"].Value.ToString();
            

            txtCodigo.Text = id;
            txtCorreo.Text = correo;
            txtDireccion.Text = direccion;
            txtNombre.Text = nombre;
            mtxtTelefono.Text = telefono;
            btnCrear.Enabled = false;
            btnEditar.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if(txtBuscar.Text.Equals(""))
            {
                MessageBox.Show("No puede quedar vacio el campo búsqueda");
                ListarProveedores();
                return;
            }

            string searchValue = txtBuscar.Text;
            con.buscarProveedor(dataGridView1, searchValue);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( txtDireccion.Text.Equals("") || txtNombre.Text.Equals("") || !esCorreoValido() || mtxtTelefono.Text.Length < 8)
            {
                MessageBox.Show("Campos incompletos/incorrectos, verifique y vuelva a intentarlo ");
                return;
            }

            if (con.insertarProveedor( txtNombre.Text, txtDireccion.Text, txtCorreo.Text, mtxtTelefono.Text))
            {
                MessageBox.Show("Datos insertados correctamente.");
                vaciarCampos();
                ListarProveedores();
            }

        }
        private bool esCorreoValido()
        {
            String correo = txtCorreo.Text;
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, expresion))
            {
                if (Regex.Replace(correo, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void vaciarCampos()
        {
            txtCodigo.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            mtxtTelefono.Text = "";
            btnCrear.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            con.editarProveedor(dataGridView1, int.Parse(txtCodigo.Text), txtNombre.Text, txtDireccion.Text, txtCorreo.Text, mtxtTelefono.Text, 1);
            vaciarCampos();
            btnCrear.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vaciarCampos();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                if (rowIndex == -1)
                {
                    MessageBox.Show("Seleccione un registro para eliminar");
                    return;
                }
                int id = int.Parse(dataGridView1.Rows[rowIndex].Cells["idProveedor"].Value.ToString());
                con.editarProveedor(dataGridView1, int.Parse(txtCodigo.Text), txtNombre.Text, txtDireccion.Text, txtCorreo.Text, mtxtTelefono.Text, 0);
                vaciarCampos();
                btnCrear.Enabled = true;
                btnEditar.Enabled = false;

                ListarProveedores();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

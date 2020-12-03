using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion
{
    public partial class Productos : Form
    {
        private Conectar con;
        int renglon;

        public Productos(Conectar con)
        {
            this.con = con;
            InitializeComponent();
            con.listarResultados(dgvProductos, "BuscarProducto");
   
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                con.insertarProducto(int.Parse(txtIdCategoria.Text),int.Parse(txtIdProveedor.Text), txtNombre.Text, int.Parse(txtExistencia.Text), float.Parse(txtPrecio.Text));
                con.listarResultados(dgvProductos, "BuscarProducto");
                vaciarCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           con.editarProducto(dgvProductos, int.Parse(txtCodigo.Text), int.Parse(txtIdCategoria.Text), int.Parse(txtIdProveedor.Text), txtNombre.Text, int.Parse(txtExistencia.Text), float.Parse(txtPrecio.Text));
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            vaciarCampos();
        }

        private void vaciarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            
            txtExistencia.Text = "";
            txtIdProveedor.Text = "";
            txtIdCategoria.Text = "";
            txtPrecio.Text = "";
            btnCrear.Enabled = true;
            btnEditar.Enabled = false;
        }
        
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void dgvProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtCodigo.Text = dgvProductos.Rows[renglon].Cells["idProducto"].Value.ToString();
            txtIdCategoria.Text = dgvProductos.Rows[renglon].Cells["idCategoria"].Value.ToString();
            txtNombre.Text = dgvProductos.Rows[renglon].Cells["nombre"].Value.ToString();
            txtIdProveedor.Text = dgvProductos.Rows[renglon].Cells["idProveedor"].Value.ToString();
            txtExistencia.Text = dgvProductos.Rows[renglon].Cells["cantidad"].Value.ToString();
            
            
            txtPrecio.Text = dgvProductos.Rows[renglon].Cells["precio"].Value.ToString();
            btnCrear.Enabled = false;
            btnEditar.Enabled = true;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscar.Text == "")
            {
                con.listarResultados(dgvProductos, "BuscarProducto");
            }
            else
            {
                con.buscarProducto(dgvProductos, txtBuscar.Text);
            }
        }
    }
}

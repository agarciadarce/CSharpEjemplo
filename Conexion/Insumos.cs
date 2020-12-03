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
    public partial class Insumos : Form
    {
        private Conectar con;
        int renglon;

        public Insumos(Conectar con)
        {
            this.con = con;
            InitializeComponent();
            con.listarResultados(dgvInsumos, "BuscarInsumo");
   
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                con.insertarInsumo(int.Parse(txtIdCategoria.Text),int.Parse(txtIdProveedor.Text), txtNombre.Text, int.Parse(txtExistencia.Text), float.Parse(txtPrecio.Text));
                con.listarResultados(dgvInsumos, "BuscarInsumo");
                vaciarCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           con.editarInsumo(dgvInsumos, int.Parse(txtCodigo.Text), int.Parse(txtIdCategoria.Text), int.Parse(txtIdProveedor.Text), txtNombre.Text, int.Parse(txtExistencia.Text), float.Parse(txtPrecio.Text));
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
            txtCodigo.Text = dgvInsumos.Rows[renglon].Cells["idInsumo"].Value.ToString();
            txtIdCategoria.Text = dgvInsumos.Rows[renglon].Cells["idCategoria"].Value.ToString();
            txtNombre.Text = dgvInsumos.Rows[renglon].Cells["nombre"].Value.ToString();
            txtIdProveedor.Text = dgvInsumos.Rows[renglon].Cells["idProveedor"].Value.ToString();
            txtExistencia.Text = dgvInsumos.Rows[renglon].Cells["cantidad"].Value.ToString();
            
            
            txtPrecio.Text = dgvInsumos.Rows[renglon].Cells["precio"].Value.ToString();
            btnCrear.Enabled = false;
            btnEditar.Enabled = true;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscar.Text == "")
            {
                con.listarResultados(dgvInsumos, "BuscarInsumo");
            }
            else
            {
                con.buscarInsumo(dgvInsumos, txtBuscar.Text);
            }
        }
    }
}

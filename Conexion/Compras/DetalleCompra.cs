using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion.Compras
{
    public partial class DetalleCompra : Form
    {
        private int idCompra;
        private Conectar con;

        public DetalleCompra(int idCompra, Conectar con)
        {
            InitializeComponent();
            this.idCompra = idCompra;
            txtIdCompra2.Text = idCompra + "";
            this.con = con;
            con.buscarDetalleCompra(dgvDetCompraInsumo, "listaDetalleCompraInsumo", idCompra);
            con.buscarDetalleCompra(dgvDetCompraProducto, "listaDetalleCompraProducto", idCompra);
            actualizarTotal();
            limpiarDatos();
        }

        private void actualizarTotal()
        {
            double total = Math.Round(con.obtenerTotalCompra(idCompra), 2);
            totalValue.Text = total + "";
            ivaValue.Text = Math.Round(total * 0.15, 2) + "";
            totalConIvaValue.Text = Math.Round(total * 1.15, 2) + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void btnCrear2_Click(object sender, EventArgs e)
        {
            con.insertarDetalleCompra(idCompra, int.Parse(txtCodigo.Text), int.Parse(txtCantidad.Text), float.Parse(txtDescuento.Text), float.Parse(txtPrecio.Text), "CrearDetalleCompraInsumo");
            con.buscarDetalleCompra(dgvDetCompraInsumo, "listaDetalleCompraInsumo", idCompra);
            actualizarTotal();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            con.insertarDetalleCompra(idCompra, int.Parse(txtCodigo.Text), int.Parse(txtCantidad.Text), float.Parse(txtDescuento.Text), float.Parse(txtPrecio.Text), "CrearDetalleCompraProducto");
            con.buscarDetalleCompra(dgvDetCompraProducto, "listaDetalleCompraProducto", idCompra);
            actualizarTotal();
        }
        
        private void dgvDetCompraInsumo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        int renglonProducto;
        private void dgvDetCompraProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvDetCompraInsumo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int renglonInsumo = dgvDetCompraInsumo.SelectedRows[0].Index;
                int idDetalle = int.Parse(dgvDetCompraInsumo.Rows[renglonInsumo].Cells["idDetalle"].Value.ToString());
                int idInsumo = int.Parse(dgvDetCompraInsumo.Rows[renglonInsumo].Cells["idInsumo"].Value.ToString());
                int cantidad = int.Parse(dgvDetCompraInsumo.Rows[renglonInsumo].Cells["cantidad"].Value.ToString());
                float precio = int.Parse(dgvDetCompraInsumo.Rows[renglonInsumo].Cells["precio"].Value.ToString());
                float descuento = float.Parse(dgvDetCompraInsumo.Rows[renglonInsumo].Cells["descuento"].Value.ToString());

                lIdDetalle.Text = idDetalle.ToString();
                txtCodigo.Text = idInsumo.ToString();
                txtCantidad.Text = cantidad.ToString();
                txtDescuento.Text = Math.Round(descuento, 2).ToString();
                txtPrecio.Text = Math.Round(precio, 2).ToString();

                btnEditarInsumo.Enabled = true;
                btnEditarProducto.Enabled = false;
                btnNuevoInsumo.Enabled = false;
                btnNuevoProducto.Enabled = false;
                btnDevolverI.Enabled = true;
                btnDevolverP.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una fila primero");
            }

        }

        private void btnEditarInsumo_Click(object sender, EventArgs e)
        {
            con.editarDetalleCompra(int.Parse(lIdDetalle.Text), int.Parse(txtCantidad.Text), float.Parse(txtDescuento.Text), float.Parse(txtPrecio.Text), 2, "EditarDetalleCompraInsumo");
            con.buscarDetalleCompra(dgvDetCompraInsumo, "listaDetalleCompraInsumo", idCompra);
            limpiarDatos();
            actualizarTotal();

        }

        private void dgvDetCompraProducto_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int renglonProducto = dgvDetCompraProducto.SelectedRows[0].Index;
            
            
                int idDetalle = int.Parse(dgvDetCompraProducto.Rows[renglonProducto].Cells["idDetalle"].Value.ToString());
                int idProducto= int.Parse(dgvDetCompraProducto.Rows[renglonProducto].Cells["idProducto"].Value.ToString());
                int cantidad = int.Parse(dgvDetCompraProducto.Rows[renglonProducto].Cells["cantidad"].Value.ToString());
                float precio = int.Parse(dgvDetCompraProducto.Rows[renglonProducto].Cells["precio"].Value.ToString());
                float descuento = float.Parse(dgvDetCompraProducto.Rows[renglonProducto].Cells["descuento"].Value.ToString());

                lIdDetalle.Text = idDetalle.ToString();
                txtCodigo.Text = idProducto.ToString();
                txtCantidad.Text = cantidad.ToString();
                txtDescuento.Text = Math.Round(descuento, 2).ToString();
                txtPrecio.Text = Math.Round(precio, 2).ToString();

                btnEditarInsumo.Enabled = false;
                btnEditarProducto.Enabled = true;
                btnNuevoInsumo.Enabled = false;
                btnNuevoProducto.Enabled = false;
                btnDevolverI.Enabled = false;
                btnDevolverP.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una fila primero");
            }
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            con.editarDetalleCompra(int.Parse(lIdDetalle.Text), int.Parse(txtCantidad.Text), float.Parse(txtDescuento.Text), float.Parse(txtPrecio.Text), 2, "EditarDetalleCompraProducto");
            con.buscarDetalleCompra(dgvDetCompraProducto, "listaDetalleCompraProducto", idCompra);
            limpiarDatos();
            actualizarTotal();

        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            con.editarDetalleCompra(int.Parse(lIdDetalle.Text), int.Parse(txtCantidad.Text), float.Parse(txtDescuento.Text), float.Parse(txtPrecio.Text), 1 , "EditarDetalleCompraProducto");
            con.buscarDetalleCompra(dgvDetCompraProducto, "listaDetalleCompraProducto", idCompra);
            limpiarDatos();
            actualizarTotal();
        }

        private void btnDevolverI_Click(object sender, EventArgs e)
        {
            con.editarDetalleCompra(int.Parse(lIdDetalle.Text), int.Parse(txtCantidad.Text), float.Parse(txtDescuento.Text), float.Parse(txtPrecio.Text), 1, "EditarDetalleCompraInsumo");
            con.buscarDetalleCompra(dgvDetCompraInsumo, "listaDetalleCompraInsumo", idCompra);
            limpiarDatos();
            actualizarTotal();
        }
        private void limpiarDatos()
        {
            btnEditarInsumo.Enabled = false;
            btnEditarProducto.Enabled = false;
            btnNuevoInsumo.Enabled = true;
            btnNuevoProducto.Enabled = true;
            btnDevolverI.Enabled = false;
            btnDevolverP.Enabled = false;
            lIdDetalle.Text = "#_";
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtDescuento.Text = "";
            txtPrecio.Text = "";
        }
    }
}

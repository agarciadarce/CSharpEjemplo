using System;
using System.Windows.Forms;

namespace Conexion
{
    public partial class Ventas : Form
    {
        private Conectar con;

        int renglon;
        public Ventas(Conectar con)
        {
            this.con = con;
            InitializeComponent();
            con.listarResultados(dgvVentas, "BuscarVenta");
            txtIdVenta.Enabled = false;
            btnEditar.Enabled = false;
            btnEditar2.Enabled = false;
            btnDevolver.Enabled = false;
            txtIdDetalle.Enabled = false;
           
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            con.insertarVenta(int.Parse(txtIdEmpleado.Text), txtNombre.Text);
            con.listarResultados(dgvVentas, "BuscarVenta");
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtIdVenta.Text = "";
            txtIdEmpleado.Text = "";
            txtNombre.Text = "";
            btnCrear.Enabled = true;
            btnEditar.Enabled = fals;
        }

        private void btnCrear2_Click(object sender, EventArgs e)
        {
            con.insertarDetalleVenta(int.Parse(txtIdVenta.Text), int.Parse(txtIdProducto.Text), int.Parse(txtCantVendida.Text), float.Parse(txtDescuento.Text));
            con.buscarDetalleVenta(dgvDetalleVenta, int.Parse(txtIdVenta.Text));
            con.listarResultados(dgvVentas, "BuscarVenta");
            limpiarCampos2();
        }
        private void limpiarCampos2()
        {
            txtIdProducto.Text = "";
            txtCantVendida.Text = "";
            txtDescuento.Text = "";
            txtIdDetalle.Text = "";
            btnCrear2.Enabled = true;
            btnEditar.Enabled = false;
            btnDevolver.Enabled = false;
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnVaciar2_Click(object sender, EventArgs e)
        {
            con.editarDetalleVenta(dgvDetalleVenta, int.Parse(txtIdDetalle.Text), int.Parse(txtCantVendida.Text), float.Parse(txtDescuento.Text), 1);
            limpiarCampos2();
            con.listarResultados(dgvVentas, "BuscarVenta");
            con.buscarDetalleVenta(dgvDetalleVenta, int.Parse(txtIdVenta.Text));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            con.editarVenta(dgvVentas, int.Parse(txtIdVenta.Text), int.Parse(txtIdEmpleado.Text), txtNombre.Text);
            limpiarCampos();

        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void dgvVentas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtIdVenta.Text = dgvVentas.Rows[renglon].Cells["idVenta"].Value.ToString();
            txtNombre.Text = dgvVentas.Rows[renglon].Cells["nombre"].Value.ToString();
            txtIdEmpleado.Text = dgvVentas.Rows[renglon].Cells["idEmpleado"].Value.ToString();
            btnCrear.Enabled = false;
            btnEditar.Enabled = true;

            con.buscarDetalleVenta(dgvDetalleVenta, int.Parse(txtIdVenta.Text));


        }
        int renglonDv;
        private void dgvDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglonDv = e.RowIndex;
        }

        private void dgvDetalleVenta_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtIdDetalle.Text = dgvDetalleVenta.Rows[renglonDv].Cells["idDetalle"].Value.ToString();
            txtIdProducto.Text = dgvDetalleVenta.Rows[renglonDv].Cells["idProducto"].Value.ToString();
            txtCantVendida.Text = dgvDetalleVenta.Rows[renglonDv].Cells["cantidad"].Value.ToString();
            txtDescuento.Text = dgvDetalleVenta.Rows[renglonDv].Cells["descuento"].Value.ToString();

            btnCrear2.Enabled = false;
            btnEditar2.Enabled = true;
            btnDevolver.Enabled = true;

        }

        private void btnEditar2_Click(object sender, EventArgs e)
        {
            con.editarDetalleVenta(dgvDetalleVenta, int.Parse(txtIdDetalle.Text), int.Parse(txtCantVendida.Text), float.Parse(txtDescuento.Text), 2);
            limpiarCampos2();
            con.listarResultados(dgvVentas, "BuscarVenta");
            con.buscarDetalleVenta(dgvDetalleVenta, int.Parse(txtIdVenta.Text));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarCampos2();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscar.Text == "")
            {
                con.listarResultados(dgvVentas, "BuscarVenta");
            }
            else
            {
                try
                {
                    con.buscarVenta(dgvVentas, int.Parse(txtBuscar.Text));
                }
                catch (Exception)
                {
                    con.listarResultados(dgvVentas, "BuscarVenta");
                }
                
            }
        }

       

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCantVendida_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

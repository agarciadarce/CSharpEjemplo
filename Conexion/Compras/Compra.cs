using Conexion.Compras;
using System;
using System.Windows.Forms;

namespace Conexion
{
    public partial class Compra : Form
    {
        private Conectar con;

        int renglon;
        public Compra(Conectar con)
        {
            this.con = con;
            InitializeComponent();
            con.listarResultados(dgvCompras, "BuscarCompra");
            txtIdCompra.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            con.insertarCompra(int.Parse(txtIdEmpleado.Text), int.Parse(txtIdProv.Text));
            con.listarResultados(dgvCompras, "BuscarCompra");
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtIdCompra.Text = "";
            txtIdProv.Text = "";
            txtIdEmpleado.Text = "";
            btnCrear.Enabled = true;
            btnEditar.Enabled = false;
        }

        
        private void limpiarCampos2()
        {
            
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

       

        private void btnEditar_Click(object sender, EventArgs e)
        {
            con.editarCompra(dgvCompras, int.Parse(txtIdCompra.Text), int.Parse(txtIdEmpleado.Text), int.Parse(txtIdProv.Text));
            limpiarCampos();

        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void dgvVentas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int IdCompra = int.Parse(dgvCompras.Rows[renglon].Cells["idCompra"].Value.ToString());
            DetalleCompra dc = new DetalleCompra(IdCompra, con);
          
            dc.Show();
           
        }
        int renglonDv;
 
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscar.Text == "")
            {
                con.listarResultados(dgvCompras, "BuscarCompra");
            }
            else
            {
                try
                {
                    con.buscarCompra(dgvCompras, txtBuscar.Text);
                }
                catch (Exception)
                {
                    con.listarResultados(dgvCompras, "BuscarCompra");
                }
                
            }
        }

        private void dgvCompras_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdCompra.Text = dgvCompras.Rows[renglon].Cells["idCompra"].Value.ToString();
            txtIdProv.Text = dgvCompras.Rows[renglon].Cells["idProveedor"].Value.ToString();
            txtIdEmpleado.Text = dgvCompras.Rows[renglon].Cells["idEmpleado"].Value.ToString();
            btnCrear.Enabled = false;
            btnEditar.Enabled = true;
        }
    }
}

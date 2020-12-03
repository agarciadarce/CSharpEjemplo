using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion.Catalogo
{
    public partial class Puestos : Form
    {
        private Conectar con;

        public Puestos(Conectar con)
        {
            this.con = con;
            InitializeComponent();
            btnEditar.Enabled = false;
            con.listarResultados(dgvPuestos, "BuscarPuestos");

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                con.insertarPuesto(txtNombre.Text, float.Parse(txtSalario.Text));
                con.listarResultados(dgvPuestos, "BuscarPuestos");
                limpiarDatos();
            }
            catch (Exception)
            {
                limpiarDatos();
            }
            
        }
        private void limpiarDatos()
        {
            txtNombre.Text = "";
            txtId.Text = "";
            txtSalario.Text = "";
            btnEditar.Enabled = false;
            btnCrear.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            con.editarPuesto(dgvPuestos, int.Parse(txtId.Text), txtNombre.Text, float.Parse(txtSalario.Text));
            con.listarResultados(dgvPuestos, "BuscarPuestos");
            limpiarDatos();
        }
        int renglon;
        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void dgvCompras_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtId.Text  = dgvPuestos.Rows[renglon].Cells["idPuesto"].Value.ToString();
            txtNombre.Text  = dgvPuestos.Rows[renglon].Cells["nombre"].Value.ToString();
            txtSalario.Text = dgvPuestos.Rows[renglon].Cells["salario"].Value.ToString();
            btnEditar.Enabled = true;
            btnCrear.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            con.buscarPuesto(dgvPuestos, txtBuscar.Text);
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }
    }
}

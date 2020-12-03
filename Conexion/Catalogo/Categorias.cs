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
    public partial class Categorias : Form
    {
        private Conectar con;

        public Categorias(Conectar con)
        {
            
            this.con = con;
            InitializeComponent();
            con.listarResultados(dgvCategoriaInsumo, "BuscarCategoriaInsu");
            con.listarResultados(dgvCategoriaProducto, "BuscarCategoriaPro");
            btnEditarCategoriaInsumo.Enabled = false;
            btnEditarCategoriaProducto.Enabled = false;
        }

        private void Categorias_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarCategoriaInsumo_Click(object sender, EventArgs e)
        {
            con.insertarCategoriaInsumo(txtNombreCategoriaInsumo.Text);
            con.listarResultados(dgvCategoriaInsumo, "BuscarCategoriaInsu");
            limpiarCampos();
        }

        private void btnAgregarCategoriaProducto_Click(object sender, EventArgs e)
        {
            con.insertarCategoriaProducto(txtNombreCategoriaProducto.Text);
            con.listarResultados(dgvCategoriaProducto, "BuscarCategoriaPro");
            limpiarCampos2();
        }
        int renglonCInsumo;
        private void dgvCategoriaInsumo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            renglonCInsumo = e.RowIndex;
        }
        int renglonCProducto;
        private void dgvCategoriaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            renglonCProducto = e.RowIndex;
        }

        private void dgvCategoriaInsumo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtIdCategoriaInsumo.Text = dgvCategoriaInsumo.Rows[renglonCInsumo].Cells["idCategoria"].Value.ToString();
            txtNombreCategoriaInsumo.Text = dgvCategoriaInsumo.Rows[renglonCInsumo].Cells["nombre"].Value.ToString();

            btnEditarCategoriaInsumo.Enabled = true;
            btnAgregarCategoriaInsumo.Enabled = false;

        }
        private void limpiarCampos()
        {
            txtIdCategoriaInsumo.Text = "";
            txtNombreCategoriaInsumo.Text = "";
            btnEditarCategoriaInsumo.Enabled = false;
            btnAgregarCategoriaInsumo.Enabled = true;
        }
        private void limpiarCampos2()
        {
            txtIdCategoriaProducto.Text = "";
            txtNombreCategoriaProducto.Text = "";
            btnEditarCategoriaProducto.Enabled = false;
            btnAgregarCategoriaProducto.Enabled = true;
        }

        private void dgvCategoriaProducto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtIdCategoriaProducto.Text = dgvCategoriaProducto.Rows[renglonCProducto].Cells["idCategoria"].Value.ToString();
            txtNombreCategoriaProducto.Text = dgvCategoriaProducto.Rows[renglonCProducto].Cells["nombre"].Value.ToString();

            btnEditarCategoriaProducto.Enabled = true;
            btnAgregarCategoriaProducto.Enabled = false;
        }

        private void btnEditarCategoriaProducto_Click(object sender, EventArgs e)
        {
            con.editarCategoriaProducto(dgvCategoriaProducto, int.Parse(txtIdCategoriaProducto.Text), txtNombreCategoriaProducto.Text);
            limpiarCampos2();
        }

        private void btnEditarCategoriaInsumo_Click(object sender, EventArgs e)
        {

            con.editarCategoriaInsumo(dgvCategoriaInsumo, int.Parse(txtIdCategoriaInsumo.Text), txtNombreCategoriaInsumo.Text);
            limpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            limpiarCampos2();
        }

        private void BtnBuscarCategoriaInsumo_Click(object sender, EventArgs e)
        {
            con.buscarCategoriaInsumo(dgvCategoriaInsumo, txtBuscarCategoriaInsumo.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.buscarCategoriaProducto(dgvCategoriaInsumo, txtBuscarCategoriaProducto.Text);
        }
    }
}

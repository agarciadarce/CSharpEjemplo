using Conexion.Catalogo;
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
    public partial class Inicio : Form
    {
        public Conectar con;

        public Inicio()
        {
            InitializeComponent();
        }

        public Inicio(Conectar con)
        {
            this.con = con;
            InitializeComponent();

        }

        
        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores cli = new Proveedores(con);
            cli.MdiParent = this;
            
            cli.Show();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos(con);
            productos.MdiParent = this;
            productos.Show();
        }

        private void ventasDetalleVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas(con);
            ventas.MdiParent = this;
            ventas.Show();
        }

        private void comrpasDetalleComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra compras = new Compra(con);
            compras.MdiParent = this;
            compras.Show();
        }

        private void devolucionesDetalleDevolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorias categoria= new Categorias(con);
            categoria.MdiParent = this;
            categoria.Show();
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Puestos puestos = new Puestos(con);
            puestos.MdiParent = this;
            puestos.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores(con);
            proveedores.MdiParent = this;
            proveedores.Show();
        }

        private void productosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos(con);
            productos.MdiParent = this;
            productos.Show();
        }

        private void insumosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Insumos insumos = new Insumos(con);
            insumos.MdiParent = this;
            insumos.Show();
        }
    }
}

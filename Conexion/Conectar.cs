using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Conexion
{
    public class Conectar
    {

        public SqlConnection connect = new SqlConnection();

        public Conectar(String user, String pass)
        {
            try
            {

                connect = new SqlConnection("Server=DESKTOP-H4QT4HV;Database=CCS;UID=" + user + ";PWD=" + pass);
                connect.Open();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }

        public void listarResultados(DataGridView GridView1, String procedimiento)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@q", SqlDbType.NVarChar, 30);
                param[0].Value = "";

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedimiento;
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para ver.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        
        //****************Proveedor**********************
        public void buscarProveedor(DataGridView GridView1, String q)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@q", SqlDbType.NVarChar, 50);
                param[0].Value = q;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BuscarProveedor";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para buscar.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        public void editarProveedor(DataGridView GridView1, int idProveedor, string nombre, String direccion, String correo, String telefono, int activo)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[6];
                param[0] = new SqlParameter("@idProveedor", SqlDbType.Int);
                param[0].Value = idProveedor;
                param[1] = new SqlParameter("@nombre", SqlDbType.NVarChar, 50);
                param[1].Value = nombre;
                param[2] = new SqlParameter("@direccion", SqlDbType.NVarChar, 150);
                param[2].Value = direccion;
                param[3] = new SqlParameter("@correo", SqlDbType.NVarChar, 20);
                param[3].Value = correo;
                param[4] = new SqlParameter("@telefono", SqlDbType.NVarChar, 8);
                param[4].Value = telefono;
                param[5] = new SqlParameter("@activo", SqlDbType.Bit);
                param[5].Value = activo;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EditarProveedor";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                mostrarMensaje(ds);
                listarResultados(GridView1, "BuscarProveedor");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para editar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public bool insertarProveedor(String nombre, String direccion,  String correo, String telefono)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@nombre", SqlDbType.NVarChar, 50);
                param[0].Value = nombre;
                param[1] = new SqlParameter("@direccion", SqlDbType.Char, 150);
                param[1].Value = direccion;
                param[2] = new SqlParameter("@correo", SqlDbType.NVarChar, 20);
                param[2].Value = correo;
                param[3] = new SqlParameter("@telefono", SqlDbType.NVarChar, 8);
                param[3].Value = telefono;
                param[4] = new SqlParameter("@activo", SqlDbType.Bit);
                param[4].Value = 1;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CrearProveedor";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
                mostrarMensaje(ds);
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para insertar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }

                return false;
            }


        }

     

        //********************Producto*********************
        public bool insertarProducto(int idCategoria, int idProveedor, string nombre, int cantidad, float precio)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[5];

                param[0] = new SqlParameter("@idCategoria", SqlDbType.Int);
                param[0].Value = idCategoria;
                param[1] = new SqlParameter("@idProveedor ", SqlDbType.Int);
                param[1].Value = idProveedor;
                param[2] = new SqlParameter("@nombre", SqlDbType.NVarChar, 50);
                param[2].Value = nombre;
                param[3] = new SqlParameter("@cantidad", SqlDbType.Int);
                param[3].Value = cantidad;
                param[4] = new SqlParameter("@precio", SqlDbType.Float);
                param[4].Value = precio;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CrearProducto";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                mostrarMensaje(ds);
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para insertar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }

                return false;
            }


        }

        private void mostrarMensaje(DataSet ds)
        {
            try
            {
               
                var mensaje = ds.Tables[0].Rows[0].ItemArray[0].ToString();

                MessageBox.Show(mensaje);
            }
            catch (Exception)
            {

            }
         
        }

        public void editarProducto(DataGridView GridView1, int idProducto ,int idCategoria, int idProveedor, string nombre, int cantidad, float precio)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[6];
                param[0] = new SqlParameter("@idProducto", SqlDbType.Int);
                param[0].Value = idProducto;
                param[1] = new SqlParameter("@idCategoria", SqlDbType.Int);
                param[1].Value = idCategoria;
                param[2] = new SqlParameter("@idProveedor", SqlDbType.Int);
                param[2].Value = idProveedor;
                param[3] = new SqlParameter("@nombre", SqlDbType.NVarChar, 50);
                param[3].Value = nombre;
                param[4] = new SqlParameter("@cantidad", SqlDbType.Int);
                param[4].Value = cantidad;
                param[5] = new SqlParameter("@precio", SqlDbType.Float);
                param[5].Value = precio;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EditarProducto";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                mostrarMensaje(ds);
                listarResultados(GridView1, "BuscarProducto");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para editar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void buscarProducto(DataGridView GridView1, String q)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@q", SqlDbType.NVarChar, 50);
                param[0].Value = q;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BuscarProducto";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para buscar.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        //******************Ventas y Detalle de Venta*****************

        public bool insertarVenta(int idEmpleado, string nombre)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@idEmpleado", SqlDbType.Int);
                param[0].Value = idEmpleado;
                param[1] = new SqlParameter("@nombre", SqlDbType.NVarChar, 50);
                param[1].Value = nombre;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CrearVenta";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                mostrarMensaje(ds);
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para insertar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }

                return false;
            }


        }
        
        public void editarVenta(DataGridView GridView1, int idVenta, int idEmpleado, string nombre)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@idVenta", SqlDbType.Int);
                param[0].Value = idVenta;
                param[1] = new SqlParameter("@idEmpleado", SqlDbType.Int);
                param[1].Value = idEmpleado;
                param[2] = new SqlParameter("@nombre", SqlDbType.NVarChar,50);
                param[2].Value = nombre;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EditarVenta";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                mostrarMensaje(ds);
                listarResultados(GridView1, "BuscarVenta");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para editar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void buscarVenta(DataGridView GridView1, int q)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@q", SqlDbType.Int);
                param[0].Value = q;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BuscarVenta";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para buscar.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        public bool insertarDetalleVenta(int idVenta, int idProducto, int cantidad, float descuento)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[4];

                param[0] = new SqlParameter("@idVenta", SqlDbType.Int);
                param[0].Value = idVenta;
                param[1] = new SqlParameter("@idProducto", SqlDbType.Int);
                param[1].Value = idProducto;
                param[2] = new SqlParameter("@cantidad", SqlDbType.Int);
                param[2].Value = cantidad;
                param[3] = new SqlParameter("@descuento", SqlDbType.Float);
                param[3].Value = descuento;


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CrearDetalleVenta";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                mostrarMensaje(ds);
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para insertar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }

                return false;
            }


        }

        public void editarDetalleVenta(DataGridView GridView1, int idDetalle, int  cantidad, float descuento, int accion )
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@idDetalle", SqlDbType.Int);
                param[0].Value = idDetalle;
                param[1] = new SqlParameter("@cantidad", SqlDbType.Int);
                param[1].Value = cantidad;
                param[2] = new SqlParameter("@descuento", SqlDbType.Float);
                param[2].Value = descuento;
                param[3] = new SqlParameter("@accion", SqlDbType.Int);
                param[3].Value = accion;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EditarDetalleVenta";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                mostrarMensaje(ds);
                listarResultados(GridView1, "BuscarDetalleVenta");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para editar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void buscarDetalleVenta(DataGridView GridView1, int q)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@q", SqlDbType.Int);
                param[0].Value = q;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BuscarDetalleVenta";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para buscar.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }


        //****************** Compras **********************


        public bool insertarCompra(int idEmpleado, int idProveedor)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("idEmpleado", SqlDbType.Int);
                param[0].Value = idEmpleado;
                param[1] = new SqlParameter("@idProveedor", SqlDbType.Int);
                param[1].Value = idProveedor;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CrearCompras";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                mostrarMensaje(ds);
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para insertar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }

                return false;
            }


        }

        public void editarCompra(DataGridView GridView1, int IdCompra, int idEmpleado, int idProveedor)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@idCompra", SqlDbType.Int);
                param[0].Value = IdCompra;
                param[1] = new SqlParameter("@idEmpleado", SqlDbType.Int);
                param[1].Value = idEmpleado;
                param[2] = new SqlParameter("@idProveedor", SqlDbType.Int);
                param[2].Value = idProveedor;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EditarCompras";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                mostrarMensaje(ds);
                listarResultados(GridView1, "BuscarCompra");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para editar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void buscarCompra(DataGridView GridView1, string q)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@q", SqlDbType.Int);
                param[0].Value = q;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BuscarCompra";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para buscar.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        public double obtenerTotalCompra(int idCompra)
        {
            double total = -1; 
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idCompra", SqlDbType.Int);
                param[0].Value = idCompra;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DatosCompra";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

               total = double.Parse(dt.Rows[0].ItemArray[3].ToString());
                

            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para buscar.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return total;

        }


        public bool insertarDetalleCompra(int IdCompra, int idInsumoProducto, int cantidad, float descuento, float precio, string procedimiento)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[5];

                param[0] = new SqlParameter("@idCompra", SqlDbType.Int);
                param[0].Value = IdCompra;
                param[1] = new SqlParameter("@idInsumoProducto", SqlDbType.Int);
                param[1].Value = idInsumoProducto;
                param[2] = new SqlParameter("@cantidad", SqlDbType.Int);
                param[2].Value = cantidad;
                param[3] = new SqlParameter("@descuento", SqlDbType.Float);
                param[3].Value = descuento;
                param[4] = new SqlParameter("@precio", SqlDbType.Float);
                param[4].Value = precio;


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedimiento;
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                mostrarMensaje(ds);
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para insertar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }

                return false;
            }


        }

        public void editarDetalleCompra(int idDetallle, int nuevaCantidad, float descuento , float precio, int accion, string procedimiento)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@idDetalle", SqlDbType.Int);
                param[0].Value = idDetallle;
                param[1] = new SqlParameter("@cantidad", SqlDbType.Int);
                param[1].Value = nuevaCantidad;
                param[2] = new SqlParameter("@descuento", SqlDbType.Float);
                param[2].Value = descuento;
                param[3] = new SqlParameter("@precio", SqlDbType.Float);
                param[3].Value = precio;
                param[4] = new SqlParameter("@accion", SqlDbType.Int);
                param[4].Value = accion;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedimiento;
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                mostrarMensaje(ds);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para editar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void buscarDetalleCompra(DataGridView GridView1, string nombre, int q)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@idCompra", SqlDbType.Int);
                param[0].Value = q;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombre;
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para buscar.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        //****************** Categoria Insumo ***************************/
        public bool insertarCategoriaInsumo(string nombre)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@nombre", SqlDbType.NVarChar, 50);
                param[0].Value = nombre;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CrearCategoriaInsu";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                mostrarMensaje(ds);
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para insertar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }

                return false;
            }


        }

        public void editarCategoriaInsumo(DataGridView GridView1, int idCategoria, string nombre)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@idCategoria", SqlDbType.Int);
                param[0].Value = idCategoria;
                param[1] = new SqlParameter("@nombre", SqlDbType.NVarChar, 50);
                param[1].Value = nombre;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EditarCategoriaInsu";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                mostrarMensaje(ds);
                listarResultados(GridView1, "BuscarCategoriaInsu");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para editar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void buscarCategoriaInsumo(DataGridView GridView1, string q)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@q", SqlDbType.NVarChar, 50);
                param[0].Value = q;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BuscarCategoriaInsu";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para buscar.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        //****************** Categoria Producto ***************************/
        public bool insertarCategoriaProducto(string nombre)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@nombre", SqlDbType.NVarChar, 50);
                param[0].Value = nombre;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CrearCategoriaPro";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                mostrarMensaje(ds);
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para insertar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }

                return false;
            }


        }

        public void editarCategoriaProducto(DataGridView GridView1, int idCategoria, string nombre)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@idCategoria", SqlDbType.Int);
                param[0].Value = idCategoria;
                param[1] = new SqlParameter("@nombre", SqlDbType.NVarChar, 50);
                param[1].Value = nombre;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EditarCategoriaPro";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                mostrarMensaje(ds);
                listarResultados(GridView1, "BuscarCategoriaPro");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para editar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void buscarCategoriaProducto(DataGridView GridView1, string q)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@q", SqlDbType.NVarChar, 50);
                param[0].Value = q;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BuscarCategoriaPro";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para buscar.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }


        //************************** Puestos *****************************/

        public bool insertarPuesto(string nombre, float salario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@nombre", SqlDbType.NVarChar, 50);
                param[0].Value = nombre;
                param[1] = new SqlParameter("@salario", SqlDbType.Float);
                param[1].Value = salario;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CrearPuesto";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                mostrarMensaje(ds);
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para insertar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }

                return false;
            }


        }
        public void editarPuesto(DataGridView GridView1, int idPuesto, string nombre, float salario)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@idPuesto", SqlDbType.Int);
                param[0].Value = idPuesto;
                param[1] = new SqlParameter("@nombre", SqlDbType.NVarChar, 50);
                param[1].Value = nombre;
                param[2] = new SqlParameter("@salario", SqlDbType.Float);
                param[2].Value = salario;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EditarPuesto";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                mostrarMensaje(ds);
                listarResultados(GridView1, "BuscarPuestos");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para editar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void buscarPuesto(DataGridView GridView1, string q)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@q", SqlDbType.NVarChar, 50);
                param[0].Value = q;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BuscarPuestos";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para buscar.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        //************************** Insumos *****************************/
        public bool insertarInsumo(int idCategoria, int idProveedor, string nombre, int cantidad, float precio)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[5];

                param[0] = new SqlParameter("@idCategoria", SqlDbType.Int);
                param[0].Value = idCategoria;
                param[1] = new SqlParameter("@idProveedor ", SqlDbType.Int);
                param[1].Value = idProveedor;
                param[2] = new SqlParameter("@nombre", SqlDbType.NVarChar, 50);
                param[2].Value = nombre;
                param[3] = new SqlParameter("@cantidad", SqlDbType.Int);
                param[3].Value = cantidad;
                param[4] = new SqlParameter("@precio", SqlDbType.Float);
                param[4].Value = precio;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CrearInsumo";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                mostrarMensaje(ds);
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para insertar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }

                return false;
            }


        }

        public void editarInsumo(DataGridView GridView1, int idInsumo, int idCategoria, int idProveedor, string nombre, int cantidad, float precio)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[6];
                param[0] = new SqlParameter("@idInsumo", SqlDbType.Int);
                param[0].Value = idInsumo;
                param[1] = new SqlParameter("@idCategoria", SqlDbType.Int);
                param[1].Value = idCategoria;
                param[2] = new SqlParameter("@idProveedor", SqlDbType.Int);
                param[2].Value = idProveedor;
                param[3] = new SqlParameter("@nombre", SqlDbType.NVarChar, 50);
                param[3].Value = nombre;
                param[4] = new SqlParameter("@cantidad", SqlDbType.Int);
                param[4].Value = cantidad;
                param[5] = new SqlParameter("@precio", SqlDbType.Float);
                param[5].Value = precio;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EditarInsumo";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                mostrarMensaje(ds);
                listarResultados(GridView1, "BuscarInsumo");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para editar");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void buscarInsumo(DataGridView GridView1, String q)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@q", SqlDbType.NVarChar, 50);
                param[0].Value = q;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BuscarInsumo";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {
                    MessageBox.Show("No tienes permiso para buscar.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }


}

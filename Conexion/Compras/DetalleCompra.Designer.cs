namespace Conexion.Compras
{
    partial class DetalleCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnDevolverP = new System.Windows.Forms.Button();
            this.btnEditarInsumo = new System.Windows.Forms.Button();
            this.btnNuevoInsumo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBuscar2 = new System.Windows.Forms.TextBox();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.dgvDetCompraInsumo = new System.Windows.Forms.DataGridView();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdCompra2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdDetCompra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.dgvDetCompraProducto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalConIvaValue = new System.Windows.Forms.Label();
            this.ivaValue = new System.Windows.Forms.Label();
            this.totalValue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.lIdDetalle = new System.Windows.Forms.Label();
            this.btnDevolverI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetCompraInsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetCompraProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(633, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 32);
            this.button1.TabIndex = 126;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDevolverP
            // 
            this.btnDevolverP.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDevolverP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolverP.Location = new System.Drawing.Point(633, 156);
            this.btnDevolverP.Name = "btnDevolverP";
            this.btnDevolverP.Size = new System.Drawing.Size(160, 32);
            this.btnDevolverP.TabIndex = 125;
            this.btnDevolverP.Text = "Devolver Producto";
            this.btnDevolverP.UseVisualStyleBackColor = false;
            this.btnDevolverP.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnEditarInsumo
            // 
            this.btnEditarInsumo.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnEditarInsumo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarInsumo.Location = new System.Drawing.Point(633, 85);
            this.btnEditarInsumo.Name = "btnEditarInsumo";
            this.btnEditarInsumo.Size = new System.Drawing.Size(160, 32);
            this.btnEditarInsumo.TabIndex = 124;
            this.btnEditarInsumo.Text = "Editar Insumo";
            this.btnEditarInsumo.UseVisualStyleBackColor = false;
            this.btnEditarInsumo.Click += new System.EventHandler(this.btnEditarInsumo_Click);
            // 
            // btnNuevoInsumo
            // 
            this.btnNuevoInsumo.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnNuevoInsumo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoInsumo.Location = new System.Drawing.Point(633, 12);
            this.btnNuevoInsumo.Name = "btnNuevoInsumo";
            this.btnNuevoInsumo.Size = new System.Drawing.Size(160, 32);
            this.btnNuevoInsumo.TabIndex = 123;
            this.btnNuevoInsumo.Text = "Nuevo Insumo";
            this.btnNuevoInsumo.UseVisualStyleBackColor = false;
            this.btnNuevoInsumo.Click += new System.EventHandler(this.btnCrear2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 20);
            this.label12.TabIndex = 122;
            this.label12.Text = "Digite el código";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(464, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 20);
            this.label13.TabIndex = 121;
            this.label13.Text = "De dos click\'s para editar";
            // 
            // txtBuscar2
            // 
            this.txtBuscar2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar2.Location = new System.Drawing.Point(35, 179);
            this.txtBuscar2.Name = "txtBuscar2";
            this.txtBuscar2.Size = new System.Drawing.Size(183, 26);
            this.txtBuscar2.TabIndex = 120;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBuscar2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar2.Location = new System.Drawing.Point(224, 174);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(107, 34);
            this.btnBuscar2.TabIndex = 119;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.UseVisualStyleBackColor = false;
            // 
            // dgvDetCompraInsumo
            // 
            this.dgvDetCompraInsumo.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDetCompraInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetCompraInsumo.Location = new System.Drawing.Point(35, 231);
            this.dgvDetCompraInsumo.Name = "dgvDetCompraInsumo";
            this.dgvDetCompraInsumo.Size = new System.Drawing.Size(585, 140);
            this.dgvDetCompraInsumo.TabIndex = 118;
            this.dgvDetCompraInsumo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetCompraInsumo_CellContentClick);
            this.dgvDetCompraInsumo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetCompraInsumo_CellDoubleClick);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(494, 66);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(93, 26);
            this.txtDescuento.TabIndex = 116;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(396, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 19);
            this.label11.TabIndex = 117;
            this.label11.Text = "Descuento";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(294, 105);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(97, 26);
            this.txtCantidad.TabIndex = 114;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 115;
            this.label5.Text = "Cantidad";
            // 
            // txtIdCompra2
            // 
            this.txtIdCompra2.Enabled = false;
            this.txtIdCompra2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCompra2.Location = new System.Drawing.Point(103, 8);
            this.txtIdCompra2.Name = "txtIdCompra2";
            this.txtIdCompra2.Size = new System.Drawing.Size(148, 26);
            this.txtIdCompra2.TabIndex = 108;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 113;
            this.label8.Text = "Id compra";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(295, 66);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(73, 26);
            this.txtCodigo.TabIndex = 109;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(223, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 112;
            this.label9.Text = "Código";
            // 
            // txtIdDetCompra
            // 
            this.txtIdDetCompra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDetCompra.Location = new System.Drawing.Point(406, -30);
            this.txtIdDetCompra.Name = "txtIdDetCompra";
            this.txtIdDetCompra.Size = new System.Drawing.Size(148, 26);
            this.txtIdDetCompra.TabIndex = 110;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(230, -23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 19);
            this.label10.TabIndex = 111;
            this.label10.Text = "Id detalle compra";
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.Location = new System.Drawing.Point(633, 47);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(160, 32);
            this.btnNuevoProducto.TabIndex = 127;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = false;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // dgvDetCompraProducto
            // 
            this.dgvDetCompraProducto.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDetCompraProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetCompraProducto.Location = new System.Drawing.Point(35, 407);
            this.dgvDetCompraProducto.Name = "dgvDetCompraProducto";
            this.dgvDetCompraProducto.Size = new System.Drawing.Size(585, 140);
            this.dgvDetCompraProducto.TabIndex = 128;
            this.dgvDetCompraProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetCompraProducto_CellContentClick);
            this.dgvDetCompraProducto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDetCompraProducto_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 129;
            this.label1.Text = "Insumos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 130;
            this.label2.Text = "Productos";
            // 
            // totalConIvaValue
            // 
            this.totalConIvaValue.AutoSize = true;
            this.totalConIvaValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalConIvaValue.Location = new System.Drawing.Point(717, 472);
            this.totalConIvaValue.Name = "totalConIvaValue";
            this.totalConIvaValue.Size = new System.Drawing.Size(31, 19);
            this.totalConIvaValue.TabIndex = 131;
            this.totalConIvaValue.Text = "0.0";
            // 
            // ivaValue
            // 
            this.ivaValue.AutoSize = true;
            this.ivaValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ivaValue.Location = new System.Drawing.Point(717, 407);
            this.ivaValue.Name = "ivaValue";
            this.ivaValue.Size = new System.Drawing.Size(31, 19);
            this.ivaValue.TabIndex = 132;
            this.ivaValue.Text = "0.0";
            // 
            // totalValue
            // 
            this.totalValue.AutoSize = true;
            this.totalValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalValue.Location = new System.Drawing.Point(717, 338);
            this.totalValue.Name = "totalValue";
            this.totalValue.Size = new System.Drawing.Size(31, 19);
            this.totalValue.TabIndex = 133;
            this.totalValue.Text = "0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(626, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 134;
            this.label7.Text = "Total: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(626, 374);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 20);
            this.label14.TabIndex = 135;
            this.label14.Text = "IVA: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(629, 435);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 20);
            this.label15.TabIndex = 136;
            this.label15.Text = "Total con IVA:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(494, 105);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(93, 26);
            this.txtPrecio.TabIndex = 137;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 138;
            this.label3.Text = "Precio";
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnEditarProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProducto.Location = new System.Drawing.Point(633, 123);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(160, 32);
            this.btnEditarProducto.TabIndex = 139;
            this.btnEditarProducto.Text = "Editar Producto";
            this.btnEditarProducto.UseVisualStyleBackColor = false;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // lIdDetalle
            // 
            this.lIdDetalle.AutoSize = true;
            this.lIdDetalle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIdDetalle.Location = new System.Drawing.Point(99, 85);
            this.lIdDetalle.Name = "lIdDetalle";
            this.lIdDetalle.Size = new System.Drawing.Size(27, 19);
            this.lIdDetalle.TabIndex = 141;
            this.lIdDetalle.Text = "#_";
            // 
            // btnDevolverI
            // 
            this.btnDevolverI.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDevolverI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolverI.Location = new System.Drawing.Point(633, 193);
            this.btnDevolverI.Name = "btnDevolverI";
            this.btnDevolverI.Size = new System.Drawing.Size(160, 32);
            this.btnDevolverI.TabIndex = 142;
            this.btnDevolverI.Text = "Devolver Insumo";
            this.btnDevolverI.UseVisualStyleBackColor = false;
            this.btnDevolverI.Click += new System.EventHandler(this.btnDevolverI_Click);
            // 
            // DetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(821, 559);
            this.Controls.Add(this.btnDevolverI);
            this.Controls.Add(this.lIdDetalle);
            this.Controls.Add(this.btnEditarProducto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalValue);
            this.Controls.Add(this.ivaValue);
            this.Controls.Add(this.totalConIvaValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetCompraProducto);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDevolverP);
            this.Controls.Add(this.btnEditarInsumo);
            this.Controls.Add(this.btnNuevoInsumo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBuscar2);
            this.Controls.Add(this.btnBuscar2);
            this.Controls.Add(this.dgvDetCompraInsumo);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdCompra2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdDetCompra);
            this.Controls.Add(this.label10);
            this.Name = "DetalleCompra";
            this.Text = "DetalleCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetCompraInsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetCompraProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDevolverP;
        private System.Windows.Forms.Button btnEditarInsumo;
        private System.Windows.Forms.Button btnNuevoInsumo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBuscar2;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.DataGridView dgvDetCompraInsumo;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdCompra2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdDetCompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.DataGridView dgvDetCompraProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalConIvaValue;
        private System.Windows.Forms.Label ivaValue;
        private System.Windows.Forms.Label totalValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Label lIdDetalle;
        private System.Windows.Forms.Button btnDevolverI;
    }
}
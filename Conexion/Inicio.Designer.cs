namespace Conexion
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.insumosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasDetalleVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comrpasDetalleComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogoToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // catalogoToolStripMenuItem
            // 
            resources.ApplyResources(this.catalogoToolStripMenuItem, "catalogoToolStripMenuItem");
            this.catalogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoríasToolStripMenuItem,
            this.productosToolStripMenuItem2,
            this.insumosToolStripMenuItem1,
            this.empleadosToolStripMenuItem,
            this.proveedorToolStripMenuItem,
            this.puestosToolStripMenuItem});
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            // 
            // categoríasToolStripMenuItem
            // 
            resources.ApplyResources(this.categoríasToolStripMenuItem, "categoríasToolStripMenuItem");
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Click += new System.EventHandler(this.categoríasToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem2
            // 
            resources.ApplyResources(this.productosToolStripMenuItem2, "productosToolStripMenuItem2");
            this.productosToolStripMenuItem2.Name = "productosToolStripMenuItem2";
            this.productosToolStripMenuItem2.Click += new System.EventHandler(this.productosToolStripMenuItem2_Click);
            // 
            // insumosToolStripMenuItem1
            // 
            resources.ApplyResources(this.insumosToolStripMenuItem1, "insumosToolStripMenuItem1");
            this.insumosToolStripMenuItem1.Name = "insumosToolStripMenuItem1";
            this.insumosToolStripMenuItem1.Click += new System.EventHandler(this.insumosToolStripMenuItem1_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            resources.ApplyResources(this.empleadosToolStripMenuItem, "empleadosToolStripMenuItem");
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            // 
            // proveedorToolStripMenuItem
            // 
            resources.ApplyResources(this.proveedorToolStripMenuItem, "proveedorToolStripMenuItem");
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click);
            // 
            // puestosToolStripMenuItem
            // 
            resources.ApplyResources(this.puestosToolStripMenuItem, "puestosToolStripMenuItem");
            this.puestosToolStripMenuItem.Name = "puestosToolStripMenuItem";
            this.puestosToolStripMenuItem.Click += new System.EventHandler(this.puestosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasDetalleVentasToolStripMenuItem,
            this.comrpasDetalleComprasToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ventasDetalleVentasToolStripMenuItem
            // 
            resources.ApplyResources(this.ventasDetalleVentasToolStripMenuItem, "ventasDetalleVentasToolStripMenuItem");
            this.ventasDetalleVentasToolStripMenuItem.Name = "ventasDetalleVentasToolStripMenuItem";
            this.ventasDetalleVentasToolStripMenuItem.Click += new System.EventHandler(this.ventasDetalleVentasToolStripMenuItem_Click);
            // 
            // comrpasDetalleComprasToolStripMenuItem
            // 
            resources.ApplyResources(this.comrpasDetalleComprasToolStripMenuItem, "comrpasDetalleComprasToolStripMenuItem");
            this.comrpasDetalleComprasToolStripMenuItem.Name = "comrpasDetalleComprasToolStripMenuItem";
            this.comrpasDetalleComprasToolStripMenuItem.Click += new System.EventHandler(this.comrpasDetalleComprasToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inicio_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventasDetalleVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comrpasDetalleComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem insumosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestosToolStripMenuItem;
    }
}
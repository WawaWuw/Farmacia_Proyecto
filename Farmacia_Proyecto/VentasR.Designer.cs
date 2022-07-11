namespace Farmacia_Proyecto
{
    partial class VentasR
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataFactura = new System.Windows.Forms.DataGridView();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.texPrecio = new System.Windows.Forms.TextBox();
            this.texDescr = new System.Windows.Forms.TextBox();
            this.texNombre = new System.Windows.Forms.TextBox();
            this.texId_Pro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Busquedapro = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.BBorrar = new System.Windows.Forms.Button();
            this.BFacturar = new System.Windows.Forms.Button();
            this.TBCantidad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyecto_FarmaciDataSet = new Farmacia_Proyecto.Proyecto_FarmaciDataSet();
            this.productoTableAdapter = new Farmacia_Proyecto.Proyecto_FarmaciDataSetTableAdapters.ProductoTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Agregado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataFactura)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto_FarmaciDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Factura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // dataFactura
            // 
            this.dataFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Producto,
            this.NombreP,
            this.Descripcion,
            this.Cantidad,
            this.Precio});
            this.dataFactura.Location = new System.Drawing.Point(235, 164);
            this.dataFactura.Name = "dataFactura";
            this.dataFactura.Size = new System.Drawing.Size(543, 156);
            this.dataFactura.TabIndex = 6;
            // 
            // ID_Producto
            // 
            this.ID_Producto.HeaderText = "ID Producto";
            this.ID_Producto.Name = "ID_Producto";
            // 
            // NombreP
            // 
            this.NombreP.HeaderText = "Nombre";
            this.NombreP.Name = "NombreP";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Empleado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha:";
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Location = new System.Drawing.Point(466, 82);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(10, 13);
            this.labelF.TabIndex = 9;
            this.labelF.Text = ".";
            this.labelF.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(728, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = ".";
            // 
            // texPrecio
            // 
            this.texPrecio.Location = new System.Drawing.Point(112, 291);
            this.texPrecio.Name = "texPrecio";
            this.texPrecio.Size = new System.Drawing.Size(100, 20);
            this.texPrecio.TabIndex = 25;
            // 
            // texDescr
            // 
            this.texDescr.Location = new System.Drawing.Point(112, 252);
            this.texDescr.Name = "texDescr";
            this.texDescr.Size = new System.Drawing.Size(100, 20);
            this.texDescr.TabIndex = 23;
            // 
            // texNombre
            // 
            this.texNombre.Location = new System.Drawing.Point(112, 215);
            this.texNombre.Name = "texNombre";
            this.texNombre.Size = new System.Drawing.Size(100, 20);
            this.texNombre.TabIndex = 22;
            // 
            // texId_Pro
            // 
            this.texId_Pro.Location = new System.Drawing.Point(112, 176);
            this.texId_Pro.Name = "texId_Pro";
            this.texId_Pro.Size = new System.Drawing.Size(100, 20);
            this.texId_Pro.TabIndex = 21;
            this.texId_Pro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texId_Pro_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Precio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Descripcion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Nombre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "ID_Producto";
            // 
            // Busquedapro
            // 
            this.Busquedapro.Location = new System.Drawing.Point(26, 382);
            this.Busquedapro.Name = "Busquedapro";
            this.Busquedapro.Size = new System.Drawing.Size(67, 27);
            this.Busquedapro.TabIndex = 26;
            this.Busquedapro.Text = "Buscar";
            this.Busquedapro.UseVisualStyleBackColor = true;
            this.Busquedapro.Click += new System.EventHandler(this.BAgregarCarrito_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(664, 393);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Total";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(664, 333);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(594, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Sub total";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(664, 362);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(596, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "IVA 15%";
            // 
            // BLimpiar
            // 
            this.BLimpiar.Location = new System.Drawing.Point(145, 382);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(67, 27);
            this.BLimpiar.TabIndex = 33;
            this.BLimpiar.Text = "Limpiar";
            this.BLimpiar.UseVisualStyleBackColor = true;
            // 
            // BBorrar
            // 
            this.BBorrar.Location = new System.Drawing.Point(29, 415);
            this.BBorrar.Name = "BBorrar";
            this.BBorrar.Size = new System.Drawing.Size(67, 27);
            this.BBorrar.TabIndex = 34;
            this.BBorrar.Text = "Borrar";
            this.BBorrar.UseVisualStyleBackColor = true;
            // 
            // BFacturar
            // 
            this.BFacturar.Location = new System.Drawing.Point(697, 423);
            this.BFacturar.Name = "BFacturar";
            this.BFacturar.Size = new System.Drawing.Size(67, 27);
            this.BFacturar.TabIndex = 35;
            this.BFacturar.Text = "facturar";
            this.BFacturar.UseVisualStyleBackColor = true;
            this.BFacturar.Click += new System.EventHandler(this.BFacturar_Click);
            // 
            // TBCantidad
            // 
            this.TBCantidad.Location = new System.Drawing.Point(112, 329);
            this.TBCantidad.Name = "TBCantidad";
            this.TBCantidad.Size = new System.Drawing.Size(100, 20);
            this.TBCantidad.TabIndex = 37;
            this.TBCantidad.TextChanged += new System.EventHandler(this.TBCantidad_TextChanged);
            this.TBCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texId_Pro_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Cantidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelF);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(35, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 132);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Farmacia \"Lolita\"";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.proyecto_FarmaciDataSet;
            // 
            // proyecto_FarmaciDataSet
            // 
            this.proyecto_FarmaciDataSet.DataSetName = "Proyecto_FarmaciDataSet";
            this.proyecto_FarmaciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(842, 25);
            this.fillByToolStrip.TabIndex = 40;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // Agregado
            // 
            this.Agregado.Location = new System.Drawing.Point(145, 418);
            this.Agregado.Name = "Agregado";
            this.Agregado.Size = new System.Drawing.Size(75, 23);
            this.Agregado.TabIndex = 41;
            this.Agregado.Text = "Agregar";
            this.Agregado.UseVisualStyleBackColor = true;
            this.Agregado.Click += new System.EventHandler(this.Agregado_Click);
            // 
            // VentasR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(842, 473);
            this.Controls.Add(this.Agregado);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TBCantidad);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BFacturar);
            this.Controls.Add(this.BBorrar);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Busquedapro);
            this.Controls.Add(this.texPrecio);
            this.Controls.Add(this.texDescr);
            this.Controls.Add(this.texNombre);
            this.Controls.Add(this.texId_Pro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentasR";
            this.Text = "VentasR";
            this.Load += new System.EventHandler(this.VentasR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFactura)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto_FarmaciDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.TextBox texPrecio;
        private System.Windows.Forms.TextBox texDescr;
        private System.Windows.Forms.TextBox texNombre;
        private System.Windows.Forms.TextBox texId_Pro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Busquedapro;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button BBorrar;
        private System.Windows.Forms.Button BFacturar;
        private System.Windows.Forms.TextBox TBCantidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private Proyecto_FarmaciDataSet proyecto_FarmaciDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private Proyecto_FarmaciDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button Agregado;
    }
}
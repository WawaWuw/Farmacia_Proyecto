﻿namespace Farmacia_Proyecto
{
    partial class Productos
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
            this.Agregar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.texId_Pro = new System.Windows.Forms.TextBox();
            this.texNombre = new System.Windows.Forms.TextBox();
            this.texDescr = new System.Windows.Forms.TextBox();
            this.texExis = new System.Windows.Forms.TextBox();
            this.texPrecio = new System.Windows.Forms.TextBox();
            this.texVencimiento = new System.Windows.Forms.TextBox();
            this.dataProducto = new System.Windows.Forms.DataGridView();
            this.Busqueda = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textbusqueda = new System.Windows.Forms.TextBox();
            this.radioId = new System.Windows.Forms.RadioButton();
            this.radioNombre = new System.Windows.Forms.RadioButton();
            this.radioExis = new System.Windows.Forms.RadioButton();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(33, 272);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(157, 272);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 1;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(157, 301);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID_Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Existencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha de vencimiento";
            // 
            // texId_Pro
            // 
            this.texId_Pro.Location = new System.Drawing.Point(118, 94);
            this.texId_Pro.Name = "texId_Pro";
            this.texId_Pro.Size = new System.Drawing.Size(100, 20);
            this.texId_Pro.TabIndex = 9;
            // 
            // texNombre
            // 
            this.texNombre.Location = new System.Drawing.Point(118, 120);
            this.texNombre.Name = "texNombre";
            this.texNombre.Size = new System.Drawing.Size(100, 20);
            this.texNombre.TabIndex = 10;
            // 
            // texDescr
            // 
            this.texDescr.Location = new System.Drawing.Point(118, 146);
            this.texDescr.Name = "texDescr";
            this.texDescr.Size = new System.Drawing.Size(100, 20);
            this.texDescr.TabIndex = 11;
            // 
            // texExis
            // 
            this.texExis.Location = new System.Drawing.Point(118, 174);
            this.texExis.Name = "texExis";
            this.texExis.Size = new System.Drawing.Size(100, 20);
            this.texExis.TabIndex = 12;
            // 
            // texPrecio
            // 
            this.texPrecio.Location = new System.Drawing.Point(118, 200);
            this.texPrecio.Name = "texPrecio";
            this.texPrecio.Size = new System.Drawing.Size(100, 20);
            this.texPrecio.TabIndex = 13;
            // 
            // texVencimiento
            // 
            this.texVencimiento.Location = new System.Drawing.Point(148, 228);
            this.texVencimiento.Name = "texVencimiento";
            this.texVencimiento.Size = new System.Drawing.Size(100, 20);
            this.texVencimiento.TabIndex = 14;
            // 
            // dataProducto
            // 
            this.dataProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProducto.Location = new System.Drawing.Point(298, 160);
            this.dataProducto.Name = "dataProducto";
            this.dataProducto.ReadOnly = true;
            this.dataProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProducto.Size = new System.Drawing.Size(349, 188);
            this.dataProducto.TabIndex = 15;
            this.dataProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProducto_CellClick);
            // 
            // Busqueda
            // 
            this.Busqueda.Location = new System.Drawing.Point(538, 74);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(75, 23);
            this.Busqueda.TabIndex = 16;
            this.Busqueda.Text = "Buscar";
            this.Busqueda.UseVisualStyleBackColor = true;
            this.Busqueda.Click += new System.EventHandler(this.Busqueda_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Buscar";
            // 
            // textbusqueda
            // 
            this.textbusqueda.Location = new System.Drawing.Point(341, 74);
            this.textbusqueda.Name = "textbusqueda";
            this.textbusqueda.Size = new System.Drawing.Size(191, 20);
            this.textbusqueda.TabIndex = 18;
            // 
            // radioId
            // 
            this.radioId.AutoSize = true;
            this.radioId.Location = new System.Drawing.Point(312, 110);
            this.radioId.Name = "radioId";
            this.radioId.Size = new System.Drawing.Size(36, 17);
            this.radioId.TabIndex = 19;
            this.radioId.TabStop = true;
            this.radioId.Text = "ID";
            this.radioId.UseVisualStyleBackColor = true;
            // 
            // radioNombre
            // 
            this.radioNombre.AutoSize = true;
            this.radioNombre.Location = new System.Drawing.Point(390, 110);
            this.radioNombre.Name = "radioNombre";
            this.radioNombre.Size = new System.Drawing.Size(62, 17);
            this.radioNombre.TabIndex = 20;
            this.radioNombre.TabStop = true;
            this.radioNombre.Text = "Nombre";
            this.radioNombre.UseVisualStyleBackColor = true;
            // 
            // radioExis
            // 
            this.radioExis.AutoSize = true;
            this.radioExis.Location = new System.Drawing.Point(493, 110);
            this.radioExis.Name = "radioExis";
            this.radioExis.Size = new System.Drawing.Size(78, 17);
            this.radioExis.TabIndex = 21;
            this.radioExis.TabStop = true;
            this.radioExis.Text = "existeancia";
            this.radioExis.UseVisualStyleBackColor = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(619, 74);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 22;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(33, 302);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 422);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.radioExis);
            this.Controls.Add(this.radioNombre);
            this.Controls.Add(this.radioId);
            this.Controls.Add(this.textbusqueda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.dataProducto);
            this.Controls.Add(this.texVencimiento);
            this.Controls.Add(this.texPrecio);
            this.Controls.Add(this.texExis);
            this.Controls.Add(this.texDescr);
            this.Controls.Add(this.texNombre);
            this.Controls.Add(this.texId_Pro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox texId_Pro;
        private System.Windows.Forms.TextBox texNombre;
        private System.Windows.Forms.TextBox texDescr;
        private System.Windows.Forms.TextBox texExis;
        private System.Windows.Forms.TextBox texPrecio;
        private System.Windows.Forms.TextBox texVencimiento;
        private System.Windows.Forms.DataGridView dataProducto;
        private System.Windows.Forms.Button Busqueda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbusqueda;
        private System.Windows.Forms.RadioButton radioId;
        private System.Windows.Forms.RadioButton radioNombre;
        private System.Windows.Forms.RadioButton radioExis;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
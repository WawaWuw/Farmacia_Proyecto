﻿namespace Farmacia_Proyecto
{
    partial class Cliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.Modificar = new System.Windows.Forms.Button();
            this.agregado = new System.Windows.Forms.Button();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.dataClie = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textDirec = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RadioNom = new System.Windows.Forms.RadioButton();
            this.Radioid = new System.Windows.Forms.RadioButton();
            this.texBusqueda = new System.Windows.Forms.TextBox();
            this.Busqueda = new System.Windows.Forms.Button();
            this.Refresf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataClie)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(119, 120);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(19, 13);
            this.labelid.TabIndex = 22;
            this.labelid.Text = "----";
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(88, 357);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 27);
            this.Modificar.TabIndex = 21;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // agregado
            // 
            this.agregado.Location = new System.Drawing.Point(88, 317);
            this.agregado.Name = "agregado";
            this.agregado.Size = new System.Drawing.Size(111, 34);
            this.agregado.TabIndex = 20;
            this.agregado.Text = "Agregar cliente";
            this.agregado.UseVisualStyleBackColor = true;
            this.agregado.Click += new System.EventHandler(this.agregado_Click);
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(90, 267);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 19;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(90, 188);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 18;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(90, 150);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 17;
            // 
            // dataClie
            // 
            this.dataClie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClie.Location = new System.Drawing.Point(270, 158);
            this.dataClie.Name = "dataClie";
            this.dataClie.ReadOnly = true;
            this.dataClie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataClie.Size = new System.Drawing.Size(469, 261);
            this.dataClie.TabIndex = 14;
            this.dataClie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEmp_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Direccion";
            // 
            // textDirec
            // 
            this.textDirec.Location = new System.Drawing.Point(90, 226);
            this.textDirec.Name = "textDirec";
            this.textDirec.Size = new System.Drawing.Size(100, 20);
            this.textDirec.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 29;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "ID Cliente";
            // 
            // RadioNom
            // 
            this.RadioNom.AutoSize = true;
            this.RadioNom.Location = new System.Drawing.Point(476, 132);
            this.RadioNom.Name = "RadioNom";
            this.RadioNom.Size = new System.Drawing.Size(62, 17);
            this.RadioNom.TabIndex = 31;
            this.RadioNom.TabStop = true;
            this.RadioNom.Text = "Nombre";
            this.RadioNom.UseVisualStyleBackColor = true;
            // 
            // Radioid
            // 
            this.Radioid.AutoSize = true;
            this.Radioid.Location = new System.Drawing.Point(420, 132);
            this.Radioid.Name = "Radioid";
            this.Radioid.Size = new System.Drawing.Size(36, 17);
            this.Radioid.TabIndex = 32;
            this.Radioid.TabStop = true;
            this.Radioid.Text = "ID";
            this.Radioid.UseVisualStyleBackColor = true;
            // 
            // texBusqueda
            // 
            this.texBusqueda.Location = new System.Drawing.Point(361, 89);
            this.texBusqueda.Name = "texBusqueda";
            this.texBusqueda.Size = new System.Drawing.Size(181, 20);
            this.texBusqueda.TabIndex = 33;
            // 
            // Busqueda
            // 
            this.Busqueda.Location = new System.Drawing.Point(568, 89);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(75, 23);
            this.Busqueda.TabIndex = 34;
            this.Busqueda.Text = "Buscar";
            this.Busqueda.UseVisualStyleBackColor = true;
            this.Busqueda.Click += new System.EventHandler(this.Busqueda_Click);
            // 
            // Refresf
            // 
            this.Refresf.Location = new System.Drawing.Point(665, 89);
            this.Refresf.Name = "Refresf";
            this.Refresf.Size = new System.Drawing.Size(75, 23);
            this.Refresf.TabIndex = 35;
            this.Refresf.Text = "Refrescar";
            this.Refresf.UseVisualStyleBackColor = true;
            this.Refresf.Click += new System.EventHandler(this.Refresf_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Refresf);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.texBusqueda);
            this.Controls.Add(this.Radioid);
            this.Controls.Add(this.RadioNom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textDirec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.agregado);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.dataClie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataClie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button agregado;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DataGridView dataClie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDirec;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RadioNom;
        private System.Windows.Forms.RadioButton Radioid;
        private System.Windows.Forms.TextBox texBusqueda;
        private System.Windows.Forms.Button Busqueda;
        private System.Windows.Forms.Button Refresf;
    }
}
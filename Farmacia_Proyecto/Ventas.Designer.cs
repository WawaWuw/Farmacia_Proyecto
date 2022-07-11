namespace Farmacia_Proyecto
{
    partial class Ventas
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
            this.dataVentas = new System.Windows.Forms.DataGridView();
            this.texBusqueda = new System.Windows.Forms.TextBox();
            this.Busqueda = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.Radioid = new System.Windows.Forms.RadioButton();
            this.Radioarti = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataVentas
            // 
            this.dataVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVentas.Location = new System.Drawing.Point(232, 105);
            this.dataVentas.Name = "dataVentas";
            this.dataVentas.Size = new System.Drawing.Size(430, 234);
            this.dataVentas.TabIndex = 0;
            // 
            // texBusqueda
            // 
            this.texBusqueda.Location = new System.Drawing.Point(290, 40);
            this.texBusqueda.Name = "texBusqueda";
            this.texBusqueda.Size = new System.Drawing.Size(177, 20);
            this.texBusqueda.TabIndex = 1;
            // 
            // Busqueda
            // 
            this.Busqueda.Location = new System.Drawing.Point(493, 40);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(75, 23);
            this.Busqueda.TabIndex = 2;
            this.Busqueda.Text = "Busqueda";
            this.Busqueda.UseVisualStyleBackColor = true;
            this.Busqueda.Click += new System.EventHandler(this.Busqueda_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(586, 40);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 3;
            this.Refresh.Text = "Refrescar";
            this.Refresh.UseVisualStyleBackColor = true;
            // 
            // Radioid
            // 
            this.Radioid.AutoSize = true;
            this.Radioid.Location = new System.Drawing.Point(230, 82);
            this.Radioid.Name = "Radioid";
            this.Radioid.Size = new System.Drawing.Size(36, 17);
            this.Radioid.TabIndex = 4;
            this.Radioid.TabStop = true;
            this.Radioid.Text = "ID";
            this.Radioid.UseVisualStyleBackColor = true;
            // 
            // Radioarti
            // 
            this.Radioarti.AutoSize = true;
            this.Radioarti.Location = new System.Drawing.Point(290, 82);
            this.Radioarti.Name = "Radioarti";
            this.Radioarti.Size = new System.Drawing.Size(81, 17);
            this.Radioarti.TabIndex = 5;
            this.Radioarti.TabStop = true;
            this.Radioarti.Text = "ID producto";
            this.Radioarti.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 362);
            this.Controls.Add(this.Radioarti);
            this.Controls.Add(this.Radioid);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.texBusqueda);
            this.Controls.Add(this.dataVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataVentas;
        private System.Windows.Forms.TextBox texBusqueda;
        private System.Windows.Forms.Button Busqueda;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.RadioButton Radioid;
        private System.Windows.Forms.RadioButton Radioarti;
    }
}
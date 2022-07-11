using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Farmacia_Proyecto
{
    public partial class VentasR : Form
    {
        SqlConnection conexion = new SqlConnection("Server= DESKTOP-UP2SA5G\\SQLEXPRESS;database=Proyecto_Farmaci;integrated security=true");

        public VentasR()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }
       
        private void BAgregarCarrito_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "SELECT * FROM Producto WHERE ID_Prod='" + texId_Pro.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                texNombre.Text = registro["Nombre"].ToString();
                texDescr.Text = registro["Descripcion"].ToString();
                texPrecio.Text = registro["Precio"].ToString();
            }
            conexion.Close();


           
        }

        private void VentasR_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyecto_FarmaciDataSet.Producto' Puede moverla o quitarla según sea necesario.
          
            labelF.Text = DateTime.Now.ToLongDateString();
           
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productoTableAdapter.FillBy(this.proyecto_FarmaciDataSet.Producto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Agregado_Click(object sender, EventArgs e)
        {
            double n;
            //dataFactura.Rows.Add(texNombre.Text);
            //dataFactura.Rows.Add(texDescr.Text);
            //dataFactura.Rows.Add(texPrecio.Text);

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataFactura);
            fila.Cells[0].Value = texId_Pro.Text;
            fila.Cells[1].Value = texNombre.Text;
            fila.Cells[2].Value = texDescr.Text;
            fila.Cells[3].Value = TBCantidad.Text;
            fila.Cells[4].Value = double.Parse(texPrecio.Text) * double.Parse(TBCantidad.Text);


            dataFactura.Rows.Add(fila);

            SumaColumna();


        }

        public void SumaColumna()
        {
            Double total = 0,iva = 0, suma = 0;

            foreach ( DataGridViewRow row in dataFactura.Rows)
            {
                total += Convert.ToDouble(row.Cells["Precio"].Value);
               
            }
            
            TbSubTotal.Text = total.ToString();
            iva = double.Parse(TbSubTotal.Text) * 0.15;
            TBIVa.Text = iva.ToString();
            suma = double.Parse(TbSubTotal.Text) + double.Parse(TBIVa.Text);
            TBTotal.Text = suma.ToString();

        }

        private void texId_Pro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //conexion.Open();
            //string consulta = "SELECT * FROM Producto WHERE ID_Prod='" + texId_Pro.Text + "'";
            //SqlCommand comando = new SqlCommand(consulta, conexion);
            //SqlDataReader registro = comando.ExecuteReader();
            //if (registro.Read())
            //{
            //    texNombre.Text = registro["Nombre"].ToString();
            //    texDescr.Text = registro["Descripcion"].ToString();
            //    texPrecio.Text = registro["Precio"].ToString();
            //}
            //conexion.Close();

        }

        private void TBCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DataGridViewRow fila = new DataGridViewRow();
            //fila.CreateCells(dataFactura);
            //fila.Cells[0].Value = texId_Pro.Text;
            //fila.Cells[1].Value = texNombre.Text;
            //fila.Cells[2].Value = texDescr.Text;
            //fila.Cells[3].Value = TBCantidad.Text;
            //fila.Cells[4].Value = texPrecio.Text;

            //dataFactura.Rows.Add(fila);
        }

        private void TBCantidad_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BFacturar_Click(object sender, EventArgs e)
        {

            SqlCommand agregar = new SqlCommand("exec sp_Ventas '@Id_produc', @CantidadComprada, '@Fecha_Venta'",conexion);
            conexion.Open();

            try
            {
                foreach (DataGridViewRow row in dataFactura.Rows)
                {
                    agregar.Parameters.Clear();

                    agregar.Parameters.AddWithValue("@Id_Produc", Convert.ToString(row.Cells["ID_Producto"].Value));
                    agregar.Parameters.AddWithValue("@CantidadComprada", Convert.ToString(row.Cells["Cantidad"].Value));
                    

                    agregar.ExecuteNonQuery();

                }
                agregar.Parameters.AddWithValue("@Fecha_Venta", Convert.ToString(labelF.Text));
                MessageBox.Show("Datos Agregados. ");

            }
       catch(Exception ex)

            {
                MessageBox.Show("Error al agregarrr");
            }
            finally
            {
                conexion.Close();
            }


        }

        private void TBCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }
    }
}

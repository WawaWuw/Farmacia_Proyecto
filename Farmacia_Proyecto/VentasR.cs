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

            //dataFactura.Rows.Add(texNombre.Text);
            //dataFactura.Rows.Add(texDescr.Text);
            //dataFactura.Rows.Add(texPrecio.Text);

            dataFactura.Columns.Add("ID Producto",texPrecio.Text);
            dataFactura.Columns.Add("Nombre", texNombre.Text);

            

        }
    }
}

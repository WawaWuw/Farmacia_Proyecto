using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Farmacia_Proyecto
{
    public partial class Ventas : Form
    {
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-1LQHI27;database=Proyecto_Farmaci;integrated security=true");
        public Ventas()
        {
            InitializeComponent();
        }
        public void llenar_tabla()
        {
            string consulta = "select * from Ventas";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataVentas.DataSource = dt;
        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            llenar_tabla();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_Proyecto
{
    public partial class usersInicio : UserControl
    {
        public usersInicio()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-1LQHI27;database=Proyecto_Farmaci;integrated security=true");
        private void button1_Click(object sender, EventArgs e)
        {
            //conexion.Open();
            //string consulta = "SELECT ID_Empleado,contraseña FROM Empleado WHERE ID_Cliente ="+txtUsuario.Text +"";
            //if ('ID_Cliente'=txtUsuario.Text && 'contraseña'=txtcontra.Text)
            //{

            //}
            //SqlCommand comando = new SqlCommand(consulta, conexion);        
            //comando.ExecuteReader();
            //conexion.Close();
        }
    }
}

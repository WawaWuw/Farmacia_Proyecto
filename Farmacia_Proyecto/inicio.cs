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
    public partial class inicio : Form
    {
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-1LQHI27;database=Proyecto_Farmaci;integrated security=true");
        public inicio()
        {
            InitializeComponent();
        }
        public bool confirmacion()
        {
            bool ok = true;

            if (texID.Text == "")
            {
                ok = false;
                errorcito.SetError(texID, "Ingresar ID");
            }

            if (texcontra.Text == "")
            {
                ok = false;
                errorcito.SetError(texcontra, "Ingresar Contraseña");
            }
        
            return ok;
        }
        public void borrarerror()
        {
            errorcito.SetError(texID, "");
            errorcito.SetError(texcontra, "");
            
        }
        public bool login()
        {
            conexion.Open();
            string consulta = "select * from Empleado where ID_Empleado="+texID.Text+" and contraseña ='"+texcontra.Text+"'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();           
            if (lector.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
                 
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            borrarerror();
            if (confirmacion())
            {
                if (login())
                {
                    Form1 principal = new Form1();
                    principal.Show();
                    this.Hide();
                    conexion.Close();
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectos");
                    conexion.Close();
                }
            }
          else
                MessageBox.Show("Ingrese valores validos");
            conexion.Close();
        }
    }
}

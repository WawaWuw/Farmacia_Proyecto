using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_Proyecto
{
    public partial class VentasR : Form
    {
        public VentasR()
        {
            
            InitializeComponent();
            labelF.Text = DateTime.Now.ToLongDateString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }
    }
}

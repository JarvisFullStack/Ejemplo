using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnholamundo_Click(object sender, EventArgs e)
        {
            lblholamundo.Text = "Hola Mundo!\nPrimera Prueba.";
        }

        private void lblholamundo_Click(object sender, EventArgs e)
        {

        }
    }
}

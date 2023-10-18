using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiberKiosco
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCiber frm = new frmCiber();
            frm.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void Productosbutton_Click(object sender, EventArgs e)
        {
            frmProductos frm = new frmProductos();  
            frm.ShowDialog();
        }

        private void SociosButton_Click(object sender, EventArgs e)
        {
            frmSocios frm = new frmSocios();
            frm.ShowDialog();
        }
    }
}

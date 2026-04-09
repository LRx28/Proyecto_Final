using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

        }

        private void btnMenuPais_Click(object sender, EventArgs e)
        {
            FrmPais frm = new FrmPais();
            frm.Show();

        }

        private void btnMenuDestino_Click(object sender, EventArgs e)
        {
            FrmDestinos frm = new FrmDestinos();
            frm.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnMenuTours_Click(object sender, EventArgs e)
        {
            FrmTours frm = new FrmTours();
            frm.Show();
        }
    }
}

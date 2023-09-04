using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryCantallopsIE
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void toolFecha_Click(object sender, EventArgs e)
        {

        }

        int contador = 0;
        private void timerHora_Tick(object sender, EventArgs e)
        {
            contador += 1000;
            toolFecha.Text = DateTime.Now.ToLongDateString();
            toolHora.Text = Convert.ToString(DateTime.Now);
        }
    }
}

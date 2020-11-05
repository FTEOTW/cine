using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cine.database;
using Cine.ventana_consultas;
using Cine.utils;
namespace Cine
{
    public partial class Cine : Form
    {
        private Control aux = null;
        public Cine()
        {
            InitializeComponent();
        }

        private void ChangeControl(Control control)
        {
            if(aux == null)
            {
                splitContainer1.Panel2.Controls.Add(control);
                aux = control;
            }
            else
            {
                splitContainer1.Panel2.Controls.Remove(aux);
                splitContainer1.Panel2.Controls.Add(control);
                aux = control;
            }
            
        }

        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            ChangeControl(new Consulta1());
        }

        private void btnConsulta2_Click_1(object sender, EventArgs e)
        {
            ChangeControl(new Consulta2());
        }

        private void btnConsulta3_Click_1(object sender, EventArgs e)
        {
            ChangeControl(new Consulta3());
        }

        private void btnConsulta4_Click(object sender, EventArgs e)
        {
            ChangeControl(new Consulta4());
        }

        private void btnConsulta5_Click(object sender, EventArgs e)
        {
            ChangeControl(new Consulta5());
        }

        private void btnConsulta6_Click(object sender, EventArgs e)
        {
            ChangeControl(new Consulta6());
        }

        private void btnConsulta7_Click(object sender, EventArgs e)
        {
            ChangeControl(new Consulta7());
        }

        private void btnConsulta8_Click(object sender, EventArgs e)
        {
            ChangeControl(new Consulta8());
        }
    }
}

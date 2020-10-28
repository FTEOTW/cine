using Cine.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.ventana_consultas
{
    class Consulta3 : Form
    {
        private Label lblConsulta2;
        private TextBox txtCantidadAnios;
        private DataGridView dgvConsulta1;
        private Button btnConsulta;

        public Consulta3()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblConsulta2 = new System.Windows.Forms.Label();
            this.txtCantidadAnios = new System.Windows.Forms.TextBox();
            this.dgvConsulta1 = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsulta2
            // 
            this.lblConsulta2.AutoSize = true;
            this.lblConsulta2.Location = new System.Drawing.Point(12, 16);
            this.lblConsulta2.Name = "lblConsulta2";
            this.lblConsulta2.Size = new System.Drawing.Size(258, 13);
            this.lblConsulta2.TabIndex = 11;
            this.lblConsulta2.Text = "Recaudación total por película de los últimos X años.";
            // 
            // txtCantidadAnios
            // 
            this.txtCantidadAnios.Location = new System.Drawing.Point(458, 16);
            this.txtCantidadAnios.Name = "txtCantidadAnios";
            this.txtCantidadAnios.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadAnios.TabIndex = 10;
            // 
            // dgvConsulta1
            // 
            this.dgvConsulta1.AllowUserToAddRows = false;
            this.dgvConsulta1.AllowUserToDeleteRows = false;
            this.dgvConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta1.Location = new System.Drawing.Point(12, 52);
            this.dgvConsulta1.Name = "dgvConsulta1";
            this.dgvConsulta1.ReadOnly = true;
            this.dgvConsulta1.RowTemplate.Height = 24;
            this.dgvConsulta1.Size = new System.Drawing.Size(546, 218);
            this.dgvConsulta1.TabIndex = 9;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(356, 286);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(202, 52);
            this.btnConsulta.TabIndex = 8;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // Consulta3
            // 
            this.ClientSize = new System.Drawing.Size(571, 346);
            this.Controls.Add(this.lblConsulta2);
            this.Controls.Add(this.txtCantidadAnios);
            this.Controls.Add(this.dgvConsulta1);
            this.Controls.Add(this.btnConsulta);
            this.Name = "Consulta3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaDB con = new ConsultaDB();
            con.ejecutarConsulta("exec consulta3 " + txtCantidadAnios.Text, 1);
            dgvConsulta1.DataSource = con.pGetTable;
        }
    }
}

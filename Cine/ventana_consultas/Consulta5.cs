using Cine.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.ventana_consultas
{
    class Consulta5 : Form
    {
        private DataGridView dgvConsulta5;
        private TextBox txtEdadFrom;
        private MaskedTextBox txtEdadTo;
        private Button btnConsulta;

        public Consulta5()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnConsulta = new System.Windows.Forms.Button();
            this.dgvConsulta5 = new System.Windows.Forms.DataGridView();
            this.txtEdadFrom = new System.Windows.Forms.TextBox();
            this.txtEdadTo = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(626, 356);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvConsulta5
            // 
            this.dgvConsulta5.AllowUserToAddRows = false;
            this.dgvConsulta5.AllowUserToDeleteRows = false;
            this.dgvConsulta5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta5.Location = new System.Drawing.Point(9, 132);
            this.dgvConsulta5.Name = "dgvConsulta5";
            this.dgvConsulta5.ReadOnly = true;
            this.dgvConsulta5.RowTemplate.Height = 24;
            this.dgvConsulta5.Size = new System.Drawing.Size(692, 218);
            this.dgvConsulta5.TabIndex = 3;
            // 
            // txtEdadFrom
            // 
            this.txtEdadFrom.Location = new System.Drawing.Point(466, 91);
            this.txtEdadFrom.Name = "txtEdadFrom";
            this.txtEdadFrom.Size = new System.Drawing.Size(100, 20);
            this.txtEdadFrom.TabIndex = 4;
            // 
            // txtEdadTo
            // 
            this.txtEdadTo.Location = new System.Drawing.Point(601, 91);
            this.txtEdadTo.Name = "txtEdadTo";
            this.txtEdadTo.Size = new System.Drawing.Size(100, 20);
            this.txtEdadTo.TabIndex = 5;
            // 
            // Consulta5
            // 
            this.ClientSize = new System.Drawing.Size(713, 391);
            this.Controls.Add(this.txtEdadTo);
            this.Controls.Add(this.txtEdadFrom);
            this.Controls.Add(this.dgvConsulta5);
            this.Controls.Add(this.btnConsulta);
            this.Name = "Consulta5";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaDB con = new ConsultaDB();

            int edadFrom = Convert.ToInt32(txtEdadFrom.Text);
            int edadTo =   Convert.ToInt32(txtEdadTo.Text);

            con.ejecutarConsulta("exec consulta5 " + edadFrom  + edadTo , 1); //TODO  Parametrizacion consulta 5

            dgvConsulta5.DataSource = con.pGetTable;
        }
    }
}

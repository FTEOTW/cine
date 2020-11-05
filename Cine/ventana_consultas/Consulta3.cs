using Cine.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.ventana_consultas
{
    class Consulta3 : Control
    {
        private TextBox txtCantidadAnios;
        private DataGridView dgvConsulta1;
        private Label lblRow;
        private Label label6;
        private Button btnConsulta;

        public Consulta3()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtCantidadAnios = new System.Windows.Forms.TextBox();
            this.dgvConsulta1 = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lblRow = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidadAnios
            // 
            this.txtCantidadAnios.Location = new System.Drawing.Point(458, 16);
            this.txtCantidadAnios.Name = "txtCantidadAnios";
            this.txtCantidadAnios.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadAnios.TabIndex = 10;
            this.txtCantidadAnios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadAnios_KeyPress);
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
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(9, 306);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(0, 13);
            this.lblRow.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(411, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Recaudación total por película de los últimos  X años";
            // 
            // Consulta3
            // 
            this.ClientSize = new System.Drawing.Size(571, 346);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.txtCantidadAnios);
            this.Controls.Add(this.dgvConsulta1);
            this.Controls.Add(this.btnConsulta);
            this.Name = "Consulta3";
            this.Text = "Consulta 3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaDB con = new ConsultaDB();
            if (String.IsNullOrEmpty(txtCantidadAnios.Text))
            {
                MessageBox.Show("El valor del campo no debe estar vacio");
                txtCantidadAnios.Focus();
            }
            else
            {
                con.ejecutarConsulta("exec consulta3 " + txtCantidadAnios.Text, 1);
                dgvConsulta1.DataSource = con.pGetTable;
                lblRow.Text = Convert.ToString(dgvConsulta1.RowCount) + " rows";
            }
        }

        private void txtCantidadAnios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

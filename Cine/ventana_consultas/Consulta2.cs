using Cine.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cine.utils;
namespace Cine.ventana_consultas
{
    class Consulta2 : Form
    {
        private DataGridView dgvConsulta1;
        private TextBox txtCantidadVisitas;
        private Label lblConsulta2;
        private Label lblRow;
        private Label lblCantidad;
        private TextBox cmbAnio;
        private Label label1;
        private Button btnConsulta;

        public Consulta2()
        {
            InitializeComponent();
            //new LoadInfo().CargarCombo(cmbo)
        }

        private void InitializeComponent()
        {
            this.dgvConsulta1 = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtCantidadVisitas = new System.Windows.Forms.TextBox();
            this.lblConsulta2 = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmbAnio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsulta1
            // 
            this.dgvConsulta1.AllowUserToAddRows = false;
            this.dgvConsulta1.AllowUserToDeleteRows = false;
            this.dgvConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta1.Location = new System.Drawing.Point(15, 110);
            this.dgvConsulta1.Name = "dgvConsulta1";
            this.dgvConsulta1.ReadOnly = true;
            this.dgvConsulta1.RowTemplate.Height = 24;
            this.dgvConsulta1.Size = new System.Drawing.Size(731, 218);
            this.dgvConsulta1.TabIndex = 5;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(544, 344);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(202, 52);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtCantidadVisitas
            // 
            this.txtCantidadVisitas.Location = new System.Drawing.Point(120, 48);
            this.txtCantidadVisitas.Name = "txtCantidadVisitas";
            this.txtCantidadVisitas.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadVisitas.TabIndex = 6;
            this.txtCantidadVisitas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadVisitas_KeyPress);
            // 
            // lblConsulta2
            // 
            this.lblConsulta2.AutoSize = true;
            this.lblConsulta2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta2.Location = new System.Drawing.Point(12, 9);
            this.lblConsulta2.Name = "lblConsulta2";
            this.lblConsulta2.Size = new System.Drawing.Size(670, 19);
            this.lblConsulta2.TabIndex = 7;
            this.lblConsulta2.Text = "Todas las visitas al cine hechas por clientes que fueron X veces algun año con re" +
    "serva ";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(12, 306);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(0, 13);
            this.lblRow.TabIndex = 8;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(12, 49);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 18);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cmbAnio
            // 
            this.cmbAnio.Location = new System.Drawing.Point(120, 76);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(100, 20);
            this.cmbAnio.TabIndex = 11;
            this.cmbAnio.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Año";
            this.label1.Visible = false;
            // 
            // Consulta2
            // 
            this.ClientSize = new System.Drawing.Size(758, 408);
            this.Controls.Add(this.cmbAnio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.lblConsulta2);
            this.Controls.Add(this.txtCantidadVisitas);
            this.Controls.Add(this.dgvConsulta1);
            this.Controls.Add(this.btnConsulta);
            this.Name = "Consulta2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta 2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaDB con = new ConsultaDB();
            if (String.IsNullOrEmpty(txtCantidadVisitas.Text))
            {
                MessageBox.Show("El valor del campo no debe estar vacio");
                txtCantidadVisitas.Focus();
            }
            else
            {
                con.ejecutarConsulta("exec consulta2 " + txtCantidadVisitas.Text, 1);
                dgvConsulta1.DataSource = con.pGetTable;
                lblRow.Text = Convert.ToString(dgvConsulta1.RowCount) + " rows";
            }
        }

        private void txtCantidadVisitas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

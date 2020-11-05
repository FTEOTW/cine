using Cine.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.ventana_consultas
{
    class Consulta5 : Control
    {
        private DataGridView dgvConsulta5;
        private TextBox txtEdadFrom;
        private MaskedTextBox txtEdadTo;
        private Label label1;
        private Label label2;
        private Label lblRow;
        private Label label6;
        private Button btnConsulta5;

        public Consulta5()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnConsulta5 = new System.Windows.Forms.Button();
            this.dgvConsulta5 = new System.Windows.Forms.DataGridView();
            this.txtEdadFrom = new System.Windows.Forms.TextBox();
            this.txtEdadTo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta5
            // 
            this.btnConsulta5.Location = new System.Drawing.Point(499, 369);
            this.btnConsulta5.Name = "btnConsulta5";
            this.btnConsulta5.Size = new System.Drawing.Size(202, 52);
            this.btnConsulta5.TabIndex = 0;
            this.btnConsulta5.Text = "Consulta";
            this.btnConsulta5.UseVisualStyleBackColor = true;
            this.btnConsulta5.Click += new System.EventHandler(this.button1_Click);
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
            this.txtEdadFrom.Location = new System.Drawing.Point(78, 53);
            this.txtEdadFrom.Name = "txtEdadFrom";
            this.txtEdadFrom.Size = new System.Drawing.Size(100, 20);
            this.txtEdadFrom.TabIndex = 4;
            this.txtEdadFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdadFrom_KeyPress);
            // 
            // txtEdadTo
            // 
            this.txtEdadTo.Location = new System.Drawing.Point(78, 86);
            this.txtEdadTo.Name = "txtEdadTo";
            this.txtEdadTo.Size = new System.Drawing.Size(100, 20);
            this.txtEdadTo.TabIndex = 5;
            this.txtEdadTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdadTo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Hasta";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(12, 389);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(0, 13);
            this.lblRow.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(496, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Peliculas que fueron vistas por clientees en un rango de edad  X";
            // 
            // Consulta5
            // 
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEdadTo);
            this.Controls.Add(this.txtEdadFrom);
            this.Controls.Add(this.dgvConsulta5);
            this.Controls.Add(this.btnConsulta5);
            this.Name = "Consulta5";
            this.Text = "Consulta 5";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaDB con = new ConsultaDB();
            if (String.IsNullOrEmpty(txtEdadFrom.Text) || String.IsNullOrEmpty(txtEdadTo.Text))
            {
                MessageBox.Show("El valor del campo no debe estar vacio");
            }
            else
            {
                int edadFrom = Convert.ToInt32(txtEdadFrom.Text);
                int edadTo = Convert.ToInt32(txtEdadTo.Text);
                con.ejecutarConsulta("exec consulta5 " + edadFrom + "," + edadTo, 1);
                //con.ejecutarConsulta("exec consulta5 30, 40", 1);
                dgvConsulta5.DataSource = con.pGetTable;
                lblRow.Text = Convert.ToString(dgvConsulta5.RowCount) + " rows";
            }

            
        }

        private void txtEdadFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEdadTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

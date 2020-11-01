using Cine.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.ventana_consultas
{
    class Consulta7 : Form
    {
        private Label lblConsulta2;
        private TextBox txtnombreActorTo;
        private DataGridView dgvConsulta1;
        private TextBox txtApellidoTo;
        private TextBox txtApellidoFrom;
        private TextBox txtnombreActorFrom;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblRow;
        private Button btnConsulta;

        public Consulta7()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblConsulta2 = new System.Windows.Forms.Label();
            this.txtnombreActorTo = new System.Windows.Forms.TextBox();
            this.dgvConsulta1 = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtApellidoTo = new System.Windows.Forms.TextBox();
            this.txtApellidoFrom = new System.Windows.Forms.TextBox();
            this.txtnombreActorFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsulta2
            // 
            this.lblConsulta2.AutoSize = true;
            this.lblConsulta2.Location = new System.Drawing.Point(9, 19);
            this.lblConsulta2.Name = "lblConsulta2";
            this.lblConsulta2.Size = new System.Drawing.Size(367, 13);
            this.lblConsulta2.TabIndex = 15;
            this.lblConsulta2.Text = "Listado de actores donde su nombre no comience con las letras A hasta la F";
            // 
            // txtnombreActorTo
            // 
            this.txtnombreActorTo.Location = new System.Drawing.Point(544, 19);
            this.txtnombreActorTo.MaxLength = 1;
            this.txtnombreActorTo.Name = "txtnombreActorTo";
            this.txtnombreActorTo.Size = new System.Drawing.Size(100, 20);
            this.txtnombreActorTo.TabIndex = 14;
            this.txtnombreActorTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombreActorTo_KeyPress);
            // 
            // dgvConsulta1
            // 
            this.dgvConsulta1.AllowUserToAddRows = false;
            this.dgvConsulta1.AllowUserToDeleteRows = false;
            this.dgvConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta1.Location = new System.Drawing.Point(12, 87);
            this.dgvConsulta1.Name = "dgvConsulta1";
            this.dgvConsulta1.ReadOnly = true;
            this.dgvConsulta1.RowTemplate.Height = 24;
            this.dgvConsulta1.Size = new System.Drawing.Size(652, 218);
            this.dgvConsulta1.TabIndex = 13;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(455, 331);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(202, 52);
            this.btnConsulta.TabIndex = 12;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtApellidoTo
            // 
            this.txtApellidoTo.Location = new System.Drawing.Point(403, 61);
            this.txtApellidoTo.MaxLength = 1;
            this.txtApellidoTo.Name = "txtApellidoTo";
            this.txtApellidoTo.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoTo.TabIndex = 16;
            this.txtApellidoTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoTo_KeyPress);
            // 
            // txtApellidoFrom
            // 
            this.txtApellidoFrom.Location = new System.Drawing.Point(547, 61);
            this.txtApellidoFrom.MaxLength = 1;
            this.txtApellidoFrom.Name = "txtApellidoFrom";
            this.txtApellidoFrom.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoFrom.TabIndex = 17;
            this.txtApellidoFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoFrom_KeyPress);
            // 
            // txtnombreActorFrom
            // 
            this.txtnombreActorFrom.Location = new System.Drawing.Point(403, 19);
            this.txtnombreActorFrom.MaxLength = 1;
            this.txtnombreActorFrom.Name = "txtnombreActorFrom";
            this.txtnombreActorFrom.Size = new System.Drawing.Size(100, 20);
            this.txtnombreActorFrom.TabIndex = 18;
            this.txtnombreActorFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombreActorFrom_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre actor desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre actor hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Apellido Director desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Apellido Director hasta";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(12, 351);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(0, 13);
            this.lblRow.TabIndex = 23;
            // 
            // Consulta7
            // 
            this.ClientSize = new System.Drawing.Size(669, 391);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombreActorFrom);
            this.Controls.Add(this.txtApellidoFrom);
            this.Controls.Add(this.txtApellidoTo);
            this.Controls.Add(this.lblConsulta2);
            this.Controls.Add(this.txtnombreActorTo);
            this.Controls.Add(this.dgvConsulta1);
            this.Controls.Add(this.btnConsulta);
            this.Name = "Consulta7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta 7";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaDB con = new ConsultaDB();
            if (String.IsNullOrEmpty(txtnombreActorFrom.Text) || String.IsNullOrEmpty(txtnombreActorTo.Text) || String.IsNullOrEmpty(txtApellidoFrom.Text) || String.IsNullOrEmpty(txtApellidoTo.Text))
            {
                MessageBox.Show("El valor del campo no debe estar vacio");
            }
            else
            {
                // exec consulta7 'a','f','s','z'
                con.ejecutarConsulta("exec consulta7 " + "'" + txtnombreActorFrom.Text + "'," + "'" + txtnombreActorTo.Text + "'," +
               "'" + txtApellidoFrom.Text + "'," + "'" + txtApellidoTo.Text + "'", 1);

                dgvConsulta1.DataSource = con.pGetTable;
                lblRow.Text = Convert.ToString(dgvConsulta1.RowCount) + " rows";
            }
        }

        private void txtnombreActorFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtnombreActorTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtApellidoTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtApellidoFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}

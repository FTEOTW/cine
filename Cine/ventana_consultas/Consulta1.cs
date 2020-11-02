using Cine.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cine.utils;
namespace Cine
{
    public partial class Consulta1 : Control
    {
        private Button btnConsulta;
        private DataGridView dgvConsulta1;
        private Label label1;
        private Label lblRow;
        private ComboBox cmbMediosVenta;
        private Label label2;
        private Label label3;
        private ComboBox cmbAnio;

        public Consulta1()
        {
            InitializeComponent();
            new LoadInfo().CargarCombo(cmbMediosVenta, "sp_MediosdeVenta");
            new LoadInfo().CargarCombo(cmbAnio, "sp_anios");
        }

        private void InitializeComponent()
        {
            this.btnConsulta = new System.Windows.Forms.Button();
            this.dgvConsulta1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.cmbMediosVenta = new System.Windows.Forms.ComboBox();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(502, 346);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(202, 52);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // dgvConsulta1
            // 
            this.dgvConsulta1.AllowUserToAddRows = false;
            this.dgvConsulta1.AllowUserToDeleteRows = false;
            this.dgvConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta1.Location = new System.Drawing.Point(15, 122);
            this.dgvConsulta1.Name = "dgvConsulta1";
            this.dgvConsulta1.ReadOnly = true;
            this.dgvConsulta1.RowTemplate.Height = 24;
            this.dgvConsulta1.Size = new System.Drawing.Size(692, 218);
            this.dgvConsulta1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = " Recaudación mensual, por medio de venta, para el año seleccionado";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(12, 366);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(0, 13);
            this.lblRow.TabIndex = 4;
            // 
            // cmbMediosVenta
            // 
            this.cmbMediosVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMediosVenta.FormattingEnabled = true;
            this.cmbMediosVenta.Location = new System.Drawing.Point(167, 86);
            this.cmbMediosVenta.Name = "cmbMediosVenta";
            this.cmbMediosVenta.Size = new System.Drawing.Size(98, 21);
            this.cmbMediosVenta.Sorted = true;
            this.cmbMediosVenta.TabIndex = 5;
            // 
            // cmbAnio
            // 
            this.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(167, 53);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(98, 21);
            this.cmbAnio.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Medio de Venta";
            // 
            // Consulta1
            // 
            this.ClientSize = new System.Drawing.Size(725, 416);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAnio);
            this.Controls.Add(this.cmbMediosVenta);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsulta1);
            this.Controls.Add(this.btnConsulta);
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Consulta1";
            //this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta 1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaDB con = new ConsultaDB();
            con.ejecutarConsulta("exec consulta1 " + cmbAnio.Text + "," + cmbMediosVenta.SelectedValue, 1);
            dgvConsulta1.DataSource = con.pGetTable;
            lblRow.Text = Convert.ToString(dgvConsulta1.RowCount) + " rows"; 
        }

    }
}
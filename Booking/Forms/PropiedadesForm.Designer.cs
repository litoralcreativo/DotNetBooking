
namespace Booking
{
    partial class PropiedadesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ckbDesayuno = new System.Windows.Forms.CheckBox();
            this.ckbPiscina = new System.Windows.Forms.CheckBox();
            this.ckbCochera = new System.Windows.Forms.CheckBox();
            this.ckbWifi = new System.Windows.Forms.CheckBox();
            this.ckbAC = new System.Windows.Forms.CheckBox();
            this.ckbMascotas = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ckbHotel = new System.Windows.Forms.CheckBox();
            this.ckbCasaFDS = new System.Windows.Forms.CheckBox();
            this.ckbCasaPorDia = new System.Windows.Forms.CheckBox();
            this.refColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plazasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnDesayuno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnMascotas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnWifi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnCochera = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnPiscina = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPrecioMaximo = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Wheat;
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1264, 28);
            this.headerPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F);
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "PROPIEDADES";
            // 
            // dgv
            // 
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refColumn,
            this.typeColumn,
            this.priceColumn,
            this.plazasColumn,
            this.localidadColumn,
            this.nameColumn,
            this.dirColumn,
            this.columnAC,
            this.columnDesayuno,
            this.columnMascotas,
            this.columnWifi,
            this.columnCochera,
            this.columnPiscina});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 28);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(857, 469);
            this.dgv.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(857, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 469);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 279);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar Propiedad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 80);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Servicios";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ckbDesayuno);
            this.flowLayoutPanel1.Controls.Add(this.ckbPiscina);
            this.flowLayoutPanel1.Controls.Add(this.ckbCochera);
            this.flowLayoutPanel1.Controls.Add(this.ckbWifi);
            this.flowLayoutPanel1.Controls.Add(this.ckbAC);
            this.flowLayoutPanel1.Controls.Add(this.ckbMascotas);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(362, 60);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // ckbDesayuno
            // 
            this.ckbDesayuno.AutoSize = true;
            this.ckbDesayuno.Location = new System.Drawing.Point(3, 3);
            this.ckbDesayuno.Name = "ckbDesayuno";
            this.ckbDesayuno.Size = new System.Drawing.Size(81, 19);
            this.ckbDesayuno.TabIndex = 0;
            this.ckbDesayuno.Text = "Desayuno";
            this.ckbDesayuno.UseVisualStyleBackColor = true;
            this.ckbDesayuno.CheckedChanged += new System.EventHandler(this.ckbDesayuno_CheckedChanged);
            // 
            // ckbPiscina
            // 
            this.ckbPiscina.AutoSize = true;
            this.ckbPiscina.Location = new System.Drawing.Point(90, 3);
            this.ckbPiscina.Name = "ckbPiscina";
            this.ckbPiscina.Size = new System.Drawing.Size(66, 19);
            this.ckbPiscina.TabIndex = 0;
            this.ckbPiscina.Text = "Piscina";
            this.ckbPiscina.UseVisualStyleBackColor = true;
            this.ckbPiscina.CheckedChanged += new System.EventHandler(this.ckbPiscina_CheckedChanged);
            // 
            // ckbCochera
            // 
            this.ckbCochera.AutoSize = true;
            this.ckbCochera.Location = new System.Drawing.Point(162, 3);
            this.ckbCochera.Name = "ckbCochera";
            this.ckbCochera.Size = new System.Drawing.Size(72, 19);
            this.ckbCochera.TabIndex = 2;
            this.ckbCochera.Text = "Cochera";
            this.ckbCochera.UseVisualStyleBackColor = true;
            this.ckbCochera.CheckedChanged += new System.EventHandler(this.ckbCochera_CheckedChanged);
            // 
            // ckbWifi
            // 
            this.ckbWifi.AutoSize = true;
            this.ckbWifi.Location = new System.Drawing.Point(240, 3);
            this.ckbWifi.Name = "ckbWifi";
            this.ckbWifi.Size = new System.Drawing.Size(46, 19);
            this.ckbWifi.TabIndex = 0;
            this.ckbWifi.Text = "Wifi";
            this.ckbWifi.UseVisualStyleBackColor = true;
            this.ckbWifi.CheckedChanged += new System.EventHandler(this.ckbWifi_CheckedChanged);
            // 
            // ckbAC
            // 
            this.ckbAC.AutoSize = true;
            this.ckbAC.Location = new System.Drawing.Point(292, 3);
            this.ckbAC.Name = "ckbAC";
            this.ckbAC.Size = new System.Drawing.Size(41, 19);
            this.ckbAC.TabIndex = 1;
            this.ckbAC.Text = "AC";
            this.ckbAC.UseVisualStyleBackColor = true;
            this.ckbAC.CheckedChanged += new System.EventHandler(this.ckbAC_CheckedChanged);
            // 
            // ckbMascotas
            // 
            this.ckbMascotas.AutoSize = true;
            this.ckbMascotas.Location = new System.Drawing.Point(3, 28);
            this.ckbMascotas.Name = "ckbMascotas";
            this.ckbMascotas.Size = new System.Drawing.Size(79, 19);
            this.ckbMascotas.TabIndex = 3;
            this.ckbMascotas.Text = "Mascotas";
            this.ckbMascotas.UseVisualStyleBackColor = true;
            this.ckbMascotas.CheckedChanged += new System.EventHandler(this.ckbMascotas_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 49);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Propiedad";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.ckbHotel);
            this.flowLayoutPanel2.Controls.Add(this.ckbCasaFDS);
            this.flowLayoutPanel2.Controls.Add(this.ckbCasaPorDia);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(365, 29);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // ckbHotel
            // 
            this.ckbHotel.AutoSize = true;
            this.ckbHotel.Checked = true;
            this.ckbHotel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbHotel.Location = new System.Drawing.Point(3, 3);
            this.ckbHotel.Name = "ckbHotel";
            this.ckbHotel.Size = new System.Drawing.Size(55, 19);
            this.ckbHotel.TabIndex = 0;
            this.ckbHotel.Text = "Hotel";
            this.ckbHotel.UseVisualStyleBackColor = true;
            this.ckbHotel.CheckedChanged += new System.EventHandler(this.ckbHotel_CheckedChanged);
            // 
            // ckbCasaFDS
            // 
            this.ckbCasaFDS.AutoSize = true;
            this.ckbCasaFDS.Checked = true;
            this.ckbCasaFDS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbCasaFDS.Location = new System.Drawing.Point(64, 3);
            this.ckbCasaFDS.Name = "ckbCasaFDS";
            this.ckbCasaFDS.Size = new System.Drawing.Size(152, 19);
            this.ckbCasaFDS.TabIndex = 1;
            this.ckbCasaFDS.Text = "Casa de fin de semana";
            this.ckbCasaFDS.UseVisualStyleBackColor = true;
            this.ckbCasaFDS.CheckedChanged += new System.EventHandler(this.ckbCasaFDS_CheckedChanged);
            // 
            // ckbCasaPorDia
            // 
            this.ckbCasaPorDia.AutoSize = true;
            this.ckbCasaPorDia.Checked = true;
            this.ckbCasaPorDia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbCasaPorDia.Location = new System.Drawing.Point(222, 3);
            this.ckbCasaPorDia.Name = "ckbCasaPorDia";
            this.ckbCasaPorDia.Size = new System.Drawing.Size(95, 19);
            this.ckbCasaPorDia.TabIndex = 2;
            this.ckbCasaPorDia.Text = "Casa por día";
            this.ckbCasaPorDia.UseVisualStyleBackColor = true;
            this.ckbCasaPorDia.CheckedChanged += new System.EventHandler(this.ckbCasaPorDia_CheckedChanged);
            // 
            // refColumn
            // 
            this.refColumn.HeaderText = "ref";
            this.refColumn.MinimumWidth = 40;
            this.refColumn.Name = "refColumn";
            this.refColumn.ReadOnly = true;
            this.refColumn.Width = 40;
            // 
            // typeColumn
            // 
            this.typeColumn.HeaderText = "Tipo";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.ReadOnly = true;
            this.typeColumn.Width = 150;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Precio";
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            // 
            // plazasColumn
            // 
            this.plazasColumn.HeaderText = "Plazas";
            this.plazasColumn.Name = "plazasColumn";
            this.plazasColumn.ReadOnly = true;
            this.plazasColumn.Width = 50;
            // 
            // localidadColumn
            // 
            this.localidadColumn.HeaderText = "Localidad";
            this.localidadColumn.Name = "localidadColumn";
            this.localidadColumn.ReadOnly = true;
            this.localidadColumn.Width = 80;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Nombre";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // dirColumn
            // 
            this.dirColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dirColumn.HeaderText = "Direccion";
            this.dirColumn.Name = "dirColumn";
            this.dirColumn.ReadOnly = true;
            // 
            // columnAC
            // 
            this.columnAC.HeaderText = "AC";
            this.columnAC.Name = "columnAC";
            this.columnAC.ReadOnly = true;
            this.columnAC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnAC.Width = 35;
            // 
            // columnDesayuno
            // 
            this.columnDesayuno.HeaderText = "Desa";
            this.columnDesayuno.Name = "columnDesayuno";
            this.columnDesayuno.ReadOnly = true;
            this.columnDesayuno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnDesayuno.Width = 35;
            // 
            // columnMascotas
            // 
            this.columnMascotas.HeaderText = "Masc";
            this.columnMascotas.Name = "columnMascotas";
            this.columnMascotas.ReadOnly = true;
            this.columnMascotas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnMascotas.Width = 35;
            // 
            // columnWifi
            // 
            this.columnWifi.HeaderText = "Wifi";
            this.columnWifi.Name = "columnWifi";
            this.columnWifi.ReadOnly = true;
            this.columnWifi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnWifi.Width = 35;
            // 
            // columnCochera
            // 
            this.columnCochera.HeaderText = "Coch";
            this.columnCochera.Name = "columnCochera";
            this.columnCochera.ReadOnly = true;
            this.columnCochera.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnCochera.Width = 35;
            // 
            // columnPiscina
            // 
            this.columnPiscina.HeaderText = "Pisc";
            this.columnPiscina.Name = "columnPiscina";
            this.columnPiscina.ReadOnly = true;
            this.columnPiscina.Width = 35;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 100;
            this.trackBar1.Location = new System.Drawing.Point(6, 19);
            this.trackBar1.Maximum = 5000;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(292, 45);
            this.trackBar1.SmallChange = 100;
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Value = 5000;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPrecioMaximo);
            this.groupBox4.Controls.Add(this.trackBar1);
            this.groupBox4.Location = new System.Drawing.Point(12, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(365, 72);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Precio Maximo";
            // 
            // lblPrecioMaximo
            // 
            this.lblPrecioMaximo.AutoSize = true;
            this.lblPrecioMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrecioMaximo.Location = new System.Drawing.Point(304, 19);
            this.lblPrecioMaximo.Name = "lblPrecioMaximo";
            this.lblPrecioMaximo.Size = new System.Drawing.Size(48, 17);
            this.lblPrecioMaximo.TabIndex = 13;
            this.lblPrecioMaximo.Text = "$5000";
            // 
            // PropiedadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1264, 497);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerPanel);
            this.Name = "PropiedadesForm";
            this.Text = "PropiedadesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PropiedadesForm_FormClosing);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox ckbHotel;
        private System.Windows.Forms.CheckBox ckbCasaFDS;
        private System.Windows.Forms.CheckBox ckbCasaPorDia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.CheckBox ckbDesayuno;
        public System.Windows.Forms.CheckBox ckbPiscina;
        public System.Windows.Forms.CheckBox ckbCochera;
        public System.Windows.Forms.CheckBox ckbWifi;
        public System.Windows.Forms.CheckBox ckbAC;
        public System.Windows.Forms.CheckBox ckbMascotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn refColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plazasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnAC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnDesayuno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnMascotas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnWifi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnCochera;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnPiscina;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblPrecioMaximo;
    }
}
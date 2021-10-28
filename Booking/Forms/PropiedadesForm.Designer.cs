
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnDisponibilidad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pbSegunda = new System.Windows.Forms.PictureBox();
            this.pbPrimera = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbPlazasMinimas = new System.Windows.Forms.RadioButton();
            this.lblPlazas = new System.Windows.Forms.Label();
            this.rbPlazasExactas = new System.Windows.Forms.RadioButton();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nudMaxValue = new System.Windows.Forms.NumericUpDown();
            this.nudMinValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrecioMaximo = new System.Windows.Forms.Label();
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSegunda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrimera)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinValue)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Wheat;
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1224, 28);
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
            this.dgv.AllowUserToAddRows = false;
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
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(858, 498);
            this.dgv.TabIndex = 4;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnDisponibilidad);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(858, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 498);
            this.panel1.TabIndex = 7;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.BackColor = System.Drawing.Color.OldLace;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Location = new System.Drawing.Point(12, 411);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(320, 27);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnDisponibilidad
            // 
            this.btnDisponibilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisponibilidad.BackColor = System.Drawing.Color.OldLace;
            this.btnDisponibilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisponibilidad.Location = new System.Drawing.Point(237, 460);
            this.btnDisponibilidad.Name = "btnDisponibilidad";
            this.btnDisponibilidad.Size = new System.Drawing.Size(117, 26);
            this.btnDisponibilidad.TabIndex = 8;
            this.btnDisponibilidad.Text = "Ver Disponibilidad";
            this.btnDisponibilidad.UseVisualStyleBackColor = false;
            this.btnDisponibilidad.Click += new System.EventHandler(this.btnDisponibilidad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 444);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar Propiedad";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pbSegunda);
            this.groupBox6.Controls.Add(this.pbPrimera);
            this.groupBox6.Location = new System.Drawing.Point(12, 244);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(320, 161);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Imagenes";
            // 
            // pbSegunda
            // 
            this.pbSegunda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSegunda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSegunda.Location = new System.Drawing.Point(162, 19);
            this.pbSegunda.Name = "pbSegunda";
            this.pbSegunda.Size = new System.Drawing.Size(146, 130);
            this.pbSegunda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSegunda.TabIndex = 15;
            this.pbSegunda.TabStop = false;
            // 
            // pbPrimera
            // 
            this.pbPrimera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPrimera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPrimera.Location = new System.Drawing.Point(10, 19);
            this.pbPrimera.Name = "pbPrimera";
            this.pbPrimera.Size = new System.Drawing.Size(146, 130);
            this.pbPrimera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrimera.TabIndex = 15;
            this.pbPrimera.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbPlazasMinimas);
            this.groupBox5.Controls.Add(this.lblPlazas);
            this.groupBox5.Controls.Add(this.rbPlazasExactas);
            this.groupBox5.Controls.Add(this.trackBar2);
            this.groupBox5.Location = new System.Drawing.Point(184, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(148, 78);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Plazas";
            // 
            // rbPlazasMinimas
            // 
            this.rbPlazasMinimas.AutoSize = true;
            this.rbPlazasMinimas.Checked = true;
            this.rbPlazasMinimas.Location = new System.Drawing.Point(75, 49);
            this.rbPlazasMinimas.Name = "rbPlazasMinimas";
            this.rbPlazasMinimas.Size = new System.Drawing.Size(63, 17);
            this.rbPlazasMinimas.TabIndex = 14;
            this.rbPlazasMinimas.TabStop = true;
            this.rbPlazasMinimas.Text = "Minimas";
            this.rbPlazasMinimas.UseVisualStyleBackColor = true;
            this.rbPlazasMinimas.CheckedChanged += new System.EventHandler(this.rbPlazasMinimas_CheckedChanged);
            // 
            // lblPlazas
            // 
            this.lblPlazas.AutoSize = true;
            this.lblPlazas.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblPlazas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlazas.Location = new System.Drawing.Point(124, 23);
            this.lblPlazas.Name = "lblPlazas";
            this.lblPlazas.Size = new System.Drawing.Size(14, 13);
            this.lblPlazas.TabIndex = 13;
            this.lblPlazas.Text = "1";
            // 
            // rbPlazasExactas
            // 
            this.rbPlazasExactas.AutoSize = true;
            this.rbPlazasExactas.Location = new System.Drawing.Point(6, 49);
            this.rbPlazasExactas.Name = "rbPlazasExactas";
            this.rbPlazasExactas.Size = new System.Drawing.Size(63, 17);
            this.rbPlazasExactas.TabIndex = 14;
            this.rbPlazasExactas.Text = "Exactas";
            this.rbPlazasExactas.UseVisualStyleBackColor = true;
            this.rbPlazasExactas.CheckedChanged += new System.EventHandler(this.rbPlazasExactas_CheckedChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 2;
            this.trackBar2.Location = new System.Drawing.Point(6, 19);
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(112, 45);
            this.trackBar2.TabIndex = 12;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nudMaxValue);
            this.groupBox4.Controls.Add(this.nudMinValue);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lblPrecioMaximo);
            this.groupBox4.Location = new System.Drawing.Point(12, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(166, 78);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Precio";
            // 
            // nudMaxValue
            // 
            this.nudMaxValue.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudMaxValue.Location = new System.Drawing.Point(50, 47);
            this.nudMaxValue.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudMaxValue.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudMaxValue.Name = "nudMaxValue";
            this.nudMaxValue.Size = new System.Drawing.Size(106, 20);
            this.nudMaxValue.TabIndex = 14;
            this.nudMaxValue.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudMaxValue.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // nudMinValue
            // 
            this.nudMinValue.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudMinValue.Location = new System.Drawing.Point(50, 21);
            this.nudMinValue.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudMinValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMinValue.Name = "nudMinValue";
            this.nudMinValue.Size = new System.Drawing.Size(106, 20);
            this.nudMinValue.TabIndex = 14;
            this.nudMinValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMinValue.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Max:";
            // 
            // lblPrecioMaximo
            // 
            this.lblPrecioMaximo.AutoSize = true;
            this.lblPrecioMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMaximo.Location = new System.Drawing.Point(17, 23);
            this.lblPrecioMaximo.Name = "lblPrecioMaximo";
            this.lblPrecioMaximo.Size = new System.Drawing.Size(27, 13);
            this.lblPrecioMaximo.TabIndex = 13;
            this.lblPrecioMaximo.Text = "Min:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 80);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(320, 60);
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
            this.ckbAC.Location = new System.Drawing.Point(3, 28);
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
            this.ckbMascotas.Location = new System.Drawing.Point(50, 28);
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
            this.groupBox2.Size = new System.Drawing.Size(329, 49);
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
            this.flowLayoutPanel2.Size = new System.Drawing.Size(323, 29);
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
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.OldLace;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(12, 460);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 26);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar Propiedad";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // PropiedadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1224, 526);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerPanel);
            this.Name = "PropiedadesForm";
            this.Text = "PropiedadesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PropiedadesForm_FormClosing);
            this.Load += new System.EventHandler(this.PropiedadesForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSegunda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrimera)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinValue)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblPlazas;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.RadioButton rbPlazasMinimas;
        private System.Windows.Forms.RadioButton rbPlazasExactas;
        private System.Windows.Forms.NumericUpDown nudMaxValue;
        private System.Windows.Forms.NumericUpDown nudMinValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrecioMaximo;
        private System.Windows.Forms.Button btnDisponibilidad;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.PictureBox pbSegunda;
        public System.Windows.Forms.PictureBox pbPrimera;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnEditar;
    }
}

namespace Booking
{
    partial class RegistroEdicionPropiedad
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
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPropietario = new System.Windows.Forms.ComboBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.nudPlazas = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudPrecioBase = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbHotel = new System.Windows.Forms.RadioButton();
            this.rbCFDS = new System.Windows.Forms.RadioButton();
            this.rbCPD = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ckbDesayuno = new System.Windows.Forms.CheckBox();
            this.ckbPiscina = new System.Windows.Forms.CheckBox();
            this.ckbCochera = new System.Windows.Forms.CheckBox();
            this.ckbWifi = new System.Windows.Forms.CheckBox();
            this.ckbAC = new System.Windows.Forms.CheckBox();
            this.ckbMascotas = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnNewLocal = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemoveFirst = new System.Windows.Forms.Button();
            this.btnRemoveSecond = new System.Windows.Forms.Button();
            this.pbSegunda = new System.Windows.Forms.PictureBox();
            this.pbPrimera = new System.Windows.Forms.PictureBox();
            this.btnBuscarImg = new System.Windows.Forms.Button();
            this.oFDImg = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDiasMinimos = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudCategoriaHotel = new System.Windows.Forms.NumericUpDown();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlazas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioBase)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSegunda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrimera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasMinimos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCategoriaHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.Wheat;
            this.pnlEncabezado.Controls.Add(this.label1);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(566, 47);
            this.pnlEncabezado.TabIndex = 2;
            this.pnlEncabezado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlEncabezado_MouseDown);
            this.pnlEncabezado.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlEncabezado_MouseMove);
            this.pnlEncabezado.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlEncabezado_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "NUEVA PROPIEDAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Propietario";
            // 
            // cbPropietario
            // 
            this.cbPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPropietario.FormattingEnabled = true;
            this.cbPropietario.Location = new System.Drawing.Point(97, 62);
            this.cbPropietario.Name = "cbPropietario";
            this.cbPropietario.Size = new System.Drawing.Size(253, 23);
            this.cbPropietario.TabIndex = 4;
            this.cbPropietario.SelectedIndexChanged += new System.EventHandler(this.cbPropietario_SelectedIndexChanged);
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(97, 93);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(253, 21);
            this.tbNombre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccion.Location = new System.Drawing.Point(97, 152);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(253, 21);
            this.tbDireccion.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Direrccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Localidad";
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(97, 122);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(180, 23);
            this.cbLocalidad.TabIndex = 4;
            // 
            // nudPlazas
            // 
            this.nudPlazas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPlazas.Location = new System.Drawing.Point(97, 181);
            this.nudPlazas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPlazas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPlazas.Name = "nudPlazas";
            this.nudPlazas.Size = new System.Drawing.Size(55, 21);
            this.nudPlazas.TabIndex = 8;
            this.nudPlazas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Plazas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(169, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Precio Base";
            // 
            // nudPrecioBase
            // 
            this.nudPrecioBase.DecimalPlaces = 1;
            this.nudPrecioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrecioBase.Location = new System.Drawing.Point(248, 181);
            this.nudPrecioBase.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrecioBase.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudPrecioBase.Name = "nudPrecioBase";
            this.nudPrecioBase.Size = new System.Drawing.Size(102, 21);
            this.nudPrecioBase.TabIndex = 8;
            this.nudPrecioBase.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(371, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 96);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Propiedad";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.rbHotel);
            this.flowLayoutPanel2.Controls.Add(this.rbCFDS);
            this.flowLayoutPanel2.Controls.Add(this.rbCPD);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(172, 76);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // rbHotel
            // 
            this.rbHotel.AutoSize = true;
            this.rbHotel.Checked = true;
            this.rbHotel.Location = new System.Drawing.Point(3, 3);
            this.rbHotel.Name = "rbHotel";
            this.rbHotel.Size = new System.Drawing.Size(54, 19);
            this.rbHotel.TabIndex = 0;
            this.rbHotel.TabStop = true;
            this.rbHotel.Text = "Hotel";
            this.rbHotel.UseVisualStyleBackColor = true;
            this.rbHotel.CheckedChanged += new System.EventHandler(this.rbHotel_CheckedChanged);
            // 
            // rbCFDS
            // 
            this.rbCFDS.AutoSize = true;
            this.rbCFDS.Location = new System.Drawing.Point(3, 28);
            this.rbCFDS.Name = "rbCFDS";
            this.rbCFDS.Size = new System.Drawing.Size(151, 19);
            this.rbCFDS.TabIndex = 0;
            this.rbCFDS.Text = "Casa de fin de semana";
            this.rbCFDS.UseVisualStyleBackColor = true;
            this.rbCFDS.CheckedChanged += new System.EventHandler(this.rbCFDS_CheckedChanged);
            // 
            // rbCPD
            // 
            this.rbCPD.AutoSize = true;
            this.rbCPD.Location = new System.Drawing.Point(3, 53);
            this.rbCPD.Name = "rbCPD";
            this.rbCPD.Size = new System.Drawing.Size(94, 19);
            this.rbCPD.TabIndex = 0;
            this.rbCPD.Text = "Casa por dia";
            this.rbCPD.UseVisualStyleBackColor = true;
            this.rbCPD.CheckedChanged += new System.EventHandler(this.rbCPD_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(371, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 129);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servicios";
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(172, 109);
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
            // 
            // ckbCochera
            // 
            this.ckbCochera.AutoSize = true;
            this.ckbCochera.Location = new System.Drawing.Point(3, 28);
            this.ckbCochera.Name = "ckbCochera";
            this.ckbCochera.Size = new System.Drawing.Size(72, 19);
            this.ckbCochera.TabIndex = 2;
            this.ckbCochera.Text = "Cochera";
            this.ckbCochera.UseVisualStyleBackColor = true;
            // 
            // ckbWifi
            // 
            this.ckbWifi.AutoSize = true;
            this.ckbWifi.Location = new System.Drawing.Point(81, 28);
            this.ckbWifi.Name = "ckbWifi";
            this.ckbWifi.Size = new System.Drawing.Size(46, 19);
            this.ckbWifi.TabIndex = 0;
            this.ckbWifi.Text = "Wifi";
            this.ckbWifi.UseVisualStyleBackColor = true;
            // 
            // ckbAC
            // 
            this.ckbAC.AutoSize = true;
            this.ckbAC.Location = new System.Drawing.Point(3, 53);
            this.ckbAC.Name = "ckbAC";
            this.ckbAC.Size = new System.Drawing.Size(41, 19);
            this.ckbAC.TabIndex = 1;
            this.ckbAC.Text = "AC";
            this.ckbAC.UseVisualStyleBackColor = true;
            // 
            // ckbMascotas
            // 
            this.ckbMascotas.AutoSize = true;
            this.ckbMascotas.Location = new System.Drawing.Point(50, 53);
            this.ckbMascotas.Name = "ckbMascotas";
            this.ckbMascotas.Size = new System.Drawing.Size(79, 19);
            this.ckbMascotas.TabIndex = 3;
            this.ckbMascotas.Text = "Mascotas";
            this.ckbMascotas.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.OldLace;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(374, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 26);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.OldLace;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(490, 354);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(59, 26);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnNewLocal
            // 
            this.btnNewLocal.BackColor = System.Drawing.Color.OldLace;
            this.btnNewLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewLocal.Location = new System.Drawing.Point(283, 122);
            this.btnNewLocal.Name = "btnNewLocal";
            this.btnNewLocal.Size = new System.Drawing.Size(67, 23);
            this.btnNewLocal.TabIndex = 10;
            this.btnNewLocal.Text = "Nueva";
            this.btnNewLocal.UseVisualStyleBackColor = false;
            this.btnNewLocal.Click += new System.EventHandler(this.btnNewLocal_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemoveFirst);
            this.groupBox3.Controls.Add(this.btnRemoveSecond);
            this.groupBox3.Controls.Add(this.pbSegunda);
            this.groupBox3.Controls.Add(this.pbPrimera);
            this.groupBox3.Controls.Add(this.btnBuscarImg);
            this.groupBox3.Location = new System.Drawing.Point(19, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 196);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagenes";
            // 
            // btnRemoveFirst
            // 
            this.btnRemoveFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveFirst.BackColor = System.Drawing.Color.OldLace;
            this.btnRemoveFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFirst.Location = new System.Drawing.Point(147, 28);
            this.btnRemoveFirst.Name = "btnRemoveFirst";
            this.btnRemoveFirst.Size = new System.Drawing.Size(20, 20);
            this.btnRemoveFirst.TabIndex = 17;
            this.btnRemoveFirst.Text = "X";
            this.btnRemoveFirst.UseVisualStyleBackColor = false;
            this.btnRemoveFirst.Click += new System.EventHandler(this.btnRemoveFirst_Click);
            // 
            // btnRemoveSecond
            // 
            this.btnRemoveSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveSecond.BackColor = System.Drawing.Color.OldLace;
            this.btnRemoveSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSecond.Location = new System.Drawing.Point(307, 28);
            this.btnRemoveSecond.Name = "btnRemoveSecond";
            this.btnRemoveSecond.Size = new System.Drawing.Size(20, 20);
            this.btnRemoveSecond.TabIndex = 16;
            this.btnRemoveSecond.Text = "X";
            this.btnRemoveSecond.UseVisualStyleBackColor = false;
            this.btnRemoveSecond.Click += new System.EventHandler(this.btnRemoveSecond_Click);
            // 
            // pbSegunda
            // 
            this.pbSegunda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSegunda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSegunda.Location = new System.Drawing.Point(171, 19);
            this.pbSegunda.Name = "pbSegunda";
            this.pbSegunda.Size = new System.Drawing.Size(156, 130);
            this.pbSegunda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSegunda.TabIndex = 15;
            this.pbSegunda.TabStop = false;
            // 
            // pbPrimera
            // 
            this.pbPrimera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPrimera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPrimera.Location = new System.Drawing.Point(11, 19);
            this.pbPrimera.Name = "pbPrimera";
            this.pbPrimera.Size = new System.Drawing.Size(156, 130);
            this.pbPrimera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrimera.TabIndex = 15;
            this.pbPrimera.TabStop = false;
            // 
            // btnBuscarImg
            // 
            this.btnBuscarImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarImg.BackColor = System.Drawing.Color.OldLace;
            this.btnBuscarImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarImg.Location = new System.Drawing.Point(11, 164);
            this.btnBuscarImg.Name = "btnBuscarImg";
            this.btnBuscarImg.Size = new System.Drawing.Size(316, 26);
            this.btnBuscarImg.TabIndex = 14;
            this.btnBuscarImg.Text = "Buscar Imagen";
            this.btnBuscarImg.UseVisualStyleBackColor = false;
            this.btnBuscarImg.Click += new System.EventHandler(this.btBuscarImg_Click);
            // 
            // oFDImg
            // 
            this.oFDImg.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dias minimos";
            // 
            // nudDiasMinimos
            // 
            this.nudDiasMinimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiasMinimos.Location = new System.Drawing.Point(462, 169);
            this.nudDiasMinimos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiasMinimos.Name = "nudDiasMinimos";
            this.nudDiasMinimos.Size = new System.Drawing.Size(84, 21);
            this.nudDiasMinimos.TabIndex = 8;
            this.nudDiasMinimos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(371, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Categoria";
            // 
            // nudCategoriaHotel
            // 
            this.nudCategoriaHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCategoriaHotel.Location = new System.Drawing.Point(462, 192);
            this.nudCategoriaHotel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCategoriaHotel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCategoriaHotel.Name = "nudCategoriaHotel";
            this.nudCategoriaHotel.Size = new System.Drawing.Size(84, 21);
            this.nudCategoriaHotel.TabIndex = 8;
            this.nudCategoriaHotel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.BackColor = System.Drawing.Color.Tomato;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(374, 386);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(175, 29);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar propiedad";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Visible = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // RegistroEdicionPropiedad
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(566, 427);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewLocal);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudCategoriaHotel);
            this.Controls.Add(this.nudDiasMinimos);
            this.Controls.Add(this.nudPrecioBase);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudPlazas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.cbLocalidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPropietario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroEdicionPropiedad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistroEdicionPropiedad_FormClosing);
            this.Load += new System.EventHandler(this.RegistroEdicionPropiedad_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlazas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioBase)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSegunda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrimera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasMinimos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCategoriaHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.ComboBox cbPropietario;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.TextBox tbDireccion;
        public System.Windows.Forms.ComboBox cbLocalidad;
        public System.Windows.Forms.NumericUpDown nudPlazas;
        public System.Windows.Forms.NumericUpDown nudPrecioBase;
        public System.Windows.Forms.RadioButton rbCPD;
        public System.Windows.Forms.RadioButton rbCFDS;
        public System.Windows.Forms.RadioButton rbHotel;
        public System.Windows.Forms.CheckBox ckbDesayuno;
        public System.Windows.Forms.CheckBox ckbPiscina;
        public System.Windows.Forms.CheckBox ckbCochera;
        public System.Windows.Forms.CheckBox ckbWifi;
        public System.Windows.Forms.CheckBox ckbAC;
        public System.Windows.Forms.CheckBox ckbMascotas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnNewLocal;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.PictureBox pbSegunda;
        public System.Windows.Forms.PictureBox pbPrimera;
        private System.Windows.Forms.Button btnBuscarImg;
        private System.Windows.Forms.OpenFileDialog oFDImg;
        private System.Windows.Forms.Button btnRemoveFirst;
        private System.Windows.Forms.Button btnRemoveSecond;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown nudDiasMinimos;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.NumericUpDown nudCategoriaHotel;
        public System.Windows.Forms.Button btnBorrar;
    }
}
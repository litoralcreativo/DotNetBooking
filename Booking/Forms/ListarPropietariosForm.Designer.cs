
namespace Booking
{
    partial class ListarPropietariosForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMigrar = new System.Windows.Forms.Button();
            this.btnResumen = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPropiedadesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantReservas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pnlEncabezado.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.Tan;
            this.pnlEncabezado.Controls.Add(this.label1);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(3, 3);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(794, 47);
            this.pnlEncabezado.TabIndex = 5;
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
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "PROPIETARIOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnMigrar);
            this.panel2.Controls.Add(this.btnResumen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(655, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 397);
            this.panel2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.OldLace;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnMigrar
            // 
            this.btnMigrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMigrar.BackColor = System.Drawing.Color.OldLace;
            this.btnMigrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMigrar.Location = new System.Drawing.Point(6, 295);
            this.btnMigrar.Name = "btnMigrar";
            this.btnMigrar.Size = new System.Drawing.Size(124, 26);
            this.btnMigrar.TabIndex = 8;
            this.btnMigrar.Text = "Migrar Reservas";
            this.btnMigrar.UseVisualStyleBackColor = false;
            this.btnMigrar.Click += new System.EventHandler(this.btnMigrar_Click);
            // 
            // btnResumen
            // 
            this.btnResumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResumen.BackColor = System.Drawing.Color.OldLace;
            this.btnResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumen.Location = new System.Drawing.Point(6, 327);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(124, 26);
            this.btnResumen.TabIndex = 8;
            this.btnResumen.Text = "Generar Resumen";
            this.btnResumen.UseVisualStyleBackColor = false;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.apellidoColumn,
            this.dniColumn,
            this.telColumn,
            this.numPropiedadesColumn,
            this.cantReservas});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 50);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(652, 397);
            this.dgv.TabIndex = 9;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.HeaderText = "Nombre";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // apellidoColumn
            // 
            this.apellidoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellidoColumn.HeaderText = "Apellido";
            this.apellidoColumn.Name = "apellidoColumn";
            this.apellidoColumn.ReadOnly = true;
            // 
            // dniColumn
            // 
            this.dniColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dniColumn.HeaderText = "DNI";
            this.dniColumn.Name = "dniColumn";
            this.dniColumn.ReadOnly = true;
            // 
            // telColumn
            // 
            this.telColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telColumn.HeaderText = "Telefono";
            this.telColumn.Name = "telColumn";
            this.telColumn.ReadOnly = true;
            // 
            // numPropiedadesColumn
            // 
            this.numPropiedadesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numPropiedadesColumn.HeaderText = "Propiedades";
            this.numPropiedadesColumn.Name = "numPropiedadesColumn";
            this.numPropiedadesColumn.ReadOnly = true;
            // 
            // cantReservas
            // 
            this.cantReservas.HeaderText = "Reservas";
            this.cantReservas.Name = "cantReservas";
            this.cantReservas.ReadOnly = true;
            // 
            // sfd
            // 
            this.sfd.Filter = "CSV (*.csv) | *.csv";
            this.sfd.InitialDirectory = ".";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintPage);
            // 
            // ListarPropietariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarPropietariosForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListarPropietariosForm";
            this.Load += new System.EventHandler(this.ListarPropietariosForm_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnResumen;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPropiedadesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantReservas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnMigrar;
    }
}
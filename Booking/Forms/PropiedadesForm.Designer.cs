
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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.dirColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plazasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Wheat;
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1244, 28);
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
            // monthCalendar
            // 
            this.monthCalendar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthCalendar.AnnuallyBoldedDates = new System.DateTime[] {
        new System.DateTime(2021, 10, 17, 0, 0, 0, 0)};
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar.Location = new System.Drawing.Point(9, 12);
            this.monthCalendar.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.monthCalendar.MaximumSize = new System.Drawing.Size(388, 162);
            this.monthCalendar.MaxSelectionCount = 365;
            this.monthCalendar.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.monthCalendar.MinimumSize = new System.Drawing.Size(388, 162);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 6;
            this.monthCalendar.TitleBackColor = System.Drawing.Color.DarkOrange;
            this.monthCalendar.TitleForeColor = System.Drawing.SystemColors.Control;
            this.monthCalendar.TrailingForeColor = System.Drawing.Color.Gray;
            // 
            // dirColumn
            // 
            this.dirColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dirColumn.HeaderText = "Direccion";
            this.dirColumn.Name = "dirColumn";
            this.dirColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Nombre";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 150;
            // 
            // localidadColumn
            // 
            this.localidadColumn.HeaderText = "Localidad";
            this.localidadColumn.Name = "localidadColumn";
            this.localidadColumn.ReadOnly = true;
            // 
            // plazasColumn
            // 
            this.plazasColumn.HeaderText = "Plazas";
            this.plazasColumn.Name = "plazasColumn";
            this.plazasColumn.ReadOnly = true;
            this.plazasColumn.Width = 50;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Precio";
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            // 
            // typeColumn
            // 
            this.typeColumn.HeaderText = "Tipo";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.ReadOnly = true;
            this.typeColumn.Width = 150;
            // 
            // refColumn
            // 
            this.refColumn.HeaderText = "ref";
            this.refColumn.MinimumWidth = 40;
            this.refColumn.Name = "refColumn";
            this.refColumn.ReadOnly = true;
            this.refColumn.Width = 40;
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
            this.dirColumn});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv.Location = new System.Drawing.Point(0, 28);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(837, 421);
            this.dgv.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.monthCalendar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(837, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 421);
            this.panel1.TabIndex = 7;
            // 
            // PropiedadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1244, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.headerPanel);
            this.Name = "PropiedadesForm";
            this.Text = "PropiedadesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PropiedadesForm_FormClosing);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plazasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refColumn;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel1;
    }
}
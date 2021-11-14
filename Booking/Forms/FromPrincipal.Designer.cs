
namespace Booking
{
    partial class FromPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportarSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propietariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirPropietarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPropietariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaPreviaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionDePaginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.propiedadesToolStripMenuItem,
            this.propietariosToolStripMenuItem,
            this.impresionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1315, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.registrarUsuarioToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportarSistemaToolStripMenuItem,
            this.importarSistemaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iniciarSesionToolStripMenuItem.Text = "Iniciar Sesion";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Enabled = false;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            this.registrarUsuarioToolStripMenuItem.Enabled = false;
            this.registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            this.registrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarUsuarioToolStripMenuItem.Text = "Registrar Usuario";
            this.registrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuarioToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exportarSistemaToolStripMenuItem
            // 
            this.exportarSistemaToolStripMenuItem.Name = "exportarSistemaToolStripMenuItem";
            this.exportarSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportarSistemaToolStripMenuItem.Text = "Exportar Sistema";
            this.exportarSistemaToolStripMenuItem.Click += new System.EventHandler(this.exportarSistemaToolStripMenuItem_Click);
            // 
            // importarSistemaToolStripMenuItem
            // 
            this.importarSistemaToolStripMenuItem.Name = "importarSistemaToolStripMenuItem";
            this.importarSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importarSistemaToolStripMenuItem.Text = "Importar Sistema";
            this.importarSistemaToolStripMenuItem.Click += new System.EventHandler(this.importarSistemaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // propiedadesToolStripMenuItem
            // 
            this.propiedadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem,
            this.crearToolStripMenuItem});
            this.propiedadesToolStripMenuItem.Name = "propiedadesToolStripMenuItem";
            this.propiedadesToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.propiedadesToolStripMenuItem.Text = "Propiedades";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.buscarToolStripMenuItem.Text = "Buscar Propiedad";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.crearToolStripMenuItem.Text = "Crear Propieadad";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // propietariosToolStripMenuItem
            // 
            this.propietariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirPropietarioToolStripMenuItem,
            this.listarPropietariosToolStripMenuItem});
            this.propietariosToolStripMenuItem.Name = "propietariosToolStripMenuItem";
            this.propietariosToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.propietariosToolStripMenuItem.Text = "Propietarios";
            // 
            // añadirPropietarioToolStripMenuItem
            // 
            this.añadirPropietarioToolStripMenuItem.Name = "añadirPropietarioToolStripMenuItem";
            this.añadirPropietarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.añadirPropietarioToolStripMenuItem.Text = "Añadir Propietario";
            this.añadirPropietarioToolStripMenuItem.Click += new System.EventHandler(this.añadirPropietarioToolStripMenuItem_Click);
            // 
            // listarPropietariosToolStripMenuItem
            // 
            this.listarPropietariosToolStripMenuItem.Name = "listarPropietariosToolStripMenuItem";
            this.listarPropietariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarPropietariosToolStripMenuItem.Text = "Listar Propietarios";
            this.listarPropietariosToolStripMenuItem.Click += new System.EventHandler(this.listarPropietariosToolStripMenuItem_Click);
            // 
            // impresionToolStripMenuItem
            // 
            this.impresionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vistaPreviaToolStripMenuItem,
            this.configuracionDePaginaToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.impresionToolStripMenuItem.Enabled = false;
            this.impresionToolStripMenuItem.Name = "impresionToolStripMenuItem";
            this.impresionToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.impresionToolStripMenuItem.Text = "Impresion";
            // 
            // vistaPreviaToolStripMenuItem
            // 
            this.vistaPreviaToolStripMenuItem.Name = "vistaPreviaToolStripMenuItem";
            this.vistaPreviaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vistaPreviaToolStripMenuItem.Text = "Vista Previa";
            this.vistaPreviaToolStripMenuItem.Click += new System.EventHandler(this.vistaPreviaToolStripMenuItem_Click);
            // 
            // configuracionDePaginaToolStripMenuItem
            // 
            this.configuracionDePaginaToolStripMenuItem.Name = "configuracionDePaginaToolStripMenuItem";
            this.configuracionDePaginaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configuracionDePaginaToolStripMenuItem.Text = "Configurar Pagina";
            this.configuracionDePaginaToolStripMenuItem.Click += new System.EventHandler(this.configuracionDePaginaToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // sfd
            // 
            this.sfd.Filter = "csv (*.csv) | *.csv";
            this.sfd.InitialDirectory = ".";
            this.sfd.Title = "EXPORTAR SISTEMA";
            // 
            // ofd
            // 
            this.ofd.InitialDirectory = ".";
            this.ofd.Title = "IMPORTAR SISTEMA";
            // 
            // printDocument
            // 
            this.printDocument.OriginAtMargins = true;
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // FromPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1315, 601);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FromPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propiedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propietariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirPropietarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPropietariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarSistemaToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ToolStripMenuItem vistaPreviaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionDePaginaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        public System.Windows.Forms.ToolStripMenuItem impresionToolStripMenuItem;
    }
}


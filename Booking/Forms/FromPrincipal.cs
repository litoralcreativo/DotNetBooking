using Booking.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Booking
{
    public partial class FromPrincipal : Form, IPrintable
    {
        public Empresa empresa;
        FileStream archivo;
        StreamWriter sWriter;
        BinaryFormatter binaryFormatter;
        string miArchivo = Application.StartupPath + "\\info.dat"; // archivo serializado
        string logFile = Application.StartupPath + "\\log.txt"; // archivo serializado

        public FromPrincipal()
        {
            InitializeComponent();
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.OldLace;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FSplash nuevoSplash = new FSplash();
            nuevoSplash.ShowDialog();
            if (File.Exists(miArchivo))
            {
                archivo = new FileStream(miArchivo, FileMode.Open, FileAccess.Read);
                binaryFormatter = new BinaryFormatter();
                empresa = (Empresa)binaryFormatter.Deserialize(archivo);
                archivo.Close();
                empresa.RefreshPk();
            }
            else
            {
                empresa = new Empresa();
                Usuario u = new Usuario("admin", "admin");
                u.Nombre = "administrador";
                u.Apellido = "administrador";
                u.Categoria = CategoriaUsuario.Administrador;
                empresa.AgregarUsuario(u);
            }

            ActualizarMenuStrip();
            iniciarSesionToolStripMenuItem.PerformClick();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(
                "Realmente desea salir de la aplicacion?",
                "Confirmacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // cerramos sesion si sigue abierta
                if (empresa.Sesion != null)
                {
                    empresa.Sesion.MarcarSalida();
                    empresa.Sesion = null;
                }

                // escribir archivo log
                GuardarLog();

                // serializar datos
                if (File.Exists(miArchivo))
                    System.IO.File.Delete(miArchivo);
                archivo = new FileStream(miArchivo, FileMode.CreateNew, FileAccess.Write);
                binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(archivo, empresa);
                archivo.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void GuardarLog()
        {
            try
            {
                StringBuilder linea;
                archivo = new FileStream(logFile, FileMode.Create, FileAccess.Write);
                sWriter = new StreamWriter(archivo);
                List<Sesion> sesiones = new List<Sesion>();
                foreach (Usuario u in empresa.usuarios) // listamos sesiones
                {
                    for (int i = 0; i < u.sesiones.Count; i++)
                    {
                        sesiones.Add(u.sesiones[i]);
                    }
                }
                sesiones.Sort();
                foreach (Sesion sesion in sesiones)
                {
                    linea = new StringBuilder();
                    linea.Append(sesion.user.Username);
                    linea.Append(",");
                    linea.Append(sesion.entrada.ToString());
                    linea.Append(",");
                    linea.Append(sesion.salida.ToString());
                    sWriter.WriteLine(linea);
                }
            }
            finally
            {
                if (sWriter != null) sWriter.Close();
                if (archivo != null) archivo.Dispose();
            }
        }

        public void ActualizarMenuStrip()
        {
            if (empresa.Sesion == null)
            {
                iniciarSesionToolStripMenuItem.Enabled = true;
                cerrarSesionToolStripMenuItem.Enabled = false;
                registrarUsuarioToolStripMenuItem.Enabled = false;
                buscarToolStripMenuItem.Enabled = false;
                crearToolStripMenuItem.Enabled = false;
                añadirPropietarioToolStripMenuItem.Enabled = false;
                añadirPropietarioToolStripMenuItem.Enabled = false;
                listarPropietariosToolStripMenuItem.Enabled = false;
                importarSistemaToolStripMenuItem.Enabled = false;
                exportarSistemaToolStripMenuItem.Enabled = false;
                reservasToolStripMenuItem.Enabled = false;
            }
            else
            {
                switch (empresa.Sesion.Categoria)
                {
                    case CategoriaUsuario.Empleado:
                    {
                            iniciarSesionToolStripMenuItem.Enabled = false;
                            cerrarSesionToolStripMenuItem.Enabled = true;
                            registrarUsuarioToolStripMenuItem.Enabled = false;
                            buscarToolStripMenuItem.Enabled = true;
                            crearToolStripMenuItem.Enabled = false;
                            añadirPropietarioToolStripMenuItem.Enabled = false;
                            listarPropietariosToolStripMenuItem.Enabled = true;
                            importarSistemaToolStripMenuItem.Enabled = false;
                            exportarSistemaToolStripMenuItem.Enabled = false;
                            reservasToolStripMenuItem.Enabled = true;
                            break;
                        }
                    case CategoriaUsuario.Administrador:
                    {
                            iniciarSesionToolStripMenuItem.Enabled = false;
                            cerrarSesionToolStripMenuItem.Enabled = true;
                            registrarUsuarioToolStripMenuItem.Enabled = true;
                            buscarToolStripMenuItem.Enabled = true;
                            crearToolStripMenuItem.Enabled = true;
                            añadirPropietarioToolStripMenuItem.Enabled = true;
                            listarPropietariosToolStripMenuItem.Enabled = true;
                            importarSistemaToolStripMenuItem.Enabled = true;
                            exportarSistemaToolStripMenuItem.Enabled = true;
                            reservasToolStripMenuItem.Enabled = true;
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // chequear credenciales
                string username = loginForm.tbUsername.Text;
                string password = loginForm.tbPassword.Text;
                empresa.Sesion = empresa.Login(username, password);
                if (empresa.Sesion == null)
                {
                    MessageBox.Show("Sus credenciales son incorrectas", "Sesion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    iniciarSesionToolStripMenuItem.PerformClick();
                } else
                {
                    empresa.Sesion.MarcarEntrada();
                    //MessageBox.Show("Bienvenido "+ empresa.Sesion.Nombre, "Sesion", MessageBoxButtons.OK);
                }
            }
            ActualizarMenuStrip();
        }
        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroForm registroUsuario = new RegistroForm();
            if (registroUsuario.ShowDialog() == DialogResult.OK)
            {
                string nombre = registroUsuario.tbNombre.Text;
                string apellido = registroUsuario.tbApellido.Text;
                string uName = registroUsuario.tbUsername.Text;
                string uPass = registroUsuario.tbPassword.Text;
                bool admin = registroUsuario.cbAdmin.Checked;
                Usuario usuarioNuevo = new Usuario(uName, uPass);
                usuarioNuevo.Nombre = nombre;
                usuarioNuevo.Apellido = apellido;
                usuarioNuevo.Categoria = admin ? CategoriaUsuario.Administrador : CategoriaUsuario.Empleado;
                if (nombre == "" || apellido == "" || uName == "" || uPass == "")
                {
                    MessageBox.Show("Todos los campos son obligatorios", "Registro", MessageBoxButtons.OK);
                } else { 
                    bool registro = empresa.AgregarUsuario(usuarioNuevo);
                    if (!registro)
                    {
                        MessageBox.Show("Ya existe un usuario con estos datos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } else
                    {
                        MessageBox.Show("Registro realizado con exito", "Registro", MessageBoxButtons.OK);
                    }
                }
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (empresa.Sesion != null)
            {
                empresa.Logout();
                for (int i = 0; i < MdiChildren.Length; i++) // borrar todos los mdi hijos
                {
                    MdiChildren[i].Close();
                }
            }
            ActualizarMenuStrip();
        }


        private void añadirPropietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoPropietarioForm nuevoPropForm = new NuevoPropietarioForm();
            if (nuevoPropForm.ShowDialog() == DialogResult.OK)
            {
                string nombre = nuevoPropForm.tbNombre.Text;
                string apellido = nuevoPropForm.tbApellido.Text;
                long dni = Convert.ToInt64(nuevoPropForm.tbDni.Text);
                long telefono = Convert.ToInt64(nuevoPropForm.tbTelefono.Text);
                Propietario nuevo = new Propietario(nombre, apellido, dni, telefono);
                bool registro = empresa.AgregarPropietario(nuevo);
                if (!registro)
                {
                    MessageBox.Show("Ya existe un propietario con este dni", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else
                {
                    MessageBox.Show("Registro realizado con exito", "Registro", MessageBoxButtons.OK);
                }
            }
        }
        
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEdicionPropiedad regPropiedad = new RegistroEdicionPropiedad();
            List<Propietario> propietarios = empresa.ListarPropietarios();
            for (int i = 0; i < propietarios.Count; i++)
            {
                regPropiedad.cbPropietario.Items.Add(propietarios[i].ToString());
            }
            regPropiedad.setEmpresa(ref empresa);
            regPropiedad.updateLocations();
            
            if (regPropiedad.ShowDialog() == DialogResult.OK)
            {
                int propietarioIndex = regPropiedad.cbPropietario.SelectedIndex;
                TipoPropiedad tipoPropiedad = regPropiedad.tipoPropiedad;
                string nombre = regPropiedad.tbNombre.Text;
                string localidad = regPropiedad.cbLocalidad.Text;
                string direccion = regPropiedad.tbDireccion.Text;
                int plazas = Convert.ToInt32(regPropiedad.nudPlazas.Value);
                double precio = Convert.ToDouble(regPropiedad.nudPrecioBase.Value);
                string[] imagesPath = { regPropiedad.pbPrimera.ImageLocation, regPropiedad.pbSegunda.ImageLocation };
                Propiedad propiedad = null;
                switch (tipoPropiedad)
                {
                    case TipoPropiedad.Hotel:
                        int categoria = Convert.ToInt32(regPropiedad.nudCategoriaHotel.Value);
                        propiedad = new Hotel(nombre, plazas, direccion, localidad, precio, imagesPath, categoria);
                        break;
                    case TipoPropiedad.CasaPorDia:
                        int minimos = Convert.ToInt32(regPropiedad.nudDiasMinimos.Value);
                        propiedad = new CasaPorDia(nombre, plazas, direccion, localidad, precio, imagesPath, minimos);
                        break;
                    case TipoPropiedad.CasaFinDeSemana:
                        propiedad = new CasaFinDeSemana(nombre, plazas, direccion, localidad, precio, imagesPath);
                        break;
                }
                propiedad.ActualizarServicios(regPropiedad.servicios);
                empresa.AgregarPropiedad(propiedad, propietarioIndex);
                
            }
            if (MdiChildren.Length == 1 && MdiChildren[0] is PropiedadesForm) // actualizar el form mdichidren si esta abierto
            {
                ((PropiedadesForm)MdiChildren[0]).ActualizarLista();
            }
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropiedadesForm propForm = new PropiedadesForm();
            propForm.MdiParent = this;
            propForm.WindowState = FormWindowState.Maximized;
            propForm.ListarPropiedades(empresa.ListarPropiedades());
            propForm.Show();
            buscarToolStripMenuItem.Enabled = false;
            impresionToolStripMenuItem.Enabled = true;
        }

        private void listarPropietariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarPropietariosForm lp = new ListarPropietariosForm();
            lp.propietarios = empresa.ListarPropietarios();
            lp.ShowDialog();
        }

        private void exportarSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string name = "ctubkp-"+dt.Day+dt.Month+dt.Year+dt.Hour+dt.Minute+dt.Second+".csv";
            string bkpPath = Application.StartupPath + "\\bkp\\"+name;
            bool result = ImportacionExportacion.Exportar(empresa, bkpPath);
            if (result) MessageBox.Show("El sistema se exporto con exito en la ruta: "+ bkpPath, "Exportacion", MessageBoxButtons.OK);
            else MessageBox.Show("Hubo un problema en la exportacion", "Exportacion", MessageBoxButtons.OK);
        }

        private void importarSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "Si importa un sistema nuevo su sesion actual se cerra y todos los datos del sistema actual se perderan. Es recomendable previamente realizar un resguardo del sistema actual, desea realizarlo antes de importar el sistema nuevo?";
            DialogResult resultado = MessageBox.Show(msg, "¡CUIDADO!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.No)
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Empresa importada = ImportacionExportacion.ImportarEmpresa(ofd.FileName);
                    ResetSystem(importada);
                }
            }
            else if (resultado == DialogResult.Yes)
            {
                exportarSistemaToolStripMenuItem.PerformClick();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Empresa importada = ImportacionExportacion.ImportarEmpresa(ofd.FileName);
                    ResetSystem(importada);
                }
            }
        }

        private void ResetSystem(Empresa empresa)
        {
            cerrarSesionToolStripMenuItem.PerformClick();
            this.empresa = empresa;
        }

        #region Printer

        private void vistaPreviaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void configuracionDePaginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog.ShowDialog();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }
        /*
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<Propiedad> propiedades = new List<Propiedad>();
            if (MdiChildren.Length == 1 && MdiChildren[0] is PropiedadesForm)
            {
                propiedades = ((PropiedadesForm)MdiChildren[0]).filtrado;
            }

            string textoActual;
            Font fuente = new Font("Giorgia", 20, FontStyle.Bold);
            SolidBrush relleno = new SolidBrush(Color.Black);
            Pen borde = new Pen(Color.Black);
            SizeF tamañoLinea;

            float posY = 10;
            float posX = 10;

            textoActual = "Propiedades: ";
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY));

            int renglon = 0;
            fuente = new Font(FontFamily.GenericMonospace, 5, FontStyle.Bold);
            textoActual = String.Format("| {0, -5}| {1, -30}| {2, -10}| {3, -5}| {4, -20}| {5, -20}| {6, -30}| {7, -30}|",
    "ref", "Tipo", "Precio", "Plaz", "Localidad", "Nombre", "Direccion", "Servicios");
            
            posY = posY + tamañoLinea.Height*2;
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            posX = (e.MarginBounds.Width - tamañoLinea.Width) / 2;
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY));
            e.Graphics.DrawRectangle(borde, posX - 5, posY - 5, tamañoLinea.Width + 10, tamañoLinea.Height + 10);
            
            fuente = new Font(FontFamily.GenericMonospace, 5, FontStyle.Regular);
            posY = posY + tamañoLinea.Height * 2;

            foreach (Propiedad p in propiedades)
            {
                textoActual = String.Format("| {0, -5}| {1, -30}| {2, -10}| {3, -5}| {4, -20}| {5, -20}| {6, -30}| {7, -30}|",
                                    p.id, p.Tipo(), p.Precio, p.Plazas, p.Localidad, p.Nombre, p.Direccion, p.serviciosToString());
                
                tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
                posX = (e.MarginBounds.Width - tamañoLinea.Width) / 2;
                e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY));
                posY = posY + tamañoLinea.Height;
                renglon++;
            }
        }
        */
        public void PrintPage(object sender, PrintPageEventArgs e)
        {
            List<Propiedad> propiedades = new List<Propiedad>();
            if (MdiChildren.Length == 1 && MdiChildren[0] is PropiedadesForm)
            {
                propiedades = ((PropiedadesForm)MdiChildren[0]).filtrado;
            }

            string textoActual;
            Font fuente = new Font("Giorgia", 10, FontStyle.Regular);
            SolidBrush relleno = new SolidBrush(Color.Black);
            Pen borde = new Pen(Color.Black);
            SizeF tamañoLinea;

            float posY = 10;
            float posX = (e.MarginBounds.Width - 75);
            Bitmap logo = Resources.b_w1;
            e.Graphics.DrawImage(logo, posX, posY, 100, 75);

            textoActual = "CTU Booking S.A.";
            posX = 10;
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY));
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            posY = posY + tamañoLinea.Height;
            textoActual = DateTime.Now.ToString();
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY));


            fuente = new Font("Giorgia", 20, FontStyle.Bold);
            relleno = new SolidBrush(Color.Black);
            textoActual = "Propiedades: ";
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            posY = posY + tamañoLinea.Height;
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY));

            int renglon = 0;
            /*fuente = new Font(FontFamily.GenericMonospace, 5, FontStyle.Bold);
            textoActual = String.Format("| {0, -5}| {1, -30}| {2, -10}| {3, -5}| {4, -20}| {5, -20}| {6, -30}| {7, -30}|",
                "ref", "Tipo", "Precio", "Plaz", "Localidad", "Nombre", "Direccion", "Servicios");*/
            fuente = new Font(FontFamily.GenericMonospace, 12, FontStyle.Bold);
            textoActual = String.Format("| {0, -5}| {1, 15:C2}| {2, -30}|",
                "ref", "Precio", "Servicios");

            posY = posY + tamañoLinea.Height * 2;
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
            posX = (e.MarginBounds.Width - tamañoLinea.Width) / 2;
            e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY));
            e.Graphics.DrawRectangle(borde, posX - 5, posY - 5, tamañoLinea.Width + 10, tamañoLinea.Height + 10);

            /*fuente = new Font(FontFamily.GenericMonospace, 5, FontStyle.Regular);*/
            fuente = new Font(FontFamily.GenericMonospace, 12, FontStyle.Regular);
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);

            posY = posY + tamañoLinea.Height * 2;

            foreach (Propiedad p in propiedades)
            {
                textoActual = String.Format("| {0, -5}| {1, 15:C2}| {2, -30}|",
                    p.id, p.Precio,p.serviciosToString());
                posX = (e.MarginBounds.Width - tamañoLinea.Width) / 2;
                e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY));
                posY = posY + tamañoLinea.Height;
                renglon++;
            }
        }
        #endregion

        private void paginaDeAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowserForm wbf = new WebBrowserForm();
            wbf.ShowDialog();
        }

        private void acercaDeCTUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBooking ab = new AboutBooking();
            ab.ShowDialog();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservasForm rf = new ReservasForm();
            rf.reservas = empresa.reservas;
            rf.ShowDialog();
        }
    }
}

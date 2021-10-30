using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class FromPrincipal : Form
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
        }

        private void listarPropietariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarPropietariosForm lp = new ListarPropietariosForm();
            lp.propietarios = empresa.ListarPropietarios();
            lp.ShowDialog();
        }

        private void exportarSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bool resultado = ImportacionExportacion.Exportar(empresa, sfd.FileName);
            }
        }
    }
}

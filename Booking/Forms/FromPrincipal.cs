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
        Empresa empresa;
        FileStream archivo;
        BinaryFormatter binaryFormatter;
        string miArchivo = Application.StartupPath + "\\info.dat"; // archivo serializado

        public FromPrincipal()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(miArchivo))
            {
                archivo = new FileStream(miArchivo, FileMode.Open, FileAccess.Read);
                binaryFormatter = new BinaryFormatter();
                empresa = (Empresa)binaryFormatter.Deserialize(archivo);
                archivo.Close();
            }
            else
            {
                empresa = new Empresa();
            }
            
            /****TEST****
            Usuario u = new Usuario("admin", "admin");
            u.Nombre = "administrador";
            u.Apellido = "administrador";
            u.Categoria = CategoriaUsuario.Administrador;
            empresa.AgregarUsuario(u);
            /****TEST****/

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
        

        public void ActualizarMenuStrip()
        {
            if (empresa.Sesion == null)
            {
                iniciarSesionToolStripMenuItem.Enabled = true;
                cerrarSesionToolStripMenuItem.Enabled = false;
                registrarUsuarioToolStripMenuItem.Enabled = false;
                abrirToolStripMenuItem.Enabled = false;
                guardarToolStripMenuItem.Enabled = false;
                buscarToolStripMenuItem.Enabled = false;
                crearToolStripMenuItem.Enabled = false;
                añadirPropietarioToolStripMenuItem.Enabled = false;
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
                            abrirToolStripMenuItem.Enabled = true;
                            guardarToolStripMenuItem.Enabled = true;
                            buscarToolStripMenuItem.Enabled = true;
                            crearToolStripMenuItem.Enabled = false;
                            añadirPropietarioToolStripMenuItem.Enabled = false;
                            break;
                    }
                    case CategoriaUsuario.Administrador:
                    {
                            iniciarSesionToolStripMenuItem.Enabled = false;
                            cerrarSesionToolStripMenuItem.Enabled = true;
                            registrarUsuarioToolStripMenuItem.Enabled = true;
                            abrirToolStripMenuItem.Enabled = true;
                            guardarToolStripMenuItem.Enabled = true;
                            buscarToolStripMenuItem.Enabled = true;
                            crearToolStripMenuItem.Enabled = true;
                            añadirPropietarioToolStripMenuItem.Enabled = true;
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
                } else
                {
                    empresa.Sesion.MarcarEntrada();
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
                bool registro = empresa.AgregarUsuario(usuarioNuevo);
                if (!registro)
                {
                    MessageBox.Show("Ya existe un usuario con estos datos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                empresa.Sesion.MarcarSalida();
                empresa.Sesion = null;
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
                }
            }
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEdicionPropiedad regPropiedad = new RegistroEdicionPropiedad();
            // agregar lista de propietarios
            for (int i = 0; i < empresa.propietarios.Count; i++)
            {
                regPropiedad.cbPropietario.Items.Add(empresa.propietarios[i].ToString());
            }
            // Agregar localidades
            for (int i = 0; i < empresa.Localidades.Count; i++)
            {
                regPropiedad.cbLocalidad.Items.Add(empresa.Localidades[i].ToString());
            }
            if (regPropiedad.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}

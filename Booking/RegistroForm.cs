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
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void RegistroForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tbNombre.Text == "" || tbApellido.Text == "" || tbUsername.Text == "" || tbPassword.Text == "") {
                MessageBox.Show("Todos los campos son obligatorios", "Registro", MessageBoxButtons.OK);
                e.Cancel = true;
            }
        }
    }
}

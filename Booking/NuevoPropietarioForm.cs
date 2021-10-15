using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class NuevoPropietarioForm : Form
    {
        public NuevoPropietarioForm()
        {
            InitializeComponent();
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void NuevoPropietarioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tbApellido.Text == "" || tbNombre.Text == "" || tbDni.Text == "" || tbTelefono.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Registro", MessageBoxButtons.OK);
                e.Cancel = true;
            }
        }
    }
}

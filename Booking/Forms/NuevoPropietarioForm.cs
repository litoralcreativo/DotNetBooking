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

        bool cancel = false;
        private void NuevoPropietarioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cancel)
            {
                if (tbApellido.Text == "" || tbNombre.Text == "" || tbDni.Text == "" || tbTelefono.Text == "")
                {
                    MessageBox.Show("Todos los campos son obligatorios", "Registro", MessageBoxButtons.OK);
                    e.Cancel = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
        }

        #region draggin del form
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private void pnlEncabezado_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void pnlEncabezado_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }

        private void pnlEncabezado_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        #endregion
    }
}

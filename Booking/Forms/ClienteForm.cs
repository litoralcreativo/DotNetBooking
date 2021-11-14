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
    public partial class ClienteForm : Form
    {
        public ClienteForm()
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNombre.Text == "") throw new Exception("Debe indicar un nombre");
                if (tbCuil.Text == "") throw new Exception("Debe indicar un DNI");
                if (tbTelefono.Text == "") throw new Exception("Debe indicar un telefono");
                if (tbDireccion.Text == "") throw new Exception("Debe indicar la direccion");

                long CUIL = Convert.ToInt64(tbCuil.Text);
                bool control = VerificarCuil(CUIL);

                if (control) throw new CUILException();

                string message = "Desea confirmar la reserva?";
                if (MessageBox.Show(message, "Confirmacion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    DialogResult = DialogResult.OK;
            }
            catch (CUILException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static bool VerificarCuil(long CUIL)
        {
            bool CuitIncorrecto;
            short[] cuil = new short[11];
            for (int i = cuil.Length - 1; i >= 0; i--)
            {
                cuil[i] = Convert.ToInt16(CUIL % 10);
                CUIL = CUIL / 10;
            }
            short[] verificador = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int numero = 0;
            for (int i = 0; i < verificador.Length; i++)
            {
                numero += cuil[i] * verificador[i];
            }
            int resto = numero % 11;
            if (resto == cuil[10])
            {
                CuitIncorrecto = false;
            }
            else
            {
                int numVerificador = 11 - resto;
                if (numVerificador == cuil[10])
                {
                    CuitIncorrecto = false;
                }
                else
                {
                    CuitIncorrecto = true;
                }
            }
            return CuitIncorrecto;
        }
    }
}

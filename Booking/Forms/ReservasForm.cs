using Booking.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class ReservasForm : Form, IPrintable
    {
        public List<Reserva> reservas = new List<Reserva>();

        public ReservasForm()
        {
            InitializeComponent();
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument1.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {

                Reserva r = null;
                if (dgv.SelectedCells.Count >= 1)
                {
                    int rIndex = dgv.SelectedCells[0].RowIndex;
                    long idColumn = Convert.ToInt64(dgv.Rows[rIndex].Cells["idColumn"].Value);
                    r = reservas.Find(x => x.id == idColumn);
                }
                if (r == null) throw new Exception("ninguna reserva seleccionada");

                printDocument1.DocumentName = "cetu-reserva-" + r.id;

                Font fuente = new Font("Giorgia", 10, FontStyle.Regular);
                SolidBrush relleno = new SolidBrush(Color.Black);
                Pen borde = new Pen(Color.Black);
                
                string textoActual;
                SizeF tamañoLinea;
                float posY = 50;
                float posX = (e.PageBounds.Width - 75 - 50);

                Bitmap logo = Resources.b_w1;
                e.Graphics.DrawImage(logo, posX, posY, 100, 75);

                textoActual = "CTU Booking S.A.";
                posX = 50;
                e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY));
                tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
                posY = posY + tamañoLinea.Height;
                textoActual = DateTime.Now.ToString();
                e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY));

                fuente = new Font("Giorgia", 15, FontStyle.Regular);
                tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);
                posY = posY + tamañoLinea.Height * 2;
                textoActual = "Reserva nro: " + r.id;
                e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY));
                posY = posY + tamañoLinea.Height;

                textoActual = "Monto: $" + r.monto;
                e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY));
                posY = posY + tamañoLinea.Height;

                textoActual = "Entrada: " + r.entrada.Date;
                e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY));
                posY = posY + tamañoLinea.Height;

                textoActual = "Salida: " + r.salida.Date;
                e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY));
                posY = posY + tamañoLinea.Height;

                textoActual = "Servicios: " + r.propiedad.serviciosToString();
                e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY));
                posY = posY + tamañoLinea.Height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReservasForm_Load(object sender, EventArgs e)
        {
            ListarReservas();
        }

        private void ListarReservas()
        {
            dgv.Rows.Clear();
            for (int i = 0; i < reservas.Count; i++)
            {
                Reserva r = reservas[i];
                string id = r.id.ToString();
                string prop = r.propiedad.id.ToString();
                string nombre = r.cliente.GetNombre();
                string cuil = r.cliente.GetDni().ToString();
                string entrada = r.entrada.ToString();
                string salida = r.salida.ToString();
                string monto = "$"+r.monto;
                string estado = (r.GetStatus() ? 1 : 0).ToString();

                dgv.Rows.Add(id, prop, nombre, cuil, entrada, salida, monto, estado);
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Reserva r = null;
                if (dgv.SelectedCells.Count >= 1)
                {
                    if (MessageBox.Show("Realmente desea dar el alta a esta reserca?",
                        "Alta",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int rIndex = dgv.SelectedCells[0].RowIndex;
                        long idColumn = Convert.ToInt64(dgv.Rows[rIndex].Cells["idColumn"].Value);
                        r = reservas.Find(x => x.id == idColumn);
                        if (r == null) throw new Exception("ninguna reserva seleccionada");
                
                        reservas.Find(x => x.id == idColumn).Alta();
                        ListarReservas();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

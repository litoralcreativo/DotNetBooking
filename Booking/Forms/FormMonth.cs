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
    public partial class FormMonth : Form
    {
        

        public Propiedad propiedad;
        public SistemaReservas sr;

        public FormMonth()
        {
            InitializeComponent();
        }

        private void FormMonth_Load(object sender, EventArgs e)
        {
            List<Control> daysControls = new List<Control>();
            daysControls.AddRange(tlpDays.Controls.Cast<Control>());
            daysControls.Reverse();
            sr = new SistemaReservas(propiedad, daysControls);
            sr.UpdateCalendar();
            if (sr.propiedad is CasaFinDeSemana) nudNumeroDeDias.Enabled = false;
            else if (sr.propiedad is CasaPorDia) nudNumeroDeDias.Minimum = ((CasaPorDia)sr.propiedad).GetDiasMinimos();
            UpdatePresupuesto();
        }

        public void UpdateCalendar()
        {
            lblMonth.Text = $"{sr.dt.ToString("MMMM")}, {sr.dt.Year}";
            sr.UpdateCalendar();
        }

        private void UpdatePresupuesto()
        {
            if (sr.selectedDates.Count >= 1)
            {
                lblIngreso.Text = sr.selectedDates.First().ToShortDateString();
                lblSalida.Text = sr.selectedDates.Last().ToShortDateString();
                lblDiasTotales.Text = sr.selectedDates.Count.ToString();
                int unitarios = sr.selectedDates.Count;
                if (sr.propiedad is CasaFinDeSemana) unitarios = 1;
                lblPresupuesto.Text = String.Format("$ {0:N2}", sr.propiedad.Presupuestar(unitarios));
            } else
            {
                lblIngreso.Text = "-";
                lblSalida.Text = "-";
                lblDiasTotales.Text = "-";
                lblPresupuesto.Text = "-";

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            sr.dt = sr.dt.AddMonths(1);
            UpdateCalendar();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            sr.dt = sr.dt.AddMonths(-1);
            UpdateCalendar();
        }

        private void DayClick(object sender, MouseEventArgs e)
        {
            Control p = sender is Panel ? (Control)sender : ((Control)sender).Parent;
            if (sr.selecting) sr.SelectDate(p);
            UpdatePresupuesto();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            sr.selecting = !sr.selecting;
            btnSeleccionar.BackColor = sr.selecting ? Color.Lime : Color.OldLace;
            btnSeleccionar.Text = sr.selecting ? "Selecting" : "Select";
            UpdateCalendar();
        }

        #region draggin del form
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        private void nudNumeroDeDias_ValueChanged(object sender, EventArgs e)
        {
            if (sr.selectedDates.Count >= 1)
            {
                bool sePudo = sr.SetNumberOfDaysDays(Convert.ToInt32(nudNumeroDeDias.Value));
                UpdatePresupuesto();
                if (!sePudo)
                {
                    nudNumeroDeDias.Value = sr.selectedDates.Count;
                    MessageBox.Show("No se puede reservar esta fecha","Fecha no disponible");
                }
            }
        }
    }
}

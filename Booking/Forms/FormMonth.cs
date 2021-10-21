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
        

        List<Control> daysControls;
        DateTime dt;
        public List<DateTime> reservedDates;
        public List<DateTime> selectedDates;
        List<DateTime> showingDates;
        List<DateTime> noDisponibles;

        public Propiedad propiedad;
        bool selecting = false;
        public FormMonth()
        {
            InitializeComponent();
            
        }

        private void FormMonth_Load(object sender, EventArgs e)
        {
            daysControls = new List<Control>();
            daysControls.AddRange(tlpDays.Controls.Cast<Control>());
            daysControls.Reverse();
            dt = DateTime.Now;
            showingDates = new List<DateTime>();
            reservedDates = propiedad.FechasReservadas();
            noDisponibles = new List<DateTime>();
            selectedDates = new List<DateTime>();
            UpdateCalendar();
        }

        public void UpdateCalendar()
        {
            lblMonth.Text = $"{dt.ToString("MMMM")}, {dt.Year}";
            DateTime firstDayOfMonth = dt.AddDays(-dt.Day+1);
            int offset;
            switch (firstDayOfMonth.DayOfWeek)
            {
                default:
                case DayOfWeek.Monday:
                    {
                        offset = 0;
                        break;
                    }
                case DayOfWeek.Tuesday:
                    {
                        offset = 1;
                        break;
                    }
                case DayOfWeek.Wednesday:
                    {
                        offset = 2;
                        break;
                    }
                case DayOfWeek.Thursday:
                    {
                        offset = 3;
                        break;
                    }
                case DayOfWeek.Friday:
                    {
                        offset = 4;
                        break;
                    }
                case DayOfWeek.Saturday:
                    {
                        offset = 5;
                        break;
                    }
                case DayOfWeek.Sunday:
                    {
                        offset = 6;
                        break;
                    }
            }
            DateTime dayOfCalendar = firstDayOfMonth.AddDays(-offset);
            showingDates.Clear();
            noDisponibles.Clear();
            for (int i = 0; i < daysControls.Count; i++)
            {
                showingDates.Add(dayOfCalendar);
                Color c = dayOfCalendar.Month != dt.Month ? Color.Silver : Color.Wheat;
                bool thisMonth = dayOfCalendar.Month == dt.Month;
                bool today = dayOfCalendar.Date == DateTime.Today;
                bool reservado = false;
                bool disponible = true;
                bool selected = selectedDates.Contains(dayOfCalendar);

                if (propiedad is CasaFinDeSemana)
                {
                    if (dayOfCalendar.Month == dt.Month)
                    {
                        if (dayOfCalendar.DayOfWeek == DayOfWeek.Saturday || dayOfCalendar.DayOfWeek == DayOfWeek.Sunday)
                        disponible = true;
                        else
                        disponible = false;
                    }
                }
                if (dayOfCalendar.Date < DateTime.Today) disponible = false; // no podemos reservar antes de hoy
                for (int j = 0; j < reservedDates.Count; j++) // chequeamos q no haya reservas este dia
                {
                    if (reservedDates[j].Date == dayOfCalendar.Date) reservado = true;
                }
                if (!disponible || !thisMonth || reservado) noDisponibles.Add(dayOfCalendar);
                string textoSecundario = "";
                PaintDayOfCalendar(daysControls[i], thisMonth, dayOfCalendar.Day, textoSecundario, today, reservado, disponible, selected);
                dayOfCalendar = dayOfCalendar.AddDays(1);
            }
        }

        public void PaintDayOfCalendar(Control control, bool thisMonth, int number, string text = "", bool today = false, bool reservado = true, bool disponible = true, bool selected = false)
        {
            Color color = !thisMonth ? Color.Silver : Color.Wheat;
            control.BackColor = selected ? (thisMonth ? Color.LimeGreen : Color.CadetBlue) : color;
            control.Controls[1].Text = number.ToString();                       // texto dia del mes
            control.Controls[0].Text = text;                                    // texto secundario
            
            ((Panel)control).BorderStyle = today ? BorderStyle.FixedSingle : BorderStyle.None;  // recuadro si es hoy
            
            if (selecting)
            {
                if (reservado || !disponible || !thisMonth) control.Cursor = Cursors.No;        // cursor inabilitado si esta reservado o no dispo
                else control.Cursor = Cursors.Hand;                                             // cursor clickeable
            }
            else control.Cursor = Cursors.Default;                                              // cursor normal

            if (reservado) control.BackColor = thisMonth ? Color.Tomato : Color.DarkSalmon;

            if (!disponible && thisMonth)
            {
                control.BackColor = Color.Gray;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dt = dt.AddMonths(1);
            UpdateCalendar();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            dt = dt.AddMonths(-1);
            UpdateCalendar();
        }

        private void DayClick(object sender, MouseEventArgs e)
        {
            Control p = sender is Panel ? (Control)sender : ((Control)sender).Parent;
            if (selecting) SelectDate(p);
        }

        public void SelectDate(Control control)
        {
            int index = daysControls.IndexOf(control);
            DateTime dtSelected = showingDates[index];
            bool canSelect = true;
            if (noDisponibles.Contains(dtSelected)) canSelect = false;
            if (canSelect) // si es una fecha seleccionable
            {
                if (selectedDates.Contains(dtSelected)) selectedDates.Remove(dtSelected);
                else selectedDates.Add(dtSelected);
            }
            UpdateCalendar();
        }
        
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            selecting = !selecting;
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

    }
}

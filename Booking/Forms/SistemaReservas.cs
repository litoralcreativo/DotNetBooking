using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public class SistemaReservas
    {
        public Propiedad propiedad;
        public List<DateTime> reservedDates;
        public List<DateTime> selectedDates;
        public List<DateTime> showingDates;
        public List<DateTime> noDisponibles;
        public List<Control> daysControls;
        public DateTime dt;
        public bool selecting = false;

        public SistemaReservas(Propiedad propiedad, List<Control> daysControls)
        {
            this.propiedad = propiedad;
            noDisponibles = new List<DateTime>();
            selectedDates = new List<DateTime>();
            showingDates = new List<DateTime>();
            reservedDates = propiedad.FechasReservadas();
            dt = DateTime.Now;
            this.daysControls = daysControls;
        }

        public void UpdateCalendar()
        {
            DateTime firstDayOfMonth = dt.AddDays(-dt.Day + 1); // 21/10 --> 1/10
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
            for (int i = 0; i < 42; i++)
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
                        if (dayOfCalendar.DayOfWeek == DayOfWeek.Friday
                            || dayOfCalendar.DayOfWeek == DayOfWeek.Saturday
                            || dayOfCalendar.DayOfWeek == DayOfWeek.Sunday)
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

        public bool SelectDate(Control control)
        {
            bool result = true;
            int index = daysControls.IndexOf(control);
            DateTime dtSelected = showingDates[index];
            bool canSelect = true;
            if (noDisponibles.Contains(dtSelected)) canSelect = false;
            if (canSelect) // si es una fecha seleccionable
            {
                if (selectedDates.Contains(dtSelected))
                {
                    selectedDates.Clear();
                }
                else
                {
                    if (propiedad is CasaFinDeSemana) // seleccionar todo los dias
                    {
                        selectedDates.Clear();
                        switch (dtSelected.DayOfWeek)
                        {
                            case DayOfWeek.Friday:
                                {
                                    selectedDates.Add(dtSelected);
                                    selectedDates.Add(dtSelected.AddDays(1));
                                    selectedDates.Add(dtSelected.AddDays(2));
                                    break;
                                }
                            case DayOfWeek.Saturday:
                                {
                                    selectedDates.Add(dtSelected.AddDays(-1));
                                    selectedDates.Add(dtSelected);
                                    selectedDates.Add(dtSelected.AddDays(1));
                                    break;
                                }
                            case DayOfWeek.Sunday:
                                {
                                    selectedDates.Add(dtSelected);
                                    selectedDates.Add(dtSelected.AddDays(-1));
                                    selectedDates.Add(dtSelected.AddDays(-2));
                                    break;
                                }
                        }
                    }
                    else // seleccionar primer dia
                    {
                        int minimos = propiedad is CasaPorDia ? ((CasaPorDia)propiedad).GetDiasMinimos() : 1;
                        result = SetNumberOfDaysDays(minimos, dtSelected);
                    }
                }
            }
            UpdateCalendar();
            return result;
        }

        public bool SetNumberOfDaysDays(int minimos)
        {
            bool result = true;
            DateTime dtSelected = selectedDates[0];
            selectedDates.Clear();
            int i = 0;
            while (result == true && i < minimos)
            {
                DateTime dt = dtSelected.AddDays(i);
                result = CheckDisponibilidad(dt);
                if (result) selectedDates.Add(dtSelected.AddDays(i));
                i++;
            }
            UpdateCalendar();

            return result;

        }
        public bool SetNumberOfDaysDays(int minimos, DateTime dtSelected)
        {
            bool result = true;
            selectedDates.Clear();
            int i = 0;
            while (result == true && i < minimos)
            {
                DateTime dt = dtSelected.AddDays(i);
                result = CheckDisponibilidad(dt);
                if (result) selectedDates.Add(dtSelected.AddDays(i));
                i++;
            }
            if (!result)
            {
                selectedDates.Clear();
            }
            return result;

        }

        private bool CheckDisponibilidad(DateTime dt)
        {
            bool result = true;
            int i = 0;
            while (result == true && i < reservedDates.Count)
            {
                if (reservedDates[i].Date == dt.Date) result = false;
                i++;
            }
            return result;
        }
        

    }
}

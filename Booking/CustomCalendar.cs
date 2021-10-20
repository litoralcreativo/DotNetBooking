using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    class CustomCalendar : MonthCalendar
    {
        private int dayBoxWidth = 0;
        private int dayBoxHeight = 15;
        private List<DateTime> xList = new List<DateTime>();
        private string cross = "X";
        private Font xFont;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int dayBoxWidth = 0;
            int dayBoxHeight = 0;
            int firstWeekPosition = 0;
            int lastWeekPosition = 0;

            if (xList.Count > 0)
            {
                SelectionRange calendarRange = GetDisplayRange(false);
                List<DateTime> visibleXList = new List<DateTime>();

                foreach (DateTime dates in xList)
                {
                    if (dates >= calendarRange.Start && dates <= calendarRange.End)
                    {
                        visibleXList.Add(dates);
                    }
                }
                if (visibleXList.Count > 0)
                {
                    while (HitTest(25, firstWeekPosition).HitArea != HitArea .PrevMonthDate
                        && HitTest(25, firstWeekPosition).HitArea != HitArea.Date
                        && firstWeekPosition < Height)
                    {
                        firstWeekPosition += 1;
                    }

                    while (HitTest(25, lastWeekPosition).HitArea != HitArea.NextMonthDate 
                        && HitTest(25, lastWeekPosition).HitArea != HitArea.Date 
                        && lastWeekPosition >= 0)
                    {
                        lastWeekPosition -= 1;
                    }

                    if (firstWeekPosition > 0 && lastWeekPosition > 0)
                    {
                        dayBoxWidth = Convert.ToInt32(Width / (ShowWeekNumbers? 8 : 7));
                        dayBoxHeight = Convert.ToInt32(Convert.ToDouble(lastWeekPosition - firstWeekPosition) / 6.0);

                        Brush warningBrush = new SolidBrush(Color.Red);

                        foreach (DateTime visDate in visibleXList)
                        {
                            int row = 0;
                            int col = 0;

                            TimeSpan span;
                            span = visDate.Subtract(calendarRange.Start);
                            row = Convert.ToInt32(span.Days / 7);
                            col = span.Days % 7;

                            Rectangle rect = new Rectangle(col + (ShowWeekNumbers ? 1 : 0) * dayBoxWidth + 2, firstWeekPosition + row * dayBoxHeight + 1, dayBoxWidth - 2, dayBoxHeight - 2);
                            TextRenderer.DrawText(g, cross, xFont, rect, Color.Red);
                        }
                    }
                }

            }

        }
    }
}

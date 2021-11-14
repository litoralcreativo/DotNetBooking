using System.Drawing.Printing;

namespace Booking
{
    public interface IPrintable
    {
        void PrintPage(object sender, PrintPageEventArgs e);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    class CUILException:ApplicationException
    {
        public CUILException()
                : base("CUIT Inválido")
        {
        }
        public CUILException(string msg)
            : base(msg)
        {
        }
        public CUILException(string msg, Exception e)
            : base(msg, e)
        {
        }
    }
}

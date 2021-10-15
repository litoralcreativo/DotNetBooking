using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    [Serializable]
    public class Sesion
    {
        public DateTime entrada;
        public DateTime salida;
        public Sesion(DateTime dt)
        {
            entrada = dt;
        }
        public Sesion()
        {
            entrada = DateTime.Now;
        }
        public void CerrarSesion()
        {
            salida = DateTime.Now;
        }
        public void CerrarSesion(DateTime dt)
        {
            salida = dt;
        }
    }
}

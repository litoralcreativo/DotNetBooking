using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    [Serializable]
    public class Sesion : IComparable
    {
        public DateTime entrada;
        public DateTime salida;
        public Usuario user;
        public Sesion(DateTime dt, Usuario user)
        {
            entrada = dt;
            this.user = user;
        }
        public Sesion(Usuario user)
        {
            entrada = DateTime.Now;
            this.user = user;
        }
        public void CerrarSesion()
        {
            salida = DateTime.Now;
        }
        public void CerrarSesion(DateTime dt)
        {
            salida = dt;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Sesion otherSesion = obj as Sesion;
            if (otherSesion != null)
                return this.entrada.CompareTo(otherSesion.entrada);
            else
                throw new ArgumentException("El objeto no es una sesion");
        }
    }
}

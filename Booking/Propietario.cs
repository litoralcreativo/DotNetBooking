using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    [Serializable]
    public class Propietario
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public long Dni { get; private set; }
        public long Telefono { get; private set; }

        public Propietario(string nombre, string apellido, long dni, long telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Telefono = telefono;
        }

        public void AgregarPropiedad()
        {

        }

    }
}

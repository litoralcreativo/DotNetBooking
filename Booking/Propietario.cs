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
        private List<Propiedad> propiedades;

        public Propietario(string nombre, string apellido, long dni, long telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Telefono = telefono;
            propiedades = new List<Propiedad>();
        }

        public void AgregarPropiedad(Propiedad prop)
        {
            propiedades.Add(prop);
        }

        public List<Propiedad> ListarPropiedades()
        {
            return propiedades;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}", Apellido, Nombre);
        }

    }
}

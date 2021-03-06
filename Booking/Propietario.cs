using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    [Serializable]
    public class Propietario : IComparable
    {
        public static int pk;
        public readonly int id;
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
            id = pk;
            pk++;
        }
        public Propietario(string nombre, string apellido, long dni, long telefono, int id)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Telefono = telefono;
            propiedades = new List<Propiedad>();
            this.id = id;
        }

        public void AgregarPropiedad(Propiedad prop)
        {
            if (propiedades == null) propiedades = new List<Propiedad>();
            propiedades.Add(prop);
        }

        public List<Propiedad> ListarPropiedades()
        {
            return propiedades;
        }
        public int NumeroDeReservas()
        {
            int result = 0;
            for (int i = 0; i < propiedades.Count; i++)
            {
                List<Reserva> res = propiedades[i].listarReservas();
                for (int j = 0; j < res.Count; j++)
                {
                    if (res[j].GetStatus())
                        result += 1;
                }
            }
            return result;
        }
        public override string ToString()
        {
            return String.Format("{0}, {1}", Apellido, Nombre);
        }

        public ArrayList Resumen()
        {
            ArrayList result = new ArrayList();
            result.Add("Resumen de reservas");
            result.Add(DateTime.Now.ToString());
            result.Add("Propietario: "+ToString());
            for (int i = 0; i < propiedades.Count; i++)
            {
                if (propiedades[i].listarReservas().Count() != 0)
                {
                    result.Add(propiedades[i].Resumen());
                }
            }
            return result;
        }

        public List<Reserva> getReservas()
        {
            List<Reserva> result = new List<Reserva>();
            for (int i = 0; i < propiedades.Count; i++)
            {
                List<Reserva> reservProps = propiedades[i].listarReservas();
                for (int j = 0; j < reservProps.Count; j++)
                {
                    result.Add(reservProps[j]);
                }
            }
            return result;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Propietario otherProp = obj as Propietario;
            if (otherProp != null)
                return this.id.CompareTo(otherProp.id);
            else
                throw new ArgumentException("El objeto no es una Propietario");
        }
    }
}

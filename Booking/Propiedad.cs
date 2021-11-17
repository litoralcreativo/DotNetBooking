using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    [Serializable]
    public abstract class Propiedad : IComparable
    {
        public static int pk;
        public readonly int id;
        public string Nombre { get; set; }
        public int Plazas { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public double Precio { get; set; }
        private string[] ImagesPath = new string[2];

        private List<Servicio> servicios;
        private Propietario propietario;
        private List<Reserva> reservas;
        public bool Eliminada { get; private set; }

        public Propiedad(string nombre, int plazas, string dir, string loc, double precio, string[] imagesPath)
        {
            Nombre = nombre;
            Plazas = plazas;
            Direccion = dir;
            Localidad = loc;
            Precio = precio;
            Eliminada = false;
            servicios = new List<Servicio>();
            reservas = new List<Reserva>();
            this.ImagesPath = imagesPath;
            id = pk;
            pk++;
        }
        public Propiedad(string nombre, int plazas, string dir, string loc, double precio, string[] imagesPath, int id)
        {
            Nombre = nombre;
            Plazas = plazas;
            Direccion = dir;
            Localidad = loc;
            Precio = precio;
            Eliminada = false;
            servicios = new List<Servicio>();
            reservas = new List<Reserva>();
            this.ImagesPath = imagesPath;
            this.id = id;
        }

        public void Eliminar()
        {
            Eliminada = true;
        }

        public void ActualizarServicios(List<Servicio> ser)
        {
            servicios = ser;
        }
        public abstract double Presupuestar(int unitarios);
        public void AgregarPropietario(Propietario prop)
        {
            propietario = prop;
        }
        public abstract string Tipo();
        public Propietario getPropietario()
        {
            return propietario;
        }
        public abstract TipoPropiedad getTipo();
        public string[] getImages()
        {
            return ImagesPath;
        }
        public void setImages(string[] ImagesPath)
        {
            this.ImagesPath = ImagesPath;
        }
        public List<Servicio> getServicios()
        {
            return servicios;
        }
        public string serviciosToString()
        {
            string result = "";
            foreach (Servicio s in servicios)
            {
                switch (s)
                {
                    case Servicio.Ac:
                        result += "AC ";
                        break;
                    case Servicio.Cochera:
                        result += "COCH ";
                        break;
                    case Servicio.Desayuno:
                        result += "DES ";
                        break;
                    case Servicio.Mascotas:
                        result += "MASC ";
                        break;
                    case Servicio.Piscina:
                        result += "PISC ";
                        break;
                    case Servicio.Wifi:
                        result += "WIFI ";
                        break;
                }

            }
            return result;
        }
        public List<DateTime> FechasReservadas()
        {
            List<DateTime> dates = new List<DateTime>();
            
            foreach (Reserva r in reservas)
            {
                for (int i = 0; i < r.DiasTotales(); i++)
                {
                    dates.Add(r.entrada.AddDays(i));
                }
            }
            return dates;
        }
        public void AgregarReserva(Reserva r)
        {
            reservas.Add(r);
        }
        public List<Reserva> listarReservas ()
        {
            return reservas;
        }
        public List<string> Resumen()
        {
            List<string> sb = new List<string>();
            reservas.Sort();
            string s;
            sb.Add("________________________________________________________________________________________________________________");
            s = String.Format("Codigo propiedad: {0}", id);
            sb.Add(s);
            s = String.Format("Direccion: {0, -50} | plazas: {1}",Localidad +", "+ Direccion, Plazas);
            sb.Add(s);
            s = String.Format("Precio base: $ {0, -20}", Precio);
            sb.Add(s);
            sb.Add("\n");
            for (int i = 0; i < reservas.Count; i++)
            {
                if (reservas[i].GetStatus())
                {
                    string entrada = reservas[i].entrada.ToShortDateString();
                    string salida = reservas[i].salida.ToShortDateString();
                    double monto = reservas[i].monto;
                    string cliente = reservas[i].cliente.ToString();
                    s = String.Format("   |Cliente| {0}", cliente);
                    sb.Add(s);
                    s = String.Format("   |Reserva| in: {0} - out: {1} - monto: $ {2}", entrada, salida, monto);
                    sb.Add(s);
                    sb.Add("\n");
                }
            }

            return sb;
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Propiedad otherProp = obj as Propiedad;
            if (otherProp != null)
                return this.id.CompareTo(otherProp.id);
            else
                throw new ArgumentException("El objeto no es una Propiedad");
        }
    }
    
    [Serializable]
    public enum Servicio
    {
        Ac,
        Cochera,
        Desayuno,
        Mascotas,
        Piscina,
        Wifi
    }
    
    [Serializable]
    public enum TipoPropiedad
    {
        Hotel,
        CasaFinDeSemana,
        CasaPorDia
    }
}

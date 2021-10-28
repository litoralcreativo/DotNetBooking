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
        public readonly int _ref;
        public string Nombre { get; set; }
        public int Plazas { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public double Precio { get; set; }
        private string[] ImagesPath = new string[2];

        private List<Servicio> servicios;
        private Propietario propietario;
        private List<Reserva> reservas;

        public Propiedad(int _ref, string nombre, int plazas, string dir, string loc, double precio, string[] imagesPath)
        {
            this._ref = _ref;
            Nombre = nombre;
            Plazas = plazas;
            Direccion = dir;
            Localidad = loc;
            Precio = precio;
            servicios = new List<Servicio>();
            reservas = new List<Reserva>();
            this.ImagesPath = imagesPath;
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
        public virtual string Tipo()
        {
            return "Propiedad abstracta";
        }
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
            s = String.Format("Codigo propiedad: {0}", _ref);
            sb.Add(s);
            s = String.Format("Direccion: {0, -50} | plazas: {1}",Localidad +", "+ Direccion, Plazas);
            sb.Add(s);
            s = String.Format("Precio base: $ {0, -20}", Precio);
            sb.Add(s);
            sb.Add("\n");
            for (int i = 0; i < reservas.Count; i++)
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

            return sb;
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Propiedad otherProp = obj as Propiedad;
            if (otherProp != null)
                return this._ref.CompareTo(otherProp._ref);
            else
                throw new ArgumentException("El objeto no es una Propiedad");
        }

    }
    
    [Serializable]
    public enum Servicio
    {
        Desayuno,
        Piscina,
        Wifi,
        Ac,
        Cochera,
        Mascotas
    }
    
    [Serializable]
    public enum TipoPropiedad
    {
        Hotel,
        CasaFinDeSemana,
        CasaPorDia
    }
}

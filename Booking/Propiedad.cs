using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    [Serializable]
    public abstract class Propiedad
    {
        public readonly int _ref;
        public string Nombre { get; set; }
        public int Plazas { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public double Precio { get; set; }
        public List<string> imagenes;
        private List<Servicio> servicios;
        private Propietario propietario;
        public Propiedad(int _ref, string nombre, int plazas, string dir, string loc, double precio)
        {
            this._ref = _ref;
            Nombre = nombre;
            Plazas = plazas;
            Direccion = dir;
            Localidad = loc;
            Precio = precio;
            imagenes = new List<string>();
            servicios = new List<Servicio>();
        }
        public void ActualizarServicios(List<Servicio> ser)
        {
            servicios = ser;
        }
        public void AgregarImagen(string path)
        {
            imagenes.Add(path);
        }
        public List<string> ListarImagenes()
        {
            return imagenes;
        }
        public double presupuestar(DateTime ingreso, DateTime salida)
        {
            return 0;
        }
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

    public enum TipoPropiedad
    {
        Hotel,
        CasaFinDeSemana,
        CasaPorDia
    }
}

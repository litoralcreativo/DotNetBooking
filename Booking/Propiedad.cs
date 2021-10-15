using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    public class Propiedad
    {
        public readonly int _ref;
        public string Nombre { get; set; }
        public int Plazas { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public double Precio { get; set; }
        public List<string> Imagenes;
        public Propiedad(int _ref, string nombre, int plazas, string dir, string loc, double precio)
        {
            this._ref = _ref;
            Nombre = nombre;
            Plazas = plazas;
            Direccion = dir;
            Localidad = loc;
            Precio = precio;
            Imagenes = new List<string>();
        }

    }
}

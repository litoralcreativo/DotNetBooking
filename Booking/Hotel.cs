using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    [Serializable]
    public class Hotel : Propiedad
    {
        private int categoria;

        public int GetCategoria()
        {
            return categoria;
        }

        public void SetCategoria(int value)
        {
            categoria = value;
        }

        public Hotel(string nombre, int plazas, string dir, string loc, double precio, string[] images, int categoria, int id)
            : base(nombre, plazas, dir, loc, precio, images, id)
        {
            this.categoria = categoria;
        }
        public Hotel(string nombre, int plazas, string dir, string loc, double precio, string[] images, int categoria) 
            : base(nombre, plazas, dir, loc, precio, images)
        {
            this.categoria = categoria;
        }

        public override double Presupuestar(int unitarios)
        {
            return Precio * unitarios * 1.03;
        }

        public override TipoPropiedad getTipo()
        {
            return TipoPropiedad.Hotel;
        }
        public override string Tipo()
        {
            return "Hotel";
        }
    }
}

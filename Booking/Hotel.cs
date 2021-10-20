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
        public Hotel(int _ref, string nombre, int plazas, string dir, string loc, double precio) 
            : base(_ref, nombre, plazas, dir, loc, precio)
        {
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

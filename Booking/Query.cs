using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    public class Query
    {
        public List<TipoPropiedad> tipo;
        public List<Servicio> servicios;
        public int precioMinimo;
        public int precioMaximo;
        public int plazas;
        public bool exactPlazas;
        public Query(List<TipoPropiedad> tipo, List<Servicio> servicios, int precioMinimo, int precioMaximo, int plazas, bool exactPlazas)
        {
            this.tipo = tipo;
            this.servicios = servicios;
            this.precioMinimo = precioMinimo;
            this.precioMaximo = precioMaximo;
            this.plazas = plazas;
            this.exactPlazas = exactPlazas;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    public class Query
    {
        public List<TipoPropiedad> tipo = null;
        public List<Servicio> servicios = null;
        public int precioMinimo = 100;
        public int precioMaximo = 999999;
        public int plazas = 1;
        public bool exactPlazas = false;
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

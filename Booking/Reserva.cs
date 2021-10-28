using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    [Serializable]
    public class Reserva
    {
        public readonly Cliente cliente;
        public readonly DateTime entrada;
        public readonly DateTime salida;
        public readonly Propiedad propiedad;

        public Reserva(Cliente cliente, DateTime entrada, DateTime salida, Propiedad propiedad)
        {
            this.cliente = cliente;
            this.entrada = entrada;
            this.salida = salida;
            this.propiedad = propiedad;
        }
        
        public int DiasTotales()
        {
            return (int)(salida - entrada).TotalDays;
        }
        public string ImprimirReserva()
        {
            propiedad.Presupuestar(5);
            return "";
        }
    }
}

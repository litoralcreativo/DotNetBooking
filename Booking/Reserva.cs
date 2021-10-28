using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    [Serializable]
    public class Reserva : IComparable
    {
        public readonly Cliente cliente;
        public readonly DateTime entrada;
        public readonly DateTime salida;
        public readonly Propiedad propiedad;
        public readonly double monto;

        public Reserva(Cliente cliente, DateTime entrada, DateTime salida, Propiedad propiedad)
        {
            this.cliente = cliente;
            this.entrada = entrada;
            this.salida = salida;
            this.propiedad = propiedad;
            monto = Presupuestar();
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Reserva otherReserva = obj as Reserva;
            if (otherReserva != null)
                return this.entrada.CompareTo(otherReserva.entrada);
            else
                throw new ArgumentException("El objeto no es una reserva");
        }

        public int DiasTotales()
        {
            return (int)(salida - entrada).TotalDays;
        }
        private double Presupuestar()
        {
            return propiedad.Presupuestar(DiasTotales());
        }
    }
}

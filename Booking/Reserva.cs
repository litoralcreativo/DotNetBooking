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
        public static int pk;
        public readonly int id;

        public readonly Cliente cliente;
        public readonly DateTime entrada;
        public readonly DateTime salida;
        public readonly Propiedad propiedad;
        public readonly double monto;
        private bool activa;

        public Reserva(Cliente cliente, DateTime entrada, DateTime salida, Propiedad propiedad)
        {
            activa = true;
            this.cliente = cliente;
            this.entrada = entrada;
            this.salida = salida;
            this.propiedad = propiedad;
            monto = Presupuestar();
            id = pk;
            pk++;
        }
        public Reserva(Cliente cliente, DateTime entrada, DateTime salida, Propiedad propiedad, int id, bool estado, double monto)
        {
            activa = estado;
            this.cliente = cliente;
            this.entrada = entrada;
            this.salida = salida;
            this.propiedad = propiedad;
            this.monto = monto;
            this.id = id;
        }


        public int DiasTotales()
        {
            return (int)(salida - entrada).TotalDays+1;
        }
        private double Presupuestar()
        {
            return propiedad.Presupuestar(DiasTotales());
        }
        public bool GetStatus()
        {
            return activa;
        }
        public void Alta()
        {
            activa = false;
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
    }
}

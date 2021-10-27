using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    [Serializable]
    class CasaPorDia : Propiedad
    {
        private int diasMinimos;

        public CasaPorDia(int _ref, string nombre, int plazas, string dir, string loc, double precio, string[] images, int minimos)
            : base(_ref, nombre, plazas, dir, loc, precio, images)
        {
            this.diasMinimos = minimos;
        }

        public override TipoPropiedad getTipo()
        {
            return TipoPropiedad.CasaPorDia;
        }

        public override double Presupuestar(int unitarios)
        {
            int extras = unitarios - diasMinimos;
            double result = Precio * diasMinimos;           // cobro por dias minimos
            result += Precio * extras * 0.9;                   // cobro dias con descuento (extras)
            return result;
        }


        public int GetDiasMinimos()
        {
            return diasMinimos;
        }
        public void SetDiasMinimos(int value)
        {
            diasMinimos = value;
        }


        public override string Tipo()
        {
            return "Casa por día";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    [Serializable]
    class CasaFinDeSemana : Propiedad
    {
        public CasaFinDeSemana(int _ref, string nombre, int plazas, string dir, string loc, double precio, string[] images)
            : base(_ref, nombre, plazas, dir, loc, precio, images)
        {

        }
        public override double Presupuestar(int unitarios)
        {
            return Precio * 1;
        }
            
        public override TipoPropiedad getTipo()
        {
            return TipoPropiedad.CasaFinDeSemana;
        }
        public override string Tipo()
        {
            return "Casa de fin de semana";
        }
    }
}

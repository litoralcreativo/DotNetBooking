using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    public class Cliente
    {
        private long dni;
        private long telefono;
        private string nombre;
        private string direccion;
        private int cantidadDePersonas;
        public Cliente(long dni, long telefono, string nombre, string direccion, int cantidadDePersonas)
        {
            this.dni = dni;
            this.telefono = telefono;
            this.nombre = nombre;
            this.direccion = direccion;
            this.cantidadDePersonas = cantidadDePersonas;
        }

        public int GetCantidadDePersonas()
        {
            return cantidadDePersonas;
        }
        public void SetCantidadDePersonas(int value)
        {
            cantidadDePersonas = value;
        }

        public string GetDireccion()
        {
            return direccion;
        }
        public void SetDireccion(string value)
        {
            direccion = value;
        }

        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string value)
        {
            nombre = value;
        }

        public long GetTelefono()
        {
            return telefono;
        }
        public void SetTelefono(long value)
        {
            telefono = value;
        }

        public long GetDni()
        {
            return dni;
        }
        public void SetDni(long value)
        {
            dni = value;
        }
    }
}

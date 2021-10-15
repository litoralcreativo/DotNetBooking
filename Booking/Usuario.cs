using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    [Serializable]
    public class Usuario
    {
        public CategoriaUsuario Categoria { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Username { get; set; }
        private string Pass { get; set; }

        public List<Sesion> sesiones = new List<Sesion>();
        Sesion sesionActual;

        public Usuario(string uName, string uPass)
        {
            Username = uName;
            Pass = uPass;
        }

        public bool ValidateCredentials(string uName, string uPass)
        {
            return uName == Username && uPass == Pass;
        }
        public void MarcarEntrada()
        {
            sesionActual = new Sesion();
        }
        public void MarcarEntrada(DateTime dt)
        {
            sesionActual = new Sesion(dt);
        }
        public void MarcarSalida()
        {
            sesionActual.CerrarSesion();
            Sesion guardar = sesionActual;
            sesiones.Add(guardar);
            sesionActual = null;
        }
        public void MarcarSalida(DateTime dt)
        {
            sesionActual.CerrarSesion(dt);
            sesiones.Add(sesionActual);
        }
    }
    
    [Serializable]
    public enum CategoriaUsuario
    {
        Administrador,
        Empleado
    }
}

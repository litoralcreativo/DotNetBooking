using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    [Serializable]
    public class Usuario
    {
        public static int pk;
        public readonly int id;
        public CategoriaUsuario Categoria { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Username { get; set; }
        private string Pass { get; set; }

        public List<Sesion> sesiones = new List<Sesion>();
        Sesion sesionActual;

        public Usuario(string uName, string uPass, bool encripted = false)
        {
            Username = uName;
            Pass = encripted ? uPass : HashedPass(uPass);
            id = pk;
            pk++;
        }
        public Usuario(string uName, string uPass, int id,  bool encripted = false)
        {
            Username = uName;
            Pass = encripted ? uPass : HashedPass(uPass);
            this.id = pk;
        }

        public bool ValidateCredentials(string uName, string uPass)
        {
            return uName == Username && HashedPass(uPass) == Pass;
        }
        public void MarcarEntrada()
        {
            sesionActual = new Sesion(this);
        }
        public void MarcarEntrada(DateTime dt)
        {
            sesionActual = new Sesion(dt, this);
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
        public string HashedPass()
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(Pass));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }
        public string HashedPass(string uPass)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(uPass));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }
    }
    
    [Serializable]
    public enum CategoriaUsuario
    {
        Administrador,
        Empleado
    }
}

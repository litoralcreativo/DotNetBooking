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
    public class Usuario : IComparable
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
            this.id = id;
        }

        public bool ValidateCredentials(string uName, string uPass)
        {
            return uName == Username && HashedPass(uPass) == Pass;
        }
        public void MarcarEntrada()
        {
            sesionActual = new Sesion(this);
        }
        public void MarcarSalida()
        {
            sesionActual.CerrarSesion();
            Sesion guardar = sesionActual;
            sesiones.Add(guardar);
            sesionActual = null;
        }
        public string HashedPass()
        {
            return Pass;
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
        
        public void ImportarSesion(Sesion s)
        {
            sesiones.Add(s);
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
                Usuario user = obj as Usuario;
            if (user != null)
                return this.id.CompareTo(user.id);
            else
                throw new ArgumentException("El objeto no es una Propietario");
        }
    }
    
    [Serializable]
    public enum CategoriaUsuario
    {
        Administrador,
        Empleado
    }
}

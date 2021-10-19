using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    [Serializable]
    public class Empresa
    {
        public static int _ref = 0;
        public List<Usuario> usuarios = new List<Usuario>();
        private List<Propietario> propietarios = new List<Propietario>();
        private List<Propiedad> propiedades = new List<Propiedad>();
        public List<string> localidades = new List<string>();
        public Usuario Sesion;
        
        public bool AgregarPropietario(Propietario prop)
        {
            Propietario encontrado = propietarios.Find(x => x.Dni == prop.Dni);
            if (encontrado == null)
            {
                propietarios.Add(prop);
                return true;
            }
            return false;
        }
        public List<Propietario> ListarPropietarios()
        {
            return propietarios;
        }
        
        
        public void AgregarLocalidad(string loc)
        {
            if (!localidades.Contains(loc))
            {
                localidades.Add(loc);
            }
        }
        public List<string> ListarLocalidades()
        {
            return localidades;
        }
        
        public bool AgregarUsuario(Usuario user)
        {
            Usuario encontrado = usuarios.Find(x => x.Username == user.Username);
            if (encontrado == null)
            {
                usuarios.Add(user);
                return true;
            }
            return false;
        }

        public void AgregarPropiedad(Propiedad prop, int propietarioIndex)
        {
           prop.AgregarPropietario(propietarios[propietarioIndex]);
           propietarios[propietarioIndex].AgregarPropiedad(prop);
           propiedades.Add(prop);
        }
        public List<Propiedad> ListarPropiedades()
        {
            return propiedades;
        }


        public Usuario Login(string uName, string uPass)
        {
            Usuario encontrado = usuarios.Find(x => x.Username == uName);
            if (encontrado == null || !encontrado.ValidateCredentials(uName, uPass))
            {
                return null;
            } else
            {
                return encontrado;
            }
        }
    }
}

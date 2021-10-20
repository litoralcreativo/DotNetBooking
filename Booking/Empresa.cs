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
        public int _ref;
        public List<Usuario> usuarios;
        private List<Propietario> propietarios;
        private List<Propiedad> propiedades;
        public List<string> localidades;
        public Usuario Sesion;

        public Empresa()
        {
            _ref = 0;
            usuarios = new List<Usuario>();
            propietarios = new List<Propietario>();
            propiedades = new List<Propiedad>();
            localidades = new List<string>();
        }
        
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
        
        public List<Propiedad> Filter(List<TipoPropiedad> tipo = null, List<Servicio> servicios = null, int precioMaximo = 999999)
        {
            List<Propiedad> resultadoPropietarios = new List<Propiedad>();
            // filtrar por propieadad
            for (int i = 0; i < tipo.Count; i++)
            {
                resultadoPropietarios.AddRange(propiedades.Where(x => x.getTipo() == tipo[i]).ToList());
            }
            List<Propiedad> resultadoServicios = new List<Propiedad>();
            // remover si no tienen servicio
            for (int i = 0; i < resultadoPropietarios.Count; i++)
            {
                int c = 0;
                bool inPrice = false;
                for (int j = 0; j < servicios.Count; j++)
                {
                    if (resultadoPropietarios[i].getServicios().Contains(servicios[j])) c++;
                }
                inPrice = resultadoPropietarios[i].Precio <= precioMaximo;
                if (c == servicios.Count && inPrice) resultadoServicios.Add(resultadoPropietarios[i]);
            }
            return resultadoServicios;
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

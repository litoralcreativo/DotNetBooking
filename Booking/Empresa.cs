using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
        public List<Reserva> reservas;

        public Empresa()
        {
            _ref = 0;
            usuarios = new List<Usuario>();
            propietarios = new List<Propietario>();
            propiedades = new List<Propiedad>();
            localidades = new List<string>();
            reservas = new List<Reserva>();
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

        public Propiedad GetPropiedad(int _ref)
        {
            propiedades.Sort();
            string[] path = { "asd", "asdas" };
            Propiedad otro = new Hotel(_ref, "otro", 1, "dir", "loc", 0, path, 5);
            int index = propiedades.BinarySearch(otro);
            if (index >= 0)
            {
                return propiedades[index];
            }
            return null;
        }
        public Propietario GetPropietario(long dni)
        {
            propietarios.Sort();
            Propietario otro = new Propietario("nombre", "apell", 123123, 123123);
            int index = propietarios.BinarySearch(otro);
            if (index >= 0)
            {
                return propietarios[index];
            }
            return null;
        }


        public List<Propiedad> Filter(Query query)
        {
            List<Propiedad> propiedadesTipo = new List<Propiedad>();
            List<Propiedad> resultado = new List<Propiedad>();
            
            // filtrar por propieadad(es)
            for (int i = 0; i < query.tipo.Count; i++)
            {
                propiedadesTipo.AddRange(propiedades.Where(x => x.getTipo() == query.tipo[i]).ToList());
            }
            
            // resto de filtros
            for (int i = 0; i < propiedadesTipo.Count; i++)
            {
                int servCont = 0;
                Propiedad prop = propiedadesTipo[i];
                bool inPrice = prop.Precio <= query.precioMaximo && prop.Precio >= query.precioMinimo;
                int numPlazas = prop.Plazas;

                // cherquear q tenga todos los servicios
                for (int j = 0; j < query.servicios.Count; j++)
                {
                    if (prop.getServicios().Contains(query.servicios[j])) servCont++;
                }

                if (
                    servCont == query.servicios.Count &&        // tiene todos los servicios
                    inPrice &&                                  // esta en precio
                    (query.exactPlazas ?                        // numero de plazas es
                        (numPlazas == query.plazas) :             // igual
                        (numPlazas >= query.plazas))               // o mayor
                    ) resultado.Add(prop);
            }
            return resultado;
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

        internal void Reservar(Cliente c, Propiedad p, DateTime e, DateTime s)
        {
            Reserva nueva = new Reserva(c, e, s, p);
            reservas.Add(nueva);
            p.AgregarReserva(nueva);
        }
    }
}

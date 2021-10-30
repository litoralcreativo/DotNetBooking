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
        public Dictionary<string, int> primaryKeys;

        public List<Usuario> usuarios;
        private List<Propietario> propietarios;
        private List<Propiedad> propiedades;
        public List<string> localidades;
        public Usuario Sesion;
        public List<Reserva> reservas;

        public Empresa()
        {
            primaryKeys = new Dictionary<string, int>();
            primaryKeys.Add("usuarios", 0);
            primaryKeys.Add("propietarios", 0);
            primaryKeys.Add("propiedades", 0);
            primaryKeys.Add("reservas", 0);
            Usuario.pk = primaryKeys["usuarios"];
            Propietario.pk = primaryKeys["propietarios"];
            Propiedad.pk = primaryKeys["propiedades"];
            Reserva.pk = primaryKeys["reservas"];

            usuarios = new List<Usuario>();
            propietarios = new List<Propietario>();
            propiedades = new List<Propiedad>();
            localidades = new List<string>();
            reservas = new List<Reserva>();
        }
        public Empresa(int users_pk, int owners_pk, int properties_pk, int reservations_pk)
        {
            primaryKeys = new Dictionary<string, int>();
            primaryKeys.Add("usuarios", users_pk);
            primaryKeys.Add("propietarios", owners_pk);
            primaryKeys.Add("propiedades", properties_pk);
            primaryKeys.Add("reservas", reservations_pk);
            Usuario.pk = primaryKeys["usuarios"];
            Propietario.pk = primaryKeys["propietarios"];
            Propiedad.pk = primaryKeys["propiedades"];
            Reserva.pk = primaryKeys["reservas"];

            usuarios = new List<Usuario>();
            propietarios = new List<Propietario>();
            propiedades = new List<Propiedad>();
            localidades = new List<string>();
            reservas = new List<Reserva>();
        }
        public void RefreshPk()
        {
            Usuario.pk = primaryKeys["usuarios"];
            Propietario.pk = primaryKeys["propietarios"];
            Propiedad.pk = primaryKeys["propiedades"];
            Reserva.pk = primaryKeys["reservas"];
        }


        #region Propietarios
        public bool AgregarPropietario(Propietario prop)
        {
            Propietario encontrado = propietarios.Find(x => x.Dni == prop.Dni);
            if (encontrado == null)
            {
                propietarios.Add(prop);
                primaryKeys["propietarios"] = Propietario.pk;
                return true;
            }
            return false;
        }
        public List<Propietario> ListarPropietarios()
        {
            return propietarios;
        }
        public Propietario GetPropietario(int id)
        {
            propietarios.Sort();
            Propietario otro = new Propietario("nombre", "apell", 123123, 123123, id);
            int index = propietarios.BinarySearch(otro);
            if (index >= 0)
            {
                return propietarios[index];
            }
            return null;
        }
        #endregion


        #region Propiedades
        public void AgregarPropiedad(Propiedad prop, int propietarioIndex)
        {
            prop.AgregarPropietario(propietarios[propietarioIndex]);
            propietarios[propietarioIndex].AgregarPropiedad(prop);
            propiedades.Add(prop);
            primaryKeys["propiedades"] = Propiedad.pk;
        }
        public List<Propiedad> ListarPropiedades()
        {
            return propiedades;
        }
        public Propiedad GetPropiedad(int id)
        {
            propiedades.Sort();
            string[] path = { "asd", "asdas" };
            Propiedad otro = new Hotel("otro", 1, "dir", "loc", 0, path, 5, id);
            int index = propiedades.BinarySearch(otro);
            if (index >= 0)
            {
                return propiedades[index];
            }
            return null;
        }
        public bool BorrarPropiedad(Propiedad propiedad)
        {
            bool result = false;
            if (propiedad.listarReservas().Count == 0)
            {
                result = propiedades.Remove(propiedad);
            }
            return result;
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
        #endregion


        #region Localidades
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
        #endregion


        #region Usuarios/Sesiones
        public bool AgregarUsuario(Usuario user)
        {
            Usuario encontrado = usuarios.Find(x => x.Username == user.Username);
            if (encontrado == null)
            {
                usuarios.Add(user);
                primaryKeys["usuarios"] = Usuario.pk;
                return true;
            }
            return false;
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
        public void Logout()
        {
            Sesion.MarcarSalida();
            Sesion = null;
        }
        public List<Sesion> ListarSesiones()
        {
            List<Sesion> sesiones = new List<Sesion>();
            foreach (Usuario u in usuarios)
            {
                foreach (Sesion s in u.sesiones)
                {
                    sesiones.Add(s);
                }
            }
            sesiones.Sort();
            return sesiones;
        }
        public List<Usuario> ListarUsuarios()
        {
            return usuarios;
        }
        #endregion


        #region Reservas
        public List<Reserva> ListarReservas()
        {
            return reservas;
        }
        public void Reservar(Cliente c, Propiedad p, DateTime e, DateTime s)
        {
            Reserva nueva = new Reserva(c, e, s, p);
            reservas.Add(nueva);
            p.AgregarReserva(nueva);
        }
        #endregion
    }
}

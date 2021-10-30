using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Booking
{
    public static class ImportacionExportacion
    {
        public static Empresa ImportarEmpresa(string path)
        {
            FileStream file = null;
            StreamReader streamReader = null;
            Empresa nueva = null;
            string[] datos;
            try
            {
                /**** APERTURA ****/
                file = new FileStream(path, FileMode.Open, FileAccess.Read);
                streamReader = new StreamReader(file);

                /**** LECTURA ****/
                while (!streamReader.EndOfStream)
                {
                    datos = streamReader.ReadLine().Split(';');
                    switch (datos[0])
                    {
                        case "primarykeys":
                            {
                                nueva = new Empresa(Convert.ToInt32(datos[1]), Convert.ToInt32(datos[2]), Convert.ToInt32(datos[3]), Convert.ToInt32(datos[4]));
                                break;
                            }
                        case "usuario":
                            {
                                if (nueva != null)
                                {
                                    Usuario user = new Usuario(datos[3], datos[4], Convert.ToInt32(datos[1]), true);
                                    user.Categoria = Convert.ToInt32(datos[2]) == 0 ? CategoriaUsuario.Administrador : CategoriaUsuario.Empleado;
                                    user.Nombre = datos[5];
                                    user.Apellido = datos[6];
                                    nueva.AgregarUsuario(user);
                                }
                                break;
                            }
                        case "sesion":
                            {
                                DateTime entrada = Convert.ToDateTime(datos[2]);
                                DateTime salida = Convert.ToDateTime(datos[3]);
                                Usuario u = nueva.GetUsuario(Convert.ToInt32(datos[1]));
                                Sesion sesion = new Sesion(entrada, salida, u);
                                u.ImportarSesion(sesion);
                                break;
                            }
                        case "propietario":
                            {
                                Propietario propietario = new Propietario(datos[2], datos[3], Convert.ToInt64(datos[4]), Convert.ToInt64(datos[5]), Convert.ToInt32(datos[1]));
                                nueva.AgregarPropietario(propietario);
                                break;
                            }
                        case "propiedad":
                            {
                                int id = Convert.ToInt32(datos[1]);
                                int id_propietario = Convert.ToInt32(datos[2]);
                                TipoPropiedad tipo = (TipoPropiedad)Convert.ToInt32(datos[3]);
                                string nombre = datos[4];
                                int plazas = Convert.ToInt32(datos[5]);
                                string direccion = datos[6];
                                string localidad = datos[7];
                                double precio = Convert.ToDouble(datos[8]);
                                int minimo_categoria = Convert.ToInt32(datos[9]);
                                string[] imagenes = { datos[10] , datos[11] };
                                bool eliminada = Convert.ToInt32(datos[12]) == 1;
                                List<Servicio> servicios = new List<Servicio>();
                                if (Convert.ToInt32(datos[13]) == 1) servicios.Add(Servicio.Ac);
                                if (Convert.ToInt32(datos[14]) == 1) servicios.Add(Servicio.Cochera);
                                if (Convert.ToInt32(datos[15]) == 1) servicios.Add(Servicio.Desayuno);
                                if (Convert.ToInt32(datos[16]) == 1) servicios.Add(Servicio.Mascotas);
                                if (Convert.ToInt32(datos[17]) == 1) servicios.Add(Servicio.Piscina);
                                if (Convert.ToInt32(datos[18]) == 1) servicios.Add(Servicio.Wifi);
                                Propiedad propiedad = null;
                                switch (tipo)
                                {
                                    case TipoPropiedad.Hotel:
                                        propiedad = new Hotel(nombre, plazas, direccion, localidad, precio, imagenes, minimo_categoria, id);
                                        break;
                                    case TipoPropiedad.CasaPorDia:
                                        propiedad = new CasaPorDia(nombre, plazas, direccion, localidad, precio, imagenes, minimo_categoria, id);
                                        break;
                                    case TipoPropiedad.CasaFinDeSemana:
                                        propiedad = new CasaFinDeSemana(nombre, plazas, direccion, localidad, precio, imagenes, id);
                                        break;
                                }
                                propiedad.ActualizarServicios(servicios);
                                nueva.AgregarPropiedad(propiedad, id_propietario);
                                break;
                            }
                        case "reserva":
                            {
                                int id = Convert.ToInt32(datos[1]);
                                int id_propiedad = Convert.ToInt32(datos[2]);
                                DateTime entrada = Convert.ToDateTime(datos[3]);
                                DateTime salida = Convert.ToDateTime(datos[4]); 
                                double monto = Convert.ToDouble(datos[5]);
                                bool activa = Convert.ToInt32(datos[6]) == 1;
                                #region Cliente
                                long dni = Convert.ToInt64(datos[7]);
                                string nombre = datos[8];
                                long tel = Convert.ToInt64(datos[9]);
                                string direccion = datos[10];
                                int personas = Convert.ToInt32(datos[11]);
                                Cliente cliente = new Cliente(dni, tel, nombre, direccion, personas);
                                #endregion
                                Propiedad prop = nueva.GetPropiedad(id_propiedad);
                                Reserva reserva = new Reserva(cliente, entrada, salida, prop, id, activa, monto);
                                nueva.ImportarReserva(reserva);
                                break;
                            }
                        case "localidad":
                            {
                                nueva.AgregarLocalidad(datos[1]);
                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                /**** CIERRE ****/
                if (streamReader != null) streamReader.Close();
                if (file != null) file.Dispose();
            }
            return nueva;
        }
        public static bool Exportar(Empresa actual, string path)
        {
            FileStream file = null;
            StreamWriter streamWriter = null;
            bool resultado = false;

            try
            {
                string linea = "";
                file = new FileStream(path, FileMode.Create, FileAccess.Write);
                streamWriter = new StreamWriter(file);

                linea = String.Format("primarykeys");
                foreach (KeyValuePair<string, int> kvp in actual.primaryKeys)
                {
                    linea += ";"+kvp.Value;
                }
                streamWriter.WriteLine(linea);

                foreach (Usuario u in actual.ListarUsuarios())
                {
                    linea = String.Format("usuario;{0};{1};{2};{3};{4};{5}", u.id, (int)u.Categoria, u.Username, u.HashedPass(), u.Nombre, u.Apellido);
                    streamWriter.WriteLine(linea);
                }
                
                foreach (Sesion s in actual.ListarSesiones())
                {
                    linea = String.Format("sesion;{0};{1};{2}", s.user.id, s.entrada, s.salida);
                    streamWriter.WriteLine(linea);
                }

                foreach (Propietario p in actual.ListarPropietarios())
                {
                    linea = String.Format("propietario;{0};{1};{2};{3};{4}", p.id, p.Nombre, p.Apellido, p.Dni, p.Telefono);
                    streamWriter.WriteLine(linea);
                }

                foreach (Propiedad p in actual.ListarPropiedades())
                {
                    int minimos_categoria = -1;
                    if (p is Hotel) minimos_categoria = ((Hotel)p).GetCategoria();
                    if (p is CasaPorDia) minimos_categoria = ((CasaPorDia)p).GetDiasMinimos();
                    linea = String.Format("propiedad;{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11};{12};{13};{14};{15};{16};{17}",
                        p.id, 
                        p.getPropietario().id,
                        (int)p.getTipo(),
                        p.Nombre,
                        p.Plazas,
                        p.Direccion,
                        p.Localidad,
                        p.Precio,
                        minimos_categoria,
                        p.getImages()[0],
                        p.getImages()[1],
                        p.Eliminada ? 1 : 0,
                        p.getServicios().Contains(Servicio.Ac) ? 1 : 0,
                        p.getServicios().Contains(Servicio.Cochera) ? 1 : 0,
                        p.getServicios().Contains(Servicio.Desayuno) ? 1 : 0,
                        p.getServicios().Contains(Servicio.Mascotas) ? 1 : 0,
                        p.getServicios().Contains(Servicio.Piscina) ? 1 : 0,
                        p.getServicios().Contains(Servicio.Wifi) ? 1 : 0);
                    streamWriter.WriteLine(linea);
                }

                foreach (Reserva r in actual.ListarReservas())
                {
                    linea = String.Format("reserva;{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10}", 
                        r.id, 
                        r.propiedad.id, 
                        r.entrada, 
                        r.salida, 
                        r.monto, 
                        r.GetStatus() ? 1 : 0,
                        r.cliente.GetDni(),
                        r.cliente.GetNombre(),
                        r.cliente.GetTelefono(),
                        r.cliente.GetDireccion(),
                        r.cliente.GetCantidadDePersonas()
                        );
                    streamWriter.WriteLine(linea);
                }

                foreach (string s in actual.localidades)
                {
                    linea = String.Format("localidad;{0}", s);
                    streamWriter.WriteLine(linea);
                }

                resultado = true;
            }
            catch (Exception)
            {
                throw;
            } 
            finally
            {
                if (streamWriter != null) streamWriter.Close();
                if (file != null) file.Dispose();
            }
            return resultado;
        }
    }
}




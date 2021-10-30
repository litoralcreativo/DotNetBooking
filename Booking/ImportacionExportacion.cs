using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Booking
{
    public static class ImportacionExportacion
    {
        public static Empresa ImportarEmpresa(string path)
        {
            FileStream file;
            StreamReader streamReader;
            Empresa nueva = new Empresa();


            return nueva;
        }
        public static bool Exportar(Empresa actual, string path)
        {
            FileStream file = null;
            StreamWriter streamWriter = null;
            bool resultado = false;

            try
            {
                string linea;
                file = new FileStream(path, FileMode.Create, FileAccess.Write);
                streamWriter = new StreamWriter(file);
                
                foreach (Usuario u in actual.usuarios)
                {
                    linea = String.Format("usuario;{0};{1};{2};{3};{4};{5}", u.id, (int)u.Categoria, u.Username, u.HashedPass(), u.Nombre, u.Apellido);
                    streamWriter.WriteLine(linea);
                }

                foreach (Usuario u in actual.usuarios)
                {
                    foreach (Sesion s in u.sesiones)
                    {
                        linea = String.Format("sesion;{0};{1};{2}", u.id, s.entrada, s.salida);
                        streamWriter.WriteLine(linea);
                    }
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
                        p.id, p.getPropietario().id,
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




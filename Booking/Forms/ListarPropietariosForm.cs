using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Booking
{
    public partial class ListarPropietariosForm : Form, IPrintable
    {
        FileStream file;
        StreamWriter streamWriter = null;

        public List<Propietario> propietarios;
        public ListarPropietariosForm()
        {
            InitializeComponent();
        }

        private void btnResumen_Click(object sender, EventArgs e)   
        {
            try
            {
                printDocument1.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        public void PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                Propietario p = null;
                if (dgv.SelectedCells.Count >= 1)
                {
                    int rIndex = dgv.SelectedCells[0].RowIndex;
                    long dni = Convert.ToInt64(dgv.Rows[rIndex].Cells["dniColumn"].Value);
                    p = propietarios.Find(x => x.Dni == dni);
                }
                if (p == null) throw new Exception("ningun propietario seleccionado");


                ArrayList resumen = p.Resumen();
                Font encabezado = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Point);
                Font cuerpo = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);
                int width = 800;
                int lineHeight = 12;
                int y = 20;
                e.Graphics.DrawString((string)resumen[0], encabezado, Brushes.Black, new RectangleF(50, y, width, y));
                e.Graphics.DrawString((string)resumen[1], cuerpo, Brushes.Blue, new RectangleF(50, y += 20, width, y));
                e.Graphics.DrawString((string)resumen[2], encabezado, Brushes.Gray, new RectangleF(50, y += 20, width, y));
                if (resumen.Count == 3)
                {
                    e.Graphics.DrawString("No hay reservas actualmente", cuerpo, Brushes.Gray, new RectangleF(50, y += y, width, y));
                }
                else
                {
                    for (int i = 3; i < resumen.Count; i++)
                    {
                        if (resumen[i] is string)
                            e.Graphics.DrawString((string)resumen[i], cuerpo, Brushes.Black, new RectangleF(50, y += lineHeight, width, y));
                        else if (resumen[i] is List<string>)
                        {
                            List<string> lista = (List<string>)resumen[i];
                            for (int j = 0; j < lista.Count; j++)
                            {
                                if (j <= 3)
                                    e.Graphics.DrawString(lista[j], cuerpo, Brushes.Gray, new RectangleF(50, y += lineHeight, width, y));
                                else
                                    e.Graphics.DrawString(lista[j], cuerpo, Brushes.DarkGray, new RectangleF(50, y += lineHeight, width, y));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ListarPropietarios()
        {
            dgv.Rows.Clear();
            for (int i = 0; i < propietarios.Count; i++)
            {
                Propietario prop = propietarios[i];
                string nombre = prop.Nombre;
                string apellido = prop.Apellido;
                string dni = prop.Dni.ToString();
                string tel = prop.Telefono.ToString();
                string props = prop.ListarPropiedades().Count.ToString();
                string reservas = prop.NumeroDeReservas().ToString();

                dgv.Rows.Add(nombre, apellido, dni, tel, props, reservas);
            }
        }

        private void ListarPropietariosForm_Load(object sender, EventArgs e)
        {
            if (propietarios != null)
            ListarPropietarios();
        }

        #region draggin del form
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);


        private void pnlEncabezado_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void pnlEncabezado_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }

        private void pnlEncabezado_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        #endregion

        private void btnMigrar_Click(object sender, EventArgs e)
        {
            try
            {
                string path;
                Propietario p = null;
                if (dgv.SelectedCells.Count >= 1)
                {
                    int rIndex = dgv.SelectedCells[0].RowIndex;
                    long dni = Convert.ToInt64(dgv.Rows[rIndex].Cells["dniColumn"].Value);
                    p = propietarios.Find(x => x.Dni == dni);
                }

                sfd.FileName = "reservas-usr"+p.id+"-"+p.Nombre;
                if (sfd.ShowDialog() == DialogResult.OK)
                    path = sfd.FileName;
                else return;

                if (p == null) throw new Exception("ningun propietario seleccionado");
                string linea = "";
                file = new FileStream(path, FileMode.Create, FileAccess.Write);
                streamWriter = new StreamWriter(file);

                linea = String.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10}",
                    "id_reserva",
                    "id_propiedad",
                    "entrada",
                    "salida",
                    "monto",
                    "estado",
                    "cuil",
                    "nombre",
                    "telefono",
                    "direccion",
                    "se alojan");
                streamWriter.WriteLine(linea);

                foreach (Reserva r in p.getReservas())
                {
                    linea = String.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10}",
                        r.id,
                        r.propiedad.id,
                        r.entrada.Date,
                        r.salida.Date,
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (streamWriter != null) streamWriter.Close();
                if (file != null) file.Dispose();
            }
        }

    }
}

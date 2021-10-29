using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class PropiedadesForm : Form
    {
        private List<TipoPropiedad> filtroTipo;
        private List<Servicio> filtroServicio;
        private int precioMaximo;
        private int plazas;
        bool plazasExactas;
        int minPrice;
        int maxPrice;
        Query query;
        List<Propiedad> filtrado;

        public PropiedadesForm()
        {
            InitializeComponent();
            filtroTipo = new List<TipoPropiedad>();
            filtroTipo.Add(TipoPropiedad.Hotel);
            filtroTipo.Add(TipoPropiedad.CasaFinDeSemana);
            filtroTipo.Add(TipoPropiedad.CasaPorDia);
            filtroServicio = new List<Servicio>();
            precioMaximo = 5000;
            nudMinValue.Maximum = nudMaxValue.Value;
            nudMaxValue.Minimum = nudMinValue.Value;
            minPrice = Convert.ToInt32(nudMinValue.Value);
            maxPrice = Convert.ToInt32(nudMaxValue.Value);
            plazasExactas = rbPlazasExactas.Checked;
            //filtrado = ((FromPrincipal)ParentForm).empresa.ListarPropiedades();
        }

        private void PropiedadesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiParent != null) ((FromPrincipal)MdiParent).buscarToolStripMenuItem.Enabled = true;
        }

        public void ListarPropiedades(List<Propiedad> propiedades)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < propiedades.Count; i++)
            {
                Propiedad prop = propiedades[i];
                string _ref = prop._ref.ToString();
                string tipo = prop.Tipo();
                string precio = $"${prop.Precio}";
                int plazas = prop.Plazas;
                string local = prop.Localidad;
                string nombre = prop.Nombre;
                string direc = prop.Direccion;
                bool sAc = prop.getServicios().Contains(Servicio.Ac);
                bool sDes = prop.getServicios().Contains(Servicio.Desayuno);
                bool sCoch = prop.getServicios().Contains(Servicio.Cochera);
                bool sMasc = prop.getServicios().Contains(Servicio.Mascotas);
                bool sPisc = prop.getServicios().Contains(Servicio.Piscina);
                bool sWifi = prop.getServicios().Contains(Servicio.Wifi);
                //DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
                dgv.Rows.Add(_ref, tipo, precio, plazas, local, nombre, direc, sAc,sDes, sMasc, sWifi, sCoch, sPisc);
            }
            if (dgv.SelectedCells.Count >= 1)
            {
                int index = dgv.SelectedCells[0].RowIndex;
                Propiedad prop = filtrado[index];
                ShowImages(prop.getImages());
            } else
            {
                string[] empty = { null, null };
                ShowImages(empty);
            }
        }

        private void ShowImages(string[] images)
        {
            pbPrimera.ImageLocation = images[0];
            pbSegunda.ImageLocation = images[1];
        }

        public void ActualizarLista()
        {
            query = new Query(filtroTipo,filtroServicio,minPrice,maxPrice,plazas,plazasExactas);
            filtrado = ((FromPrincipal)ParentForm).empresa.Filter(query);
            ListarPropiedades(filtrado);
        }

        private void ckbHotel_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked && !filtroTipo.Contains(TipoPropiedad.Hotel)) filtroTipo.Add(TipoPropiedad.Hotel);
            else if (!((CheckBox)sender).Checked && filtroTipo.Contains(TipoPropiedad.Hotel)) filtroTipo.Remove(TipoPropiedad.Hotel);
            //ActualizarLista();
        }

        private void ckbCasaFDS_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked && !filtroTipo.Contains(TipoPropiedad.CasaFinDeSemana)) filtroTipo.Add(TipoPropiedad.CasaFinDeSemana);
            else if (!((CheckBox)sender).Checked && filtroTipo.Contains(TipoPropiedad.CasaFinDeSemana)) filtroTipo.Remove(TipoPropiedad.CasaFinDeSemana);
            //ActualizarLista();
        }

        private void ckbCasaPorDia_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked && !filtroTipo.Contains(TipoPropiedad.CasaPorDia)) filtroTipo.Add(TipoPropiedad.CasaPorDia);
            else if (!((CheckBox)sender).Checked && filtroTipo.Contains(TipoPropiedad.CasaPorDia)) filtroTipo.Remove(TipoPropiedad.CasaPorDia);
            //ActualizarLista();
        }

        public void ToogleServicio(object sender, Servicio serv)
        {
            if (((CheckBox)sender).Checked && !filtroServicio.Contains(serv)) filtroServicio.Add(serv);
            else if (!((CheckBox)sender).Checked && filtroServicio.Contains(serv)) filtroServicio.Remove(serv);
            //ActualizarLista();
        }

        private void ckbDesayuno_CheckedChanged(object sender, EventArgs e)
        {
            ToogleServicio(sender, Servicio.Desayuno);
        }

        private void ckbPiscina_CheckedChanged(object sender, EventArgs e)
        {
            ToogleServicio(sender, Servicio.Piscina);
        }

        private void ckbCochera_CheckedChanged(object sender, EventArgs e)
        {
            ToogleServicio(sender, Servicio.Cochera);
        }

        private void ckbWifi_CheckedChanged(object sender, EventArgs e)
        {
            ToogleServicio(sender, Servicio.Wifi);
        }

        private void ckbAC_CheckedChanged(object sender, EventArgs e)
        {
            ToogleServicio(sender, Servicio.Ac);
        }

        private void ckbMascotas_CheckedChanged(object sender, EventArgs e)
        {
            ToogleServicio(sender, Servicio.Mascotas);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            precioMaximo = 5000;
            lblPrecioMaximo.Text = $"${precioMaximo}";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            plazas = trackBar2.Value;
            lblPlazas.Text = $"{plazas}";
            //ActualizarLista();
        }

        private void rbPlazasMinimas_CheckedChanged(object sender, EventArgs e)
        {
            plazasExactas = rbPlazasExactas.Checked;
            //ActualizarLista();
        }

        private void rbPlazasExactas_CheckedChanged(object sender, EventArgs e)
        {
            plazasExactas = rbPlazasExactas.Checked;
            //ActualizarLista();
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            //precioMaximo = trackBar1.Value;
            lblPrecioMaximo.Text = $"${precioMaximo}";
            //ActualizarLista();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            minPrice = Convert.ToInt32(nudMinValue.Value);
            nudMaxValue.Minimum = minPrice;
            //ActualizarLista();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            maxPrice = Convert.ToInt32(nudMaxValue.Value);
            nudMinValue.Maximum = maxPrice;
            //ActualizarLista();
        }

        private void btnDisponibilidad_Click(object sender, EventArgs e)
        {
            try
            {
                FormMonth formMes = new FormMonth();
                int rIndex = dgv.SelectedCells[0].RowIndex;
                int _ref = Convert.ToInt32(dgv.Rows[rIndex].Cells[0].Value);
                Propiedad prop = ((FromPrincipal)ParentForm).empresa.GetPropiedad(_ref);
                formMes.propiedad = prop;
                if (formMes.ShowDialog() == DialogResult.OK)
                {
                    if (formMes.sr.selectedDates.Count > 0) // Hay dias por reservar
                    {
                        ClienteForm cf = new ClienteForm();
                        if (cf.ShowDialog() == DialogResult.OK)
                        {
                            string nombre = cf.tbNombre.Text;
                            long dni = Convert.ToInt64(cf.tbDni.Text);
                            long tel = Convert.ToInt64(cf.tbTelefono.Text);
                            string direc = cf.tbDireccion.Text;
                            int personas = Convert.ToInt32(cf.nudSeAlojan.Value);
                            Cliente c = new Cliente(dni, tel, nombre, direc, personas);
                            ((FromPrincipal)ParentForm).empresa.Reservar(c, prop, formMes.sr.selectedDates.First(), formMes.sr.selectedDates.Last());
                            MessageBox.Show("La reserva se realizo con exito!", "Reserva");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo realizar la reserva", "Reserva");
                        }

                    }
                }
            }
            catch (ArgumentOutOfRangeException ee)
            {
                MessageBox.Show("Error: No existen propiedades cargadas");
            }
        }

        private void PropiedadesForm_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedCells.Count >= 1)
            {
                int index = dgv.SelectedCells[0].RowIndex;
                Propiedad prop = filtrado[index];
                ShowImages(prop.getImages());
            }
            else
            {
                string[] empty = { null, null };
                ShowImages(empty);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                int rIndex = dgv.SelectedCells[0].RowIndex;
                int _ref = Convert.ToInt32(dgv.Rows[rIndex].Cells[0].Value);
                Propiedad editable = ((FromPrincipal)ParentForm).empresa.GetPropiedad(_ref);
                RegistroEdicionPropiedad regPropiedad = new RegistroEdicionPropiedad();
                List<Propietario> propietarios = ((FromPrincipal)ParentForm).empresa.ListarPropietarios();
                for (int i = 0; i < propietarios.Count; i++)
                {
                    regPropiedad.cbPropietario.Items.Add(propietarios[i].ToString());
                }
                regPropiedad.setEmpresa(ref ((FromPrincipal)ParentForm).empresa);
                regPropiedad.updateLocations();
                int pIndex = ((FromPrincipal)ParentForm).empresa.ListarPropietarios().IndexOf(editable.getPropietario());
                regPropiedad.cbPropietario.SelectedIndex = pIndex;
                regPropiedad.tipoPropiedad = editable.getTipo();
                regPropiedad.tbNombre.Text = editable.Nombre;
                regPropiedad.cbLocalidad.Text = editable.Localidad;
                regPropiedad.tbDireccion.Text = editable.Direccion;
                regPropiedad.nudPlazas.Value = editable.Plazas;
                regPropiedad.nudPrecioBase.Value = (decimal)editable.Precio;
                regPropiedad.pbPrimera.ImageLocation = editable.getImages()[0];
                regPropiedad.pbSegunda.ImageLocation = editable.getImages()[1];
                regPropiedad.cbPropietario.Enabled = false; // no cambiar propietario
                switch (regPropiedad.tipoPropiedad)
                {
                    case TipoPropiedad.Hotel:
                        regPropiedad.rbHotel.Checked = true;
                        regPropiedad.nudCategoriaHotel.Enabled = true;
                        regPropiedad.nudDiasMinimos.Enabled = false;
                        regPropiedad.nudCategoriaHotel.Value = ((Hotel)editable).GetCategoria();
                        break;
                    case TipoPropiedad.CasaPorDia:
                        regPropiedad.rbCPD.Checked = true;
                        regPropiedad.nudCategoriaHotel.Enabled = false;
                        regPropiedad.nudDiasMinimos.Enabled = true;
                        regPropiedad.nudCategoriaHotel.Value = ((CasaPorDia)editable).GetDiasMinimos();
                        break;
                    case TipoPropiedad.CasaFinDeSemana:
                        regPropiedad.rbCFDS.Checked = true;
                        break;
                }
                for (int i = 0; i < editable.getServicios().Count; i++)
                {
                    Servicio s = editable.getServicios()[i];
                    switch (s)
                    {
                        case Servicio.Ac: 
                           regPropiedad.ckbAC.Checked = true;
                            break;
                        case Servicio.Cochera:
                            regPropiedad.ckbAC.Checked = true;
                            break;
                        case Servicio.Desayuno:
                            regPropiedad.ckbDesayuno.Checked = true;
                            break;
                        case Servicio.Mascotas:
                            regPropiedad.ckbMascotas.Checked = true;
                            break;
                        case Servicio.Piscina:
                            regPropiedad.ckbPiscina.Checked = true;
                            break;
                        case Servicio.Wifi:
                            regPropiedad.ckbWifi.Checked = true;
                            break;
                    }
                }
                regPropiedad.btnBorrar.Visible = true;
                
                regPropiedad.propiedad = ((FromPrincipal)ParentForm).empresa.GetPropiedad(_ref);


                if (((FromPrincipal)ParentForm).empresa.Sesion.Categoria == CategoriaUsuario.Empleado)
                {
                    regPropiedad.btnBorrar.Enabled = false;
                }
                if (regPropiedad.ShowDialog() == DialogResult.OK)
                {
                    int propietarioIndex = regPropiedad.cbPropietario.SelectedIndex;
                    string nombre = regPropiedad.tbNombre.Text;
                    string localidad = regPropiedad.cbLocalidad.Text;
                    string direccion = regPropiedad.tbDireccion.Text;
                    int plazas = Convert.ToInt32(regPropiedad.nudPlazas.Value);
                    double precio = Convert.ToDouble(regPropiedad.nudPrecioBase.Value);
                    string[] imagesPath = { regPropiedad.pbPrimera.ImageLocation, regPropiedad.pbSegunda.ImageLocation };

                    // actualizar
                    editable.Nombre = nombre;
                    editable.Localidad = localidad;
                    editable.Direccion = direccion;
                    editable.Plazas = plazas;
                    editable.Precio = precio;
                    editable.setImages(imagesPath);
                    editable.ActualizarServicios(regPropiedad.servicios);
                    
                }
                ActualizarLista();
            }
        }
    }
}

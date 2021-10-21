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
            ActualizarLista();
        }

        private void ckbCasaFDS_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked && !filtroTipo.Contains(TipoPropiedad.CasaFinDeSemana)) filtroTipo.Add(TipoPropiedad.CasaFinDeSemana);
            else if (!((CheckBox)sender).Checked && filtroTipo.Contains(TipoPropiedad.CasaFinDeSemana)) filtroTipo.Remove(TipoPropiedad.CasaFinDeSemana);
            ActualizarLista();
        }

        private void ckbCasaPorDia_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked && !filtroTipo.Contains(TipoPropiedad.CasaPorDia)) filtroTipo.Add(TipoPropiedad.CasaPorDia);
            else if (!((CheckBox)sender).Checked && filtroTipo.Contains(TipoPropiedad.CasaPorDia)) filtroTipo.Remove(TipoPropiedad.CasaPorDia);
            ActualizarLista();
        }

        public void ToogleServicio(object sender, Servicio serv)
        {
            if (((CheckBox)sender).Checked && !filtroServicio.Contains(serv)) filtroServicio.Add(serv);
            else if (!((CheckBox)sender).Checked && filtroServicio.Contains(serv)) filtroServicio.Remove(serv);
            ActualizarLista();
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
            ActualizarLista();
        }

        private void rbPlazasMinimas_CheckedChanged(object sender, EventArgs e)
        {
            plazasExactas = rbPlazasExactas.Checked;
            ActualizarLista();
        }

        private void rbPlazasExactas_CheckedChanged(object sender, EventArgs e)
        {
            plazasExactas = rbPlazasExactas.Checked;
            ActualizarLista();
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            //precioMaximo = trackBar1.Value;
            lblPrecioMaximo.Text = $"${precioMaximo}";
            ActualizarLista();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            minPrice = Convert.ToInt32(nudMinValue.Value);
            nudMaxValue.Minimum = minPrice;
            ActualizarLista();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            maxPrice = Convert.ToInt32(nudMaxValue.Value);
            nudMinValue.Maximum = maxPrice;
            ActualizarLista();
        }

        private void btnDisponibilidad_Click(object sender, EventArgs e)
        {
            FormMonth formMes = new FormMonth();
            Propiedad prop = filtrado[dgv.SelectedCells[0].RowIndex];
            formMes.propiedad = prop;
            if (formMes.ShowDialog() == DialogResult.OK)
            {
                if (formMes.selectedDates.Count > 0)
                {
                    /********   SISTEMA PROVISORIO   *********/
                    ((FromPrincipal)ParentForm).empresa.GetPropiedad(prop._ref).ReservarFechas(formMes.selectedDates);
                }
            }
        }

        private void PropiedadesForm_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }
    }
}

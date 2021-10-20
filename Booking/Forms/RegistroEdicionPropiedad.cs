using Booking.Forms;
using System;
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
    public partial class RegistroEdicionPropiedad : Form
    {
        public RegistroEdicionPropiedad()
        {
            InitializeComponent();
        }

        public TipoPropiedad tipoPropiedad = TipoPropiedad.Hotel;

        private void rbHotel_CheckedChanged(object sender, EventArgs e)
        {
            tipoPropiedad = TipoPropiedad.Hotel;
            actualizarNombre();
        }

        private void rbCFDS_CheckedChanged(object sender, EventArgs e)
        {
            tipoPropiedad = TipoPropiedad.CasaFinDeSemana;
            actualizarNombre();
        }

        private void rbCPD_CheckedChanged(object sender, EventArgs e)
        {
            tipoPropiedad = TipoPropiedad.CasaPorDia;
            actualizarNombre();
        }


        private void actualizarNombre()
        {
            switch (tipoPropiedad)
            {
                case TipoPropiedad.Hotel:
                    tbNombre.Text = "";
                    tbNombre.Enabled = true;
                    break;
                case TipoPropiedad.CasaPorDia:
                case TipoPropiedad.CasaFinDeSemana:
                    tbNombre.Text = cbPropietario.Text;
                    tbNombre.Enabled = false;
                    break;
            }
        }

        private void btnNewLocal_Click(object sender, EventArgs e)
        {
            // crear nueva localidad
            AddLocationForm addLocForm = new AddLocationForm();
            if (addLocForm.ShowDialog() == DialogResult.OK)
            {
                string newLoc = addLocForm.tbLocation.Text;
                empresa.AgregarLocalidad(newLoc);
                updateLocations();
            }
        }

        private Empresa empresa;
        public void setEmpresa(ref Empresa e)
        {
            empresa = e;
        }

        public void updateLocations()
        {
            List<string> props = empresa.ListarLocalidades();
            cbLocalidad.Items.Clear();
            for (int i = 0; i < props.Count; i++)
            {
                cbLocalidad.Items.Add(props[i].ToString());
            }
        }

        private void cbPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarNombre();
        }
    }

}

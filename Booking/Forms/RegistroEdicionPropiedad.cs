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

        TipoPropiedad tipoPropiedad = TipoPropiedad.Hotel;
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
        }

        private void cbPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarNombre();
        }
    }
    public enum TipoPropiedad 
    { 
        Hotel,
        CasaFinDeSemana,
        CasaPorDia
    }

}

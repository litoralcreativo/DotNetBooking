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
    public partial class PropiedadesForm : Form
    {
        public PropiedadesForm()
        {
            InitializeComponent();
        }

        private void PropiedadesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiParent != null) ((FromPrincipal)MdiParent).buscarToolStripMenuItem.Enabled = true;
        }

        public void ListarPropiedades(List<Propiedad> propiedades)
        {
            for (int i = 0; i < propiedades.Count; i++)
            {
                Propiedad prop = propiedades[i];
                string _ref = prop._ref.ToString();
                string tipo = prop.tipo();
                double precio = prop.Precio;
                int plazas = prop.Plazas;
                string local = prop.Localidad;
                string nombre = prop.Nombre;
                string direc = prop.Direccion;
                DataGridViewRow newEntry = new DataGridViewRow();
                dgv.Rows.Add(_ref, tipo, precio, plazas, local, nombre, direc);
            }
        }
    }
}

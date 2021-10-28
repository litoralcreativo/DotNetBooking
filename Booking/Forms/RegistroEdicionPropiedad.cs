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
        public Empresa empresa;
        public Propiedad propiedad;

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
            nudCategoriaHotel.Enabled = rbHotel.Checked;
            nudDiasMinimos.Enabled = rbCPD.Checked;
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

        public List<Servicio> servicios = new List<Servicio>();

        private void RegistroEdicionPropiedad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ckbAC.Checked) servicios.Add(Servicio.Ac);
            if (ckbCochera.Checked) servicios.Add(Servicio.Cochera);
            if (ckbDesayuno.Checked) servicios.Add(Servicio.Desayuno);
            if (ckbMascotas.Checked) servicios.Add(Servicio.Mascotas);
            if (ckbPiscina.Checked) servicios.Add(Servicio.Piscina);
            if (ckbWifi.Checked) servicios.Add(Servicio.Wifi);
        }

        private void btBuscarImg_Click(object sender, EventArgs e)
        {
            oFDImg.Title = "Buscar imagen";
            oFDImg.Filter = " Imagenes (*.JPG; *.BMP) | *.jpg;*.bmp";
            if (oFDImg.ShowDialog() == DialogResult.OK)
            {
                if (pbPrimera.ImageLocation == null)
                pbPrimera.ImageLocation = oFDImg.FileName;
                else if (pbSegunda.ImageLocation == null)
                pbSegunda.ImageLocation = oFDImg.FileName;
            }
            checkImages();
        }

        private void btnRemoveFirst_Click(object sender, EventArgs e)
        {
            pbPrimera.ImageLocation = null;
            checkImages();
        }

        private void btnRemoveSecond_Click(object sender, EventArgs e)
        {
            pbSegunda.ImageLocation = null;
            checkImages();
        }

        private void RegistroEdicionPropiedad_Load(object sender, EventArgs e)
        {
            checkImages();
        }

        private void checkImages()
        {
            if (pbPrimera.ImageLocation == null || pbSegunda.ImageLocation == null)
                btnBuscarImg.Enabled = true;
            else
                btnBuscarImg.Enabled = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPropietario.SelectedIndex == -1) throw new Exception("Debe seleccionar un propietario");
                if (tbNombre.Text == "") throw new Exception("Debe indicar el nombre de la propiedad");
                if (cbLocalidad.SelectedIndex == -1) throw new Exception("Debe seleccionar una localidad");
                if (tbDireccion.Text == "") throw new Exception("Debe indicar la direccion de la propiedad");
                if (pbPrimera.ImageLocation == null || pbSegunda.ImageLocation == null) throw new Exception("Debe seleccionar dos imagenes");

                string message = "Desea guardar esta propiedad?";
                if (MessageBox.Show(message, "Confirmacion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea eliminar esta propiedad?", "Propiedades", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                bool sePudo = empresa.BorrarPropiedad(propiedad);
                if (sePudo)
                {
                    MessageBox.Show("Se a borrado la propiedad", "Propiedades");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo borrar la propiedad, existen reservas asociadas", "Propiedades");
                }
            }

        }
    }
}



using ProyectoFinal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmTours : Form
    {
        private AppAgenciaTContext _context;
        

        public FrmTours()
        {
            InitializeComponent();
            _context = new AppAgenciaTContext();
            CargarTours();
            dgv_Tour.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void CargarTours()
        {
            var listaTours = _context.Tours
                .Select(t => new
                {
                    t.TourID,
                    t.NombreTour,
                    t.PaisID,
                    t.DestinoID,
                    t.Fecha,
                    t.Hora,
                    t.Precio,
                    t.Itbis,
                    t.Duracion,
                    t.fechaYHoraFin,
                    t.Estado

                })
                .ToList();

            var n = listaTours.FirstOrDefault();
            dgv_Tour.DataSource = listaTours;
        }
        private void btnAgregarDestino_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreTour.Text))
            {
                MessageBox.Show("Nombre del Tour Vacio.Ingresa un nombre valido para el Tour.");
            }

            if (int.TryParse(txtNombreTour.Text, out int nombreTour))
            {
                MessageBox.Show("Nombre del Tour incorrecto.Ingresa un nombre valido para el Tour.");
                txtNombreTour.Clear();
                return;
            }

            if (!decimal.TryParse(txtPrecioTour.Text, out decimal precioTour))
            {
                MessageBox.Show("Precio del Tour incorrecto. Ingresa un precio valido para el Tour.");
                txtPrecioTour.Clear();
                return;
            }

            if (dtpFechaTour.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Fecha invalida.Debes de agregar una fecha valida.");
                return;
            }

            if (!dtpHoraTour.Checked)
            {
                MessageBox.Show("Debes de agregar la hora de inicio del tour.");
                return;
            }

            if (cmbDestinoTour.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un destino");
                return;
            }

            var destino = (Destino)cmbDestinoTour.SelectedItem;

            var destinoTour = _context.Destinos
                .FirstOrDefault(d => d.DestinoID == destino.DestinoID);

            if (destinoTour == null)
            {
                MessageBox.Show("Destino no encontrado en la BD");
                return;
            }

            int diasDuracion = destinoTour.DuracionDias;
            int horasDuracion = destinoTour.DuracionHora;
            string duracion = $"{diasDuracion} días y {horasDuracion} horas";


            string estadoVigente = "No Vigente.";

            if (dtpFechaTour.Value.Date >= DateTime.Today)
            {
                estadoVigente = "Vigente.";
            }
            //aqui calculo la fechaYHoraFin
            DateTime fechahoraInicio = dtpFechaTour.Value.Date + dtpHoraTour.Value.TimeOfDay;
            DateTime fechaHoraFin = fechahoraInicio.AddHours(horasDuracion);
            int duracionTotalHoras = (diasDuracion *24) + horasDuracion;
            fechaHoraFin = fechahoraInicio.AddHours(duracionTotalHoras);

            Tour nuevoTour = new Tour
            {
                NombreTour = txtNombreTour.Text,
                PaisID = Convert.ToInt32 (cmbPaisTour.SelectedValue),
                DestinoID = Convert.ToInt32(cmbDestinoTour.SelectedValue),
                Fecha = dtpFechaTour.Value.Date,
                Hora = dtpHoraTour.Value.TimeOfDay,
                Precio = precioTour,
                Itbis = precioTour * 18 /100, 
                Duracion = duracion,
                fechaYHoraFin = fechaHoraFin,
                Estado = estadoVigente
            };

             _context.Tours.Add(nuevoTour);
            var resultado = _context.SaveChanges();
            if (resultado > 0)
            {
                MessageBox.Show("Tour agregado correctamente.");
                CargarTours();

            }

        }
        private void FrmTours_Load(object sender, EventArgs e)
        {
            cmbPaisTour.DataSource = _context.Pais.ToList();
            cmbPaisTour.DisplayMember = "NombrePais";
            cmbPaisTour.ValueMember = "PaisId";
        }
        private void cmbPaisTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaisTour.SelectedItem == null)
                return;

            var pais = (Pais)cmbPaisTour.SelectedItem;
            int paisId = pais.PaisId;

            var destinos = _context.Destinos
                .Where(d => d.PaisId == paisId)
                .ToList();

            cmbDestinoTour.DataSource = destinos;
            cmbDestinoTour.DisplayMember = "NombreDestino";
            cmbDestinoTour.ValueMember = "DestinoId";

        }

        
    }
}
        
           

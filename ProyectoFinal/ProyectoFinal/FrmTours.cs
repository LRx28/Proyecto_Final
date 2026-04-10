using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
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
                return;
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
                MessageBox.Show("Debes seleccionar un pais para poder ver el destino.");
                return;
            }

            if (Convert.ToInt32(cmbPaisTour.SelectedValue) == 0)
            {
                MessageBox.Show("Debes de selecionar un pais valido para el tour.");
                return;
            }

            var destino = (Destino)cmbDestinoTour.SelectedItem;

            var destinoTour = _context.Destinos
                .FirstOrDefault(d => d.DestinoID == destino.DestinoID);

            if (destinoTour == null)
            {
                MessageBox.Show("Destino no encontrado.");
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
            int duracionTotalHoras = (diasDuracion * 24) + horasDuracion;
            fechaHoraFin = fechahoraInicio.AddHours(duracionTotalHoras);

            Tour nuevoTour = new Tour
            {
                NombreTour = txtNombreTour.Text,
                PaisID = Convert.ToInt32(cmbPaisTour.SelectedValue),
                DestinoID = Convert.ToInt32(cmbDestinoTour.SelectedValue),
                Fecha = dtpFechaTour.Value.Date,
                Hora = dtpHoraTour.Value.TimeOfDay,
                Precio = precioTour,
                Itbis = precioTour * 18 / 100,
                Duracion = duracion,
                fechaYHoraFin = fechaHoraFin,
                Estado = estadoVigente
            };

            _context.Tours.Add(nuevoTour);
            var resultado = _context.SaveChanges();
            if (resultado > 0)
            {
                MessageBox.Show("Tour agregado correctamente.");
                txtNombreTour.Clear();
                txtPrecioTour.Clear();
                cmbPaisTour.SelectedIndex = 0;
                CargarTours();

            }

        }
        private void FrmTours_Load(object sender, EventArgs e)
        {
            var listaPaises = _context.Pais.ToList();
            listaPaises.Insert(0, new Pais
            {
                PaisId = 0,
                NombrePais = "     -- Seleccione un país --"
            });


            cmbPaisTour.DataSource = listaPaises;
            cmbPaisTour.DisplayMember = "NombrePais";
            cmbPaisTour.ValueMember = "PaisId";

            cmbPaisActualizarTour.DataSource = listaPaises;
            cmbPaisActualizarTour.DisplayMember = "NombrePais";
            cmbPaisActualizarTour.ValueMember = "PaisId";
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

        private void btnEliminarTour_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTourEliminar.Text, out int eliminarTour))
            {
                MessageBox.Show("ID del Tour incorrecto. Ingresa un ID valido para eliminar.");
                txtTourEliminar.Clear();
                return;
            }

            var tourEliminado = _context.Tours.Find(eliminarTour);
            if (tourEliminado == null)
            {
                MessageBox.Show("Tour no encontrado. Ingresa un ID valido para eliminar.");
                txtTourEliminar.Clear();
                return;
            }

            _context.Tours.Remove(tourEliminado);
            var resultado = _context.SaveChanges();
            if (resultado > 0)
            {
                MessageBox.Show("Tour eliminado correctamente.");
                txtTourEliminar.Clear();
                CargarTours();
            }
        }

        private void btnActualizarTour_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtActualizarIdTour.Text, out int IdactualizarTour))
            {
                MessageBox.Show("ID del Tour incorrecto. Ingresa un ID valido para actualizar.");
                txtActualizarIdTour.Clear();
                return;
            }

            if (string.IsNullOrEmpty(txtNombreActualizarTour.Text))
            {
                MessageBox.Show("Nombre del Tour Vacio.Ingresa un nombre valido para el Tour.");
                txtNombreActualizarTour.Clear();
                return;
            }

            if (int.TryParse(txtNombreActualizarTour.Text, out int nombreTour))
            {
                MessageBox.Show("Nombre del Tour incorrecto.Ingresa un nombre valido para el Tour.");
                txtNombreActualizarTour.Clear();
                return;
            }

            if (!decimal.TryParse(txtPrecioActualizar.Text, out decimal precioTour))
            {
                MessageBox.Show("Precio del Tour incorrecto. Ingresa un precio valido para el Tour.");
                txtPrecioActualizar.Clear();
                return;
            }

            if (dtp_FechaActualizar.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Fecha invalida.Debes de agregar una fecha valida.");
                return;
            }

            if (!dtp_HoraActualizar.Checked)
            {
                MessageBox.Show("Debes de agregar la hora de inicio del tour.");
                return;
            }

            if (Convert.ToInt32(cmbPaisActualizarTour.SelectedValue) == 0)
            {
                MessageBox.Show("Debes de selecionar un pais valido para el tour.");
                return;
            }

            var tourActualizar = _context.Tours.Find(IdactualizarTour);
            if (tourActualizar == null)
            {
                MessageBox.Show("Tour no encontrado. Ingresa un ID valido para actualizar.");
                txtActualizarIdTour.Clear();
                return;
            }

            tourActualizar.NombreTour = txtNombreActualizarTour.Text;
            tourActualizar.PaisID = Convert.ToInt32(cmbPaisActualizarTour.SelectedValue);
            tourActualizar.DestinoID = Convert.ToInt32(cmbActualizarDestinoTour.SelectedValue);
            tourActualizar.Fecha = dtp_FechaActualizar.Value.Date;
            tourActualizar.Hora = dtp_HoraActualizar.Value.TimeOfDay;
            tourActualizar.Precio = precioTour;
            tourActualizar.Itbis = precioTour * 18 / 100;

            var resultado = _context.SaveChanges();
            if (resultado > 0)
            {
                MessageBox.Show("Tour actualizado correctamente.");
                txtActualizarIdTour.Clear();
                txtNombreActualizarTour.Clear();
                txtPrecioActualizar.Clear();
                cmbPaisActualizarTour.SelectedIndex = 0;
                CargarTours();
            }



        }

        private void cmbActualizarDestinoTour_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cmbPaisActualizarTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaisActualizarTour.SelectedItem == null)
                return;

            var pais = (Pais)cmbPaisActualizarTour.SelectedItem;
            int paisId = pais.PaisId;

            var destinos = _context.Destinos
                .Where(d => d.PaisId == paisId)
                .ToList();

            cmbActualizarDestinoTour.DataSource = destinos;
            cmbActualizarDestinoTour.DisplayMember = "NombreDestino";
            cmbActualizarDestinoTour.ValueMember = "DestinoId";
        }

        private void btn_CsvTour_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo CSV (*.csv)|*.csv",
                Title = "Guardar Tours en CSV",
                FileName = "CSV_Tours.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine("TourID,NombreTour,PaisID,DestinoID,Fecha,Hora,Precio,Itbis,Duracion,fechaYHoraFin,Estado");
                        foreach (var Tour in _context.Tours)
                        {
                            string linea = $"{Tour.TourID},{Tour.NombreTour},{Tour.PaisID},{Tour.DestinoID},{Tour.Fecha:yyyy-MM-dd},{Tour.Hora:hh\\:mm\\:ss},{Tour.Precio},{Tour.Itbis},{Tour.Duracion},{Tour.fechaYHoraFin:yyyy-MM-dd HH:mm:ss},{Tour.Estado}";
                            writer.WriteLine(linea);

                        }
                    }
                    MessageBox.Show("Archivo CSV guardado exitosamente.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo CSV: {ex.Message}");

                }

            }

        }
        private void btn_PdfTour_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo PDF (*.pdf)|*.pdf",
                Title = "Guardar Tours en PDF",
                FileName = "PDF_Tours.pdf"
            };

            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (PdfWriter writer = new PdfWriter(saveFileDialog.FileName))
                    using (PdfDocument pdf = new PdfDocument(writer))
                    using (Document doc = new Document(pdf, iText.Kernel.Geom.PageSize.A4.Rotate()))
                    {
                        Table table = new Table(11);

                        table.AddCell("TourID");
                        table.AddCell("NombreTour");
                        table.AddCell("PaisID");
                        table.AddCell("DestinoID");
                        table.AddCell("Fecha");
                        table.AddCell("Hora");
                        table.AddCell("Precio");
                        table.AddCell("Itbis");
                        table.AddCell("Duracion");
                        table.AddCell("fechaYHoraFin");
                        table.AddCell("Estado");

                        var tours = _context.Tours.ToList();
                        if (tours.Count == 0)
                        {
                            MessageBox.Show("No hay tours disponibles para exportar.");
                            return;
                        }

                        foreach (var tour in tours)
                        {
                            table.AddCell(tour.TourID.ToString());
                            table.AddCell(tour.NombreTour??"");
                            table.AddCell(tour.PaisID.ToString());
                            table.AddCell(tour.DestinoID.ToString());
                            table.AddCell(tour.Fecha.ToString());
                            table.AddCell(tour.Hora.ToString());
                            table.AddCell(tour.Precio.ToString());
                            table.AddCell(tour.Itbis.ToString());
                            table.AddCell(tour.Duracion);
                            table.AddCell(tour.fechaYHoraFin.ToString());
                            table.AddCell(tour.Estado);
                        }

                        doc.Add(table);
                    }

                    MessageBox.Show("PDF creado coreectamente.");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al crear el PDF: {ex.Message}");
            }
            

            


        }
    }
}
        
           

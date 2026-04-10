using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
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
    public partial class FrmDestinos : Form
    {
        private AppAgenciaTContext _context;
        public FrmDestinos()
        {
            InitializeComponent();
            _context = new AppAgenciaTContext();
            CargarDestinos();

            //Esto lo hice para que se vea mejor el datagridview ya que al cargar los datos se veían muy pequeños y no se ajustaban al tamaño del datagridview
            dgv_Destinos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarDestinos()
        {
            var listaDestinos = _context.Destinos
                
                .Select(d => new                {
                    d.DestinoID,
                    d.NombreDestino,
                    d.PaisId,
                    d.DuracionDias,
                    d.DuracionHora
                })
                .ToList();
            var n = listaDestinos.FirstOrDefault();
            dgv_Destinos.DataSource = listaDestinos;
        }
        private void btnAgregarDestino_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDestinoNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del destino.");
                return;
            }
            // Aqui valido que el nombre del destino no sea un numero
            if (int.TryParse(txtDestinoNombre.Text, out int destino))
            {
                MessageBox.Show("El nombre del destino no puede ser un número. ingrese un nombre válido.");
                txtDestinoNombre.Clear();
                return;
            }
           
            int destinoHoras = 0;

            //Aqui valido el campo de duracion en Horas no este vacio y que sea un numero valido.
            if (!int.TryParse(txtDuracionHora.Text, out destinoHoras))
            {
                MessageBox.Show("Duracion en horas invalida. Debes de ingresar un numero valido.");
                txtDuracionHora.Clear();
                return;
            }
 
            if (Convert.ToInt32(cmbDestinosP.SelectedValue) == 0)
            {
                MessageBox.Show("Debes de seleccionar un pais valido.");
                return;
            }

            Destino nuevoDestino = new Destino
            {
                NombreDestino = txtDestinoNombre.Text,
                DuracionDias = destinoHoras /24,
                DuracionHora = destinoHoras,
                PaisId = Convert.ToInt32(cmbDestinosP.SelectedValue)
            };

            _context.Destinos.Add(nuevoDestino);
            var resultado = _context.SaveChanges();

            if (resultado > 0)
            {
                MessageBox.Show("Destino agregado correctamente!");
                CargarDestinos();
                txtActualizarDestinoId.Clear();
                txtDestinoNombre.Clear();
                txtDuracionHora.Clear();
                cmbDestinosP.SelectedIndex = 0;
            }

            else
            {
                MessageBox.Show("Error al agregar el destino. Por favor, intente nuevamente.");
            }
        }

        private void FrmDestinos_Load(object sender, EventArgs e)
        {
            // Esto es para agregar una opción por defecto que indique al usuario que debe seleccionar un país
            var listaPaises = _context.Pais.ToList();
            listaPaises.Insert(0, new Pais
            {
                PaisId = 0,
                NombrePais = "      -- Seleccione un país --"
            });

            cmbDestinosP.DataSource = listaPaises;
            cmbDestinosP.DisplayMember = "NombrePais";
            cmbDestinosP.ValueMember = "paisID";

            cmbActualizarDestino.DataSource = listaPaises;
            cmbActualizarDestino.DisplayMember = "NombrePais";
            cmbActualizarDestino.ValueMember = "paisID";

        }

        private void btnDestinoE_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDestinoE.Text, out int destinoEliminar))
            {
                MessageBox.Show("ID del destino no válido. Por favor ingrese un ID valido.");
                txtDestinoE.Clear();
                return;
            }

            var destino = _context.Destinos.Find(destinoEliminar);
            if (destino == null)
            {
                MessageBox.Show("Destino no encontrado. Por favor ingrese un ID válido.");
                txtDestinoE.Clear();
                return;
            }

            _context.Destinos.Remove(destino);
            var resultado = _context.SaveChanges();

            if (resultado > 0)
            {
                MessageBox.Show("Destino eliminado correctamente!");
                CargarDestinos();
                txtDestinoE.Clear();
            }
            else
            {
                MessageBox.Show("Error al eliminar el destino. Por favor intente nuevamente.");
            }
        }

        private void btnActualizarDestino_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtActualizarDestinoId.Text, out int destinoActualizarId))
            {
                MessageBox.Show("ID invalido. Por favor introduce un ID valido.");
                txtActualizarDestinoId.Clear();
                return;
            }

            if (!string.IsNullOrEmpty(txtNombreActualizarD.Text))
            {
                if (int.TryParse(txtNombreActualizarD.Text, out int destinoActualizarN))
                {
                    MessageBox.Show("Nombre del destino invalido. Debe de ingresar un Nombre valido para el destino.");
                    txtNombreActualizarD.Clear();
                    return;
                }
            }

          
            var destinoDuracionHora = 0;

            if (!int.TryParse(txtActualizarDuracionH.Text, out destinoDuracionHora))
            {
                MessageBox.Show("Duracion en horas invalida. Debes de ingresar un numero valido.");
                txtActualizarDuracionH.Clear();
                return;
            }
            
            if (Convert.ToInt32(cmbActualizarDestino.SelectedValue) == 0)
            {
                MessageBox.Show("Debes de seleccionar un pais valido.");
                return;
            }

            var destinoActualizar = _context.Destinos.Find(destinoActualizarId);
            if (destinoActualizar == null)
            {
                MessageBox.Show("No se ha encontrado un destino con ese ID. Ingresa un ID valido");
                txtActualizarDestinoId.Clear();
                return;
            }

            destinoActualizar.NombreDestino = txtNombreActualizarD.Text;
            destinoActualizar.DuracionDias = destinoDuracionHora /24;
            destinoActualizar.DuracionHora = destinoDuracionHora;
            destinoActualizar.PaisId = Convert.ToInt32(cmbActualizarDestino.SelectedValue);

            var resultado = _context.SaveChanges();
            if (resultado > 0)
            {
                MessageBox.Show("Destino actualizado correctamente!");
                CargarDestinos();
                txtActualizarDestinoId.Clear();
                txtNombreActualizarD.Clear();
                txtActualizarDuracionH.Clear();
                cmbActualizarDestino.SelectedIndex = 0;
            }

            else
            {
                MessageBox.Show("Error al actualizar el destino. Por favor intente nuevamente.");
            }
        }

        private void btn_CsvDestino_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo CSV (*.csv)|*.csv",
                Title = "Guardar como CSV",
                FileName = "CSV_Destinos.csv"


            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {

                        writer.WriteLine("DestinoID,NombreDestino,PaisId,DuracionDias,DuracionHora");
                        foreach (var destinos in _context.Destinos)
                        {
                            writer.WriteLine($"{destinos.DestinoID},{destinos.NombreDestino},{destinos.PaisId},{destinos.DuracionDias},{destinos.DuracionDias}");
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

        private void btn_PdfDestino_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Archivo PDF (*.pdf)|*.pdf",
                Title = "Guardar como PDF",
                FileName = "PDF_Destinos.pdf"
            };

            try
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (PdfWriter writer = new PdfWriter(sfd.FileName))
                    using (PdfDocument pdf = new PdfDocument(writer))
                    using (Document doc = new Document(pdf))
                    {
                        Table table = new Table(2);

                        table.AddCell("DestinoID");
                        table.AddCell("NombreDestino");
                        table.AddCell("PaisId");
                        table.AddCell("DuracionDias");
                        table.AddCell("DuracionHora");

                        var destinosD = _context.Destinos.ToList();
                        if (destinosD.Count == 0)
                        {
                            MessageBox.Show("No se encontraron países para exportar.");
                            return;
                        }

                        foreach (var destinos in destinosD)
                        {
                            table.AddCell(destinos.DestinoID.ToString());
                            table.AddCell(destinos.NombreDestino ?? "");
                            table.AddCell(destinos.PaisId.ToString());
                            table.AddCell(destinos.DuracionDias.ToString());
                            table.AddCell(destinos.DuracionHora.ToString());
                        }

                        doc.Add(table);
                    }

                       
                    MessageBox.Show("PDF creado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el PDF: {ex.Message}");
            }
        }
    }
}

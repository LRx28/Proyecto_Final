using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using ProyectoFinal.Model;

namespace ProyectoFinal
{
    public partial class FrmPais : Form
    {
        private AppAgenciaTContext _context;


        public FrmPais()
        {
            InitializeComponent();
            _context = new AppAgenciaTContext();
            CargarPaises();

            //Esto lo hice para que se vea mejor el datagridview ya que al cargar los datos se veían muy pequeños y no se ajustaban al tamaño del datagridview
            dgv_Pais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void CargarPaises()
        {
            var listaPaises = _context.Pais
                .Select(p => new
                {
                    p.PaisId,
                    p.NombrePais
                })
                .ToList();
            var n = listaPaises.FirstOrDefault();
            dgv_Pais.DataSource = listaPaises;
        }



        private void btnAgregarPais_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Pais.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del país.");
                return;
            }
            // Aqui valido que el nombre del país no sea un numero
            if (int.TryParse(txt_Pais.Text, out int pais))
            {
                MessageBox.Show("El nombre del país no puede ser un número. ingrese un nombre válido.");
                txt_Pais.Clear();
                return;

            }

            Pais nuevoPais = new Pais
            {
                NombrePais = txt_Pais.Text
            };

            _context.Pais.Add(nuevoPais);
            var resultado = _context.SaveChanges();
            if (resultado > 0)
            {
                MessageBox.Show("País agregado exitosamente.");
                CargarPaises();
                txt_Pais.Clear();
            }
            else
            {
                MessageBox.Show("Error al agregar el país. Intente nuevamente.");

            }
        }

        private void btnEliminarPais_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEliminarPais.Text, out int pais))
            {
                MessageBox.Show("ID incorrecto o vacio.");
                txtEliminarPais.Clear();
                return;
            }

            var paisAEliminar = _context.Pais.Find(pais);
            if (paisAEliminar == null)
            {
                MessageBox.Show("No se encontró el país con el ID proporcionado.");
                txtEliminarPais.Clear();
                return;
            }

            _context.Pais.Remove(paisAEliminar);
            var resultado = _context.SaveChanges();
            if (resultado > 0)
            {
                MessageBox.Show("País eliminado exitosamente.");
                CargarPaises();
                txtEliminarPais.Clear();
            }
            else
            {
                MessageBox.Show("Error al eliminar el país. Intente nuevamente.");
            }



        }

        private void btnActualizarP_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtActualizarIDP.Text, out int paisActualizar))
            {
                MessageBox.Show("ID incorrecto o vacio");
                txtActualizarIDP.Clear();
                return;
            }

            if (string.IsNullOrEmpty(txtNombreActualizarP.Text))
            {
                MessageBox.Show("Por favor, ingrese el nuevo nombre del país.");
                return;
            }

            if (int.TryParse(txtNombreActualizarP.Text, out int nombrePais))
            {
                MessageBox.Show("El nombre del país no puede ser un número. ingrese un nombre válido.");
                txtNombreActualizarP.Clear();
                return;
            }

            var paisAActualizar = _context.Pais.Find(paisActualizar);
            if (paisAActualizar == null)
            {
                MessageBox.Show("No se encontro el país con el ID ingresado.");
                txtActualizarIDP.Clear();
                return;
            }

            paisAActualizar.NombrePais = txtNombreActualizarP.Text;

            var resultado = _context.SaveChanges();
            if (resultado > 0)
            {
                MessageBox.Show("País actualizado exitosamente.");
                CargarPaises();
                txtActualizarIDP.Clear();
                txtNombreActualizarP.Clear();
            }
            else
            {
                MessageBox.Show("Error al actualizar el país. Intente nuevamente.");
            }
        }

        private void btn_Csv_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo CSV (*.csv)|*.csv",
                Title = "Guardar como CSV",
                FileName = "Reporte_Pais.csv"

            };

            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        //Aqui escribe los encabezados
                        writer.WriteLine("PaisId,NombrePais");
                        // Aqui escribe los datos de cada país
                        foreach (var pais in _context.Pais)
                        {
                            writer.WriteLine($"{pais.PaisId},{pais.NombrePais}");
                        }
                    }
                    MessageBox.Show("Archivo CSV guardado exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo CSV: {ex.Message}");
            }

        }

        private void btn_Pdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Archivo PDF (*.pdf)|*.pdf",
                Title = "Guardar como PDF",
                FileName = "PDF_Pais.pdf"
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

                        table.AddCell("PaisId");
                        table.AddCell("NombrePais");

                        var paises = _context.Pais.ToList();
                        if (paises.Count == 0)
                        {
                            MessageBox.Show("No se encontraron países para exportar.");
                            return;
                        }

                        foreach (var pais in paises)
                        {
                            table.AddCell(pais.PaisId.ToString());
                            table.AddCell(pais.NombrePais ?? "");
                        }

                        doc.Add(table);
                    }

                    MessageBox.Show("PDF creado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el PDF: {ex.Message}");
            }
        }

        private void FrmPais_Load(object sender, EventArgs e)
        {
             
        }
    }
}
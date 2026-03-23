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
    }
}

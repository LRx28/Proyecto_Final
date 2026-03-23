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

        }
    }
}

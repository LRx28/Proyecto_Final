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
                .Select(d => new
                {
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

            if (!int.TryParse(txtDestinoDuracionD.Text, out int destinoDias) || destinoDias < 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido para la duración en días.");
                txtDestinoDuracionD.Clear();
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
                DuracionDias = destinoDias,
                DuracionHora = destinoDias * 24,
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
                txtDestinoDuracionD.Clear();

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
                txtActualizarDestinoId.Clear();
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

            if (string.IsNullOrEmpty(txtNombreActualizarD.Text))
            {
                MessageBox.Show("El campo destino no puede estar vacio. Ingresa un destino valido.");
                txtNombreActualizarD.Clear();
                return;
            }

            if (int.TryParse(txtNombreActualizarD.Text, out int destinoActualizarN))
            {
                MessageBox.Show("El destino ingresado no puede ser un numero . Por favor introduzca un destino valido.");
                txtNombreActualizarD.Clear();
                return;
            }

            if (!int.TryParse(txtActualizarDuracionD.Text, out int destinoDuracionDia))
            {
                MessageBox.Show("Duracion en dias invalida. Debes de agregar un numero valido.");
                txtActualizarDuracionD.Clear();
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
            destinoActualizar.DuracionDias = destinoDuracionDia;
            destinoActualizar.DuracionHora = destinoDuracionDia * 24;
            destinoActualizar.PaisId = Convert.ToInt32(cmbActualizarDestino.SelectedValue);

            var resultado = _context.SaveChanges();
            if (resultado > 0)
            {
                MessageBox.Show("Destino actualizado correctamente!");
                CargarDestinos();
                txtActualizarDestinoId.Clear();
                txtNombreActualizarD.Clear();
                txtActualizarDuracionD.Clear();
            }

            else
            {
                MessageBox.Show("Error al actualizar el destino. Por favor intente nuevamente.");
            }
        }
    }
}

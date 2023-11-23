using Archivos;
using proyecto_veterinaria;

namespace GuardiaVeterinaria
{

    public partial class GuardiaVeterinaria : Form
    {
        CancellationTokenSource cancellationTokenSource;
        CancellationToken cancellationToken;
        public Veterinaria veterinaria;
        public Mascota mascota;
        public Medico medico;
        public List<Mascota> todasLasMascotas;
        public List<Medico> todosLosMedicos;


        public GuardiaVeterinaria()
        {
            InitializeComponent();
            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;
            veterinaria = new Veterinaria(5);
            todasLasMascotas = new List<Mascota>();
            todasLasMascotas = GestorSql.GetMascotas();
            todosLosMedicos = new List<Medico>();
            todosLosMedicos = GestorSql.GetMedicos();
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            FrmNuevaMascota frmNuevaMascota = new FrmNuevaMascota(this);
            frmNuevaMascota.ShowDialog();

            this.Refrescar();

        }

        private void Refrescar()
        {
            this.lstSalaDeEspera.DataSource = null;
            this.lstSalaDeEspera.DataSource = veterinaria.Mascotas;
            this.lstEnAtencionMedica.DataSource = veterinaria.MascotasAtendiendose;
            this.lstAtendidos.DataSource = veterinaria.MascotasAtendidas;
            todasLasMascotas = GestorSql.GetMascotas();
            todosLosMedicos = GestorSql.GetMedicos();
        }

        private void GuardiaVeterinaria_Load(object sender, EventArgs e)
        {
            this.Refrescar();
        }

        private void btnBuscarMascota_Click(object sender, EventArgs e)
        {
            lstPacienteEncontrado.Items.Clear();
            mascota = null;

            if (txtDniTutor.Text.Length > 0)
            {
                int dni = int.Parse(txtDniTutor.Text);

                foreach (Mascota item in todasLasMascotas)
                {
                    if (item.Dni_tutor == dni)
                    {
                        mascota = item;
                        MessageBox.Show("Se encontró el dato buscado.", "Dato Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lstPacienteEncontrado.Items.Add(mascota);

                        break;
                    }
                }
            }
        }

        private void btnIngresarPaciente_Click(object sender, EventArgs e)
        {
            if (lstPacienteEncontrado.Items.Count > 0 && veterinaria != mascota)
            {
                veterinaria += mascota;
                this.Refrescar();


                //arranca el hilo
                veterinaria.Atender += veterinaria.PacienteAtendido;


                Task.Run(() =>{ 
                    veterinaria.AtenderPaciente(mascota);
                    this.Refrescar();
                });
                

            }
        }

        private void btnCerrarVeterinaria_Click(object sender, EventArgs e)
        {
            Veterinaria.Guardar(veterinaria);
        }

        private void btnIngresarPacientesXml_Click(object sender, EventArgs e)
        {
            Xml<List<Mascota>> xml = new Xml<List<Mascota>>();

            xml.Leer("Mascota", out List<Mascota> cargaMascotas);
            foreach (Mascota item in cargaMascotas)
            {
                veterinaria += item;
                this.Refrescar();
            }

        }

        private void btnNuevoMedico_Click(object sender, EventArgs e)
        {
            FrmNuevoMedico frmNuevoMedico = new FrmNuevoMedico(this);
            frmNuevoMedico.ShowDialog();
            this.Refrescar();
        }

        private void btnIngresarMedico_Click(object sender, EventArgs e)
        {
            medico = null;

            if (txtDniMedico.Text.Length > 0)
            {
                int dni = int.Parse(txtDniMedico.Text);

                foreach (Medico item in todosLosMedicos)
                {
                    if (item.Dni == dni)
                    {
                        medico = item;

                        if (veterinaria != medico)
                        {
                            veterinaria += medico;
                            this.Refrescar();
                            MessageBox.Show("Medico ingresado al turno correctamente", "Dato Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                }
            }
        }
    }
}
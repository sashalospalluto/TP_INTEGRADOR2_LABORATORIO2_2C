using Archivos;
using proyecto_veterinaria;

namespace GuardiaVeterinaria
{
    public delegate void InformarEstadoEventHandler();
    public partial class GuardiaVeterinaria : Form
    {
        CancellationTokenSource cancellationTokenSource;
        CancellationToken cancellationToken;
        public Veterinaria veterinaria;
        public Mascota mascota;
        public Medico medico;
        public List<Mascota> todasLasMascotas;
        public List<Medico> todosLosMedicos;
        public InformarEstadoEventHandler informarEstado;



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
            veterinaria.InformarModificacion += RefrescarForm;
            veterinaria.Atender += veterinaria.PacienteAtendido;
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            FrmNuevaMascota frmNuevaMascota = new FrmNuevaMascota(this);
            frmNuevaMascota.ShowDialog();

            this.Refrescar();

        }

        private void RefrescarForm(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Veterinaria.ActualizarPacientesEventHandler v = new Veterinaria.ActualizarPacientesEventHandler(RefrescarForm);
                this.Invoke(v, new object[] { sender, e });
            }
            else
            {
                Refrescar();
            }
        }

        private void Refrescar()
        {
            this.lstSalaDeEspera.DataSource = null;
            this.lstSalaDeEspera.DataSource = veterinaria.Mascotas;
            this.lstEnAtencionMedica.DataSource = null;
            this.lstEnAtencionMedica.DataSource = veterinaria.MascotasAtendiendose;
            this.lstAtendidos.DataSource = null;
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
            bool encontrado = false;

            if (txtDniTutor.Text.Length > 0 && txtDniTutor.Text.Length < 9)
            {
                int dni = int.Parse(txtDniTutor.Text);

                foreach (Mascota item in todasLasMascotas)
                {
                    if (item.Dni_tutor == dni)
                    {
                        mascota = item;
                        MessageBox.Show("Se encontró el dato buscado.", "Dato Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lstPacienteEncontrado.Items.Add(mascota);
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show("No se encontró el paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un dni valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIngresarPaciente_Click(object sender, EventArgs e)
        {
            if (lstPacienteEncontrado.Items.Count > 0 && veterinaria != mascota)
            {
                veterinaria += mascota;
                this.Refrescar();
                lstPacienteEncontrado.Items.Clear();
                //ComenzarAtencion(mascota);
            }
            else
            {
                MessageBox.Show("Primero debe ingresar un dni valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrarVeterinaria_Click(object sender, EventArgs e)
        {
            Veterinaria.Guardar(veterinaria);
            this.Close();
        }

        private void btnIngresarPacientesXml_Click(object sender, EventArgs e)
        {
            Xml<List<Mascota>> xml = new Xml<List<Mascota>>();

            xml.Leer("Mascota", out List<Mascota> cargaMascotas);
            foreach (Mascota item in cargaMascotas)
            {
                veterinaria += item;
                //this.Refrescar();
                //ComenzarAtencion(item);
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
            bool encontrado = false;

            if (txtDniMedico.Text.Length > 0 && txtDniMedico.Text.Length < 9)
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
                            MessageBox.Show("Medico ingresado al turno laboral correctamente", "Dato Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show("No se encontró el medico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un dni valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardiaVeterinaria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la veterinaria?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; //no deja que se cierre 
            }
            else
            {
                this.Visible = false;
            }
        }

        private void txtDniTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.SoloNumeros(sender, e);
        }

        private void txtDniMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.SoloNumeros(sender, e);
        }

        public void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
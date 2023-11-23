using Archivos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_veterinaria
{
    public delegate bool AtenderPacienteEventHandler(Mascota mascota, Medico medico);
    public class Veterinaria
    {
        public delegate void ActualizarPacientesEventHandler(object sender, EventArgs e);
        public event AtenderPacienteEventHandler Atender;
        public event ActualizarPacientesEventHandler InformarModificacion;
        private List<Mascota> mascotas;
        private List<Mascota> mascotasAtendiendose;
        private List<Mascota> mascotasAtendidas;
        private List<Medico> medicos;
        public int cantidadMaxEnGuardia;
        private List<Consulta> consultasGuardadas;



        public Veterinaria()
        {
            this.mascotas = new List<Mascota>();
            this.medicos = new List<Medico>();
            this.mascotasAtendiendose = new List<Mascota>();
            this.mascotasAtendidas = new List<Mascota>();
            this.consultasGuardadas = new List<Consulta>();
        }

        public List<Mascota> Mascotas
        {
            get
            {
                return this.mascotas;
            }
        }

        public List<Mascota> MascotasAtendiendose
        {
            get
            {
                return this.mascotasAtendiendose;
            }
        }

        public List<Mascota> MascotasAtendidas
        {
            get
            {
                return this.mascotasAtendidas;
            }
        }

        public List<Consulta> ConsultasGuardadas
        {
            get
            {
                return this.consultasGuardadas;
            }
        }

        public Veterinaria(int cantidadMaxEnGuardia) : this()
        {
            this.cantidadMaxEnGuardia = cantidadMaxEnGuardia;
        }

        public static Veterinaria operator +(Veterinaria veterinaria, Mascota mascota)
        {
            bool existe = false;
            Medico medico;

            if (veterinaria.mascotas.Count > 0)
            {
                foreach (Mascota item in veterinaria.mascotas)
                {
                    if (item == mascota)
                    {
                        existe = true;

                        break;
                    }
                }
            }

            if (!existe)
            {
                veterinaria.mascotas.Add(mascota);
                //do
                //{
                    medico = veterinaria.AsignarUnMedico(veterinaria.medicos, mascota);
                    Task tarea = Task.Run(() => {
                        veterinaria.AtenderPaciente(mascota,medico);
                    });
                //} while (medico is null);
            }
            return veterinaria;
        }

        public static Veterinaria operator +(Veterinaria veterinaria, Medico medico)
        {
            bool existe = false;

            if (veterinaria.medicos.Count > 0)
            {
                foreach (Medico item in veterinaria.medicos)
                {
                    if (item == medico)
                    {

                        existe = true;
                        break;
                    }
                }
            }

            if (!existe)
            {
                veterinaria.medicos.Add(medico);
            }
            return veterinaria;
        }

        public static Veterinaria operator -(Veterinaria veterinaria, Mascota mascota)
        {
            foreach (Mascota item in veterinaria.mascotas)
            {
                if (item == mascota)
                {
                    veterinaria.mascotas.Add(item);
                    break;
                }
            }
            return veterinaria;
        }

        public Mascota BuscarMascota(int dni)
        {
            Mascota mascota = null;
            foreach (Mascota item in mascotas)
            {
                if (item.Dni_tutor == dni)
                {
                    mascota = item;
                    break;
                }
            }

            return mascota;
        }

        public static bool operator ==(Veterinaria veterinaria, Mascota mascota)
        {
            bool seEncuentra = false;
            if (veterinaria.mascotas.Count > 0)
            {
                Mascota miMascota = veterinaria.mascotas.Find(m => m == mascota);
                if (miMascota is not null)
                {
                    seEncuentra = true;
                }
            }
            return seEncuentra;
        }

        public static bool operator !=(Veterinaria veterinaria, Medico medico)
        {
            return !(veterinaria == medico);
        }

        public static bool operator ==(Veterinaria veterinaria, Medico medico)
        {
            bool seEncuentra = false;
            if (veterinaria.medicos.Count > 0)
            {
                Medico unMedico = veterinaria.medicos.Find(m => m == medico);
                if (unMedico is not null)
                {
                    seEncuentra = true;
                }
            }
            return seEncuentra;
        }

        public static bool operator !=(Veterinaria veterinaria, Mascota mascota)
        {
            return !(veterinaria == mascota);
        }

        public static bool Guardar(Veterinaria veterinaria)
        {
            Xml<Veterinaria> xml = new Xml<Veterinaria>();

            return xml.Guardar("Veterinaria", veterinaria);
        }

        public bool CargarFicha(Mascota mascota)
        {
            bool pacienteAtendido = false;

            if (GestorSql.ModificarIMC(mascota))
            {
                pacienteAtendido = true;
            }

            return pacienteAtendido;
        }

        public bool AtenderPaciente(Mascota mascota, Medico medico)
        {
            bool atendido = false;
            Random random = new Random();

            if (this.CargarFicha(mascota))
            {
                atendido = true;
                Thread.Sleep(random.Next(1000, 6000));
                this.mascotas.Remove(mascota);
                //Thread.Sleep(random.Next(1000, 6000));
                //this.InformarModificacion.Invoke(this, EventArgs.Empty);
                this.mascotasAtendiendose.Add(mascota);
                this.InformarModificacion.Invoke(this, EventArgs.Empty);
                Thread.Sleep(random.Next(6000, 8000));
                //medico = this.AsignarUnMedico(medicos, mascota);
                Atender.Invoke(mascota,medico);
            }

            return atendido;
        }

        public bool PacienteAtendido(Mascota mascota, Medico medico)
        {
            bool atendido = false;

            if (this.Atender is not null)
            {
                if (GestorSql.IngresarPacienteAtendido(mascota, medico))
                {
                    this.mascotasAtendiendose.Remove(mascota);
                    this.mascotasAtendidas.Add(mascota);
                    Consulta consultaEncontrada = this.consultasGuardadas.Find(m=> m.Medico == medico);

                    if (consultaEncontrada != null)
                    {
                        consultaEncontrada.Medico.Atendiendo = false;
                    }
                    this.InformarModificacion.Invoke(this, EventArgs.Empty);
                    
                    atendido = true;
                }
            }

            return atendido;
        }

        public Medico MedicoRandom(List<Medico> medicos)
        {
            Medico unMedico = null;
            bool encontroUno = false;

            while (!encontroUno)
            {
                if (medicos.Count != 0)
                {
                    foreach (Medico medico in medicos)
                    {
                        //if (medico.Atendiendo == false)
                        //{
                            unMedico = medico;
                            encontroUno = true;
                            break;
                        //}
                    }
                }
            }
            return unMedico;
        }

        public Medico AsignarUnMedico(List<Medico> medicos, Mascota mascota)
        {
            Medico unMedico = null;
            bool encontroUno = false;

            if (medicos.Count != 0)
            {
                foreach (Medico medico in medicos)
                {
                    //if (medico.Atendiendo == false)
                    //{
                        unMedico = medico;
                        encontroUno = true;
                        this.consultasGuardadas.Add(new Consulta(mascota, medico));
                        medico.Atendiendo = true;
                        break;
                    //}
                }
            }
            
            return unMedico;
        }
    }
}

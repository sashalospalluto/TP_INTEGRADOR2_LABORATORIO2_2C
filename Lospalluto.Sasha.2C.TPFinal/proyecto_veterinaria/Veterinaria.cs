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
    //17 - Delegados
    public delegate bool AtenderPacienteEventHandler(Mascota mascota, Medico medico);
    public class Veterinaria
    {
        public delegate void ActualizarPacientesEventHandler(object sender, EventArgs e);
        //19 - Eventos
        public event AtenderPacienteEventHandler Atender;
        public event ActualizarPacientesEventHandler InformarModificacion;
        private List<Mascota> mascotas;
        private List<Mascota> mascotasAtendiendose;
        private List<Mascota> mascotasAtendidas;
        private List<Medico> medicos;
        //public int cantidadMaxEnGuardia;
        private List<Consulta> consultasGuardadas;


        /// <summary>
        /// Constructor que inicializa todas las listas de la veterinaria
        /// </summary>
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

        public List<Medico> Medicos
        {
            get
            {
                return this.medicos;
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

        
        //public Veterinaria(int cantidadMaxEnGuardia) : this()
        //{
          //  this.cantidadMaxEnGuardia = cantidadMaxEnGuardia;
        //}

        /// <summary>
        /// operador que agrega una mascota a la veterinaria
        /// </summary>
        /// <param name="veterinaria">veterinaria</param>
        /// <param name="mascota">mascota a agregar a veterinaria</param>
        /// <returns>una veterinaria</returns>
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
                //18 - Programacion multi-hilo  y concurrencia
                Task tarea = Task.Run(() => {
                    veterinaria.AtenderPaciente(mascota,medico);
                });
                //} while (medico is null);
            }
            return veterinaria;
        }

        /// <summary>
        /// Operador que agrega un medico a la lista de medicos de turno en la veterinaria
        /// </summary>
        /// <param name="veterinaria">veterinaria</param>
        /// <param name="medico">medico para agregar a la lista de medicos en la veterinaria</param>
        /// <returns>una veterinaria</returns>
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

        /// <summary>
        /// Metodo que busca una mascota por el dni del tutor
        /// </summary>
        /// <param name="dni">dni del tutor</param>
        /// <returns>una mascota si es que la encontró, caso contrario devuelve null</returns>
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

        /// <summary>
        /// Operador que compara si una mascota se encuentra en lista de espera para ser atendido
        /// </summary>
        /// <param name="veterinaria">veterinaria</param>
        /// <param name="mascota">mascota a buscar</param>
        /// <returns>true si lo encontro, caso contrario retorna false</returns>
        public static bool operator ==(Veterinaria veterinaria, Mascota mascota)
        {
            bool seEncuentra = false;
            if (veterinaria.mascotas.Count > 0)
            {
                //17 - Expresiones lambda
                Mascota miMascota = veterinaria.mascotas.Find(m => m == mascota);
                if (miMascota is not null)
                {
                    seEncuentra = true;
                }
            }
            return seEncuentra;
        }

        /// <summary>
        /// Operador que compara si un medico se encuentra de turno
        /// </summary>
        /// <param name="veterinaria">veterinaria</param>
        /// <param name="medico">medico a buscar</param>
        /// <returns>true si no lo encontro, caso contrario retorna false</returns>
        public static bool operator !=(Veterinaria veterinaria, Medico medico)
        {
            return !(veterinaria == medico);
        }

        public static bool operator ==(Veterinaria veterinaria, Medico medico)
        {
            bool seEncuentra = false;
            if (veterinaria.medicos.Count > 0)
            {
                //Medico unMedico = veterinaria.medicos.Find(m => m == medico);
                foreach (Medico item in veterinaria.medicos)
                {
                    if(item == medico)
                    {
                        seEncuentra = true;
                        break;
                    }
                }
                //if (unMedico is not null)
                //{
                  //  seEncuentra = true;
                //}
            }
            return seEncuentra;
        }

        /// <summary>
        /// Operador que compara si una mascota no se encuentra en lista de espera para ser atendido
        /// </summary>
        /// <param name="veterinaria">veterinaria</param>
        /// <param name="mascota">mascota a buscar</param>
        /// <returns>true si no lo encontro, caso contrario retorna false</returns>
        public static bool operator !=(Veterinaria veterinaria, Mascota mascota)
        {
            return !(veterinaria == mascota);
        }

        /// <summary>
        /// Metodo que guarda la veterinaria en un archivo XML
        /// </summary>
        /// <param name="veterinaria">veterinaria a guardar</param>
        /// <returns>true si pudo guardar, caso contrario devuelve null</returns>
        public static bool Guardar(Veterinaria veterinaria)
        {
            Xml<Veterinaria> xml = new Xml<Veterinaria>();

            return xml.Guardar("Veterinaria", veterinaria);
        }

        /// <summary>
        /// Metodo que agrega el imc a la mascota pasada por parametro
        /// </summary>
        /// <param name="mascota">mascota a la que se le va a agregar el imc</param>
        /// <returns>true si pudo modificar la mascota en la BD, caso contrario retorna false</returns>
        public bool CargarFicha(Mascota mascota)
        {
            bool pacienteAtendido = false;

            if (GestorSql.ModificarIMC(mascota))
            {
                pacienteAtendido = true;
            }

            return pacienteAtendido;
        }

        /// <summary>
        /// metodo que atiende al paciente
        /// </summary>
        /// <param name="mascota">mascota a ser atendida</param>
        /// <param name="medico">medico que atendera</param>
        /// <returns>true si pudo atender, caso contrario retorna false</returns>
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

        /// <summary>
        /// Metodo que guarda en la BD el paciente ya atendido por un medico
        /// </summary>
        /// <param name="mascota">mascota atendida</param>
        /// <param name="medico">medico que lo atendio</param>
        /// <returns>true si pudo guardarlo, caso contrario retorna false</returns>
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

        /// <summary>
        /// metodo que asigna un medico a un paciente
        /// </summary>
        /// <param name="medicos">medico disponible</param>
        /// <param name="mascota">mascota que necesita ser atendida</param>
        /// <returns>el medico que lo atendio, caso contrario retorna null</returns>
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

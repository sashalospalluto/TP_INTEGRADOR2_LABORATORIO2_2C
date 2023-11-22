using Archivos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_veterinaria
{
    public class Veterinaria
    {
        private List<Mascota> mascotas;
        private List<Medico> medicos;
        public int cantidadMaxEnGuardia;

        public Veterinaria()
        {
            this.mascotas = new List<Mascota>();
            this.medicos = new List<Medico>();
        }

        public List<Mascota> Mascotas
        {
            get
            {
                return this.mascotas;
            }
        }

        public Veterinaria(int cantidadMaxEnGuardia) : this()
        {
            this.cantidadMaxEnGuardia = cantidadMaxEnGuardia;
        }

        public static Veterinaria operator +(Veterinaria veterinaria, Mascota mascota)
        {
            bool existe = false;

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

        public bool AtenderPaciente(Mascota mascota)
        {
            bool pacienteAtendido = false;

            if (GestorSql.ModificarIMC(mascota))
            {
                pacienteAtendido = true;
            }

            return pacienteAtendido;
        }

        public bool PacienteAtendido(Mascota mascota)
        {
            bool atendido = false;

            if(GestorSql.IngresarPacienteAtendido(mascota, this.MedicoRandom(medicos)))
            {
                atendido = true;
            }

            return atendido;
        }

        public Medico MedicoRandom(List<Medico> medico)
        {
            if(medico.Count != 0)
            {
                Random rnd = new Random();
                int indiceAleatorio = rnd.Next(medico.Count);
                Medico unMedico = medico[indiceAleatorio];
                return unMedico;
            }
            return null;
        }
    }
}

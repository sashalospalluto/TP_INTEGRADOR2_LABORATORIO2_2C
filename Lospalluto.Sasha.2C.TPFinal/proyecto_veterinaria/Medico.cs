using Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static proyecto_veterinaria.Mascota;

namespace proyecto_veterinaria
{
    public class Medico
    {
        private string nombre;
        private string apellido;
        private int dni;
        private bool atendiendo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni 
        { 
            get
            {
               return dni; 
            }
            set
            {
                if (value.ToString().Length == 8)
                {
                    this.dni = value;
                }
                else
                {
                    throw new ArgumentException("El valor ingresado no es un DNI válido.");
                }
            }

        }

        public bool Atendiendo { get => atendiendo; set => atendiendo = value; }

        public Medico()
        {

        }

        public Medico(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            Atendiendo = false;
        }

        public static bool operator ==(Medico medico1, Medico medico2)
        {
            return medico1.dni == medico2.dni;
        }

        public static bool operator !=(Medico medico1, Medico medico2)
        {
            return !(medico1 == medico2);
        }

    }
}

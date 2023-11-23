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

        /// <summary>
        /// constructor sin parametros
        /// </summary>
        public Medico()
        {

        }

        /// <summary>
        /// Constructor que instancia los datos del medico
        /// </summary>
        /// <param name="nombre">nombre del medico</param>
        /// <param name="apellido">apellido del medico</param>
        /// <param name="dni">dni del medico</param>
        public Medico(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            Atendiendo = false;
        }
        /// <summary>
        /// Operador que compara si son iguales dos medicos por su dni
        /// </summary>
        /// <param name="medico1">medico 1 a comparar con medico 2</param>
        /// <param name="medico2">medico 2 a comparar con medico 1</param>
        /// <returns>true si sus dnis son iguales, caso contrario devuelve false</returns>
        public static bool operator ==(Medico medico1, Medico medico2)
        {
            return medico1.dni == medico2.dni;
        }

        /// <summary>
        /// Operador que compara si son distintos dos medicos por su dni
        /// </summary>
        /// <param name="medico1">medico 1 a comparar con medico 2</param>
        /// <param name="medico2">medico 2 a comparar con medico 1</param>
        /// <returns>true si sus dnis son distintos, caso contrario devuelve false</returns>
        public static bool operator !=(Medico medico1, Medico medico2)
        {
            return !(medico1 == medico2);
        }

    }
}

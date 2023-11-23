using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_veterinaria
{
    public class Consulta
    {
        public Mascota Paciente { get; set; }
        public Medico Medico { get; set; }

        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Consulta() { }

        /// <summary>
        /// Constructor que recibe una mascota y un medico, y asigna los datos a sus atributos
        /// </summary>
        /// <param name="paciente">una mascota</param>
        /// <param name="medico">un medico</param>
        public Consulta(Mascota paciente, Medico medico)
        {
            Paciente = paciente;
            Medico = medico;
        }
    }
}

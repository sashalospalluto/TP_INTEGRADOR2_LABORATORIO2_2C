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

        public Consulta(Mascota paciente, Medico medico)
        {
            Paciente = paciente;
            Medico = medico;
        }
    }
}

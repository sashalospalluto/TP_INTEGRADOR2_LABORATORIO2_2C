using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_veterinaria
{
    public static class Extensiones
    {
        public static double CalcularIMC (this Mascota mascota)
        {
            Random random = new Random();
            double peso = mascota.Peso;
            double altura = random.Next(20,70);

            double imc = peso / (altura * altura);

            return imc;
        }
    }
}

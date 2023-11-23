using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_veterinaria
{
    /// <summary>
    /// 20 - Metodos de extensión 
    /// </summary>
    public static class Extensiones
    {
        /// <summary>
        /// Metodo de extension que recibe una mascota y calcula el IMC con su peso y altura
        /// </summary>
        /// <param name="mascota">una mascota de tipo Mascota</param>
        /// <returns>Devuelve el calculo de IMC</returns>
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

using System.Diagnostics;
using System.Text;

namespace proyecto_veterinaria
{
    public class Mascota
    {
        public enum ETipoMascota
        {
            Perro,
            Gato
        }

        private string nombre;
        private string nombre_tutor;
        private int dni_tutor;
        private int edad;
        private ETipoMascota tipo;
        private float peso;

        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Nombre_tutor { get => this.nombre_tutor; set => this.nombre_tutor = value; }
        public int Dni_tutor 
        {
            get 
            {
                return this.dni_tutor;               
            }
            set
            {

                if (value.ToString().Length == 8) 
                {
                    this.dni_tutor = value;
                }
                else
                {
                    throw new ArgumentException("El valor ingresado no es un DNI válido.");
                }
            }
        }
        public int Edad { get => this.edad; set => this.edad = value; }
        public ETipoMascota Tipo { get => this.tipo; set => this.tipo = value; }
        public float Peso { get => this.peso; set => this.peso = value; }

        public Mascota ()
        {
            
        }

        private Mascota(string nombre, string nombre_tutor, int edad, ETipoMascota tipo, int dni_tutor, float peso) :this()
        {
            this.Nombre = nombre;
            this.Nombre_tutor = nombre_tutor;
            this.Edad = edad;
            this.Tipo = tipo;
            this.Peso = peso;
            this.Dni_tutor = dni_tutor;
        }

        public static Mascota NuevaMascota (string nombre, string nombre_tutor, int edad, ETipoMascota tipo, int dni_tutor, string? peso)
        {
            if (float.TryParse(peso, out float peso_real) && peso_real > 0)
            {
                return new Mascota(nombre, nombre_tutor, edad, tipo, dni_tutor, peso_real);
            }
            else
            {
                throw new ArgumentException("peso erroneo, ingrese uno correcto");
            }
        }

        public static bool operator ==(Mascota mascota1, Mascota mascota2)
        {
            return mascota1.dni_tutor == mascota2.dni_tutor;
        }

        public static bool operator !=(Mascota mascota1, Mascota mascota2)
        {
            return !(mascota1 == mascota2);
        }

        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine($"Nombre mascota: {this.nombre}, Tutor: {this.nombre_tutor}, DNI tutor {this.dni_tutor}");
            return stb.ToString();
        }
    }
}
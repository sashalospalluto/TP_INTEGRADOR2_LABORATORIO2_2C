using proyecto_veterinaria;

namespace TestUnitarios
{
    [TestClass]
    public class TestVeterinaria
    {
        /// <summary>
        /// 11 - pruebas unitarias
        /// </summary>
        [TestMethod]
        public void VerificoQueSeCarguenLasMascotasEnVeterinaria()
        {
            //arrange

            Veterinaria veterinaria = new Veterinaria();
            Mascota mascota1 = Mascota.NuevaMascota("Max", "Juan", 5, Mascota.ETipoMascota.Perro, 40519519, "30");
            veterinaria += mascota1;

            Mascota mascota2 = Mascota.NuevaMascota("Lucy", "Ailen", 3, Mascota.ETipoMascota.Gato, 41547247, "7");
            veterinaria += mascota2;

            //act

            int cantidadMascotas = veterinaria.Mascotas.Count;

            //Assert

            Assert.AreEqual(2,cantidadMascotas);
        }

        /// <summary>
        /// 11 - pruebas unitarias
        /// </summary>
        [TestMethod]
        public void BuscarMascotaPorDniDelTutor()
        {
            //arrange

            Veterinaria veterinaria = new Veterinaria();
            Mascota mascota1 = Mascota.NuevaMascota("Max", "Juan", 5, Mascota.ETipoMascota.Perro, 40519519, "30");
            veterinaria += mascota1;

            //act

            Mascota mascotaEncontrada = veterinaria.BuscarMascota(mascota1.Dni_tutor);

            //Assert

            Assert.AreEqual(mascotaEncontrada, mascota1);
        }
    }
}
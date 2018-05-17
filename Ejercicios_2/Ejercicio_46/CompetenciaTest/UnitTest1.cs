using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_46;

namespace CompetenciaTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TODO completar
        /// </summary>
        [TestMethod]        
        public void TestInicializacion()
        {
            // arrange
            Competencia grandPrix = new Competencia(10, 2, Competencia.TipoCompetencia.F1);
            AutoF1 auto1 = new AutoF1(1, "fiordos");
            // act 
            grandPrix.Competidores.Add(auto1);
            // assert is handled by CompetenciaNoDisponibleException 
        }

        /// <summary>
        /// Comprobar que al cargar un nuevo vehículo en la competencia esté figure en la lista. Utilizar el operador + y el ==.
        /// </summary>
        [TestMethod]
        public void AgregarVehiculo()
        {
            // arrange
            Competencia grandPrix = new Competencia(10, 2, Competencia.TipoCompetencia.F1);
            AutoF1 auto1 = new AutoF1(1, "fiordos");
            bool expected = true;
            // act 
            bool respuesta = grandPrix + auto1;
            // assert 
            bool actual = grandPrix.Competidores.Contains(auto1);
            Assert.AreEqual(expected, actual, "El auto no fue agregado");
        }

        /// <summary>
        /// Comprobar que al quitar un vehículo existente en la competencia esté ya no figure en la lista. Utilizar el operador - y el !=.
        /// </summary>
        [TestMethod]
        public void QuitarVehiculo()
        {
            // arrange
            Competencia grandPrix = new Competencia(10, 2, Competencia.TipoCompetencia.F1);
            AutoF1 auto1 = new AutoF1(1, "fiordos");
            bool expected = false;
            // act 
            bool respuesta = grandPrix - auto1;
            // assert 
            bool actual = grandPrix.Competidores.Contains(auto1);
            Assert.AreEqual(expected, actual, "El auto aun existe");
        }

        /// <summary>
        /// Comprobar que al cargar un nuevo vehículo en la competencia esté figure en la lista. Utilizar el operador + y el ==.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))] 
        public void CompetenciaNoDisponibleException()
        {
            // arrange
            Competencia motoPrix = new Competencia(15, 3, Competencia.TipoCompetencia.MotoCross);
            AutoF1 auto1 = new AutoF1(1, "fiordos");          
            // act 
            bool a = motoPrix + auto1;
            // assert is handled by CompetenciaNoDisponibleException 
        }
    }
}

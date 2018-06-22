using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
namespace EntidadesTesting
{
    [TestClass]
    public class EntidadesTesting
    {

        /// <summary>
        /// Si hacemos new Paciente("Nombre", "Apellido"); el valor del Turno deberá ser 1.
        /// Si hacemos new Paciente("Nombre", "Apellido", 5); el valor del Turno deberá ser 5.
        /// Si hacemos new Paciente("Nombre", "Apellido"); el valor del Turno deberá ser 6.
        /// </summary>
        [TestMethod]
        public void ConstructoresPaciente()
        {
            //arrange 
            Paciente paciente = new Paciente("Nombre", "Apellido");
            Paciente paciente2 = new Paciente("Nombre", "Apellido", 5);
            Paciente paciente3 = new Paciente("Nombre", "Apellido");
            //act
            //asset            
            Assert.AreEqual(1, paciente.Turno, "El turno deberia ser 1");
            Assert.AreEqual(5, paciente2.Turno, "El turno deberia ser 5");
            Assert.AreEqual(6, paciente3.Turno, "El turno deberia ser 6");
            
             
        }
    }
}

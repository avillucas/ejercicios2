using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace CentralitaTest
{
    [TestClass]
    public class CentralitaTest
    {        
        [TestMethod]
        public void AgregarLlamadaLocal()
        {
            //arreglo
            Centralita central = new Centralita("Fede Center");                        
            Local llamadaLocal = new Local("Bernal", 30, "Rosario", 2.65f);
            //acto
            central += llamadaLocal;
            bool llamadaLocalExiste = central == llamadaLocal;
            //
            Assert.AreEqual(true, llamadaLocalExiste, "La llamada Local no se agrego"); 
        }

        [TestMethod]
        public void AgregarLlamadaProvincial()
        {
            //arreglo
            Centralita central = new Centralita("Fede Center");
            Provincial llamadaProvincial = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            //acto
            central += llamadaProvincial;
            bool llamadaLocalExiste = central == llamadaProvincial;
            //
            Assert.AreEqual(true, llamadaLocalExiste, "La llamada Provincial no se agrego");
        }

        /// <summary>
        /// Controlar mediante un nuevo método de test unitario que la excepción CentralitaExcepcion 
        /// se lance al intentar cargar una segunda llamada con solamente los mismos datos de origen y
        /// destino de una llamada Local ya existente.
        /// </summary>
        /// 
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void AgregarLlamadaLocalRepetida()
        {
            //arreglo
            Centralita central = new Centralita("Fede Center");
            Local llamadaLocal = new Local("Bernal", 30, "Rosario", 2.65f);
            Local llamadaLocalReplicada = new Local("Bernal", 50, "Rosario", 4.5f);
            //acto
            central += llamadaLocal;
            central += llamadaLocalReplicada;
        }        

        /// <summary>
        /// Controlar mediante un nuevo método de test unitario que la excepción CentralitaExcepcion
        /// se lance al intentar cargar una segunda llamada con solamente los mismos datos de origen y
        /// destino de una llamada Provincial ya existente.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void AgregarLlamadaProvicialRepetida()
        {
            //arreglo
            Centralita central = new Centralita("Fede Center");
            Provincial llamadaProvincial = new Provincial("Morón", Provincial.Franja.Franja_2, 60, "Bernal");
            Provincial llamadaProvincialReplica = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            //acto
            central += llamadaProvincial;
            central += llamadaProvincialReplica;
        }        

         ///Crear un test unitario que valide que la lista de llamadas de la centralita esté instanciada al crear un nuevo objeto del tipo Centralita.
        [TestMethod]
        public void validarInstanciacionListaLlamadas()
        {
            //arreglo
            Centralita central = new Centralita("Fede Center");
            short cantidadEsperada = 0;
            //
            Assert.AreEqual(cantidadEsperada, central.Llamadas.Count, "Las llamadas no estain inicializadas");
        }

        ///Dentro de un método de test unitario crear dos llamadas Local y dos Provincial, todos con
        ///los mismos datos de origen y destino. Luego comparar cada uno de estos cuatro objetos
        ///contra los demás, debiendo ser iguales solamente las instancias de Local y de Provincial
        ///entre sí.
        [TestMethod]
        public void CompararIgualdadDeTipos()
        {
            //set de datos
            Provincial llamadaProvincial = new Provincial("Morón", Provincial.Franja.Franja_2, 60, "Bernal");
            Provincial llamadaProvincialReplica = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local llamadaLocal = new Local("Bernal", 30, "Rosario", 2.65f);
            Local llamadaLocalReplicada = new Local("Bernal", 50, "Rosario", 4.5f);
            //acto
            bool localLocalReplica = llamadaLocal == llamadaLocalReplicada;
            bool localProvincial = llamadaLocal == llamadaProvincial;
            bool localProvincialReplica = llamadaLocal == llamadaProvincialReplica;
            //
            bool localReplicaProvincial = llamadaLocalReplicada == llamadaProvincial;            
            bool localReplicaProvincialReplica = llamadaLocalReplicada == llamadaProvincialReplica;
            //
            bool provincialProvincialReplica = llamadaProvincial == llamadaProvincialReplica;            
            //acto
            Assert.AreEqual(true, localLocalReplica, "Las dos llamadas locales no son iguales");
            Assert.AreEqual(false, localProvincial, "La llamada Local y la provincial son iguales");
            Assert.AreEqual(false, localProvincialReplica, "La segunda llamada local es igual a la llamada provincial");
            Assert.AreEqual(false, localReplicaProvincialReplica, "La segunda llamda local y la segunda provincial son iguales");
            Assert.AreEqual(true, provincialProvincialReplica, "Las dos llamadas provinciales no son iguales");

        }

    }
}

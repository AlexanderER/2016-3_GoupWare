using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman.Business_Logic;


namespace Hangman.UnitTests
{
    [TestClass]
    public class Test_LetraContenidaEnPalabra
    {
        [TestMethod]
        public void LaLetraAsiEstaEnLaPalabraMama()
        {
            // Paso1.   Definimos el escenario de los valores a enviar
            Char sletra                = 'a';
            String sPalabra            = "Mama";
            Boolean bResultadoEsperado = true;



            // Paso 2.   Invocamos al metodo correspondiente
            Herramientas Tool      = new Herramientas();
            Boolean bResultadoReal = Tool.UnaLetraEstaContenidaEnUnaPalabra(sletra, sPalabra);



            // Paso 3.   Comparar el resultado real con el esperado
            Assert.AreEqual(bResultadoEsperado, bResultadoReal);



        }


        [TestMethod]
        public void LaLetraAmayusculasiEstaEnLaPalabraMama()
        {
            // Paso1.   Definimos el escenario de los valores a enviar
            Char sletra = 'A';
            String sPalabra = "Mama";
            Boolean bResultadoEsperado = true;



            // Paso 2.   Invocamos al metodo correspondiente
            Herramientas Tool = new Herramientas();
            Boolean bResultadoReal = Tool.UnaLetraEstaContenidaEnUnaPalabra(sletra, sPalabra);



            // Paso 3.   Comparar el resultado real con el esperado
            Assert.AreEqual(bResultadoEsperado, bResultadoReal);



        }


    }
}

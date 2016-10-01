using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman.Business_Logic;
using System.Data;

namespace Hangman.UnitTests
{
    /// <summary>
    /// Descripción resumida de Test_IndicesLetraEnPalabra
    /// </summary>
    [TestClass]
    public class Test_IndicesLetraEnPalabra
    {
        [TestMethod]
        public void PruebaExitosa()
        {
            // Paso1.   Definimos el escenario de los valores a enviar
            Char sletra                = 'a';
            String sPalabra            = "Mama";
            Int32 iResultadoEsperado   = 2;



            // Paso 2.   Invocamos al metodo correspondiente
            Herramientas Tool    = new Herramientas();
            DataSet dsResultado  = Tool.obtenerIndicesLetraEnPalabra(sletra, sPalabra);
            Int32 iResultadoReal = dsResultado.Tables[0].Rows.Count;


            // Paso 3.   Comparar el resultado real con el esperado
            Assert.AreEqual(iResultadoEsperado, iResultadoReal);
        }

        [TestMethod]
        public void PruebaInCorrecta()
        {
            // Paso1.   Definimos el escenario de los valores a enviar
            Char sletra = 'A';
            String sPalabra = "Mama";
            Int32 iResultadoEsperado = 2;



            // Paso 2.   Invocamos al metodo correspondiente
            Herramientas Tool = new Herramientas();
            DataSet dsResultado = Tool.obtenerIndicesLetraEnPalabra(sletra, sPalabra);
            Int32 iResultadoReal = dsResultado.Tables[0].Rows.Count;


            // Paso 3.   Comparar el resultado real con el esperado
            Assert.AreEqual(iResultadoEsperado, iResultadoReal);
        }

    }
}

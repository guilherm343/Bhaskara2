using BhaskaraApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BhaskaraTeste
{
    [TestClass()]


    public class BhaskaraUnitTest
    {


        [TestMethod]
        [DataRow(1, -5, 6, 3, 2)]   // Raízes esperadas: 3 e 2
        [DataRow(1, 3, -4, 1, -4)]  // Raízes esperadas: 1 e -4
        [DataRow(1, -4, 4, 2, 2)]   // Raízes esperadas: 2 e 2 (raiz dupla)
        [DataRow(1, 6, 8, -2, -4)]  // Raízes esperadas: -2 e -4
        [DataRow(1, 1, -6, 2, -3)]  // Raízes esperadas: 2 e -3
        public void Teste_de_Raizes(double a, double b, double c, double esperado1, double esperado2)
        {
            // Arrange
            var bhaskara = new Bhaskara(a, b, c);

            // Act
            var (Raiz1, Raiz2) = bhaskara.CalcularRaizes();

            // Assert
            Assert.AreEqual(esperado1, Raiz1, "O valor da raiz 1 está incorreto.");
            Assert.AreEqual(esperado2, Raiz2, "O valor da raiz 2 está incorreto.");
        }

        [TestMethod]
        [DataRow(2, 5, 3, 1)]     // Delta esperado: 1
        [DataRow(3, 4, 2, -8)]    // Delta esperado: -8
        [DataRow(1, 2, 1, 0)]     // Delta esperado: 0
        [DataRow(4, 0, -9, 144)]  // Delta esperado: 144
        [DataRow(5, -7, 2, 9)]    // Delta esperado: 9


        public void Teste_de_Delta(double a, double b, double c, double deltaEsperado)
        {
            // Arrange
            var bhaskara = new Bhaskara(a, b, c);

            // Act
            var Del = bhaskara.CalcularDelta();

            // Assert
            Assert.AreEqual(deltaEsperado, Del, "O valor de Delta está incorreto.");

        }


        [TestMethod]
        [DataRow(1, -6, 9, 0, 0, 0)]
        [DataRow(0, 0, 0, 0, 0, 0)]
        public void Teste_de_Uma_Raiz(double a, double b, double c, double delta, double esperado1, double esperado2)
        {
            // Arrange
            var bhaskara = new Bhaskara(a, b, c);   

            // Act
            var deltaCalculado = bhaskara.TemRaizesReais();

            // Assert
            Assert.AreEqual(delta, esperado1);
        }

    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gestionBancariaApp;
namespace gestionBancariaTest
{
    [TestClass]

    public class gestionBancariaTests
    {
        [TestMethod]
        public void validarMetodoIngreso()
        {
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarIngreso(ingreso);

            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "Elsaldo de la cuenta no es correcto");
             
        }

        [TestMethod]
        public void validarMetodoReintegro()
        {
            double saldoReintegro = 1000;
        }
    }
}

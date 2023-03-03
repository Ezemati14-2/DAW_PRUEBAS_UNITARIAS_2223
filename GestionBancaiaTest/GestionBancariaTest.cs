using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GestionBancariaAppNS;
using System.Windows.Forms;

namespace GestionBancaiaTest
{
    [TestClass]
    public class GestionBancariaTest
    {
        [TestMethod]

        //public void ValidarReintegro ()
        //{
        //    //Ezequiel Matias Maggio 2023 alu-2771
        //    //preparacion del caso de prueba
        //    const double ERR_CANTIDAD_NO_VALIDA = 1;
        //    double saldoInicial = 1000;
        //    double reintegro = 1001;
        //    double saldoEsperado = ERR_CANTIDAD_NO_VALIDA;



        //    GestionBancariaApp miAppEMM2771 = new
        //    GestionBancariaApp(saldoInicial);
        //    //Ezequiel Matias Maggio 2023 alu-2771
        //    //metodo a probar

        //    miAppEMM2771.RealizarReintegro (reintegro);
        //    Assert.AreNotEqual(saldoEsperado, miAppEMM2771.RealizarReintegro(reintegro), 0.001, "Se produbjo un error al realizar el reintegro, saldo" + "incorrecto.");
        //}

        //public void ValidarIngreso()
        //{
        //    //Ezequiel Matias Maggio 2023 alu-2771
        //    //preparacion del caso de prueba
        //    //const int ERR_SALDO_INSUFICIENTE = 0;
        //    double saldoInicial = 10;
        //    double ingreso = 0;
        //    double saldoEsperado = 10;


        //    GestionBancariaApp miAppEMM2771 = new
        //    GestionBancariaApp(saldoInicial);
        //    //Ezequiel Matias Maggio 2023 alu-2771
        //    //metodo a probar

        //    miAppEMM2771.RealizarIngreso(ingreso);
        //    Assert.AreEqual(saldoEsperado, miAppEMM2771.RealizarIngreso(ingreso), "Se produbjo un error al realizar eL INGRESO, saldo" + "incorrecto.");
        //}


        //public void ValidarReintrgroCantidadaNoValida()
        //{
        //    //Ezequiel Matias Maggio 2023 alu-2771
        //    //preparacion del caso de prueba
        //    double saldoInicial = -1;
        //    double reintegro = 10;
        //    double saldoEsperado = saldoInicial - reintegro;


        //    GestionBancariaApp miAppEMM2771 = new GestionBancariaApp(saldoInicial);
        //    //Ezequiel Matias Maggio 2023 alu-2771
        //    //metodo a probar

        //    miAppEMM2771.RealizarReintegro(reintegro);
        //    //Assert.AreEqual(saldoEsperado, miAppEMM2771.RealizarIngreso(ingreso), "Se produbjo un error al realizar eL INGRESO, saldo" + "incorrecto.");
        //}

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidarIngresoCantidadaNoValida()
        {
            //Ezequiel Matias Maggio 2023 alu-2771
            //preparacion del caso de prueba
            double saldoInicial = 0;
            double ingreso = -10;
            double saldoEsperado = saldoInicial + ingreso;


            GestionBancariaApp miAppEMM2771 = new GestionBancariaApp(saldoInicial);
            //Ezequiel Matias Maggio 2023 alu-2771
            //metodo a probar

            miAppEMM2771.RealizarIngreso(ingreso);
            //Assert.AreEqual(saldoEsperado, miAppEMM2771.RealizarIngreso(ingreso), "Se produbjo un error al realizar eL INGRESO, saldo" + "incorrecto.");
        }
        public void TestMethod1()
        {
            //Ezequiel Matias Maggio 2023 alu-2771
        }
    }
}

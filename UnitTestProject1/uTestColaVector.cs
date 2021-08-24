using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Ordenamiento;
using System;
using Servicios.Colecciones.Vectoriales;
using Servicios.Colecciones.Enlazadas;
using Servicios.Colecciones.DobleEnlazadas;

namespace uTestColecciones
{

    [TestClass]
    public class uTestColaVector
    {

        #region Atributos de prueba
        private clsColaVector<int> miCola;
        private int atrItem = 0;
        #endregion
        #region Metodos de prueba
        #region Test Construcctor

        [TestMethod]
        public void uTestConstructorPorDefecto()
        {
            #region Configurar
            miCola = new clsColaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(100, miCola.darCapacidad());
            Assert.AreEqual(0, miCola.DarLongitud());
            Assert.AreNotEqual(null, miCola.DarItems());
            Assert.AreEqual(100, miCola.DarItems().Length);
            #endregion

        }
        [TestMethod]
        public void uTestConstructorParametrizado()
        {
            #region Configurar
            miCola = new clsColaVector<int>(200);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(200, miCola.darCapacidad());
            Assert.AreEqual(0, miCola.DarLongitud());
            Assert.AreNotEqual(null, miCola.DarItems());
            Assert.AreEqual(200, miCola.DarItems().Length);
            #endregion
        }
        #endregion
        #region Test Accesores
        [TestMethod]
        public void testDarLongitud()
        {
            #region Configurar
            miCola = new clsColaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(0, miCola.DarLongitud());
            #endregion
        }
        [TestMethod]
        public void testDarCapacidad()
        {
            #region Configuar
            miCola = new clsColaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(100, miCola.darCapacidad());
            #endregion
        }
        [TestMethod]
        public void testDarItems()
        {
            #region Configurar
            miCola = new clsColaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreNotEqual(null, miCola.DarItems());
            for (int varIndice = 0; varIndice < miCola.darCapacidad(); varIndice++)
            {
                Assert.AreEqual(0, miCola.DarItems()[varIndice]);
            }
            #endregion
        }
        #endregion
        #region Test Mutadores
        [TestMethod]
        public void testPonerItems()
        {
            #region Configurar
            miCola = new clsColaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, miCola.PonerItems(new int[3] { 123, 456, 789 }));
            Assert.AreEqual(123, miCola.DarItems()[0]);
            Assert.AreEqual(456, miCola.DarItems()[1]);
            Assert.AreEqual(789, miCola.DarItems()[2]);
            Assert.AreEqual(3, miCola.DarLongitud());
            Assert.AreEqual(3, miCola.darCapacidad());

            #endregion
        }
        #endregion
        #region Test CRUDs
        #region Test Encolar
        [TestMethod]
        public void testEncolarEnTADVacio()
        {
            #region Configurar
            miCola = new clsColaVector<int>();
            int varLongitudAnterior = miCola.DarLongitud();
            int varCapacidadAnterior = miCola.darCapacidad();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, miCola.Encolar(123));
            Assert.AreEqual(123, miCola.DarItems()[miCola.DarLongitud() - 1]);
            Assert.AreEqual(varLongitudAnterior + 1, miCola.DarLongitud());
            Assert.AreEqual(varCapacidadAnterior, miCola.darCapacidad());
            #endregion
        }
        [TestMethod]
        public void testEncolarEnTADLleno()
        {
            #region Configurar
            miCola = new clsColaVector<int>();
            miCola.PonerItems(new int[3] { 123, 456, 789 });
            int varLongitudAnterior = miCola.DarLongitud();
            int varCapacidadAnterior = miCola.darCapacidad();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, miCola.Encolar(777));
            Assert.AreEqual(varLongitudAnterior, miCola.DarLongitud());
            Assert.AreEqual(varCapacidadAnterior, miCola.darCapacidad());
            Assert.AreEqual(123, miCola.DarItems()[0]);
            Assert.AreEqual(456, miCola.DarItems()[1]);
            Assert.AreEqual(789, miCola.DarItems()[2]);
            Assert.AreEqual(false, miCola.Encolar(1));
            #endregion
        }
        [TestMethod]
        public void testEnconlarHastaLlenar()
        {
            #region Configurar
            miCola = new clsColaVector<int>(3);
            int varLongitudAnterior = miCola.DarLongitud();
            int varCapacidadAnterior = miCola.darCapacidad();

            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, miCola.Encolar(789));
            Assert.AreEqual(true, miCola.Encolar(456));
            Assert.AreEqual(true, miCola.Encolar(123));
            Assert.AreEqual(false, miCola.Encolar(098));
            Assert.AreEqual(varLongitudAnterior + 3, miCola.DarLongitud());
            Assert.AreEqual(varCapacidadAnterior, miCola.darCapacidad());
            #endregion
        }
        #endregion
        #region Test DesEncolar
        [TestMethod]
        public void uTestDesEncolarEnTADVacio()
        {
            #region Configurar
            miCola = new clsColaVector<int>();
            int varLongitudAnterior = miCola.DarLongitud();
            int varCapacidadAnterior = miCola.darCapacidad();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, miCola.Desencolar(ref atrItem));
            Assert.AreEqual(0, atrItem);
            Assert.AreEqual(varLongitudAnterior, miCola.DarLongitud());
            Assert.AreEqual(varCapacidadAnterior, miCola.darCapacidad());
            #endregion
        }
        [TestMethod]
        public void uTestDesEncolarEnTADLleno()
        {
            #region Configurar
            miCola = new clsColaVector<int>();
            miCola.PonerItems(new int[3] { 123, 456, 789 });
            int VarLongitudAnterior = miCola.DarLongitud();
            int VarCapacidadAnterior = miCola.darCapacidad();
            atrItem = -1;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, miCola.Desencolar(ref atrItem));
            Assert.AreEqual(123, atrItem);
            Assert.AreEqual(VarLongitudAnterior - 1, miCola.DarLongitud());
            Assert.AreEqual(VarCapacidadAnterior, miCola.darCapacidad());
            Assert.AreEqual(456, miCola.DarItems()[0]);
            Assert.AreEqual(789, miCola.DarItems()[1]);
            Assert.AreEqual(789, miCola.DarItems()[2]);

            #endregion
        }
        [TestMethod]
        public void testDesEncolarHastaVaciar()
        {
            #region Configuraqr
            miCola = new clsColaVector<int>();
            miCola.PonerItems(new int[3] { 123, 456, 789 });
            int varLongitudAnterior = miCola.darCapacidad();
            int varCapacidadAnterior = miCola.darCapacidad();
            atrItem = -1;

            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, miCola.Desencolar(ref atrItem));
            Assert.AreEqual(123, atrItem);
            Assert.AreEqual(true, miCola.Desencolar(ref atrItem));
            Assert.AreEqual(456, atrItem);
            Assert.AreEqual(true, miCola.Desencolar(ref atrItem));
            Assert.AreEqual(789, atrItem);
            Assert.AreEqual(false, miCola.Desencolar(ref atrItem));
            Assert.AreEqual(789, miCola.DarItems()[0]);
            Assert.AreEqual(789, miCola.DarItems()[1]);
            Assert.AreEqual(789, miCola.DarItems()[2]);
            Assert.AreEqual(varLongitudAnterior - 3, miCola.DarLongitud());
            Assert.AreEqual(varCapacidadAnterior, miCola.darCapacidad());


            #endregion
        }
        #endregion
        #region Test Revisar
        [TestMethod]
        public void uTestRevisarEnTADVacio()
        {
            #region Configurar
            miCola = new clsColaVector<int>();
            int varLongitudAnterior = miCola.DarLongitud();
            int varCapacidadAnterior = miCola.darCapacidad();
            atrItem = -1;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, miCola.revisar(ref atrItem));
            Assert.AreEqual(-1, atrItem);
            Assert.AreEqual(varLongitudAnterior, miCola.DarLongitud());
            Assert.AreEqual(varCapacidadAnterior, miCola.darCapacidad());
            #endregion
        }
        [TestMethod]
        public void uTestRevisarEnTADLleno()
        {
            #region Configurar
            miCola = new clsColaVector<int>();
            miCola.PonerItems(new int[3] { 123, 456, 789 });
            int varLongitudAnterior = miCola.DarLongitud();
            int varCapacidadAnterior = miCola.darCapacidad();
            atrItem = -1;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, miCola.revisar(ref atrItem));
            Assert.AreEqual(123, atrItem);
            Assert.AreEqual(varLongitudAnterior, miCola.DarLongitud());
            Assert.AreEqual(varCapacidadAnterior, miCola.darCapacidad());
            Assert.AreEqual(123, miCola.DarItems()[0]);
            Assert.AreEqual(456, miCola.DarItems()[1]);
            Assert.AreEqual(789, miCola.DarItems()[2]);
            #endregion
        }
        #endregion
        #endregion
        #endregion
    }
}

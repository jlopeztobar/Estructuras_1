using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Ordenamiento;
using System;
using Servicios.Colecciones.Vectoriales;
using Servicios.Colecciones.Enlazadas;
using Servicios.Colecciones.DobleEnlazadas;

namespace uTestColecciones
{

    [TestClass]
    public class uTestPilaVector
    {
        #region Atributos de Prueba
        private clsPilaVector<int> miPila;
        private int atrItem = 0;
        #endregion
        #region Metodos de prueba
        #region Test Constructor
        [TestMethod]
        public void uTestConstructorPorDefecto()
        {

            #region Configurar
            miPila = new clsPilaVector<int>();
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(100, miPila.darCapacidad());
            Assert.AreEqual(0, miPila.DarLongitud());
            Assert.AreNotEqual(null, miPila.DarItems());
            Assert.AreEqual(100, miPila.DarItems().Length);
            #endregion
        }
        [TestMethod]
        public void uTestConstructorParametrizado()
        {
            #region Configuar
            miPila = new clsPilaVector<int>(200);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(0, miPila.DarLongitud());
            Assert.AreNotEqual(null, miPila.DarItems());
            Assert.AreEqual(200, miPila.DarItems().Length);
            Assert.AreEqual(200, miPila.darCapacidad());
            #endregion
        }
        #endregion
        #region Test Accesores
        [TestMethod]
        public void testDarLongitud()
        {
            #region Configurar
            miPila = new clsPilaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(0, miPila.DarLongitud());
            #endregion
        }
        [TestMethod]
        public void testDarCapacidad()
        {
            #region Configurar
            miPila = new clsPilaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(100, miPila.darCapacidad());
            #endregion
        }
        [TestMethod]
        public void testDarItems()
        {
            #region Configurar
            miPila = new clsPilaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreNotEqual(null, miPila.DarItems());
            for (int varIndice = 0; varIndice < miPila.darCapacidad(); varIndice++)
            {
                Assert.AreEqual(0, miPila.DarItems()[varIndice]);
            }
            #endregion
        }
        #endregion
        #region  Test Mutadores
        [TestMethod]
        public void testPonerItems()
        {
            #region Configurar
            miPila = new clsPilaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, miPila.PonerItems(new int[3] { 123, 456, 789 }));
            Assert.AreEqual(123, miPila.DarItems()[0]);
            Assert.AreEqual(456, miPila.DarItems()[1]);
            Assert.AreEqual(789, miPila.DarItems()[2]);
            Assert.AreEqual(3, miPila.DarLongitud());
            Assert.AreEqual(3, miPila.darCapacidad());
            #endregion
        }
        #endregion
        #region Test CRUDs
        #region Test Apilar
        [TestMethod]
        public void testApilarEnTADVacio()
        {
            #region Configurar
            miPila = new clsPilaVector<int>();
            int varLongitudAnterior = miPila.DarLongitud();
            int varCapacidadAnterior = miPila.darCapacidad();
            #endregion
            #region probar y comprobar
            Assert.AreEqual(true, miPila.Apilar(123));
            Assert.AreEqual(123, miPila.DarItems()[0]);
            Assert.AreEqual(varLongitudAnterior + 1, miPila.DarLongitud());
            Assert.AreEqual(varCapacidadAnterior, miPila.darCapacidad());
            #endregion

        }

        public void testApilarEnTADLleno()
        {
            #region Configurar
            miPila = new clsPilaVector<int>();
            int varLongitudAnterior = miPila.DarLongitud();
            int varCapacidadAnterior = miPila.darCapacidad();
            miPila.PonerItems(new int[3] { 123, 456, 789 });



            #endregion
            #region probar y comprobar
            Assert.AreEqual(false, miPila.Apilar(777));
            Assert.AreEqual(varLongitudAnterior, miPila.DarLongitud());
            Assert.AreEqual(varCapacidadAnterior, miPila.darCapacidad());
            Assert.AreEqual(123, miPila.DarItems()[0]);
            Assert.AreEqual(456, miPila.DarItems()[1]);
            Assert.AreEqual(789, miPila.DarItems()[2]);

            #endregion
        }
        public void testApilarHastaLlenar()
        {
            #region Configurar
            miPila = new clsPilaVector<int>();
            int varLongitudAnterior = miPila.DarLongitud();
            int varCapacidadAnterior = miPila.darCapacidad();

            #endregion
            #region probar y comprobar
            Assert.AreEqual(true, miPila.Apilar(789));
            Assert.AreEqual(true, miPila.Apilar(456));
            Assert.AreEqual(true, miPila.Apilar(123));
            Assert.AreEqual(123, miPila.DarItems()[0]);
            Assert.AreEqual(456, miPila.DarItems()[1]);
            Assert.AreEqual(789, miPila.DarItems()[2]);
            Assert.AreEqual(varLongitudAnterior + 3, miPila.DarLongitud());
            Assert.AreEqual(varCapacidadAnterior, miPila.darCapacidad());


            #endregion
        }
        #endregion
        #region Test Desapilar
        [TestMethod]
        public void uTestDesapilarEnTADVacio()
        {
            #region Configurar
            miPila = new clsPilaVector<int>();
            int varLongitudAnterior = miPila.DarLongitud();
            int varCapacidadAnterior = miPila.darCapacidad();
            atrItem = 0;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, miPila.Desapilar(ref atrItem));
            Assert.AreEqual(0, atrItem);
            Assert.AreEqual(varLongitudAnterior, miPila.DarLongitud());
            Assert.AreEqual(varCapacidadAnterior, miPila.darCapacidad());
            #endregion


        }
        public void uTestDesapilarEnTADLleno()
        {
            #region Configurar
            miPila = new clsPilaVector<int>();
            miPila.PonerItems(new int[3] { 123, 456, 789 });
            int varLongitudAnterior = miPila.DarLongitud();
            int varCapacidadAnterior = miPila.darCapacidad();
            atrItem = -1;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, miPila.Desapilar(ref atrItem));
            Assert.AreEqual(123, atrItem);
            Assert.AreEqual(varLongitudAnterior - 1, miPila.DarLongitud());
            Assert.AreEqual(varCapacidadAnterior, miPila.darCapacidad());
            Assert.AreEqual(456, miPila.DarItems()[0]);
            Assert.AreEqual(789, miPila.DarItems()[1]);
            Assert.AreEqual(789, miPila.DarItems()[2]);
            #endregion
        }
        public void uTestDesapilarHastaVacion()
        {
            #region Configurar
            miPila = new clsPilaVector<int>();
            miPila.PonerItems(new int[3] { 123, 456, 789 });
            int varLongitudAnterior = miPila.DarLongitud();
            int varCapacidadAnterior = miPila.darCapacidad();
            atrItem = -1;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, miPila.Desapilar(ref atrItem));
            Assert.AreEqual(123, atrItem);
            Assert.AreEqual(true, miPila.Desapilar(ref atrItem));
            Assert.AreEqual(456, atrItem);
            Assert.AreEqual(true, miPila.Desapilar(ref atrItem));
            Assert.AreEqual(789, atrItem);
            Assert.AreEqual(false, miPila.Desapilar(ref atrItem));
            Assert.AreEqual(789, miPila.DarItems()[0]);
            Assert.AreEqual(789, miPila.DarItems()[1]);
            Assert.AreEqual(789, miPila.DarItems()[2]);
            Assert.AreEqual(varLongitudAnterior - 3, miPila.DarLongitud());
            Assert.AreEqual(varCapacidadAnterior, miPila.darCapacidad());
            #endregion
        }
        #endregion
        #region Test Revisar
        public void uTestRevisarEnTADVacio()
        {

            #region Configurar
            miPila = new clsPilaVector<int>();
            int varLongitudAnterior = miPila.DarLongitud();
            int varCapacidadAnterior = miPila.darCapacidad();
            atrItem = -1;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, miPila.Revisar(ref atrItem));
            Assert.AreEqual(-1, atrItem);
            Assert.AreEqual(varLongitudAnterior, miPila.DarLongitud());
            Assert.AreEqual(varCapacidadAnterior, miPila.darCapacidad());

            #endregion

        }
        public void uTestRevisarEnTADLleno()
        {
            #region Configurar
            miPila = new clsPilaVector<int>();
            miPila.PonerItems(new int[3] { 123, 456, 789 });
            int varLongitudAnterior = miPila.DarLongitud();
            int varCapacidadAnterior = miPila.darCapacidad();
            atrItem = -1;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, miPila.Revisar(ref atrItem));
            Assert.AreEqual(123, atrItem);
            Assert.AreEqual(varLongitudAnterior, miPila.DarLongitud());
            Assert.AreEqual(varCapacidadAnterior, miPila.darCapacidad());
            Assert.AreEqual(123, miPila.DarItems()[0]);
            Assert.AreEqual(456, miPila.DarItems()[1]);
            Assert.AreEqual(789, miPila.DarItems()[2]);
            #endregion
        }
        #endregion
        #endregion
        #endregion
    }

}
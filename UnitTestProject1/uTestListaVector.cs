using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Ordenamiento;
using System;
using Servicios.Colecciones.Vectoriales;
using Servicios.Colecciones.Enlazadas;
using Servicios.Colecciones.DobleEnlazadas;

namespace uTestColecciones
{
    [TestClass]
    public class uTestListaVector
    {
        private clsListaVector<int> miLista;

        [TestMethod]

        public void TestAgregar()
        {
            #region configurar
            miLista = new clsListaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(null, miLista.agregar(0));
            #endregion


        }
        public void TestEncontrar()
        {
            #region configurar
            miLista = new clsListaVector<int>();
            #endregion
            #region probar y comprobar
            //
            #endregion
        }
        public void TestInsertar()
        {
            #region configurar
            miLista = new clsListaVector<int>();
            #endregion
            #region probar y comprobar
            //
            #endregion
        }
        public void TestModificar()
        {
            #region configurar
            miLista = new clsListaVector<int>();
            #endregion
            #region probar y comprobar
            //
            #endregion
        }
        public void TestRecuperar()
        {
            #region configurar
            miLista = new clsListaVector<int>();
            #endregion
            #region probar y comprobar
            //
            #endregion
        }
        public void TestRemover()
        {
            #region configurar
            miLista = new clsListaVector<int>();
            #endregion
            #region probar y comprobar
            //
            #endregion
        }

    }
}

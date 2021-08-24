using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;


namespace Servicios.Colecciones.Tads
{
    public class clsTADEnlazado<Tipo>: clsTAD<Tipo> , iTADEnlazada<Tipo>
    {
        #region Atributos
        private clsNodoEnlazado<Tipo> atrPrimero=null;
        private clsNodoEnlazado<Tipo> atrUltimo = null;
        #endregion
        #region Operaciones
        #region constructores
        public clsTADEnlazado() { }
        #endregion
        #region Accesores
        public clsNodoEnlazado<Tipo> darPrimero()
        {
            //TODO:Implementar
            return null;
        }
        public clsNodoEnlazado<Tipo> darUltimo()
        {
            //TODO:Implementar
            return null;
        }
        #region CRUDs
        #region Insertadores
        protected override bool insertarPrimero(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected override bool insertarUltimo(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected override bool insertarEnMedio(int prmIndice, Tipo prmItem)
        {
            throw new NotImplementedException();
        }
       
        #endregion
           #region Extractores
        protected override bool extraerPrimero(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected override bool extraerUltimo(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected override bool extraerEnMedio(int prmIndice, ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        
        #endregion
        #region Modificadores
        protected override bool modificarPrimero(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected override bool modificarUltimo(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected override bool modificarEnMedio(int prmIndice, Tipo prmItem)
        {
            throw new NotImplementedException();
        }
       
        #endregion
        #region Recuperadores
        protected override bool recuperarPrimero(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected override bool recuperarUltimo(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected override bool recuperarEnMedio(int prmIndice, ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        
        #endregion
        #endregion
        #endregion
        #endregion
    }
}

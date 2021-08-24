using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;
namespace Servicios.Colecciones.Tads
{
    public class clsTADDobleEnlazado<Tipo>:clsTAD<Tipo> , iTADDobleEnlazado<Tipo>
    {
        #region Atributos
        private clsNodoDobleEnlazado<Tipo> atrPrimero = null;
        private clsNodoDobleEnlazado<Tipo> atrUltimo = null;
        #endregion
        #region Operaciones
        #region constructores
        public clsTADDobleEnlazado() { }

        #endregion
        #region Accesores
        public clsNodoDobleEnlazado<Tipo> darPrimero()
        {
            //TODO:Implementar
            return null;
        }
        public clsNodoDobleEnlazado<Tipo> darUltimo()
        {
            //TODO:Implementar
            return null;
        }
        #endregion
        #region CRUDs
        #region Insertadores
        protected virtual bool InsertarPrimero(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected virtual bool InsertarUltimo(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        protected virtual bool InsertarEnMedio(int prmIndice, Tipo prmItem)
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
    }
}

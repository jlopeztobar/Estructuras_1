
using System;
using Servicios.Colecciones.Interfaces;
namespace Servicios.Colecciones.Nodos
{
    public class clsNodoDobleEnlazado<Tipo>:clsNodo<Tipo>, iNodoDobleEnlazado<Tipo>
    {
        #region atributos
        #region Asociativos
        private clsNodoDobleEnlazado<Tipo> atrAnterior;
        private clsNodoDobleEnlazado<Tipo> atrSiguiente;
        #endregion
        #endregion
        #region Operaciones
        #region Accesores
        public clsNodoDobleEnlazado(Tipo prmItem) { }

        public clsNodoDobleEnlazado<Tipo> darAnterior()
        {
            throw new NotImplementedException();
        }

        public clsNodoDobleEnlazado<Tipo> darSiguiente()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Constructores
        public clsNodoDobleEnlazado() { }
       
        #endregion
        #endregion
    }
}

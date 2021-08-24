
using Servicios.Colecciones.Interfaces;
namespace Servicios.Colecciones.Nodos
{
    public class clsNodoEnlazado<Tipo>:clsNodo<Tipo> , iNodoEnlazado<Tipo>

    {
        #region Atributos
        clsNodoEnlazado<Tipo> atrSiguiente = null;
        #endregion
        #region Operaciones
        #region Constructores
        public clsNodoEnlazado() { }
        public clsNodoEnlazado(Tipo prmItem) : base(prmItem)
        {
            //TODO:Implementar
        }
        #endregion
        #endregion
    }
}

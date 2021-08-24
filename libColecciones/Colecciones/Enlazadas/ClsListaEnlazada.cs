using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Tads;

namespace Servicios.Colecciones.Enlazadas
{
    public class ClsListaEnlazada<Tipo> : clsTADEnlazado<Tipo> , iLista<Tipo>
    {
        #region Operaciones
        #region Constructores
        ClsListaEnlazada() { }
        #endregion
        #region CRUDs
        public bool agregar(Tipo prmItem)
        {
            return false;
        }

        public bool encontrar(Tipo prmItem, ref int prmIndice)
        {
            return false;
        }

        public bool insertar(int prmIndice, Tipo prmItem)
        {
            return false;
        }

        public bool modificar(int prmIndice, Tipo prmItem)
        {
            return false;
        }

        public bool recuperar(int prmIndice, ref Tipo prmItem)
        {
            return false;
        }

        public bool remover(int prmIndice, ref Tipo prmItem)
        {
            return false;
        }
        #endregion
        #endregion
    }
}

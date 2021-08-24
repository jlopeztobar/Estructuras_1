
using Servicios.Colecciones.Interfaces;
namespace Servicios.Colecciones.Nodos
{
    public class clsNodo<Tipo>:iNodo<Tipo>
    {
        #region Atributos
        private Tipo atrItem = default(Tipo);
        #endregion
        #region Operaciones
        #region Constructores
        public clsNodo() { }
        public clsNodo(Tipo prmItem)
        {
            //TODO:implementar
        }
        #endregion
        #region Accesores
        public Tipo darItem()
        {
            //TODO: implementar
            return default(Tipo);
        }
        #endregion
        #region Mutadores
        public void ponerItem(Tipo prmContenido) {
            //TODO:Implementar
        }
        #endregion
        #endregion
    }
}

using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Tads;

namespace Servicios.Colecciones.Enlazadas
{
    public class ClsColaEnlazada<Tipo> : clsTADEnlazado<Tipo> , iCola<Tipo>
    {
        #region Operaciones
        #region Constructores
        ClsColaEnlazada() { }
        #endregion
        #region CRUDs
        public bool Desencolar(ref Tipo prmitem)
        {
            //TODO:Implementar
            return false;
            
        }

        public bool Encolar(Tipo prmitem)
        {
            //TODO:Implementar
            return false;
        }

        public bool revisar(ref Tipo prmitem)
        {
            //TODO:Implementar
            return false; 
        }
        #endregion
        #endregion
    }
}

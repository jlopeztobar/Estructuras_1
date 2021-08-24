using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.Interfaces
{
    public interface iTADDobleEnlazado<Tipo>
    {
        #region Accesores
        clsNodoDobleEnlazado<Tipo> darPrimero();
        clsNodoDobleEnlazado<Tipo> darUltimo();
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Colecciones.Interfaces
{
    public interface iTADVectoriales<Tipo>
    {
        #region Accesores
        Tipo[] DarItems();
        int darCapacidad();
        #endregion
        #region Mutadores
        bool PonerItems(Tipo[] prmVector);
        #endregion
    }
}

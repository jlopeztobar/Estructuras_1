using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Colecciones.Interfaces
{
    public interface iTAD<Tipo>
    {
        #region Accesores
        int DarLongitud();
        #endregion
        bool esValido(int prmIndice);
    }
}

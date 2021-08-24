using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Colecciones.Interfaces
{
    interface iNodo<Tipo>
    {
        #region Accesores
        #endregion
        #region Mutadores
        void ponerItem(Tipo prmContenido);
        #endregion
    }
}

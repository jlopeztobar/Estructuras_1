using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Colecciones.Interfaces
{
    public interface iCola<Tipo>
    {
        #region CRUDs
        bool Encolar(Tipo prmitem);
        bool Desencolar(ref Tipo prmitem);
        bool revisar(ref Tipo prmitem);
        #endregion
    }
}

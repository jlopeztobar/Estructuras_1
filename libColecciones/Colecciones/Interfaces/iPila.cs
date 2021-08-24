using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Colecciones.Interfaces
{
    public interface iPila<Tipo>
    {
        #region CRUDs
        bool Apilar(Tipo prmItem);
        bool Desapilar(ref Tipo prmItem);
        bool Revisar(ref Tipo prmItem);
        #endregion
    }
}

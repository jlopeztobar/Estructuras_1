using Servicios.Colecciones.Tads;
using Servicios.Colecciones.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Colecciones.DobleEnlazadas 
{
    class clsColaDobleEnlazada<Tipo> : clsTADEnlazado<Tipo> , iCola<Tipo>
    {
        #region CRUDs
        public bool Desencolar(ref Tipo prmitem)
        {
            return ExtraerEn(0, ref prmitem);
        }

        public bool Encolar(Tipo prmitem)
        {
            return InsertarEn(atrlongitud, prmitem);
        }

        public bool revisar(ref Tipo prmitem)
        {
            return recuperarEn(0, ref prmitem);
        }
        #endregion
    }
}

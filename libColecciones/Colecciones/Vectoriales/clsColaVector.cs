using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Tads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Colecciones.Vectoriales
{
    public class clsColaVector<Tipo> : clsTADVectorial<Tipo> , iCola<Tipo> 
    {
        #region Operaciones
        #region Constructores
        public clsColaVector()
        {

        }
        public clsColaVector(int prmcapacidad):base(prmcapacidad) {

        }
        #endregion
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
        #endregion
    }
}

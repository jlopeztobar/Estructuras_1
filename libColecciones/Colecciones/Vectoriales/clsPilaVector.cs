 using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Tads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Colecciones.Vectoriales
{
    public class clsPilaVector<Tipo> : clsTADVectorial<Tipo> , iPila<Tipo>
    {
        #region Operaciones
        #region Constructores
        public clsPilaVector()
        {


        }
        public clsPilaVector(int prmcapacidad):base(prmcapacidad)
        {

        }
        #endregion
        #region CRUDs
        public bool Apilar(Tipo prmItem)
        {
            //return InsertarPrimero(prmItem);
            return InsertarEn(0, prmItem);
        }

        public bool Desapilar(ref Tipo prmItem)
        {
            return ExtraerEn(0, ref prmItem);
        }

        public bool Revisar(ref Tipo prmItem)
        {
            return recuperarEn(0, ref prmItem);
        }
        #endregion
        #endregion
    }
}

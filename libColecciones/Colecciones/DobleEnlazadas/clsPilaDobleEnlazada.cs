using Servicios.Colecciones.Tads;
using Servicios.Colecciones.Interfaces;
using System;

namespace Servicios.Colecciones.DobleEnlazadas
{
    public class clsPilaDobleEnlazada<Tipo> : clsTADDobleEnlazado<Tipo> , iPila<Tipo>
    {
        #region Operaciones
        #region Constructores
        public clsPilaDobleEnlazada() { }
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

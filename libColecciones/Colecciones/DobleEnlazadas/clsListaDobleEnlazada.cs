using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Tads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Colecciones.DobleEnlazadas
{
    class clsListaDobleEnlazada<Tipo> : clsTADEnlazado<Tipo>, iLista<Tipo>
    {
        #region CRUDs
        public bool agregar(Tipo prmItem)
        {
            return InsertarEn(atrlongitud, prmItem);
        }

        public bool encontrar(Tipo prmItem, ref int prmIndice)
        {
            return default(bool);
        }

        public bool insertar(int prmIndice, Tipo prmItem)
        {
            return InsertarEn(prmIndice, prmItem);
        }

        public bool modificar(int prmIndice, Tipo prmItem)
        {
            return modificarEn(prmIndice, ref prmItem);
        }

        public bool recuperar(int prmIndice, ref Tipo prmItem)
        {
            return recuperarEn(prmIndice, ref prmItem);
        }

        public bool remover(int prmIndice, ref Tipo prmItem)
        {
            return ExtraerEn(prmIndice, ref prmItem);
        }
        #endregion
    }
}

using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Tads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Colecciones.Vectoriales
{
    public class clsListaVector<Tipo> : clsTADVectorial<Tipo>, iLista<Tipo>
    {
        private int v;
        #region Operaciones
        #region Constructores
        public clsListaVector() {
        }

        public clsListaVector(int v)
        {
            this.v = v;
        }

        public clsListaVector(int prmcapacidad, int v) :base(prmcapacidad)
        {

        }
        #endregion
        #region CRUDs
        public bool agregar(Tipo prmItem)
        {
            return InsertarEn(atrlongitud, prmItem);
        }

        public bool encontrar(Tipo prmItem,ref int prmIndice)
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

        public bool recuperar(int prmIndice,ref Tipo prmItem)
        {
            return recuperarEn(prmIndice, ref prmItem);
        }

        public bool remover(int prmIndice,ref  Tipo prmItem)
        {
            return ExtraerEn(prmIndice, ref prmItem);
        }
        #endregion
        #endregion
    }
}

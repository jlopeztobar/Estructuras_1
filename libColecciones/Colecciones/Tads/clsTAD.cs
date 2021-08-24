using Servicios.Colecciones.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Colecciones.Tads
{
    public class clsTAD<Tipo> : iTAD<Tipo>
    {
        #region Atributos
        #region Propios
        protected int atrlongitud;
        #endregion
        #endregion
        #region Constructores
        public clsTAD()
        {

        }
        #endregion
        #region Consultores
        public bool esValido(int prmIndice)
        {
            return (prmIndice >= 0 && prmIndice < atrlongitud);
        }
        #endregion
        #region CRUDs
        #region Insertadores
        protected virtual bool insertarPrimero(Tipo prmItem) {
            return false;
        }
        protected virtual bool insertarUltimo(Tipo prmItem)
        {
            return false;
        }
        protected virtual bool insertarEnMedio(int prmIndice, Tipo prmItem) {
            return false;
        }
        protected bool InsertarEn(int prmIndice, Tipo prmItem) {
            if (prmIndice == 0) return insertarPrimero(prmItem);
            if (prmIndice == atrlongitud) return insertarUltimo(prmItem);
            if (esValido(prmIndice)) return insertarEnMedio(prmIndice, prmItem);
            return false;
        }
        #endregion
        #region Extractores
        protected virtual bool extraerPrimero(ref Tipo prmItem)
        {
            return false;
        }
        protected virtual bool extraerUltimo(ref Tipo prmItem)
        {
            return false;
        }
        protected virtual bool extraerEnMedio(int prmIndice, ref Tipo prmItem)
        {
            return false;
        }
        protected bool ExtraerEn(int prmIndice, ref Tipo prmItem)
        {
            if (prmIndice == 0) return extraerPrimero(ref prmItem);
            if (prmIndice == atrlongitud) return extraerUltimo(ref prmItem);
            if (esValido(prmIndice)) return extraerEnMedio(prmIndice, ref prmItem);
            return false;
        }
        #endregion
        #region Modificadores
        protected virtual bool modificarPrimero(Tipo prmItem)
        {
            return false;
        }
        protected virtual bool modificarUltimo(Tipo prmItem)
        {
            return false;
        }
        protected virtual bool modificarEnMedio(int prmIndice, Tipo prmItem)
        {
            return false;
        }
        protected bool modificarEn(int prmIndice, ref Tipo prmItem)
        {
            if (prmIndice == 0) return modificarPrimero(prmItem);
            if (prmIndice == atrlongitud) return modificarUltimo(prmItem);
            if (esValido(prmIndice)) return modificarEnMedio(prmIndice, prmItem);
            return false;
        }
        #endregion
        #region Recuperadores
        protected virtual bool recuperarPrimero(ref Tipo prmItem)
        {
            return false;
        }
        protected virtual bool recuperarUltimo(ref Tipo prmItem)
        {
            return false;
        }
        protected virtual bool recuperarEnMedio(int prmIndice, ref Tipo prmItem)
        {
            return false;
        }
        protected bool recuperarEn(int prmIndice, ref Tipo prmItem)
        {
            if (prmIndice == 0) return recuperarPrimero(ref prmItem);
            if (prmIndice == atrlongitud) return recuperarUltimo(ref prmItem);
            if (esValido(prmIndice)) return recuperarEnMedio(prmIndice, ref prmItem);
            return false;
        }
        #endregion
        #endregion
        #region Patrón Iterador
        #region Atributos
        protected int atrIndiceActural;
        protected Tipo atrItemActual;
        #endregion
        #region Operaciones
        #region Accesores
        public int darIndiceActual()
        {
            return atrIndiceActural;
        }
        public Tipo darItemActual() {
            return atrItemActual;
        }
        #endregion
        #region Mutadores
        public virtual void ponerItemActual(Tipo prmItem) { }
        #endregion
        #region Posicionadores
        public virtual bool irPrimero()
        {
            return false;
        }
        public virtual bool irUltimo() {
            return false;
        }
        public bool irAnterior() {
            if (hayAnterior()) { return retrocederItem(); }
            return false;
        }
        public bool irSiguiente() {
            if (haySiguiente()) { return avanzarItem(); }
            return false;
        }
        public virtual bool irIndice(int prmIndice) { return false; }
        protected virtual bool avanzarItem() {
            return false;
        }
        public virtual bool retrocederItem() {
            return false;
        }
        #endregion
        #region Consultores
        public bool estaVacia()
        {
            return atrlongitud == 0;
        }
        public bool hayAnterior()
        {
            return (estaVacia()== false && atrIndiceActural > 0);
        }
        public bool haySiguiente()
        {
            return ((estaVacia() == false) && (atrIndiceActural < atrlongitud-1));
        }
        #endregion
        #endregion

        #endregion
        #region Accesores
        public int DarLongitud()
        {
            return atrlongitud;
        }
        #endregion
    }
}

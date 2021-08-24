using Servicios.Colecciones.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Colecciones.Tads
{
    public class clsTADVectorial<Tipo> : clsTAD<Tipo> , iTADVectoriales<Tipo>
    {
        #region Atributos
        #region propios
        private int capacidad;
        private Tipo[] items;
        #endregion
        #endregion
        #region Operaciones
        #region Constructores
        public clsTADVectorial() {
            atrlongitud = 0;
            capacidad = 100;
            items = new Tipo[capacidad];
            // Valor de ejemplo
        }
        public clsTADVectorial(int prmcapacidad)
        {
            capacidad = 100;
            atrlongitud = 0;
            if (prmcapacidad > 0)
            {
                capacidad = prmcapacidad;
            }
            items = new Tipo[capacidad];
        }
        #endregion
        #region Accesores
        public int darCapacidad()
        {
            return capacidad;
        }

        public Tipo[] DarItems()
        {
            return items;
        }
        #endregion
        #region Mutadores
        public bool PonerItems(Tipo[] Vector)
        {
            atrlongitud = Vector.Length;
            capacidad = Vector.Length;
            items = Vector;
            return true;
        }

        #endregion
        #region CRUDs
        #region Insertadores
        protected override bool insertarPrimero(Tipo prmItem)
        {
            if (desplazarItems(true, 0)) {
                atrlongitud += 1;
                items[0] = prmItem;
                return true;
            }
            return false;
        }
        protected override bool insertarUltimo(Tipo prmItem)
        {
            if (desplazarItems(true, atrlongitud - 1))
            {
                atrlongitud += 1;
                items[atrlongitud - 1] = prmItem;
                return true;
            }
            return false;
        }
        protected override bool insertarEnMedio(int prmIndice, Tipo prmItem)
        {
            if (desplazarItems(true, prmIndice))
            {
                atrlongitud += 1;
                items[prmIndice] = prmItem;
                return true;
            }
            return false;
        }
        #endregion
        #region Extractores
        protected override bool extraerPrimero(ref Tipo prmItem)
        {
            if (atrlongitud > 0) 
            {
                atrlongitud -= 1;
                prmItem = items[0];
                desplazarItems(false, 0);
                return true;
            }
            return false;
        }
        protected override bool extraerUltimo(ref Tipo prmItem)
        {
            if (atrlongitud > 0)
            {
                atrlongitud -= 1;
                prmItem = items[atrlongitud - 1];
                desplazarItems(false, atrlongitud - 1);
                return true;
            }
            return false;
        }
        protected override bool extraerEnMedio(int prmIndice, ref Tipo prmItem)
        {
            if (atrlongitud > 0)
            {
                atrlongitud -= 1;
                prmItem = items[prmIndice];
                desplazarItems(false, prmIndice);
                return true;
            }
            return false;
        }
        
        #endregion
        #region Modificadores
        protected override bool modificarPrimero(Tipo prmItem)
        {
            if (atrlongitud > 0)
            {
                items[0] = prmItem;
                return true;
            }
            return false;
        }
        protected override bool modificarUltimo(Tipo prmItem)
        {
            if (atrlongitud > 0)
            {
                items[atrlongitud - 1] = prmItem;
                return true;
            }
            return false;
        }
        protected override bool modificarEnMedio(int prmIndice, Tipo prmItem)
        {
            if (atrlongitud > 0)
            {
                items[prmIndice] = prmItem;
                return true;
            }
            return false;
        }
       
        #endregion
        #region Recuperadores
        protected override bool recuperarPrimero(ref Tipo prmItem)
        {
            if (atrlongitud > 0) 
            {
                prmItem = items[0];
                return true;
            }
            return false;
        }
        protected override bool recuperarUltimo(ref Tipo prmItem)
        {
            if (atrlongitud > 0) 
            {
                prmItem = items[atrlongitud - 1];
                return true;
            }
            return false;
        }
        protected override bool recuperarEnMedio(int prmIndice, ref Tipo prmItem)
        {
            if (atrlongitud > 0) 
            {
                prmItem = items[prmIndice];
                return true;
            }
            return false;
        }

        #endregion
        #endregion
        #endregion
        #region Auxiliares
        protected bool desplazarItems(bool haciaDerecha, int prmIndice)
        {
            if (!(atrlongitud == capacidad) && haciaDerecha)
            {
                for (int indice = atrlongitud - 1; indice >= prmIndice; indice--)
                { 
                    items[indice + 1] = items[indice];
                }
                return true;
            }
            if (!haciaDerecha)
            {
                for (int indice = prmIndice; indice < atrlongitud ; indice++) 
                {
                    items[indice] = items[indice + 1];
                }
                return true;
            }
            return false;
        }
        #endregion
    }
}

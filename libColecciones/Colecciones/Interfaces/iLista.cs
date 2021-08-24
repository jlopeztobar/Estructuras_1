﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Colecciones.Interfaces
{
    public interface iLista<Tipo>
    {
        #region CRUDs
        bool agregar(Tipo prmItem);
        bool insertar(int prmIndice, Tipo prmItem);
        bool remover(int prmIndice, ref Tipo prmItem);
        bool modificar(int prmIndice, Tipo prmItem);
        bool recuperar(int prmIndice, ref Tipo prmItem);
        bool encontrar(Tipo prmItem, ref int prmIndice);
        #endregion
    }
}

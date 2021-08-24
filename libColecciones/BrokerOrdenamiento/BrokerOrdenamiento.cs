namespace Servicios.Ordenamiento
{
    public static class clsBrokerOrdenamiento
    {
        /// <summary>
        /// Propós to:Implementa el Ordena miento por el Método de la Burbuja Simple Original según el criterio Ascendente .
        /// Se implementa este método como referencia para comparar su desempeño contra los servicios de ordenamiento de la Librería ofrecidos por la clase TAO y TAO Vectorial,que sí gestionan excepciones, mensajería y criterio de ordenamiento.
        /// O(n) =n^2
        /// </summary>
        /// <param name="prmVector"></param>
        ///  <contiene> es la estructura de datos que se van a ordenar.



        public static void Burbuja(ref int[] prmVector)
        {

            int varPosExterior;
            int varPorsinterior;
            int varElementoTemporal;

            for (varPosExterior = 1; varPosExterior < prmVector.Length - 1; varPosExterior++)
            {
                for (varPorsinterior = 0; varPorsinterior < prmVector.Length - varPosExterior - 1; varPorsinterior++)
                {
                    if (prmVector[varPorsinterior] > prmVector[varPorsinterior + 1])
                    {
                        varElementoTemporal = prmVector[varPorsinterior];
                        prmVector[varPorsinterior] = prmVector[varPorsinterior + 1];
                        prmVector[varPorsinterior + 1] = varElementoTemporal;

                    }
                }
            }

        }
        /// <summary>
        /// Propósito: Implementa elOrdenam iento por elMétodo de la Burbuja Mejorado Originalsegún Criterio Ascendente.Funciona sí y solo síla colección  se ha creado con datos enteros. 
        /// Se implementa este método como referencia para comparar su desempeño contra los servicios de ordenamiento de la Librería ofrecidos por la clase TAO y TAO Vectorial,que sí gestionan excepciones, mensajería y criterio de ordenamiento.
        /// O(n)= n log(n)
        /// </summary>
        /// <param name="prmVector"></param>
        /// <contiene> es la estructura de datos que se van a ordenar.

        public static void BurbujaMejorado(ref int[] prmVector)
        {
            int varPosExterior;
            int varPosInterior;
            int varElementoTemporal;
            bool varHuboIntercambio;

            varPosExterior = 1;
            varHuboIntercambio = true;

            while ((varPosExterior < prmVector.Length) && (varHuboIntercambio == true))
            {
                varPosExterior = varPosExterior + 1;
                varHuboIntercambio = false;

                for (varPosInterior = 0; varPosInterior < prmVector.Length - varPosExterior; varPosInterior++)
                {
                    if (prmVector[varPosInterior] > prmVector[varPosInterior + 1])
                    {
                        varElementoTemporal = prmVector[varPosInterior];
                        prmVector[varPosInterior] = prmVector[varPosInterior + 1];
                        prmVector[varPosInterior + 1] = varElementoTemporal;
                        varHuboIntercambio = true;
                    }
                }
            }

        }
        /// <summary>
        /// Proposito: Implementa el Ordenamiento por el Método de la Burbuja Bi-DireccionalOriginal según Criterio Ascendente .Se implementa este método como referencia para comparar su desempeño
        /// contra los servicios de ordenam iento de la Librería  ofrecidos por la clase TAD y TAD Vectorial,que sí gestionan excepciones, mensajería y criterio de ordenamiento.
        /// O(n)= log(2n)
        /// </summary>
        /// <param name="prmVector"></param>
        /// /// <contiene> es la estructura de datos que se van a ordenar.

        public static void BurbujaBiDireccional(ref int[] prmVector)
        {
            bool varHuboIntercambios;
            int varPos;
            int varElementoTemporal;

            do
            {
                varHuboIntercambios = false;

                for (varPos = 0; varPos < prmVector.Length - 2; varPos++)
                {
                    if (prmVector[varPos] > prmVector[varPos + 1])
                    {
                        varElementoTemporal = prmVector[varPos];
                        prmVector[varPos] = prmVector[varPos + 1];
                        prmVector[varPos + 1] = varElementoTemporal;
                        varHuboIntercambios = true;
                    }
                }

                if (varHuboIntercambios == false)
                {
                    break;
                }
                varHuboIntercambios = false;
                for (varPos = prmVector.Length - 2; varPos == 0; varPos++)
                {
                    if (prmVector[varPos] > prmVector[varPos + 1])
                    {
                        varElementoTemporal = prmVector[varPos];
                        prmVector[varPos] = prmVector[varPos + 1];
                        prmVector[varPos + 1] = varElementoTemporal;
                        varHuboIntercambios = true;

                    }
                }

            } while (varHuboIntercambios == true);

        }
        /// <summary>
        /// Proposito: Implementa el Ordenamiento por el Método de Inserción Original según Criterio Ascendente . 
        /// Se implementa este método como referencia para comparar su desempeño contra los servicios de ordenamiento de la Librería ofrecidos por la clase TAD y TAO Vectorial, que sí gestionan excepciones, mensajería y criterio de ordenamiento.
        /// O(n)= n log(n)
        /// </summary>
        /// <param name="prmVector"></param>
        ///  <contiene> es la estructura de datos que se van a ordenar.


        public static void Insercion(ref int[] prmVector)
        {
            int varPosExterior;
            int VarPosInterior;
            int varElementoInsertado;

            for (varPosExterior = 1; varPosExterior < prmVector.Length - 1; varPosExterior++)
            {
                varElementoInsertado = prmVector[varPosExterior];
                VarPosInterior = varPosExterior - 1;


                while ((VarPosInterior >= 0) && (prmVector[VarPosInterior] != varElementoInsertado) && (prmVector[VarPosInterior] > varElementoInsertado))
                {
                    prmVector[VarPosInterior + 1] = prmVector[VarPosInterior];
                    VarPosInterior = VarPosInterior - 1;
                }
                prmVector[VarPosInterior + 1] = varElementoInsertado;
            }

        }
        /// <summary>
        /// Propósito: Implementa el Ordenam iento por el Método de Selección Original según Criterio Ascendente. 
        /// Se implementa este método como referencia para comparar su desempeño contra los servicios de ordenamiento de la Librería ofrecidos por la clase TAD y TAD Vectorial, que sí gestionan excepciones, mensajería y criterio de ordenamiento.
        /// O(n)= n^2
        /// </summary>
        /// <param name="prmVector"></param>
        /// <contiene> es la estructura de datos que se van a ordenar.
        /// 

        public static void Seleccion(ref int[] prmVector)
        {
            int varPosExterior;
            int varPosInterior;
            int varPosDelMinimo;
            int varElementoTemporal;

            for (varPosExterior = 0; varPosExterior < prmVector.Length - 1; varPosExterior++)
            {
                varPosDelMinimo = varPosExterior;
                for (varPosInterior = varPosExterior + 1; varPosInterior < prmVector.Length - 1; varPosInterior++)
                {
                    if (prmVector[varPosInterior] < prmVector[varPosDelMinimo])
                    {
                        varPosDelMinimo = varPosInterior;
                    }
                }
                if (varPosDelMinimo != varPosExterior)
                {
                    varElementoTemporal = prmVector[varPosDelMinimo];
                    prmVector[varPosDelMinimo] = prmVector[varPosExterior];
                    prmVector[varPosExterior] = varElementoTemporal;
                }
            }


        }
        /// <summary>
        /// Propósito: Implementa el Ordenamiento por el Método QuickSort Original según Criterio Ascendente.
        /// Se implementa este método como referencia para comparar su desempeño contra los servicios de ordenamiento de la Librería ofrecidos por la clase TAD y TAD Vectorial,que sí gestionan excepciones, mensajería y criterio de ordenamiento.
        /// O(n)= nlog(n)
        /// </summary>
        /// <param name="prmVector"></param>
        /// <contiene> es la estructura de datos que se van a ordenar.
        /// <param name="prmPosPrimero"></param>
        /// <contiene> devuelve el primer elemento del vector
        /// /// <param name="prmPosUltimo"></param>
        /// <contiene> devuelve el ultimo elemento del vector


        public static void QuickSort(ref int[] prmVector, int prmPosPrimero, int prmPosUltimo)
        {
            int varPosIzquierdo;
            int varPosDerecho;
            int varElementoPivote;
            int varElementoTemporal;

            varElementoPivote = prmVector[(prmPosPrimero + prmPosUltimo) / 2];
            varPosIzquierdo = prmPosPrimero;
            varPosDerecho = prmPosUltimo;

            while ((varPosIzquierdo <= varPosDerecho) && (prmPosUltimo - prmPosPrimero) > 0)
            {
                while (prmVector[varPosIzquierdo] < varElementoPivote)
                {
                    varPosIzquierdo = varPosIzquierdo + 1;
                }
                while (prmVector[varPosDerecho] > varElementoPivote)
                {
                    varPosDerecho = varPosDerecho - 1;
                }
                if (varPosIzquierdo <= varPosDerecho)
                {
                    varElementoTemporal = prmVector[varPosIzquierdo];
                    prmVector[varPosIzquierdo] = prmVector[varPosDerecho];
                    prmVector[varPosDerecho] = varElementoTemporal;
                    varPosIzquierdo = varPosIzquierdo + 1;
                    varPosDerecho = varPosDerecho - 1;
                }
            }
            if (prmPosPrimero < varPosDerecho)
            {
                QuickSort(ref prmVector, prmPosPrimero, varPosDerecho);
            }
            if (varPosIzquierdo < prmPosUltimo)
            {
                QuickSort(ref prmVector, varPosIzquierdo, prmPosUltimo);
            }

        }

    }


}


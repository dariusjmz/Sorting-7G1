using System;
using System.Collections.Generic;
using System.Text;

namespace método_radix
{
    public delegate string Clave<T>(T elemento);
    internal class Radix
    {
        public void Ordenar<T>(List<T> lista, Clave<T> clave)
        {
            int largo = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (clave(lista[i]).Length > largo)
                {
                    largo = clave(lista[i]).Length;
                }
            }
            for (int p = largo - 1; p >= 0; p--)
            {
                List<List<T>> contenedores = new List<List<T>> { };
                for (int i = 0; i < 256; i++)
                {
                    contenedores.Add(new List<T> { });
                }
                for (int i = 0; i < lista.Count; i++)
                {
                    string texto = clave(lista[i]);
                    int indice = 0;
                    if (p < texto.Length)
                    {
                        indice = char.ToLowerInvariant(texto[p]);
                    }
                    contenedores[indice].Add(lista[i]);
                }

                lista.Clear();
                for (int i = 0; i < contenedores.Count; i++)
                {
                    for (int j = 0; j < contenedores[i].Count; j++)
                    {
                        lista.Add(contenedores[i][j]);
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace ByteBank.SistemaAgencia
{
    public static class ListaExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach(T item in itens)
            {
                lista.Add(item);
            }
        }

        public static void Imprimir<T>(this List<T> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
}

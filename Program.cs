using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_MaxCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {3,4,4,6,1,4,4};

            int nInicial = 5;

            Console.WriteLine(solucion(nInicial,arr));

            Console.ReadLine();

            int[] solucion(int N, int[]A) {

                int[] Contador = new int[N];

                int baseMinima = 0;
                int posibleMinimo = 0;
                int indice = 0;


                for (int i = 0; i < A.Length; i++)
                {
                    indice = A[i] - 1;

                    if (indice==N)
                    {
                        baseMinima = posibleMinimo;

                    }
                    else
                    {
                        Contador[indice] = Math.Max(Contador[indice], baseMinima);
                        Contador[indice] += 1;

                        if (posibleMinimo<Contador[indice])
                        {
                            posibleMinimo = Contador[indice];

                        }
                    }

                }

                for (int i = 0; i < Contador.Length; i++)
                {
                    Contador[i] = Math.Max(Contador[i], baseMinima);
                }


                return Contador;


            }

        }
    }
}

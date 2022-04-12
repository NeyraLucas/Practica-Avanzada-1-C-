using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaAvanzada1
{
    public class Operations
    {
        public Operations() { }

        //Pares
        public List<int> EvenNumbers(List<int> even)
        {
            //puntero
            List<int> result = new List<int>();
            foreach (int i in even)
            {
                if ((i % 2) == 0)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        //Impares
        public List<int> OddNumbers(List<int> even)
        {
            //puntero
            List<int> result = new List<int>();
            foreach (int i in even)
            {
                if ((i % 2) == 1)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        //Burbuja Asc
        public List<int> BubbleAsc(List<int> arr)
        {
            int aux = 0;
            for (int j = 0; j < arr.Count; j++)
            {
                //pasadas
                for (int i = 0; i < arr.Count - 1; i++)
                {
                    //add
                    if (arr[i] > arr[i + 1])
                    {
                        aux = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = aux;
                    }

                }
            }

            return arr;
        }

        //Burbuja Des
        public List<int> BubbleDesc(List<int> arr)
        {
            int aux = 0;
            for (int j = 0; j < arr.Count; j++)
            {
                //pasadas
                for (int i = 0; i < arr.Count - 1; i++)
                {
                    //add
                    if (arr[i] < arr[i + 1])
                    {
                        aux = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = aux;
                    }

                }
            }

            return arr;
        }

        //Multiplo
        public string Multiplo(int num)
        {
            return ((num % 3) == 0) ? "Es multiplo de 3" : "No es multiplo";
        }

        //Max value
        public int MaxValue(List<int> arr)
        {
            int aux = 0;
            for (int j = 0; j < arr.Count; j++)
            {
                //pasadas
                for (int i = 0; i < arr.Count - 1; i++)
                {
                    //add
                    if (arr[i] < arr[i + 1])
                    {
                        aux = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = aux;
                    }

                }
            }

            return arr[0];
        }

        //Min value
        public int MinValue(List<int> arr)
        {
            int aux = 0;
            for (int j = 0; j < arr.Count; j++)
            {
                //pasadas
                for (int i = 0; i < arr.Count - 1; i++)
                {
                    //add
                    if (arr[i] < arr[i + 1])
                    {
                        aux = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = aux;
                    }

                }
            }

            return arr[arr.Count];
        }

        //Valor promedio
        public int AverageValue(List<int> arr)
        {
            int aux = 0;
            foreach (int i in arr)
            {
                aux += i;
            }

            aux = aux / arr.Count;

            return aux;

        }

        //RMS Value
        public double Rms(List<int> arr)
        {
            //RMS
            int cont = 0;
            double resultado = 0;
            double aux2 = 0;
            foreach (var rms in arr)
            {
                aux2 += Math.Pow(rms, 2);

            }

            return resultado = Math.Sqrt(aux2 / arr.Count);
        }
    }
}

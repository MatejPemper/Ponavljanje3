using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje3
{
    internal class Program
    {

        class KlasaX
        {

            int[] array = new int[100];

            int index;

            public int Index { get => index; set => index = value; }

            public int Dodjela(int[] array, int i)
            {
                i = Index;
                return array[Index];
            }
        }

        static void Main(string[] args)
        {

            int[] array = new int[100];
            KlasaX x = new KlasaX();
            for (int i = 0; i < 100; i++)
            {
                x.Index = i;
                x.Dodjela(array, i);
            }
            Console.WriteLine(array[50]);




            Console.ReadKey();

        }
    }
}


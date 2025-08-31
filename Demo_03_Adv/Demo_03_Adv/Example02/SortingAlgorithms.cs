using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03_Adv.Example02
{
    // Generic Delegate 
    //public delegate Tout SortingStrategyFuncDelegate<in T1, in T2, out Tout>(T1 A, T2 B);
    internal static class SortingAlgorithms<T>
    {
        public static void BubbleSort(T[] Arr, Func<T, T, bool>? sortingStrategy)
        {
            if (Arr?.Length > 0 && sortingStrategy is not null)
                for (int i = 0; i < Arr.Length; i++)
                    for (int j = 0; j < Arr.Length - 1 - i; j++)
                        if (sortingStrategy(Arr[j], Arr[j + 1]))
                            Swap(ref Arr[j], ref Arr[j + 1]);
        }
        private static void Swap(ref T v1, ref T v2)
        {
            T temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}

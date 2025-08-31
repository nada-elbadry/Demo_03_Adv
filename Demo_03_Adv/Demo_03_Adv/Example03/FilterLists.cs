using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03_Adv.Example03
{ 
    //public delegate bool FilterListFuncDelegate<T>(T number);
    internal static class FilterLists
    {
        public static List<T> FindElements<T>(List<T> elements, Predicate<T>? filterList)
        {
            List<T> Result = new List<T>();
            if (elements?.Count > 0 && filterList is not null)
            {
                for (int i = 0; i < elements.Count; i++)
                {
                    if (filterList(elements[i]))
                        Result.Add(elements[i]);
                }
            }
            return Result;
        }

    }
}

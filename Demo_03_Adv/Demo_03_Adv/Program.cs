namespace Demo_03_Adv
{
    internal class Program
    {
        //// Step 0 : Defining a Delegate
        //public delegate int StringFuncDelegate(string s);
        //// New Delegate [Class]
        //// Reference From This Delegate Can Refer To 
        //// One Function Or More [Pointer To Function]
        //// This Functions May Be Static Function Or Non Static Function 
        //// But These Function Must Be With The Same Signature Of Delegate
        //// Regardless Function Name and Access Modifier 
        static void Main(string[] args)
        {
            #region Example 01
            //// Step 01 : Declare reference From Delegate 
            //Func<string, int>? stringFunc;

            //// Step 02 : Initialize Reference From Delegate[Pointer To Function]

            //stringFunc = StringFunctions.GetCountOfUpperCaseChar; // Syntax Sugar

            //stringFunc += StringFunctions.GetCountOfLowerCaseChar;
            //// Add New Reference For Function To Reference From Delegate 

            //stringFunc -= StringFunctions.GetCountOfUpperCaseChar;
            //// Remove Reference Of GetCountOfUpperCaseChar() Method

            //// Step 03 : Use Delegate Reference [Invoke Method]

            //int Result = stringFunc?.Invoke("RoutE") ?? 0;

            ////Result = stringFunc("RoutE");
            //if (stringFunc != null)
            //	Result = stringFunc("RoutE");
            //else
            //	Result = 0;

            //Console.WriteLine(Result); // 2 
            #endregion

            #region Example 02

            //int[] Numbers = { 7, 6, 5, 8, 9, 4, 1, 3, 2 };

            //SortingAlgorithms<int>.BubbleSort(Numbers, SortingStrategy.SortAsc); // To Sort In Asc

            //Func<int, int, bool>? sortingStrategy01 = SortingStrategy.SortDesc;

            //SortingAlgorithms<int>.BubbleSort(Numbers, sortingStrategy01); // To Sort In Desc

            //foreach (int item in Numbers) Console.Write($"{item} ");

            #endregion

            #region Example 02 With Generics 

            //string[] Names = ["Omar", "Mohamed", "Amr", "Salma"];

            //Func<string, string, bool> sortingStrategy02 = SortingStrategy.SortAsc;

            //SortingAlgorithms<string>.BubbleSort(Names, sortingStrategy02);

            //SortingAlgorithms<string>.BubbleSort(Names, SortingStrategy.SortDesc);

            //foreach (string item in Names) Console.Write($"{item} "); // Mohamed Salma Omar Amr

            #endregion

        }
    }
}

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


            #region Example 03 

            //List<int> Numbers = Enumerable.Range(1, 100).ToList();

            //List<int> OddNumbers = FilterLists.FindElements(Numbers, FiltersOfList.CheckOdd);

            //Predicate<int> filterList = FiltersOfList.CheckEven;

            //List<int> EvenNumbers = FilterLists.FindElements(Numbers, filterList);

            //List<int> NumbersDivisableBy7 = FilterLists.FindElements(Numbers, FiltersOfList.DivisibleBy7);

            //foreach (int item in NumbersDivisableBy7) Console.Write($"{item} ");
            //// 7 14 21 28 35 42 49 56 63 70 77 84 91 98


            //List<string> Names = ["Ahmed", "Aya", "Khaled", "Rawan", "Amr", "Youssef"];

            //List<string> NamesWithLengthMoreThanFour = FilterLists.FindElements<string>(Names, FiltersOfList.CheckLengthMoreThanFour);

            //foreach (string item in NamesWithLengthMoreThanFour) Console.Write($"{item} ");
            //// Ahmed Khaled Rawan Youssef


            #endregion

            #region Built In Delegate [Func , Predicate , Action]

            //Action action1 = TestBuiltInDelegate.Print;
            //action1.Invoke(); // Hello Route
            //action1(); // Hello Route


            //Action<string> action2 = TestBuiltInDelegate.Print;
            //action2.Invoke("Omar"); // Hello Omar
            //action2("Omar");// Hello Omar


            //Func<int, string> func = TestBuiltInDelegate.Casting;
            //string Number = func.Invoke(10); // 10
            //Number = func(10); // 10

            //Predicate<int> predicate = TestBuiltInDelegate.CheckPositive;
            //bool Result = predicate.Invoke(10); // True 
            //Result = predicate(10); // True 

            #endregion

            #region Anonymous Method And Lambda Expression

            ////Action action1 = delegate { Console.WriteLine("Hello Route"); }; // Anonymous Method 
            //Action action1 = () => Console.WriteLine("Hello Route");  // Lambda Expression
            //action1.Invoke(); // Hello Route
            //action1(); // Hello Route

            ////Action<string> action2 = delegate (string name) { Console.WriteLine($"Hello {name}"); }; // Anonymous Method 
            //Action<string> action2 = name =>  Console.WriteLine($"Hello {name}"); // Lambda Expression
            //action2.Invoke("Omar"); // Hello Omar
            //action2("Omar");// Hello Omar


            ////Func<int, string> func = delegate (int number) { return number.ToString(); }; // Anonymous Method
            //Func<int, string> func = number => number.ToString();  // Lambda Expression 

            //string Number = func.Invoke(10); // 10
            //Number = func(10); // 10

            ////Predicate<int> predicate = delegate (int number) { return number > 0; }; // Anonymous Method 
            //Predicate<int> predicate = number => number > 0; // Lambda Expression 
            //bool Result = predicate.Invoke(10); // True 
            //Result = predicate(10); // True 

            #endregion

            #region Functional Programing Paradigm 

            //FunctionsReturnDelegate.Print(); // Hello Route

            //bool Result = FunctionsReturnDelegate.CheckPositive(10);
            //Console.WriteLine(Result); // true

            //string str = FunctionsReturnDelegate.ConvertToString(chars);
            //Console.WriteLine(str); // Route

            //FunctionsReturnDelegate.DelegateAction(); // Do Nothing 
            //Action action = FunctionsReturnDelegate.DelegateAction();
            //action.Invoke(); // Hello Route 
            //FunctionsReturnDelegate.DelegateAction().Invoke(); // Hello Route 
            //FunctionsReturnDelegate.DelegateAction()(); // Hello Route 


            //char[] chars = ['R', 'o', 'u', 't', 'e'];
            //Func<char[], string> func = FunctionsReturnDelegate.DelegateFunc();
            //string str = func.Invoke(chars); // Route
            //str = FunctionsReturnDelegate.DelegateFunc()(chars);


            //Predicate<int> predicate = FunctionsReturnDelegate.DelegatePredicate();
            //bool Flag = predicate.Invoke(-10); // False 
            //Console.WriteLine(predicate(-10)); // False
            //Console.WriteLine(FunctionsReturnDelegate.DelegatePredicate()(-10)); // False 

            #endregion

        }
    }
}

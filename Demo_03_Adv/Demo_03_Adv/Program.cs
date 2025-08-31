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

        }
    }
}

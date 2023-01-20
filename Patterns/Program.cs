public partial class Program
{
    public static void Main(string[] args)
    {
        Pattern03();
    }

    /// Pattern 01
    ////*
    /// **
    /// ***
    /// ****
    /// *****
    ///
    public static void Pattern01()
    {

        int rows = 5;
        char chr = '*';

        for (int i = 0; i < rows; i++)
        {
            string output = string.Empty;
            for (int j = 0; j < i + 1; j++)
            {
                output += chr;
            }
            Console.WriteLine(output);
        }
    }
    /// Pattern 02
    ////*****
    /// ****
    /// ***
    /// **
    /// *
    ///
    public static void Pattern02()
    {
        int rows = 10;
        for (int i = rows; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    /// Pattern 03
    ////    *  
    ///    ***
    ///   *****
    ///  ******* 
    /// ********* 
    ///*********** 
    ///
    public static void Pattern03()
    {
        int rows = 3;

        for (int i = 0; i < rows; i++)
        {
            for (int k = rows - 1 - i; k > 0; k--)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < (i + i) + 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}










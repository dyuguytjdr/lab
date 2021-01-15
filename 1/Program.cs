using System;

namespace Main 
{
    class Program 
    {
        public static void Main(string[] args)
        { 
            long num;
            int N = 59013;
            for (int i = 0; i < 16; i++)
            {
                string str = ConsApp_StrParsing.FuncAction(N * 10 + i); 
                bool result = Int64.TryParse(str, out num); 
                if (result) Console.WriteLine("str = {0}, num = {1}", str, num);
                else Console.WriteLine("str = {0}, num unknown", str);
            }
        }
    }
}
public class ConsApp_StrParsing
{
    public static string FuncAction(int n) 
    {
        string[] alphabet = {"0", "1", "2", "A", "3", "4", "5", "B",
                            "6", "7", "8", "C", "D", "E", "F", "9"};
        string str_ret = alphabet[n % 16] + alphabet[(n + 1) % 16];
        return str_ret; 
    }
}

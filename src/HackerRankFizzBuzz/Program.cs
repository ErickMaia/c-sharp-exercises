using System;

namespace HackerRankFizzBuzz
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.fizzBuzz(n);
        }
    }

    class Result
    {
        public static void fizzBuzz(int n)
        {

            if(n<1) return; 

            for(int i=1; i<=n; i++)
            {
                string result = "";
            
                if(i%3==0)
                {
                    result += "Fizz"; 
                }

                if(i%5==0)
                {
                    result += "Buzz"; 
                }

                if(result == "")
                {
                    result = i.ToString(); 
                }

                Console.WriteLine(result); 
            }

            
        }
    }
}

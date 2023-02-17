using RPGHeroes.Custom_Exceptions;
using System;

namespace RPGHeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestException(true);
            } catch(MyCustomException ex)
            {
                Console.WriteLine("Custom exception: " + ex.Message);
            } catch(Exception ex)
            {
                Console.WriteLine("Generic exception: " + ex.Message);
            }
        }

        public static void TestException(bool throwException)
        {
            if (throwException)
            {
                throw new MyCustomException();
            }

            throw new IndexOutOfRangeException();
        }
    }
}
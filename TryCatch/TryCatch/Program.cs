using System;
using System.IO;
using static System.Console;

namespace Namespace
{
    class Program
    {
        public static void ExecptionMethod()
        {
            throw new MethodAccessException();
        }
        static void Main(string[] args)
        {
            try
            {
                ExecptionMethod();
            }
            catch(MethodAccessException exception)
            {
                WriteLine(exception.Message);
            }
            ReadLine();
        }
    }
}

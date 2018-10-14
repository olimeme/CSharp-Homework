using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }

        private static void Task2()
        {
            var testClass = new TestReflectionClass();

            Type type = testClass.GetType();

            var fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var fieldInfo in fields)
                Console.WriteLine("{0}: {1}", fieldInfo.Name, fieldInfo.FieldType);

            Console.ReadLine();
        }

        private static void Task1()
        {
            Type type = typeof(Console);

            var fields = type.GetMethods();

            foreach (var field in fields)
                Console.WriteLine(field.Name + field.ReflectedType);

            Console.ReadLine();
        }
    }
}

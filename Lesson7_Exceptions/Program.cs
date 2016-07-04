using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            //throw new Exception("А мне захотелось");
            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    Console.WriteLine(number * number);
                    return;
                }
                catch (FormatException ex1)
                {
                    Console.WriteLine(ex1.Message);
                    Console.WriteLine("Вводить надо целые числа");
                }
                catch (OverflowException ex2)
                {
                    Console.WriteLine(ex2.Message);
                    Console.WriteLine("Вводить надо числа в диапазоне [{0}..{1}]", int.MinValue, int.MaxValue);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Попробуйте еще раз:");
                }
                finally
                {
                    Console.WriteLine("Надеемся, наша программа Вам понравилась :)");
                }
            }


        }
    }

    [Serializable]
    public class IWantThrowThisException : Exception
    {
        public IWantThrowThisException() { }
        public IWantThrowThisException(string message) : base(message) { }
        public IWantThrowThisException(string message, Exception inner) : base(message, inner) { }
        protected IWantThrowThisException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}

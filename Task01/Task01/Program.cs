using System;

namespace Task01
{
    class Program
    {
        static void Main()
        {
            //-------------------------------------------------------------------------------------
            LinearFunction lfun = new LinearFunction(); //используем конструктор по умолчанию
            OutputToConsole(50, lfun);

            //-------------------------------------------------------------------------------------
             lfun.A = 1; lfun.B = 2;  //возмем, для примера, любой другой частный случай
            OutputToConsole(50, lfun);

            //-------------------------------------------------------------------------------------
            LinearFunction lfun2 = new LinearFunction(5, 10); //используем специальный конструктор c передачей значений
            OutputToConsole(50, lfun2);

            Console.ReadKey();
         }

        public static void OutputToConsole(int k, LinearFunction lfun)
        {
            Console.WriteLine("Используем значения: а={0}, b={1}", lfun.A, lfun.B); //вывод значений на экран

            for (int i = 1; i < k; i++)
            {
                Console.Write(lfun.LFunction(i) + "; "); //вывод значений на экран
            }
            Console.WriteLine();
            Console.WriteLine("*************************************************************");
           

        }
        
    }
}
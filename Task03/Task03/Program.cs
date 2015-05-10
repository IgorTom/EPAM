using System;

namespace Task03
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значения длин сторон треугольника a,b,c");

            int a = InputOptions("a");
            int b = InputOptions("b");
            int c = InputOptions("c");

            try
            {
                // создание объекта
                Triangle objTriangle1 = new Triangle(a, b, c);

                if (objTriangle1.ValidationsTriangle(a, b, c))
                {
                  Console.WriteLine("Это треугольник.");
                    objTriangle1.TypeTriangle(a, b, c);
                }
                else
                {
                  Console.WriteLine("Это НЕ треугольник!!!");
                }


            }
            //исключение
            catch (Exception err)
            {
                //Пишем сообщение, хранящееся в исключении
                Console.WriteLine(err.Message);
            }

            finally
            {

                Console.Write("Нажмите любую клавишу для завершения программы.");
                Console.ReadKey();
                
            }
            


        }

        public static int InputOptions(string s)
        {
            int i=0;
            
            do
            {
                Console.Write("Введите значение {0}:", s);

                try
                {
                    i = Convert.ToInt32(Console.ReadLine());

                    if (i <= 0)
                    {
                        Console.WriteLine("Введено некорретное значение. Значение не может быть меньше либо равно нолю. Повторите ввод. ");
                    }

                }
                catch
                {
                    Console.WriteLine("Введённое значение не является числом. Повторите ввод.");
                }

                
                
            } while (i <= 0);

            return i;
        }

}
}
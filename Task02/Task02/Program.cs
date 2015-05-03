using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {   
            const int sizeArray = 10; //длинна массива 

            Item[] ArrayList = new Item[sizeArray]; //массив

            
            Random random;  //генератор случайных чисел
            random = new Random();

            for (int i = 0; i < sizeArray; i++)
            {
               ArrayList[i] = new Item("Товар №" + i.ToString(), random.Next(1, 1000000), random.Next(1, 1000)); //заполнение массива

            }

            for (int i = 0; i < sizeArray; i++)
            {
                Console.WriteLine( "Название товара: {0}, Цена: {1}, Кол-во: {2}, Общая стоимость: {3}", ArrayList[i].ProduktName, ArrayList[i].UnitPrice, ArrayList[i].Quantity, ArrayList[i].PriceAllGoods);
            }

            Console.ReadKey();

        }
    }
}

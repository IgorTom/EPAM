using System;
using System.Linq;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {   
            const int sizeArray = 100000; //длинна массива 

            Item[] ArrayList = new Item[sizeArray]; //массив

            
            Random random;  //генератор случайных чисел
            random = new Random();

            decimal checksum =0 ;
            
            for (int i = 0; i < sizeArray; i++)
            {
               ArrayList[i] = new Item("Товар №" + i.ToString(),Convert.ToDecimal(random.Next(1,10000000)), Convert.ToUInt32(random.Next(1,1000))); //заполнение массива

               checksum += ArrayList[i].UnitPrice*ArrayList[i].Quantity;
               
            }

            //for (int i = 0; i < sizeArray; i++)
            //{
            //    Console.WriteLine("Название товара: {0}, Цена: {1}, Кол-во: {2}, Общая стоимость: {3}", ArrayList[i].ProduktName, ArrayList[i].UnitPrice, ArrayList[i].Quantity, ArrayList[i].PriceAllGoods);
            //}


            decimal sum = 0;
            for (int i = 0; i < sizeArray; i++)
            {
                sum += ArrayList[i].PriceAllGoods;
            }

            Console.WriteLine("checksum: {0}", checksum);
            
            Console.WriteLine("Сумма всех стоимостей товаров: {0}", sum);

            //ArrayList.Sum();


            Console.ReadKey();

        }
    }
}

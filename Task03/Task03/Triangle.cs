using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Triangle
    {
        private int a, b, c; // поля данных
        
        // свойство полей
        public int A
        {
            get { return a;  } 
            set { a = value; }  
            
        }

        public int B
        {
            get { return b;  } 
            set { b = value; }  
            
        }

        public int C
        {
            get { return c;  } 
            set { c = value; }  
            
        }

        //public Triangle()    //конструктор по умолчанию 
        //{
        //    A = 0; B = 0; C = 0;
        //}

        public Triangle(int a, int b, int c) //конструктор с параметарми
        {
            A = a;
            B = b;
            C = c;
        }

        public bool ValidationsTriangle(int a, int b, int c) //  метод проверки: является ли фигура с заданными параметрами треугольником
        {
            if ((a > 0) && (b > 0) && (c > 0))
            {
                //В невырожденном треугольнике сумма длин двух его сторон больше длины третьей стороны, в вырожденном — равна. 
                //Иначе говоря, длины сторон треугольника связаны следующими неравенствами: a < b+c; b < c+a; c < a+b.
                if ((a < b + c) && (b < c + a) && (c < a + b))   //возвращаем true, иначе false
                {
                    return true;
                }
                
            }
            return false;
        }

        public void TypeTriangle(int a, int b, int c)
        {
            //если h - максимальная из длин сторон a,b,c, a k,l -- длины двух других сторон, то треугольник будет:
            //прямоугольным при h^2 = k^2 + l^2, 
            //остроугольным при h^2 < k^2 + l^2,
            //тупоугольным при  h^2 > k^2 + l^2.
            int i1, i2;

            if (a > b && a > c)
            {
                i1 = a*a;
                i2 = b*b + c*c;
                
            }else if(b > a && b > c)
            {
                i1 = b*b;
                i2 = a*a + c*c;
                
            }else if (c > a && c > b)
            {
                i1 = c*c;
                i2 = a*a + b*b;
            }
            else //все стороны равны
            {
                i1 = a*a;
                i2 = b*b + c*c;
            }

            if ((a == b) || (a == c) || (b == c))
            {
                Console.WriteLine("Треугольник равнобедренный.");
            }
            else if ((a == b) && (a == c) && (b == c))
            {
                Console.WriteLine("Треугольник равносторонний.");
            }


            if (i1 == i2)
            {
                Console.WriteLine("Треугольник прямоугольный.");
            }
            else if (i1<i2)
            {
                Console.WriteLine("Треугольник остроугоный.");
            }
            else // (i1>i2)
            {
                Console.WriteLine("Треугольник тупоугольный.");
            }
            

        }

    }
}

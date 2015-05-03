using System;


namespace Task01
{
    public class LinearFunction
    {
        private double a; // поле данных
        private double b; // поле данных

        public double A // свойство для поля a
        {
            get { return a; }
            set { a = value; } 
        }

        public double B // свойство для поля b
        {
            get { return b; }
            set { b = value; } 
        }

        public LinearFunction() //конструктор по умолчанию
        {
            A = 0;
            B = 0;
        }

        public LinearFunction(double a, double b) //конструктор с параметарми
        {
            A = a;
            B = b;
        }
            
        public double LFunction(double x) // метод
        {
            return A * x + B; // линейная функция вида f(x)=a * x + b
        }

        
    }
}

using System;

namespace Task02
{
    class Item
    {
        private string produktName; //наименование тоовара
        private int unitPrice; // цена за еденицу товара
        private int quantity; // колличество товара
        private int priceAllGoods; // цена всего=цена за еденицу тов.*кол-во

        public int PriceAllGoods 
        {
            get { return priceAllGoods; }
        } 

        public string ProduktName //свойство
        {
            get { return produktName;}
            set { produktName = value; }
        }

        public int UnitPrice //свойство
        {
            get {return unitPrice; }
            set {if (unitPrice >= 0) {unitPrice = value;} else{unitPrice = 0;}} 
        }

        public int Quantity //свойство
        {
            get { return quantity; }
            set { if (quantity >= 0) { quantity = value; } else { quantity = 0; } }
        }

        public Item() //конструктор по умолчанию
        {
            ProduktName = "без наименования";
            UnitPrice = 0;
            Quantity = 1;
            priceAllGoods = 0;
        }

        public Item(string produktName, int unitPrice, int quantity) //конструктор с параметрами
        {
            ProduktName = produktName;
            UnitPrice = unitPrice;
            Quantity = quantity;
            priceAllGoods = PriceOfAllGoods();
        }

        // МЕТОД (выполняется расчет цены всего товара; цена=цена за еденицу тов.*кол-во)
        public int PriceOfAllGoods()
        { 
            return UnitPrice * Quantity;
        } 

        
    }
}

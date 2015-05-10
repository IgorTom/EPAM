using System;

namespace Task02
{
    class Item
    {
        private string produktName; //наименование товара
        private decimal unitPrice; // цена за еденицу товара
        private uint quantity; // колличество товара
        private decimal priceAllGoods; // цена всего=цена за еденицу тов.*кол-во

        public decimal PriceAllGoods 
        {
            get { return priceAllGoods; }
        } 

        public string ProduktName //свойство
        {
            get { return produktName;}
            set { produktName = value; }
        }

        public decimal UnitPrice //свойство
        {
            get {return unitPrice; }
            set {if (unitPrice >= 0) {unitPrice = value;} else{unitPrice = 0;}} 
        }

        public uint Quantity //свойство
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

        public Item(string produktName, decimal unitPrice, uint quantity) //конструктор с параметрами
        {
            ProduktName = produktName;
            UnitPrice = unitPrice;
            Quantity = quantity;
            priceAllGoods = PriceOfAllGoods();
        }

        // МЕТОД (выполняется расчет цены всего товара; цена=цена за еденицу тов.*кол-во)
        public decimal PriceOfAllGoods()
        { 
            return UnitPrice * Quantity;
        } 

        
    }
}

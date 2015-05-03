using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    public class Goods : IGoodsItem
    {
        public DateTime DateReceipt { get; set; } // дата получения товара
        public string ProduktName { get; set; }  //наименование товара
        public string BrandName { get; set; } // производитель
        public Decimal  UnitPrice { get; set; } // цена за еденицу товара 
        public int Quantity { get; set; } // колличество товара
        public Decimal PriceAllGoods { get; set; } // цена всего=цена за еденицу тов.*кол-во
    }
}

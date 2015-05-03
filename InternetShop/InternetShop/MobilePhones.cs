using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    class MobilePhones : DeviceWithScreen, IMobilePhonesItem
    {
        public Byte SIMCardQuantity { get; set; } // кол-во сим-карт
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    class DeviceWithScreen : Goods, IDeviceWithScreenItem
    {
        public float DisplaySize { get; set; } //размер экрана
        public string DisplayType { get; set; } //тип экрана
        public ushort Length { get; set; } //длинна
        public ushort Width  { get; set; } //ширина
        public ushort Thickness { get; set; } //толщина
    }
}

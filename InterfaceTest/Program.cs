using System;

namespace InterfaceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var toshiba = new Microwave();
            toshiba.Start(HotMode.hightMode);            
            toshiba.TimeCook(5);
            toshiba.Cook(new Fastfood());
            toshiba.Cook(new Apple());
            toshiba.Cook(new Fish());
            toshiba.Stop();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    interface IMenu
    {
        void Start(HotMode hot);
        void Stop();
        int TimeCook(int time);
        void Cook(Food food);
    }
    enum HotMode
    { 
        lowMode = 1,
        middleMode = 2,
        hightMode = 3
    }
}

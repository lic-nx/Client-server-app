using System;
using System.Collections.Generic;
using System.Text;
namespace RemoteHello
{
    public class Hello : MarshalByRefObject
    {
        public Hello()
        {
            Console.WriteLine("Объект Hello создан");
        }
        ~Hello()
        {
            Console.WriteLine("Объект Hello уничтожен");
        }
        public string Greeting(string name)
        {
            Console.WriteLine("Метод Greeting вызван");
            return "Приветствую Вас, " + name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemoteHello;
namespace HelloServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание канала
            TcpServerChannel channel = new TcpServerChannel(8086);
            //Регистация канала
            ChannelServices.RegisterChannel(channel, false);
            //Регистрация хорошо известного объекта
            RemotingConfiguration.RegisterWellKnownServiceType(
            typeof(Hello),
            "Hi",
            WellKnownObjectMode.SingleCall);
            Console.WriteLine("Сервер работает");
            Console.WriteLine("Нажмите Enter для выхода");
            Console.ReadLine();//Удерживаем сервер в рабочем состоянии
        }
    }
}

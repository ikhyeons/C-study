using System;

namespace InterfaceDemo
{
    interface IBattery
    {
        string GetName();
    }
    class Good : IBattery
    {
        public string GetName() => "good";
    }
    class Bad : IBattery {
        public string GetName() => "bad";
    }
    class Car
    {
        private IBattery _battery;
        public Car(IBattery battery)
        {
            _battery = battery;
        }

        public void Run() => Console.WriteLine(
            "{0}배터리를 장착한 자동차가 달립니다.", _battery.GetName());
    }

    class InterfaceDemo
    {
        static void Main(string[] args)
        {
            var good = new Car(new Good()); good.Run();
            new Car(new Bad()).Run();
        }
    }
}

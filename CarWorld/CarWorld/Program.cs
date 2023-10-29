using System;
using System.Collections;

namespace CarWorld
{
    interface IStandard { void Run(); }

    class Car : IStandard
    {
        #region [4] 필드 : private Member Variables
        private string name;
        private string[] names;
        private readonly int _Length;
        #endregion

        #region [5] 생성자 : Constructors
        public Car()
        {
            this.name = "좋은 차";
        }
        public Car(string name)
        {
            this.name = name;
        }
        public Car(int length)
        {
            this.name = "좋은 차";
            _Length = length;
            names = new string[length];
        }
        #endregion

        #region [6] 메서드 : Public Methods
        public void Run() => Console.WriteLine("{0} 자동차가 달립니다.", name);
        #endregion

        #region [7] 속성 : Public Properties
        public string Name { get { return name; } set { name = value; } }
        public int Length { get { return _Length; } }
        #endregion

        #region [8] 소멸자 : Destructor
        ~Car() {
            Console.WriteLine("{0} 자동차가 폐차됨.", name);
        }
        #endregion

        #region [9] 인덱서 : Indexer
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        #endregion

        #region [10] 이터레이터 : Iterators
        public IEnumerator GetEnumerator()
        {
            for (int i = 0;i<_Length;i++)
            {
                yield return names[i];
            }
        }
        #endregion

        #region [11] 대리자 : Public Delegates
        public delegate void EventHandler();
        #endregion

        #region [12] 이벤트 : Public Events
        public event EventHandler Click;
        #endregion

        #region [13] 이벤트 처리기 : Event Handlers
        public void OnClick()
        {
            if(Click != null)
            {
                Click();
            }
        }
        #endregion
    }

    class CarWorld
    {
        static void Main()
        {
            Car campingCar = new Car("캠핑카");
            campingCar.Run();

            Car sportsCar = new Car();
            sportsCar.Name = "스포츠 카";
            sportsCar.Run();

            Car cars = new Car(2);
            cars[0] = "1번 자동차";
            cars[1] = "2번 자동차";
            for(int i = 0; i< cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            foreach(string name in cars)
            {
                Console.WriteLine(name);
            }

            Car btn = new Car("전기 자동차");
            btn.Click += new Car.EventHandler(btn.Run);
            btn.Click += new Car.EventHandler(btn.Run);
            btn.OnClick();
        }
    }
}

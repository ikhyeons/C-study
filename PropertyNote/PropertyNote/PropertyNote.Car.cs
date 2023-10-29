using System;

namespace PropertyNote
{
    public class Car
    {
        public static string Color;
        private static string _Type;
        public static string Type {  get { return _Type;} set { _Type = value; } }

        static Car()
        {
            Color = "Red";
            _Type = "스포츠카";
        }
    }
}

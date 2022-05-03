using System;
namespace Inheritance
{
    public class Bird : Animals
    {
        public Bird()
        {
        }

        public int WingSpan { get; set; }
        public string BeackColor { get; set; }
        public bool DoesSing { get; set; }
        public bool DoesFly { get; set; }


    }
}

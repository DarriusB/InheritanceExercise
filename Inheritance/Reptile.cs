using System;
namespace Inheritance
{
    public class Reptile : Animals
    {
        public Reptile()
        {
        }

        public string ReptileClass { get; set; }
        public bool HasLaidEggs { get; set; }
        public bool HasScutes { get; set; }
        public bool HasScales { get; set; }


    }
}

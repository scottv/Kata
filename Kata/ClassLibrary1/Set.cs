using System;

namespace ClassLibrary1
{
    public class Set
    {
        public object[] OurSet = new object[10];

        public object this[int index]
        {
            get { return OurSet[index]; }
        }
        
        public void Add(object item)
        {
            OurSet[0] = item;
        }
    }
}
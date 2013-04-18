using System;

namespace ClassLibrary1
{
    public class Set
    {
        private readonly object[] _ourSet;

        public Set()
        {
            _ourSet = new object[10];
        }

        public void Add(object item)
        {
            _ourSet[0] = item;
        }

    }
}


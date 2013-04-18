using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture()]
    public class SetTests
    {
        [Test()]
        public void CanAddAnItemToSet()
        {
            Set monkey = new Set();
            
            Assert.DoesNotThrow(()=>monkey.Add("1"));
    
        }
    }
}

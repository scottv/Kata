﻿using ClassLibrary1;
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
    
        [Test()]
        public void SetContainsValuePassedIn()
        {
            Set one = new Set();
            one.Add("1");

            Assert.That(one[0], Is.EqualTo("1"));

        }    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace ClassLibrary4
{
    public class PredicateMethods
    {
        public static bool GreaterThanThree(int x)
        {
            return x > 3;
        }
    }

    [TestFixture]
    public class PredicateTests
    {
        [Test]
        public void TestUsingStandardLinq()
        {
            var myList = new List<int>();
            myList.AddRange(new [] { 1, 2, 3, 4, 5 });
            
            var result = myList.Where(x => x > 3);
            
            Assert.That(result.Count(), Is.EqualTo(2));
        }

        [Test]
        public void TestUsingPredicate()
        {
            var myList = new List<int>();
            myList.AddRange(new[] { 1, 2, 3, 4, 5 });
            
            var result = myList.Where(PredicateMethods.GreaterThanThree);

            Assert.That(result.Count(), Is.EqualTo(2));
        }

        [Test]
        public void TestUsingPredicate2()
        {
            var myList = new List<int>();
            myList.AddRange(new[] { 1, 2, 3, 4, 5 });
            Predicate<int> predicate = PredicateMethods.GreaterThanThree;
            
            var result = myList.Where(predicate.Invoke);

            Assert.That(result.Count(), Is.EqualTo(2));
        }

        [Test]
        public void TestUsingPredicate3()
        {
            var myList = new List<int>();
            myList.AddRange(new[] { 1, 2, 3, 4, 5 });
            
            var result = myList.Where(delegate(int i)
            {
                return i > 3;
            });

            Assert.That(result.Count(), Is.EqualTo(2));
        }
    }
}

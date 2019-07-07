using NUnit.Framework;

using System;
using FizzBuzzDojo;

namespace Tests
{
    public class Tests
    {
        private FizzBuzz fizzbuzz;

        [SetUp]
        public void Setup()
        {
            fizzbuzz = new FizzBuzz();
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(7)]
        [TestCase(8)]
        public void Test_NotDivisibleByThreeOrFive(int input)
        {
            string output = fizzbuzz.Get(input);

            Assert.AreEqual(input.ToString(), output);
        }


        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void Test_DivisibleByThree(int input)
        {
            string output = fizzbuzz.Get(input);

            Assert.AreEqual("Fizz", output);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(50)]
        [TestCase(55)]
        public void Test_DivisibleByFive(int input)
        {
            string output = fizzbuzz.Get(input);

            Assert.AreEqual("Buzz", output);
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(60)]
        [TestCase(90)]
        public void Test_DivisibleByThreeAndFive(int input)
        {
            string output = fizzbuzz.Get(input);

            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
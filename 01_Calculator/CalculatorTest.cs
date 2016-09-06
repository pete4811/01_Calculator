using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Calculator
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add()  /* jeg har skrevet i første tab, definitionen på "ADD" */
        {
            Assert.AreEqual(0, Calculator.Add(0, 0));
            Assert.AreEqual(4, Calculator.Add(2, 2));
            Assert.AreEqual(8, Calculator.Add(2, 6));
        }
        [TestMethod]
        public void Subtract()  /* jeg har skrevet i første tab, definitionen på "SUBTRACT" */
        {
            Assert.AreEqual(6, Calculator.Subtract(10, 4));
        }
        [TestMethod]
        public void Sum()  /* jeg har skrevet i første tab, definitionen på "SUM" */
        {
            //Arrange
            int[] numbers = new int[2] {0,0,};
            Assert.AreEqual(0, Calculator.Sum(numbers));

            numbers[0] = 7;
            Assert.AreEqual(7, Calculator.Sum(numbers));

            numbers[0] = 7;
            numbers[1] = 11;
            Assert.AreEqual(18, Calculator.Sum(numbers));

        }
        [TestMethod]
        public void Multiply()  /* jeg har skrevet i første tab, definitionen på "MULTIPLY" */
        {
            //It multiplies two numbers
            //It multiplies several numbers
        }
        [TestMethod]
        public void Divide()  /* jeg har skrevet i første tab, definitionen på "DIVIDE" */
        {
            //It divides two numbers
            //It divides several numbers
        }
        [TestMethod]
        public void Power()  /* jeg har skrevet i første tab, definitionen på "POWER" */
        {
            Assert.AreEqual(4, Calculator.Power(2, 2));
            Assert.AreEqual(10000000000, Calculator.Power(10, 10));
            //It raises one number to the power of another number /*det er fx 2^2 = 4 eller 3^3 = 27 */
        }
        [TestMethod]
        public void Factorial()
        {
            Assert.AreEqual(120, Calculator.Factorial(5));
            //# http://en.wikipedia.org/wiki/Factorial
            //  it "computes the factorial of 0"
            //  it "computes the factorial of 1"
            //  it "computes the factorial of 2"
            //  it "computes the factorial of 5"
            //  it "computes the factorial of 10"
        }
    }
}

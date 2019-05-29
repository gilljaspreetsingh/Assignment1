using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApp19;

namespace RectangleTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void GetLength_Input100_Returns100()
        {

            //Arrange
            int length = 100;
            int width = 10;

            int expectedResult = length;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetLength();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetWidth_Input40_Returns40()
        {

            //Arrange
            int length = 10;
            int width = 40;

            int expectedResult = width;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetWidth();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetLength_Input15_Returns15()
        {

            //Arrange
            int length = 15;
            int width = 12;

            int expectedResult = length;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.SetLength(length);

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Setwidth_Input20_Returns20()
        {

            //Arrange
            int length = 115;
            int width = 20;

            int expectedResult = width;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.SetWidth(length);

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetPerimeter_Input_Length15And_Width15_Returns60()
        {

            //Arrange
            int length = 15;
            int width = 15;

            int expectedResult = 2 * (length + width);

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetPerimeter();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Input_Length5And_Width5_Returns25()
        {

            //Arrange
            int length = 5;
            int width = 5;

            int expectedResult = (length * width);

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetArea();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzzTest
{
    [TestFixture]
     public class FizzBuzzTest
    {
        private Multiplos numero { get; set; }

        [SetUp]
         public void InstanciarAntesDeCadaTest()
        {
            //arrange
            numero = new Multiplos();
        }
        [Test]
        public void Mostrar1()
        {
            //arrange
           
            //act
            var multiplo = numero.Multiplo(1);

            //
            Assert.AreEqual("1", multiplo);

        }

        [Test]
        public void Mostrar3()
        {
            //arrange
            
            //act
            var multiplo = numero.Multiplo(3);

            //
            Assert.AreEqual("Fizz", multiplo);

        }
        [Test]
        public void Mostrar5()
        {
            //arrange
           
            //act
            var multiplo = numero.Multiplo(5);

            //
            Assert.AreEqual("Buzz", multiplo);

        }

        [Test]
        public void Mostrar15()
        {
            //arrange
            
            //act
            var multiplo = numero.Multiplo(15);

            //
            Assert.AreEqual("FizzBuzz", multiplo);

        }
        [Test]
        public void Mostrar6()
        {
            //arrange
            var numero = new Multiplos();

            //act
            var multiplo = numero.Multiplo(6);

            //
            Assert.AreEqual("Fizz", multiplo);

        }
    }
}

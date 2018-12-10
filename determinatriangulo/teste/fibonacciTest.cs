using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    [TestFixture]
    class fibonacciTest
    {
        fibonacci f = new fibonacci();

        [TestCase]
        public void ninvalido()
        {
            Assert.AreEqual("n deve ser positivo", f.pegarfibonacci(-1));
        }

        [TestCase]
        public void ok()
        {
            Assert.AreEqual("1 1 2 3 5 ", f.pegarfibonacci(5));
        }

    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{

    [TestFixture]
    class determinatrianguloTest
    {
        determinatriangulo dt = new determinatriangulo();

        [TestCase]
        public void escaleno()
        {
          
            Assert.AreEqual("ESCALENO", dt.tipo(2, 3, 4));
        }

        [TestCase]
        public void inexistente()
        {
            Assert.AreEqual("INEXISTENTE", dt.tipo(0, 0, 0));
        }


        [TestCase]
        public void isosceles()
        {
            Assert.AreEqual("ISOSCELES", dt.tipo(1, 2, 2));
        }

    }
}

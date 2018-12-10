using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste;

namespace determinatriangulo
{
    [TestFixture]
    class cadeiacaracteresTest
    {
        cadeiacaracteres cc = new cadeiacaracteres();

        [TestCase]
        public void naoachou()
        {
            Assert.AreEqual("erro: não encontrado", cc.buscar("gcd", 'h'));
        }


        [TestCase]
        public void achou()
        {
            Assert.AreEqual("1", cc.buscar("abc", 'b'));
        }

       
        [TestCase]
        public void invalido()
        {
            Assert.AreEqual("erro: caractere inválido", cc.buscar("dc", ' '));
        }
    }
}

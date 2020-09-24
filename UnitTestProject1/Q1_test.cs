using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercicio_1;

namespace Testes
{
    [TestClass]
    public class Q1_test
    {
        [TestMethod]
        public void getFamily()
        {
            Q1 teste = new Q1();
            teste.getNumberFamily(553);
        }

    }
}

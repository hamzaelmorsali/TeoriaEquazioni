using System;
using EquazioniLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsDetermined()
        {
            double a = 3;
            bool respattesa = true, resp = Equazioni.IsDetermined(a);
            Assert.AreEqual(respattesa, resp);

        }
    }
}

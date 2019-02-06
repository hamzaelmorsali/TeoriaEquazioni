using System;
using EquazioniLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Equazioni_Library_tests
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
        [TestMethod]
        public void TestIsDetermined1()
        {
            double a = 3;
            bool respattesa = true, resp = Equazioni.IsDetermined(a);
            Assert.AreEqual(respattesa, resp);

        }
        [TestMethod]
        public void TestIsDetermined2()
        {
            double a = 3;
            bool respattesa = true, resp = Equazioni.IsDetermined(a);
            Assert.AreEqual(respattesa, resp);

        }
        public void TestIsIndetermined()
        {
            double a = 3;
            bool respattesa = true, resp = Equazioni.IsIndetermined(a,b);
            Assert.AreEqual(respattesa, resp);

        }

    }
}

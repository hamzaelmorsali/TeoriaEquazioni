﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary_test
{
    [TestClass]
    public class Equazioni_test
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
            double a = 0;
            bool respattesa = false, resp = Equazioni.IsDetermined(a);
            Assert.AreEqual(respattesa, resp);

        }
        [TestMethod]
        public void TestIsDetermined2()
        {
            double a = -2;
            bool respattesa = true, resp = Equazioni.IsDetermined(a);
            Assert.AreEqual(respattesa, resp);
        }
        [TestMethod]
        public void TestIsDetermined3()
        {
            double b = -2, a = 0;
            bool respattesa = false, resp = Equazioni.IsImpossible(a,b);
            Assert.AreEqual(respattesa, resp);
        }
    }
}
    


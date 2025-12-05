using Microsoft.VisualStudio.TestTools.UnitTesting;
using habilitations2024.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024.model.Tests
{
    [TestClass()]
    public class AdminTests
    {
        private const string nom = "Fravier";
        private const string prenom = "Laurent";
        private const string pwd = "fezfsqsd";
        private static readonly Admin ad = new Admin(nom, prenom, pwd);

        [TestMethod()]
        public void AdminTest()
        {
            Assert.AreEqual(nom, ad.Nom, "devrait réussir : nom valorisé");
            Assert.AreEqual(prenom, ad.Prenom, "devrait réussir : prenom valorisé");
            Assert.AreEqual(pwd, ad.Pwd, "devrait réussir : Pwd valorisé");
        }
    }
}
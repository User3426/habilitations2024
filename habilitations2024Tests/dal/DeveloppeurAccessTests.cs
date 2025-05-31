using Microsoft.VisualStudio.TestTools.UnitTesting;
using habilitations2024.dal;
using habilitations2024.model;
using habilitations2024.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024.dal.Tests
{
    [TestClass()]
    public class DeveloppeurAccessTests
    {
        private DeveloppeurAccess developpeurAccess;

        [TestMethod()]
        public void GetLesDeveloppeursTest()
        {
            developpeurAccess = new DeveloppeurAccess();

            int idProfil = 3;
            int attendu = 4;
            List<Developpeur> resultat = developpeurAccess.GetLesDeveloppeurs(idProfil);
            Assert.AreEqual(attendu, resultat.Count);

        }
    }
}
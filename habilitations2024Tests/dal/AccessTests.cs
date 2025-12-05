using Microsoft.VisualStudio.TestTools.UnitTesting;
using habilitations2024.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024.dal.Tests
{
    [TestClass()]
    public class AccessTests
    {
        private static readonly Access access = Access.GetInstance();

        [TestMethod()]
        public void GetInstanceTest()
        {
            Assert.IsNotNull(access, "devrait réussir si la connexion à la BDD est correcte");
        }
    }
}
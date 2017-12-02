using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BiblioTechProject.BLL;
using BiblioTechProject.Entidades;
using System.Collections.Generic;

namespace BiblioTechUnitTestProject
{
    [TestClass]
    public class ClienteBLLUnitTest
    {
        [TestMethod]
        public void Guardar()
        {
            Assert.IsTrue(ClienteBLL.Guardar(new Cliente()));
        }

        [TestMethod]
        public void Buscar()
        {
            Assert.IsNotNull(ClienteBLL.Buscar(A => A.ClienteId == 3));
        }

        [TestMethod]
        public void Eliminar()
        {
            Cliente cliente = ClienteBLL.Buscar(A => A.ClienteId == 1);
            Assert.IsTrue(ClienteBLL.Eliminar(cliente));
        }

        [TestMethod]
        public void GetList()
        {
            Assert.IsNotNull(ClienteBLL.GetList(A => A.ClienteId > 0));
        }
    }
}

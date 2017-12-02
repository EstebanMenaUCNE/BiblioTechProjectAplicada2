using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BiblioTechProject.BLL;
using BiblioTechProject.Entidades;
using System.Collections.Generic;

namespace BiblioTechUnitTestProject
{
    [TestClass]
    public class EditorialBLLUnitTest
    {
        [TestMethod]
        public void Guardar()
        {
            Assert.IsTrue(EditorialBLL.Guardar(new Editorial()));
        }

        [TestMethod]
        public void Buscar()
        {
            Assert.IsNotNull(EditorialBLL.Buscar(A => A.EditorialId == 1));
        }

        [TestMethod]
        public void Eliminar()
        {
            Editorial editorial = EditorialBLL.Buscar(A => A.EditorialId == 4);
            Assert.IsTrue(EditorialBLL.Eliminar(editorial));
        }

        [TestMethod]
        public void GetList()
        {
            Assert.IsNotNull(EditorialBLL.GetList(A => A.EditorialId > 0));
        }
    }
}

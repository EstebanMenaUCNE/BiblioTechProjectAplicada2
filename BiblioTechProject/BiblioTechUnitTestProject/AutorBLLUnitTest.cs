using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BiblioTechProject.BLL;
using BiblioTechProject.Entidades;
using System.Collections.Generic;

namespace BiblioTechUnitTestProject
{
    [TestClass]
    public class AutorBLLUnitTest
    {
        [TestMethod]
        public void Guardar()
        {
            Assert.IsTrue(AutorBLL.Guardar(new Autor(), new List<AutorLibro>()));
        }

        [TestMethod]
        public void Buscar()
        {
            Assert.IsNotNull(AutorBLL.Buscar(A => A.AutorId == 1));
        }

        [TestMethod]
        public void Eliminar()
        {
            Autor autor = AutorBLL.Buscar(A => A.AutorId == 4);
            Assert.IsTrue(AutorBLL.Eliminar(autor));
        }

        [TestMethod]
        public void GetList()
        {
            Assert.IsNotNull(AutorBLL.GetList(A => A.AutorId > 0));
        }
    }
}

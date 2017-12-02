using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BiblioTechProject.BLL;
using BiblioTechProject.Entidades;
using System.Collections.Generic;

namespace BiblioTechUnitTestProject
{
    [TestClass]
    public class PrestamoBLLUnitTest
    {
        [TestMethod]
        public void Guardar()
        {
            Assert.IsTrue(PrestamoBLL.Guardar(new Prestamo(0, DateTime.Today, DateTime.Today, DateTime.Today, "Devuelto", 3), new List<PrestamoLibro>(), false));
        }

        [TestMethod]
        public void Buscar()
        {
            Assert.IsNotNull(PrestamoBLL.Buscar(A => A.PrestamoId == 12));
        }

        [TestMethod]
        public void Eliminar()
        {
            Prestamo prestamo = PrestamoBLL.Buscar(A => A.PrestamoId == 28);
            Assert.IsTrue(PrestamoBLL.Eliminar(prestamo));
        }

        [TestMethod]
        public void GetList()
        {
            Assert.IsNotNull(PrestamoBLL.GetList(A => A.PrestamoId > 0));
        }
    }
}

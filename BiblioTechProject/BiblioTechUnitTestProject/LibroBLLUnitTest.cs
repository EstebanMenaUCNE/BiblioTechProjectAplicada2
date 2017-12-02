using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BiblioTechProject.BLL;
using BiblioTechProject.Entidades;
using System.Collections.Generic;

namespace BiblioTechUnitTestProject
{
    [TestClass]
    public class LibroBLLUnitTest
    {
        [TestMethod]
        public void Guardar()
        {
            Assert.IsTrue(LibroBLL.Guardar(new Libro(0, "", 0, "Disponible", 1), new List<AutorLibro>(), false));
        }

        [TestMethod]
        public void Buscar()
        {
            Assert.IsNotNull(LibroBLL.Buscar(A => A.LibroId == 8));
        }

        [TestMethod]
        public void Eliminar()
        {
            Libro libro = LibroBLL.Buscar(A => A.LibroId == 8);
            Assert.IsTrue(LibroBLL.Eliminar(libro));
        }

        [TestMethod]
        public void GetList()
        {
            Assert.IsNotNull(LibroBLL.GetList(A => A.LibroId > 0));
        }
    }
}

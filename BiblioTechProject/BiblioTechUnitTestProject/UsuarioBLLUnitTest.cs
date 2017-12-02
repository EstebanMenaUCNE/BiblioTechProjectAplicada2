using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BiblioTechProject.BLL;
using BiblioTechProject.Entidades;
using System.Collections.Generic;

namespace BiblioTechUnitTestProject
{
    [TestClass]
    public class UsuarioBLLUnitTest
    {
        [TestMethod]
        public void Guardar()
        {
            Assert.IsTrue(UsuarioBLL.Guardar(new Usuario()));
        }

        [TestMethod]
        public void Buscar()
        {
            Assert.IsNotNull(UsuarioBLL.Buscar(A => A.UsuarioId == 1));
        }

        [TestMethod]
        public void Eliminar()
        {
            Usuario usuario = UsuarioBLL.Buscar(A => A.UsuarioId == 3);
            Assert.IsTrue(UsuarioBLL.Eliminar(usuario));
        }

        [TestMethod]
        public void GetList()
        {
            Assert.IsNotNull(UsuarioBLL.GetList(A => A.UsuarioId > 0));
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void RepositorioBaseTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RepositorioBaseTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Pacientes> repositorio = new RepositorioBase<Pacientes>();
            Pacientes pacientes = new Pacientes();
            pacientes.PacienteId = 0;
            pacientes.Nombres = "Juan";
            pacientes.Direccion = "ffdfddf";
            pacientes.SeguroDeVida = "dfdfdfd";
            pacientes.Cedula = "dfdfdfdf";
            pacientes.Balance = 100;
            pacientes.Usuarioid = 1;
            pacientes.Telefono = "809-963-8963";
            pacientes.Celular = "809-963-7845";
            pacientes.Email = "sfdfdf@";
            pacientes.Fecha = DateTime.Now;
            Assert.IsTrue(repositorio.Guardar(pacientes));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Pacientes> repositorio = new RepositorioBase<Pacientes>();
            Pacientes pacientes = new Pacientes();
            pacientes.PacienteId = 1;
            pacientes.Nombres = "Juan";
            pacientes.Direccion = "ffdfddf";
            pacientes.SeguroDeVida = "dfdfdfd";
            pacientes.Cedula = "dfdfdfdf";
            pacientes.Balance = 100;
            pacientes.Usuarioid = 1;
            pacientes.Telefono = "809-963-8963";
            pacientes.Celular = "809-963-7845";
            pacientes.Email = "sfdfdf@";
            pacientes.Fecha = DateTime.Now;
            Assert.IsTrue(repositorio.Modificar(pacientes));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Pacientes> repositorio = new RepositorioBase<Pacientes>();
            Pacientes pacientes = new Pacientes();
            pacientes.PacienteId = 1;
            pacientes.Nombres = "Juan";
            pacientes.Direccion = "ffdfddf";
            pacientes.SeguroDeVida = "dfdfdfd";
            pacientes.Cedula = "dfdfdfdf";
            pacientes.Balance = 100;
            pacientes.Usuarioid = 1;
            pacientes.Telefono = "809-963-8963";
            pacientes.Celular = "809-963-7845";
            pacientes.Email = "sfdfdf@";
            pacientes.Fecha = DateTime.Now;
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Pacientes> repositorio = new RepositorioBase<Pacientes>();
            Assert.IsNotNull(repositorio.Buscar(2));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Pacientes> repositorio = new RepositorioBase<Pacientes>();
            Assert.IsNotNull(repositorio.GetList(p=>true));
        }

        [TestMethod()]
        public void DisposeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RepositorioBaseTest2()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RepositorioBaseTest3()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GuardarTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ModificarTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DisposeTest1()
        {
            Assert.Fail();
        }
    }
}
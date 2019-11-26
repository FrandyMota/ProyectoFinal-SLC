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
    public class AnalisisBLLTests
    {
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
    }
}
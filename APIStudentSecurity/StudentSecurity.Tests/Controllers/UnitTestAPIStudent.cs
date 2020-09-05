using System;
using APIStudentSecurity.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudentSecurity.Tests.Controllers
{
    [TestClass]
    public class UnitTestAPIStudent
    {
        [TestMethod]
        public void TestGetStudent()
        {
            //arrange
            StudentsController studentsController = new StudentsController();
            //act
            var listaEstudiantes = studentsController.GetStudents();
            //assert
            Assert.IsNotNull(listaEstudiantes);
        }
    }
}

using crudoperationentity.Controllers;
using crudoperationentity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;



namespace UnitTestProject
{
    public class UnitTest1
    {

        [TestClass]
        public class EmployeeControllerTest
        {

            [TestMethod]
            
            public void Index()
            {

                // Arrange
                EmployeeController controller = new EmployeeController();
                // Act
                IActionResult result = controller.Index() as IActionResult;
                // Assert
                Assert.IsNotNull(result);
               
                
            }

            //[TestMethod]
            //public void Create()
            //{

            //    EmployeeController controller = new EmployeeController();

            //    IActionResult result = controller.Create(); /*as ViewResult;*/
            //    Assert.AreEqual("Your application description page.", result);
            //}

            //[TestMethod]
            //public void Delete()
            //{
            //    EmployeeController controller = new EmployeeController();
            //    ViewResult result = controller.Delete() as ViewResult;
            //}
        }
    }
}

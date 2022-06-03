using crudoperationentity.Controllers;
using crudoperationentity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace projecttest
{
    [TestClass]
    public class UnitTest1
    {
        public readonly ApplicationContext dbcontext;
        DbContextOptions<ApplicationContext> options;

        public UnitTest1()
        {
            options = new DbContextOptions<ApplicationContext>();
            dbcontext = new ApplicationContext(options);
        }

        [TestMethod]
        public void Index()
        {
          
                // Arrange
                EmployeeController controller = new EmployeeController(dbcontext);
            // Act
            ViewResult result = controller.Index();
                // Assert
                Assert.AreEqual("Your description page.", result.ViewData["sms"]);
        }

        [TestMethod]
        public void Create()
        {

            // Arrange
            EmployeeController controller = new EmployeeController(dbcontext);
            // Act
            ViewResult result = controller.Create();
            // Assert
            Assert.AreEqual("Your page.", result.ViewData["sms"]);



        }
    }
}

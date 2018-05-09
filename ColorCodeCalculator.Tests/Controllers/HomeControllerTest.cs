using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ColorCodeCalculator.Controllers;
using ColorCodeCalculator.BLogic;

namespace ColorCodeCalculator.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        int colBands1 = 2;
        int colBands2 = 3;
        float colBands3 = 10;
        float colBands4 = 2;
        float expectedResult = 230f;
      
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void IndexPost()
        {
            // Arrange           
            ResistorOhmCalculator obj = new BLogic.ResistorOhmCalculator();

            //Act
            float result = obj.CalculateOhmValue(colBands1, colBands2, colBands3, colBands4);

            // Assert
            Assert.AreEqual(expectedResult, result);

        }       

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

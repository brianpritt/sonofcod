using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using sonOfCod.Controllers;
using sonOfCod.Models;
using Xunit;

namespace sonOfCod.Tests
{
    public class HomeControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
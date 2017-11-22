using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using aspnet_core2_cicd_docker.Controllers;
using Moq;

namespace aspnet_core2_cicd_docker_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            //var mockRepo = new Mock<ITestModel>();
            //mockRepo.Setup(repo => repo.ListAsync()).Returns(Task.FromResult(GetTestModel()));
            //var controller = new HomeController(mockRepo.Object);

            //// Act
            //var result = await controller.Index();

            //// Assert
            //var viewResult = Assert.IsType<ViewResult>(result);
            //var model = Assert.IsAssignableFrom<IEnumerable<TestViewModel>>(
            //    viewResult.ViewData.Model);
            //Assert.Equal(2, model.Count());

            var controller = new HomeController();
            var response = ((Microsoft.AspNetCore.Mvc.JsonResult)controller.AWS()).Value??"".ToString();
            Assert.Equal("Hello AWS!", response);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XamarinDemo.MVVM.ViewModels;

namespace XamarinDemo.UnitTests
{
    [TestClass]
    public class PersonViewModelTests
    {
        [TestMethod]
        public void SayHelloMethod()
        {
            // Arrange
            var personViewModel = new PersonViewModel();
            personViewModel.Name = "Hassen";

            // Act
            personViewModel.SayHelloCommand.Execute(null);

            // Assert
            Assert.AreEqual(
                "Hello Hassen", 
                personViewModel.HelloMessage,
                "HelloMessage is not Hello Hassen");
        }
        [TestMethod]
        public void SayHelloMethod2()
        {
            // Arrange
            var personViewModel = new PersonViewModel();
            personViewModel.Name = "Hassen";

            // Act
            personViewModel.SayHelloCommand.Execute(null);

            // Assert
            Assert.AreNotEqual(
                "Hello Hasse",
                personViewModel.HelloMessage,
                "HelloMessage is not Hello Hassen");
        }
    }
}

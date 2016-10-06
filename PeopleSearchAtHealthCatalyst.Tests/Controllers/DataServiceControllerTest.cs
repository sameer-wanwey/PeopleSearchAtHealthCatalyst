using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleSearchAtHealthCatalyst.Controllers;
using PeopleSearchAtHealthCatalyst.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PeopleSearchAtHealthCatalyst.Tests.Controllers
{
    [TestClass]
    class DataServiceControllerTest
    {

        [TestMethod]
        public void GetPeople()
        {
            // Arrange
            DataServiceController controller = new DataServiceController(new PersonRepository());

            // Act
            ActionResult result = controller.GetPeople() as ActionResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void SearchPerson()
        {
            // Arrange
            DataServiceController controller = new DataServiceController(new PersonRepository());

            // Act
            ActionResult result = controller.SearchPerson("Sameer") as ActionResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

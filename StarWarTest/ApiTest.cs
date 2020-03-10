using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarWarApi.Controllers;
using StarWarApi.Models;
using System.Collections.Generic;

namespace StarWarTest
{
    [TestClass]
    public class ApiTest
    {
        [TestMethod]
        public void GetLongestCrawl_ShouldReturnLongestCrawl()
        {
            var controller = new FilmsController();
            string result = controller.getLongestCrawl();
            Assert.AreEqual("A New Hope", result);
        }

        [TestMethod]
        public void GetLongestCrawl_CheckNullLongestCrawl()
        {
            var controller = new FilmsController();
            string result = controller.getLongestCrawl();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetMostActedPerson_ShouldReturnMostActedPerson()
        {
            var controller = new PersonsController();
            string result = controller.getMostActedPerson();
            Assert.AreEqual("C-3P0", result);
        }

        [TestMethod]
        public void GetMostActedPerson_CheckNullGetMostActedPerson()
        {
            var controller = new PersonsController();
            string result = controller.getMostActedPerson();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetMostNumberOfSpecies_ShouldReturnMostNumberOfSpecies()
        {
            var controller = new SpeciesController();
            List<SpeciesModel> result = controller.getMostNumberOfSpecies();
            Assert.IsTrue(result.Count>0);
        }

        [TestMethod]
        public void GetMostNumberOfSpecies_CheckNullMostNumberOfSpecies()
        {
            var controller = new PersonsController();
            string result = controller.getMostActedPerson();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetLargestNumberOfVechiclePilots_ShouldReturnLargestNumberOfVechiclePilots()
        {
            var controller = new VechicleController();
            List<PilotsModel> result = controller.getLargestNumberOfVechiclePilots();
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void GetLargestNumberOfVechiclePilots_CheckNullGetLargestNumberOfVechiclePilots()
        {
            var controller = new VechicleController();
            List<PilotsModel> result = controller.getLargestNumberOfVechiclePilots();
            Assert.IsNotNull(result);
        }
    }
}

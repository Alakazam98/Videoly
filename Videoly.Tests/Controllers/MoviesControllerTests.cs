using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using Videoly.Controllers;
using System.Web.Mvc;
using Moq;
using Videoly.Interfaces;

namespace Videoly.Tests.Controllers
{
    /// <summary>
    /// Opis podsumowujący elementu MoviesControllerTests
    /// </summary>
    [TestFixture]
    public class MoviesControllerTests
    {
        
       

        #region Dodatkowe atrybuty testu
        //
        // Można użyć następujących dodatkowych atrybutów w trakcie pisania testów:
        //
        // Użyj ClassInitialize do uruchomienia kodu przed uruchomieniem pierwszego testu w klasie
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Użyj ClassCleanup do uruchomienia kodu po wykonaniu wszystkich testów w klasie
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Użyj TestInitialize do uruchomienia kodu przed uruchomieniem każdego testu 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Użyj TestCleanup do uruchomienia kodu po wykonaniu każdego testu
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [Test]
        public void New_Returns_ActionResult()
        {
            MoviesController controller = new MoviesController();

            var result = controller.New() as ViewResult;

            Assert.That(result.ViewName, Is.EqualTo("New"));

        }
       
    }
}

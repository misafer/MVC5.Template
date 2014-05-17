using NUnit.Framework;
using System.Linq;
using System.Web.Mvc;
using Template.Data.Core;
using Template.Objects;
using Template.Services;
using Template.Tests.Data;

namespace Template.Tests.Unit.Services
{
    [TestFixture]
    public class AkkountsServiceTests
    {
        private AkkountsService service;
        private Context context;

        [SetUp]
        public void SetUp()
        {
            context = new TestingContext();
            service = new AkkountsService(new UnitOfWork(context));
            service.ModelState = new ModelStateDictionary();

            TearDownData();
            SetUpData();
        }

        [TearDown]
        public void TearDown()
        {
            service.Dispose();
            context.Dispose();
        }

		// TODO: Add service tests

        #region Test helpers

        private void SetUpData()
        {
            // TODO: Add service tests data set up

            context.SaveChanges();
        }
        private void TearDownData()
        {
            // TODO: Add service tests data tear down

            context.SaveChanges();
        }

        #endregion
    }
}

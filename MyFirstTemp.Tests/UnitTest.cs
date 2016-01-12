using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstTemp.Core.Models;
using MyFirstTemp.Core.Services;
using MyFirstTemp.Tests.Helpers;

namespace MyFirstTemp.Tests
{
    [TestClass]
    public sealed class UnitTest
    {
        [TestMethod]
        [TestCategory("Unit")]
        [Timeout(30000)]
        public void DoSomething()
        {
            try
            {
                var model = new MyModel();
                var repository = new FakeRepository();
                repository.Add(model);

                var service = new MyService(repository);
                var result = service.DoSomething();

                Trace.WriteLine(result);
                Assert.AreEqual(2, result);

                var data = repository.Get();

                Assert.IsNotNull(data);
                Assert.IsTrue(data.Any());
                Assert.AreEqual(2, data.Count());
            }
            catch (Exception exception)
            {
                Trace.WriteLine(exception);

                Assert.Fail(exception.Message);
            }
        }
    }
}

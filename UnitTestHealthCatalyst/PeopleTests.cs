using Autofac.Extras.Moq;
using System;
using Xunit;
using HealthCatalyst.Models;
using HealthCatalyst.Controllers;
using System.Collections.Generic;
using Moq;
using Moq.Protected;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace UnitTestHealthCatalyst
{
    public class PeopleTests
    {
        [Fact]
        public void GetPeople_Test()
        {
            var mockInfo = new Mock<HealthCatalystDBContext>();
            var Person = new Person(mockInfo.Object);
            mockInfo.SetupAllProperties();         

            throw new NotImplementedException();
        }
    }
}

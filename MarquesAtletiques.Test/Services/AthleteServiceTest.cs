using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RaulLorca.MarquesAtletiques.Model;
using RaulLorca.MarquesAtletiques.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaulLorca.MarquesAtletiques.Test.Services
{
    [TestClass]
    public class AthleteServiceTest
    {
        private IAthleteService _service;
        Mock<IContext> _mockContext;
        Mock<DbSet<Athlete>> _mockSet;
        IQueryable<Athlete> listAthlete;

        [TestInitialize]
        public void Initialize()
        {
            listAthlete = new List<Athlete>
            {
                new Athlete { Id = 1, Name = "Raul", BirthYear = 1967, Genre = Genre.Male },
                new Athlete { Id = 2, Name = "Montse", BirthYear = 1968, Genre = Genre.Female },
                new Athlete { Id = 3, Name = "Adria", BirthYear = 1995, Genre = Genre.Male },
                new Athlete { Id = 4, Name = "Xenia", BirthYear = 2003, Genre = Genre.Female }
            }.AsQueryable();

            _mockSet = new Mock<DbSet<Athlete>>();
            _mockSet.As<IQueryable<Athlete>>().Setup(x => x.Provider).Returns(listAthlete.Provider);
            _mockSet.As<IQueryable<Athlete>>().Setup(m => m.Expression).Returns(listAthlete.Expression);
            _mockSet.As<IQueryable<Athlete>>().Setup(m => m.ElementType).Returns(listAthlete.ElementType);
            _mockSet.As<IQueryable<Athlete>>().Setup(m => m.GetEnumerator()).Returns(listAthlete.GetEnumerator());

            _mockContext = new Mock<IContext>();
            _mockContext.Setup(c => c.Set<Athlete>()).Returns(_mockSet.Object);
            _mockContext.Setup(c => c.Athletes).Returns(_mockSet.Object);

            _service = new AthleteService(_mockContext.Object);
        }

        [TestMethod]
        public void Athlete_GetAll()
        {
            var results = _service.GetAll().ToList() as List<Athlete>;

            Assert.IsNotNull(results);
            Assert.AreEqual(4, results.Count);
        }

        [TestMethod]
        public void Can_Add_Athlete()
        {
            int id = 1;
            var athlete = new Athlete
            {
                BirthYear = 1990,
                Genre = Genre.Male,
                Name = "Name Athlete"
            };

             _mockSet.Setup(m => m.Add(athlete)).Returns((Athlete e) =>
             {
                 e.Id = id;
                 return e;
             });

            _service.Create(athlete);

            Assert.AreEqual(id, athlete.Id);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once());

        }

        [TestMethod]
        public void Can_Update_Athlete()
        {
            var athlete = new Athlete
            {
                BirthYear = 1990,
                Genre = Genre.Male,
                Name = "Name Athlete"
            };

            
            

            _service.Update(athlete);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once());

        }

    }
}

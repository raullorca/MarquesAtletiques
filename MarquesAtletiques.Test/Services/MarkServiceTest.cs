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
    public class MarkServiceTest
    {
        private IMarkService _service;
        Mock<IContext> _mockContext;
        Mock<DbSet<Mark>> _mockSetMark;
        IQueryable<Mark> _listMark;

        [TestInitialize]
        public void Initialize()
        {
            var athlete = GetAthlete(2000, Genre.Male, 1, "Ath 1");
            var trial = GetTrial(1, Measurement.Points, "Trial 1", 1);
            var markAthlete = GetMarkAthlete(athlete, null, 1);
            var markAthletes = new List<MarkAthlete> { markAthlete };
            var mark = GetMark(null, DateTime.Today, 1, markAthletes, null, "town", Track.Indoor, trial, 100m);
            
            _listMark = new List<Mark>
            {
                mark
            }.AsQueryable();

            _mockSetMark = new Mock<DbSet<Mark>>();
            _mockSetMark.As<IQueryable<Mark>>().Setup(x => x.Provider).Returns(_listMark.Provider);
            _mockSetMark.As<IQueryable<Mark>>().Setup(m => m.Expression).Returns(_listMark.Expression);
            _mockSetMark.As<IQueryable<Mark>>().Setup(m => m.ElementType).Returns(_listMark.ElementType);
            _mockSetMark.As<IQueryable<Mark>>().Setup(m => m.GetEnumerator()).Returns(_listMark.GetEnumerator());

            _mockContext = new Mock<IContext>();
            _mockContext.Setup(c => c.Set<Mark>()).Returns(_mockSetMark.Object);
            _mockContext.Setup(c => c.Marks).Returns(_mockSetMark.Object);

            _service = new MarkService(_mockContext.Object);
        }


        //----------------------------------------------------
        //----------------------------------------------------
        //----------------------------------------------------

        private Mark GetMark(string comments,
            DateTime date,
            int id,
            ICollection<MarkAthlete> markAthletes,
            string receipt,
            string town,
            Track track,
            Trial trial,
            decimal value)
        {
            return new Mark
            {
                Comments = comments,
                Date = date,
                Id = id,
                MarkAthletes = markAthletes,
                Receipt = receipt,
                Town = town,
                Track = track,
                Trial = trial,
                TrialId = trial.Id,
                Value = value
            };
        }

        private MarkAthlete GetMarkAthlete(Athlete athlete, Mark mark, int position)
        {
            return new MarkAthlete
            {
                Athlete = athlete,
                AthleteId = athlete.Id,
                Mark = mark,
                MarkId = mark.Id,
                Position = position
            };
        }

        private Athlete GetAthlete(int birthYear, Genre genre, int id, string name)
        {
            return new Athlete
            {
                BirthYear = birthYear,
                Genre = genre,
                Id = id,
                Name = name
            };
        }

        private Trial GetTrial(int id, Measurement measurement, string name, int quantityAthletes)
        {
            return new Trial
            {
                Id = id,
                Measurement = measurement,
                Name = name,
                QuantityAthletes = quantityAthletes
            };
        }

    }

}

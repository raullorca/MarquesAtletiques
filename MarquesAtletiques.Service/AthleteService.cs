using RaulLorca.MarquesAtletiques.Model;
using System.Linq;

namespace RaulLorca.MarquesAtletiques.Service
{
    public interface IAthleteService: IEntityService<Athlete>
    {
        Athlete GetById(int id);
    }

    public class AthleteService : EntityService<Athlete>, IAthleteService
    {
        public AthleteService(IContext context) : base(context) { }

        public Athlete GetById(int id)
        {
            return _dbset.FirstOrDefault(x => x.Id == id);
        }

    }
}

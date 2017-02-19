using RaulLorca.MarquesAtletiques.Model;
using System.Linq;

namespace RaulLorca.MarquesAtletiques.Service
{
    public interface ITrialService : IEntityService<Trial>
    {
        Trial GetById(int id);
    }

    public class TrialService : EntityService<Trial>, ITrialService
    {
        public TrialService(IContext context) : base(context)
        {
        }

        public Trial GetById(int id)
        {
            return _dbset.FirstOrDefault(x => x.Id == id);
        }
    }
}

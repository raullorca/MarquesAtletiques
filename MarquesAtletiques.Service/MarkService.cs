using RaulLorca.MarquesAtletiques.Model;
using System.Linq;

namespace RaulLorca.MarquesAtletiques.Service
{
    public interface IMarkService : IEntityService<Mark>
    {
        Mark GetById(int id);
    }

    public class MarkService : EntityService<Mark>, IMarkService
    {
        public MarkService(IContext context) : base(context)
        {
        }

        public Mark GetById(int id)
        {
            return _dbset.FirstOrDefault(x => x.Id == id);
        }




    }
}

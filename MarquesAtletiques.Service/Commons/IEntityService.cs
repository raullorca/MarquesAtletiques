using RaulLorca.MarquesAtletiques.Model;
using System.Collections.Generic;

namespace RaulLorca.MarquesAtletiques.Service
{
    public interface IEntityService<T> : IService where T : BaseEntity
    {
        void Create(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void SetEntityStateModified(T entity);
    }
}

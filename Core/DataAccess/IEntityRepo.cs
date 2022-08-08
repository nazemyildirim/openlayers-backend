using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


namespace Core.DataAccess
{
    
    public interface IEntityRepo<Map> where Map:class,IEntity,new()
    {
        Map Get(Expression<Func<Map, bool>> filter);
        IList<Map> GetList(Expression<Func<Map, bool>> filter = null);

        void Add(Map entity);

        void Update(Map entity);

        void Delete(Map entity);

           

    }
}

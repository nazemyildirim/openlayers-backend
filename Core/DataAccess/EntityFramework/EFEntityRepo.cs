using Core.DataAccess;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Text;

namespace Core.EntityFramework
{
    public class EFEntityRepo<Map, Context> : IEntityRepo<Map>
    where Map : class, IEntity, new()
        where Context : DbContext, new()
    {
        public void Add(Map entity)
        {
            throw new NotImplementedException();
        }

       

        public void Delete(Map entity)
        {
            throw new NotImplementedException();
        }

       

        

        public Map Get(Expression<Func<Map, bool>> filter)
        {
            throw new NotImplementedException();
        }

      

        public IList<Map> GetList(Expression<Func<Map, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

       
        public void Update(Map entity)
        {
            throw new NotImplementedException();
        }
    }





}


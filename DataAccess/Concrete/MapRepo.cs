using DataAccess.Abstract;
using DataAccess.Migrations;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using Entity;
using System.Linq;


namespace DataAccess.Concrete
{
    public class MapRepo : IMapRepo
    {
        public Map CreateMap(Map Map)
        {
            using (var Context = new Context())
            {
                Context.Map.Add(Map);
                Context.SaveChanges();
                return Map;

            }
        }

        public Map GetMapByID(int ID)
        {
            using (var Context = new Context())
            {
                return Context.Map.Find(ID);
            }

        }

        public void DeleteMap(int ID)
        {
            using (var Context = new Context())
            {
                var DeleteThis = GetMapByID(ID);
                Context.Map.Remove(DeleteThis);
                Context.SaveChanges();

            }
        }

        public List<Map> GetAllMaps()
        {
            using (var Context = new Context())
            {
                return Context.Map.ToList();

            }
        }

     
        public Map UpdateMap(Map Map)
        {
            using (var Context = new Context())
            {
                Context.Map.Update(Map);
                Context.SaveChanges();
                return Map;

            }
        }
    }
}

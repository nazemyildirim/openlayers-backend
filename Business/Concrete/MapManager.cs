using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Migrations;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MapManager : IMapService
    {
        private IMapRepo mapRepo;
        public MapManager(IMapRepo mapRepo)
        {
            this.mapRepo = mapRepo;
        }

            public Map CreateMap(Map Map)
        {
            return mapRepo.CreateMap(Map);
        }

        public void DeleteMap(int ID)
        {
            mapRepo.DeleteMap(ID);
        }

        public List<Map> GetAllMaps()
        {
            return mapRepo.GetAllMaps();
        }

        public Map GetMapByID(int ID)
        {
            return mapRepo.GetMapByID(ID);
        }

        public Map UpdateMap(Map Map)
        {
            return mapRepo.UpdateMap(Map);
        }
    }
}

using DataAccess.Migrations;
using System;
using System.Collections.Generic;
using System.Text;
using Entity;


namespace Business.Abstract
{
   public interface IMapService
    {
        List<Map> GetAllMaps();

        Map GetMapByID(int ID);

        Map CreateMap(Map Map);

        Map UpdateMap(Map Map);

        void DeleteMap(int ID);

    }
}

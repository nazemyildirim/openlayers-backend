using DataAccess.Migrations;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IMapRepo
    {
        List<Map> GetAllMaps();

        Map GetMapByID(int ID);

        Map CreateMap(Map Map);

        Map UpdateMap(Map Map);

        void DeleteMap(int ID);





    }
}

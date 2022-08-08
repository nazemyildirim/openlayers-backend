using Business.Abstract;
using Business.Concrete;
using DataAccess;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication36.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapController : ControllerBase
    {
        private IMapService mapService;
        public MapController(IMapService mapService)
        {
            this.mapService = mapService;    
        }
        [HttpGet]
        public IActionResult Get()
        {
            var Map = mapService.GetAllMaps();
            return Ok(Map);
        }

        [HttpGet("{ID}")]
        public IActionResult Get(int ID)
        {
            var Map = mapService.GetMapByID(ID);
            if(Map!=null)
            {
                return Ok(Map);
            } return NotFound();
        }


        [HttpPost]

        public IActionResult Post([FromBody]Map Map)
        {
            var createdMap = mapService.CreateMap(Map);
            return CreatedAtAction("Get", new { ID = createdMap.ID }, createdMap);
        }

        [HttpPut]
        public IActionResult Put([FromBody]Map Map)
        {
            if(mapService.GetMapByID(Map.ID)!=null)
            {
                return Ok(mapService.UpdateMap(Map));
            }
            return NotFound();
        }


        [HttpDelete("{ID}")]
        public IActionResult Delete(int ID)
        {
            if (mapService.GetMapByID(ID)!= null)
            {
                mapService.DeleteMap(ID);
                return Ok();

            }
            return NotFound();
        }

    }
}

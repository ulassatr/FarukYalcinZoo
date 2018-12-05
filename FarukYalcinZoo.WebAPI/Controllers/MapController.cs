using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarukYalcinZoo.DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FarukYalcinZoo.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MapController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            using (FarukYalcinZooContext context = new FarukYalcinZooContext())
            {
                var res = context.Maps.ToList();

                if (res.Count > 0)
                {
                    return Ok(res);
                }
                else
                {
                    return NotFound("malesef bulunamadı");
                }


            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult GetMapById(int id)
        {
            using (FarukYalcinZooContext context = new FarukYalcinZooContext())
            {
                var res = context.Maps.FirstOrDefault(x => x.Id == id);

                if (res != null)
                {
                    return Ok(res);
                }
                else
                {
                    return NotFound("malesef bulunamadı");
                }


            }
        }
    }
}
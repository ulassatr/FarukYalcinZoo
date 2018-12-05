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
    public class AnnouncementController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            using (FarukYalcinZooContext context = new FarukYalcinZooContext())
            {
                var res = context.Announcements.ToList();

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
        public ActionResult GetAnnoById(int id)
        {
            using (FarukYalcinZooContext context = new FarukYalcinZooContext())
            {
                var res = context.Announcements.FirstOrDefault(x => x.Id == id);

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
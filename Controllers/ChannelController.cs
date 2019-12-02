using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeSheet.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TimeSheet.Controllers
{
    public class ChannelController : Controller
    {
        private readonly TimeSheetDbContext _dbcontext;

        public ChannelController(TimeSheetDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        public JsonResult GetAllData()
        {
            var jsonValues = Json(_dbcontext.Channels.ToList());
            return jsonValues;
        }


        [HttpPost]
        public IActionResult DeleteRecord([FromBody] tmpValues rs)
        {

            var myActivity = (from c in _dbcontext.Channels
                              where c.Id == Convert.ToInt32(rs.id)
                              select c).FirstOrDefault();

            _dbcontext.Channels.Remove(myActivity);
            _dbcontext.SaveChanges();

            return Json(new { msg = "Successfully added " });

        }

        [HttpPost("SaveChannel")]
        public IActionResult SaveChannel([FromBody] Channel rs)

        {
            int tmpID = System.Convert.ToInt32(rs.Id.ToString());
            var dbStudent = _dbcontext.Channels.Where(s => s.Id == System.Convert.ToInt32(tmpID)).FirstOrDefault();


            if (rs != null)
            {
                if (rs.Id == 0)
                {
                    _dbcontext.Add(rs);
                }
                else
                {
                    dbStudent.ChannelName = rs.ChannelName;
                }

                _dbcontext.SaveChanges();
                return Json(new { msg = "Successfully added " });
            }
            else
            {
                return Json(new { msg = "Fail added " });
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeSheet.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TimeSheet.Controllers
{
    public class ActivitiesController : Controller
    {

        private readonly TimeSheetDbContext _conntext;

        public ActivitiesController(TimeSheetDbContext context)
        {
            _conntext = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        //get data to show on scfreen
        public JsonResult GetAllData()
        {
            var jsonValues = Json(_conntext.Acitivities.ToList());
            return jsonValues;
        }

         
        [HttpPost]
        public IActionResult DeleteRecord([FromBody] tmpValues rs)
        {

                var myActivity = (from c in _conntext.Acitivities
                                  where c.Id == Convert.ToInt32(rs.id)
                                  select c).FirstOrDefault();

            _conntext.Acitivities.Remove(myActivity);
            _conntext.SaveChanges();

            return Json(new { msg = "Successfully added " });

        }



        [HttpPost("SaveData")]
        public IActionResult SaveData([FromBody] Acitivity rs)

        {
            int tmpID = System.Convert.ToInt32(rs.Id.ToString());
            var dbStudent = _conntext.Acitivities.Where(s => s.Id == System.Convert.ToInt32(tmpID)).FirstOrDefault();


            if (rs != null)
            {
                if (rs.Id == 0)
                {
                    _conntext.Add(rs);
                }
                else
                {
                    dbStudent.ActivityName = rs.ActivityName;
                }

                _conntext.SaveChanges();
                return Json(new { msg = "Successfully added " });
            }
            else
            {
                return Json(new { msg = "Fail added " });
            }
        }
    }
}

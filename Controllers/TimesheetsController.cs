using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeSheet.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TimeSheet.Controllers
{
    public class TimesheetsController : Controller
    {

        private readonly TimeSheetDbContext _dbcontext;

        public TimesheetsController(TimeSheetDbContext dbcontext)
        {
            _dbcontext = dbcontext; 
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetEvents()
        {
            var timeSheetdb = (from timesheet in _dbcontext.TaskEvents
                               join project in _dbcontext.Projects on timesheet.ProjectId equals project.Id
                               select new
                               {
                                   eventId = timesheet.Id,
                                   projectCode = project.ProjectCode,
                                   DateStart = timesheet.StartDate,
                                   projectName = project.Descriptions,
                                   endDate = timesheet.EndDate
                               }).ToList();
            return Json(timeSheetdb);
        }

        public JsonResult getProjectType()
        {
            var projectType = Json(_dbcontext.Jobtypes.ToList());
            return projectType;
        }

        /*====== for fillter project type ---*/

        [HttpPost]
        public IActionResult getProjectDetail([FromBody] tmpValues rs)
        {
            var result = (from projects in _dbcontext.Projects where projects.ProjectTypeId.Equals(rs.id) select projects).ToList();
            return Json(result);
        }

        public JsonResult getActivities()
        {
            var activitiesdb = Json(_dbcontext.Acitivities.ToList());
            return activitiesdb;
        }

        [HttpPost("SaveTimesheet")]
        public IActionResult SaveTimesheet([FromBody] TaskEvent rs)

        {
            int tmpID = System.Convert.ToInt32(rs.Id.ToString());
            var dbproject = _dbcontext.TaskEvents.Where(s => s.Id == System.Convert.ToInt32(tmpID)).FirstOrDefault();

           

            if (rs != null)
            {
                if (rs.Id == 0)
                {
                    _dbcontext.Add(rs);
                }
                else
                {
                  //  dbproject.Descriptions = rs.Descriptions;
                  //  dbproject.ProjectTypeId = rs.ProjectTypeId;
                  //  dbproject.ChannelId = rs.ChannelId;
                  //  dbproject.DepartmentId = rs.DepartmentId;
                }

                _dbcontext.SaveChanges();
                return Json(new { msg = "done" });
            }
            else
            {
                return Json(new { msg = "Fail added " });
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeSheet.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TimeSheet.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly TimeSheetDbContext _dbcontext;

        public ProjectsController(TimeSheetDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // to get data for show on data table index views.
        public JsonResult GetAllData()
        {
            var dbProject = (from project in _dbcontext.Projects
                             join tmlchannel in _dbcontext.Channels on project.ChannelId equals tmlchannel.Id
                             join tmldepartment in _dbcontext.Departments on project.DepartmentId equals tmldepartment.Id
                             join tmljobtype in _dbcontext.Jobtypes on project.ProjectTypeId equals tmljobtype.Id
                             select new
                             {
                                     projectId = project.Id,
                                     projectCode = project.ProjectCode,
                                     projectrefrence = project.ReferenceNo,
                                     projectDescription = project.Descriptions,
                                     projectType = tmljobtype.Descriptions,
                                     ChannelsName = tmlchannel.ChannelName,
                                     departmentName = tmldepartment.DepartmentName
                             }).ToList();
            var jsonValues = Json(dbProject);
            return jsonValues;
        }

        // to poppulate department combobox
        public JsonResult GetDepartment()
        {
            var jsonValue = Json(_dbcontext.Departments.ToList());
            return jsonValue;
        }

        //to populate channel commbobox
        public JsonResult GetChannel()
        {
            var jsonValue = Json(_dbcontext.Channels.ToList());
            return jsonValue;
        }

        //to populate jobtype combobox
        public JsonResult GetJobType()
        {
            var jsonvalue = Json(_dbcontext.Jobtypes.ToList());
            return jsonvalue;
        }

        // to Delete records 
        [HttpPost]
        public IActionResult DeleteRecord([FromBody] tmpValues rs)
        {
            var project = (from c in _dbcontext.Projects
                           where c.Id == Convert.ToInt32(rs.id)
                           select c).FirstOrDefault();

            _dbcontext.Projects.Remove(project);
            _dbcontext.SaveChanges();

            return Json(new { msg = "Successfully added " });
        }

        // to save data and update data to database 

        [HttpPost("SaveProjcts")]
        public IActionResult SavePojects([FromBody] Project rs)

        {
            int tmpID = System.Convert.ToInt32(rs.Id.ToString());
            var dbproject = _dbcontext.Projects.Where(s => s.Id == System.Convert.ToInt32(tmpID)).FirstOrDefault();

            if (rs != null)
            {
                if (rs.Id == 0)
                {
                    _dbcontext.Add(rs);
                }
                else
                {
                    dbproject.Descriptions = rs.Descriptions;
                    dbproject.ProjectTypeId = rs.ProjectTypeId;
                    dbproject.ChannelId = rs.ChannelId;
                    dbproject.DepartmentId = rs.DepartmentId;
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

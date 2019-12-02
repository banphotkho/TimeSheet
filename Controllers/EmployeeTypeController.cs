using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeSheet.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TimeSheet.Controllers
{
    public class EmployeeTypeController : Controller
    {
		private readonly TimeSheetDbContext _dbcontext;

		public EmployeeTypeController(TimeSheetDbContext dbcontext)
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
			var jsonValues = Json(_dbcontext.EmployeeTypes.ToList());
			return jsonValues;
		}


		[HttpPost]
		public IActionResult DeleteRecord([FromBody] tmpValues rs)
		{

			var employee = (from c in _dbcontext.EmployeeTypes
							  where c.Id == Convert.ToInt32(rs.id)
							  select c).FirstOrDefault();

			_dbcontext.EmployeeTypes.Remove(employee);
			_dbcontext.SaveChanges();

			return Json(new { msg = "Successfully added " });

		}

		[HttpPost("SaveEmpType")]
		public IActionResult SaveEmpType([FromBody] EmployeeType rs)

		{
			int tmpID = System.Convert.ToInt32(rs.Id.ToString());
			var dbStudent = _dbcontext.EmployeeTypes.Where(s => s.Id == System.Convert.ToInt32(tmpID)).FirstOrDefault();


			if (rs != null)
			{
				if (rs.Id == 0)
				{
					_dbcontext.Add(rs);
				}
				else
				{
					dbStudent.EmployeeTypeName = rs.EmployeeTypeName;
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

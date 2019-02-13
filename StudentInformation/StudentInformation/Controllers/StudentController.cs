using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentInformation.Models;
using StudentInformation.Repository;

namespace StudentInformation.Controllers
{


    public class StudentController : Controller
    {
       
        
        private readonly StudentRepository _information = new StudentRepository();
        public ActionResult StudentInfo()
        {
            return View();
        }

       
        public JsonResult InsertStudentInfo(List<Student> stu)
        {

            var info = _information.Insert(stu);

            return Json(info);


        }
	}
}
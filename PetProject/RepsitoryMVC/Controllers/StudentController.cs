using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using RepsitoryMVC.Repositorys;
using RepsitoryMVC.Models;

namespace RepsitoryMVC.Controllers
{
    public class StudentController : Controller
    {
        private StudentRepository _student=null;
        public StudentController()
        {
            _student = new StudentRepository();
        }
        // GET: Student
        public ActionResult Index()
        {
            var student = _student.SelectAll();
            return View(student);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            try
            {
                _student.Insert(student);
                _student.Save();
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Update(int? id)
        {
           var getStudent= _student.SelectById(id);
            return View(getStudent);
        }
        [HttpPost]
        public ActionResult Update(Student student)
        {
            try
            {
                _student.Update(student);
                _student.Save();
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var getStudent = _student.SelectById(id);
            return View(getStudent);
        }
        [HttpPost]
        public ActionResult Delete(Student student)
        {
            try
            {
                _student.Delete(student);
                _student.Save();
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }

    }
}
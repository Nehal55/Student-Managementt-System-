using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Data;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class StudentClassController : Controller

    {

        private ApplicationDbContext _db;


        public StudentClassController (ApplicationDbContext db)
        {

            _db = db;
        }

            public IActionResult Index()
        {
            return View(_db.StudentClass.ToList());
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentClass studentClass)
        {

            if (ModelState.IsValid)
            {
                _db.StudentClass.Add(studentClass);
                await _db.SaveChangesAsync();
                return RedirectToAction(actionName: nameof(Index));

            }
            return View(studentClass);
        }

        // delete option 
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentClass = _db.StudentClass.Find(id);
            if (studentClass== null)
            {
                return NotFound();
            }
            return View(studentClass);
        }

        //POST Delete Action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, StudentClass StudentClass)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (id != StudentClass.Id)
            {
                return NotFound();
            }

            var studentClass = _db.StudentClass.Find(id);
            if (studentClass == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Remove(studentClass);
                await _db.SaveChangesAsync();
                TempData["delete"] = "Product type has been deleted";
                return RedirectToAction(nameof(Index));
            }

            return View(studentClass);
        }


    }
}
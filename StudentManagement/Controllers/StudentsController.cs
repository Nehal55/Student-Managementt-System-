using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Data;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class StudentsController : Controller
    {

        private ApplicationDbContext _db;


        public StudentsController(ApplicationDbContext db)
        {

            _db = db;
        }



        public IActionResult Index()
        {
            return View(_db.Students.Include(c => c.StudentClass).ToList());
        }

        [Authorize]
        public IActionResult Create()
        {


            ViewData["ClassNameId"] = new SelectList(_db.StudentClass.ToList(), "Id", "ClassName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Students Students)
        {

            if (ModelState.IsValid)
            {


                var searchStudent = _db.Students.FirstOrDefault(c => c.Name == Students.Name);


                if (searchStudent != null)
                {


                    ViewBag.message = "This Students are already exist";
                    ViewData["ClassNameId"] = new SelectList(_db.StudentClass.ToList(), "Id", "ClassName");
                    return View(Students);
                }



                _db.Students.Add(Students);
                await _db.SaveChangesAsync();
                return RedirectToAction(actionName: nameof(Index));

            }
            return View(Students);
        }



    }
}
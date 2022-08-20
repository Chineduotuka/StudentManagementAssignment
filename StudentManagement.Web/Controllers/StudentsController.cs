using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Core.IServices;
using StudentManagement.Data;
using StudentManagement.Data.IRepositories;
using StudentManagement.Dtos.StudentDtos;
using StudentManagement.Models;

namespace StudentManagement.Web.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IStudentRepository _studentRepository;

        public StudentsController(IStudentService studentService, IStudentRepository _studentRepository)
        {
            _studentService = studentService;
            this._studentRepository = _studentRepository;

        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            return View(await _studentService.GetAllStudentsAsync());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var student = await _studentService.Details(id);
                return View(student);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return NotFound();
            }
            
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentRequestDto student)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _studentService.AddStudentAsync(student);
                    
                }
                catch (Exception)
                {
                    View(student);
                }
 
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction("Index");
            //return View(student);
        }

        // GET: Students/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            var student = await _studentRepository.GetStudentByIdAsync(id);
            
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Student student)
        {
            //[Bind("Id,Email,FirstName,LastName,FavouriteQuote,CreatedDate,LastUpdatedDate")] Student student

            if (ModelState.IsValid)
            {
                try
                {                  
                    await _studentService.EditAsync(student);
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int id)
        {         
            await _studentService.DeleteStudentAsync(id);
            return View();
        }
        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _studentService.DeleteStudentAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //private bool StudentExists(int id)
        //{
        //    return _context.Students.Any(e => e.Id == id);
        //}
    }
}

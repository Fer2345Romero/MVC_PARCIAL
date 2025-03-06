using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_PARCIAL.Db;
using MVC_PARCIAL.Models;

namespace MVC_PARCIAL.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppDbContext _dbConnection;
        public StudentsController(AppDbContext appDb)
        {
            _dbConnection = appDb;
        }

        public IActionResult Index()
        {
            List<Students> students = _dbConnection.Students.ToList();
            return View(students);
        }
        [HttpGet]
        public IActionResult UpSert(int id)
        {
            // Si el id es 0, significa que es un registro nuevo
            Students student = id == 0 ? new Students() : _dbConnection.Students.Find(id);

            if (student == null)
            {
                return NotFound(); // Manejo de error si el estudiante no existe
            }

            return View(student);
        }

        [HttpPost]
        public IActionResult UpSert(Students model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                if (model.StudentId == 0)
                {
                    _dbConnection.Students.Add(model);
                }
                else
                {
                    _dbConnection.Students.Update(model);
                }

                _dbConnection.SaveChanges();
                return RedirectToAction("Index");
            }
            catch

            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = _dbConnection.Students.Find(id);

            if (student == null)
            {
                return NotFound();
            }

            // Solo cambia el estado en lugar de eliminarlo
            student.IsActive = false;
            _dbConnection.Students.Update(student);
            _dbConnection.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}

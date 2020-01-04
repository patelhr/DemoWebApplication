using DemoWebApplication.Services.Students;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DemoWebApplication.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentsRepository _studentsRepository;
        public StudentsController(IStudentsRepository studentsRepository)
        {
            _studentsRepository = studentsRepository;
        }
        public async Task<IActionResult> StudentsList()
        {
            var students = await _studentsRepository.GetStudents();
            return View(students);
        }
    }
}
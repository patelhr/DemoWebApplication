using DemoWebApplication.Models.ApplicationClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebApplication.Services.Students
{
    public interface IStudentsRepository
    {
        Task<List<StudentsAc>> GetStudents();
    }
}

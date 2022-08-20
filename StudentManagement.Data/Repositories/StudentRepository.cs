using Microsoft.EntityFrameworkCore;
using StudentManagement.Data.IRepositories;
using StudentManagement.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Student> _db;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
            _db = _context.Students;
        }
        public async Task AddStudentAsync(Student student)
        {
            await _db.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _db.AsNoTracking().ToListAsync();
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            return await _db.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task DeleteStudentAsync(int id)
        {
            var student = await GetStudentByIdAsync(id);

            _db.Remove(student);
            await _context.SaveChangesAsync();          
        }
        public async Task<Student> Details(int id)
        {
            var student = await GetStudentByIdAsync(id);
            return student; 
        }

        public async Task EditAsync(Student student)
        {
            var CurrentStudent = _context.Students.FirstOrDefault(x => x.Id == student.Id);
            CurrentStudent.FirstName = student.FirstName;
            CurrentStudent.LastName = student.LastName;           
            CurrentStudent.FavouriteQuote = student.FavouriteQuote;
            CurrentStudent.LastUpdatedDate = System.DateTime.Now;
            CurrentStudent.CreatedDate = CurrentStudent.CreatedDate;                     
            await _context.SaveChangesAsync();          
        }

    }
}

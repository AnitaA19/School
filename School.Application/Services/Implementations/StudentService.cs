using School.Application.Services.Interfaces;
using School.Domain.Models.DTOs;

namespace School.Application.Services.Implementations
{
    public class StudentService : IStudentService
    {
        public Task<StudentDTO> AddStudentAsync(CreateStudentDTO createStudentDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task DeleteStudentAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<StudentDTO>> GetAllStudetnsAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<StudentDTO> GetStudentByIdAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStudentAsync(int id, UpdateStudentDTO updateStudentDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

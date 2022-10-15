using MongoDBTestProject.Model;

namespace MongoDBTestProject.Service
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student Get(String id);
        Student Create(Student student);
        void Update(String id, Student student);
        void Remove(String id);
    }
}

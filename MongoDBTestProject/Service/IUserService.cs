using MongoDBTestProject.Model;

namespace MongoDBTestProject.Service
{
    public interface IUserService
    {
        List<User> GetStudents();
        User Get(String id);
        User Create(User user);
        User GetUserByUsername(string username);
        void Update(String id, User user);
        void Remove(String id);
    }
}

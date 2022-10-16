using MongoDB.Driver;
using MongoDBTestProject.Model;

namespace MongoDBTestProject.Service
{
    public class UserService : IUserService
    {
        private readonly IMongoCollection<User> _user;

        public UserService(IStudentDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _user = database.GetCollection<User>(settings.UserCollectionName);
        }
        public User Create(User user)
        {
            _user.InsertOne(user);
            return user;
        }

        public User Get(string id)
        {
            return _user.Find(user => user.Id == id).FirstOrDefault();
        }

        public User GetUserByUsername(string username)
        {
            return _user.Find(user => user.Username == username).FirstOrDefault();
        }

        public List<User> GetStudents()
        {
            return _user.Find(user => true).ToList();
        }

        public void Remove(string id)
        {
            _user.DeleteOne(user => user.Id == id);
        }

        public void Update(string id, User user)
        {
            _user.ReplaceOne(user => user.Id == id, user);
        }
    }
}

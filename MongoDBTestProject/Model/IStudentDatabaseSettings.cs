namespace MongoDBTestProject.Model
{
    public interface IStudentDatabaseSettings
    {
        string StudentCollectionName { get; set; }

        string UserCollectionName { get; set; }
        string DatabaseName { get; set; } 
        string ConnectionString { get; set; }   


    }
}
